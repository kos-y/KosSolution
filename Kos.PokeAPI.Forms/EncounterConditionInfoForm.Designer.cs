namespace Kos.PokeAPI.Forms;

partial class EncounterConditionInfoForm
{
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null)) {
            components.Dispose();
        }
        base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        NameCaptionLabel = new Label();
        IdCaptionLabel = new Label();
        NamesDataGridView = new DataGridView();
        NameColumn = new DataGridViewTextBoxColumn();
        LanguageColumn = new DataGridViewTextBoxColumn();
        DetailColumn = new DataGridViewButtonColumn();
        NamesCaptionLabel = new Label();
        ValuesDataGridView = new DataGridView();
        ValuesNameColumn = new DataGridViewTextBoxColumn();
        dataGridViewButtonColumn1 = new DataGridViewButtonColumn();
        ValuesCaptionLabel = new Label();
        CloseButton = new Button();
        IdTextBox = new TextBox();
        NameTextBox = new TextBox();
        button1 = new Button();
        ((System.ComponentModel.ISupportInitialize)NamesDataGridView).BeginInit();
        ((System.ComponentModel.ISupportInitialize)ValuesDataGridView).BeginInit();
        SuspendLayout();
        // 
        // NameCaptionLabel
        // 
        NameCaptionLabel.AutoSize = true;
        NameCaptionLabel.Location = new Point(13, 45);
        NameCaptionLabel.Margin = new Padding(4, 0, 4, 0);
        NameCaptionLabel.Name = "NameCaptionLabel";
        NameCaptionLabel.Size = new Size(98, 17);
        NameCaptionLabel.TabIndex = 2;
        NameCaptionLabel.Text = "遭遇条件の名前";
        NameCaptionLabel.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // IdCaptionLabel
        // 
        IdCaptionLabel.AutoSize = true;
        IdCaptionLabel.Location = new Point(34, 15);
        IdCaptionLabel.Margin = new Padding(4, 0, 4, 0);
        IdCaptionLabel.Name = "IdCaptionLabel";
        IdCaptionLabel.Size = new Size(77, 17);
        IdCaptionLabel.TabIndex = 0;
        IdCaptionLabel.Text = "遭遇条件ID";
        IdCaptionLabel.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // NamesDataGridView
        // 
        NamesDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        NamesDataGridView.Columns.AddRange(new DataGridViewColumn[] { NameColumn, LanguageColumn, DetailColumn });
        NamesDataGridView.Location = new Point(13, 92);
        NamesDataGridView.Margin = new Padding(4, 3, 4, 3);
        NamesDataGridView.Name = "NamesDataGridView";
        NamesDataGridView.RowHeadersVisible = false;
        NamesDataGridView.Size = new Size(263, 170);
        NamesDataGridView.TabIndex = 5;
        NamesDataGridView.CellClick += NamesDataGridView_CellClick;
        NamesDataGridView.CellDoubleClick += NamesDataGridView_CellDoubleClick;
        // 
        // NameColumn
        // 
        NameColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
        NameColumn.DataPropertyName = "Text";
        NameColumn.HeaderText = "名前";
        NameColumn.Name = "NameColumn";
        NameColumn.ReadOnly = true;
        NameColumn.Width = 59;
        // 
        // LanguageColumn
        // 
        LanguageColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
        LanguageColumn.DataPropertyName = "Language";
        LanguageColumn.HeaderText = "言語";
        LanguageColumn.Name = "LanguageColumn";
        LanguageColumn.ReadOnly = true;
        LanguageColumn.Width = 59;
        // 
        // DetailColumn
        // 
        DetailColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
        DetailColumn.HeaderText = "言語";
        DetailColumn.Name = "DetailColumn";
        DetailColumn.Text = "言語";
        DetailColumn.UseColumnTextForButtonValue = true;
        DetailColumn.Width = 40;
        // 
        // NamesCaptionLabel
        // 
        NamesCaptionLabel.AutoSize = true;
        NamesCaptionLabel.Location = new Point(13, 72);
        NamesCaptionLabel.Margin = new Padding(4, 0, 4, 0);
        NamesCaptionLabel.Name = "NamesCaptionLabel";
        NamesCaptionLabel.Size = new Size(92, 17);
        NamesCaptionLabel.TabIndex = 4;
        NamesCaptionLabel.Text = "言語ごとの名前";
        NamesCaptionLabel.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // ValuesDataGridView
        // 
        ValuesDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        ValuesDataGridView.Columns.AddRange(new DataGridViewColumn[] { ValuesNameColumn, dataGridViewButtonColumn1 });
        ValuesDataGridView.Location = new Point(284, 92);
        ValuesDataGridView.Margin = new Padding(4, 3, 4, 3);
        ValuesDataGridView.Name = "ValuesDataGridView";
        ValuesDataGridView.RowHeadersVisible = false;
        ValuesDataGridView.Size = new Size(444, 170);
        ValuesDataGridView.TabIndex = 7;
        ValuesDataGridView.CellClick += ValuesDataGridView_CellClick;
        ValuesDataGridView.CellDoubleClick += ValuesDataGridView_CellDoubleClick;
        // 
        // ValuesNameColumn
        // 
        ValuesNameColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
        ValuesNameColumn.DataPropertyName = "Name";
        ValuesNameColumn.HeaderText = "条件値";
        ValuesNameColumn.Name = "ValuesNameColumn";
        ValuesNameColumn.ReadOnly = true;
        ValuesNameColumn.Width = 72;
        // 
        // dataGridViewButtonColumn1
        // 
        dataGridViewButtonColumn1.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
        dataGridViewButtonColumn1.HeaderText = "詳細";
        dataGridViewButtonColumn1.Name = "dataGridViewButtonColumn1";
        dataGridViewButtonColumn1.Text = "詳細";
        dataGridViewButtonColumn1.UseColumnTextForButtonValue = true;
        dataGridViewButtonColumn1.Width = 40;
        // 
        // ValuesCaptionLabel
        // 
        ValuesCaptionLabel.AutoSize = true;
        ValuesCaptionLabel.Location = new Point(284, 72);
        ValuesCaptionLabel.Margin = new Padding(4, 0, 4, 0);
        ValuesCaptionLabel.Name = "ValuesCaptionLabel";
        ValuesCaptionLabel.Size = new Size(47, 17);
        ValuesCaptionLabel.TabIndex = 6;
        ValuesCaptionLabel.Text = "条件値";
        ValuesCaptionLabel.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // CloseButton
        // 
        CloseButton.Location = new Point(652, 268);
        CloseButton.Margin = new Padding(4, 3, 4, 3);
        CloseButton.Name = "CloseButton";
        CloseButton.Size = new Size(76, 35);
        CloseButton.TabIndex = 9;
        CloseButton.Text = "閉じる";
        CloseButton.UseVisualStyleBackColor = true;
        CloseButton.Click += CloseButton_Click;
        // 
        // IdTextBox
        // 
        IdTextBox.Location = new Point(118, 12);
        IdTextBox.Name = "IdTextBox";
        IdTextBox.ReadOnly = true;
        IdTextBox.Size = new Size(158, 24);
        IdTextBox.TabIndex = 1;
        IdTextBox.Text = "100";
        // 
        // NameTextBox
        // 
        NameTextBox.Location = new Point(118, 42);
        NameTextBox.Name = "NameTextBox";
        NameTextBox.ReadOnly = true;
        NameTextBox.Size = new Size(158, 24);
        NameTextBox.TabIndex = 3;
        NameTextBox.Text = "story-progress";
        // 
        // button1
        // 
        button1.Location = new Point(568, 268);
        button1.Margin = new Padding(4, 3, 4, 3);
        button1.Name = "button1";
        button1.Size = new Size(76, 35);
        button1.TabIndex = 8;
        button1.Text = "プロパティ";
        button1.UseVisualStyleBackColor = true;
        button1.Click += button1_Click;
        // 
        // EncounterConditionInfoForm
        // 
        AutoScaleDimensions = new SizeF(9F, 17F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(743, 310);
        Controls.Add(button1);
        Controls.Add(NameTextBox);
        Controls.Add(IdTextBox);
        Controls.Add(CloseButton);
        Controls.Add(ValuesCaptionLabel);
        Controls.Add(ValuesDataGridView);
        Controls.Add(NamesDataGridView);
        Controls.Add(NamesCaptionLabel);
        Controls.Add(NameCaptionLabel);
        Controls.Add(IdCaptionLabel);
        Font = new Font("Meiryo UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 128);
        FormBorderStyle = FormBorderStyle.FixedSingle;
        Margin = new Padding(4, 3, 4, 3);
        MaximizeBox = false;
        Name = "EncounterConditionInfoForm";
        StartPosition = FormStartPosition.CenterParent;
        Text = "遭遇条件";
        Load += EncounterConditionInfoForm_Load;
        ((System.ComponentModel.ISupportInitialize)NamesDataGridView).EndInit();
        ((System.ComponentModel.ISupportInitialize)ValuesDataGridView).EndInit();
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion
    private Label NameCaptionLabel;
    private Label IdCaptionLabel;
    private DataGridView NamesDataGridView;
    private Label NamesCaptionLabel;
    private DataGridView ValuesDataGridView;
    private Label ValuesCaptionLabel;
    private Button CloseButton;
    private DataGridViewTextBoxColumn NameColumn;
    private DataGridViewTextBoxColumn LanguageColumn;
    private DataGridViewButtonColumn DetailColumn;
    private DataGridViewTextBoxColumn ValuesNameColumn;
    private DataGridViewButtonColumn dataGridViewButtonColumn1;
    private TextBox IdTextBox;
    private TextBox NameTextBox;
    private Button button1;
}