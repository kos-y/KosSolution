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
        ContestTypeCaptionLabel = new Label();
        ContestTypeTextBox = new TextBox();
        ContestTypeDetailButton = new Button();
        ContestEffectCaptionLabel = new Label();
        ContestEffectTextBox = new TextBox();
        ContestEffectDetailButton = new Button();
        ContestCombosCaptionLabel = new Label();
        ContestCombosDetailButton = new Button();
        GenerationCaptionLabel = new Label();
        GenerationTextBox = new TextBox();
        GenerationDetailButton = new Button();
        MoveMetaDataDetailButton = new Button();
        ContestEffectGroupBox = new GroupBox();
        SuperContestEffectTextBox = new TextBox();
        SuperContestEffectCaptionLabel = new Label();
        SuperContestEffectDetailButton = new Button();
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
        HeldByPokemonDataGridView = new DataGridView();
        HeldByPokemonCaptionLabel = new Label();
        dataGridViewTextBoxColumn7 = new DataGridViewTextBoxColumn();
        dataGridViewButtonColumn6 = new DataGridViewButtonColumn();
        ContestGroupBox.SuspendLayout();
        ContestEffectGroupBox.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)NamesDataGridView).BeginInit();
        ((System.ComponentModel.ISupportInitialize)HeldByPokemonDataGridView).BeginInit();
        SuspendLayout();
        // 
        // NameTextBox
        // 
        NameTextBox.Location = new Point(77, 42);
        NameTextBox.Name = "NameTextBox";
        NameTextBox.ReadOnly = true;
        NameTextBox.Size = new Size(191, 24);
        NameTextBox.TabIndex = 7;
        // 
        // IdTextBox
        // 
        IdTextBox.Location = new Point(77, 12);
        IdTextBox.Name = "IdTextBox";
        IdTextBox.ReadOnly = true;
        IdTextBox.Size = new Size(191, 24);
        IdTextBox.TabIndex = 5;
        // 
        // NameCaptionLabel
        // 
        NameCaptionLabel.AutoSize = true;
        NameCaptionLabel.Location = new Point(31, 45);
        NameCaptionLabel.Margin = new Padding(4, 0, 4, 0);
        NameCaptionLabel.Name = "NameCaptionLabel";
        NameCaptionLabel.Size = new Size(34, 17);
        NameCaptionLabel.TabIndex = 6;
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
        IdCaptionLabel.TabIndex = 4;
        IdCaptionLabel.Text = "技ID";
        IdCaptionLabel.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // PPTextBox
        // 
        PPTextBox.Location = new Point(77, 102);
        PPTextBox.Name = "PPTextBox";
        PPTextBox.ReadOnly = true;
        PPTextBox.Size = new Size(56, 24);
        PPTextBox.TabIndex = 13;
        PPTextBox.Text = "99";
        // 
        // PPCaptionLabel
        // 
        PPCaptionLabel.AutoSize = true;
        PPCaptionLabel.Location = new Point(13, 105);
        PPCaptionLabel.Margin = new Padding(4, 0, 4, 0);
        PPCaptionLabel.Name = "PPCaptionLabel";
        PPCaptionLabel.Size = new Size(52, 17);
        PPCaptionLabel.TabIndex = 14;
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
        AccuracyCaptionLabel.TabIndex = 15;
        AccuracyCaptionLabel.Text = "命中率";
        AccuracyCaptionLabel.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // AccuracyTextBox
        // 
        AccuracyTextBox.Location = new Point(77, 132);
        AccuracyTextBox.Name = "AccuracyTextBox";
        AccuracyTextBox.ReadOnly = true;
        AccuracyTextBox.Size = new Size(56, 24);
        AccuracyTextBox.TabIndex = 16;
        AccuracyTextBox.Text = "99";
        // 
        // EffectChanceTextBox
        // 
        EffectChanceTextBox.Location = new Point(440, 72);
        EffectChanceTextBox.Name = "EffectChanceTextBox";
        EffectChanceTextBox.ReadOnly = true;
        EffectChanceTextBox.Size = new Size(56, 24);
        EffectChanceTextBox.TabIndex = 17;
        EffectChanceTextBox.Text = "99";
        // 
        // EffectChanceCaptionLabel
        // 
        EffectChanceCaptionLabel.AutoSize = true;
        EffectChanceCaptionLabel.Location = new Point(334, 75);
        EffectChanceCaptionLabel.Margin = new Padding(4, 0, 4, 0);
        EffectChanceCaptionLabel.Name = "EffectChanceCaptionLabel";
        EffectChanceCaptionLabel.Size = new Size(99, 17);
        EffectChanceCaptionLabel.TabIndex = 18;
        EffectChanceCaptionLabel.Text = "追加効果発動率";
        EffectChanceCaptionLabel.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // PowerTextBox
        // 
        PowerTextBox.Location = new Point(181, 132);
        PowerTextBox.Name = "PowerTextBox";
        PowerTextBox.ReadOnly = true;
        PowerTextBox.Size = new Size(56, 24);
        PowerTextBox.TabIndex = 19;
        PowerTextBox.Text = "99";
        // 
        // PowerCaptionLabel
        // 
        PowerCaptionLabel.AutoSize = true;
        PowerCaptionLabel.Location = new Point(140, 135);
        PowerCaptionLabel.Margin = new Padding(4, 0, 4, 0);
        PowerCaptionLabel.Name = "PowerCaptionLabel";
        PowerCaptionLabel.Size = new Size(34, 17);
        PowerCaptionLabel.TabIndex = 20;
        PowerCaptionLabel.Text = "威力";
        PowerCaptionLabel.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // PriorityTextBox
        // 
        PriorityTextBox.Location = new Point(594, 72);
        PriorityTextBox.Name = "PriorityTextBox";
        PriorityTextBox.ReadOnly = true;
        PriorityTextBox.Size = new Size(56, 24);
        PriorityTextBox.TabIndex = 21;
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
        DamageClassTextBox.TabIndex = 23;
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
        DamageClassDetailButton.TabIndex = 25;
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
        ContestGroupBox.TabIndex = 26;
        ContestGroupBox.TabStop = false;
        ContestGroupBox.Text = "コンテスト";
        // 
        // ContestTypeCaptionLabel
        // 
        ContestTypeCaptionLabel.AutoSize = true;
        ContestTypeCaptionLabel.Location = new Point(38, 26);
        ContestTypeCaptionLabel.Margin = new Padding(4, 0, 4, 0);
        ContestTypeCaptionLabel.Name = "ContestTypeCaptionLabel";
        ContestTypeCaptionLabel.Size = new Size(34, 17);
        ContestTypeCaptionLabel.TabIndex = 27;
        ContestTypeCaptionLabel.Text = "種類";
        ContestTypeCaptionLabel.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // ContestTypeTextBox
        // 
        ContestTypeTextBox.Location = new Point(79, 23);
        ContestTypeTextBox.Name = "ContestTypeTextBox";
        ContestTypeTextBox.ReadOnly = true;
        ContestTypeTextBox.Size = new Size(191, 24);
        ContestTypeTextBox.TabIndex = 27;
        // 
        // ContestTypeDetailButton
        // 
        ContestTypeDetailButton.Location = new Point(276, 23);
        ContestTypeDetailButton.Name = "ContestTypeDetailButton";
        ContestTypeDetailButton.Size = new Size(53, 24);
        ContestTypeDetailButton.TabIndex = 27;
        ContestTypeDetailButton.Text = "詳細";
        ContestTypeDetailButton.UseVisualStyleBackColor = true;
        // 
        // ContestEffectCaptionLabel
        // 
        ContestEffectCaptionLabel.AutoSize = true;
        ContestEffectCaptionLabel.Location = new Point(16, 26);
        ContestEffectCaptionLabel.Margin = new Padding(4, 0, 4, 0);
        ContestEffectCaptionLabel.Name = "ContestEffectCaptionLabel";
        ContestEffectCaptionLabel.Size = new Size(100, 17);
        ContestEffectCaptionLabel.TabIndex = 28;
        ContestEffectCaptionLabel.Text = "ポケモンコンテスト";
        ContestEffectCaptionLabel.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // ContestEffectTextBox
        // 
        ContestEffectTextBox.Location = new Point(129, 23);
        ContestEffectTextBox.Name = "ContestEffectTextBox";
        ContestEffectTextBox.ReadOnly = true;
        ContestEffectTextBox.Size = new Size(191, 24);
        ContestEffectTextBox.TabIndex = 29;
        // 
        // ContestEffectDetailButton
        // 
        ContestEffectDetailButton.Location = new Point(326, 23);
        ContestEffectDetailButton.Name = "ContestEffectDetailButton";
        ContestEffectDetailButton.Size = new Size(53, 24);
        ContestEffectDetailButton.TabIndex = 30;
        ContestEffectDetailButton.Text = "詳細";
        ContestEffectDetailButton.UseVisualStyleBackColor = true;
        // 
        // ContestCombosCaptionLabel
        // 
        ContestCombosCaptionLabel.AutoSize = true;
        ContestCombosCaptionLabel.Location = new Point(33, 56);
        ContestCombosCaptionLabel.Margin = new Padding(4, 0, 4, 0);
        ContestCombosCaptionLabel.Name = "ContestCombosCaptionLabel";
        ContestCombosCaptionLabel.Size = new Size(39, 17);
        ContestCombosCaptionLabel.TabIndex = 32;
        ContestCombosCaptionLabel.Text = "コンボ";
        ContestCombosCaptionLabel.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // ContestCombosDetailButton
        // 
        ContestCombosDetailButton.Location = new Point(79, 52);
        ContestCombosDetailButton.Name = "ContestCombosDetailButton";
        ContestCombosDetailButton.Size = new Size(53, 24);
        ContestCombosDetailButton.TabIndex = 33;
        ContestCombosDetailButton.Text = "詳細";
        ContestCombosDetailButton.UseVisualStyleBackColor = true;
        // 
        // GenerationCaptionLabel
        // 
        GenerationCaptionLabel.AutoSize = true;
        GenerationCaptionLabel.Location = new Point(399, 15);
        GenerationCaptionLabel.Margin = new Padding(4, 0, 4, 0);
        GenerationCaptionLabel.Name = "GenerationCaptionLabel";
        GenerationCaptionLabel.Size = new Size(34, 17);
        GenerationCaptionLabel.TabIndex = 27;
        GenerationCaptionLabel.Text = "世代";
        GenerationCaptionLabel.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // GenerationTextBox
        // 
        GenerationTextBox.Location = new Point(440, 12);
        GenerationTextBox.Name = "GenerationTextBox";
        GenerationTextBox.ReadOnly = true;
        GenerationTextBox.Size = new Size(191, 24);
        GenerationTextBox.TabIndex = 28;
        // 
        // GenerationDetailButton
        // 
        GenerationDetailButton.Location = new Point(637, 11);
        GenerationDetailButton.Name = "GenerationDetailButton";
        GenerationDetailButton.Size = new Size(53, 24);
        GenerationDetailButton.TabIndex = 29;
        GenerationDetailButton.Text = "詳細";
        GenerationDetailButton.UseVisualStyleBackColor = true;
        // 
        // MoveMetaDataDetailButton
        // 
        MoveMetaDataDetailButton.Location = new Point(167, 101);
        MoveMetaDataDetailButton.Name = "MoveMetaDataDetailButton";
        MoveMetaDataDetailButton.Size = new Size(101, 24);
        MoveMetaDataDetailButton.TabIndex = 30;
        MoveMetaDataDetailButton.Text = "技の詳細情報";
        MoveMetaDataDetailButton.UseVisualStyleBackColor = true;
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
        ContestEffectGroupBox.TabIndex = 34;
        ContestEffectGroupBox.TabStop = false;
        ContestEffectGroupBox.Text = "効果";
        // 
        // SuperContestEffectTextBox
        // 
        SuperContestEffectTextBox.Location = new Point(129, 53);
        SuperContestEffectTextBox.Name = "SuperContestEffectTextBox";
        SuperContestEffectTextBox.ReadOnly = true;
        SuperContestEffectTextBox.Size = new Size(191, 24);
        SuperContestEffectTextBox.TabIndex = 31;
        // 
        // SuperContestEffectCaptionLabel
        // 
        SuperContestEffectCaptionLabel.AutoSize = true;
        SuperContestEffectCaptionLabel.Location = new Point(16, 56);
        SuperContestEffectCaptionLabel.Margin = new Padding(4, 0, 4, 0);
        SuperContestEffectCaptionLabel.Name = "SuperContestEffectCaptionLabel";
        SuperContestEffectCaptionLabel.Size = new Size(104, 17);
        SuperContestEffectCaptionLabel.TabIndex = 32;
        SuperContestEffectCaptionLabel.Text = "スーパーコンテスト";
        SuperContestEffectCaptionLabel.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // SuperContestEffectDetailButton
        // 
        SuperContestEffectDetailButton.Location = new Point(326, 56);
        SuperContestEffectDetailButton.Name = "SuperContestEffectDetailButton";
        SuperContestEffectDetailButton.Size = new Size(53, 24);
        SuperContestEffectDetailButton.TabIndex = 33;
        SuperContestEffectDetailButton.Text = "詳細";
        SuperContestEffectDetailButton.UseVisualStyleBackColor = true;
        // 
        // TargetDetailButton
        // 
        TargetDetailButton.Location = new Point(637, 41);
        TargetDetailButton.Name = "TargetDetailButton";
        TargetDetailButton.Size = new Size(53, 24);
        TargetDetailButton.TabIndex = 34;
        TargetDetailButton.Text = "詳細";
        TargetDetailButton.UseVisualStyleBackColor = true;
        // 
        // TargetTextBox
        // 
        TargetTextBox.Location = new Point(440, 42);
        TargetTextBox.Name = "TargetTextBox";
        TargetTextBox.ReadOnly = true;
        TargetTextBox.Size = new Size(191, 24);
        TargetTextBox.TabIndex = 33;
        // 
        // TargetCaptionLabel
        // 
        TargetCaptionLabel.AutoSize = true;
        TargetCaptionLabel.Location = new Point(399, 45);
        TargetCaptionLabel.Margin = new Padding(4, 0, 4, 0);
        TargetCaptionLabel.Name = "TargetCaptionLabel";
        TargetCaptionLabel.Size = new Size(34, 17);
        TargetCaptionLabel.TabIndex = 32;
        TargetCaptionLabel.Text = "対象";
        TargetCaptionLabel.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // TypeDetailButton
        // 
        TypeDetailButton.Location = new Point(274, 68);
        TypeDetailButton.Name = "TypeDetailButton";
        TypeDetailButton.Size = new Size(53, 24);
        TypeDetailButton.TabIndex = 37;
        TypeDetailButton.Text = "詳細";
        TypeDetailButton.UseVisualStyleBackColor = true;
        // 
        // TypeTextBox
        // 
        TypeTextBox.Location = new Point(77, 72);
        TypeTextBox.Name = "TypeTextBox";
        TypeTextBox.ReadOnly = true;
        TypeTextBox.Size = new Size(191, 24);
        TypeTextBox.TabIndex = 36;
        // 
        // TypeCaptionLabel
        // 
        TypeCaptionLabel.AutoSize = true;
        TypeCaptionLabel.Location = new Point(25, 75);
        TypeCaptionLabel.Margin = new Padding(4, 0, 4, 0);
        TypeCaptionLabel.Name = "TypeCaptionLabel";
        TypeCaptionLabel.Size = new Size(40, 17);
        TypeCaptionLabel.TabIndex = 35;
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
        NamesDataGridView.TabIndex = 39;
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
        NamesCaptionLabel.TabIndex = 38;
        NamesCaptionLabel.Text = "言語ごとの名前";
        NamesCaptionLabel.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // HeldByPokemonDataGridView
        // 
        HeldByPokemonDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        HeldByPokemonDataGridView.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn7, dataGridViewButtonColumn6 });
        HeldByPokemonDataGridView.Location = new Point(831, 32);
        HeldByPokemonDataGridView.Margin = new Padding(4, 3, 4, 3);
        HeldByPokemonDataGridView.Name = "HeldByPokemonDataGridView";
        HeldByPokemonDataGridView.RowHeadersVisible = false;
        HeldByPokemonDataGridView.Size = new Size(408, 351);
        HeldByPokemonDataGridView.TabIndex = 41;
        // 
        // HeldByPokemonCaptionLabel
        // 
        HeldByPokemonCaptionLabel.AutoSize = true;
        HeldByPokemonCaptionLabel.Location = new Point(831, 12);
        HeldByPokemonCaptionLabel.Margin = new Padding(4, 0, 4, 0);
        HeldByPokemonCaptionLabel.Name = "HeldByPokemonCaptionLabel";
        HeldByPokemonCaptionLabel.Size = new Size(75, 17);
        HeldByPokemonCaptionLabel.TabIndex = 40;
        HeldByPokemonCaptionLabel.Text = "習得ポケモン";
        HeldByPokemonCaptionLabel.TextAlign = ContentAlignment.MiddleLeft;
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
        // MoveInfoForm
        // 
        AutoScaleDimensions = new SizeF(9F, 17F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(1264, 985);
        Controls.Add(HeldByPokemonDataGridView);
        Controls.Add(HeldByPokemonCaptionLabel);
        Controls.Add(NamesDataGridView);
        Controls.Add(NamesCaptionLabel);
        Controls.Add(TypeDetailButton);
        Controls.Add(TypeTextBox);
        Controls.Add(TypeCaptionLabel);
        Controls.Add(TargetDetailButton);
        Controls.Add(TargetTextBox);
        Controls.Add(TargetCaptionLabel);
        Controls.Add(MoveMetaDataDetailButton);
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
        ((System.ComponentModel.ISupportInitialize)HeldByPokemonDataGridView).EndInit();
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
    private Button MoveMetaDataDetailButton;
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
    private DataGridView HeldByPokemonDataGridView;
    private DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
    private DataGridViewButtonColumn dataGridViewButtonColumn6;
    private Label HeldByPokemonCaptionLabel;
}