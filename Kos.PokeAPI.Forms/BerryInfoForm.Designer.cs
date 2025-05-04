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
        NameCaptionLabel = new Label();
        IdCaptionLabel = new Label();
        GrowthTimeCaptionLabel = new Label();
        MaxHarvestCaptionLabel = new Label();
        NaturalGiftPowerCaptionLabel = new Label();
        SizeCaptionLabel = new Label();
        SmoothnessCaptionLabel = new Label();
        FirmnessCaptionLabel = new Label();
        SoilDrynessCaptionLabel = new Label();
        FirmnessDetailButton = new Button();
        FlavorsCaptionLabel = new Label();
        FlavorDataGridView = new DataGridView();
        FlavorColumn = new DataGridViewTextBoxColumn();
        PotencyColumn = new DataGridViewTextBoxColumn();
        FlavorDetailColumn = new DataGridViewButtonColumn();
        ItemCaptionLabel = new Label();
        ItemDetailButton = new Button();
        NaturalGiftTypeCaptionLabel = new Label();
        NaturalGiftTypeDetailButton = new Button();
        CloseButton = new Button();
        NaturalGiftGroupBox = new GroupBox();
        NaturalGiftPowerTextBox = new TextBox();
        NaturalGiftTypeTextBox = new TextBox();
        IdTextBox = new TextBox();
        NameTextBox = new TextBox();
        SizeTextBox = new TextBox();
        SmoothnessTextBox = new TextBox();
        FirmnessTextBox = new TextBox();
        ItemTextBox = new TextBox();
        GrowthTimeTextBox = new TextBox();
        MaxHarvestTextBox = new TextBox();
        SoilDrynessTextBox = new TextBox();
        ((System.ComponentModel.ISupportInitialize)FlavorDataGridView).BeginInit();
        NaturalGiftGroupBox.SuspendLayout();
        SuspendLayout();
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
        // GrowthTimeCaptionLabel
        // 
        GrowthTimeCaptionLabel.AutoSize = true;
        GrowthTimeCaptionLabel.Location = new Point(13, 105);
        GrowthTimeCaptionLabel.Margin = new Padding(4, 0, 4, 0);
        GrowthTimeCaptionLabel.Name = "GrowthTimeCaptionLabel";
        GrowthTimeCaptionLabel.Size = new Size(60, 17);
        GrowthTimeCaptionLabel.TabIndex = 9;
        GrowthTimeCaptionLabel.Text = "成長時間";
        GrowthTimeCaptionLabel.TextAlign = ContentAlignment.MiddleLeft;
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
        // FirmnessCaptionLabel
        // 
        FirmnessCaptionLabel.AutoSize = true;
        FirmnessCaptionLabel.Location = new Point(42, 75);
        FirmnessCaptionLabel.Margin = new Padding(4, 0, 4, 0);
        FirmnessCaptionLabel.Name = "FirmnessCaptionLabel";
        FirmnessCaptionLabel.Size = new Size(31, 17);
        FirmnessCaptionLabel.TabIndex = 6;
        FirmnessCaptionLabel.Text = "硬さ";
        FirmnessCaptionLabel.TextAlign = ContentAlignment.MiddleLeft;
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
        FirmnessDetailButton.Location = new Point(278, 70);
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
        // ItemCaptionLabel
        // 
        ItemCaptionLabel.AutoSize = true;
        ItemCaptionLabel.Location = new Point(345, 75);
        ItemCaptionLabel.Margin = new Padding(4, 0, 4, 0);
        ItemCaptionLabel.Name = "ItemCaptionLabel";
        ItemCaptionLabel.Size = new Size(51, 17);
        ItemCaptionLabel.TabIndex = 13;
        ItemCaptionLabel.Text = "アイテム";
        ItemCaptionLabel.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // ItemDetailButton
        // 
        ItemDetailButton.Location = new Point(600, 70);
        ItemDetailButton.Margin = new Padding(4, 3, 4, 3);
        ItemDetailButton.Name = "ItemDetailButton";
        ItemDetailButton.Size = new Size(47, 26);
        ItemDetailButton.TabIndex = 15;
        ItemDetailButton.Text = "詳細";
        ItemDetailButton.UseVisualStyleBackColor = true;
        ItemDetailButton.Click += ItemDetailButton_Click;
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
        // NaturalGiftTypeDetailButton
        // 
        NaturalGiftTypeDetailButton.Location = new Point(265, 19);
        NaturalGiftTypeDetailButton.Margin = new Padding(4, 3, 4, 3);
        NaturalGiftTypeDetailButton.Name = "NaturalGiftTypeDetailButton";
        NaturalGiftTypeDetailButton.Size = new Size(42, 26);
        NaturalGiftTypeDetailButton.TabIndex = 2;
        NaturalGiftTypeDetailButton.Text = "詳細";
        NaturalGiftTypeDetailButton.UseVisualStyleBackColor = true;
        // 
        // CloseButton
        // 
        CloseButton.Location = new Point(572, 402);
        CloseButton.Margin = new Padding(4, 3, 4, 3);
        CloseButton.Name = "CloseButton";
        CloseButton.Size = new Size(76, 39);
        CloseButton.TabIndex = 23;
        CloseButton.Text = "閉じる";
        CloseButton.UseVisualStyleBackColor = true;
        CloseButton.Click += CloseButton_Click;
        // 
        // NaturalGiftGroupBox
        // 
        NaturalGiftGroupBox.Controls.Add(NaturalGiftPowerTextBox);
        NaturalGiftGroupBox.Controls.Add(NaturalGiftTypeTextBox);
        NaturalGiftGroupBox.Controls.Add(NaturalGiftTypeCaptionLabel);
        NaturalGiftGroupBox.Controls.Add(NaturalGiftTypeDetailButton);
        NaturalGiftGroupBox.Controls.Add(NaturalGiftPowerCaptionLabel);
        NaturalGiftGroupBox.Location = new Point(13, 353);
        NaturalGiftGroupBox.Name = "NaturalGiftGroupBox";
        NaturalGiftGroupBox.Size = new Size(321, 88);
        NaturalGiftGroupBox.TabIndex = 22;
        NaturalGiftGroupBox.TabStop = false;
        NaturalGiftGroupBox.Text = "しぜんのめぐみ";
        // 
        // NaturalGiftPowerTextBox
        // 
        NaturalGiftPowerTextBox.Location = new Point(67, 51);
        NaturalGiftPowerTextBox.Name = "NaturalGiftPowerTextBox";
        NaturalGiftPowerTextBox.ReadOnly = true;
        NaturalGiftPowerTextBox.Size = new Size(190, 24);
        NaturalGiftPowerTextBox.TabIndex = 4;
        // 
        // NaturalGiftTypeTextBox
        // 
        NaturalGiftTypeTextBox.Location = new Point(68, 21);
        NaturalGiftTypeTextBox.Name = "NaturalGiftTypeTextBox";
        NaturalGiftTypeTextBox.ReadOnly = true;
        NaturalGiftTypeTextBox.Size = new Size(190, 24);
        NaturalGiftTypeTextBox.TabIndex = 1;
        // 
        // IdTextBox
        // 
        IdTextBox.Location = new Point(80, 7);
        IdTextBox.Name = "IdTextBox";
        IdTextBox.ReadOnly = true;
        IdTextBox.Size = new Size(190, 24);
        IdTextBox.TabIndex = 1;
        // 
        // NameTextBox
        // 
        NameTextBox.Location = new Point(403, 7);
        NameTextBox.Name = "NameTextBox";
        NameTextBox.ReadOnly = true;
        NameTextBox.Size = new Size(190, 24);
        NameTextBox.TabIndex = 3;
        // 
        // SizeTextBox
        // 
        SizeTextBox.Location = new Point(81, 42);
        SizeTextBox.Name = "SizeTextBox";
        SizeTextBox.ReadOnly = true;
        SizeTextBox.Size = new Size(190, 24);
        SizeTextBox.TabIndex = 5;
        // 
        // SmoothnessTextBox
        // 
        SmoothnessTextBox.Location = new Point(404, 42);
        SmoothnessTextBox.Name = "SmoothnessTextBox";
        SmoothnessTextBox.ReadOnly = true;
        SmoothnessTextBox.Size = new Size(190, 24);
        SmoothnessTextBox.TabIndex = 12;
        // 
        // FirmnessTextBox
        // 
        FirmnessTextBox.Location = new Point(81, 72);
        FirmnessTextBox.Name = "FirmnessTextBox";
        FirmnessTextBox.ReadOnly = true;
        FirmnessTextBox.Size = new Size(190, 24);
        FirmnessTextBox.TabIndex = 7;
        // 
        // ItemTextBox
        // 
        ItemTextBox.Location = new Point(403, 72);
        ItemTextBox.Name = "ItemTextBox";
        ItemTextBox.ReadOnly = true;
        ItemTextBox.Size = new Size(190, 24);
        ItemTextBox.TabIndex = 14;
        // 
        // GrowthTimeTextBox
        // 
        GrowthTimeTextBox.Location = new Point(80, 102);
        GrowthTimeTextBox.Name = "GrowthTimeTextBox";
        GrowthTimeTextBox.ReadOnly = true;
        GrowthTimeTextBox.Size = new Size(190, 24);
        GrowthTimeTextBox.TabIndex = 10;
        // 
        // MaxHarvestTextBox
        // 
        MaxHarvestTextBox.Location = new Point(404, 102);
        MaxHarvestTextBox.Name = "MaxHarvestTextBox";
        MaxHarvestTextBox.ReadOnly = true;
        MaxHarvestTextBox.Size = new Size(190, 24);
        MaxHarvestTextBox.TabIndex = 17;
        // 
        // SoilDrynessTextBox
        // 
        SoilDrynessTextBox.Location = new Point(404, 138);
        SoilDrynessTextBox.Name = "SoilDrynessTextBox";
        SoilDrynessTextBox.ReadOnly = true;
        SoilDrynessTextBox.Size = new Size(190, 24);
        SoilDrynessTextBox.TabIndex = 19;
        // 
        // BerryInfoForm
        // 
        AutoScaleDimensions = new SizeF(9F, 17F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(658, 452);
        Controls.Add(SoilDrynessTextBox);
        Controls.Add(MaxHarvestTextBox);
        Controls.Add(GrowthTimeTextBox);
        Controls.Add(ItemTextBox);
        Controls.Add(FirmnessTextBox);
        Controls.Add(SmoothnessTextBox);
        Controls.Add(SizeTextBox);
        Controls.Add(NameTextBox);
        Controls.Add(IdTextBox);
        Controls.Add(NaturalGiftGroupBox);
        Controls.Add(CloseButton);
        Controls.Add(ItemDetailButton);
        Controls.Add(ItemCaptionLabel);
        Controls.Add(FlavorDataGridView);
        Controls.Add(FlavorsCaptionLabel);
        Controls.Add(FirmnessDetailButton);
        Controls.Add(SoilDrynessCaptionLabel);
        Controls.Add(FirmnessCaptionLabel);
        Controls.Add(SmoothnessCaptionLabel);
        Controls.Add(SizeCaptionLabel);
        Controls.Add(MaxHarvestCaptionLabel);
        Controls.Add(GrowthTimeCaptionLabel);
        Controls.Add(NameCaptionLabel);
        Controls.Add(IdCaptionLabel);
        Font = new Font("Meiryo UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 128);
        FormBorderStyle = FormBorderStyle.FixedSingle;
        Margin = new Padding(4, 3, 4, 3);
        MaximizeBox = false;
        Name = "BerryInfoForm";
        StartPosition = FormStartPosition.CenterParent;
        Text = "きのみの硬さ";
        Load += BerryInfoForm_Load;
        ((System.ComponentModel.ISupportInitialize)FlavorDataGridView).EndInit();
        NaturalGiftGroupBox.ResumeLayout(false);
        NaturalGiftGroupBox.PerformLayout();
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion
    private Label NameCaptionLabel;
    private Label IdCaptionLabel;
    private Label GrowthTimeCaptionLabel;
    private Label MaxHarvestCaptionLabel;
    private Label NaturalGiftPowerCaptionLabel;
    private Label SizeCaptionLabel;
    private Label SmoothnessCaptionLabel;
    private Label FirmnessCaptionLabel;
    private Label SoilDrynessCaptionLabel;
    private Button FirmnessDetailButton;
    private Label FlavorsCaptionLabel;
    private DataGridView FlavorDataGridView;
    private Label ItemCaptionLabel;
    private Button ItemDetailButton;
    private Label NaturalGiftTypeCaptionLabel;
    private Button NaturalGiftTypeDetailButton;
    private Button CloseButton;
    private GroupBox NaturalGiftGroupBox;
    private DataGridViewTextBoxColumn FlavorColumn;
    private DataGridViewTextBoxColumn PotencyColumn;
    private DataGridViewButtonColumn FlavorDetailColumn;
    private TextBox NaturalGiftTypeTextBox;
    private TextBox IdTextBox;
    private TextBox NameTextBox;
    private TextBox SizeTextBox;
    private TextBox SmoothnessTextBox;
    private TextBox FirmnessTextBox;
    private TextBox ItemTextBox;
    private TextBox GrowthTimeTextBox;
    private TextBox MaxHarvestTextBox;
    private TextBox SoilDrynessTextBox;
    private TextBox NaturalGiftPowerTextBox;
}
