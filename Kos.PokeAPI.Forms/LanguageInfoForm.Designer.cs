namespace Kos.PokeAPI.Forms;

partial class LanguageInfoForm
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
        IdCaptionLabel = new Label();
        NameCaptionLabel = new Label();
        OfficialCaptionLabel = new Label();
        Iso639CaptionLabel = new Label();
        Iso3166CaptionLabel = new Label();
        NamesCaptionLabel = new Label();
        NamesDataGridView = new DataGridView();
        NameColumn = new DataGridViewTextBoxColumn();
        LanguageColumn = new DataGridViewTextBoxColumn();
        DetailColumn = new DataGridViewButtonColumn();
        CloseButton = new Button();
        IdTextBox = new TextBox();
        NameTextBox = new TextBox();
        OfficialTextBox = new TextBox();
        Iso639TextBox = new TextBox();
        Iso3166TextBox = new TextBox();
        PropertyButton = new Button();
        ((System.ComponentModel.ISupportInitialize)NamesDataGridView).BeginInit();
        SuspendLayout();
        // 
        // IdCaptionLabel
        // 
        IdCaptionLabel.AutoSize = true;
        IdCaptionLabel.Location = new Point(59, 16);
        IdCaptionLabel.Name = "IdCaptionLabel";
        IdCaptionLabel.Size = new Size(47, 17);
        IdCaptionLabel.TabIndex = 0;
        IdCaptionLabel.Text = "言語ID";
        IdCaptionLabel.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // NameCaptionLabel
        // 
        NameCaptionLabel.AutoSize = true;
        NameCaptionLabel.Location = new Point(59, 46);
        NameCaptionLabel.Name = "NameCaptionLabel";
        NameCaptionLabel.Size = new Size(47, 17);
        NameCaptionLabel.TabIndex = 2;
        NameCaptionLabel.Text = "言語名";
        NameCaptionLabel.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // OfficialCaptionLabel
        // 
        OfficialCaptionLabel.AutoSize = true;
        OfficialCaptionLabel.Location = new Point(14, 77);
        OfficialCaptionLabel.Name = "OfficialCaptionLabel";
        OfficialCaptionLabel.Size = new Size(92, 17);
        OfficialCaptionLabel.TabIndex = 4;
        OfficialCaptionLabel.Text = "オフィシャル言語";
        OfficialCaptionLabel.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // Iso639CaptionLabel
        // 
        Iso639CaptionLabel.AutoSize = true;
        Iso639CaptionLabel.Location = new Point(56, 108);
        Iso639CaptionLabel.Name = "Iso639CaptionLabel";
        Iso639CaptionLabel.Size = new Size(50, 17);
        Iso639CaptionLabel.TabIndex = 6;
        Iso639CaptionLabel.Text = "ISO639";
        Iso639CaptionLabel.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // Iso3166CaptionLabel
        // 
        Iso3166CaptionLabel.AutoSize = true;
        Iso3166CaptionLabel.Location = new Point(51, 139);
        Iso3166CaptionLabel.Name = "Iso3166CaptionLabel";
        Iso3166CaptionLabel.Size = new Size(55, 17);
        Iso3166CaptionLabel.TabIndex = 8;
        Iso3166CaptionLabel.Text = "ISO3166";
        Iso3166CaptionLabel.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // NamesCaptionLabel
        // 
        NamesCaptionLabel.AutoSize = true;
        NamesCaptionLabel.Location = new Point(14, 164);
        NamesCaptionLabel.Name = "NamesCaptionLabel";
        NamesCaptionLabel.Size = new Size(103, 17);
        NamesCaptionLabel.TabIndex = 10;
        NamesCaptionLabel.Text = "言語ごとの言語名";
        NamesCaptionLabel.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // NamesDataGridView
        // 
        NamesDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        NamesDataGridView.Columns.AddRange(new DataGridViewColumn[] { NameColumn, LanguageColumn, DetailColumn });
        NamesDataGridView.Location = new Point(14, 184);
        NamesDataGridView.Name = "NamesDataGridView";
        NamesDataGridView.RowHeadersVisible = false;
        NamesDataGridView.Size = new Size(270, 208);
        NamesDataGridView.TabIndex = 11;
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
        LanguageColumn.HeaderText = "表示言語";
        LanguageColumn.Name = "LanguageColumn";
        LanguageColumn.ReadOnly = true;
        LanguageColumn.Width = 85;
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
        // CloseButton
        // 
        CloseButton.Location = new Point(208, 398);
        CloseButton.Name = "CloseButton";
        CloseButton.Size = new Size(76, 35);
        CloseButton.TabIndex = 13;
        CloseButton.Text = "閉じる";
        CloseButton.UseVisualStyleBackColor = true;
        CloseButton.Click += CloseButton_Click;
        // 
        // IdTextBox
        // 
        IdTextBox.Location = new Point(112, 12);
        IdTextBox.Name = "IdTextBox";
        IdTextBox.ReadOnly = true;
        IdTextBox.Size = new Size(172, 25);
        IdTextBox.TabIndex = 1;
        // 
        // NameTextBox
        // 
        NameTextBox.Location = new Point(112, 43);
        NameTextBox.Name = "NameTextBox";
        NameTextBox.ReadOnly = true;
        NameTextBox.Size = new Size(172, 25);
        NameTextBox.TabIndex = 3;
        // 
        // OfficialTextBox
        // 
        OfficialTextBox.Location = new Point(112, 74);
        OfficialTextBox.Name = "OfficialTextBox";
        OfficialTextBox.ReadOnly = true;
        OfficialTextBox.Size = new Size(172, 25);
        OfficialTextBox.TabIndex = 5;
        // 
        // Iso639TextBox
        // 
        Iso639TextBox.Location = new Point(112, 105);
        Iso639TextBox.Name = "Iso639TextBox";
        Iso639TextBox.ReadOnly = true;
        Iso639TextBox.Size = new Size(172, 25);
        Iso639TextBox.TabIndex = 7;
        // 
        // Iso3166TextBox
        // 
        Iso3166TextBox.Location = new Point(112, 136);
        Iso3166TextBox.Name = "Iso3166TextBox";
        Iso3166TextBox.ReadOnly = true;
        Iso3166TextBox.Size = new Size(172, 25);
        Iso3166TextBox.TabIndex = 9;
        // 
        // PropertyButton
        // 
        PropertyButton.Location = new Point(126, 398);
        PropertyButton.Name = "PropertyButton";
        PropertyButton.Size = new Size(76, 35);
        PropertyButton.TabIndex = 12;
        PropertyButton.Text = "プロパティ";
        PropertyButton.UseVisualStyleBackColor = true;
        PropertyButton.Click += PropertyButton_Click;
        // 
        // LanguageInfoForm
        // 
        AutoScaleDimensions = new SizeF(8F, 17F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(306, 446);
        Controls.Add(PropertyButton);
        Controls.Add(Iso3166TextBox);
        Controls.Add(Iso639TextBox);
        Controls.Add(OfficialTextBox);
        Controls.Add(NameTextBox);
        Controls.Add(IdTextBox);
        Controls.Add(CloseButton);
        Controls.Add(NamesDataGridView);
        Controls.Add(NamesCaptionLabel);
        Controls.Add(Iso3166CaptionLabel);
        Controls.Add(Iso639CaptionLabel);
        Controls.Add(OfficialCaptionLabel);
        Controls.Add(NameCaptionLabel);
        Controls.Add(IdCaptionLabel);
        Font = new Font("Yu Gothic UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 128);
        MaximizeBox = false;
        Name = "LanguageInfoForm";
        StartPosition = FormStartPosition.CenterParent;
        Text = "言語";
        ((System.ComponentModel.ISupportInitialize)NamesDataGridView).EndInit();
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private Label IdCaptionLabel;
    private Label NameCaptionLabel;
    private Label OfficialCaptionLabel;
    private Label Iso639CaptionLabel;
    private Label Iso3166CaptionLabel;
    private Label NamesCaptionLabel;
    private DataGridView NamesDataGridView;
    private Button CloseButton;
    private TextBox IdTextBox;
    private TextBox NameTextBox;
    private TextBox OfficialTextBox;
    private TextBox Iso639TextBox;
    private TextBox Iso3166TextBox;
    private DataGridViewTextBoxColumn NameColumn;
    private DataGridViewTextBoxColumn LanguageColumn;
    private DataGridViewButtonColumn DetailColumn;
    private Button PropertyButton;
}