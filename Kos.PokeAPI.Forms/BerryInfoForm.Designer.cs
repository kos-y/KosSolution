namespace Kos.PokeAPI.Forms;

partial class BerryInfoForm
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
        GrowthTimeLabel = new Label();
        GrowthTimeCaptionLabel = new Label();
        MaxHarvestLabel = new Label();
        NaturalGiftPowerLabel = new Label();
        MaxHarvestCaptionLabel = new Label();
        NaturalGiftPowerCaptionLabel = new Label();
        SizeLabel = new Label();
        SizeCaptionLabel = new Label();
        SmoothnessLabel = new Label();
        SmoothnessCaptionLabel = new Label();
        FirmnessLabel = new Label();
        FirmnessCaptionLabel = new Label();
        SoilDrynessLabel = new Label();
        SoilDrynessCaptionLabel = new Label();
        FirmnessDetailButton = new Button();
        FlavorsCaptionLabel = new Label();
        FlavorDataGridView = new DataGridView();
        ItemLabel = new Label();
        ItemCaptionLabel = new Label();
        ItemDetailButton = new Button();
        NaturalGiftTypeLabel = new Label();
        NaturalGiftTypeCaptionLabel = new Label();
        NaturalGiftTypeInfoButton = new Button();
        CloseButton = new Button();
        NaturalGiftGroupBox = new GroupBox();
        FlavorColumn = new DataGridViewTextBoxColumn();
        PotencyColumn = new DataGridViewTextBoxColumn();
        FlavorDetailColumn = new DataGridViewButtonColumn();
        ((System.ComponentModel.ISupportInitialize)FlavorDataGridView).BeginInit();
        NaturalGiftGroupBox.SuspendLayout();
        SuspendLayout();
        // 
        // NameLabel
        // 
        NameLabel.BorderStyle = BorderStyle.Fixed3D;
        NameLabel.Location = new Point(404, 5);
        NameLabel.Margin = new Padding(4, 0, 4, 0);
        NameLabel.Name = "NameLabel";
        NameLabel.Size = new Size(189, 26);
        NameLabel.TabIndex = 3;
        NameLabel.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // NameCaptionLabel
        // 
        NameCaptionLabel.AutoSize = true;
        NameCaptionLabel.Location = new Point(317, 10);
        NameCaptionLabel.Margin = new Padding(4, 0, 4, 0);
        NameCaptionLabel.Name = "NameCaptionLabel";
        NameCaptionLabel.Size = new Size(79, 17);
        NameCaptionLabel.TabIndex = 2;
        NameCaptionLabel.Text = "きのみの名前";
        NameCaptionLabel.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // IdLabel
        // 
        IdLabel.BorderStyle = BorderStyle.Fixed3D;
        IdLabel.Location = new Point(81, 5);
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
        IdCaptionLabel.Size = new Size(58, 17);
        IdCaptionLabel.TabIndex = 0;
        IdCaptionLabel.Text = "きのみID";
        IdCaptionLabel.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // GrowthTimeLabel
        // 
        GrowthTimeLabel.BorderStyle = BorderStyle.Fixed3D;
        GrowthTimeLabel.Location = new Point(81, 92);
        GrowthTimeLabel.Margin = new Padding(4, 0, 4, 0);
        GrowthTimeLabel.Name = "GrowthTimeLabel";
        GrowthTimeLabel.Size = new Size(189, 26);
        GrowthTimeLabel.TabIndex = 10;
        GrowthTimeLabel.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // GrowthTimeCaptionLabel
        // 
        GrowthTimeCaptionLabel.AutoSize = true;
        GrowthTimeCaptionLabel.Location = new Point(13, 97);
        GrowthTimeCaptionLabel.Margin = new Padding(4, 0, 4, 0);
        GrowthTimeCaptionLabel.Name = "GrowthTimeCaptionLabel";
        GrowthTimeCaptionLabel.Size = new Size(60, 17);
        GrowthTimeCaptionLabel.TabIndex = 9;
        GrowthTimeCaptionLabel.Text = "成長時間";
        GrowthTimeCaptionLabel.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // MaxHarvestLabel
        // 
        MaxHarvestLabel.BorderStyle = BorderStyle.Fixed3D;
        MaxHarvestLabel.Location = new Point(404, 99);
        MaxHarvestLabel.Margin = new Padding(4, 0, 4, 0);
        MaxHarvestLabel.Name = "MaxHarvestLabel";
        MaxHarvestLabel.Size = new Size(189, 26);
        MaxHarvestLabel.TabIndex = 17;
        MaxHarvestLabel.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // NaturalGiftPowerLabel
        // 
        NaturalGiftPowerLabel.BorderStyle = BorderStyle.Fixed3D;
        NaturalGiftPowerLabel.Location = new Point(68, 49);
        NaturalGiftPowerLabel.Margin = new Padding(4, 0, 4, 0);
        NaturalGiftPowerLabel.Name = "NaturalGiftPowerLabel";
        NaturalGiftPowerLabel.Size = new Size(189, 26);
        NaturalGiftPowerLabel.TabIndex = 4;
        NaturalGiftPowerLabel.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // MaxHarvestCaptionLabel
        // 
        MaxHarvestCaptionLabel.AutoSize = true;
        MaxHarvestCaptionLabel.Location = new Point(286, 95);
        MaxHarvestCaptionLabel.Margin = new Padding(4, 0, 4, 0);
        MaxHarvestCaptionLabel.Name = "MaxHarvestCaptionLabel";
        MaxHarvestCaptionLabel.Size = new Size(112, 34);
        MaxHarvestCaptionLabel.TabIndex = 16;
        MaxHarvestCaptionLabel.Text = "収穫最大数\r\n（第４世代以降）";
        MaxHarvestCaptionLabel.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // NaturalGiftPowerCaptionLabel
        // 
        NaturalGiftPowerCaptionLabel.AutoSize = true;
        NaturalGiftPowerCaptionLabel.Location = new Point(26, 54);
        NaturalGiftPowerCaptionLabel.Margin = new Padding(4, 0, 4, 0);
        NaturalGiftPowerCaptionLabel.Name = "NaturalGiftPowerCaptionLabel";
        NaturalGiftPowerCaptionLabel.Size = new Size(34, 17);
        NaturalGiftPowerCaptionLabel.TabIndex = 3;
        NaturalGiftPowerCaptionLabel.Text = "威力";
        NaturalGiftPowerCaptionLabel.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // SizeLabel
        // 
        SizeLabel.BorderStyle = BorderStyle.Fixed3D;
        SizeLabel.Location = new Point(81, 40);
        SizeLabel.Margin = new Padding(4, 0, 4, 0);
        SizeLabel.Name = "SizeLabel";
        SizeLabel.Size = new Size(189, 26);
        SizeLabel.TabIndex = 5;
        SizeLabel.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // SizeCaptionLabel
        // 
        SizeCaptionLabel.AutoSize = true;
        SizeCaptionLabel.Location = new Point(32, 45);
        SizeCaptionLabel.Margin = new Padding(4, 0, 4, 0);
        SizeCaptionLabel.Name = "SizeCaptionLabel";
        SizeCaptionLabel.Size = new Size(41, 17);
        SizeCaptionLabel.TabIndex = 4;
        SizeCaptionLabel.Text = "大きさ";
        SizeCaptionLabel.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // SmoothnessLabel
        // 
        SmoothnessLabel.BorderStyle = BorderStyle.Fixed3D;
        SmoothnessLabel.Location = new Point(404, 40);
        SmoothnessLabel.Margin = new Padding(4, 0, 4, 0);
        SmoothnessLabel.Name = "SmoothnessLabel";
        SmoothnessLabel.Size = new Size(189, 26);
        SmoothnessLabel.TabIndex = 12;
        SmoothnessLabel.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // SmoothnessCaptionLabel
        // 
        SmoothnessCaptionLabel.AutoSize = true;
        SmoothnessCaptionLabel.Location = new Point(344, 45);
        SmoothnessCaptionLabel.Margin = new Padding(4, 0, 4, 0);
        SmoothnessCaptionLabel.Name = "SmoothnessCaptionLabel";
        SmoothnessCaptionLabel.Size = new Size(52, 17);
        SmoothnessCaptionLabel.TabIndex = 11;
        SmoothnessCaptionLabel.Text = "滑らかさ";
        SmoothnessCaptionLabel.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // FirmnessLabel
        // 
        FirmnessLabel.BorderStyle = BorderStyle.Fixed3D;
        FirmnessLabel.Location = new Point(81, 66);
        FirmnessLabel.Margin = new Padding(4, 0, 4, 0);
        FirmnessLabel.Name = "FirmnessLabel";
        FirmnessLabel.Size = new Size(189, 26);
        FirmnessLabel.TabIndex = 7;
        FirmnessLabel.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // FirmnessCaptionLabel
        // 
        FirmnessCaptionLabel.AutoSize = true;
        FirmnessCaptionLabel.Location = new Point(42, 70);
        FirmnessCaptionLabel.Margin = new Padding(4, 0, 4, 0);
        FirmnessCaptionLabel.Name = "FirmnessCaptionLabel";
        FirmnessCaptionLabel.Size = new Size(31, 17);
        FirmnessCaptionLabel.TabIndex = 6;
        FirmnessCaptionLabel.Text = "硬さ";
        FirmnessCaptionLabel.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // SoilDrynessLabel
        // 
        SoilDrynessLabel.BorderStyle = BorderStyle.Fixed3D;
        SoilDrynessLabel.Location = new Point(404, 136);
        SoilDrynessLabel.Margin = new Padding(4, 0, 4, 0);
        SoilDrynessLabel.Name = "SoilDrynessLabel";
        SoilDrynessLabel.Size = new Size(189, 26);
        SoilDrynessLabel.TabIndex = 19;
        SoilDrynessLabel.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // SoilDrynessCaptionLabel
        // 
        SoilDrynessCaptionLabel.AutoSize = true;
        SoilDrynessCaptionLabel.Location = new Point(312, 141);
        SoilDrynessCaptionLabel.Margin = new Padding(4, 0, 4, 0);
        SoilDrynessCaptionLabel.Name = "SoilDrynessCaptionLabel";
        SoilDrynessCaptionLabel.Size = new Size(86, 17);
        SoilDrynessCaptionLabel.TabIndex = 18;
        SoilDrynessCaptionLabel.Text = "土壌乾燥速度";
        SoilDrynessCaptionLabel.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // FirmnessDetailButton
        // 
        FirmnessDetailButton.Location = new Point(278, 65);
        FirmnessDetailButton.Margin = new Padding(4, 3, 4, 3);
        FirmnessDetailButton.Name = "FirmnessDetailButton";
        FirmnessDetailButton.Size = new Size(45, 26);
        FirmnessDetailButton.TabIndex = 8;
        FirmnessDetailButton.Text = "詳細";
        FirmnessDetailButton.UseVisualStyleBackColor = true;
        FirmnessDetailButton.Click += FirmnessDetailButton_Click;
        // 
        // FlavorsCaptionLabel
        // 
        FlavorsCaptionLabel.AutoSize = true;
        FlavorsCaptionLabel.Location = new Point(13, 157);
        FlavorsCaptionLabel.Margin = new Padding(4, 0, 4, 0);
        FlavorsCaptionLabel.Name = "FlavorsCaptionLabel";
        FlavorsCaptionLabel.Size = new Size(21, 17);
        FlavorsCaptionLabel.TabIndex = 20;
        FlavorsCaptionLabel.Text = "味";
        FlavorsCaptionLabel.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // FlavorDataGridView
        // 
        FlavorDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        FlavorDataGridView.Columns.AddRange(new DataGridViewColumn[] { FlavorColumn, PotencyColumn, FlavorDetailColumn });
        FlavorDataGridView.Location = new Point(13, 177);
        FlavorDataGridView.Margin = new Padding(4, 3, 4, 3);
        FlavorDataGridView.Name = "FlavorDataGridView";
        FlavorDataGridView.RowHeadersVisible = false;
        FlavorDataGridView.Size = new Size(635, 170);
        FlavorDataGridView.TabIndex = 21;
        FlavorDataGridView.CellClick += FlavorDataGridView_CellClick;
        FlavorDataGridView.CellDoubleClick += FlavorDataGridView_CellDoubleClick;
        // 
        // ItemLabel
        // 
        ItemLabel.BorderStyle = BorderStyle.Fixed3D;
        ItemLabel.Location = new Point(404, 66);
        ItemLabel.Margin = new Padding(4, 0, 4, 0);
        ItemLabel.Name = "ItemLabel";
        ItemLabel.Size = new Size(189, 26);
        ItemLabel.TabIndex = 14;
        ItemLabel.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // ItemCaptionLabel
        // 
        ItemCaptionLabel.AutoSize = true;
        ItemCaptionLabel.Location = new Point(345, 71);
        ItemCaptionLabel.Margin = new Padding(4, 0, 4, 0);
        ItemCaptionLabel.Name = "ItemCaptionLabel";
        ItemCaptionLabel.Size = new Size(51, 17);
        ItemCaptionLabel.TabIndex = 13;
        ItemCaptionLabel.Text = "アイテム";
        ItemCaptionLabel.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // ItemDetailButton
        // 
        ItemDetailButton.Location = new Point(601, 65);
        ItemDetailButton.Margin = new Padding(4, 3, 4, 3);
        ItemDetailButton.Name = "ItemDetailButton";
        ItemDetailButton.Size = new Size(47, 26);
        ItemDetailButton.TabIndex = 15;
        ItemDetailButton.Text = "詳細";
        ItemDetailButton.UseVisualStyleBackColor = true;
        ItemDetailButton.Click += ItemDetailButton_Click;
        // 
        // NaturalGiftTypeLabel
        // 
        NaturalGiftTypeLabel.BorderStyle = BorderStyle.Fixed3D;
        NaturalGiftTypeLabel.Location = new Point(68, 20);
        NaturalGiftTypeLabel.Margin = new Padding(4, 0, 4, 0);
        NaturalGiftTypeLabel.Name = "NaturalGiftTypeLabel";
        NaturalGiftTypeLabel.Size = new Size(189, 26);
        NaturalGiftTypeLabel.TabIndex = 1;
        NaturalGiftTypeLabel.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // NaturalGiftTypeCaptionLabel
        // 
        NaturalGiftTypeCaptionLabel.AutoSize = true;
        NaturalGiftTypeCaptionLabel.Location = new Point(7, 24);
        NaturalGiftTypeCaptionLabel.Margin = new Padding(4, 0, 4, 0);
        NaturalGiftTypeCaptionLabel.Name = "NaturalGiftTypeCaptionLabel";
        NaturalGiftTypeCaptionLabel.Size = new Size(53, 17);
        NaturalGiftTypeCaptionLabel.TabIndex = 0;
        NaturalGiftTypeCaptionLabel.Text = "技タイプ";
        NaturalGiftTypeCaptionLabel.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // NaturalGiftTypeInfoButton
        // 
        NaturalGiftTypeInfoButton.Location = new Point(265, 20);
        NaturalGiftTypeInfoButton.Margin = new Padding(4, 3, 4, 3);
        NaturalGiftTypeInfoButton.Name = "NaturalGiftTypeInfoButton";
        NaturalGiftTypeInfoButton.Size = new Size(42, 26);
        NaturalGiftTypeInfoButton.TabIndex = 2;
        NaturalGiftTypeInfoButton.Text = "詳細";
        NaturalGiftTypeInfoButton.UseVisualStyleBackColor = true;
        // 
        // CloseButton
        // 
        CloseButton.Location = new Point(572, 415);
        CloseButton.Margin = new Padding(4, 3, 4, 3);
        CloseButton.Name = "CloseButton";
        CloseButton.Size = new Size(76, 26);
        CloseButton.TabIndex = 23;
        CloseButton.Text = "閉じる";
        CloseButton.UseVisualStyleBackColor = true;
        CloseButton.Click += CloseButton_Click;
        // 
        // NaturalGiftGroupBox
        // 
        NaturalGiftGroupBox.Controls.Add(NaturalGiftTypeCaptionLabel);
        NaturalGiftGroupBox.Controls.Add(NaturalGiftTypeLabel);
        NaturalGiftGroupBox.Controls.Add(NaturalGiftTypeInfoButton);
        NaturalGiftGroupBox.Controls.Add(NaturalGiftPowerCaptionLabel);
        NaturalGiftGroupBox.Controls.Add(NaturalGiftPowerLabel);
        NaturalGiftGroupBox.Location = new Point(13, 353);
        NaturalGiftGroupBox.Name = "NaturalGiftGroupBox";
        NaturalGiftGroupBox.Size = new Size(321, 88);
        NaturalGiftGroupBox.TabIndex = 22;
        NaturalGiftGroupBox.TabStop = false;
        NaturalGiftGroupBox.Text = "しぜんのめぐみ";
        // 
        // FlavorColumn
        // 
        FlavorColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
        FlavorColumn.DataPropertyName = "Flavor";
        FlavorColumn.HeaderText = "味";
        FlavorColumn.Name = "FlavorColumn";
        FlavorColumn.ReadOnly = true;
        FlavorColumn.Width = 46;
        // 
        // PotencyColumn
        // 
        PotencyColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
        PotencyColumn.DataPropertyName = "Potency";
        PotencyColumn.HeaderText = "強さ";
        PotencyColumn.Name = "PotencyColumn";
        PotencyColumn.ReadOnly = true;
        PotencyColumn.Width = 56;
        // 
        // FlavorDetailColumn
        // 
        FlavorDetailColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
        FlavorDetailColumn.HeaderText = "詳細";
        FlavorDetailColumn.Name = "FlavorDetailColumn";
        FlavorDetailColumn.ReadOnly = true;
        FlavorDetailColumn.Text = "詳細";
        FlavorDetailColumn.UseColumnTextForButtonValue = true;
        FlavorDetailColumn.Width = 40;
        // 
        // BerryInfoForm
        // 
        AutoScaleDimensions = new SizeF(9F, 17F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(658, 454);
        Controls.Add(NaturalGiftGroupBox);
        Controls.Add(CloseButton);
        Controls.Add(ItemDetailButton);
        Controls.Add(ItemCaptionLabel);
        Controls.Add(ItemLabel);
        Controls.Add(FlavorDataGridView);
        Controls.Add(FlavorsCaptionLabel);
        Controls.Add(FirmnessDetailButton);
        Controls.Add(SoilDrynessCaptionLabel);
        Controls.Add(SoilDrynessLabel);
        Controls.Add(FirmnessCaptionLabel);
        Controls.Add(FirmnessLabel);
        Controls.Add(SmoothnessCaptionLabel);
        Controls.Add(SmoothnessLabel);
        Controls.Add(SizeCaptionLabel);
        Controls.Add(SizeLabel);
        Controls.Add(MaxHarvestCaptionLabel);
        Controls.Add(MaxHarvestLabel);
        Controls.Add(GrowthTimeCaptionLabel);
        Controls.Add(GrowthTimeLabel);
        Controls.Add(NameLabel);
        Controls.Add(NameCaptionLabel);
        Controls.Add(IdLabel);
        Controls.Add(IdCaptionLabel);
        Font = new Font("Meiryo UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 128);
        FormBorderStyle = FormBorderStyle.FixedSingle;
        Margin = new Padding(4, 3, 4, 3);
        MaximizeBox = false;
        Name = "BerryInfoForm";
        StartPosition = FormStartPosition.CenterParent;
        Text = "きのみ";
        Load += BerryInfoForm_Load;
        ((System.ComponentModel.ISupportInitialize)FlavorDataGridView).EndInit();
        NaturalGiftGroupBox.ResumeLayout(false);
        NaturalGiftGroupBox.PerformLayout();
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private Label NameLabel;
    private Label NameCaptionLabel;
    private Label IdLabel;
    private Label IdCaptionLabel;
    private Label GrowthTimeLabel;
    private Label GrowthTimeCaptionLabel;
    private Label MaxHarvestLabel;
    private Label NaturalGiftPowerLabel;
    private Label MaxHarvestCaptionLabel;
    private Label NaturalGiftPowerCaptionLabel;
    private Label SizeLabel;
    private Label SizeCaptionLabel;
    private Label SmoothnessLabel;
    private Label SmoothnessCaptionLabel;
    private Label FirmnessLabel;
    private Label FirmnessCaptionLabel;
    private Label SoilDrynessLabel;
    private Label SoilDrynessCaptionLabel;
    private Button FirmnessDetailButton;
    private Label FlavorsCaptionLabel;
    private DataGridView FlavorDataGridView;
    private Label ItemLabel;
    private Label ItemCaptionLabel;
    private Button ItemDetailButton;
    private Label NaturalGiftTypeLabel;
    private Label NaturalGiftTypeCaptionLabel;
    private Button NaturalGiftTypeInfoButton;
    private Button CloseButton;
    private GroupBox NaturalGiftGroupBox;
    private DataGridViewTextBoxColumn FlavorColumn;
    private DataGridViewTextBoxColumn PotencyColumn;
    private DataGridViewButtonColumn FlavorDetailColumn;
}
