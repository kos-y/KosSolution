namespace Kos.PokeAPI.Forms;

partial class ContestTypeInfoForm
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
        if (disposing && (components != null)) {
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
        NameCaptionLabel = new Label();
        IdCaptionLabel = new Label();
        BerryFlavorCaptionLabel = new Label();
        BerryFlavorDetailButton = new Button();
        NamesDataGridView = new DataGridView();
        NamesCaptionLabel = new Label();
        CloseButton = new Button();
        IdTextBox = new TextBox();
        NameTextBox = new TextBox();
        BerryFlavorTextBox = new TextBox();
        NameColumn = new DataGridViewTextBoxColumn();
        ColorColumn = new DataGridViewTextBoxColumn();
        LanguageColumn = new DataGridViewTextBoxColumn();
        DetailColumn = new DataGridViewButtonColumn();
        ((System.ComponentModel.ISupportInitialize)NamesDataGridView).BeginInit();
        SuspendLayout();
        // 
        // NameCaptionLabel
        // 
        NameCaptionLabel.AutoSize = true;
        NameCaptionLabel.Location = new Point(19, 40);
        NameCaptionLabel.Margin = new Padding(4, 0, 4, 0);
        NameCaptionLabel.Name = "NameCaptionLabel";
        NameCaptionLabel.Size = new Size(110, 17);
        NameCaptionLabel.TabIndex = 2;
        NameCaptionLabel.Text = "コンテストの種類名";
        NameCaptionLabel.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // IdCaptionLabel
        // 
        IdCaptionLabel.AutoSize = true;
        IdCaptionLabel.Location = new Point(15, 10);
        IdCaptionLabel.Margin = new Padding(4, 0, 4, 0);
        IdCaptionLabel.Name = "IdCaptionLabel";
        IdCaptionLabel.Size = new Size(114, 17);
        IdCaptionLabel.TabIndex = 0;
        IdCaptionLabel.Text = "コンテストの種類ID";
        IdCaptionLabel.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // BerryFlavorCaptionLabel
        // 
        BerryFlavorCaptionLabel.AutoSize = true;
        BerryFlavorCaptionLabel.Location = new Point(63, 70);
        BerryFlavorCaptionLabel.Margin = new Padding(4, 0, 4, 0);
        BerryFlavorCaptionLabel.Name = "BerryFlavorCaptionLabel";
        BerryFlavorCaptionLabel.Size = new Size(66, 17);
        BerryFlavorCaptionLabel.TabIndex = 4;
        BerryFlavorCaptionLabel.Text = "きのみの味";
        BerryFlavorCaptionLabel.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // BerryFlavorDetailButton
        // 
        BerryFlavorDetailButton.Location = new Point(347, 65);
        BerryFlavorDetailButton.Margin = new Padding(4, 3, 4, 3);
        BerryFlavorDetailButton.Name = "BerryFlavorDetailButton";
        BerryFlavorDetailButton.Size = new Size(51, 26);
        BerryFlavorDetailButton.TabIndex = 6;
        BerryFlavorDetailButton.Text = "詳細";
        BerryFlavorDetailButton.UseVisualStyleBackColor = true;
        BerryFlavorDetailButton.Click += BerryFlavorDetailButton_Click;
        // 
        // NamesDataGridView
        // 
        NamesDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        NamesDataGridView.Columns.AddRange(new DataGridViewColumn[] { NameColumn, ColorColumn, LanguageColumn, DetailColumn });
        NamesDataGridView.Location = new Point(150, 97);
        NamesDataGridView.Margin = new Padding(4, 3, 4, 3);
        NamesDataGridView.Name = "NamesDataGridView";
        NamesDataGridView.RowHeadersVisible = false;
        NamesDataGridView.Size = new Size(558, 170);
        NamesDataGridView.TabIndex = 8;
        NamesDataGridView.CellClick += NamesDataGridView_CellClick;
        NamesDataGridView.CellDoubleClick += NamesDataGridView_CellDoubleClick;
        // 
        // NamesCaptionLabel
        // 
        NamesCaptionLabel.AutoSize = true;
        NamesCaptionLabel.Location = new Point(37, 97);
        NamesCaptionLabel.Margin = new Padding(4, 0, 4, 0);
        NamesCaptionLabel.Name = "NamesCaptionLabel";
        NamesCaptionLabel.Size = new Size(92, 17);
        NamesCaptionLabel.TabIndex = 7;
        NamesCaptionLabel.Text = "言語ごとの名前";
        NamesCaptionLabel.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // CloseButton
        // 
        CloseButton.Location = new Point(632, 273);
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
        IdTextBox.Location = new Point(150, 7);
        IdTextBox.Name = "IdTextBox";
        IdTextBox.ReadOnly = true;
        IdTextBox.Size = new Size(190, 24);
        IdTextBox.TabIndex = 1;
        // 
        // NameTextBox
        // 
        NameTextBox.Location = new Point(150, 37);
        NameTextBox.Name = "NameTextBox";
        NameTextBox.ReadOnly = true;
        NameTextBox.Size = new Size(190, 24);
        NameTextBox.TabIndex = 3;
        // 
        // BerryFlavorTextBox
        // 
        BerryFlavorTextBox.Location = new Point(150, 67);
        BerryFlavorTextBox.Name = "BerryFlavorTextBox";
        BerryFlavorTextBox.ReadOnly = true;
        BerryFlavorTextBox.Size = new Size(190, 24);
        BerryFlavorTextBox.TabIndex = 5;
        // 
        // NameColumn
        // 
        NameColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
        NameColumn.DataPropertyName = "Name";
        NameColumn.HeaderText = "名前";
        NameColumn.Name = "NameColumn";
        NameColumn.ReadOnly = true;
        NameColumn.Width = 59;
        // 
        // ColorColumn
        // 
        ColorColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
        ColorColumn.DataPropertyName = "Color";
        ColorColumn.HeaderText = "色";
        ColorColumn.Name = "ColorColumn";
        ColorColumn.ReadOnly = true;
        ColorColumn.Width = 46;
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
        DetailColumn.HeaderText = "詳細";
        DetailColumn.Name = "DetailColumn";
        DetailColumn.Text = "詳細";
        DetailColumn.UseColumnTextForButtonValue = true;
        DetailColumn.Width = 40;
        // 
        // ContestTypeInfoForm
        // 
        AutoScaleDimensions = new SizeF(9F, 17F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(725, 316);
        Controls.Add(BerryFlavorTextBox);
        Controls.Add(NameTextBox);
        Controls.Add(IdTextBox);
        Controls.Add(CloseButton);
        Controls.Add(NamesCaptionLabel);
        Controls.Add(NamesDataGridView);
        Controls.Add(BerryFlavorDetailButton);
        Controls.Add(BerryFlavorCaptionLabel);
        Controls.Add(NameCaptionLabel);
        Controls.Add(IdCaptionLabel);
        Font = new Font("Meiryo UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 128);
        FormBorderStyle = FormBorderStyle.FixedSingle;
        Margin = new Padding(4, 3, 4, 3);
        MaximizeBox = false;
        Name = "ContestTypeInfoForm";
        StartPosition = FormStartPosition.CenterParent;
        Text = "コンテストの種類";
        Load += ContestTypeInfoForm_Load;
        ((System.ComponentModel.ISupportInitialize)NamesDataGridView).EndInit();
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion
    private Label NameCaptionLabel;
    private Label IdCaptionLabel;
    private Label BerryFlavorCaptionLabel;
    private Button BerryFlavorDetailButton;
    private DataGridView NamesDataGridView;
    private Label NamesCaptionLabel;
    private Button CloseButton;
    private DataGridViewTextBoxColumn NameColumn;
    private DataGridViewTextBoxColumn ColorColumn;
    private DataGridViewTextBoxColumn LanguageColumn;
    private DataGridViewButtonColumn DetailColumn;
    private TextBox IdTextBox;
    private TextBox NameTextBox;
    private TextBox BerryFlavorTextBox;
}
