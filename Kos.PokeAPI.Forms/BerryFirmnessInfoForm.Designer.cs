namespace Kos.PokeAPI.Forms;

partial class BerryFirmnessInfoForm
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
        NameLabel = new Label();
        NameCaptionLabel = new Label();
        IdLabel = new Label();
        IdCaptionLabel = new Label();
        BerriesCaptionLabel = new Label();
        BerriesDataGridView = new DataGridView();
        NamesDataGridView = new DataGridView();
        NamesCaptionLabel = new Label();
        CloseButton = new Button();
        BerriesNameColumn = new DataGridViewTextBoxColumn();
        BerrieDetailButtonColumn = new DataGridViewButtonColumn();
        NameColumn = new DataGridViewTextBoxColumn();
        LanguageColumn = new DataGridViewTextBoxColumn();
        DetailColumn = new DataGridViewButtonColumn();
        ((System.ComponentModel.ISupportInitialize)BerriesDataGridView).BeginInit();
        ((System.ComponentModel.ISupportInitialize)NamesDataGridView).BeginInit();
        SuspendLayout();
        // 
        // NameLabel
        // 
        NameLabel.BorderStyle = BorderStyle.Fixed3D;
        NameLabel.Location = new Point(150, 36);
        NameLabel.Margin = new Padding(4, 0, 4, 0);
        NameLabel.Name = "NameLabel";
        NameLabel.Size = new Size(189, 26);
        NameLabel.TabIndex = 3;
        NameLabel.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // NameCaptionLabel
        // 
        NameCaptionLabel.AutoSize = true;
        NameCaptionLabel.Location = new Point(15, 36);
        NameCaptionLabel.Margin = new Padding(4, 0, 4, 0);
        NameCaptionLabel.Name = "NameCaptionLabel";
        NameCaptionLabel.Size = new Size(89, 17);
        NameCaptionLabel.TabIndex = 2;
        NameCaptionLabel.Text = "きのみの硬さ名";
        NameCaptionLabel.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // IdLabel
        // 
        IdLabel.BorderStyle = BorderStyle.Fixed3D;
        IdLabel.Location = new Point(150, 10);
        IdLabel.Margin = new Padding(4, 0, 4, 0);
        IdLabel.Name = "IdLabel";
        IdLabel.Size = new Size(189, 26);
        IdLabel.TabIndex = 1;
        IdLabel.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // IdCaptionLabel
        // 
        IdCaptionLabel.AutoSize = true;
        IdCaptionLabel.Location = new Point(15, 10);
        IdCaptionLabel.Margin = new Padding(4, 0, 4, 0);
        IdCaptionLabel.Name = "IdCaptionLabel";
        IdCaptionLabel.Size = new Size(93, 17);
        IdCaptionLabel.TabIndex = 0;
        IdCaptionLabel.Text = "きのみの硬さID";
        IdCaptionLabel.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // BerriesCaptionLabel
        // 
        BerriesCaptionLabel.AutoSize = true;
        BerriesCaptionLabel.Location = new Point(15, 62);
        BerriesCaptionLabel.Margin = new Padding(4, 0, 4, 0);
        BerriesCaptionLabel.Name = "BerriesCaptionLabel";
        BerriesCaptionLabel.Size = new Size(41, 17);
        BerriesCaptionLabel.TabIndex = 4;
        BerriesCaptionLabel.Text = "きのみ";
        BerriesCaptionLabel.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // BerriesDataGridView
        // 
        BerriesDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        BerriesDataGridView.Columns.AddRange(new DataGridViewColumn[] { BerriesNameColumn, BerrieDetailButtonColumn });
        BerriesDataGridView.Location = new Point(150, 66);
        BerriesDataGridView.Margin = new Padding(4, 3, 4, 3);
        BerriesDataGridView.Name = "BerriesDataGridView";
        BerriesDataGridView.RowHeadersVisible = false;
        BerriesDataGridView.Size = new Size(324, 170);
        BerriesDataGridView.TabIndex = 5;
        BerriesDataGridView.CellClick += BerriesDataGridView_CellClick;
        BerriesDataGridView.CellDoubleClick += BerriesDataGridView_CellDoubleClick;
        // 
        // NamesDataGridView
        // 
        NamesDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        NamesDataGridView.Columns.AddRange(new DataGridViewColumn[] { NameColumn, LanguageColumn, DetailColumn });
        NamesDataGridView.Location = new Point(150, 243);
        NamesDataGridView.Margin = new Padding(4, 3, 4, 3);
        NamesDataGridView.Name = "NamesDataGridView";
        NamesDataGridView.RowHeadersVisible = false;
        NamesDataGridView.Size = new Size(324, 170);
        NamesDataGridView.TabIndex = 7;
        NamesDataGridView.CellClick += NamesDataGridView_CellClick;
        NamesDataGridView.CellDoubleClick += NamesDataGridView_CellDoubleClick;
        // 
        // NamesCaptionLabel
        // 
        NamesCaptionLabel.AutoSize = true;
        NamesCaptionLabel.Location = new Point(15, 243);
        NamesCaptionLabel.Margin = new Padding(4, 0, 4, 0);
        NamesCaptionLabel.Name = "NamesCaptionLabel";
        NamesCaptionLabel.Size = new Size(92, 17);
        NamesCaptionLabel.TabIndex = 6;
        NamesCaptionLabel.Text = "言語ごとの名前";
        NamesCaptionLabel.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // CloseButton
        // 
        CloseButton.Location = new Point(378, 419);
        CloseButton.Margin = new Padding(4, 3, 4, 3);
        CloseButton.Name = "CloseButton";
        CloseButton.Size = new Size(96, 26);
        CloseButton.TabIndex = 8;
        CloseButton.Text = "閉じる";
        CloseButton.UseVisualStyleBackColor = true;
        CloseButton.Click += CloseButton_Click;
        // 
        // BerriesNameColumn
        // 
        BerriesNameColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
        BerriesNameColumn.DataPropertyName = "Name";
        BerriesNameColumn.HeaderText = "きのみ";
        BerriesNameColumn.Name = "BerriesNameColumn";
        BerriesNameColumn.ReadOnly = true;
        BerriesNameColumn.Width = 66;
        // 
        // BerrieDetailButtonColumn
        // 
        BerrieDetailButtonColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
        BerrieDetailButtonColumn.HeaderText = "詳細";
        BerrieDetailButtonColumn.Name = "BerrieDetailButtonColumn";
        BerrieDetailButtonColumn.ReadOnly = true;
        BerrieDetailButtonColumn.Text = "詳細";
        BerrieDetailButtonColumn.UseColumnTextForButtonValue = true;
        BerrieDetailButtonColumn.Width = 40;
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
        // BerryFirmnessInfoForm
        // 
        AutoScaleDimensions = new SizeF(9F, 17F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(496, 460);
        Controls.Add(CloseButton);
        Controls.Add(NamesDataGridView);
        Controls.Add(NamesCaptionLabel);
        Controls.Add(BerriesDataGridView);
        Controls.Add(BerriesCaptionLabel);
        Controls.Add(NameLabel);
        Controls.Add(NameCaptionLabel);
        Controls.Add(IdLabel);
        Controls.Add(IdCaptionLabel);
        Font = new Font("Meiryo UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 128);
        FormBorderStyle = FormBorderStyle.FixedSingle;
        Margin = new Padding(4, 3, 4, 3);
        MaximizeBox = false;
        Name = "BerryFirmnessInfoForm";
        StartPosition = FormStartPosition.CenterParent;
        Text = "きのみの硬さ";
        Load += BerryFirmnessInfoForm_Load;
        ((System.ComponentModel.ISupportInitialize)BerriesDataGridView).EndInit();
        ((System.ComponentModel.ISupportInitialize)NamesDataGridView).EndInit();
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private Label NameLabel;
    private Label NameCaptionLabel;
    private Label IdLabel;
    private Label IdCaptionLabel;
    private Label BerriesCaptionLabel;
    private DataGridView BerriesDataGridView;
    private DataGridView NamesDataGridView;
    private Label NamesCaptionLabel;
    private Button CloseButton;
    private DataGridViewTextBoxColumn BerriesNameColumn;
    private DataGridViewButtonColumn BerrieDetailButtonColumn;
    private DataGridViewTextBoxColumn NameColumn;
    private DataGridViewTextBoxColumn LanguageColumn;
    private DataGridViewButtonColumn DetailColumn;
}