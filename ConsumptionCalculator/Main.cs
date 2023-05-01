using ConsumptionCalculator.Calculators;
using Microsoft.Extensions.Configuration;
using System.Windows.Forms;

namespace ConsumptionCalculator;

public partial class Main : Form
{
    private readonly List<ICalculator> _calculators = Helper.GetCalculators();
    private readonly Settings _settings;
    private ICalculator _selectedCalculator;

    public Main()
    {
        InitializeComponent();

        _settings = Program.Configuration.GetSection("config").Get<Settings>();
    }

    private void Main_Load(object sender, EventArgs e)
    {
        calculatorListBox.Items.AddRange(_calculators.Select(x => new { Name = $"{x.Category.GetEnumDisplayName()} - {x.Name}", x.Type }).ToArray());
    }

    private void calculatorListBox_SelectedIndexChanged(object sender, EventArgs e)
    {
        _selectedCalculator = _calculators.Single(x => x.Type == (CalculatorType)((sender as ListBox)!.SelectedItem as dynamic).Type);

        dataGridView.Columns.Clear();
        dataGridView.Columns.AddRange(_selectedCalculator.Components
            .Select(x =>
            new DataGridViewTextBoxColumn
            {
                HeaderText = x.GetEnumDisplayName(),
                Name = x.ToString(),
                ValueType = typeof(double),
                DefaultCellStyle = new DataGridViewCellStyle { Format = Constants.CellTextFormat }
            }).ToArray());

        foreach (var record in _selectedCalculator.Data.ToList())
        {
            int rowIndex = dataGridView.Rows.Add();

            var row = dataGridView.Rows[rowIndex];

            foreach (var item in record)
            {
                row.Cells[item.Key.ToString()].Value = item.Value;
            }
        }
    }

    private void dataGridView_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
    {
        var row = dataGridView.Rows[e.RowIndex];
        row.Cells[ComponentType.Index.ToString()].Value = _selectedCalculator.DefaultIndex;
    }

    private void dataGridView_CellValueChanged(object sender, DataGridViewCellEventArgs e)
    {
        var row = dataGridView.Rows[e.RowIndex];
        var total = (double?)1;

        foreach (var item in _selectedCalculator.Components.Where(x => x != ComponentType.Total))
        {
            total *= row.Cells[item.ToString()].Value as double? ?? (double?)0;
        }

        row.Cells[ComponentType.Total.ToString()].Value = total;
        if (total > 0)
        {
            _selectedCalculator.AddOrUpdate(e.RowIndex, _selectedCalculator.Components.ToDictionary(x => x, x => row.Cells[x.ToString()].Value as double? ?? 0));
        }
    }

    private void dataGridView_KeyUp(object sender, KeyEventArgs e)
    {
        if (e.KeyCode == Keys.Delete && dataGridView.SelectedCells.Count == 1)
        {
            var confirmResult = MessageBox.Show(Constants.DeleteConfirmationMessage,
                                     Constants.DeleteConfirmationTitle,
                                     MessageBoxButtons.YesNo);

            if (confirmResult == DialogResult.Yes)
            {
                dataGridView.Rows.RemoveAt(dataGridView.CurrentCell.RowIndex);
                _selectedCalculator.Remove(dataGridView.CurrentCell.RowIndex);
            }
        }
    }

    private void print_Click(object sender, EventArgs e)
    {
        using var sfd = new SaveFileDialog();
        var title = $"{Constants.FileTitle} - {dateTimePicker.Text}";
        sfd.FileName = title;
        sfd.Filter = "Pdf Files|*.pdf|All Files|*.*";
        if (sfd.ShowDialog() != DialogResult.OK)
        {
            return;
        }

        PdfPrinter.SavePdf(sfd.FileName, title, _settings, _calculators.Where(x => x.HasData).ToList());
    }

    private void dataGridView_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
    {
        e.Control.KeyPress -= new KeyPressEventHandler(Column_KeyPress);

        var tb = e.Control as TextBox;
        if (tb != null)
        {
            tb.KeyPress += new KeyPressEventHandler(Column_KeyPress);
        }
    }

    private void Column_KeyPress(object sender, KeyPressEventArgs e)
    {
        var decimalSepatator = Thread.CurrentThread.CurrentCulture.NumberFormat.NumberDecimalSeparator;
        var containsSeaparator = dataGridView.CurrentCell.EditedFormattedValue?.ToString()?.Contains(decimalSepatator) ?? false;
        var isValidDecimalSeparator = e.KeyChar == Convert.ToChar(decimalSepatator) && !containsSeaparator;
        if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && !isValidDecimalSeparator)
        {
            e.Handled = true;
        }
    }
}