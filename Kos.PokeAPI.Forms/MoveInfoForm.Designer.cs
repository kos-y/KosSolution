namespace Kos.PokeAPI.Forms;

partial class MoveInfoForm
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
        DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
        NameTextBox = new TextBox();
        IdTextBox = new TextBox();
        NameCaptionLabel = new Label();
        IdCaptionLabel = new Label();
        PPTextBox = new TextBox();
        PPCaptionLabel = new Label();
        AccuracyCaptionLabel = new Label();
        AccuracyTextBox = new TextBox();
        EffectChanceTextBox = new TextBox();
        EffectChanceCaptionLabel = new Label();
        PowerTextBox = new TextBox();
        PowerCaptionLabel = new Label();
        PriorityTextBox = new TextBox();
        PriorityCaptionLabel = new Label();
        DamageClassTextBox = new TextBox();
        DamageClassCaptionLabel = new Label();
        DamageClassDetailButton = new Button();
        ContestGroupBox = new GroupBox();
        ContestEffectGroupBox = new GroupBox();
        SuperContestEffectDetailButton = new Button();
        SuperContestEffectCaptionLabel = new Label();
        SuperContestEffectTextBox = new TextBox();
        ContestEffectTextBox = new TextBox();
        ContestEffectCaptionLabel = new Label();
        ContestEffectDetailButton = new Button();
        ContestCombosDetailButton = new Button();
        ContestCombosCaptionLabel = new Label();
        ContestTypeDetailButton = new Button();
        ContestTypeTextBox = new TextBox();
        ContestTypeCaptionLabel = new Label();
        GenerationCaptionLabel = new Label();
        GenerationTextBox = new TextBox();
        GenerationDetailButton = new Button();
        MetaDetailButton = new Button();
        TargetDetailButton = new Button();
        TargetTextBox = new TextBox();
        TargetCaptionLabel = new Label();
        TypeDetailButton = new Button();
        TypeTextBox = new TextBox();
        TypeCaptionLabel = new Label();
        NamesDataGridView = new DataGridView();
        NameColumn = new DataGridViewTextBoxColumn();
        LanguageColumn = new DataGridViewTextBoxColumn();
        DetailColumn = new DataGridViewButtonColumn();
        NamesCaptionLabel = new Label();
        LearnedByPokemonDataGridView = new DataGridView();
        dataGridViewTextBoxColumn7 = new DataGridViewTextBoxColumn();
        dataGridViewButtonColumn6 = new DataGridViewButtonColumn();
        LearnedByPokemonCaptionLabel = new Label();
        tabControl1 = new TabControl();
        FlavorTextTabPage = new TabPage();
        FlavorTextEntriesDataGridView = new DataGridView();
        EffectTabPage = new TabPage();
        EffectEntriesDataGridView = new DataGridView();
        EffectColumn = new DataGridViewTextBoxColumn();
        EffectDetailColumn = new DataGridViewButtonColumn();
        EffectChangesTabPage = new TabPage();
        EffectChangesDataGridView = new DataGridView();
        dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
        dataGridViewButtonColumn1 = new DataGridViewButtonColumn();
        MachineTabPage = new TabPage();
        MachinesDataGridView = new DataGridView();
        MachineVersionGroupColumn = new DataGridViewTextBoxColumn();
        MachineDetailColumn = new DataGridViewButtonColumn();
        StatChangeTabPage = new TabPage();
        StatChangeDataGridView = new DataGridView();
        dataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
        dataGridViewTextBoxColumn4 = new DataGridViewTextBoxColumn();
        dataGridViewButtonColumn3 = new DataGridViewButtonColumn();
        PastStatChangeTabPage = new TabPage();
        PastValuesDataGridView = new DataGridView();
        dataGridViewTextBoxColumn6 = new DataGridViewTextBoxColumn();
        dataGridViewButtonColumn4 = new DataGridViewButtonColumn();
        CloseButton = new Button();
        FlavorTextVersionGroupColumn = new DataGridViewTextBoxColumn();
        FlavorTextLanguageColumn = new DataGridViewTextBoxColumn();
        FlavorTextColumn = new DataGridViewTextBoxColumn();
        FlavorTextDetailColumn = new DataGridViewButtonColumn();
        ContestGroupBox.SuspendLayout();
        ContestEffectGroupBox.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)NamesDataGridView).BeginInit();
        ((System.ComponentModel.ISupportInitialize)LearnedByPokemonDataGridView).BeginInit();
        tabControl1.SuspendLayout();
        FlavorTextTabPage.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)FlavorTextEntriesDataGridView).BeginInit();
        EffectTabPage.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)EffectEntriesDataGridView).BeginInit();
        EffectChangesTabPage.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)EffectChangesDataGridView).BeginInit();
        MachineTabPage.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)MachinesDataGridView).BeginInit();
        StatChangeTabPage.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)StatChangeDataGridView).BeginInit();
        PastStatChangeTabPage.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)PastValuesDataGridView).BeginInit();
        SuspendLayout();
        // 
        // NameTextBox
        // 
        NameTextBox.Location = new Point(77, 42);
        NameTextBox.Name = "NameTextBox";
        NameTextBox.ReadOnly = true;
        NameTextBox.Size = new Size(191, 24);
        NameTextBox.TabIndex = 3;
        // 
        // IdTextBox
        // 
        IdTextBox.Location = new Point(77, 12);
        IdTextBox.Name = "IdTextBox";
        IdTextBox.ReadOnly = true;
        IdTextBox.Size = new Size(191, 24);
        IdTextBox.TabIndex = 1;
        // 
        // NameCaptionLabel
        // 
        NameCaptionLabel.AutoSize = true;
        NameCaptionLabel.Location = new Point(31, 45);
        NameCaptionLabel.Margin = new Padding(4, 0, 4, 0);
        NameCaptionLabel.Name = "NameCaptionLabel";
        NameCaptionLabel.Size = new Size(34, 17);
        NameCaptionLabel.TabIndex = 2;
        NameCaptionLabel.Text = "技名";
        NameCaptionLabel.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // IdCaptionLabel
        // 
        IdCaptionLabel.AutoSize = true;
        IdCaptionLabel.Location = new Point(25, 15);
        IdCaptionLabel.Margin = new Padding(4, 0, 4, 0);
        IdCaptionLabel.Name = "IdCaptionLabel";
        IdCaptionLabel.Size = new Size(38, 17);
        IdCaptionLabel.TabIndex = 0;
        IdCaptionLabel.Text = "技ID";
        IdCaptionLabel.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // PPTextBox
        // 
        PPTextBox.Location = new Point(77, 102);
        PPTextBox.Name = "PPTextBox";
        PPTextBox.ReadOnly = true;
        PPTextBox.Size = new Size(56, 24);
        PPTextBox.TabIndex = 8;
        PPTextBox.Text = "99";
        // 
        // PPCaptionLabel
        // 
        PPCaptionLabel.AutoSize = true;
        PPCaptionLabel.Location = new Point(13, 105);
        PPCaptionLabel.Margin = new Padding(4, 0, 4, 0);
        PPCaptionLabel.Name = "PPCaptionLabel";
        PPCaptionLabel.Size = new Size(52, 17);
        PPCaptionLabel.TabIndex = 7;
        PPCaptionLabel.Text = "消費PP";
        PPCaptionLabel.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // AccuracyCaptionLabel
        // 
        AccuracyCaptionLabel.AutoSize = true;
        AccuracyCaptionLabel.Location = new Point(24, 135);
        AccuracyCaptionLabel.Margin = new Padding(4, 0, 4, 0);
        AccuracyCaptionLabel.Name = "AccuracyCaptionLabel";
        AccuracyCaptionLabel.Size = new Size(47, 17);
        AccuracyCaptionLabel.TabIndex = 10;
        AccuracyCaptionLabel.Text = "命中率";
        AccuracyCaptionLabel.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // AccuracyTextBox
        // 
        AccuracyTextBox.Location = new Point(77, 132);
        AccuracyTextBox.Name = "AccuracyTextBox";
        AccuracyTextBox.ReadOnly = true;
        AccuracyTextBox.Size = new Size(56, 24);
        AccuracyTextBox.TabIndex = 11;
        AccuracyTextBox.Text = "99";
        // 
        // EffectChanceTextBox
        // 
        EffectChanceTextBox.Location = new Point(440, 72);
        EffectChanceTextBox.Name = "EffectChanceTextBox";
        EffectChanceTextBox.ReadOnly = true;
        EffectChanceTextBox.Size = new Size(56, 24);
        EffectChanceTextBox.TabIndex = 21;
        EffectChanceTextBox.Text = "99";
        // 
        // EffectChanceCaptionLabel
        // 
        EffectChanceCaptionLabel.AutoSize = true;
        EffectChanceCaptionLabel.Location = new Point(334, 75);
        EffectChanceCaptionLabel.Margin = new Padding(4, 0, 4, 0);
        EffectChanceCaptionLabel.Name = "EffectChanceCaptionLabel";
        EffectChanceCaptionLabel.Size = new Size(99, 17);
        EffectChanceCaptionLabel.TabIndex = 20;
        EffectChanceCaptionLabel.Text = "追加効果発動率";
        EffectChanceCaptionLabel.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // PowerTextBox
        // 
        PowerTextBox.Location = new Point(181, 132);
        PowerTextBox.Name = "PowerTextBox";
        PowerTextBox.ReadOnly = true;
        PowerTextBox.Size = new Size(56, 24);
        PowerTextBox.TabIndex = 13;
        PowerTextBox.Text = "99";
        // 
        // PowerCaptionLabel
        // 
        PowerCaptionLabel.AutoSize = true;
        PowerCaptionLabel.Location = new Point(140, 135);
        PowerCaptionLabel.Margin = new Padding(4, 0, 4, 0);
        PowerCaptionLabel.Name = "PowerCaptionLabel";
        PowerCaptionLabel.Size = new Size(34, 17);
        PowerCaptionLabel.TabIndex = 12;
        PowerCaptionLabel.Text = "威力";
        PowerCaptionLabel.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // PriorityTextBox
        // 
        PriorityTextBox.Location = new Point(594, 72);
        PriorityTextBox.Name = "PriorityTextBox";
        PriorityTextBox.ReadOnly = true;
        PriorityTextBox.Size = new Size(56, 24);
        PriorityTextBox.TabIndex = 23;
        PriorityTextBox.Text = "99";
        // 
        // PriorityCaptionLabel
        // 
        PriorityCaptionLabel.AutoSize = true;
        PriorityCaptionLabel.Location = new Point(503, 75);
        PriorityCaptionLabel.Margin = new Padding(4, 0, 4, 0);
        PriorityCaptionLabel.Name = "PriorityCaptionLabel";
        PriorityCaptionLabel.Size = new Size(85, 17);
        PriorityCaptionLabel.TabIndex = 22;
        PriorityCaptionLabel.Text = "技の発動順番";
        PriorityCaptionLabel.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // DamageClassTextBox
        // 
        DamageClassTextBox.Location = new Point(440, 102);
        DamageClassTextBox.Name = "DamageClassTextBox";
        DamageClassTextBox.ReadOnly = true;
        DamageClassTextBox.Size = new Size(191, 24);
        DamageClassTextBox.TabIndex = 25;
        // 
        // DamageClassCaptionLabel
        // 
        DamageClassCaptionLabel.AutoSize = true;
        DamageClassCaptionLabel.Location = new Point(344, 105);
        DamageClassCaptionLabel.Margin = new Padding(4, 0, 4, 0);
        DamageClassCaptionLabel.Name = "DamageClassCaptionLabel";
        DamageClassCaptionLabel.Size = new Size(89, 17);
        DamageClassCaptionLabel.TabIndex = 24;
        DamageClassCaptionLabel.Text = "ダメージの種類";
        DamageClassCaptionLabel.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // DamageClassDetailButton
        // 
        DamageClassDetailButton.Location = new Point(637, 102);
        DamageClassDetailButton.Name = "DamageClassDetailButton";
        DamageClassDetailButton.Size = new Size(53, 24);
        DamageClassDetailButton.TabIndex = 26;
        DamageClassDetailButton.Text = "詳細";
        DamageClassDetailButton.UseVisualStyleBackColor = true;
        // 
        // ContestGroupBox
        // 
        ContestGroupBox.Controls.Add(ContestEffectGroupBox);
        ContestGroupBox.Controls.Add(ContestCombosDetailButton);
        ContestGroupBox.Controls.Add(ContestCombosCaptionLabel);
        ContestGroupBox.Controls.Add(ContestTypeDetailButton);
        ContestGroupBox.Controls.Add(ContestTypeTextBox);
        ContestGroupBox.Controls.Add(ContestTypeCaptionLabel);
        ContestGroupBox.Location = new Point(13, 171);
        ContestGroupBox.Name = "ContestGroupBox";
        ContestGroupBox.Size = new Size(423, 212);
        ContestGroupBox.TabIndex = 27;
        ContestGroupBox.TabStop = false;
        ContestGroupBox.Text = "コンテスト";
        // 
        // ContestEffectGroupBox
        // 
        ContestEffectGroupBox.Controls.Add(SuperContestEffectDetailButton);
        ContestEffectGroupBox.Controls.Add(SuperContestEffectCaptionLabel);
        ContestEffectGroupBox.Controls.Add(SuperContestEffectTextBox);
        ContestEffectGroupBox.Controls.Add(ContestEffectTextBox);
        ContestEffectGroupBox.Controls.Add(ContestEffectCaptionLabel);
        ContestEffectGroupBox.Controls.Add(ContestEffectDetailButton);
        ContestEffectGroupBox.Location = new Point(9, 93);
        ContestEffectGroupBox.Name = "ContestEffectGroupBox";
        ContestEffectGroupBox.Size = new Size(397, 103);
        ContestEffectGroupBox.TabIndex = 5;
        ContestEffectGroupBox.TabStop = false;
        ContestEffectGroupBox.Text = "効果";
        // 
        // SuperContestEffectDetailButton
        // 
        SuperContestEffectDetailButton.Location = new Point(326, 56);
        SuperContestEffectDetailButton.Name = "SuperContestEffectDetailButton";
        SuperContestEffectDetailButton.Size = new Size(53, 24);
        SuperContestEffectDetailButton.TabIndex = 5;
        SuperContestEffectDetailButton.Text = "詳細";
        SuperContestEffectDetailButton.UseVisualStyleBackColor = true;
        SuperContestEffectDetailButton.Click += SuperContestEffectDetailButton_Click;
        // 
        // SuperContestEffectCaptionLabel
        // 
        SuperContestEffectCaptionLabel.AutoSize = true;
        SuperContestEffectCaptionLabel.Location = new Point(16, 56);
        SuperContestEffectCaptionLabel.Margin = new Padding(4, 0, 4, 0);
        SuperContestEffectCaptionLabel.Name = "SuperContestEffectCaptionLabel";
        SuperContestEffectCaptionLabel.Size = new Size(104, 17);
        SuperContestEffectCaptionLabel.TabIndex = 3;
        SuperContestEffectCaptionLabel.Text = "スーパーコンテスト";
        SuperContestEffectCaptionLabel.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // SuperContestEffectTextBox
        // 
        SuperContestEffectTextBox.Location = new Point(129, 53);
        SuperContestEffectTextBox.Name = "SuperContestEffectTextBox";
        SuperContestEffectTextBox.ReadOnly = true;
        SuperContestEffectTextBox.Size = new Size(191, 24);
        SuperContestEffectTextBox.TabIndex = 4;
        // 
        // ContestEffectTextBox
        // 
        ContestEffectTextBox.Location = new Point(129, 23);
        ContestEffectTextBox.Name = "ContestEffectTextBox";
        ContestEffectTextBox.ReadOnly = true;
        ContestEffectTextBox.Size = new Size(191, 24);
        ContestEffectTextBox.TabIndex = 1;
        // 
        // ContestEffectCaptionLabel
        // 
        ContestEffectCaptionLabel.AutoSize = true;
        ContestEffectCaptionLabel.Location = new Point(16, 26);
        ContestEffectCaptionLabel.Margin = new Padding(4, 0, 4, 0);
        ContestEffectCaptionLabel.Name = "ContestEffectCaptionLabel";
        ContestEffectCaptionLabel.Size = new Size(100, 17);
        ContestEffectCaptionLabel.TabIndex = 0;
        ContestEffectCaptionLabel.Text = "ポケモンコンテスト";
        ContestEffectCaptionLabel.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // ContestEffectDetailButton
        // 
        ContestEffectDetailButton.Location = new Point(326, 23);
        ContestEffectDetailButton.Name = "ContestEffectDetailButton";
        ContestEffectDetailButton.Size = new Size(53, 24);
        ContestEffectDetailButton.TabIndex = 2;
        ContestEffectDetailButton.Text = "詳細";
        ContestEffectDetailButton.UseVisualStyleBackColor = true;
        ContestEffectDetailButton.Click += ContestEffectDetailButton_Click;
        // 
        // ContestCombosDetailButton
        // 
        ContestCombosDetailButton.Location = new Point(79, 52);
        ContestCombosDetailButton.Name = "ContestCombosDetailButton";
        ContestCombosDetailButton.Size = new Size(53, 24);
        ContestCombosDetailButton.TabIndex = 4;
        ContestCombosDetailButton.Text = "詳細";
        ContestCombosDetailButton.UseVisualStyleBackColor = true;
        ContestCombosDetailButton.Click += ContestCombosDetailButton_Click;
        // 
        // ContestCombosCaptionLabel
        // 
        ContestCombosCaptionLabel.AutoSize = true;
        ContestCombosCaptionLabel.Location = new Point(33, 56);
        ContestCombosCaptionLabel.Margin = new Padding(4, 0, 4, 0);
        ContestCombosCaptionLabel.Name = "ContestCombosCaptionLabel";
        ContestCombosCaptionLabel.Size = new Size(39, 17);
        ContestCombosCaptionLabel.TabIndex = 3;
        ContestCombosCaptionLabel.Text = "コンボ";
        ContestCombosCaptionLabel.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // ContestTypeDetailButton
        // 
        ContestTypeDetailButton.Location = new Point(276, 23);
        ContestTypeDetailButton.Name = "ContestTypeDetailButton";
        ContestTypeDetailButton.Size = new Size(53, 24);
        ContestTypeDetailButton.TabIndex = 2;
        ContestTypeDetailButton.Text = "詳細";
        ContestTypeDetailButton.UseVisualStyleBackColor = true;
        ContestTypeDetailButton.Click += ContestTypeDetailButton_Click;
        // 
        // ContestTypeTextBox
        // 
        ContestTypeTextBox.Location = new Point(79, 23);
        ContestTypeTextBox.Name = "ContestTypeTextBox";
        ContestTypeTextBox.ReadOnly = true;
        ContestTypeTextBox.Size = new Size(191, 24);
        ContestTypeTextBox.TabIndex = 1;
        // 
        // ContestTypeCaptionLabel
        // 
        ContestTypeCaptionLabel.AutoSize = true;
        ContestTypeCaptionLabel.Location = new Point(38, 26);
        ContestTypeCaptionLabel.Margin = new Padding(4, 0, 4, 0);
        ContestTypeCaptionLabel.Name = "ContestTypeCaptionLabel";
        ContestTypeCaptionLabel.Size = new Size(34, 17);
        ContestTypeCaptionLabel.TabIndex = 0;
        ContestTypeCaptionLabel.Text = "種類";
        ContestTypeCaptionLabel.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // GenerationCaptionLabel
        // 
        GenerationCaptionLabel.AutoSize = true;
        GenerationCaptionLabel.Location = new Point(399, 15);
        GenerationCaptionLabel.Margin = new Padding(4, 0, 4, 0);
        GenerationCaptionLabel.Name = "GenerationCaptionLabel";
        GenerationCaptionLabel.Size = new Size(34, 17);
        GenerationCaptionLabel.TabIndex = 14;
        GenerationCaptionLabel.Text = "世代";
        GenerationCaptionLabel.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // GenerationTextBox
        // 
        GenerationTextBox.Location = new Point(440, 12);
        GenerationTextBox.Name = "GenerationTextBox";
        GenerationTextBox.ReadOnly = true;
        GenerationTextBox.Size = new Size(191, 24);
        GenerationTextBox.TabIndex = 15;
        // 
        // GenerationDetailButton
        // 
        GenerationDetailButton.Location = new Point(637, 11);
        GenerationDetailButton.Name = "GenerationDetailButton";
        GenerationDetailButton.Size = new Size(53, 24);
        GenerationDetailButton.TabIndex = 16;
        GenerationDetailButton.Text = "詳細";
        GenerationDetailButton.UseVisualStyleBackColor = true;
        GenerationDetailButton.Click += GenerationDetailButton_Click;
        // 
        // MetaDetailButton
        // 
        MetaDetailButton.Location = new Point(167, 101);
        MetaDetailButton.Name = "MetaDetailButton";
        MetaDetailButton.Size = new Size(101, 24);
        MetaDetailButton.TabIndex = 9;
        MetaDetailButton.Text = "技の詳細情報";
        MetaDetailButton.UseVisualStyleBackColor = true;
        MetaDetailButton.Click += MetaDetailButton_Click;
        // 
        // TargetDetailButton
        // 
        TargetDetailButton.Location = new Point(637, 41);
        TargetDetailButton.Name = "TargetDetailButton";
        TargetDetailButton.Size = new Size(53, 24);
        TargetDetailButton.TabIndex = 19;
        TargetDetailButton.Text = "詳細";
        TargetDetailButton.UseVisualStyleBackColor = true;
        // 
        // TargetTextBox
        // 
        TargetTextBox.Location = new Point(440, 42);
        TargetTextBox.Name = "TargetTextBox";
        TargetTextBox.ReadOnly = true;
        TargetTextBox.Size = new Size(191, 24);
        TargetTextBox.TabIndex = 18;
        // 
        // TargetCaptionLabel
        // 
        TargetCaptionLabel.AutoSize = true;
        TargetCaptionLabel.Location = new Point(399, 45);
        TargetCaptionLabel.Margin = new Padding(4, 0, 4, 0);
        TargetCaptionLabel.Name = "TargetCaptionLabel";
        TargetCaptionLabel.Size = new Size(34, 17);
        TargetCaptionLabel.TabIndex = 17;
        TargetCaptionLabel.Text = "対象";
        TargetCaptionLabel.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // TypeDetailButton
        // 
        TypeDetailButton.Location = new Point(274, 68);
        TypeDetailButton.Name = "TypeDetailButton";
        TypeDetailButton.Size = new Size(53, 24);
        TypeDetailButton.TabIndex = 6;
        TypeDetailButton.Text = "詳細";
        TypeDetailButton.UseVisualStyleBackColor = true;
        TypeDetailButton.Click += TypeDetailButton_Click;
        // 
        // TypeTextBox
        // 
        TypeTextBox.Location = new Point(77, 72);
        TypeTextBox.Name = "TypeTextBox";
        TypeTextBox.ReadOnly = true;
        TypeTextBox.Size = new Size(191, 24);
        TypeTextBox.TabIndex = 5;
        // 
        // TypeCaptionLabel
        // 
        TypeCaptionLabel.AutoSize = true;
        TypeCaptionLabel.Location = new Point(25, 75);
        TypeCaptionLabel.Margin = new Padding(4, 0, 4, 0);
        TypeCaptionLabel.Name = "TypeCaptionLabel";
        TypeCaptionLabel.Size = new Size(40, 17);
        TypeCaptionLabel.TabIndex = 4;
        TypeCaptionLabel.Text = "タイプ";
        TypeCaptionLabel.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // NamesDataGridView
        // 
        NamesDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        NamesDataGridView.Columns.AddRange(new DataGridViewColumn[] { NameColumn, LanguageColumn, DetailColumn });
        NamesDataGridView.Location = new Point(442, 191);
        NamesDataGridView.Margin = new Padding(4, 3, 4, 3);
        NamesDataGridView.Name = "NamesDataGridView";
        NamesDataGridView.RowHeadersVisible = false;
        NamesDataGridView.Size = new Size(379, 192);
        NamesDataGridView.TabIndex = 29;
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
        // NamesCaptionLabel
        // 
        NamesCaptionLabel.AutoSize = true;
        NamesCaptionLabel.Location = new Point(440, 171);
        NamesCaptionLabel.Margin = new Padding(4, 0, 4, 0);
        NamesCaptionLabel.Name = "NamesCaptionLabel";
        NamesCaptionLabel.Size = new Size(92, 17);
        NamesCaptionLabel.TabIndex = 28;
        NamesCaptionLabel.Text = "言語ごとの名前";
        NamesCaptionLabel.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // LearnedByPokemonDataGridView
        // 
        LearnedByPokemonDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        LearnedByPokemonDataGridView.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn7, dataGridViewButtonColumn6 });
        LearnedByPokemonDataGridView.Location = new Point(831, 32);
        LearnedByPokemonDataGridView.Margin = new Padding(4, 3, 4, 3);
        LearnedByPokemonDataGridView.Name = "LearnedByPokemonDataGridView";
        LearnedByPokemonDataGridView.RowHeadersVisible = false;
        LearnedByPokemonDataGridView.Size = new Size(408, 351);
        LearnedByPokemonDataGridView.TabIndex = 31;
        // 
        // dataGridViewTextBoxColumn7
        // 
        dataGridViewTextBoxColumn7.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
        dataGridViewTextBoxColumn7.DataPropertyName = "Name";
        dataGridViewTextBoxColumn7.HeaderText = "ポケモン";
        dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
        dataGridViewTextBoxColumn7.ReadOnly = true;
        dataGridViewTextBoxColumn7.Width = 74;
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
        // LearnedByPokemonCaptionLabel
        // 
        LearnedByPokemonCaptionLabel.AutoSize = true;
        LearnedByPokemonCaptionLabel.Location = new Point(831, 12);
        LearnedByPokemonCaptionLabel.Margin = new Padding(4, 0, 4, 0);
        LearnedByPokemonCaptionLabel.Name = "LearnedByPokemonCaptionLabel";
        LearnedByPokemonCaptionLabel.Size = new Size(75, 17);
        LearnedByPokemonCaptionLabel.TabIndex = 30;
        LearnedByPokemonCaptionLabel.Text = "習得ポケモン";
        LearnedByPokemonCaptionLabel.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // tabControl1
        // 
        tabControl1.Controls.Add(FlavorTextTabPage);
        tabControl1.Controls.Add(EffectTabPage);
        tabControl1.Controls.Add(EffectChangesTabPage);
        tabControl1.Controls.Add(MachineTabPage);
        tabControl1.Controls.Add(StatChangeTabPage);
        tabControl1.Controls.Add(PastStatChangeTabPage);
        tabControl1.Location = new Point(13, 389);
        tabControl1.Name = "tabControl1";
        tabControl1.SelectedIndex = 0;
        tabControl1.Size = new Size(1226, 538);
        tabControl1.TabIndex = 32;
        // 
        // FlavorTextTabPage
        // 
        FlavorTextTabPage.Controls.Add(FlavorTextEntriesDataGridView);
        FlavorTextTabPage.Location = new Point(4, 26);
        FlavorTextTabPage.Name = "FlavorTextTabPage";
        FlavorTextTabPage.Padding = new Padding(3);
        FlavorTextTabPage.Size = new Size(1218, 508);
        FlavorTextTabPage.TabIndex = 3;
        FlavorTextTabPage.Text = "フレーバーテキスト";
        FlavorTextTabPage.UseVisualStyleBackColor = true;
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
        FlavorTextEntriesDataGridView.Size = new Size(1212, 502);
        FlavorTextEntriesDataGridView.TabIndex = 1;
        FlavorTextEntriesDataGridView.CellClick += FlavorTextEntriesDataGridView_CellClick;
        FlavorTextEntriesDataGridView.CellDoubleClick += FlavorTextEntriesDataGridView_CellDoubleClick;
        // 
        // EffectTabPage
        // 
        EffectTabPage.Controls.Add(EffectEntriesDataGridView);
        EffectTabPage.Location = new Point(4, 24);
        EffectTabPage.Name = "EffectTabPage";
        EffectTabPage.Padding = new Padding(3);
        EffectTabPage.Size = new Size(1218, 510);
        EffectTabPage.TabIndex = 0;
        EffectTabPage.Text = "効果";
        EffectTabPage.UseVisualStyleBackColor = true;
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
        EffectEntriesDataGridView.Size = new Size(1212, 504);
        EffectEntriesDataGridView.TabIndex = 1;
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
        // EffectChangesTabPage
        // 
        EffectChangesTabPage.Controls.Add(EffectChangesDataGridView);
        EffectChangesTabPage.Location = new Point(4, 24);
        EffectChangesTabPage.Name = "EffectChangesTabPage";
        EffectChangesTabPage.Padding = new Padding(3);
        EffectChangesTabPage.Size = new Size(1218, 510);
        EffectChangesTabPage.TabIndex = 1;
        EffectChangesTabPage.Text = "効果変更";
        EffectChangesTabPage.UseVisualStyleBackColor = true;
        // 
        // EffectChangesDataGridView
        // 
        EffectChangesDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        EffectChangesDataGridView.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1, dataGridViewButtonColumn1 });
        EffectChangesDataGridView.Dock = DockStyle.Fill;
        EffectChangesDataGridView.Location = new Point(3, 3);
        EffectChangesDataGridView.Margin = new Padding(4, 3, 4, 3);
        EffectChangesDataGridView.Name = "EffectChangesDataGridView";
        EffectChangesDataGridView.RowHeadersVisible = false;
        EffectChangesDataGridView.Size = new Size(1212, 504);
        EffectChangesDataGridView.TabIndex = 2;
        EffectChangesDataGridView.CellClick += EffectChangesDataGridView_CellClick;
        EffectChangesDataGridView.CellDoubleClick += EffectChangesDataGridView_CellDoubleClick;
        // 
        // dataGridViewTextBoxColumn1
        // 
        dataGridViewTextBoxColumn1.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
        dataGridViewTextBoxColumn1.DataPropertyName = "VersionGroup";
        dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
        dataGridViewTextBoxColumn1.DefaultCellStyle = dataGridViewCellStyle2;
        dataGridViewTextBoxColumn1.HeaderText = "バージョングループ";
        dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
        dataGridViewTextBoxColumn1.ReadOnly = true;
        dataGridViewTextBoxColumn1.Width = 88;
        // 
        // dataGridViewButtonColumn1
        // 
        dataGridViewButtonColumn1.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
        dataGridViewButtonColumn1.HeaderText = "詳細";
        dataGridViewButtonColumn1.Name = "dataGridViewButtonColumn1";
        dataGridViewButtonColumn1.Text = "詳細";
        dataGridViewButtonColumn1.UseColumnTextForButtonValue = true;
        dataGridViewButtonColumn1.Width = 36;
        // 
        // MachineTabPage
        // 
        MachineTabPage.Controls.Add(MachinesDataGridView);
        MachineTabPage.Location = new Point(4, 24);
        MachineTabPage.Name = "MachineTabPage";
        MachineTabPage.Size = new Size(1218, 510);
        MachineTabPage.TabIndex = 4;
        MachineTabPage.Text = "技マシン";
        MachineTabPage.UseVisualStyleBackColor = true;
        // 
        // MachinesDataGridView
        // 
        MachinesDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        MachinesDataGridView.Columns.AddRange(new DataGridViewColumn[] { MachineVersionGroupColumn, MachineDetailColumn });
        MachinesDataGridView.Dock = DockStyle.Fill;
        MachinesDataGridView.Location = new Point(0, 0);
        MachinesDataGridView.Margin = new Padding(4, 3, 4, 3);
        MachinesDataGridView.Name = "MachinesDataGridView";
        MachinesDataGridView.RowHeadersVisible = false;
        MachinesDataGridView.Size = new Size(1218, 510);
        MachinesDataGridView.TabIndex = 20;
        MachinesDataGridView.CellClick += MachinesDataGridView_CellClick;
        MachinesDataGridView.CellDoubleClick += MachinesDataGridView_CellDoubleClick;
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
        // StatChangeTabPage
        // 
        StatChangeTabPage.Controls.Add(StatChangeDataGridView);
        StatChangeTabPage.Location = new Point(4, 26);
        StatChangeTabPage.Name = "StatChangeTabPage";
        StatChangeTabPage.Size = new Size(1218, 508);
        StatChangeTabPage.TabIndex = 5;
        StatChangeTabPage.Text = "ステータス変更";
        StatChangeTabPage.UseVisualStyleBackColor = true;
        // 
        // StatChangeDataGridView
        // 
        StatChangeDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        StatChangeDataGridView.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn3, dataGridViewTextBoxColumn4, dataGridViewButtonColumn3 });
        StatChangeDataGridView.Dock = DockStyle.Fill;
        StatChangeDataGridView.Location = new Point(0, 0);
        StatChangeDataGridView.Margin = new Padding(4, 3, 4, 3);
        StatChangeDataGridView.Name = "StatChangeDataGridView";
        StatChangeDataGridView.RowHeadersVisible = false;
        StatChangeDataGridView.Size = new Size(1218, 508);
        StatChangeDataGridView.TabIndex = 2;
        StatChangeDataGridView.CellClick += StatChangeDataGridView_CellClick;
        StatChangeDataGridView.CellDoubleClick += StatChangeDataGridView_CellDoubleClick;
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
        // dataGridViewTextBoxColumn4
        // 
        dataGridViewTextBoxColumn4.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
        dataGridViewTextBoxColumn4.DataPropertyName = "Change";
        dataGridViewTextBoxColumn4.HeaderText = "変更量";
        dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
        dataGridViewTextBoxColumn4.ReadOnly = true;
        dataGridViewTextBoxColumn4.Width = 72;
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
        // PastStatChangeTabPage
        // 
        PastStatChangeTabPage.Controls.Add(PastValuesDataGridView);
        PastStatChangeTabPage.Location = new Point(4, 24);
        PastStatChangeTabPage.Name = "PastStatChangeTabPage";
        PastStatChangeTabPage.Size = new Size(1218, 510);
        PastStatChangeTabPage.TabIndex = 6;
        PastStatChangeTabPage.Text = "過去のステータス変更";
        PastStatChangeTabPage.UseVisualStyleBackColor = true;
        // 
        // PastValuesDataGridView
        // 
        PastValuesDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        PastValuesDataGridView.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn6, dataGridViewButtonColumn4 });
        PastValuesDataGridView.Dock = DockStyle.Fill;
        PastValuesDataGridView.Location = new Point(0, 0);
        PastValuesDataGridView.Margin = new Padding(4, 3, 4, 3);
        PastValuesDataGridView.Name = "PastValuesDataGridView";
        PastValuesDataGridView.RowHeadersVisible = false;
        PastValuesDataGridView.Size = new Size(1218, 510);
        PastValuesDataGridView.TabIndex = 3;
        PastValuesDataGridView.CellClick += PastValuesDataGridView_CellClick;
        PastValuesDataGridView.CellDoubleClick += PastValuesDataGridView_CellDoubleClick;
        // 
        // dataGridViewTextBoxColumn6
        // 
        dataGridViewTextBoxColumn6.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
        dataGridViewTextBoxColumn6.DataPropertyName = "Text";
        dataGridViewTextBoxColumn6.HeaderText = "内容";
        dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
        dataGridViewTextBoxColumn6.ReadOnly = true;
        dataGridViewTextBoxColumn6.Width = 59;
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
        // CloseButton
        // 
        CloseButton.Location = new Point(1153, 933);
        CloseButton.Margin = new Padding(4, 3, 4, 3);
        CloseButton.Name = "CloseButton";
        CloseButton.Size = new Size(82, 40);
        CloseButton.TabIndex = 33;
        CloseButton.Text = "閉じる";
        CloseButton.UseVisualStyleBackColor = true;
        CloseButton.Click += CloseButton_Click;
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
        FlavorTextColumn.DataPropertyName = "FlavorText";
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
        // MoveInfoForm
        // 
        AutoScaleDimensions = new SizeF(9F, 17F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(1264, 985);
        Controls.Add(CloseButton);
        Controls.Add(tabControl1);
        Controls.Add(LearnedByPokemonDataGridView);
        Controls.Add(LearnedByPokemonCaptionLabel);
        Controls.Add(NamesDataGridView);
        Controls.Add(NamesCaptionLabel);
        Controls.Add(TypeDetailButton);
        Controls.Add(TypeTextBox);
        Controls.Add(TypeCaptionLabel);
        Controls.Add(TargetDetailButton);
        Controls.Add(TargetTextBox);
        Controls.Add(TargetCaptionLabel);
        Controls.Add(MetaDetailButton);
        Controls.Add(GenerationDetailButton);
        Controls.Add(GenerationTextBox);
        Controls.Add(GenerationCaptionLabel);
        Controls.Add(ContestGroupBox);
        Controls.Add(DamageClassDetailButton);
        Controls.Add(DamageClassCaptionLabel);
        Controls.Add(DamageClassTextBox);
        Controls.Add(PriorityCaptionLabel);
        Controls.Add(PriorityTextBox);
        Controls.Add(PowerCaptionLabel);
        Controls.Add(PowerTextBox);
        Controls.Add(EffectChanceCaptionLabel);
        Controls.Add(EffectChanceTextBox);
        Controls.Add(AccuracyTextBox);
        Controls.Add(AccuracyCaptionLabel);
        Controls.Add(PPCaptionLabel);
        Controls.Add(PPTextBox);
        Controls.Add(NameTextBox);
        Controls.Add(IdTextBox);
        Controls.Add(NameCaptionLabel);
        Controls.Add(IdCaptionLabel);
        Font = new Font("Meiryo UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 128);
        Margin = new Padding(4, 3, 4, 3);
        Name = "MoveInfoForm";
        StartPosition = FormStartPosition.CenterParent;
        Text = "技";
        ContestGroupBox.ResumeLayout(false);
        ContestGroupBox.PerformLayout();
        ContestEffectGroupBox.ResumeLayout(false);
        ContestEffectGroupBox.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)NamesDataGridView).EndInit();
        ((System.ComponentModel.ISupportInitialize)LearnedByPokemonDataGridView).EndInit();
        tabControl1.ResumeLayout(false);
        FlavorTextTabPage.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)FlavorTextEntriesDataGridView).EndInit();
        EffectTabPage.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)EffectEntriesDataGridView).EndInit();
        EffectChangesTabPage.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)EffectChangesDataGridView).EndInit();
        MachineTabPage.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)MachinesDataGridView).EndInit();
        StatChangeTabPage.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)StatChangeDataGridView).EndInit();
        PastStatChangeTabPage.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)PastValuesDataGridView).EndInit();
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private TextBox NameTextBox;
    private TextBox IdTextBox;
    private Label NameCaptionLabel;
    private Label IdCaptionLabel;
    private TextBox PPTextBox;
    private Label PPCaptionLabel;
    private Label AccuracyCaptionLabel;
    private TextBox AccuracyTextBox;
    private TextBox EffectChanceTextBox;
    private Label EffectChanceCaptionLabel;
    private TextBox PowerTextBox;
    private Label PowerCaptionLabel;
    private TextBox PriorityTextBox;
    private Label PriorityCaptionLabel;
    private TextBox DamageClassTextBox;
    private Label DamageClassCaptionLabel;
    private Button DamageClassDetailButton;
    private GroupBox ContestGroupBox;
    private Label ContestEffectCaptionLabel;
    private Button ContestTypeDetailButton;
    private TextBox ContestTypeTextBox;
    private Label ContestTypeCaptionLabel;
    private Button ContestEffectDetailButton;
    private TextBox ContestEffectTextBox;
    private Button ContestCombosDetailButton;
    private Label ContestCombosCaptionLabel;
    private Label GenerationCaptionLabel;
    private TextBox GenerationTextBox;
    private Button GenerationDetailButton;
    private Button MetaDetailButton;
    private GroupBox ContestEffectGroupBox;
    private Button SuperContestEffectDetailButton;
    private Label SuperContestEffectCaptionLabel;
    private TextBox SuperContestEffectTextBox;
    private Button TargetDetailButton;
    private TextBox TargetTextBox;
    private Label TargetCaptionLabel;
    private Button TypeDetailButton;
    private TextBox TypeTextBox;
    private Label TypeCaptionLabel;
    private DataGridView NamesDataGridView;
    private DataGridViewTextBoxColumn NameColumn;
    private DataGridViewTextBoxColumn LanguageColumn;
    private DataGridViewButtonColumn DetailColumn;
    private Label NamesCaptionLabel;
    private DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
    private DataGridViewButtonColumn dataGridViewButtonColumn6;
    private Label LearnedByPokemonCaptionLabel;
    private TabControl tabControl1;
    private TabPage EffectTabPage;
    private TabPage EffectChangesTabPage;
    private Button CloseButton;
    private DataGridView EffectEntriesDataGridView;
    private DataGridViewTextBoxColumn EffectColumn;
    private DataGridViewButtonColumn EffectDetailColumn;
    private DataGridView EffectChangesDataGridView;
    private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
    private DataGridViewButtonColumn dataGridViewButtonColumn1;
    private TabPage FlavorTextTabPage;
    private DataGridView LearnedByPokemonDataGridView;
    private DataGridView FlavorTextEntriesDataGridView;
    private TabPage MachineTabPage;
    private DataGridView MachinesDataGridView;
    private DataGridViewTextBoxColumn MachineVersionGroupColumn;
    private DataGridViewButtonColumn MachineDetailColumn;
    private TabPage StatChangeTabPage;
    private DataGridView StatChangeDataGridView;
    private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
    private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
    private DataGridViewButtonColumn dataGridViewButtonColumn3;
    private TabPage PastStatChangeTabPage;
    private DataGridView PastValuesDataGridView;
    private DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
    private DataGridViewButtonColumn dataGridViewButtonColumn4;
    private DataGridViewTextBoxColumn FlavorTextVersionGroupColumn;
    private DataGridViewTextBoxColumn FlavorTextLanguageColumn;
    private DataGridViewTextBoxColumn FlavorTextColumn;
    private DataGridViewButtonColumn FlavorTextDetailColumn;
}