namespace Kos.PokeAPI.Forms.Berries;

partial class BerryFlavorInfoForm
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
        BerriesCaptionLabel = new Label();
        BerriesDataGridView = new DataGridView();
        BerriesColumn = new DataGridViewTextBoxColumn();
        PotencyColumn = new DataGridViewTextBoxColumn();
        BerryInfoColumn = new DataGridViewButtonColumn();
        NamesDataGridView = new DataGridView();
        NameColumn = new DataGridViewTextBoxColumn();
        LanguageColumn = new DataGridViewTextBoxColumn();
        DetailColumn = new DataGridViewButtonColumn();
        NamesCaptionLabel = new Label();
        CloseButton = new Button();
        ContestTypeButton = new Button();
        IdTextBox = new TextBox();
        ContestTypeTextBox = new TextBox();
        NameTextBox = new TextBox();
        PropertyButton = new Button();
        ((System.ComponentModel.ISupportInitialize)BerriesDataGridView).BeginInit();
        ((System.ComponentModel.ISupportInitialize)NamesDataGridView).BeginInit();
        SuspendLayout();
        // 
        // NameCaptionLabel
        // 
        NameCaptionLabel.AutoSize = true;
        NameCaptionLabel.Location = new Point(13, 44);
        NameCaptionLabel.Name = "NameCaptionLabel";
        NameCaptionLabel.Size = new Size(93, 15);
        NameCaptionLabel.TabIndex = 2;
        NameCaptionLabel.Text = "きのみの味の名前";
        NameCaptionLabel.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // IdCaptionLabel
        // 
        IdCaptionLabel.AutoSize = true;
        IdCaptionLabel.Location = new Point(36, 15);
        IdCaptionLabel.Name = "IdCaptionLabel";
        IdCaptionLabel.Size = new Size(70, 15);
        IdCaptionLabel.TabIndex = 0;
        IdCaptionLabel.Text = "きのみの味ID";
        IdCaptionLabel.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // BerriesCaptionLabel
        // 
        BerriesCaptionLabel.AutoSize = true;
        BerriesCaptionLabel.Location = new Point(258, 12);
        BerriesCaptionLabel.Name = "BerriesCaptionLabel";
        BerriesCaptionLabel.Size = new Size(37, 15);
        BerriesCaptionLabel.TabIndex = 8;
        BerriesCaptionLabel.Text = "きのみ";
        BerriesCaptionLabel.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // BerriesDataGridView
        // 
        BerriesDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        BerriesDataGridView.Columns.AddRange(new DataGridViewColumn[] { BerriesColumn, PotencyColumn, BerryInfoColumn });
        BerriesDataGridView.Location = new Point(257, 30);
        BerriesDataGridView.Name = "BerriesDataGridView";
        BerriesDataGridView.RowHeadersVisible = false;
        BerriesDataGridView.Size = new Size(215, 244);
        BerriesDataGridView.TabIndex = 9;
        BerriesDataGridView.CellClick += BerriesDataGridView_CellClick;
        BerriesDataGridView.CellDoubleClick += BerriesDataGridView_CellDoubleClick;
        // 
        // BerriesColumn
        // 
        BerriesColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
        BerriesColumn.DataPropertyName = "Berry";
        BerriesColumn.HeaderText = "きのみ";
        BerriesColumn.Name = "BerriesColumn";
        BerriesColumn.ReadOnly = true;
        BerriesColumn.Width = 62;
        // 
        // PotencyColumn
        // 
        PotencyColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
        PotencyColumn.DataPropertyName = "Potency";
        PotencyColumn.HeaderText = "味の強さ";
        PotencyColumn.Name = "PotencyColumn";
        PotencyColumn.ReadOnly = true;
        PotencyColumn.Width = 74;
        // 
        // BerryInfoColumn
        // 
        BerryInfoColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
        BerryInfoColumn.HeaderText = "きのみ詳細";
        BerryInfoColumn.Name = "BerryInfoColumn";
        BerryInfoColumn.ReadOnly = true;
        BerryInfoColumn.Text = "詳細";
        BerryInfoColumn.UseColumnTextForButtonValue = true;
        BerryInfoColumn.Width = 67;
        // 
        // NamesDataGridView
        // 
        NamesDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        NamesDataGridView.Columns.AddRange(new DataGridViewColumn[] { NameColumn, LanguageColumn, DetailColumn });
        NamesDataGridView.Location = new Point(12, 124);
        NamesDataGridView.Name = "NamesDataGridView";
        NamesDataGridView.RowHeadersVisible = false;
        NamesDataGridView.Size = new Size(230, 150);
        NamesDataGridView.TabIndex = 7;
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
        NameColumn.Width = 56;
        // 
        // LanguageColumn
        // 
        LanguageColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
        LanguageColumn.DataPropertyName = "Language";
        LanguageColumn.HeaderText = "言語";
        LanguageColumn.Name = "LanguageColumn";
        LanguageColumn.ReadOnly = true;
        LanguageColumn.Width = 56;
        // 
        // DetailColumn
        // 
        DetailColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
        DetailColumn.HeaderText = "詳細";
        DetailColumn.Name = "DetailColumn";
        DetailColumn.Text = "詳細";
        DetailColumn.UseColumnTextForButtonValue = true;
        DetailColumn.Width = 37;
        // 
        // NamesCaptionLabel
        // 
        NamesCaptionLabel.AutoSize = true;
        NamesCaptionLabel.Location = new Point(13, 106);
        NamesCaptionLabel.Name = "NamesCaptionLabel";
        NamesCaptionLabel.Size = new Size(82, 15);
        NamesCaptionLabel.TabIndex = 6;
        NamesCaptionLabel.Text = "言語ごとの名前";
        NamesCaptionLabel.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // CloseButton
        // 
        CloseButton.Location = new Point(413, 280);
        CloseButton.Name = "CloseButton";
        CloseButton.Size = new Size(59, 31);
        CloseButton.TabIndex = 11;
        CloseButton.Text = "閉じる";
        CloseButton.UseVisualStyleBackColor = true;
        CloseButton.Click += CloseButton_Click;
        // 
        // ContestTypeButton
        // 
        ContestTypeButton.Location = new Point(12, 69);
        ContestTypeButton.Name = "ContestTypeButton";
        ContestTypeButton.Size = new Size(93, 23);
        ContestTypeButton.TabIndex = 4;
        ContestTypeButton.Text = "コンテストの種類";
        ContestTypeButton.UseVisualStyleBackColor = true;
        ContestTypeButton.Click += ContestTypeButton_Click;
        // 
        // IdTextBox
        // 
        IdTextBox.Location = new Point(111, 12);
        IdTextBox.Margin = new Padding(2, 3, 2, 3);
        IdTextBox.Name = "IdTextBox";
        IdTextBox.ReadOnly = true;
        IdTextBox.Size = new Size(142, 23);
        IdTextBox.TabIndex = 1;
        // 
        // ContestTypeTextBox
        // 
        ContestTypeTextBox.Location = new Point(110, 70);
        ContestTypeTextBox.Margin = new Padding(2, 3, 2, 3);
        ContestTypeTextBox.Name = "ContestTypeTextBox";
        ContestTypeTextBox.ReadOnly = true;
        ContestTypeTextBox.Size = new Size(142, 23);
        ContestTypeTextBox.TabIndex = 5;
        // 
        // NameTextBox
        // 
        NameTextBox.Location = new Point(111, 41);
        NameTextBox.Margin = new Padding(2, 3, 2, 3);
        NameTextBox.Name = "NameTextBox";
        NameTextBox.ReadOnly = true;
        NameTextBox.Size = new Size(142, 23);
        NameTextBox.TabIndex = 3;
        // 
        // PropertyButton
        // 
        PropertyButton.Location = new Point(348, 280);
        PropertyButton.Name = "PropertyButton";
        PropertyButton.Size = new Size(59, 31);
        PropertyButton.TabIndex = 10;
        PropertyButton.Text = "プロパティ";
        PropertyButton.UseVisualStyleBackColor = true;
        PropertyButton.Click += PropertyButton_Click;
        // 
        // BerryFlavorInfoForm
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(481, 320);
        Controls.Add(PropertyButton);
        Controls.Add(NameTextBox);
        Controls.Add(ContestTypeTextBox);
        Controls.Add(IdTextBox);
        Controls.Add(ContestTypeButton);
        Controls.Add(CloseButton);
        Controls.Add(NamesCaptionLabel);
        Controls.Add(NamesDataGridView);
        Controls.Add(BerriesDataGridView);
        Controls.Add(BerriesCaptionLabel);
        Controls.Add(NameCaptionLabel);
        Controls.Add(IdCaptionLabel);
        FormBorderStyle = FormBorderStyle.FixedSingle;
        MaximizeBox = false;
        Name = "BerryFlavorInfoForm";
        StartPosition = FormStartPosition.CenterParent;
        Text = "きのみの味";
        Load += BerryFlavorInfoForm_Load;
        ((System.ComponentModel.ISupportInitialize)BerriesDataGridView).EndInit();
        ((System.ComponentModel.ISupportInitialize)NamesDataGridView).EndInit();
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion
    private Label NameCaptionLabel;
    private Label IdCaptionLabel;
    private Label BerriesCaptionLabel;
    private DataGridView BerriesDataGridView;
    private DataGridView NamesDataGridView;
    private Label NamesCaptionLabel;
    private Button CloseButton;
    private Button ContestTypeButton;
    private TextBox IdTextBox;
    private TextBox ContestTypeTextBox;
    private DataGridViewTextBoxColumn BerriesColumn;
    private DataGridViewTextBoxColumn PotencyColumn;
    private DataGridViewButtonColumn BerryInfoColumn;
    private DataGridViewTextBoxColumn NameColumn;
    private DataGridViewTextBoxColumn LanguageColumn;
    private DataGridViewButtonColumn DetailColumn;
    private TextBox NameTextBox;
    private Button PropertyButton;
}