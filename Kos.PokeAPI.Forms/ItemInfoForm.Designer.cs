namespace Kos.PokeAPI.Forms;

partial class ItemInfoForm
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
        DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
        NameLabel = new Label();
        NameCaptionLabel = new Label();
        IdLabel = new Label();
        IdCaptionLabel = new Label();
        CostLabel = new Label();
        CostCaptionLabel = new Label();
        FlingPowerCaptionLabel = new Label();
        FlingEffectCaptionLabel = new Label();
        AttributesCaptionLabel = new Label();
        CategoryCatpionLabel = new Label();
        GameIndiceCaptionLabel = new Label();
        NamesCaptionLabel = new Label();
        HeldByPokemonCaptionLabel = new Label();
        MachinesCaptionLabel = new Label();
        FlingPowerLabel = new Label();
        FlingEffectLabel = new Label();
        AttributesDataGridView = new DataGridView();
        dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
        dataGridViewButtonColumn1 = new DataGridViewButtonColumn();
        CategoryLabel = new Label();
        EffectEntriesDataGridView = new DataGridView();
        EffectColumn = new DataGridViewTextBoxColumn();
        EffectDetailColumn = new DataGridViewButtonColumn();
        FlavorTextEntriesDataGridView = new DataGridView();
        GameIndiceDataGridView = new DataGridView();
        GenerationColumn = new DataGridViewTextBoxColumn();
        GameIndexColumn = new DataGridViewTextBoxColumn();
        DetailButtonColumn = new DataGridViewButtonColumn();
        NamesDataGridView = new DataGridView();
        NameColumn = new DataGridViewTextBoxColumn();
        LanguageColumn = new DataGridViewTextBoxColumn();
        DetailColumn = new DataGridViewButtonColumn();
        MachinesDataGridView = new DataGridView();
        MachineVersionGroupColumn = new DataGridViewTextBoxColumn();
        MachineDetailColumn = new DataGridViewButtonColumn();
        HeldByPokemonDataGridView = new DataGridView();
        dataGridViewTextBoxColumn7 = new DataGridViewTextBoxColumn();
        dataGridViewButtonColumn6 = new DataGridViewButtonColumn();
        SpritesPictureBox = new PictureBox();
        CloseButton = new Button();
        FlingPowerGroupBox = new GroupBox();
        BabyTriggerForInfoButton = new Button();
        CategoryInfoButton = new Button();
        tabControl1 = new TabControl();
        EffectEntriesTabPage = new TabPage();
        FlavorTextEntriesTabPage = new TabPage();
        FlavorTextVersionGroupColumn = new DataGridViewTextBoxColumn();
        FlavorTextLanguageColumn = new DataGridViewTextBoxColumn();
        FlavorTextColumn = new DataGridViewTextBoxColumn();
        FlavorTextDetailColumn = new DataGridViewButtonColumn();
        ((System.ComponentModel.ISupportInitialize)AttributesDataGridView).BeginInit();
        ((System.ComponentModel.ISupportInitialize)EffectEntriesDataGridView).BeginInit();
        ((System.ComponentModel.ISupportInitialize)FlavorTextEntriesDataGridView).BeginInit();
        ((System.ComponentModel.ISupportInitialize)GameIndiceDataGridView).BeginInit();
        ((System.ComponentModel.ISupportInitialize)NamesDataGridView).BeginInit();
        ((System.ComponentModel.ISupportInitialize)MachinesDataGridView).BeginInit();
        ((System.ComponentModel.ISupportInitialize)HeldByPokemonDataGridView).BeginInit();
        ((System.ComponentModel.ISupportInitialize)SpritesPictureBox).BeginInit();
        FlingPowerGroupBox.SuspendLayout();
        tabControl1.SuspendLayout();
        EffectEntriesTabPage.SuspendLayout();
        FlavorTextEntriesTabPage.SuspendLayout();
        SuspendLayout();
        // 
        // NameLabel
        // 
        NameLabel.BorderStyle = BorderStyle.Fixed3D;
        NameLabel.Location = new Point(91, 43);
        NameLabel.Margin = new Padding(4, 0, 4, 0);
        NameLabel.Name = "NameLabel";
        NameLabel.Size = new Size(189, 26);
        NameLabel.TabIndex = 3;
        NameLabel.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // NameCaptionLabel
        // 
        NameCaptionLabel.AutoSize = true;
        NameCaptionLabel.Location = new Point(19, 48);
        NameCaptionLabel.Margin = new Padding(4, 0, 4, 0);
        NameCaptionLabel.Name = "NameCaptionLabel";
        NameCaptionLabel.Size = new Size(64, 17);
        NameCaptionLabel.TabIndex = 2;
        NameCaptionLabel.Text = "アイテム名";
        NameCaptionLabel.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // IdLabel
        // 
        IdLabel.BorderStyle = BorderStyle.Fixed3D;
        IdLabel.Location = new Point(91, 9);
        IdLabel.Margin = new Padding(4, 0, 4, 0);
        IdLabel.Name = "IdLabel";
        IdLabel.Size = new Size(189, 26);
        IdLabel.TabIndex = 1;
        IdLabel.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // IdCaptionLabel
        // 
        IdCaptionLabel.AutoSize = true;
        IdCaptionLabel.Location = new Point(15, 18);
        IdCaptionLabel.Margin = new Padding(4, 0, 4, 0);
        IdCaptionLabel.Name = "IdCaptionLabel";
        IdCaptionLabel.Size = new Size(68, 17);
        IdCaptionLabel.TabIndex = 0;
        IdCaptionLabel.Text = "アイテムID";
        IdCaptionLabel.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // CostLabel
        // 
        CostLabel.BorderStyle = BorderStyle.Fixed3D;
        CostLabel.Location = new Point(91, 77);
        CostLabel.Margin = new Padding(4, 0, 4, 0);
        CostLabel.Name = "CostLabel";
        CostLabel.Size = new Size(189, 26);
        CostLabel.TabIndex = 5;
        CostLabel.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // CostCaptionLabel
        // 
        CostCaptionLabel.AutoSize = true;
        CostCaptionLabel.Location = new Point(49, 82);
        CostCaptionLabel.Margin = new Padding(4, 0, 4, 0);
        CostCaptionLabel.Name = "CostCaptionLabel";
        CostCaptionLabel.Size = new Size(34, 17);
        CostCaptionLabel.TabIndex = 4;
        CostCaptionLabel.Text = "価格";
        CostCaptionLabel.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // FlingPowerCaptionLabel
        // 
        FlingPowerCaptionLabel.AutoSize = true;
        FlingPowerCaptionLabel.Location = new Point(13, 34);
        FlingPowerCaptionLabel.Margin = new Padding(4, 0, 4, 0);
        FlingPowerCaptionLabel.Name = "FlingPowerCaptionLabel";
        FlingPowerCaptionLabel.Size = new Size(34, 17);
        FlingPowerCaptionLabel.TabIndex = 0;
        FlingPowerCaptionLabel.Text = "威力";
        FlingPowerCaptionLabel.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // FlingEffectCaptionLabel
        // 
        FlingEffectCaptionLabel.AutoSize = true;
        FlingEffectCaptionLabel.Location = new Point(13, 68);
        FlingEffectCaptionLabel.Margin = new Padding(4, 0, 4, 0);
        FlingEffectCaptionLabel.Name = "FlingEffectCaptionLabel";
        FlingEffectCaptionLabel.Size = new Size(34, 17);
        FlingEffectCaptionLabel.TabIndex = 2;
        FlingEffectCaptionLabel.Text = "効果";
        FlingEffectCaptionLabel.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // AttributesCaptionLabel
        // 
        AttributesCaptionLabel.Location = new Point(13, 240);
        AttributesCaptionLabel.Margin = new Padding(4, 0, 4, 0);
        AttributesCaptionLabel.Name = "AttributesCaptionLabel";
        AttributesCaptionLabel.Size = new Size(150, 26);
        AttributesCaptionLabel.TabIndex = 14;
        AttributesCaptionLabel.Text = "attributes";
        AttributesCaptionLabel.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // CategoryCatpionLabel
        // 
        CategoryCatpionLabel.AutoSize = true;
        CategoryCatpionLabel.Location = new Point(35, 112);
        CategoryCatpionLabel.Margin = new Padding(4, 0, 4, 0);
        CategoryCatpionLabel.Name = "CategoryCatpionLabel";
        CategoryCatpionLabel.Size = new Size(48, 17);
        CategoryCatpionLabel.TabIndex = 6;
        CategoryCatpionLabel.Text = "カテゴリ";
        CategoryCatpionLabel.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // GameIndiceCaptionLabel
        // 
        GameIndiceCaptionLabel.AutoSize = true;
        GameIndiceCaptionLabel.Location = new Point(724, 9);
        GameIndiceCaptionLabel.Margin = new Padding(4, 0, 4, 0);
        GameIndiceCaptionLabel.Name = "GameIndiceCaptionLabel";
        GameIndiceCaptionLabel.Size = new Size(116, 17);
        GameIndiceCaptionLabel.TabIndex = 12;
        GameIndiceCaptionLabel.Text = "ゲーム内インデックス";
        GameIndiceCaptionLabel.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // NamesCaptionLabel
        // 
        NamesCaptionLabel.AutoSize = true;
        NamesCaptionLabel.Location = new Point(335, 9);
        NamesCaptionLabel.Margin = new Padding(4, 0, 4, 0);
        NamesCaptionLabel.Name = "NamesCaptionLabel";
        NamesCaptionLabel.Size = new Size(92, 17);
        NamesCaptionLabel.TabIndex = 10;
        NamesCaptionLabel.Text = "言語ごとの名前";
        NamesCaptionLabel.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // HeldByPokemonCaptionLabel
        // 
        HeldByPokemonCaptionLabel.Location = new Point(362, 240);
        HeldByPokemonCaptionLabel.Margin = new Padding(4, 0, 4, 0);
        HeldByPokemonCaptionLabel.Name = "HeldByPokemonCaptionLabel";
        HeldByPokemonCaptionLabel.Size = new Size(150, 26);
        HeldByPokemonCaptionLabel.TabIndex = 16;
        HeldByPokemonCaptionLabel.Text = "held_by_pokemon";
        HeldByPokemonCaptionLabel.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // MachinesCaptionLabel
        // 
        MachinesCaptionLabel.Location = new Point(724, 240);
        MachinesCaptionLabel.Margin = new Padding(4, 0, 4, 0);
        MachinesCaptionLabel.Name = "MachinesCaptionLabel";
        MachinesCaptionLabel.Size = new Size(150, 26);
        MachinesCaptionLabel.TabIndex = 18;
        MachinesCaptionLabel.Text = "machines";
        MachinesCaptionLabel.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // FlingPowerLabel
        // 
        FlingPowerLabel.BorderStyle = BorderStyle.Fixed3D;
        FlingPowerLabel.Location = new Point(55, 29);
        FlingPowerLabel.Margin = new Padding(4, 0, 4, 0);
        FlingPowerLabel.Name = "FlingPowerLabel";
        FlingPowerLabel.Size = new Size(250, 26);
        FlingPowerLabel.TabIndex = 1;
        FlingPowerLabel.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // FlingEffectLabel
        // 
        FlingEffectLabel.BorderStyle = BorderStyle.Fixed3D;
        FlingEffectLabel.Location = new Point(55, 63);
        FlingEffectLabel.Margin = new Padding(4, 0, 4, 0);
        FlingEffectLabel.Name = "FlingEffectLabel";
        FlingEffectLabel.Size = new Size(240, 26);
        FlingEffectLabel.TabIndex = 3;
        FlingEffectLabel.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // AttributesDataGridView
        // 
        AttributesDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        AttributesDataGridView.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1, dataGridViewButtonColumn1 });
        AttributesDataGridView.Location = new Point(15, 269);
        AttributesDataGridView.Margin = new Padding(4, 3, 4, 3);
        AttributesDataGridView.Name = "AttributesDataGridView";
        AttributesDataGridView.RowHeadersVisible = false;
        AttributesDataGridView.Size = new Size(339, 170);
        AttributesDataGridView.TabIndex = 15;
        // 
        // dataGridViewTextBoxColumn1
        // 
        dataGridViewTextBoxColumn1.DataPropertyName = "Name";
        dataGridViewTextBoxColumn1.HeaderText = "name";
        dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
        dataGridViewTextBoxColumn1.ReadOnly = true;
        // 
        // dataGridViewButtonColumn1
        // 
        dataGridViewButtonColumn1.HeaderText = "Info";
        dataGridViewButtonColumn1.Name = "dataGridViewButtonColumn1";
        dataGridViewButtonColumn1.Text = "Info..";
        dataGridViewButtonColumn1.UseColumnTextForButtonValue = true;
        // 
        // CategoryLabel
        // 
        CategoryLabel.BorderStyle = BorderStyle.Fixed3D;
        CategoryLabel.Location = new Point(91, 107);
        CategoryLabel.Margin = new Padding(4, 0, 4, 0);
        CategoryLabel.Name = "CategoryLabel";
        CategoryLabel.Size = new Size(189, 26);
        CategoryLabel.TabIndex = 7;
        CategoryLabel.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // EffectEntriesDataGridView
        // 
        EffectEntriesDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        EffectEntriesDataGridView.Columns.AddRange(new DataGridViewColumn[] { EffectColumn, EffectDetailColumn });
        EffectEntriesDataGridView.Dock = DockStyle.Fill;
        EffectEntriesDataGridView.Location = new Point(3, 3);
        EffectEntriesDataGridView.Margin = new Padding(4, 3, 4, 3);
        EffectEntriesDataGridView.Name = "EffectEntriesDataGridView";
        EffectEntriesDataGridView.RowHeadersVisible = false;
        EffectEntriesDataGridView.Size = new Size(1037, 289);
        EffectEntriesDataGridView.TabIndex = 0;
        EffectEntriesDataGridView.CellClick += EffectEntriesDataGridView_CellClick;
        EffectEntriesDataGridView.CellDoubleClick += EffectEntriesDataGridView_CellDoubleClick;
        // 
        // EffectColumn
        // 
        EffectColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
        EffectColumn.DataPropertyName = "ShortEffect";
        dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
        EffectColumn.DefaultCellStyle = dataGridViewCellStyle1;
        EffectColumn.HeaderText = "効果";
        EffectColumn.Name = "EffectColumn";
        EffectColumn.ReadOnly = true;
        EffectColumn.Width = 59;
        // 
        // EffectDetailColumn
        // 
        EffectDetailColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
        EffectDetailColumn.HeaderText = "詳細";
        EffectDetailColumn.Name = "EffectDetailColumn";
        EffectDetailColumn.Text = "詳細";
        EffectDetailColumn.UseColumnTextForButtonValue = true;
        EffectDetailColumn.Width = 40;
        // 
        // FlavorTextEntriesDataGridView
        // 
        FlavorTextEntriesDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        FlavorTextEntriesDataGridView.Columns.AddRange(new DataGridViewColumn[] { FlavorTextVersionGroupColumn, FlavorTextLanguageColumn, FlavorTextColumn, FlavorTextDetailColumn });
        FlavorTextEntriesDataGridView.Dock = DockStyle.Fill;
        FlavorTextEntriesDataGridView.Location = new Point(3, 3);
        FlavorTextEntriesDataGridView.Margin = new Padding(4, 3, 4, 3);
        FlavorTextEntriesDataGridView.Name = "FlavorTextEntriesDataGridView";
        FlavorTextEntriesDataGridView.RowHeadersVisible = false;
        FlavorTextEntriesDataGridView.Size = new Size(1037, 289);
        FlavorTextEntriesDataGridView.TabIndex = 0;
        FlavorTextEntriesDataGridView.CellClick += FlavorTextEntriesDataGridView_CellClick;
        FlavorTextEntriesDataGridView.CellDoubleClick += FlavorTextEntriesDataGridView_CellDoubleClick;
        // 
        // GameIndiceDataGridView
        // 
        GameIndiceDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        GameIndiceDataGridView.Columns.AddRange(new DataGridViewColumn[] { GenerationColumn, GameIndexColumn, DetailButtonColumn });
        GameIndiceDataGridView.Location = new Point(724, 29);
        GameIndiceDataGridView.Margin = new Padding(4, 3, 4, 3);
        GameIndiceDataGridView.Name = "GameIndiceDataGridView";
        GameIndiceDataGridView.RowHeadersVisible = false;
        GameIndiceDataGridView.Size = new Size(342, 170);
        GameIndiceDataGridView.TabIndex = 13;
        GameIndiceDataGridView.CellClick += GameIndiceDataGridView_CellClick;
        GameIndiceDataGridView.CellDoubleClick += GameIndiceDataGridView_CellDoubleClick;
        // 
        // GenerationColumn
        // 
        GenerationColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
        GenerationColumn.DataPropertyName = "Generation";
        GenerationColumn.HeaderText = "世代";
        GenerationColumn.Name = "GenerationColumn";
        GenerationColumn.ReadOnly = true;
        GenerationColumn.Width = 59;
        // 
        // GameIndexColumn
        // 
        GameIndexColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
        GameIndexColumn.DataPropertyName = "GameIndex";
        GameIndexColumn.HeaderText = "インデックス";
        GameIndexColumn.Name = "GameIndexColumn";
        GameIndexColumn.ReadOnly = true;
        GameIndexColumn.Width = 95;
        // 
        // DetailButtonColumn
        // 
        DetailButtonColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
        DetailButtonColumn.HeaderText = "詳細";
        DetailButtonColumn.Name = "DetailButtonColumn";
        DetailButtonColumn.Text = "詳細";
        DetailButtonColumn.UseColumnTextForButtonValue = true;
        DetailButtonColumn.Width = 40;
        // 
        // NamesDataGridView
        // 
        NamesDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        NamesDataGridView.Columns.AddRange(new DataGridViewColumn[] { NameColumn, LanguageColumn, DetailColumn });
        NamesDataGridView.Location = new Point(337, 29);
        NamesDataGridView.Margin = new Padding(4, 3, 4, 3);
        NamesDataGridView.Name = "NamesDataGridView";
        NamesDataGridView.RowHeadersVisible = false;
        NamesDataGridView.Size = new Size(379, 170);
        NamesDataGridView.TabIndex = 11;
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
        // MachinesDataGridView
        // 
        MachinesDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        MachinesDataGridView.Columns.AddRange(new DataGridViewColumn[] { MachineVersionGroupColumn, MachineDetailColumn });
        MachinesDataGridView.Location = new Point(724, 269);
        MachinesDataGridView.Margin = new Padding(4, 3, 4, 3);
        MachinesDataGridView.Name = "MachinesDataGridView";
        MachinesDataGridView.RowHeadersVisible = false;
        MachinesDataGridView.Size = new Size(342, 170);
        MachinesDataGridView.TabIndex = 19;
        // 
        // MachineVersionGroupColumn
        // 
        MachineVersionGroupColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
        MachineVersionGroupColumn.DataPropertyName = "VersionGroup";
        MachineVersionGroupColumn.HeaderText = "バージョングループ";
        MachineVersionGroupColumn.Name = "MachineVersionGroupColumn";
        MachineVersionGroupColumn.ReadOnly = true;
        MachineVersionGroupColumn.Width = 88;
        // 
        // MachineDetailColumn
        // 
        MachineDetailColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
        MachineDetailColumn.HeaderText = "詳細";
        MachineDetailColumn.Name = "MachineDetailColumn";
        MachineDetailColumn.Text = "詳細";
        MachineDetailColumn.UseColumnTextForButtonValue = true;
        MachineDetailColumn.Width = 36;
        // 
        // HeldByPokemonDataGridView
        // 
        HeldByPokemonDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        HeldByPokemonDataGridView.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn7, dataGridViewButtonColumn6 });
        HeldByPokemonDataGridView.Location = new Point(362, 269);
        HeldByPokemonDataGridView.Margin = new Padding(4, 3, 4, 3);
        HeldByPokemonDataGridView.Name = "HeldByPokemonDataGridView";
        HeldByPokemonDataGridView.RowHeadersVisible = false;
        HeldByPokemonDataGridView.Size = new Size(354, 170);
        HeldByPokemonDataGridView.TabIndex = 17;
        // 
        // dataGridViewTextBoxColumn7
        // 
        dataGridViewTextBoxColumn7.DataPropertyName = "Pokemon";
        dataGridViewTextBoxColumn7.HeaderText = "ポケモン";
        dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
        dataGridViewTextBoxColumn7.ReadOnly = true;
        // 
        // dataGridViewButtonColumn6
        // 
        dataGridViewButtonColumn6.HeaderText = "詳細";
        dataGridViewButtonColumn6.Name = "dataGridViewButtonColumn6";
        dataGridViewButtonColumn6.Text = "詳細";
        dataGridViewButtonColumn6.UseColumnTextForButtonValue = true;
        // 
        // SpritesPictureBox
        // 
        SpritesPictureBox.Location = new Point(288, 9);
        SpritesPictureBox.Margin = new Padding(4, 3, 4, 3);
        SpritesPictureBox.Name = "SpritesPictureBox";
        SpritesPictureBox.Size = new Size(39, 34);
        SpritesPictureBox.TabIndex = 33;
        SpritesPictureBox.TabStop = false;
        // 
        // CloseButton
        // 
        CloseButton.Location = new Point(969, 776);
        CloseButton.Margin = new Padding(4, 3, 4, 3);
        CloseButton.Name = "CloseButton";
        CloseButton.Size = new Size(96, 52);
        CloseButton.TabIndex = 22;
        CloseButton.Text = "閉じる";
        CloseButton.UseVisualStyleBackColor = true;
        CloseButton.Click += CloseButton_Click;
        // 
        // FlingPowerGroupBox
        // 
        FlingPowerGroupBox.Controls.Add(FlingPowerCaptionLabel);
        FlingPowerGroupBox.Controls.Add(FlingEffectCaptionLabel);
        FlingPowerGroupBox.Controls.Add(FlingPowerLabel);
        FlingPowerGroupBox.Controls.Add(FlingEffectLabel);
        FlingPowerGroupBox.Location = new Point(15, 136);
        FlingPowerGroupBox.Name = "FlingPowerGroupBox";
        FlingPowerGroupBox.Size = new Size(312, 100);
        FlingPowerGroupBox.TabIndex = 9;
        FlingPowerGroupBox.TabStop = false;
        FlingPowerGroupBox.Text = "なげつける";
        // 
        // BabyTriggerForInfoButton
        // 
        BabyTriggerForInfoButton.Location = new Point(15, 776);
        BabyTriggerForInfoButton.Name = "BabyTriggerForInfoButton";
        BabyTriggerForInfoButton.Size = new Size(103, 52);
        BabyTriggerForInfoButton.TabIndex = 21;
        BabyTriggerForInfoButton.Text = "ベビーポケモンの\r\n進化トリガー";
        BabyTriggerForInfoButton.UseVisualStyleBackColor = true;
        BabyTriggerForInfoButton.Click += BabyTriggerForInfoButton_Click;
        // 
        // CategoryInfoButton
        // 
        CategoryInfoButton.Location = new Point(287, 105);
        CategoryInfoButton.Name = "CategoryInfoButton";
        CategoryInfoButton.Size = new Size(43, 28);
        CategoryInfoButton.TabIndex = 8;
        CategoryInfoButton.Text = "詳細";
        CategoryInfoButton.UseVisualStyleBackColor = true;
        // 
        // tabControl1
        // 
        tabControl1.Controls.Add(EffectEntriesTabPage);
        tabControl1.Controls.Add(FlavorTextEntriesTabPage);
        tabControl1.Location = new Point(15, 445);
        tabControl1.Name = "tabControl1";
        tabControl1.SelectedIndex = 0;
        tabControl1.Size = new Size(1051, 325);
        tabControl1.TabIndex = 20;
        // 
        // EffectEntriesTabPage
        // 
        EffectEntriesTabPage.Controls.Add(EffectEntriesDataGridView);
        EffectEntriesTabPage.Location = new Point(4, 26);
        EffectEntriesTabPage.Name = "EffectEntriesTabPage";
        EffectEntriesTabPage.Padding = new Padding(3);
        EffectEntriesTabPage.Size = new Size(1043, 295);
        EffectEntriesTabPage.TabIndex = 0;
        EffectEntriesTabPage.Text = "効果";
        EffectEntriesTabPage.UseVisualStyleBackColor = true;
        // 
        // FlavorTextEntriesTabPage
        // 
        FlavorTextEntriesTabPage.Controls.Add(FlavorTextEntriesDataGridView);
        FlavorTextEntriesTabPage.Location = new Point(4, 26);
        FlavorTextEntriesTabPage.Name = "FlavorTextEntriesTabPage";
        FlavorTextEntriesTabPage.Padding = new Padding(3);
        FlavorTextEntriesTabPage.Size = new Size(1043, 295);
        FlavorTextEntriesTabPage.TabIndex = 1;
        FlavorTextEntriesTabPage.Text = "フレーバーテキスト";
        FlavorTextEntriesTabPage.UseVisualStyleBackColor = true;
        // 
        // FlavorTextVersionGroupColumn
        // 
        FlavorTextVersionGroupColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
        FlavorTextVersionGroupColumn.DataPropertyName = "VersionGroup";
        FlavorTextVersionGroupColumn.HeaderText = "バージョングループ";
        FlavorTextVersionGroupColumn.Name = "FlavorTextVersionGroupColumn";
        FlavorTextVersionGroupColumn.ReadOnly = true;
        FlavorTextVersionGroupColumn.Width = 88;
        // 
        // FlavorTextLanguageColumn
        // 
        FlavorTextLanguageColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
        FlavorTextLanguageColumn.DataPropertyName = "Language";
        FlavorTextLanguageColumn.HeaderText = "言語";
        FlavorTextLanguageColumn.Name = "FlavorTextLanguageColumn";
        FlavorTextLanguageColumn.ReadOnly = true;
        FlavorTextLanguageColumn.Width = 55;
        // 
        // FlavorTextColumn
        // 
        FlavorTextColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
        FlavorTextColumn.DataPropertyName = "Text";
        FlavorTextColumn.HeaderText = "フレーバーテキスト";
        FlavorTextColumn.Name = "FlavorTextColumn";
        FlavorTextColumn.ReadOnly = true;
        FlavorTextColumn.Width = 88;
        // 
        // FlavorTextDetailColumn
        // 
        FlavorTextDetailColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
        FlavorTextDetailColumn.HeaderText = "詳細";
        FlavorTextDetailColumn.Name = "FlavorTextDetailColumn";
        FlavorTextDetailColumn.Text = "詳細";
        FlavorTextDetailColumn.UseColumnTextForButtonValue = true;
        FlavorTextDetailColumn.Width = 36;
        // 
        // ItemInfoForm
        // 
        AutoScaleDimensions = new SizeF(9F, 17F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(1078, 835);
        Controls.Add(CategoryInfoButton);
        Controls.Add(BabyTriggerForInfoButton);
        Controls.Add(FlingPowerGroupBox);
        Controls.Add(CloseButton);
        Controls.Add(SpritesPictureBox);
        Controls.Add(HeldByPokemonDataGridView);
        Controls.Add(MachinesDataGridView);
        Controls.Add(NamesDataGridView);
        Controls.Add(GameIndiceDataGridView);
        Controls.Add(CategoryLabel);
        Controls.Add(MachinesCaptionLabel);
        Controls.Add(HeldByPokemonCaptionLabel);
        Controls.Add(NamesCaptionLabel);
        Controls.Add(GameIndiceCaptionLabel);
        Controls.Add(CategoryCatpionLabel);
        Controls.Add(CostCaptionLabel);
        Controls.Add(CostLabel);
        Controls.Add(NameLabel);
        Controls.Add(NameCaptionLabel);
        Controls.Add(IdLabel);
        Controls.Add(IdCaptionLabel);
        Controls.Add(tabControl1);
        Controls.Add(AttributesDataGridView);
        Controls.Add(AttributesCaptionLabel);
        Font = new Font("Meiryo UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 128);
        FormBorderStyle = FormBorderStyle.FixedSingle;
        Margin = new Padding(4, 3, 4, 3);
        MaximizeBox = false;
        Name = "ItemInfoForm";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "アイテム";
        ((System.ComponentModel.ISupportInitialize)AttributesDataGridView).EndInit();
        ((System.ComponentModel.ISupportInitialize)EffectEntriesDataGridView).EndInit();
        ((System.ComponentModel.ISupportInitialize)FlavorTextEntriesDataGridView).EndInit();
        ((System.ComponentModel.ISupportInitialize)GameIndiceDataGridView).EndInit();
        ((System.ComponentModel.ISupportInitialize)NamesDataGridView).EndInit();
        ((System.ComponentModel.ISupportInitialize)MachinesDataGridView).EndInit();
        ((System.ComponentModel.ISupportInitialize)HeldByPokemonDataGridView).EndInit();
        ((System.ComponentModel.ISupportInitialize)SpritesPictureBox).EndInit();
        FlingPowerGroupBox.ResumeLayout(false);
        FlingPowerGroupBox.PerformLayout();
        tabControl1.ResumeLayout(false);
        EffectEntriesTabPage.ResumeLayout(false);
        FlavorTextEntriesTabPage.ResumeLayout(false);
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private Label NameLabel;
    private Label NameCaptionLabel;
    private Label IdLabel;
    private Label IdCaptionLabel;
    private Label CostLabel;
    private Label CostCaptionLabel;
    private Label FlingPowerCaptionLabel;
    private Label FlingEffectCaptionLabel;
    private Label AttributesCaptionLabel;
    private Label CategoryCatpionLabel;
    private Label EffectEntriesCaptionLabel;
    private Label FlavorTextEntriesCaptionLabel;
    private Label GameIndiceCaptionLabel;
    private Label NamesCaptionLabel;
    private Label HeldByPokemonCaptionLabel;
    private Label MachinesCaptionLabel;
    private Label FlingPowerLabel;
    private Label FlingEffectLabel;
    private DataGridView AttributesDataGridView;
    private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
    private DataGridViewButtonColumn dataGridViewButtonColumn1;
    private Label CategoryLabel;
    private DataGridView EffectEntriesDataGridView;
    private DataGridView FlavorTextEntriesDataGridView;
    private DataGridView GameIndiceDataGridView;
    private DataGridView NamesDataGridView;
    private DataGridView MachinesDataGridView;
    private DataGridView HeldByPokemonDataGridView;
    private PictureBox SpritesPictureBox;
    private Button CloseButton;
    private GroupBox FlingPowerGroupBox;
    private Button BabyTriggerForInfoButton;
    private Button CategoryInfoButton;
    private TabControl tabControl1;
    private TabPage EffectEntriesTabPage;
    private TabPage FlavorTextEntriesTabPage;
    private DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
    private DataGridViewButtonColumn dataGridViewButtonColumn6;
    private DataGridViewTextBoxColumn EffectColumn;
    private DataGridViewButtonColumn EffectDetailColumn;
    private DataGridViewTextBoxColumn GenerationColumn;
    private DataGridViewTextBoxColumn GameIndexColumn;
    private DataGridViewButtonColumn DetailButtonColumn;
    private DataGridViewTextBoxColumn NameColumn;
    private DataGridViewTextBoxColumn LanguageColumn;
    private DataGridViewButtonColumn DetailColumn;
    private DataGridViewTextBoxColumn MachineVersionGroupColumn;
    private DataGridViewButtonColumn MachineDetailColumn;
    private DataGridViewTextBoxColumn FlavorTextVersionGroupColumn;
    private DataGridViewTextBoxColumn FlavorTextLanguageColumn;
    private DataGridViewTextBoxColumn FlavorTextColumn;
    private DataGridViewButtonColumn FlavorTextDetailColumn;
}