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
        NameLabel = new Label();
        NameCaptionLabel = new Label();
        IdLabel = new Label();
        IdCaptionLabel = new Label();
        BerriesCaptionLabel = new Label();
        BerriesDataGridView = new DataGridView();
        PotencyColumn = new DataGridViewTextBoxColumn();
        BerriesColumn = new DataGridViewTextBoxColumn();
        BerryInfoColumn = new DataGridViewButtonColumn();
        ContestTypeLabel = new Label();
        ContestTypeCaptionLabel = new Label();
        NamesDataGridView = new DataGridView();
        NameColumn = new DataGridViewTextBoxColumn();
        LanguageColumn = new DataGridViewTextBoxColumn();
        DetailColumn = new DataGridViewButtonColumn();
        NamesCaptionLabel = new Label();
        CloseButton = new Button();
        ContestTypeInfoButton = new Button();
        ((System.ComponentModel.ISupportInitialize)BerriesDataGridView).BeginInit();
        ((System.ComponentModel.ISupportInitialize)NamesDataGridView).BeginInit();
        SuspendLayout();
        // 
        // NameLabel
        // 
        NameLabel.BorderStyle = BorderStyle.Fixed3D;
        NameLabel.Location = new Point(117, 32);
        NameLabel.Name = "NameLabel";
        NameLabel.Size = new Size(147, 23);
        NameLabel.TabIndex = 3;
        NameLabel.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // NameCaptionLabel
        // 
        NameCaptionLabel.Location = new Point(12, 32);
        NameCaptionLabel.Name = "NameCaptionLabel";
        NameCaptionLabel.Size = new Size(99, 23);
        NameCaptionLabel.TabIndex = 2;
        NameCaptionLabel.Text = "name";
        NameCaptionLabel.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // IdLabel
        // 
        IdLabel.BorderStyle = BorderStyle.Fixed3D;
        IdLabel.Location = new Point(117, 9);
        IdLabel.Name = "IdLabel";
        IdLabel.Size = new Size(147, 23);
        IdLabel.TabIndex = 1;
        IdLabel.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // IdCaptionLabel
        // 
        IdCaptionLabel.Location = new Point(12, 9);
        IdCaptionLabel.Name = "IdCaptionLabel";
        IdCaptionLabel.Size = new Size(99, 23);
        IdCaptionLabel.TabIndex = 0;
        IdCaptionLabel.Text = "id";
        IdCaptionLabel.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // BerriesCaptionLabel
        // 
        BerriesCaptionLabel.Location = new Point(12, 55);
        BerriesCaptionLabel.Name = "BerriesCaptionLabel";
        BerriesCaptionLabel.Size = new Size(99, 23);
        BerriesCaptionLabel.TabIndex = 4;
        BerriesCaptionLabel.Text = "berries";
        BerriesCaptionLabel.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // BerriesDataGridView
        // 
        BerriesDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        BerriesDataGridView.Columns.AddRange(new DataGridViewColumn[] { PotencyColumn, BerriesColumn, BerryInfoColumn });
        BerriesDataGridView.Location = new Point(117, 58);
        BerriesDataGridView.Name = "BerriesDataGridView";
        BerriesDataGridView.RowHeadersVisible = false;
        BerriesDataGridView.Size = new Size(363, 150);
        BerriesDataGridView.TabIndex = 5;
        BerriesDataGridView.CellClick += BerriesDataGridView_CellClick;
        BerriesDataGridView.CellDoubleClick += BerriesDataGridView_CellDoubleClick;
        // 
        // PotencyColumn
        // 
        PotencyColumn.DataPropertyName = "Potency";
        PotencyColumn.HeaderText = "potency";
        PotencyColumn.Name = "PotencyColumn";
        PotencyColumn.ReadOnly = true;
        // 
        // BerriesColumn
        // 
        BerriesColumn.DataPropertyName = "Berry";
        BerriesColumn.HeaderText = "berry";
        BerriesColumn.Name = "BerriesColumn";
        BerriesColumn.ReadOnly = true;
        // 
        // BerryInfoColumn
        // 
        BerryInfoColumn.HeaderText = "berry_info";
        BerryInfoColumn.Name = "BerryInfoColumn";
        BerryInfoColumn.ReadOnly = true;
        BerryInfoColumn.Text = "Info...";
        BerryInfoColumn.UseColumnTextForButtonValue = true;
        // 
        // ContestTypeLabel
        // 
        ContestTypeLabel.BorderStyle = BorderStyle.Fixed3D;
        ContestTypeLabel.Location = new Point(117, 211);
        ContestTypeLabel.Name = "ContestTypeLabel";
        ContestTypeLabel.Size = new Size(147, 23);
        ContestTypeLabel.TabIndex = 7;
        ContestTypeLabel.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // ContestTypeCaptionLabel
        // 
        ContestTypeCaptionLabel.Location = new Point(12, 211);
        ContestTypeCaptionLabel.Name = "ContestTypeCaptionLabel";
        ContestTypeCaptionLabel.Size = new Size(99, 23);
        ContestTypeCaptionLabel.TabIndex = 6;
        ContestTypeCaptionLabel.Text = "contest_type";
        ContestTypeCaptionLabel.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // NamesDataGridView
        // 
        NamesDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        NamesDataGridView.Columns.AddRange(new DataGridViewColumn[] { NameColumn, LanguageColumn, DetailColumn });
        NamesDataGridView.Location = new Point(117, 237);
        NamesDataGridView.Name = "NamesDataGridView";
        NamesDataGridView.RowHeadersVisible = false;
        NamesDataGridView.Size = new Size(434, 150);
        NamesDataGridView.TabIndex = 10;
        NamesDataGridView.CellClick += NamesDataGridView_CellClick;
        NamesDataGridView.CellDoubleClick += NamesDataGridView_CellDoubleClick;
        // 
        // NameColumn
        // 
        NameColumn.DataPropertyName = "Text";
        NameColumn.HeaderText = "name";
        NameColumn.Name = "NameColumn";
        NameColumn.ReadOnly = true;
        // 
        // LanguageColumn
        // 
        LanguageColumn.DataPropertyName = "Language";
        LanguageColumn.HeaderText = "language";
        LanguageColumn.Name = "LanguageColumn";
        LanguageColumn.ReadOnly = true;
        // 
        // DetailColumn
        // 
        DetailColumn.HeaderText = "Info";
        DetailColumn.Name = "DetailColumn";
        DetailColumn.Text = "Info..";
        DetailColumn.UseColumnTextForButtonValue = true;
        // 
        // NamesCaptionLabel
        // 
        NamesCaptionLabel.Location = new Point(12, 237);
        NamesCaptionLabel.Name = "NamesCaptionLabel";
        NamesCaptionLabel.Size = new Size(99, 23);
        NamesCaptionLabel.TabIndex = 9;
        NamesCaptionLabel.Text = "names";
        NamesCaptionLabel.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // CloseButton
        // 
        CloseButton.Location = new Point(476, 393);
        CloseButton.Name = "CloseButton";
        CloseButton.Size = new Size(75, 23);
        CloseButton.TabIndex = 11;
        CloseButton.Text = "Close";
        CloseButton.UseVisualStyleBackColor = true;
        CloseButton.Click += CloseButton_Click;
        // 
        // ContestTypeInfoButton
        // 
        ContestTypeInfoButton.Location = new Point(270, 211);
        ContestTypeInfoButton.Name = "ContestTypeInfoButton";
        ContestTypeInfoButton.Size = new Size(43, 23);
        ContestTypeInfoButton.TabIndex = 8;
        ContestTypeInfoButton.Text = "Info...";
        ContestTypeInfoButton.UseVisualStyleBackColor = true;
        ContestTypeInfoButton.Click += ContestTypeInfoButton_Click;
        // 
        // BerryFlavorInfoForm
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(563, 426);
        Controls.Add(ContestTypeInfoButton);
        Controls.Add(CloseButton);
        Controls.Add(NamesCaptionLabel);
        Controls.Add(NamesDataGridView);
        Controls.Add(ContestTypeCaptionLabel);
        Controls.Add(ContestTypeLabel);
        Controls.Add(BerriesDataGridView);
        Controls.Add(BerriesCaptionLabel);
        Controls.Add(NameLabel);
        Controls.Add(NameCaptionLabel);
        Controls.Add(IdLabel);
        Controls.Add(IdCaptionLabel);
        MinimizeBox = false;
        Name = "BerryFlavorInfoForm";
        Text = "Berry Flavor";
        Load += BerryFlavorInfoForm_Load;
        ((System.ComponentModel.ISupportInitialize)BerriesDataGridView).EndInit();
        ((System.ComponentModel.ISupportInitialize)NamesDataGridView).EndInit();
        ResumeLayout(false);
    }

    #endregion

    private Label NameLabel;
    private Label NameCaptionLabel;
    private Label IdLabel;
    private Label IdCaptionLabel;
    private Label BerriesCaptionLabel;
    private DataGridView BerriesDataGridView;
    private Label ContestTypeLabel;
    private Label ContestTypeCaptionLabel;
    private DataGridView NamesDataGridView;
    private DataGridViewTextBoxColumn NameColumn;
    private DataGridViewTextBoxColumn LanguageColumn;
    private DataGridViewButtonColumn DetailColumn;
    private Label NamesCaptionLabel;
    private Button CloseButton;
    private Button ContestTypeInfoButton;
    private DataGridViewTextBoxColumn PotencyColumn;
    private DataGridViewTextBoxColumn BerriesColumn;
    private DataGridViewButtonColumn BerryInfoColumn;
}