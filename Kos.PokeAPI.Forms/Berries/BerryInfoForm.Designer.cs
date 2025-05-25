namespace Kos.PokeAPI.Forms.Berries;

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
        SoilDrynessCaptionLabel = new Label();
        FirmnessButton = new Button();
        FlavorsCaptionLabel = new Label();
        FlavorsDataGridView = new DataGridView();
        FlavorColumn = new DataGridViewTextBoxColumn();
        PotencyColumn = new DataGridViewTextBoxColumn();
        FlavorDetailColumn = new DataGridViewButtonColumn();
        ItemButton = new Button();
        NaturalGiftTypeButton = new Button();
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
        PropertyButton = new Button();
        ((System.ComponentModel.ISupportInitialize)FlavorsDataGridView).BeginInit();
        NaturalGiftGroupBox.SuspendLayout();
        SuspendLayout();
        // 
        // NameCaptionLabel
        // 
        NameCaptionLabel.AutoSize = true;
        NameCaptionLabel.Location = new Point(35, 35);
        NameCaptionLabel.Name = "NameCaptionLabel";
        NameCaptionLabel.Size = new Size(71, 15);
        NameCaptionLabel.TabIndex = 2;
        NameCaptionLabel.Text = "きのみの名前";
        NameCaptionLabel.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // IdCaptionLabel
        // 
        IdCaptionLabel.AutoSize = true;
        IdCaptionLabel.Location = new Point(49, 9);
        IdCaptionLabel.Name = "IdCaptionLabel";
        IdCaptionLabel.Size = new Size(48, 15);
        IdCaptionLabel.TabIndex = 0;
        IdCaptionLabel.Text = "きのみID";
        IdCaptionLabel.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // GrowthTimeCaptionLabel
        // 
        GrowthTimeCaptionLabel.AutoSize = true;
        GrowthTimeCaptionLabel.Location = new Point(49, 115);
        GrowthTimeCaptionLabel.Name = "GrowthTimeCaptionLabel";
        GrowthTimeCaptionLabel.Size = new Size(55, 15);
        GrowthTimeCaptionLabel.TabIndex = 8;
        GrowthTimeCaptionLabel.Text = "成長時間";
        GrowthTimeCaptionLabel.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // MaxHarvestCaptionLabel
        // 
        MaxHarvestCaptionLabel.AutoSize = true;
        MaxHarvestCaptionLabel.Location = new Point(11, 188);
        MaxHarvestCaptionLabel.Name = "MaxHarvestCaptionLabel";
        MaxHarvestCaptionLabel.Size = new Size(103, 30);
        MaxHarvestCaptionLabel.TabIndex = 14;
        MaxHarvestCaptionLabel.Text = "収穫最大数\r\n（第４世代以降）";
        MaxHarvestCaptionLabel.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // NaturalGiftPowerCaptionLabel
        // 
        NaturalGiftPowerCaptionLabel.AutoSize = true;
        NaturalGiftPowerCaptionLabel.Location = new Point(20, 48);
        NaturalGiftPowerCaptionLabel.Name = "NaturalGiftPowerCaptionLabel";
        NaturalGiftPowerCaptionLabel.Size = new Size(31, 15);
        NaturalGiftPowerCaptionLabel.TabIndex = 2;
        NaturalGiftPowerCaptionLabel.Text = "威力";
        NaturalGiftPowerCaptionLabel.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // SizeCaptionLabel
        // 
        SizeCaptionLabel.AutoSize = true;
        SizeCaptionLabel.Location = new Point(62, 62);
        SizeCaptionLabel.Name = "SizeCaptionLabel";
        SizeCaptionLabel.Size = new Size(36, 15);
        SizeCaptionLabel.TabIndex = 4;
        SizeCaptionLabel.Text = "大きさ";
        SizeCaptionLabel.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // SmoothnessCaptionLabel
        // 
        SmoothnessCaptionLabel.AutoSize = true;
        SmoothnessCaptionLabel.Location = new Point(55, 141);
        SmoothnessCaptionLabel.Name = "SmoothnessCaptionLabel";
        SmoothnessCaptionLabel.Size = new Size(46, 15);
        SmoothnessCaptionLabel.TabIndex = 10;
        SmoothnessCaptionLabel.Text = "滑らかさ";
        SmoothnessCaptionLabel.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // SoilDrynessCaptionLabel
        // 
        SoilDrynessCaptionLabel.AutoSize = true;
        SoilDrynessCaptionLabel.Location = new Point(31, 221);
        SoilDrynessCaptionLabel.Name = "SoilDrynessCaptionLabel";
        SoilDrynessCaptionLabel.Size = new Size(79, 15);
        SoilDrynessCaptionLabel.TabIndex = 16;
        SoilDrynessCaptionLabel.Text = "土壌乾燥速度";
        SoilDrynessCaptionLabel.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // FirmnessButton
        // 
        FirmnessButton.Location = new Point(59, 84);
        FirmnessButton.Name = "FirmnessButton";
        FirmnessButton.Size = new Size(35, 23);
        FirmnessButton.TabIndex = 6;
        FirmnessButton.Text = "硬さ";
        FirmnessButton.UseVisualStyleBackColor = true;
        FirmnessButton.Click += FirmnessButton_Click;
        // 
        // FlavorsCaptionLabel
        // 
        FlavorsCaptionLabel.AutoSize = true;
        FlavorsCaptionLabel.Location = new Point(255, 8);
        FlavorsCaptionLabel.Name = "FlavorsCaptionLabel";
        FlavorsCaptionLabel.Size = new Size(19, 15);
        FlavorsCaptionLabel.TabIndex = 18;
        FlavorsCaptionLabel.Text = "味";
        FlavorsCaptionLabel.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // FlavorsDataGridView
        // 
        FlavorsDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        FlavorsDataGridView.Columns.AddRange(new DataGridViewColumn[] { FlavorColumn, PotencyColumn, FlavorDetailColumn });
        FlavorsDataGridView.Location = new Point(255, 26);
        FlavorsDataGridView.Name = "FlavorsDataGridView";
        FlavorsDataGridView.RowHeadersVisible = false;
        FlavorsDataGridView.Size = new Size(218, 150);
        FlavorsDataGridView.TabIndex = 19;
        FlavorsDataGridView.CellClick += FlavorDataGridView_CellClick;
        FlavorsDataGridView.CellDoubleClick += FlavorDataGridView_CellDoubleClick;
        // 
        // FlavorColumn
        // 
        FlavorColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
        FlavorColumn.DataPropertyName = "Flavor";
        FlavorColumn.HeaderText = "味";
        FlavorColumn.Name = "FlavorColumn";
        FlavorColumn.ReadOnly = true;
        FlavorColumn.Width = 44;
        // 
        // PotencyColumn
        // 
        PotencyColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
        PotencyColumn.DataPropertyName = "Potency";
        PotencyColumn.HeaderText = "強さ";
        PotencyColumn.Name = "PotencyColumn";
        PotencyColumn.ReadOnly = true;
        PotencyColumn.Width = 52;
        // 
        // FlavorDetailColumn
        // 
        FlavorDetailColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
        FlavorDetailColumn.HeaderText = "詳細";
        FlavorDetailColumn.Name = "FlavorDetailColumn";
        FlavorDetailColumn.ReadOnly = true;
        FlavorDetailColumn.Text = "詳細";
        FlavorDetailColumn.UseColumnTextForButtonValue = true;
        FlavorDetailColumn.Width = 37;
        // 
        // ItemButton
        // 
        ItemButton.Location = new Point(35, 163);
        ItemButton.Name = "ItemButton";
        ItemButton.Size = new Size(63, 23);
        ItemButton.TabIndex = 12;
        ItemButton.Text = "アイテム";
        ItemButton.UseVisualStyleBackColor = true;
        ItemButton.Click += ItemButton_Click;
        // 
        // NaturalGiftTypeButton
        // 
        NaturalGiftTypeButton.Location = new Point(5, 17);
        NaturalGiftTypeButton.Name = "NaturalGiftTypeButton";
        NaturalGiftTypeButton.Size = new Size(47, 23);
        NaturalGiftTypeButton.TabIndex = 0;
        NaturalGiftTypeButton.Text = "技タイプ";
        NaturalGiftTypeButton.UseVisualStyleBackColor = true;
        // 
        // CloseButton
        // 
        CloseButton.Location = new Point(415, 264);
        CloseButton.Name = "CloseButton";
        CloseButton.Size = new Size(59, 31);
        CloseButton.TabIndex = 22;
        CloseButton.Text = "閉じる";
        CloseButton.UseVisualStyleBackColor = true;
        CloseButton.Click += CloseButton_Click;
        // 
        // NaturalGiftGroupBox
        // 
        NaturalGiftGroupBox.Controls.Add(NaturalGiftPowerTextBox);
        NaturalGiftGroupBox.Controls.Add(NaturalGiftTypeTextBox);
        NaturalGiftGroupBox.Controls.Add(NaturalGiftTypeButton);
        NaturalGiftGroupBox.Controls.Add(NaturalGiftPowerCaptionLabel);
        NaturalGiftGroupBox.Location = new Point(256, 181);
        NaturalGiftGroupBox.Margin = new Padding(2, 3, 2, 3);
        NaturalGiftGroupBox.Name = "NaturalGiftGroupBox";
        NaturalGiftGroupBox.Padding = new Padding(2, 3, 2, 3);
        NaturalGiftGroupBox.Size = new Size(218, 78);
        NaturalGiftGroupBox.TabIndex = 20;
        NaturalGiftGroupBox.TabStop = false;
        NaturalGiftGroupBox.Text = "しぜんのめぐみ";
        // 
        // NaturalGiftPowerTextBox
        // 
        NaturalGiftPowerTextBox.Location = new Point(52, 45);
        NaturalGiftPowerTextBox.Margin = new Padding(2, 3, 2, 3);
        NaturalGiftPowerTextBox.Name = "NaturalGiftPowerTextBox";
        NaturalGiftPowerTextBox.ReadOnly = true;
        NaturalGiftPowerTextBox.Size = new Size(149, 23);
        NaturalGiftPowerTextBox.TabIndex = 3;
        // 
        // NaturalGiftTypeTextBox
        // 
        NaturalGiftTypeTextBox.Location = new Point(53, 19);
        NaturalGiftTypeTextBox.Margin = new Padding(2, 3, 2, 3);
        NaturalGiftTypeTextBox.Name = "NaturalGiftTypeTextBox";
        NaturalGiftTypeTextBox.ReadOnly = true;
        NaturalGiftTypeTextBox.Size = new Size(149, 23);
        NaturalGiftTypeTextBox.TabIndex = 1;
        // 
        // IdTextBox
        // 
        IdTextBox.Location = new Point(102, 6);
        IdTextBox.Margin = new Padding(2, 3, 2, 3);
        IdTextBox.Name = "IdTextBox";
        IdTextBox.ReadOnly = true;
        IdTextBox.Size = new Size(149, 23);
        IdTextBox.TabIndex = 1;
        // 
        // NameTextBox
        // 
        NameTextBox.Location = new Point(101, 33);
        NameTextBox.Margin = new Padding(2, 3, 2, 3);
        NameTextBox.Name = "NameTextBox";
        NameTextBox.ReadOnly = true;
        NameTextBox.Size = new Size(149, 23);
        NameTextBox.TabIndex = 3;
        // 
        // SizeTextBox
        // 
        SizeTextBox.Location = new Point(101, 59);
        SizeTextBox.Margin = new Padding(2, 3, 2, 3);
        SizeTextBox.Name = "SizeTextBox";
        SizeTextBox.ReadOnly = true;
        SizeTextBox.Size = new Size(149, 23);
        SizeTextBox.TabIndex = 5;
        // 
        // SmoothnessTextBox
        // 
        SmoothnessTextBox.Location = new Point(101, 139);
        SmoothnessTextBox.Margin = new Padding(2, 3, 2, 3);
        SmoothnessTextBox.Name = "SmoothnessTextBox";
        SmoothnessTextBox.ReadOnly = true;
        SmoothnessTextBox.Size = new Size(149, 23);
        SmoothnessTextBox.TabIndex = 11;
        // 
        // FirmnessTextBox
        // 
        FirmnessTextBox.Location = new Point(103, 86);
        FirmnessTextBox.Margin = new Padding(2, 3, 2, 3);
        FirmnessTextBox.Name = "FirmnessTextBox";
        FirmnessTextBox.ReadOnly = true;
        FirmnessTextBox.Size = new Size(149, 23);
        FirmnessTextBox.TabIndex = 7;
        // 
        // ItemTextBox
        // 
        ItemTextBox.Location = new Point(103, 165);
        ItemTextBox.Margin = new Padding(2, 3, 2, 3);
        ItemTextBox.Name = "ItemTextBox";
        ItemTextBox.ReadOnly = true;
        ItemTextBox.Size = new Size(149, 23);
        ItemTextBox.TabIndex = 13;
        // 
        // GrowthTimeTextBox
        // 
        GrowthTimeTextBox.Location = new Point(101, 112);
        GrowthTimeTextBox.Margin = new Padding(2, 3, 2, 3);
        GrowthTimeTextBox.Name = "GrowthTimeTextBox";
        GrowthTimeTextBox.ReadOnly = true;
        GrowthTimeTextBox.Size = new Size(149, 23);
        GrowthTimeTextBox.TabIndex = 9;
        // 
        // MaxHarvestTextBox
        // 
        MaxHarvestTextBox.Location = new Point(103, 191);
        MaxHarvestTextBox.Margin = new Padding(2, 3, 2, 3);
        MaxHarvestTextBox.Name = "MaxHarvestTextBox";
        MaxHarvestTextBox.ReadOnly = true;
        MaxHarvestTextBox.Size = new Size(149, 23);
        MaxHarvestTextBox.TabIndex = 15;
        // 
        // SoilDrynessTextBox
        // 
        SoilDrynessTextBox.Location = new Point(101, 218);
        SoilDrynessTextBox.Margin = new Padding(2, 3, 2, 3);
        SoilDrynessTextBox.Name = "SoilDrynessTextBox";
        SoilDrynessTextBox.ReadOnly = true;
        SoilDrynessTextBox.Size = new Size(149, 23);
        SoilDrynessTextBox.TabIndex = 17;
        // 
        // PropertyButton
        // 
        PropertyButton.Location = new Point(349, 264);
        PropertyButton.Name = "PropertyButton";
        PropertyButton.Size = new Size(59, 31);
        PropertyButton.TabIndex = 21;
        PropertyButton.Text = "プロパティ";
        PropertyButton.UseVisualStyleBackColor = true;
        PropertyButton.Click += PropertyButton_Click;
        // 
        // BerryInfoForm
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(481, 307);
        Controls.Add(PropertyButton);
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
        Controls.Add(ItemButton);
        Controls.Add(FlavorsDataGridView);
        Controls.Add(FlavorsCaptionLabel);
        Controls.Add(FirmnessButton);
        Controls.Add(SoilDrynessCaptionLabel);
        Controls.Add(SmoothnessCaptionLabel);
        Controls.Add(SizeCaptionLabel);
        Controls.Add(MaxHarvestCaptionLabel);
        Controls.Add(GrowthTimeCaptionLabel);
        Controls.Add(NameCaptionLabel);
        Controls.Add(IdCaptionLabel);
        FormBorderStyle = FormBorderStyle.FixedSingle;
        MaximizeBox = false;
        Name = "BerryInfoForm";
        StartPosition = FormStartPosition.CenterParent;
        Text = "きのみ";
        Load += BerryInfoForm_Load;
        ((System.ComponentModel.ISupportInitialize)FlavorsDataGridView).EndInit();
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
    private Label SoilDrynessCaptionLabel;
    private Button FirmnessButton;
    private Label FlavorsCaptionLabel;
    private DataGridView FlavorsDataGridView;
    private Button ItemButton;
    private Button NaturalGiftTypeButton;
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
    private Button PropertyButton;
}
