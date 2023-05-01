namespace ConsumptionCalculator;

partial class Main
{
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }
        base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    ///  Required method for Designer support - do not modify
    ///  the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
        calculatorListBox = new ListBox();
        dataGridView = new DataGridView();
        print = new Button();
        dateTimePicker = new DateTimePicker();
        ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
        SuspendLayout();
        // 
        // calculatorListBox
        // 
        calculatorListBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
        calculatorListBox.DisplayMember = "Name";
        calculatorListBox.FormattingEnabled = true;
        calculatorListBox.ItemHeight = 25;
        calculatorListBox.Location = new Point(7, 7);
        calculatorListBox.Margin = new Padding(2);
        calculatorListBox.Name = "calculatorListBox";
        calculatorListBox.Size = new Size(310, 554);
        calculatorListBox.Sorted = true;
        calculatorListBox.TabIndex = 1;
        calculatorListBox.ValueMember = "Type";
        calculatorListBox.SelectedIndexChanged += calculatorListBox_SelectedIndexChanged;
        // 
        // dataGridView
        // 
        dataGridView.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
        dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        dataGridView.Location = new Point(378, 7);
        dataGridView.Margin = new Padding(2);
        dataGridView.Name = "dataGridView";
        dataGridView.RowHeadersWidth = 102;
        dataGridView.RowTemplate.Height = 49;
        dataGridView.Size = new Size(747, 415);
        dataGridView.TabIndex = 2;
        dataGridView.CellValueChanged += dataGridView_CellValueChanged;
        dataGridView.EditingControlShowing += dataGridView_EditingControlShowing;
        dataGridView.RowsAdded += dataGridView_RowsAdded;
        dataGridView.KeyUp += dataGridView_KeyUp;
        // 
        // print
        // 
        print.Anchor = AnchorStyles.Bottom;
        print.Location = new Point(957, 490);
        print.Margin = new Padding(2);
        print.Name = "print";
        print.Size = new Size(111, 35);
        print.TabIndex = 3;
        print.Text = "Print";
        print.UseVisualStyleBackColor = true;
        print.Click += print_Click;
        // 
        // dateTimePicker
        // 
        dateTimePicker.Anchor = AnchorStyles.Bottom;
        dateTimePicker.CustomFormat = "MM.yyyy";
        dateTimePicker.Format = DateTimePickerFormat.Custom;
        dateTimePicker.Location = new Point(749, 496);
        dateTimePicker.Margin = new Padding(2);
        dateTimePicker.Name = "dateTimePicker";
        dateTimePicker.Size = new Size(133, 31);
        dateTimePicker.TabIndex = 4;
        // 
        // Main
        // 
        AutoScaleDimensions = new SizeF(10F, 25F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(1132, 569);
        Controls.Add(dateTimePicker);
        Controls.Add(print);
        Controls.Add(dataGridView);
        Controls.Add(calculatorListBox);
        Icon = (Icon)resources.GetObject("$this.Icon");
        Margin = new Padding(2);
        Name = "Main";
        Text = "Calculator Consum";
        Load += Main_Load;
        ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
        ResumeLayout(false);
    }

    #endregion
    private ListBox calculatorListBox;
    private DataGridView dataGridView;
    private Button print;
    private DateTimePicker dateTimePicker;
}
