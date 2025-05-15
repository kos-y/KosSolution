namespace Kos.PokeAPI.Forms;

partial class NatureInfoForm
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
        StatGroupBox = new GroupBox();
        DecreasedStatButton = new Button();
        DecreasedStatTextBox = new TextBox();
        IncreasedStatTextBox = new TextBox();
        IncreasedStatButton = new Button();
        BerryGroupBox = new GroupBox();
        HatesFlavorButton = new Button();
        HatesFlavorTextBox = new TextBox();
        LikesFlavorTextBox = new TextBox();
        LikesFlavorButton = new Button();
        NamesCaptionLabel = new Label();
        NamesDataGridView = new DataGridView();
        NameColumn = new DataGridViewTextBoxColumn();
        LanguageColumn = new DataGridViewTextBoxColumn();
        DetailColumn = new DataGridViewButtonColumn();
        MoveBattleStylePreferenceCaptionLabel = new Label();
        MoveBattleStylePreferencesDataGridView = new DataGridView();
        dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
        dataGridViewButtonColumn1 = new DataGridViewButtonColumn();
        PokeathlonStatChangesDataGridView = new DataGridView();
        dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
        dataGridViewButtonColumn2 = new DataGridViewButtonColumn();
        PokeathlonStatChangesCaptionLabel = new Label();
        PropertyButton = new Button();
        CloseButton = new Button();
        StatGroupBox.SuspendLayout();
        BerryGroupBox.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)NamesDataGridView).BeginInit();
        ((System.ComponentModel.ISupportInitialize)MoveBattleStylePreferencesDataGridView).BeginInit();
        ((System.ComponentModel.ISupportInitialize)PokeathlonStatChangesDataGridView).BeginInit();
        SuspendLayout();
        // 
        // NameTextBox
        // 
        NameTextBox.Location = new Point(92, 42);
        NameTextBox.Name = "NameTextBox";
        NameTextBox.ReadOnly = true;
        NameTextBox.Size = new Size(191, 24);
        NameTextBox.TabIndex = 3;
        // 
        // IdTextBox
        // 
        IdTextBox.Location = new Point(92, 12);
        IdTextBox.Name = "IdTextBox";
        IdTextBox.ReadOnly = true;
        IdTextBox.Size = new Size(191, 24);
        IdTextBox.TabIndex = 1;
        // 
        // NameCaptionLabel
        // 
        NameCaptionLabel.AutoSize = true;
        NameCaptionLabel.Location = new Point(13, 45);
        NameCaptionLabel.Margin = new Padding(4, 0, 4, 0);
        NameCaptionLabel.Name = "NameCaptionLabel";
        NameCaptionLabel.Size = new Size(72, 17);
        NameCaptionLabel.TabIndex = 2;
        NameCaptionLabel.Text = "性格の名前";
        NameCaptionLabel.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // IdCaptionLabel
        // 
        IdCaptionLabel.AutoSize = true;
        IdCaptionLabel.Location = new Point(34, 15);
        IdCaptionLabel.Margin = new Padding(4, 0, 4, 0);
        IdCaptionLabel.Name = "IdCaptionLabel";
        IdCaptionLabel.Size = new Size(51, 17);
        IdCaptionLabel.TabIndex = 0;
        IdCaptionLabel.Text = "性格ID";
        IdCaptionLabel.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // StatGroupBox
        // 
        StatGroupBox.Controls.Add(DecreasedStatButton);
        StatGroupBox.Controls.Add(DecreasedStatTextBox);
        StatGroupBox.Controls.Add(IncreasedStatTextBox);
        StatGroupBox.Controls.Add(IncreasedStatButton);
        StatGroupBox.Location = new Point(13, 72);
        StatGroupBox.Name = "StatGroupBox";
        StatGroupBox.Size = new Size(270, 95);
        StatGroupBox.TabIndex = 4;
        StatGroupBox.TabStop = false;
        StatGroupBox.Text = "ステータス";
        // 
        // DecreasedStatButton
        // 
        DecreasedStatButton.Location = new Point(6, 53);
        DecreasedStatButton.Name = "DecreasedStatButton";
        DecreasedStatButton.Size = new Size(43, 24);
        DecreasedStatButton.TabIndex = 2;
        DecreasedStatButton.Text = "下降";
        DecreasedStatButton.UseVisualStyleBackColor = true;
        // 
        // DecreasedStatTextBox
        // 
        DecreasedStatTextBox.Location = new Point(55, 53);
        DecreasedStatTextBox.Name = "DecreasedStatTextBox";
        DecreasedStatTextBox.ReadOnly = true;
        DecreasedStatTextBox.Size = new Size(209, 24);
        DecreasedStatTextBox.TabIndex = 3;
        // 
        // IncreasedStatTextBox
        // 
        IncreasedStatTextBox.Location = new Point(55, 23);
        IncreasedStatTextBox.Name = "IncreasedStatTextBox";
        IncreasedStatTextBox.ReadOnly = true;
        IncreasedStatTextBox.Size = new Size(209, 24);
        IncreasedStatTextBox.TabIndex = 1;
        // 
        // IncreasedStatButton
        // 
        IncreasedStatButton.Location = new Point(6, 23);
        IncreasedStatButton.Name = "IncreasedStatButton";
        IncreasedStatButton.Size = new Size(43, 24);
        IncreasedStatButton.TabIndex = 0;
        IncreasedStatButton.Text = "上昇";
        IncreasedStatButton.UseVisualStyleBackColor = true;
        // 
        // BerryGroupBox
        // 
        BerryGroupBox.Controls.Add(HatesFlavorButton);
        BerryGroupBox.Controls.Add(HatesFlavorTextBox);
        BerryGroupBox.Controls.Add(LikesFlavorTextBox);
        BerryGroupBox.Controls.Add(LikesFlavorButton);
        BerryGroupBox.Location = new Point(13, 173);
        BerryGroupBox.Name = "BerryGroupBox";
        BerryGroupBox.Size = new Size(270, 95);
        BerryGroupBox.TabIndex = 5;
        BerryGroupBox.TabStop = false;
        BerryGroupBox.Text = "きのみ";
        // 
        // HatesFlavorButton
        // 
        HatesFlavorButton.Location = new Point(6, 53);
        HatesFlavorButton.Name = "HatesFlavorButton";
        HatesFlavorButton.Size = new Size(66, 24);
        HatesFlavorButton.TabIndex = 2;
        HatesFlavorButton.Text = "嫌いな味";
        HatesFlavorButton.UseVisualStyleBackColor = true;
        HatesFlavorButton.Click += HatesFlavorButton_Click;
        // 
        // HatesFlavorTextBox
        // 
        HatesFlavorTextBox.Location = new Point(79, 53);
        HatesFlavorTextBox.Name = "HatesFlavorTextBox";
        HatesFlavorTextBox.ReadOnly = true;
        HatesFlavorTextBox.Size = new Size(185, 24);
        HatesFlavorTextBox.TabIndex = 3;
        // 
        // LikesFlavorTextBox
        // 
        LikesFlavorTextBox.Location = new Point(79, 23);
        LikesFlavorTextBox.Name = "LikesFlavorTextBox";
        LikesFlavorTextBox.ReadOnly = true;
        LikesFlavorTextBox.Size = new Size(185, 24);
        LikesFlavorTextBox.TabIndex = 1;
        // 
        // LikesFlavorButton
        // 
        LikesFlavorButton.Location = new Point(6, 23);
        LikesFlavorButton.Name = "LikesFlavorButton";
        LikesFlavorButton.Size = new Size(66, 24);
        LikesFlavorButton.TabIndex = 0;
        LikesFlavorButton.Text = "好きな味";
        LikesFlavorButton.UseVisualStyleBackColor = true;
        LikesFlavorButton.Click += LikesFlavorButton_Click;
        // 
        // NamesCaptionLabel
        // 
        NamesCaptionLabel.AutoSize = true;
        NamesCaptionLabel.Location = new Point(290, 9);
        NamesCaptionLabel.Margin = new Padding(4, 0, 4, 0);
        NamesCaptionLabel.Name = "NamesCaptionLabel";
        NamesCaptionLabel.Size = new Size(92, 17);
        NamesCaptionLabel.TabIndex = 6;
        NamesCaptionLabel.Text = "言語ごとの名前";
        NamesCaptionLabel.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // NamesDataGridView
        // 
        NamesDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        NamesDataGridView.Columns.AddRange(new DataGridViewColumn[] { NameColumn, LanguageColumn, DetailColumn });
        NamesDataGridView.Location = new Point(292, 29);
        NamesDataGridView.Margin = new Padding(4, 3, 4, 3);
        NamesDataGridView.Name = "NamesDataGridView";
        NamesDataGridView.RowHeadersVisible = false;
        NamesDataGridView.Size = new Size(262, 239);
        NamesDataGridView.TabIndex = 7;
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
        // MoveBattleStylePreferenceCaptionLabel
        // 
        MoveBattleStylePreferenceCaptionLabel.AutoSize = true;
        MoveBattleStylePreferenceCaptionLabel.Location = new Point(13, 274);
        MoveBattleStylePreferenceCaptionLabel.Margin = new Padding(4, 0, 4, 0);
        MoveBattleStylePreferenceCaptionLabel.Name = "MoveBattleStylePreferenceCaptionLabel";
        MoveBattleStylePreferenceCaptionLabel.Size = new Size(77, 17);
        MoveBattleStylePreferenceCaptionLabel.TabIndex = 8;
        MoveBattleStylePreferenceCaptionLabel.Text = "戦闘スタイル";
        MoveBattleStylePreferenceCaptionLabel.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // MoveBattleStylePreferencesDataGridView
        // 
        MoveBattleStylePreferencesDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        MoveBattleStylePreferencesDataGridView.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1, dataGridViewButtonColumn1 });
        MoveBattleStylePreferencesDataGridView.Location = new Point(15, 294);
        MoveBattleStylePreferencesDataGridView.Margin = new Padding(4, 3, 4, 3);
        MoveBattleStylePreferencesDataGridView.Name = "MoveBattleStylePreferencesDataGridView";
        MoveBattleStylePreferencesDataGridView.RowHeadersVisible = false;
        MoveBattleStylePreferencesDataGridView.Size = new Size(262, 239);
        MoveBattleStylePreferencesDataGridView.TabIndex = 9;
        MoveBattleStylePreferencesDataGridView.CellClick += MoveBattleStylePreferencesDataGridView_CellClick;
        MoveBattleStylePreferencesDataGridView.CellDoubleClick += MoveBattleStylePreferencesDataGridView_CellDoubleClick;
        // 
        // dataGridViewTextBoxColumn1
        // 
        dataGridViewTextBoxColumn1.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
        dataGridViewTextBoxColumn1.DataPropertyName = "MoveBattleStyle";
        dataGridViewTextBoxColumn1.HeaderText = "戦闘スタイル";
        dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
        dataGridViewTextBoxColumn1.ReadOnly = true;
        dataGridViewTextBoxColumn1.Width = 102;
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
        // PokeathlonStatChangesDataGridView
        // 
        PokeathlonStatChangesDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        PokeathlonStatChangesDataGridView.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn2, dataGridViewButtonColumn2 });
        PokeathlonStatChangesDataGridView.Location = new Point(292, 294);
        PokeathlonStatChangesDataGridView.Margin = new Padding(4, 3, 4, 3);
        PokeathlonStatChangesDataGridView.Name = "PokeathlonStatChangesDataGridView";
        PokeathlonStatChangesDataGridView.RowHeadersVisible = false;
        PokeathlonStatChangesDataGridView.Size = new Size(262, 239);
        PokeathlonStatChangesDataGridView.TabIndex = 11;
        PokeathlonStatChangesDataGridView.CellClick += PokeathlonStatChangesDataGridView_CellClick;
        PokeathlonStatChangesDataGridView.CellDoubleClick += PokeathlonStatChangesDataGridView_CellDoubleClick;
        // 
        // dataGridViewTextBoxColumn2
        // 
        dataGridViewTextBoxColumn2.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
        dataGridViewTextBoxColumn2.DataPropertyName = "PokeathlonStat";
        dataGridViewTextBoxColumn2.HeaderText = "ステータス";
        dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
        dataGridViewTextBoxColumn2.ReadOnly = true;
        dataGridViewTextBoxColumn2.Width = 86;
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
        // PokeathlonStatChangesCaptionLabel
        // 
        PokeathlonStatChangesCaptionLabel.AutoSize = true;
        PokeathlonStatChangesCaptionLabel.Location = new Point(292, 274);
        PokeathlonStatChangesCaptionLabel.Margin = new Padding(4, 0, 4, 0);
        PokeathlonStatChangesCaptionLabel.Name = "PokeathlonStatChangesCaptionLabel";
        PokeathlonStatChangesCaptionLabel.Size = new Size(196, 17);
        PokeathlonStatChangesCaptionLabel.TabIndex = 10;
        PokeathlonStatChangesCaptionLabel.Text = "影響を与えるポケスロンのステータス";
        PokeathlonStatChangesCaptionLabel.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // PropertyButton
        // 
        PropertyButton.Location = new Point(394, 539);
        PropertyButton.Margin = new Padding(4, 3, 4, 3);
        PropertyButton.Name = "PropertyButton";
        PropertyButton.Size = new Size(76, 35);
        PropertyButton.TabIndex = 12;
        PropertyButton.Text = "プロパティ";
        PropertyButton.UseVisualStyleBackColor = true;
        PropertyButton.Click += PropertyButton_Click;
        // 
        // CloseButton
        // 
        CloseButton.Location = new Point(478, 539);
        CloseButton.Margin = new Padding(4, 3, 4, 3);
        CloseButton.Name = "CloseButton";
        CloseButton.Size = new Size(76, 35);
        CloseButton.TabIndex = 13;
        CloseButton.Text = "閉じる";
        CloseButton.UseVisualStyleBackColor = true;
        CloseButton.Click += CloseButton_Click;
        // 
        // NatureInfoForm
        // 
        AutoScaleDimensions = new SizeF(9F, 17F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(571, 586);
        Controls.Add(PropertyButton);
        Controls.Add(CloseButton);
        Controls.Add(PokeathlonStatChangesCaptionLabel);
        Controls.Add(PokeathlonStatChangesDataGridView);
        Controls.Add(MoveBattleStylePreferenceCaptionLabel);
        Controls.Add(MoveBattleStylePreferencesDataGridView);
        Controls.Add(NamesCaptionLabel);
        Controls.Add(NamesDataGridView);
        Controls.Add(BerryGroupBox);
        Controls.Add(StatGroupBox);
        Controls.Add(NameTextBox);
        Controls.Add(IdTextBox);
        Controls.Add(NameCaptionLabel);
        Controls.Add(IdCaptionLabel);
        Font = new Font("Meiryo UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 128);
        FormBorderStyle = FormBorderStyle.FixedSingle;
        Margin = new Padding(4, 3, 4, 3);
        MaximizeBox = false;
        Name = "NatureInfoForm";
        StartPosition = FormStartPosition.CenterParent;
        Text = "性格";
        StatGroupBox.ResumeLayout(false);
        StatGroupBox.PerformLayout();
        BerryGroupBox.ResumeLayout(false);
        BerryGroupBox.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)NamesDataGridView).EndInit();
        ((System.ComponentModel.ISupportInitialize)MoveBattleStylePreferencesDataGridView).EndInit();
        ((System.ComponentModel.ISupportInitialize)PokeathlonStatChangesDataGridView).EndInit();
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private TextBox NameTextBox;
    private TextBox IdTextBox;
    private Label NameCaptionLabel;
    private Label IdCaptionLabel;
    private GroupBox StatGroupBox;
    private TextBox IncreasedStatTextBox;
    private Button IncreasedStatButton;
    private Button DecreasedStatButton;
    private TextBox DecreasedStatTextBox;
    private GroupBox BerryGroupBox;
    private Button HatesFlavorButton;
    private TextBox HatesFlavorTextBox;
    private TextBox LikesFlavorTextBox;
    private Button LikesFlavorButton;
    private Label NamesCaptionLabel;
    private DataGridView NamesDataGridView;
    private DataGridViewTextBoxColumn NameColumn;
    private DataGridViewTextBoxColumn LanguageColumn;
    private DataGridViewButtonColumn DetailColumn;
    private Label MoveBattleStylePreferenceCaptionLabel;
    private DataGridView MoveBattleStylePreferencesDataGridView;
    private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
    private DataGridViewButtonColumn dataGridViewButtonColumn1;
    private DataGridView PokeathlonStatChangesDataGridView;
    private Label PokeathlonStatChangesCaptionLabel;
    private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
    private DataGridViewButtonColumn dataGridViewButtonColumn2;
    private Button PropertyButton;
    private Button CloseButton;
}