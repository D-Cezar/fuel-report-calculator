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
            this.calculatorListBox = new System.Windows.Forms.ListBox();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.print = new System.Windows.Forms.Button();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // calculatorListBox
            // 
            this.calculatorListBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.calculatorListBox.DisplayMember = "Name";
            this.calculatorListBox.FormattingEnabled = true;
            this.calculatorListBox.ItemHeight = 41;
            this.calculatorListBox.Location = new System.Drawing.Point(12, 12);
            this.calculatorListBox.Name = "calculatorListBox";
            this.calculatorListBox.Size = new System.Drawing.Size(525, 906);
            this.calculatorListBox.Sorted = true;
            this.calculatorListBox.TabIndex = 1;
            this.calculatorListBox.ValueMember = "Type";
            this.calculatorListBox.SelectedIndexChanged += new System.EventHandler(this.calculatorListBox_SelectedIndexChanged);
            // 
            // dataGridView
            // 
            this.dataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(642, 12);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowHeadersWidth = 102;
            this.dataGridView.RowTemplate.Height = 49;
            this.dataGridView.Size = new System.Drawing.Size(1645, 680);
            this.dataGridView.TabIndex = 2;
            this.dataGridView.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellValueChanged);
            this.dataGridView.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dataGridView_RowsAdded);
            this.dataGridView.KeyUp += new System.Windows.Forms.KeyEventHandler(this.dataGridView_KeyUp);
            // 
            // print
            // 
            this.print.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.print.Location = new System.Drawing.Point(1627, 803);
            this.print.Name = "print";
            this.print.Size = new System.Drawing.Size(188, 58);
            this.print.TabIndex = 3;
            this.print.Text = "Print";
            this.print.UseVisualStyleBackColor = true;
            this.print.Click += new System.EventHandler(this.print_Click);
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.dateTimePicker.CustomFormat = "MM.yyyy";
            this.dateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker.Location = new System.Drawing.Point(1274, 814);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(223, 47);
            this.dateTimePicker.TabIndex = 4;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(17F, 41F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2299, 933);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.print);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.calculatorListBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Main";
            this.Text = "Calculator Consum";
            this.Load += new System.EventHandler(this.Main_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);

    }

    #endregion
    private ListBox calculatorListBox;
    private DataGridView dataGridView;
    private Button print;
    private DateTimePicker dateTimePicker;
}
