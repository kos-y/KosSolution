namespace Kos.PokeAPI.Utility.Forms;

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
        IdLabel = new Label();
        NameCaptionLabel = new Label();
        NameLabel = new Label();
        OfficialCaptionLabel = new Label();
        OfficialLabel = new Label();
        Iso639CaptionLabel = new Label();
        Iso639Label = new Label();
        Iso3166CaptionLabel = new Label();
        Iso3166Label = new Label();
        NamesCaptionLabel = new Label();
        NamesDataGridView = new DataGridView();
        NameColumn = new DataGridViewTextBoxColumn();
        LanguageColumn = new DataGridViewTextBoxColumn();
        DetailColumn = new DataGridViewButtonColumn();
        CloseButton = new Button();
        ((System.ComponentModel.ISupportInitialize)NamesDataGridView).BeginInit();
        SuspendLayout();
        // 
        // IdCaptionLabel
        // 
        IdCaptionLabel.Location = new Point(12, 10);
        IdCaptionLabel.Name = "IdCaptionLabel";
        IdCaptionLabel.Size = new Size(99, 23);
        IdCaptionLabel.TabIndex = 0;
        IdCaptionLabel.Text = "id";
        IdCaptionLabel.TextAlign = ContentAlignment.MiddleLeft;
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
        // NameCaptionLabel
        // 
        NameCaptionLabel.Location = new Point(12, 33);
        NameCaptionLabel.Name = "NameCaptionLabel";
        NameCaptionLabel.Size = new Size(99, 23);
        NameCaptionLabel.TabIndex = 2;
        NameCaptionLabel.Text = "name";
        NameCaptionLabel.TextAlign = ContentAlignment.MiddleLeft;
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
        // OfficialCaptionLabel
        // 
        OfficialCaptionLabel.Location = new Point(12, 56);
        OfficialCaptionLabel.Name = "OfficialCaptionLabel";
        OfficialCaptionLabel.Size = new Size(99, 23);
        OfficialCaptionLabel.TabIndex = 4;
        OfficialCaptionLabel.Text = "official";
        OfficialCaptionLabel.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // OfficialLabel
        // 
        OfficialLabel.BorderStyle = BorderStyle.Fixed3D;
        OfficialLabel.Location = new Point(117, 55);
        OfficialLabel.Name = "OfficialLabel";
        OfficialLabel.Size = new Size(147, 23);
        OfficialLabel.TabIndex = 5;
        OfficialLabel.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // Iso639CaptionLabel
        // 
        Iso639CaptionLabel.Location = new Point(12, 78);
        Iso639CaptionLabel.Name = "Iso639CaptionLabel";
        Iso639CaptionLabel.Size = new Size(99, 23);
        Iso639CaptionLabel.TabIndex = 6;
        Iso639CaptionLabel.Text = "iso639";
        Iso639CaptionLabel.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // Iso639Label
        // 
        Iso639Label.BorderStyle = BorderStyle.Fixed3D;
        Iso639Label.Location = new Point(117, 78);
        Iso639Label.Name = "Iso639Label";
        Iso639Label.Size = new Size(147, 23);
        Iso639Label.TabIndex = 7;
        Iso639Label.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // Iso3166CaptionLabel
        // 
        Iso3166CaptionLabel.Location = new Point(12, 101);
        Iso3166CaptionLabel.Name = "Iso3166CaptionLabel";
        Iso3166CaptionLabel.Size = new Size(99, 23);
        Iso3166CaptionLabel.TabIndex = 8;
        Iso3166CaptionLabel.Text = "iso3166";
        Iso3166CaptionLabel.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // Iso3166Label
        // 
        Iso3166Label.BorderStyle = BorderStyle.Fixed3D;
        Iso3166Label.Location = new Point(117, 101);
        Iso3166Label.Name = "Iso3166Label";
        Iso3166Label.Size = new Size(147, 23);
        Iso3166Label.TabIndex = 9;
        Iso3166Label.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // NamesCaptionLabel
        // 
        NamesCaptionLabel.Location = new Point(12, 127);
        NamesCaptionLabel.Name = "NamesCaptionLabel";
        NamesCaptionLabel.Size = new Size(99, 23);
        NamesCaptionLabel.TabIndex = 10;
        NamesCaptionLabel.Text = "names";
        NamesCaptionLabel.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // NamesDataGridView
        // 
        NamesDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        NamesDataGridView.Columns.AddRange(new DataGridViewColumn[] { NameColumn, LanguageColumn, DetailColumn });
        NamesDataGridView.Location = new Point(117, 127);
        NamesDataGridView.Name = "NamesDataGridView";
        NamesDataGridView.RowHeadersVisible = false;
        NamesDataGridView.Size = new Size(434, 150);
        NamesDataGridView.TabIndex = 11;
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
        // CloseButton
        // 
        CloseButton.Location = new Point(476, 283);
        CloseButton.Name = "CloseButton";
        CloseButton.Size = new Size(75, 23);
        CloseButton.TabIndex = 12;
        CloseButton.Text = "Close";
        CloseButton.UseVisualStyleBackColor = true;
        CloseButton.Click += CloseButton_Click;
        // 
        // LanguageInfoForm
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(562, 314);
        Controls.Add(CloseButton);
        Controls.Add(NamesDataGridView);
        Controls.Add(NamesCaptionLabel);
        Controls.Add(Iso3166Label);
        Controls.Add(Iso3166CaptionLabel);
        Controls.Add(Iso639Label);
        Controls.Add(Iso639CaptionLabel);
        Controls.Add(OfficialLabel);
        Controls.Add(OfficialCaptionLabel);
        Controls.Add(NameLabel);
        Controls.Add(NameCaptionLabel);
        Controls.Add(IdLabel);
        Controls.Add(IdCaptionLabel);
        MaximizeBox = false;
        Name = "LanguageInfoForm";
        Text = "Language";
        Load += LanguageInfo_Load;
        ((System.ComponentModel.ISupportInitialize)NamesDataGridView).EndInit();
        ResumeLayout(false);
    }

    #endregion

    private Label IdCaptionLabel;
    private Label IdLabel;
    private Label NameCaptionLabel;
    private Label NameLabel;
    private Label OfficialCaptionLabel;
    private Label OfficialLabel;
    private Label Iso639CaptionLabel;
    private Label Iso639Label;
    private Label Iso3166CaptionLabel;
    private Label Iso3166Label;
    private Label NamesCaptionLabel;
    private DataGridView NamesDataGridView;
    private Button CloseButton;
    private DataGridViewTextBoxColumn NameColumn;
    private DataGridViewTextBoxColumn LanguageColumn;
    private DataGridViewButtonColumn DetailColumn;
}