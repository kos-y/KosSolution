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
        NameCaptionLabel.Location = new Point(59, 49);
        NameCaptionLabel.Name = "NameCaptionLabel";
        NameCaptionLabel.Size = new Size(47, 17);
        NameCaptionLabel.TabIndex = 2;
        NameCaptionLabel.Text = "言語名";
        NameCaptionLabel.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // OfficialCaptionLabel
        // 
        OfficialCaptionLabel.AutoSize = true;
        OfficialCaptionLabel.Location = new Point(14, 82);
        OfficialCaptionLabel.Name = "OfficialCaptionLabel";
        OfficialCaptionLabel.Size = new Size(92, 17);
        OfficialCaptionLabel.TabIndex = 4;
        OfficialCaptionLabel.Text = "オフィシャル言語";
        OfficialCaptionLabel.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // Iso639CaptionLabel
        // 
        Iso639CaptionLabel.AutoSize = true;
        Iso639CaptionLabel.Location = new Point(56, 115);
        Iso639CaptionLabel.Name = "Iso639CaptionLabel";
        Iso639CaptionLabel.Size = new Size(50, 17);
        Iso639CaptionLabel.TabIndex = 6;
        Iso639CaptionLabel.Text = "ISO639";
        Iso639CaptionLabel.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // Iso3166CaptionLabel
        // 
        Iso3166CaptionLabel.AutoSize = true;
        Iso3166CaptionLabel.Location = new Point(51, 148);
        Iso3166CaptionLabel.Name = "Iso3166CaptionLabel";
        Iso3166CaptionLabel.Size = new Size(55, 17);
        Iso3166CaptionLabel.TabIndex = 8;
        Iso3166CaptionLabel.Text = "ISO3166";
        Iso3166CaptionLabel.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // NamesCaptionLabel
        // 
        NamesCaptionLabel.AutoSize = true;
        NamesCaptionLabel.Location = new Point(14, 180);
        NamesCaptionLabel.Name = "NamesCaptionLabel";
        NamesCaptionLabel.Size = new Size(103, 17);
        NamesCaptionLabel.TabIndex = 10;
        NamesCaptionLabel.Text = "言語ごとの言語名";
        NamesCaptionLabel.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // NamesDataGridView
        // 
        NamesDataGridView.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
        NamesDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        NamesDataGridView.Columns.AddRange(new DataGridViewColumn[] { NameColumn, LanguageColumn, DetailColumn });
        NamesDataGridView.Location = new Point(14, 200);
        NamesDataGridView.Name = "NamesDataGridView";
        NamesDataGridView.RowHeadersVisible = false;
        NamesDataGridView.Size = new Size(473, 208);
        NamesDataGridView.TabIndex = 11;
        NamesDataGridView.CellClick += NamesDataGridView_CellClick;
        NamesDataGridView.CellDoubleClick += NamesDataGridView_CellDoubleClick;
        // 
        // NameColumn
        // 
        NameColumn.DataPropertyName = "Text";
        NameColumn.HeaderText = "言語名";
        NameColumn.Name = "NameColumn";
        NameColumn.ReadOnly = true;
        // 
        // LanguageColumn
        // 
        LanguageColumn.DataPropertyName = "Language";
        LanguageColumn.HeaderText = "表示言語";
        LanguageColumn.Name = "LanguageColumn";
        LanguageColumn.ReadOnly = true;
        // 
        // DetailColumn
        // 
        DetailColumn.HeaderText = "詳細";
        DetailColumn.Name = "DetailColumn";
        DetailColumn.Text = "詳細";
        DetailColumn.UseColumnTextForButtonValue = true;
        // 
        // CloseButton
        // 
        CloseButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
        CloseButton.Location = new Point(401, 410);
        CloseButton.Name = "CloseButton";
        CloseButton.Size = new Size(86, 26);
        CloseButton.TabIndex = 12;
        CloseButton.Text = "閉じる";
        CloseButton.UseVisualStyleBackColor = true;
        CloseButton.Click += CloseButton_Click;
        // 
        // IdTextBox
        // 
        IdTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        IdTextBox.Location = new Point(112, 12);
        IdTextBox.Name = "IdTextBox";
        IdTextBox.ReadOnly = true;
        IdTextBox.Size = new Size(375, 25);
        IdTextBox.TabIndex = 13;
        // 
        // NameTextBox
        // 
        NameTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        NameTextBox.Location = new Point(112, 45);
        NameTextBox.Name = "NameTextBox";
        NameTextBox.ReadOnly = true;
        NameTextBox.Size = new Size(375, 25);
        NameTextBox.TabIndex = 14;
        // 
        // OfficialTextBox
        // 
        OfficialTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        OfficialTextBox.Location = new Point(112, 78);
        OfficialTextBox.Name = "OfficialTextBox";
        OfficialTextBox.ReadOnly = true;
        OfficialTextBox.Size = new Size(375, 25);
        OfficialTextBox.TabIndex = 15;
        // 
        // Iso639TextBox
        // 
        Iso639TextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        Iso639TextBox.Location = new Point(112, 111);
        Iso639TextBox.Name = "Iso639TextBox";
        Iso639TextBox.ReadOnly = true;
        Iso639TextBox.Size = new Size(375, 25);
        Iso639TextBox.TabIndex = 16;
        // 
        // Iso3166TextBox
        // 
        Iso3166TextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        Iso3166TextBox.Location = new Point(112, 144);
        Iso3166TextBox.Name = "Iso3166TextBox";
        Iso3166TextBox.ReadOnly = true;
        Iso3166TextBox.Size = new Size(375, 25);
        Iso3166TextBox.TabIndex = 17;
        // 
        // LanguageInfoForm
        // 
        AutoScaleDimensions = new SizeF(8F, 17F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(505, 444);
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
        MinimumSize = new Size(379, 445);
        Name = "LanguageInfoForm";
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
    private DataGridViewTextBoxColumn NameColumn;
    private DataGridViewTextBoxColumn LanguageColumn;
    private DataGridViewButtonColumn DetailColumn;
    private TextBox IdTextBox;
    private TextBox NameTextBox;
    private TextBox OfficialTextBox;
    private TextBox Iso639TextBox;
    private TextBox Iso3166TextBox;
}