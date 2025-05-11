namespace Kos.PokeAPI.Forms;

partial class AbilityInfoForm
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
        IsMainSeriesCaptionLabel = new Label();
        IIsMainSeriesTextBox = new TextBox();
        GenerationButton = new Button();
        GenerationTextBox = new TextBox();
        NamesDataGridView = new DataGridView();
        NameColumn = new DataGridViewTextBoxColumn();
        LanguageColumn = new DataGridViewTextBoxColumn();
        DetailColumn = new DataGridViewButtonColumn();
        NamesCaptionLabel = new Label();
        AbilityPokemonDataGridView = new DataGridView();
        dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
        dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
        dataGridViewButtonColumn1 = new DataGridViewButtonColumn();
        AbilityPokemonCaptionLabel = new Label();
        tabControl1 = new TabControl();
        FlavorTextTabPage = new TabPage();
        FlavorTextEntriesDataGridView = new DataGridView();
        FlavorTextVersionGroupColumn = new DataGridViewTextBoxColumn();
        FlavorTextLanguageColumn = new DataGridViewTextBoxColumn();
        FlavorTextColumn = new DataGridViewTextBoxColumn();
        FlavorTextDetailColumn = new DataGridViewButtonColumn();
        EffectTabPage = new TabPage();
        EffectEntriesDataGridView = new DataGridView();
        EffectColumn = new DataGridViewTextBoxColumn();
        EffectDetailColumn = new DataGridViewButtonColumn();
        EffectChangesTabPage = new TabPage();
        EffectChangesDataGridView = new DataGridView();
        dataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
        dataGridViewButtonColumn2 = new DataGridViewButtonColumn();
        PropertyButton = new Button();
        CloseButton = new Button();
        ((System.ComponentModel.ISupportInitialize)NamesDataGridView).BeginInit();
        ((System.ComponentModel.ISupportInitialize)AbilityPokemonDataGridView).BeginInit();
        tabControl1.SuspendLayout();
        FlavorTextTabPage.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)FlavorTextEntriesDataGridView).BeginInit();
        EffectTabPage.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)EffectEntriesDataGridView).BeginInit();
        EffectChangesTabPage.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)EffectChangesDataGridView).BeginInit();
        SuspendLayout();
        // 
        // NameTextBox
        // 
        NameTextBox.Location = new Point(142, 42);
        NameTextBox.Name = "NameTextBox";
        NameTextBox.ReadOnly = true;
        NameTextBox.Size = new Size(190, 24);
        NameTextBox.TabIndex = 3;
        // 
        // IdTextBox
        // 
        IdTextBox.Location = new Point(142, 12);
        IdTextBox.Name = "IdTextBox";
        IdTextBox.ReadOnly = true;
        IdTextBox.Size = new Size(190, 24);
        IdTextBox.TabIndex = 1;
        // 
        // NameCaptionLabel
        // 
        NameCaptionLabel.AutoSize = true;
        NameCaptionLabel.Location = new Point(63, 45);
        NameCaptionLabel.Margin = new Padding(4, 0, 4, 0);
        NameCaptionLabel.Name = "NameCaptionLabel";
        NameCaptionLabel.Size = new Size(72, 17);
        NameCaptionLabel.TabIndex = 2;
        NameCaptionLabel.Text = "特性の名前";
        NameCaptionLabel.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // IdCaptionLabel
        // 
        IdCaptionLabel.AutoSize = true;
        IdCaptionLabel.Location = new Point(84, 15);
        IdCaptionLabel.Margin = new Padding(4, 0, 4, 0);
        IdCaptionLabel.Name = "IdCaptionLabel";
        IdCaptionLabel.Size = new Size(51, 17);
        IdCaptionLabel.TabIndex = 0;
        IdCaptionLabel.Text = "特性ID";
        IdCaptionLabel.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // IsMainSeriesCaptionLabel
        // 
        IsMainSeriesCaptionLabel.AutoSize = true;
        IsMainSeriesCaptionLabel.Location = new Point(13, 75);
        IsMainSeriesCaptionLabel.Margin = new Padding(4, 0, 4, 0);
        IsMainSeriesCaptionLabel.Name = "IsMainSeriesCaptionLabel";
        IsMainSeriesCaptionLabel.Size = new Size(122, 17);
        IsMainSeriesCaptionLabel.TabIndex = 4;
        IsMainSeriesCaptionLabel.Text = "メインシリーズかどうか";
        IsMainSeriesCaptionLabel.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // IIsMainSeriesTextBox
        // 
        IIsMainSeriesTextBox.Location = new Point(142, 72);
        IIsMainSeriesTextBox.Name = "IIsMainSeriesTextBox";
        IIsMainSeriesTextBox.ReadOnly = true;
        IIsMainSeriesTextBox.Size = new Size(190, 24);
        IIsMainSeriesTextBox.TabIndex = 5;
        // 
        // GenerationButton
        // 
        GenerationButton.Location = new Point(80, 100);
        GenerationButton.Margin = new Padding(4, 3, 4, 3);
        GenerationButton.Name = "GenerationButton";
        GenerationButton.Size = new Size(55, 26);
        GenerationButton.TabIndex = 6;
        GenerationButton.Text = "世代";
        GenerationButton.UseVisualStyleBackColor = true;
        GenerationButton.Click += GenerationButton_Click;
        // 
        // GenerationTextBox
        // 
        GenerationTextBox.Location = new Point(142, 102);
        GenerationTextBox.Name = "GenerationTextBox";
        GenerationTextBox.ReadOnly = true;
        GenerationTextBox.Size = new Size(190, 24);
        GenerationTextBox.TabIndex = 7;
        // 
        // NamesDataGridView
        // 
        NamesDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        NamesDataGridView.Columns.AddRange(new DataGridViewColumn[] { NameColumn, LanguageColumn, DetailColumn });
        NamesDataGridView.Location = new Point(13, 149);
        NamesDataGridView.Margin = new Padding(4, 3, 4, 3);
        NamesDataGridView.Name = "NamesDataGridView";
        NamesDataGridView.RowHeadersVisible = false;
        NamesDataGridView.Size = new Size(319, 116);
        NamesDataGridView.TabIndex = 9;
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
        NamesCaptionLabel.Location = new Point(13, 129);
        NamesCaptionLabel.Margin = new Padding(4, 0, 4, 0);
        NamesCaptionLabel.Name = "NamesCaptionLabel";
        NamesCaptionLabel.Size = new Size(92, 17);
        NamesCaptionLabel.TabIndex = 8;
        NamesCaptionLabel.Text = "言語ごとの名前";
        NamesCaptionLabel.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // AbilityPokemonDataGridView
        // 
        AbilityPokemonDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        AbilityPokemonDataGridView.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1, dataGridViewTextBoxColumn2, dataGridViewButtonColumn1 });
        AbilityPokemonDataGridView.Location = new Point(339, 32);
        AbilityPokemonDataGridView.Margin = new Padding(4, 3, 4, 3);
        AbilityPokemonDataGridView.Name = "AbilityPokemonDataGridView";
        AbilityPokemonDataGridView.RowHeadersVisible = false;
        AbilityPokemonDataGridView.Size = new Size(319, 233);
        AbilityPokemonDataGridView.TabIndex = 11;
        AbilityPokemonDataGridView.CellClick += AbilityPokemonDataGridView_CellClick;
        AbilityPokemonDataGridView.CellDoubleClick += AbilityPokemonDataGridView_CellDoubleClick;
        // 
        // dataGridViewTextBoxColumn1
        // 
        dataGridViewTextBoxColumn1.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
        dataGridViewTextBoxColumn1.DataPropertyName = "Pokemon";
        dataGridViewTextBoxColumn1.HeaderText = "ポケモン";
        dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
        dataGridViewTextBoxColumn1.ReadOnly = true;
        dataGridViewTextBoxColumn1.Width = 74;
        // 
        // dataGridViewTextBoxColumn2
        // 
        dataGridViewTextBoxColumn2.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
        dataGridViewTextBoxColumn2.DataPropertyName = "Slot";
        dataGridViewTextBoxColumn2.HeaderText = "スロット";
        dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
        dataGridViewTextBoxColumn2.ReadOnly = true;
        dataGridViewTextBoxColumn2.Width = 72;
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
        // AbilityPokemonCaptionLabel
        // 
        AbilityPokemonCaptionLabel.AutoSize = true;
        AbilityPokemonCaptionLabel.Location = new Point(339, 12);
        AbilityPokemonCaptionLabel.Margin = new Padding(4, 0, 4, 0);
        AbilityPokemonCaptionLabel.Name = "AbilityPokemonCaptionLabel";
        AbilityPokemonCaptionLabel.Size = new Size(49, 17);
        AbilityPokemonCaptionLabel.TabIndex = 10;
        AbilityPokemonCaptionLabel.Text = "ポケモン";
        AbilityPokemonCaptionLabel.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // tabControl1
        // 
        tabControl1.Controls.Add(FlavorTextTabPage);
        tabControl1.Controls.Add(EffectTabPage);
        tabControl1.Controls.Add(EffectChangesTabPage);
        tabControl1.Location = new Point(12, 271);
        tabControl1.Name = "tabControl1";
        tabControl1.SelectedIndex = 0;
        tabControl1.Size = new Size(1066, 538);
        tabControl1.TabIndex = 12;
        // 
        // FlavorTextTabPage
        // 
        FlavorTextTabPage.Controls.Add(FlavorTextEntriesDataGridView);
        FlavorTextTabPage.Location = new Point(4, 26);
        FlavorTextTabPage.Name = "FlavorTextTabPage";
        FlavorTextTabPage.Padding = new Padding(3);
        FlavorTextTabPage.Size = new Size(1058, 508);
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
        FlavorTextEntriesDataGridView.Size = new Size(1052, 502);
        FlavorTextEntriesDataGridView.TabIndex = 0;
        FlavorTextEntriesDataGridView.CellClick += FlavorTextEntriesDataGridView_CellClick;
        FlavorTextEntriesDataGridView.CellDoubleClick += FlavorTextEntriesDataGridView_CellDoubleClick;
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
        // EffectTabPage
        // 
        EffectTabPage.Controls.Add(EffectEntriesDataGridView);
        EffectTabPage.Location = new Point(4, 24);
        EffectTabPage.Name = "EffectTabPage";
        EffectTabPage.Padding = new Padding(3);
        EffectTabPage.Size = new Size(1058, 510);
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
        EffectEntriesDataGridView.Size = new Size(1052, 504);
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
        EffectChangesTabPage.Size = new Size(1058, 510);
        EffectChangesTabPage.TabIndex = 1;
        EffectChangesTabPage.Text = "効果変更";
        EffectChangesTabPage.UseVisualStyleBackColor = true;
        // 
        // EffectChangesDataGridView
        // 
        EffectChangesDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        EffectChangesDataGridView.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn3, dataGridViewButtonColumn2 });
        EffectChangesDataGridView.Dock = DockStyle.Fill;
        EffectChangesDataGridView.Location = new Point(3, 3);
        EffectChangesDataGridView.Margin = new Padding(4, 3, 4, 3);
        EffectChangesDataGridView.Name = "EffectChangesDataGridView";
        EffectChangesDataGridView.RowHeadersVisible = false;
        EffectChangesDataGridView.Size = new Size(1052, 504);
        EffectChangesDataGridView.TabIndex = 2;
        EffectChangesDataGridView.CellClick += EffectChangesDataGridView_CellClick;
        EffectChangesDataGridView.CellDoubleClick += EffectChangesDataGridView_CellDoubleClick;
        // 
        // dataGridViewTextBoxColumn3
        // 
        dataGridViewTextBoxColumn3.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
        dataGridViewTextBoxColumn3.DataPropertyName = "VersionGroup";
        dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
        dataGridViewTextBoxColumn3.DefaultCellStyle = dataGridViewCellStyle2;
        dataGridViewTextBoxColumn3.HeaderText = "バージョングループ";
        dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
        dataGridViewTextBoxColumn3.ReadOnly = true;
        dataGridViewTextBoxColumn3.Width = 88;
        // 
        // dataGridViewButtonColumn2
        // 
        dataGridViewButtonColumn2.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
        dataGridViewButtonColumn2.HeaderText = "詳細";
        dataGridViewButtonColumn2.Name = "dataGridViewButtonColumn2";
        dataGridViewButtonColumn2.Text = "詳細";
        dataGridViewButtonColumn2.UseColumnTextForButtonValue = true;
        dataGridViewButtonColumn2.Width = 36;
        // 
        // PropertyButton
        // 
        PropertyButton.Location = new Point(911, 811);
        PropertyButton.Margin = new Padding(4, 3, 4, 3);
        PropertyButton.Name = "PropertyButton";
        PropertyButton.Size = new Size(76, 35);
        PropertyButton.TabIndex = 13;
        PropertyButton.Text = "プロパティ";
        PropertyButton.UseVisualStyleBackColor = true;
        PropertyButton.Click += PropertyButton_Click;
        // 
        // CloseButton
        // 
        CloseButton.Location = new Point(995, 811);
        CloseButton.Margin = new Padding(4, 3, 4, 3);
        CloseButton.Name = "CloseButton";
        CloseButton.Size = new Size(76, 35);
        CloseButton.TabIndex = 14;
        CloseButton.Text = "閉じる";
        CloseButton.UseVisualStyleBackColor = true;
        CloseButton.Click += CloseButton_Click;
        // 
        // AbilityInfoForm
        // 
        AutoScaleDimensions = new SizeF(9F, 17F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(1100, 859);
        Controls.Add(PropertyButton);
        Controls.Add(CloseButton);
        Controls.Add(tabControl1);
        Controls.Add(AbilityPokemonCaptionLabel);
        Controls.Add(AbilityPokemonDataGridView);
        Controls.Add(NamesDataGridView);
        Controls.Add(NamesCaptionLabel);
        Controls.Add(GenerationTextBox);
        Controls.Add(GenerationButton);
        Controls.Add(IIsMainSeriesTextBox);
        Controls.Add(IsMainSeriesCaptionLabel);
        Controls.Add(NameTextBox);
        Controls.Add(IdTextBox);
        Controls.Add(NameCaptionLabel);
        Controls.Add(IdCaptionLabel);
        Font = new Font("Meiryo UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 128);
        FormBorderStyle = FormBorderStyle.FixedSingle;
        Margin = new Padding(4, 3, 4, 3);
        MaximizeBox = false;
        Name = "AbilityInfoForm";
        StartPosition = FormStartPosition.CenterParent;
        Text = "特性";
        ((System.ComponentModel.ISupportInitialize)NamesDataGridView).EndInit();
        ((System.ComponentModel.ISupportInitialize)AbilityPokemonDataGridView).EndInit();
        tabControl1.ResumeLayout(false);
        FlavorTextTabPage.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)FlavorTextEntriesDataGridView).EndInit();
        EffectTabPage.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)EffectEntriesDataGridView).EndInit();
        EffectChangesTabPage.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)EffectChangesDataGridView).EndInit();
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private TextBox NameTextBox;
    private TextBox IdTextBox;
    private Label NameCaptionLabel;
    private Label IdCaptionLabel;
    private Label IsMainSeriesCaptionLabel;
    private TextBox IIsMainSeriesTextBox;
    private Button GenerationButton;
    private TextBox GenerationTextBox;
    private DataGridView NamesDataGridView;
    private DataGridViewTextBoxColumn NameColumn;
    private DataGridViewTextBoxColumn LanguageColumn;
    private DataGridViewButtonColumn DetailColumn;
    private Label NamesCaptionLabel;
    private DataGridView AbilityPokemonDataGridView;
    private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
    private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
    private DataGridViewButtonColumn dataGridViewButtonColumn1;
    private Label AbilityPokemonCaptionLabel;
    private TabControl tabControl1;
    private TabPage FlavorTextTabPage;
    private DataGridView FlavorTextEntriesDataGridView;
    private DataGridViewTextBoxColumn FlavorTextVersionGroupColumn;
    private DataGridViewTextBoxColumn FlavorTextLanguageColumn;
    private DataGridViewTextBoxColumn FlavorTextColumn;
    private DataGridViewButtonColumn FlavorTextDetailColumn;
    private TabPage EffectTabPage;
    private DataGridView EffectEntriesDataGridView;
    private DataGridViewTextBoxColumn EffectColumn;
    private DataGridViewButtonColumn EffectDetailColumn;
    private TabPage EffectChangesTabPage;
    private DataGridView EffectChangesDataGridView;
    private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
    private DataGridViewButtonColumn dataGridViewButtonColumn2;
    private Button PropertyButton;
    private Button CloseButton;
}