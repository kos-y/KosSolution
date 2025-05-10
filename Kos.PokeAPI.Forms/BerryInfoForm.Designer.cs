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
        NameCaptionLabel.Location = new Point(45, 40);
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
        IdCaptionLabel.Location = new Point(63, 10);
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
        GrowthTimeCaptionLabel.Location = new Point(63, 130);
        GrowthTimeCaptionLabel.Margin = new Padding(4, 0, 4, 0);
        GrowthTimeCaptionLabel.Name = "GrowthTimeCaptionLabel";
        GrowthTimeCaptionLabel.Size = new Size(60, 17);
        GrowthTimeCaptionLabel.TabIndex = 8;
        GrowthTimeCaptionLabel.Text = "成長時間";
        GrowthTimeCaptionLabel.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // MaxHarvestCaptionLabel
        // 
        MaxHarvestCaptionLabel.AutoSize = true;
        MaxHarvestCaptionLabel.Location = new Point(14, 213);
        MaxHarvestCaptionLabel.Margin = new Padding(4, 0, 4, 0);
        MaxHarvestCaptionLabel.Name = "MaxHarvestCaptionLabel";
        MaxHarvestCaptionLabel.Size = new Size(112, 34);
        MaxHarvestCaptionLabel.TabIndex = 14;
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
        NaturalGiftPowerCaptionLabel.TabIndex = 2;
        NaturalGiftPowerCaptionLabel.Text = "威力";
        NaturalGiftPowerCaptionLabel.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // SizeCaptionLabel
        // 
        SizeCaptionLabel.AutoSize = true;
        SizeCaptionLabel.Location = new Point(80, 70);
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
        SmoothnessCaptionLabel.Location = new Point(71, 160);
        SmoothnessCaptionLabel.Margin = new Padding(4, 0, 4, 0);
        SmoothnessCaptionLabel.Name = "SmoothnessCaptionLabel";
        SmoothnessCaptionLabel.Size = new Size(52, 17);
        SmoothnessCaptionLabel.TabIndex = 10;
        SmoothnessCaptionLabel.Text = "滑らかさ";
        SmoothnessCaptionLabel.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // SoilDrynessCaptionLabel
        // 
        SoilDrynessCaptionLabel.AutoSize = true;
        SoilDrynessCaptionLabel.Location = new Point(40, 250);
        SoilDrynessCaptionLabel.Margin = new Padding(4, 0, 4, 0);
        SoilDrynessCaptionLabel.Name = "SoilDrynessCaptionLabel";
        SoilDrynessCaptionLabel.Size = new Size(86, 17);
        SoilDrynessCaptionLabel.TabIndex = 16;
        SoilDrynessCaptionLabel.Text = "土壌乾燥速度";
        SoilDrynessCaptionLabel.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // FirmnessButton
        // 
        FirmnessButton.Location = new Point(76, 95);
        FirmnessButton.Margin = new Padding(4, 3, 4, 3);
        FirmnessButton.Name = "FirmnessButton";
        FirmnessButton.Size = new Size(45, 26);
        FirmnessButton.TabIndex = 6;
        FirmnessButton.Text = "硬さ";
        FirmnessButton.UseVisualStyleBackColor = true;
        FirmnessButton.Click += FirmnessButton_Click;
        // 
        // FlavorsCaptionLabel
        // 
        FlavorsCaptionLabel.AutoSize = true;
        FlavorsCaptionLabel.Location = new Point(328, 9);
        FlavorsCaptionLabel.Margin = new Padding(4, 0, 4, 0);
        FlavorsCaptionLabel.Name = "FlavorsCaptionLabel";
        FlavorsCaptionLabel.Size = new Size(21, 17);
        FlavorsCaptionLabel.TabIndex = 18;
        FlavorsCaptionLabel.Text = "味";
        FlavorsCaptionLabel.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // FlavorsDataGridView
        // 
        FlavorsDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        FlavorsDataGridView.Columns.AddRange(new DataGridViewColumn[] { FlavorColumn, PotencyColumn, FlavorDetailColumn });
        FlavorsDataGridView.Location = new Point(328, 29);
        FlavorsDataGridView.Margin = new Padding(4, 3, 4, 3);
        FlavorsDataGridView.Name = "FlavorsDataGridView";
        FlavorsDataGridView.RowHeadersVisible = false;
        FlavorsDataGridView.Size = new Size(280, 170);
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
        // ItemButton
        // 
        ItemButton.Location = new Point(65, 185);
        ItemButton.Margin = new Padding(4, 3, 4, 3);
        ItemButton.Name = "ItemButton";
        ItemButton.Size = new Size(60, 26);
        ItemButton.TabIndex = 12;
        ItemButton.Text = "アイテム";
        ItemButton.UseVisualStyleBackColor = true;
        ItemButton.Click += ItemButton_Click;
        // 
        // NaturalGiftTypeButton
        // 
        NaturalGiftTypeButton.Location = new Point(7, 19);
        NaturalGiftTypeButton.Margin = new Padding(4, 3, 4, 3);
        NaturalGiftTypeButton.Name = "NaturalGiftTypeButton";
        NaturalGiftTypeButton.Size = new Size(61, 26);
        NaturalGiftTypeButton.TabIndex = 0;
        NaturalGiftTypeButton.Text = "技タイプ";
        NaturalGiftTypeButton.UseVisualStyleBackColor = true;
        // 
        // CloseButton
        // 
        CloseButton.Location = new Point(533, 299);
        CloseButton.Margin = new Padding(4, 3, 4, 3);
        CloseButton.Name = "CloseButton";
        CloseButton.Size = new Size(76, 35);
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
        NaturalGiftGroupBox.Location = new Point(329, 205);
        NaturalGiftGroupBox.Name = "NaturalGiftGroupBox";
        NaturalGiftGroupBox.Size = new Size(280, 88);
        NaturalGiftGroupBox.TabIndex = 20;
        NaturalGiftGroupBox.TabStop = false;
        NaturalGiftGroupBox.Text = "しぜんのめぐみ";
        // 
        // NaturalGiftPowerTextBox
        // 
        NaturalGiftPowerTextBox.Location = new Point(67, 51);
        NaturalGiftPowerTextBox.Name = "NaturalGiftPowerTextBox";
        NaturalGiftPowerTextBox.ReadOnly = true;
        NaturalGiftPowerTextBox.Size = new Size(190, 24);
        NaturalGiftPowerTextBox.TabIndex = 3;
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
        IdTextBox.Location = new Point(131, 7);
        IdTextBox.Name = "IdTextBox";
        IdTextBox.ReadOnly = true;
        IdTextBox.Size = new Size(190, 24);
        IdTextBox.TabIndex = 1;
        // 
        // NameTextBox
        // 
        NameTextBox.Location = new Point(130, 37);
        NameTextBox.Name = "NameTextBox";
        NameTextBox.ReadOnly = true;
        NameTextBox.Size = new Size(190, 24);
        NameTextBox.TabIndex = 3;
        // 
        // SizeTextBox
        // 
        SizeTextBox.Location = new Point(130, 67);
        SizeTextBox.Name = "SizeTextBox";
        SizeTextBox.ReadOnly = true;
        SizeTextBox.Size = new Size(190, 24);
        SizeTextBox.TabIndex = 5;
        // 
        // SmoothnessTextBox
        // 
        SmoothnessTextBox.Location = new Point(130, 157);
        SmoothnessTextBox.Name = "SmoothnessTextBox";
        SmoothnessTextBox.ReadOnly = true;
        SmoothnessTextBox.Size = new Size(190, 24);
        SmoothnessTextBox.TabIndex = 11;
        // 
        // FirmnessTextBox
        // 
        FirmnessTextBox.Location = new Point(132, 97);
        FirmnessTextBox.Name = "FirmnessTextBox";
        FirmnessTextBox.ReadOnly = true;
        FirmnessTextBox.Size = new Size(190, 24);
        FirmnessTextBox.TabIndex = 7;
        // 
        // ItemTextBox
        // 
        ItemTextBox.Location = new Point(132, 187);
        ItemTextBox.Name = "ItemTextBox";
        ItemTextBox.ReadOnly = true;
        ItemTextBox.Size = new Size(190, 24);
        ItemTextBox.TabIndex = 13;
        // 
        // GrowthTimeTextBox
        // 
        GrowthTimeTextBox.Location = new Point(130, 127);
        GrowthTimeTextBox.Name = "GrowthTimeTextBox";
        GrowthTimeTextBox.ReadOnly = true;
        GrowthTimeTextBox.Size = new Size(190, 24);
        GrowthTimeTextBox.TabIndex = 9;
        // 
        // MaxHarvestTextBox
        // 
        MaxHarvestTextBox.Location = new Point(133, 217);
        MaxHarvestTextBox.Name = "MaxHarvestTextBox";
        MaxHarvestTextBox.ReadOnly = true;
        MaxHarvestTextBox.Size = new Size(190, 24);
        MaxHarvestTextBox.TabIndex = 15;
        // 
        // SoilDrynessTextBox
        // 
        SoilDrynessTextBox.Location = new Point(130, 247);
        SoilDrynessTextBox.Name = "SoilDrynessTextBox";
        SoilDrynessTextBox.ReadOnly = true;
        SoilDrynessTextBox.Size = new Size(190, 24);
        SoilDrynessTextBox.TabIndex = 17;
        // 
        // PropertyButton
        // 
        PropertyButton.Location = new Point(449, 299);
        PropertyButton.Margin = new Padding(4, 3, 4, 3);
        PropertyButton.Name = "PropertyButton";
        PropertyButton.Size = new Size(76, 35);
        PropertyButton.TabIndex = 21;
        PropertyButton.Text = "プロパティ";
        PropertyButton.UseVisualStyleBackColor = true;
        PropertyButton.Click += PropertyButton_Click;
        // 
        // BerryInfoForm
        // 
        AutoScaleDimensions = new SizeF(9F, 17F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(632, 354);
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
        Font = new Font("Meiryo UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 128);
        FormBorderStyle = FormBorderStyle.FixedSingle;
        Margin = new Padding(4, 3, 4, 3);
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
    private Label FirmnessCaptionLabel;
    private Label SoilDrynessCaptionLabel;
    private Button FirmnessButton;
    private Label FlavorsCaptionLabel;
    private DataGridView FlavorsDataGridView;
    private Label ItemCaptionLabel;
    private Button ItemButton;
    private Label NaturalGiftTypeCaptionLabel;
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
