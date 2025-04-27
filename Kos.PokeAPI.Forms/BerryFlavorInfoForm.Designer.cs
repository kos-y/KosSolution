namespace Kos.PokeAPI.Forms;

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
        ContestTypeCaptionLabel = new Label();
        NamesDataGridView = new DataGridView();
        NameColumn = new DataGridViewTextBoxColumn();
        LanguageColumn = new DataGridViewTextBoxColumn();
        DetailColumn = new DataGridViewButtonColumn();
        NamesCaptionLabel = new Label();
        CloseButton = new Button();
        ContestTypeDetailButton = new Button();
        IdTextBox = new TextBox();
        ContestTypeTextBox = new TextBox();
        NameTextBox = new TextBox();
        ((System.ComponentModel.ISupportInitialize)BerriesDataGridView).BeginInit();
        ((System.ComponentModel.ISupportInitialize)NamesDataGridView).BeginInit();
        SuspendLayout();
        // 
        // NameCaptionLabel
        // 
        NameCaptionLabel.AutoSize = true;
        NameCaptionLabel.Location = new Point(314, 10);
        NameCaptionLabel.Margin = new Padding(4, 0, 4, 0);
        NameCaptionLabel.Name = "NameCaptionLabel";
        NameCaptionLabel.Size = new Size(79, 17);
        NameCaptionLabel.TabIndex = 2;
        NameCaptionLabel.Text = "きのみの味名";
        NameCaptionLabel.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // IdCaptionLabel
        // 
        IdCaptionLabel.AutoSize = true;
        IdCaptionLabel.Location = new Point(24, 14);
        IdCaptionLabel.Margin = new Padding(4, 0, 4, 0);
        IdCaptionLabel.Name = "IdCaptionLabel";
        IdCaptionLabel.Size = new Size(83, 17);
        IdCaptionLabel.TabIndex = 0;
        IdCaptionLabel.Text = "きのみの味ID";
        IdCaptionLabel.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // BerriesCaptionLabel
        // 
        BerriesCaptionLabel.AutoSize = true;
        BerriesCaptionLabel.Location = new Point(66, 72);
        BerriesCaptionLabel.Margin = new Padding(4, 0, 4, 0);
        BerriesCaptionLabel.Name = "BerriesCaptionLabel";
        BerriesCaptionLabel.Size = new Size(41, 17);
        BerriesCaptionLabel.TabIndex = 7;
        BerriesCaptionLabel.Text = "きのみ";
        BerriesCaptionLabel.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // BerriesDataGridView
        // 
        BerriesDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        BerriesDataGridView.Columns.AddRange(new DataGridViewColumn[] { BerriesColumn, PotencyColumn, BerryInfoColumn });
        BerriesDataGridView.Location = new Point(115, 72);
        BerriesDataGridView.Margin = new Padding(4, 3, 4, 3);
        BerriesDataGridView.Name = "BerriesDataGridView";
        BerriesDataGridView.RowHeadersVisible = false;
        BerriesDataGridView.Size = new Size(467, 170);
        BerriesDataGridView.TabIndex = 8;
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
        BerriesColumn.Width = 66;
        // 
        // PotencyColumn
        // 
        PotencyColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
        PotencyColumn.DataPropertyName = "Potency";
        PotencyColumn.HeaderText = "味の強さ";
        PotencyColumn.Name = "PotencyColumn";
        PotencyColumn.ReadOnly = true;
        PotencyColumn.Width = 81;
        // 
        // BerryInfoColumn
        // 
        BerryInfoColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
        BerryInfoColumn.HeaderText = "きのみ詳細";
        BerryInfoColumn.Name = "BerryInfoColumn";
        BerryInfoColumn.ReadOnly = true;
        BerryInfoColumn.Text = "詳細";
        BerryInfoColumn.UseColumnTextForButtonValue = true;
        BerryInfoColumn.Width = 73;
        // 
        // ContestTypeCaptionLabel
        // 
        ContestTypeCaptionLabel.AutoSize = true;
        ContestTypeCaptionLabel.Location = new Point(15, 45);
        ContestTypeCaptionLabel.Margin = new Padding(4, 0, 4, 0);
        ContestTypeCaptionLabel.Name = "ContestTypeCaptionLabel";
        ContestTypeCaptionLabel.Size = new Size(97, 17);
        ContestTypeCaptionLabel.TabIndex = 4;
        ContestTypeCaptionLabel.Text = "コンテストの種別";
        ContestTypeCaptionLabel.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // NamesDataGridView
        // 
        NamesDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        NamesDataGridView.Columns.AddRange(new DataGridViewColumn[] { NameColumn, LanguageColumn, DetailColumn });
        NamesDataGridView.Location = new Point(115, 248);
        NamesDataGridView.Margin = new Padding(4, 3, 4, 3);
        NamesDataGridView.Name = "NamesDataGridView";
        NamesDataGridView.RowHeadersVisible = false;
        NamesDataGridView.Size = new Size(467, 170);
        NamesDataGridView.TabIndex = 10;
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
        DetailColumn.HeaderText = "詳細";
        DetailColumn.Name = "DetailColumn";
        DetailColumn.Text = "詳細";
        DetailColumn.UseColumnTextForButtonValue = true;
        DetailColumn.Width = 40;
        // 
        // NamesCaptionLabel
        // 
        NamesCaptionLabel.AutoSize = true;
        NamesCaptionLabel.Location = new Point(13, 248);
        NamesCaptionLabel.Margin = new Padding(4, 0, 4, 0);
        NamesCaptionLabel.Name = "NamesCaptionLabel";
        NamesCaptionLabel.Size = new Size(92, 17);
        NamesCaptionLabel.TabIndex = 9;
        NamesCaptionLabel.Text = "言語ごとの名前";
        NamesCaptionLabel.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // CloseButton
        // 
        CloseButton.Location = new Point(504, 424);
        CloseButton.Margin = new Padding(4, 3, 4, 3);
        CloseButton.Name = "CloseButton";
        CloseButton.Size = new Size(78, 42);
        CloseButton.TabIndex = 11;
        CloseButton.Text = "閉じる";
        CloseButton.UseVisualStyleBackColor = true;
        CloseButton.Click += CloseButton_Click;
        // 
        // ContestTypeDetailButton
        // 
        ContestTypeDetailButton.Location = new Point(312, 40);
        ContestTypeDetailButton.Margin = new Padding(4, 3, 4, 3);
        ContestTypeDetailButton.Name = "ContestTypeDetailButton";
        ContestTypeDetailButton.Size = new Size(55, 26);
        ContestTypeDetailButton.TabIndex = 6;
        ContestTypeDetailButton.Text = "詳細";
        ContestTypeDetailButton.UseVisualStyleBackColor = true;
        ContestTypeDetailButton.Click += ContestTypeDetailButton_Click;
        // 
        // IdTextBox
        // 
        IdTextBox.Location = new Point(115, 11);
        IdTextBox.Name = "IdTextBox";
        IdTextBox.ReadOnly = true;
        IdTextBox.Size = new Size(192, 24);
        IdTextBox.TabIndex = 1;
        // 
        // ContestTypeTextBox
        // 
        ContestTypeTextBox.Location = new Point(113, 42);
        ContestTypeTextBox.Name = "ContestTypeTextBox";
        ContestTypeTextBox.ReadOnly = true;
        ContestTypeTextBox.Size = new Size(192, 24);
        ContestTypeTextBox.TabIndex = 5;
        // 
        // NameTextBox
        // 
        NameTextBox.Location = new Point(400, 7);
        NameTextBox.Name = "NameTextBox";
        NameTextBox.ReadOnly = true;
        NameTextBox.Size = new Size(182, 24);
        NameTextBox.TabIndex = 3;
        // 
        // BerryFlavorInfoForm
        // 
        AutoScaleDimensions = new SizeF(9F, 17F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(600, 478);
        Controls.Add(NameTextBox);
        Controls.Add(ContestTypeTextBox);
        Controls.Add(IdTextBox);
        Controls.Add(ContestTypeDetailButton);
        Controls.Add(CloseButton);
        Controls.Add(NamesCaptionLabel);
        Controls.Add(NamesDataGridView);
        Controls.Add(ContestTypeCaptionLabel);
        Controls.Add(BerriesDataGridView);
        Controls.Add(BerriesCaptionLabel);
        Controls.Add(NameCaptionLabel);
        Controls.Add(IdCaptionLabel);
        Font = new Font("Meiryo UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
        FormBorderStyle = FormBorderStyle.FixedSingle;
        Margin = new Padding(4, 3, 4, 3);
        MinimizeBox = false;
        Name = "BerryFlavorInfoForm";
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
    private Label ContestTypeCaptionLabel;
    private DataGridView NamesDataGridView;
    private Label NamesCaptionLabel;
    private Button CloseButton;
    private Button ContestTypeDetailButton;
    private TextBox IdTextBox;
    private TextBox ContestTypeTextBox;
    private DataGridViewTextBoxColumn BerriesColumn;
    private DataGridViewTextBoxColumn PotencyColumn;
    private DataGridViewButtonColumn BerryInfoColumn;
    private DataGridViewTextBoxColumn NameColumn;
    private DataGridViewTextBoxColumn LanguageColumn;
    private DataGridViewButtonColumn DetailColumn;
    private TextBox NameTextBox;
}