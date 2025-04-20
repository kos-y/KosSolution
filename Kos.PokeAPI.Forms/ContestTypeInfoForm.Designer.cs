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
        NameLabel = new Label();
        NameCaptionLabel = new Label();
        IdLabel = new Label();
        IdCaptionLabel = new Label();
        BerryFlavorLabel = new Label();
        BerryFlavorCaptionLabel = new Label();
        BerryFlavorInfoButton = new Button();
        NamesDataGridView = new DataGridView();
        NameColumn = new DataGridViewTextBoxColumn();
        ColorColumn = new DataGridViewTextBoxColumn();
        LanguageColumn = new DataGridViewTextBoxColumn();
        DetailColumn = new DataGridViewButtonColumn();
        NamesCaptionLabel = new Label();
        CloseButton = new Button();
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
        // BerryFlavorLabel
        // 
        BerryFlavorLabel.BorderStyle = BorderStyle.Fixed3D;
        BerryFlavorLabel.Location = new Point(117, 55);
        BerryFlavorLabel.Name = "BerryFlavorLabel";
        BerryFlavorLabel.Size = new Size(147, 23);
        BerryFlavorLabel.TabIndex = 5;
        BerryFlavorLabel.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // BerryFlavorCaptionLabel
        // 
        BerryFlavorCaptionLabel.Location = new Point(12, 55);
        BerryFlavorCaptionLabel.Name = "BerryFlavorCaptionLabel";
        BerryFlavorCaptionLabel.Size = new Size(99, 23);
        BerryFlavorCaptionLabel.TabIndex = 4;
        BerryFlavorCaptionLabel.Text = "berry_flavor";
        BerryFlavorCaptionLabel.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // BerryFlavorInfoButton
        // 
        BerryFlavorInfoButton.Location = new Point(270, 55);
        BerryFlavorInfoButton.Name = "BerryFlavorInfoButton";
        BerryFlavorInfoButton.Size = new Size(43, 23);
        BerryFlavorInfoButton.TabIndex = 6;
        BerryFlavorInfoButton.Text = "Info...";
        BerryFlavorInfoButton.UseVisualStyleBackColor = true;
        BerryFlavorInfoButton.Click += BerryFlavorInfoButton_Click;
        // 
        // NamesDataGridView
        // 
        NamesDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        NamesDataGridView.Columns.AddRange(new DataGridViewColumn[] { NameColumn, ColorColumn, LanguageColumn, DetailColumn });
        NamesDataGridView.Location = new Point(117, 81);
        NamesDataGridView.Name = "NamesDataGridView";
        NamesDataGridView.RowHeadersVisible = false;
        NamesDataGridView.Size = new Size(434, 150);
        NamesDataGridView.TabIndex = 8;
        NamesDataGridView.CellClick += NamesDataGridView_CellClick;
        NamesDataGridView.CellDoubleClick += NamesDataGridView_CellDoubleClick;
        // 
        // NameColumn
        // 
        NameColumn.DataPropertyName = "Name";
        NameColumn.HeaderText = "name";
        NameColumn.Name = "NameColumn";
        NameColumn.ReadOnly = true;
        // 
        // ColorColumn
        // 
        ColorColumn.DataPropertyName = "Color";
        ColorColumn.HeaderText = "color";
        ColorColumn.Name = "ColorColumn";
        ColorColumn.ReadOnly = true;
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
        DetailColumn.HeaderText = "Lang Info";
        DetailColumn.Name = "DetailColumn";
        DetailColumn.Text = "Info..";
        DetailColumn.UseColumnTextForButtonValue = true;
        // 
        // NamesCaptionLabel
        // 
        NamesCaptionLabel.Location = new Point(12, 81);
        NamesCaptionLabel.Name = "NamesCaptionLabel";
        NamesCaptionLabel.Size = new Size(99, 23);
        NamesCaptionLabel.TabIndex = 7;
        NamesCaptionLabel.Text = "names";
        NamesCaptionLabel.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // CloseButton
        // 
        CloseButton.Location = new Point(476, 237);
        CloseButton.Name = "CloseButton";
        CloseButton.Size = new Size(75, 23);
        CloseButton.TabIndex = 9;
        CloseButton.Text = "Close";
        CloseButton.UseVisualStyleBackColor = true;
        CloseButton.Click += CloseButton_Click;
        // 
        // ContestTypeInfoForm
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(564, 270);
        Controls.Add(CloseButton);
        Controls.Add(NamesCaptionLabel);
        Controls.Add(NamesDataGridView);
        Controls.Add(BerryFlavorInfoButton);
        Controls.Add(BerryFlavorCaptionLabel);
        Controls.Add(BerryFlavorLabel);
        Controls.Add(NameLabel);
        Controls.Add(NameCaptionLabel);
        Controls.Add(IdLabel);
        Controls.Add(IdCaptionLabel);
        MaximizeBox = false;
        Name = "ContestTypeInfoForm";
        Text = "Contest Type";
        Load += ContestTypeInfoForm_Load;
        ((System.ComponentModel.ISupportInitialize)NamesDataGridView).EndInit();
        ResumeLayout(false);
    }

    #endregion

    private Label NameLabel;
    private Label NameCaptionLabel;
    private Label IdLabel;
    private Label IdCaptionLabel;
    private Label BerryFlavorLabel;
    private Label BerryFlavorCaptionLabel;
    private Button BerryFlavorInfoButton;
    private DataGridView NamesDataGridView;
    private Label NamesCaptionLabel;
    private Button CloseButton;
    private DataGridViewTextBoxColumn NameColumn;
    private DataGridViewTextBoxColumn ColorColumn;
    private DataGridViewTextBoxColumn LanguageColumn;
    private DataGridViewButtonColumn DetailColumn;
}
