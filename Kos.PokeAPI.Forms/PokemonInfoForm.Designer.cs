namespace Kos.PokeAPI.Forms;

partial class PokemonInfoForm
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
        NameTextBox = new TextBox();
        IdTextBox = new TextBox();
        NameCaptionLabel = new Label();
        IdCaptionLabel = new Label();
        PropertyButton = new Button();
        CloseButton = new Button();
        SpeciesButton = new Button();
        SpeciesTextBox = new TextBox();
        BaseExperienceCaptionLabel = new Label();
        BaseExperienceTextBox = new TextBox();
        HeightCaptionLabel = new Label();
        HeightTextBox = new TextBox();
        WeightTextBox = new TextBox();
        WeightCaptionLabel = new Label();
        SpeciesGroupBox = new GroupBox();
        IsDefaultTextBox = new TextBox();
        IsDefaultCaptionLabel = new Label();
        OrderCaptionLabel = new Label();
        OrderTextBox = new TextBox();
        GameIndiceDataGridView = new DataGridView();
        VersionColumn = new DataGridViewTextBoxColumn();
        GameIndexColumn = new DataGridViewTextBoxColumn();
        DetailButtonColumn = new DataGridViewButtonColumn();
        GameIndiceCaptionLabel = new Label();
        TypesDataGridView = new DataGridView();
        dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
        dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
        dataGridViewButtonColumn1 = new DataGridViewButtonColumn();
        TypesCaptionLabel = new Label();
        CriesLatestButton = new Button();
        StatsCaptionLabel = new Label();
        StatsDataGridView = new DataGridView();
        dataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
        dataGridViewButtonColumn2 = new DataGridViewButtonColumn();
        AbilitiesDataGridView = new DataGridView();
        dataGridViewTextBoxColumn4 = new DataGridViewTextBoxColumn();
        dataGridViewTextBoxColumn5 = new DataGridViewTextBoxColumn();
        dataGridViewButtonColumn3 = new DataGridViewButtonColumn();
        AbilitiesCaptionLabel = new Label();
        PastButton = new Button();
        LocationAreaEncountersButton = new Button();
        MovesDataGridView = new DataGridView();
        dataGridViewTextBoxColumn6 = new DataGridViewTextBoxColumn();
        dataGridViewButtonColumn4 = new DataGridViewButtonColumn();
        MovesCaptionLabel = new Label();
        HeldItemsDataGridView = new DataGridView();
        dataGridViewTextBoxColumn7 = new DataGridViewTextBoxColumn();
        dataGridViewButtonColumn5 = new DataGridViewButtonColumn();
        HeldItemsCaptionLabel = new Label();
        FormsDataGridView = new DataGridView();
        dataGridViewTextBoxColumn8 = new DataGridViewTextBoxColumn();
        dataGridViewButtonColumn6 = new DataGridViewButtonColumn();
        FormsCaptionLabel = new Label();
        SpriteBackShinyFemalePictureBox = new PictureBox();
        SpriteBackFemalePictureBox = new PictureBox();
        SpriteBackShinyPictureBox = new PictureBox();
        SpriteBackDefaultPictureBox = new PictureBox();
        SpriteFrontShinyFemalePictureBox = new PictureBox();
        SpriteFrontFemalePictureBox = new PictureBox();
        SpriteFrontShinyPictureBox = new PictureBox();
        SpriteFrontDefaultPictureBox = new PictureBox();
        SpeciesGroupBox.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)GameIndiceDataGridView).BeginInit();
        ((System.ComponentModel.ISupportInitialize)TypesDataGridView).BeginInit();
        ((System.ComponentModel.ISupportInitialize)StatsDataGridView).BeginInit();
        ((System.ComponentModel.ISupportInitialize)AbilitiesDataGridView).BeginInit();
        ((System.ComponentModel.ISupportInitialize)MovesDataGridView).BeginInit();
        ((System.ComponentModel.ISupportInitialize)HeldItemsDataGridView).BeginInit();
        ((System.ComponentModel.ISupportInitialize)FormsDataGridView).BeginInit();
        ((System.ComponentModel.ISupportInitialize)SpriteBackShinyFemalePictureBox).BeginInit();
        ((System.ComponentModel.ISupportInitialize)SpriteBackFemalePictureBox).BeginInit();
        ((System.ComponentModel.ISupportInitialize)SpriteBackShinyPictureBox).BeginInit();
        ((System.ComponentModel.ISupportInitialize)SpriteBackDefaultPictureBox).BeginInit();
        ((System.ComponentModel.ISupportInitialize)SpriteFrontShinyFemalePictureBox).BeginInit();
        ((System.ComponentModel.ISupportInitialize)SpriteFrontFemalePictureBox).BeginInit();
        ((System.ComponentModel.ISupportInitialize)SpriteFrontShinyPictureBox).BeginInit();
        ((System.ComponentModel.ISupportInitialize)SpriteFrontDefaultPictureBox).BeginInit();
        SuspendLayout();
        // 
        // NameTextBox
        // 
        NameTextBox.Location = new Point(109, 42);
        NameTextBox.Margin = new Padding(4, 3, 4, 3);
        NameTextBox.Name = "NameTextBox";
        NameTextBox.ReadOnly = true;
        NameTextBox.Size = new Size(156, 24);
        NameTextBox.TabIndex = 3;
        // 
        // IdTextBox
        // 
        IdTextBox.Location = new Point(109, 12);
        IdTextBox.Margin = new Padding(4, 3, 4, 3);
        IdTextBox.Name = "IdTextBox";
        IdTextBox.ReadOnly = true;
        IdTextBox.Size = new Size(156, 24);
        IdTextBox.TabIndex = 1;
        // 
        // NameCaptionLabel
        // 
        NameCaptionLabel.AutoSize = true;
        NameCaptionLabel.Location = new Point(38, 45);
        NameCaptionLabel.Margin = new Padding(5, 0, 5, 0);
        NameCaptionLabel.Name = "NameCaptionLabel";
        NameCaptionLabel.Size = new Size(62, 17);
        NameCaptionLabel.TabIndex = 2;
        NameCaptionLabel.Text = "ポケモン名";
        NameCaptionLabel.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // IdCaptionLabel
        // 
        IdCaptionLabel.AutoSize = true;
        IdCaptionLabel.Location = new Point(34, 15);
        IdCaptionLabel.Margin = new Padding(5, 0, 5, 0);
        IdCaptionLabel.Name = "IdCaptionLabel";
        IdCaptionLabel.Size = new Size(66, 17);
        IdCaptionLabel.TabIndex = 0;
        IdCaptionLabel.Text = "ポケモンID";
        IdCaptionLabel.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // PropertyButton
        // 
        PropertyButton.Location = new Point(1120, 545);
        PropertyButton.Margin = new Padding(4, 3, 4, 3);
        PropertyButton.Name = "PropertyButton";
        PropertyButton.Size = new Size(76, 35);
        PropertyButton.TabIndex = 30;
        PropertyButton.Text = "プロパティ";
        PropertyButton.UseVisualStyleBackColor = true;
        PropertyButton.Click += PropertyButton_Click;
        // 
        // CloseButton
        // 
        CloseButton.Location = new Point(1204, 545);
        CloseButton.Margin = new Padding(4, 3, 4, 3);
        CloseButton.Name = "CloseButton";
        CloseButton.Size = new Size(76, 35);
        CloseButton.TabIndex = 31;
        CloseButton.Text = "閉じる";
        CloseButton.UseVisualStyleBackColor = true;
        CloseButton.Click += CloseButton_Click;
        // 
        // SpeciesButton
        // 
        SpeciesButton.Location = new Point(6, 23);
        SpeciesButton.Name = "SpeciesButton";
        SpeciesButton.Size = new Size(60, 25);
        SpeciesButton.TabIndex = 0;
        SpeciesButton.Text = "種族";
        SpeciesButton.UseVisualStyleBackColor = true;
        // 
        // SpeciesTextBox
        // 
        SpeciesTextBox.Location = new Point(73, 24);
        SpeciesTextBox.Margin = new Padding(4, 3, 4, 3);
        SpeciesTextBox.Name = "SpeciesTextBox";
        SpeciesTextBox.ReadOnly = true;
        SpeciesTextBox.Size = new Size(142, 24);
        SpeciesTextBox.TabIndex = 1;
        // 
        // BaseExperienceCaptionLabel
        // 
        BaseExperienceCaptionLabel.AutoSize = true;
        BaseExperienceCaptionLabel.Location = new Point(27, 75);
        BaseExperienceCaptionLabel.Margin = new Padding(5, 0, 5, 0);
        BaseExperienceCaptionLabel.Name = "BaseExperienceCaptionLabel";
        BaseExperienceCaptionLabel.Size = new Size(73, 17);
        BaseExperienceCaptionLabel.TabIndex = 4;
        BaseExperienceCaptionLabel.Text = "基本経験値";
        BaseExperienceCaptionLabel.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // BaseExperienceTextBox
        // 
        BaseExperienceTextBox.Location = new Point(109, 72);
        BaseExperienceTextBox.Margin = new Padding(4, 3, 4, 3);
        BaseExperienceTextBox.Name = "BaseExperienceTextBox";
        BaseExperienceTextBox.ReadOnly = true;
        BaseExperienceTextBox.Size = new Size(156, 24);
        BaseExperienceTextBox.TabIndex = 5;
        // 
        // HeightCaptionLabel
        // 
        HeightCaptionLabel.AutoSize = true;
        HeightCaptionLabel.Location = new Point(69, 105);
        HeightCaptionLabel.Margin = new Padding(5, 0, 5, 0);
        HeightCaptionLabel.Name = "HeightCaptionLabel";
        HeightCaptionLabel.Size = new Size(31, 17);
        HeightCaptionLabel.TabIndex = 6;
        HeightCaptionLabel.Text = "高さ";
        HeightCaptionLabel.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // HeightTextBox
        // 
        HeightTextBox.Location = new Point(109, 102);
        HeightTextBox.Margin = new Padding(4, 3, 4, 3);
        HeightTextBox.Name = "HeightTextBox";
        HeightTextBox.ReadOnly = true;
        HeightTextBox.Size = new Size(156, 24);
        HeightTextBox.TabIndex = 7;
        // 
        // WeightTextBox
        // 
        WeightTextBox.Location = new Point(109, 132);
        WeightTextBox.Margin = new Padding(4, 3, 4, 3);
        WeightTextBox.Name = "WeightTextBox";
        WeightTextBox.ReadOnly = true;
        WeightTextBox.Size = new Size(156, 24);
        WeightTextBox.TabIndex = 9;
        // 
        // WeightCaptionLabel
        // 
        WeightCaptionLabel.AutoSize = true;
        WeightCaptionLabel.Location = new Point(69, 135);
        WeightCaptionLabel.Margin = new Padding(5, 0, 5, 0);
        WeightCaptionLabel.Name = "WeightCaptionLabel";
        WeightCaptionLabel.Size = new Size(31, 17);
        WeightCaptionLabel.TabIndex = 8;
        WeightCaptionLabel.Text = "重さ";
        WeightCaptionLabel.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // SpeciesGroupBox
        // 
        SpeciesGroupBox.Controls.Add(IsDefaultTextBox);
        SpeciesGroupBox.Controls.Add(IsDefaultCaptionLabel);
        SpeciesGroupBox.Controls.Add(SpeciesButton);
        SpeciesGroupBox.Controls.Add(SpeciesTextBox);
        SpeciesGroupBox.Location = new Point(272, 15);
        SpeciesGroupBox.Name = "SpeciesGroupBox";
        SpeciesGroupBox.Size = new Size(222, 95);
        SpeciesGroupBox.TabIndex = 12;
        SpeciesGroupBox.TabStop = false;
        SpeciesGroupBox.Text = "ポケモン種族";
        // 
        // IsDefaultTextBox
        // 
        IsDefaultTextBox.Location = new Point(73, 54);
        IsDefaultTextBox.Margin = new Padding(4, 3, 4, 3);
        IsDefaultTextBox.Name = "IsDefaultTextBox";
        IsDefaultTextBox.ReadOnly = true;
        IsDefaultTextBox.Size = new Size(142, 24);
        IsDefaultTextBox.TabIndex = 3;
        // 
        // IsDefaultCaptionLabel
        // 
        IsDefaultCaptionLabel.AutoSize = true;
        IsDefaultCaptionLabel.Location = new Point(6, 57);
        IsDefaultCaptionLabel.Margin = new Padding(5, 0, 5, 0);
        IsDefaultCaptionLabel.Name = "IsDefaultCaptionLabel";
        IsDefaultCaptionLabel.Size = new Size(58, 17);
        IsDefaultCaptionLabel.TabIndex = 2;
        IsDefaultCaptionLabel.Text = "デフォルト";
        IsDefaultCaptionLabel.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // OrderCaptionLabel
        // 
        OrderCaptionLabel.AutoSize = true;
        OrderCaptionLabel.Location = new Point(14, 165);
        OrderCaptionLabel.Margin = new Padding(5, 0, 5, 0);
        OrderCaptionLabel.Name = "OrderCaptionLabel";
        OrderCaptionLabel.Size = new Size(86, 17);
        OrderCaptionLabel.TabIndex = 10;
        OrderCaptionLabel.Text = "図鑑表示順番";
        OrderCaptionLabel.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // OrderTextBox
        // 
        OrderTextBox.Location = new Point(109, 162);
        OrderTextBox.Margin = new Padding(4, 3, 4, 3);
        OrderTextBox.Name = "OrderTextBox";
        OrderTextBox.ReadOnly = true;
        OrderTextBox.Size = new Size(156, 24);
        OrderTextBox.TabIndex = 11;
        // 
        // GameIndiceDataGridView
        // 
        GameIndiceDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        GameIndiceDataGridView.Columns.AddRange(new DataGridViewColumn[] { VersionColumn, GameIndexColumn, DetailButtonColumn });
        GameIndiceDataGridView.Location = new Point(13, 212);
        GameIndiceDataGridView.Margin = new Padding(4, 3, 4, 3);
        GameIndiceDataGridView.Name = "GameIndiceDataGridView";
        GameIndiceDataGridView.RowHeadersVisible = false;
        GameIndiceDataGridView.Size = new Size(252, 225);
        GameIndiceDataGridView.TabIndex = 14;
        GameIndiceDataGridView.CellClick += GameIndiceDataGridView_CellClick;
        GameIndiceDataGridView.CellDoubleClick += GameIndiceDataGridView_CellDoubleClick;
        // 
        // VersionColumn
        // 
        VersionColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
        VersionColumn.DataPropertyName = "Version";
        VersionColumn.HeaderText = "バージョン";
        VersionColumn.Name = "VersionColumn";
        VersionColumn.ReadOnly = true;
        VersionColumn.Width = 85;
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
        // GameIndiceCaptionLabel
        // 
        GameIndiceCaptionLabel.AutoSize = true;
        GameIndiceCaptionLabel.Location = new Point(14, 192);
        GameIndiceCaptionLabel.Margin = new Padding(4, 0, 4, 0);
        GameIndiceCaptionLabel.Name = "GameIndiceCaptionLabel";
        GameIndiceCaptionLabel.Size = new Size(116, 17);
        GameIndiceCaptionLabel.TabIndex = 13;
        GameIndiceCaptionLabel.Text = "ゲーム内インデックス";
        GameIndiceCaptionLabel.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // TypesDataGridView
        // 
        TypesDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        TypesDataGridView.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1, dataGridViewTextBoxColumn2, dataGridViewButtonColumn1 });
        TypesDataGridView.Location = new Point(271, 133);
        TypesDataGridView.Margin = new Padding(4, 3, 4, 3);
        TypesDataGridView.Name = "TypesDataGridView";
        TypesDataGridView.RowHeadersVisible = false;
        TypesDataGridView.Size = new Size(223, 84);
        TypesDataGridView.TabIndex = 16;
        TypesDataGridView.CellClick += TypesDataGridView_CellClick;
        TypesDataGridView.CellDoubleClick += TypesDataGridView_CellDoubleClick;
        // 
        // dataGridViewTextBoxColumn1
        // 
        dataGridViewTextBoxColumn1.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
        dataGridViewTextBoxColumn1.DataPropertyName = "Slot";
        dataGridViewTextBoxColumn1.HeaderText = "";
        dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
        dataGridViewTextBoxColumn1.ReadOnly = true;
        dataGridViewTextBoxColumn1.Width = 21;
        // 
        // dataGridViewTextBoxColumn2
        // 
        dataGridViewTextBoxColumn2.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
        dataGridViewTextBoxColumn2.DataPropertyName = "Type";
        dataGridViewTextBoxColumn2.HeaderText = "タイプ";
        dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
        dataGridViewTextBoxColumn2.ReadOnly = true;
        dataGridViewTextBoxColumn2.Width = 65;
        // 
        // dataGridViewButtonColumn1
        // 
        dataGridViewButtonColumn1.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
        dataGridViewButtonColumn1.HeaderText = "詳細";
        dataGridViewButtonColumn1.Name = "dataGridViewButtonColumn1";
        dataGridViewButtonColumn1.Text = "詳細";
        dataGridViewButtonColumn1.UseColumnTextForButtonValue = true;
        dataGridViewButtonColumn1.Width = 40;
        // 
        // TypesCaptionLabel
        // 
        TypesCaptionLabel.AutoSize = true;
        TypesCaptionLabel.Location = new Point(272, 113);
        TypesCaptionLabel.Margin = new Padding(4, 0, 4, 0);
        TypesCaptionLabel.Name = "TypesCaptionLabel";
        TypesCaptionLabel.Size = new Size(40, 17);
        TypesCaptionLabel.TabIndex = 15;
        TypesCaptionLabel.Text = "タイプ";
        TypesCaptionLabel.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // CriesLatestButton
        // 
        CriesLatestButton.Location = new Point(14, 545);
        CriesLatestButton.Margin = new Padding(4, 3, 4, 3);
        CriesLatestButton.Name = "CriesLatestButton";
        CriesLatestButton.Size = new Size(76, 35);
        CriesLatestButton.TabIndex = 27;
        CriesLatestButton.Text = "鳴き声";
        CriesLatestButton.UseVisualStyleBackColor = true;
        // 
        // StatsCaptionLabel
        // 
        StatsCaptionLabel.AutoSize = true;
        StatsCaptionLabel.Location = new Point(500, 12);
        StatsCaptionLabel.Margin = new Padding(4, 0, 4, 0);
        StatsCaptionLabel.Name = "StatsCaptionLabel";
        StatsCaptionLabel.Size = new Size(61, 17);
        StatsCaptionLabel.TabIndex = 19;
        StatsCaptionLabel.Text = "ステータス";
        StatsCaptionLabel.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // StatsDataGridView
        // 
        StatsDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        StatsDataGridView.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn3, dataGridViewButtonColumn2 });
        StatsDataGridView.Location = new Point(500, 32);
        StatsDataGridView.Margin = new Padding(4, 3, 4, 3);
        StatsDataGridView.Name = "StatsDataGridView";
        StatsDataGridView.RowHeadersVisible = false;
        StatsDataGridView.Size = new Size(203, 405);
        StatsDataGridView.TabIndex = 20;
        StatsDataGridView.CellClick += StatsDataGridView_CellClick;
        StatsDataGridView.CellDoubleClick += StatsDataGridView_CellDoubleClick;
        // 
        // dataGridViewTextBoxColumn3
        // 
        dataGridViewTextBoxColumn3.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
        dataGridViewTextBoxColumn3.DataPropertyName = "Stat";
        dataGridViewTextBoxColumn3.HeaderText = "ステータス";
        dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
        dataGridViewTextBoxColumn3.ReadOnly = true;
        dataGridViewTextBoxColumn3.Width = 86;
        // 
        // dataGridViewButtonColumn2
        // 
        dataGridViewButtonColumn2.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
        dataGridViewButtonColumn2.HeaderText = "詳細";
        dataGridViewButtonColumn2.Name = "dataGridViewButtonColumn2";
        dataGridViewButtonColumn2.Text = "詳細";
        dataGridViewButtonColumn2.UseColumnTextForButtonValue = true;
        dataGridViewButtonColumn2.Width = 40;
        // 
        // AbilitiesDataGridView
        // 
        AbilitiesDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        AbilitiesDataGridView.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn4, dataGridViewTextBoxColumn5, dataGridViewButtonColumn3 });
        AbilitiesDataGridView.Location = new Point(270, 240);
        AbilitiesDataGridView.Margin = new Padding(4, 3, 4, 3);
        AbilitiesDataGridView.Name = "AbilitiesDataGridView";
        AbilitiesDataGridView.RowHeadersVisible = false;
        AbilitiesDataGridView.Size = new Size(223, 197);
        AbilitiesDataGridView.TabIndex = 18;
        AbilitiesDataGridView.CellClick += AbilitiesDataGridView_CellClick;
        AbilitiesDataGridView.CellDoubleClick += AbilitiesDataGridView_CellDoubleClick;
        // 
        // dataGridViewTextBoxColumn4
        // 
        dataGridViewTextBoxColumn4.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
        dataGridViewTextBoxColumn4.DataPropertyName = "Slot";
        dataGridViewTextBoxColumn4.HeaderText = "";
        dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
        dataGridViewTextBoxColumn4.ReadOnly = true;
        dataGridViewTextBoxColumn4.Width = 21;
        // 
        // dataGridViewTextBoxColumn5
        // 
        dataGridViewTextBoxColumn5.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
        dataGridViewTextBoxColumn5.DataPropertyName = "Ability";
        dataGridViewTextBoxColumn5.HeaderText = "特性";
        dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
        dataGridViewTextBoxColumn5.ReadOnly = true;
        dataGridViewTextBoxColumn5.Width = 59;
        // 
        // dataGridViewButtonColumn3
        // 
        dataGridViewButtonColumn3.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
        dataGridViewButtonColumn3.HeaderText = "詳細";
        dataGridViewButtonColumn3.Name = "dataGridViewButtonColumn3";
        dataGridViewButtonColumn3.Text = "詳細";
        dataGridViewButtonColumn3.UseColumnTextForButtonValue = true;
        dataGridViewButtonColumn3.Width = 40;
        // 
        // AbilitiesCaptionLabel
        // 
        AbilitiesCaptionLabel.AutoSize = true;
        AbilitiesCaptionLabel.Location = new Point(271, 220);
        AbilitiesCaptionLabel.Margin = new Padding(4, 0, 4, 0);
        AbilitiesCaptionLabel.Name = "AbilitiesCaptionLabel";
        AbilitiesCaptionLabel.Size = new Size(34, 17);
        AbilitiesCaptionLabel.TabIndex = 17;
        AbilitiesCaptionLabel.Text = "特性";
        AbilitiesCaptionLabel.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // PastButton
        // 
        PastButton.Location = new Point(182, 545);
        PastButton.Margin = new Padding(4, 3, 4, 3);
        PastButton.Name = "PastButton";
        PastButton.Size = new Size(76, 35);
        PastButton.TabIndex = 29;
        PastButton.Text = "過去情報";
        PastButton.UseVisualStyleBackColor = true;
        // 
        // LocationAreaEncountersButton
        // 
        LocationAreaEncountersButton.Location = new Point(98, 545);
        LocationAreaEncountersButton.Margin = new Padding(4, 3, 4, 3);
        LocationAreaEncountersButton.Name = "LocationAreaEncountersButton";
        LocationAreaEncountersButton.Size = new Size(76, 35);
        LocationAreaEncountersButton.TabIndex = 28;
        LocationAreaEncountersButton.Text = "遭遇場所";
        LocationAreaEncountersButton.UseVisualStyleBackColor = true;
        // 
        // MovesDataGridView
        // 
        MovesDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        MovesDataGridView.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn6, dataGridViewButtonColumn4 });
        MovesDataGridView.Location = new Point(879, 32);
        MovesDataGridView.Margin = new Padding(4, 3, 4, 3);
        MovesDataGridView.Name = "MovesDataGridView";
        MovesDataGridView.RowHeadersVisible = false;
        MovesDataGridView.Size = new Size(233, 405);
        MovesDataGridView.TabIndex = 24;
        MovesDataGridView.CellClick += MovesDataGridView_CellClick;
        MovesDataGridView.CellDoubleClick += MovesDataGridView_CellDoubleClick;
        // 
        // dataGridViewTextBoxColumn6
        // 
        dataGridViewTextBoxColumn6.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
        dataGridViewTextBoxColumn6.DataPropertyName = "Move";
        dataGridViewTextBoxColumn6.HeaderText = "技";
        dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
        dataGridViewTextBoxColumn6.ReadOnly = true;
        dataGridViewTextBoxColumn6.Width = 46;
        // 
        // dataGridViewButtonColumn4
        // 
        dataGridViewButtonColumn4.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
        dataGridViewButtonColumn4.HeaderText = "詳細";
        dataGridViewButtonColumn4.Name = "dataGridViewButtonColumn4";
        dataGridViewButtonColumn4.Text = "詳細";
        dataGridViewButtonColumn4.UseColumnTextForButtonValue = true;
        dataGridViewButtonColumn4.Width = 40;
        // 
        // MovesCaptionLabel
        // 
        MovesCaptionLabel.AutoSize = true;
        MovesCaptionLabel.Location = new Point(879, 12);
        MovesCaptionLabel.Margin = new Padding(4, 0, 4, 0);
        MovesCaptionLabel.Name = "MovesCaptionLabel";
        MovesCaptionLabel.Size = new Size(21, 17);
        MovesCaptionLabel.TabIndex = 23;
        MovesCaptionLabel.Text = "技";
        MovesCaptionLabel.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // HeldItemsDataGridView
        // 
        HeldItemsDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        HeldItemsDataGridView.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn7, dataGridViewButtonColumn5 });
        HeldItemsDataGridView.Location = new Point(1120, 32);
        HeldItemsDataGridView.Margin = new Padding(4, 3, 4, 3);
        HeldItemsDataGridView.Name = "HeldItemsDataGridView";
        HeldItemsDataGridView.RowHeadersVisible = false;
        HeldItemsDataGridView.Size = new Size(160, 405);
        HeldItemsDataGridView.TabIndex = 26;
        // 
        // dataGridViewTextBoxColumn7
        // 
        dataGridViewTextBoxColumn7.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
        dataGridViewTextBoxColumn7.DataPropertyName = "Item";
        dataGridViewTextBoxColumn7.HeaderText = "アイテム";
        dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
        dataGridViewTextBoxColumn7.ReadOnly = true;
        dataGridViewTextBoxColumn7.Width = 76;
        // 
        // dataGridViewButtonColumn5
        // 
        dataGridViewButtonColumn5.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
        dataGridViewButtonColumn5.HeaderText = "詳細";
        dataGridViewButtonColumn5.Name = "dataGridViewButtonColumn5";
        dataGridViewButtonColumn5.Text = "詳細";
        dataGridViewButtonColumn5.UseColumnTextForButtonValue = true;
        dataGridViewButtonColumn5.Width = 40;
        // 
        // HeldItemsCaptionLabel
        // 
        HeldItemsCaptionLabel.AutoSize = true;
        HeldItemsCaptionLabel.Location = new Point(1120, 12);
        HeldItemsCaptionLabel.Margin = new Padding(4, 0, 4, 0);
        HeldItemsCaptionLabel.Name = "HeldItemsCaptionLabel";
        HeldItemsCaptionLabel.Size = new Size(77, 17);
        HeldItemsCaptionLabel.TabIndex = 25;
        HeldItemsCaptionLabel.Text = "所持アイテム";
        HeldItemsCaptionLabel.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // FormsDataGridView
        // 
        FormsDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        FormsDataGridView.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn8, dataGridViewButtonColumn6 });
        FormsDataGridView.Location = new Point(711, 32);
        FormsDataGridView.Margin = new Padding(4, 3, 4, 3);
        FormsDataGridView.Name = "FormsDataGridView";
        FormsDataGridView.RowHeadersVisible = false;
        FormsDataGridView.Size = new Size(160, 405);
        FormsDataGridView.TabIndex = 22;
        // 
        // dataGridViewTextBoxColumn8
        // 
        dataGridViewTextBoxColumn8.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
        dataGridViewTextBoxColumn8.DataPropertyName = "Name";
        dataGridViewTextBoxColumn8.HeaderText = "フォーム";
        dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
        dataGridViewTextBoxColumn8.ReadOnly = true;
        dataGridViewTextBoxColumn8.Width = 73;
        // 
        // dataGridViewButtonColumn6
        // 
        dataGridViewButtonColumn6.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
        dataGridViewButtonColumn6.HeaderText = "詳細";
        dataGridViewButtonColumn6.Name = "dataGridViewButtonColumn6";
        dataGridViewButtonColumn6.Text = "詳細";
        dataGridViewButtonColumn6.UseColumnTextForButtonValue = true;
        dataGridViewButtonColumn6.Width = 40;
        // 
        // FormsCaptionLabel
        // 
        FormsCaptionLabel.AutoSize = true;
        FormsCaptionLabel.Location = new Point(711, 12);
        FormsCaptionLabel.Margin = new Padding(4, 0, 4, 0);
        FormsCaptionLabel.Name = "FormsCaptionLabel";
        FormsCaptionLabel.Size = new Size(97, 17);
        FormsCaptionLabel.TabIndex = 21;
        FormsCaptionLabel.Text = "リージョンフォーム";
        FormsCaptionLabel.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // SpriteBackShinyFemalePictureBox
        // 
        SpriteBackShinyFemalePictureBox.Location = new Point(741, 443);
        SpriteBackShinyFemalePictureBox.Margin = new Padding(4, 3, 4, 3);
        SpriteBackShinyFemalePictureBox.Name = "SpriteBackShinyFemalePictureBox";
        SpriteBackShinyFemalePictureBox.Size = new Size(96, 96);
        SpriteBackShinyFemalePictureBox.TabIndex = 49;
        SpriteBackShinyFemalePictureBox.TabStop = false;
        // 
        // SpriteBackFemalePictureBox
        // 
        SpriteBackFemalePictureBox.Location = new Point(637, 443);
        SpriteBackFemalePictureBox.Margin = new Padding(4, 3, 4, 3);
        SpriteBackFemalePictureBox.Name = "SpriteBackFemalePictureBox";
        SpriteBackFemalePictureBox.Size = new Size(96, 96);
        SpriteBackFemalePictureBox.TabIndex = 48;
        SpriteBackFemalePictureBox.TabStop = false;
        // 
        // SpriteBackShinyPictureBox
        // 
        SpriteBackShinyPictureBox.Location = new Point(533, 443);
        SpriteBackShinyPictureBox.Margin = new Padding(4, 3, 4, 3);
        SpriteBackShinyPictureBox.Name = "SpriteBackShinyPictureBox";
        SpriteBackShinyPictureBox.Size = new Size(96, 96);
        SpriteBackShinyPictureBox.TabIndex = 47;
        SpriteBackShinyPictureBox.TabStop = false;
        // 
        // SpriteBackDefaultPictureBox
        // 
        SpriteBackDefaultPictureBox.Location = new Point(429, 443);
        SpriteBackDefaultPictureBox.Margin = new Padding(4, 3, 4, 3);
        SpriteBackDefaultPictureBox.Name = "SpriteBackDefaultPictureBox";
        SpriteBackDefaultPictureBox.Size = new Size(96, 96);
        SpriteBackDefaultPictureBox.TabIndex = 46;
        SpriteBackDefaultPictureBox.TabStop = false;
        // 
        // SpriteFrontShinyFemalePictureBox
        // 
        SpriteFrontShinyFemalePictureBox.Location = new Point(325, 443);
        SpriteFrontShinyFemalePictureBox.Margin = new Padding(4, 3, 4, 3);
        SpriteFrontShinyFemalePictureBox.Name = "SpriteFrontShinyFemalePictureBox";
        SpriteFrontShinyFemalePictureBox.Size = new Size(96, 96);
        SpriteFrontShinyFemalePictureBox.TabIndex = 45;
        SpriteFrontShinyFemalePictureBox.TabStop = false;
        // 
        // SpriteFrontFemalePictureBox
        // 
        SpriteFrontFemalePictureBox.Location = new Point(221, 443);
        SpriteFrontFemalePictureBox.Margin = new Padding(4, 3, 4, 3);
        SpriteFrontFemalePictureBox.Name = "SpriteFrontFemalePictureBox";
        SpriteFrontFemalePictureBox.Size = new Size(96, 96);
        SpriteFrontFemalePictureBox.TabIndex = 44;
        SpriteFrontFemalePictureBox.TabStop = false;
        // 
        // SpriteFrontShinyPictureBox
        // 
        SpriteFrontShinyPictureBox.Location = new Point(117, 443);
        SpriteFrontShinyPictureBox.Margin = new Padding(4, 3, 4, 3);
        SpriteFrontShinyPictureBox.Name = "SpriteFrontShinyPictureBox";
        SpriteFrontShinyPictureBox.Size = new Size(96, 96);
        SpriteFrontShinyPictureBox.TabIndex = 43;
        SpriteFrontShinyPictureBox.TabStop = false;
        // 
        // SpriteFrontDefaultPictureBox
        // 
        SpriteFrontDefaultPictureBox.Location = new Point(13, 443);
        SpriteFrontDefaultPictureBox.Margin = new Padding(4, 3, 4, 3);
        SpriteFrontDefaultPictureBox.Name = "SpriteFrontDefaultPictureBox";
        SpriteFrontDefaultPictureBox.Size = new Size(96, 96);
        SpriteFrontDefaultPictureBox.TabIndex = 42;
        SpriteFrontDefaultPictureBox.TabStop = false;
        // 
        // PokemonInfoForm
        // 
        AutoScaleDimensions = new SizeF(9F, 17F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(1297, 592);
        Controls.Add(SpriteBackShinyFemalePictureBox);
        Controls.Add(SpriteBackFemalePictureBox);
        Controls.Add(SpriteBackShinyPictureBox);
        Controls.Add(SpriteBackDefaultPictureBox);
        Controls.Add(SpriteFrontShinyFemalePictureBox);
        Controls.Add(SpriteFrontFemalePictureBox);
        Controls.Add(SpriteFrontShinyPictureBox);
        Controls.Add(SpriteFrontDefaultPictureBox);
        Controls.Add(FormsDataGridView);
        Controls.Add(FormsCaptionLabel);
        Controls.Add(HeldItemsCaptionLabel);
        Controls.Add(HeldItemsDataGridView);
        Controls.Add(MovesDataGridView);
        Controls.Add(MovesCaptionLabel);
        Controls.Add(LocationAreaEncountersButton);
        Controls.Add(PastButton);
        Controls.Add(AbilitiesDataGridView);
        Controls.Add(CriesLatestButton);
        Controls.Add(AbilitiesCaptionLabel);
        Controls.Add(StatsDataGridView);
        Controls.Add(StatsCaptionLabel);
        Controls.Add(TypesDataGridView);
        Controls.Add(TypesCaptionLabel);
        Controls.Add(GameIndiceDataGridView);
        Controls.Add(GameIndiceCaptionLabel);
        Controls.Add(OrderTextBox);
        Controls.Add(OrderCaptionLabel);
        Controls.Add(SpeciesGroupBox);
        Controls.Add(WeightCaptionLabel);
        Controls.Add(WeightTextBox);
        Controls.Add(HeightTextBox);
        Controls.Add(HeightCaptionLabel);
        Controls.Add(BaseExperienceTextBox);
        Controls.Add(BaseExperienceCaptionLabel);
        Controls.Add(PropertyButton);
        Controls.Add(CloseButton);
        Controls.Add(NameTextBox);
        Controls.Add(IdTextBox);
        Controls.Add(NameCaptionLabel);
        Controls.Add(IdCaptionLabel);
        Font = new Font("Meiryo UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 128);
        FormBorderStyle = FormBorderStyle.FixedSingle;
        Margin = new Padding(4, 3, 4, 3);
        MaximizeBox = false;
        Name = "PokemonInfoForm";
        StartPosition = FormStartPosition.CenterParent;
        Text = "ポケモン";
        SpeciesGroupBox.ResumeLayout(false);
        SpeciesGroupBox.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)GameIndiceDataGridView).EndInit();
        ((System.ComponentModel.ISupportInitialize)TypesDataGridView).EndInit();
        ((System.ComponentModel.ISupportInitialize)StatsDataGridView).EndInit();
        ((System.ComponentModel.ISupportInitialize)AbilitiesDataGridView).EndInit();
        ((System.ComponentModel.ISupportInitialize)MovesDataGridView).EndInit();
        ((System.ComponentModel.ISupportInitialize)HeldItemsDataGridView).EndInit();
        ((System.ComponentModel.ISupportInitialize)FormsDataGridView).EndInit();
        ((System.ComponentModel.ISupportInitialize)SpriteBackShinyFemalePictureBox).EndInit();
        ((System.ComponentModel.ISupportInitialize)SpriteBackFemalePictureBox).EndInit();
        ((System.ComponentModel.ISupportInitialize)SpriteBackShinyPictureBox).EndInit();
        ((System.ComponentModel.ISupportInitialize)SpriteBackDefaultPictureBox).EndInit();
        ((System.ComponentModel.ISupportInitialize)SpriteFrontShinyFemalePictureBox).EndInit();
        ((System.ComponentModel.ISupportInitialize)SpriteFrontFemalePictureBox).EndInit();
        ((System.ComponentModel.ISupportInitialize)SpriteFrontShinyPictureBox).EndInit();
        ((System.ComponentModel.ISupportInitialize)SpriteFrontDefaultPictureBox).EndInit();
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private TextBox NameTextBox;
    private TextBox IdTextBox;
    private Label NameCaptionLabel;
    private Label IdCaptionLabel;
    private Button PropertyButton;
    private Button CloseButton;
    private Button SpeciesButton;
    private TextBox SpeciesTextBox;
    private Label BaseExperienceCaptionLabel;
    private TextBox BaseExperienceTextBox;
    private Label HeightCaptionLabel;
    private TextBox HeightTextBox;
    private TextBox WeightTextBox;
    private Label WeightCaptionLabel;
    private GroupBox SpeciesGroupBox;
    private Label IsDefaultCaptionLabel;
    private TextBox IsDefaultTextBox;
    private Label OrderCaptionLabel;
    private TextBox OrderTextBox;
    private DataGridView GameIndiceDataGridView;
    private Label GameIndiceCaptionLabel;
    private DataGridViewTextBoxColumn VersionColumn;
    private DataGridViewTextBoxColumn GameIndexColumn;
    private DataGridViewButtonColumn DetailButtonColumn;
    private DataGridView TypesDataGridView;
    private Label TypesCaptionLabel;
    private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
    private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
    private DataGridViewButtonColumn dataGridViewButtonColumn1;
    private Button CriesLatestButton;
    private Label StatsCaptionLabel;
    private DataGridView StatsDataGridView;
    private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
    private DataGridViewButtonColumn dataGridViewButtonColumn2;
    private DataGridView AbilitiesDataGridView;
    private Label AbilitiesCaptionLabel;
    private Button PastButton;
    private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
    private DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
    private DataGridViewButtonColumn dataGridViewButtonColumn3;
    private Button LocationAreaEncountersButton;
    private DataGridView MovesDataGridView;
    private DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
    private DataGridViewButtonColumn dataGridViewButtonColumn4;
    private Label MovesCaptionLabel;
    private DataGridView HeldItemsDataGridView;
    private DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
    private DataGridViewButtonColumn dataGridViewButtonColumn5;
    private Label HeldItemsCaptionLabel;
    private DataGridView FormsDataGridView;
    private DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
    private DataGridViewButtonColumn dataGridViewButtonColumn6;
    private Label FormsCaptionLabel;
    private PictureBox SpriteBackShinyFemalePictureBox;
    private PictureBox SpriteBackFemalePictureBox;
    private PictureBox SpriteBackShinyPictureBox;
    private PictureBox SpriteBackDefaultPictureBox;
    private PictureBox SpriteFrontShinyFemalePictureBox;
    private PictureBox SpriteFrontFemalePictureBox;
    private PictureBox SpriteFrontShinyPictureBox;
    private PictureBox SpriteFrontDefaultPictureBox;
}