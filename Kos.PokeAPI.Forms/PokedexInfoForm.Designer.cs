namespace Kos.PokeAPI.Forms;

partial class PokedexInfoForm
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
        NameCaptionLabel = new Label();
        IdCaptionLabel = new Label();
        IsMainSeriesCaptionLabel = new Label();
        DescriptionsDataGridView = new DataGridView();
        DescriptionColumn = new DataGridViewTextBoxColumn();
        EffectLanguageColumn = new DataGridViewTextBoxColumn();
        EffectLanguageInfoButtonColumn = new DataGridViewButtonColumn();
        DescriptionsCaptionLabel = new Label();
        NamesDataGridView = new DataGridView();
        NameColumn = new DataGridViewTextBoxColumn();
        LanguageColumn = new DataGridViewTextBoxColumn();
        DetailColumn = new DataGridViewButtonColumn();
        NamesCaptionLabel = new Label();
        PokemonEntriesDataGridView = new DataGridView();
        EntryNumberColumn = new DataGridViewTextBoxColumn();
        PokemonSpeciesColumn = new DataGridViewTextBoxColumn();
        PokemonSpeciesInfoColumn = new DataGridViewButtonColumn();
        PokemonEntriesCaptionLabel = new Label();
        RegionButton = new Button();
        VersionGroupDataGridView = new DataGridView();
        dataGridViewTextBoxColumn4 = new DataGridViewTextBoxColumn();
        dataGridViewButtonColumn4 = new DataGridViewButtonColumn();
        VersionGroupCaptionLabel = new Label();
        CloseButton = new Button();
        NameTextBox = new TextBox();
        IdTextBox = new TextBox();
        IsMainSeriesTextBox = new TextBox();
        RegionTextBox = new TextBox();
        PropertyButton = new Button();
        ((System.ComponentModel.ISupportInitialize)DescriptionsDataGridView).BeginInit();
        ((System.ComponentModel.ISupportInitialize)NamesDataGridView).BeginInit();
        ((System.ComponentModel.ISupportInitialize)PokemonEntriesDataGridView).BeginInit();
        ((System.ComponentModel.ISupportInitialize)VersionGroupDataGridView).BeginInit();
        SuspendLayout();
        // 
        // NameCaptionLabel
        // 
        NameCaptionLabel.AutoSize = true;
        NameCaptionLabel.Location = new Point(47, 49);
        NameCaptionLabel.Margin = new Padding(4, 0, 4, 0);
        NameCaptionLabel.Name = "NameCaptionLabel";
        NameCaptionLabel.Size = new Size(88, 17);
        NameCaptionLabel.TabIndex = 2;
        NameCaptionLabel.Text = "ポケモン図鑑名";
        NameCaptionLabel.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // IdCaptionLabel
        // 
        IdCaptionLabel.AutoSize = true;
        IdCaptionLabel.Location = new Point(43, 15);
        IdCaptionLabel.Margin = new Padding(4, 0, 4, 0);
        IdCaptionLabel.Name = "IdCaptionLabel";
        IdCaptionLabel.Size = new Size(92, 17);
        IdCaptionLabel.TabIndex = 0;
        IdCaptionLabel.Text = "ポケモン図鑑ID";
        IdCaptionLabel.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // IsMainSeriesCaptionLabel
        // 
        IsMainSeriesCaptionLabel.AutoSize = true;
        IsMainSeriesCaptionLabel.Location = new Point(13, 83);
        IsMainSeriesCaptionLabel.Margin = new Padding(4, 0, 4, 0);
        IsMainSeriesCaptionLabel.Name = "IsMainSeriesCaptionLabel";
        IsMainSeriesCaptionLabel.Size = new Size(122, 17);
        IsMainSeriesCaptionLabel.TabIndex = 4;
        IsMainSeriesCaptionLabel.Text = "メインシリーズかどうか";
        IsMainSeriesCaptionLabel.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // DescriptionsDataGridView
        // 
        DescriptionsDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        DescriptionsDataGridView.Columns.AddRange(new DataGridViewColumn[] { DescriptionColumn, EffectLanguageColumn, EffectLanguageInfoButtonColumn });
        DescriptionsDataGridView.Location = new Point(17, 172);
        DescriptionsDataGridView.Margin = new Padding(4, 3, 4, 3);
        DescriptionsDataGridView.Name = "DescriptionsDataGridView";
        DescriptionsDataGridView.RowHeadersVisible = false;
        DescriptionsDataGridView.Size = new Size(788, 170);
        DescriptionsDataGridView.TabIndex = 9;
        DescriptionsDataGridView.CellClick += DescriptionsDataGridView_CellClick;
        DescriptionsDataGridView.CellDoubleClick += DescriptionsDataGridView_CellDoubleClick;
        // 
        // DescriptionColumn
        // 
        DescriptionColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
        DescriptionColumn.DataPropertyName = "Text";
        DescriptionColumn.HeaderText = "説明";
        DescriptionColumn.Name = "DescriptionColumn";
        DescriptionColumn.ReadOnly = true;
        DescriptionColumn.Width = 59;
        // 
        // EffectLanguageColumn
        // 
        EffectLanguageColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
        EffectLanguageColumn.DataPropertyName = "Language";
        EffectLanguageColumn.HeaderText = "言語";
        EffectLanguageColumn.Name = "EffectLanguageColumn";
        EffectLanguageColumn.ReadOnly = true;
        EffectLanguageColumn.Width = 59;
        // 
        // EffectLanguageInfoButtonColumn
        // 
        EffectLanguageInfoButtonColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
        EffectLanguageInfoButtonColumn.HeaderText = "詳細";
        EffectLanguageInfoButtonColumn.Name = "EffectLanguageInfoButtonColumn";
        EffectLanguageInfoButtonColumn.Text = "詳細";
        EffectLanguageInfoButtonColumn.UseColumnTextForButtonValue = true;
        EffectLanguageInfoButtonColumn.Width = 40;
        // 
        // DescriptionsCaptionLabel
        // 
        DescriptionsCaptionLabel.AutoSize = true;
        DescriptionsCaptionLabel.Location = new Point(17, 152);
        DescriptionsCaptionLabel.Margin = new Padding(4, 0, 4, 0);
        DescriptionsCaptionLabel.Name = "DescriptionsCaptionLabel";
        DescriptionsCaptionLabel.Size = new Size(34, 17);
        DescriptionsCaptionLabel.TabIndex = 8;
        DescriptionsCaptionLabel.Text = "説明";
        DescriptionsCaptionLabel.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // NamesDataGridView
        // 
        NamesDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        NamesDataGridView.Columns.AddRange(new DataGridViewColumn[] { NameColumn, LanguageColumn, DetailColumn });
        NamesDataGridView.Location = new Point(15, 376);
        NamesDataGridView.Margin = new Padding(4, 3, 4, 3);
        NamesDataGridView.Name = "NamesDataGridView";
        NamesDataGridView.RowHeadersVisible = false;
        NamesDataGridView.Size = new Size(352, 170);
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
        // NamesCaptionLabel
        // 
        NamesCaptionLabel.AutoSize = true;
        NamesCaptionLabel.Location = new Point(17, 356);
        NamesCaptionLabel.Margin = new Padding(4, 0, 4, 0);
        NamesCaptionLabel.Name = "NamesCaptionLabel";
        NamesCaptionLabel.Size = new Size(92, 17);
        NamesCaptionLabel.TabIndex = 10;
        NamesCaptionLabel.Text = "言語ごとの名前";
        NamesCaptionLabel.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // PokemonEntriesDataGridView
        // 
        PokemonEntriesDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        PokemonEntriesDataGridView.Columns.AddRange(new DataGridViewColumn[] { EntryNumberColumn, PokemonSpeciesColumn, PokemonSpeciesInfoColumn });
        PokemonEntriesDataGridView.Location = new Point(373, 376);
        PokemonEntriesDataGridView.Margin = new Padding(4, 3, 4, 3);
        PokemonEntriesDataGridView.Name = "PokemonEntriesDataGridView";
        PokemonEntriesDataGridView.RowHeadersVisible = false;
        PokemonEntriesDataGridView.Size = new Size(432, 372);
        PokemonEntriesDataGridView.TabIndex = 15;
        // 
        // EntryNumberColumn
        // 
        EntryNumberColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
        EntryNumberColumn.DataPropertyName = "EntryNumber";
        EntryNumberColumn.HeaderText = "No.";
        EntryNumberColumn.Name = "EntryNumberColumn";
        EntryNumberColumn.ReadOnly = true;
        EntryNumberColumn.Width = 57;
        // 
        // PokemonSpeciesColumn
        // 
        PokemonSpeciesColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
        PokemonSpeciesColumn.DataPropertyName = "PokemonSpecies";
        PokemonSpeciesColumn.HeaderText = "ポケモン種族";
        PokemonSpeciesColumn.Name = "PokemonSpeciesColumn";
        PokemonSpeciesColumn.ReadOnly = true;
        // 
        // PokemonSpeciesInfoColumn
        // 
        PokemonSpeciesInfoColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
        PokemonSpeciesInfoColumn.HeaderText = "詳細";
        PokemonSpeciesInfoColumn.Name = "PokemonSpeciesInfoColumn";
        PokemonSpeciesInfoColumn.Text = "詳細";
        PokemonSpeciesInfoColumn.UseColumnTextForButtonValue = true;
        PokemonSpeciesInfoColumn.Width = 40;
        // 
        // PokemonEntriesCaptionLabel
        // 
        PokemonEntriesCaptionLabel.AutoSize = true;
        PokemonEntriesCaptionLabel.Location = new Point(373, 356);
        PokemonEntriesCaptionLabel.Margin = new Padding(4, 0, 4, 0);
        PokemonEntriesCaptionLabel.Name = "PokemonEntriesCaptionLabel";
        PokemonEntriesCaptionLabel.Size = new Size(99, 17);
        PokemonEntriesCaptionLabel.TabIndex = 14;
        PokemonEntriesCaptionLabel.Text = "ポケモンエントリー";
        PokemonEntriesCaptionLabel.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // RegionButton
        // 
        RegionButton.Location = new Point(80, 112);
        RegionButton.Margin = new Padding(4, 3, 4, 3);
        RegionButton.Name = "RegionButton";
        RegionButton.Size = new Size(55, 26);
        RegionButton.TabIndex = 6;
        RegionButton.Text = "地域";
        RegionButton.UseVisualStyleBackColor = true;
        RegionButton.Click += RegionDetailButton_Click;
        // 
        // VersionGroupDataGridView
        // 
        VersionGroupDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        VersionGroupDataGridView.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn4, dataGridViewButtonColumn4 });
        VersionGroupDataGridView.Location = new Point(15, 578);
        VersionGroupDataGridView.Margin = new Padding(4, 3, 4, 3);
        VersionGroupDataGridView.Name = "VersionGroupDataGridView";
        VersionGroupDataGridView.RowHeadersVisible = false;
        VersionGroupDataGridView.Size = new Size(350, 170);
        VersionGroupDataGridView.TabIndex = 13;
        VersionGroupDataGridView.CellClick += VersionGroupDataGridView_CellClick;
        VersionGroupDataGridView.CellDoubleClick += VersionGroupDataGridView_CellDoubleClick;
        // 
        // dataGridViewTextBoxColumn4
        // 
        dataGridViewTextBoxColumn4.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
        dataGridViewTextBoxColumn4.DataPropertyName = "Name";
        dataGridViewTextBoxColumn4.HeaderText = "バージョングループ";
        dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
        dataGridViewTextBoxColumn4.ReadOnly = true;
        dataGridViewTextBoxColumn4.Width = 88;
        // 
        // dataGridViewButtonColumn4
        // 
        dataGridViewButtonColumn4.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
        dataGridViewButtonColumn4.HeaderText = "詳細";
        dataGridViewButtonColumn4.Name = "dataGridViewButtonColumn4";
        dataGridViewButtonColumn4.Text = "詳細";
        dataGridViewButtonColumn4.UseColumnTextForButtonValue = true;
        dataGridViewButtonColumn4.Width = 36;
        // 
        // VersionGroupCaptionLabel
        // 
        VersionGroupCaptionLabel.AutoSize = true;
        VersionGroupCaptionLabel.Location = new Point(13, 558);
        VersionGroupCaptionLabel.Margin = new Padding(4, 0, 4, 0);
        VersionGroupCaptionLabel.Name = "VersionGroupCaptionLabel";
        VersionGroupCaptionLabel.Size = new Size(104, 17);
        VersionGroupCaptionLabel.TabIndex = 12;
        VersionGroupCaptionLabel.Text = "バージョングループ";
        VersionGroupCaptionLabel.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // CloseButton
        // 
        CloseButton.Location = new Point(729, 754);
        CloseButton.Margin = new Padding(4, 3, 4, 3);
        CloseButton.Name = "CloseButton";
        CloseButton.Size = new Size(76, 35);
        CloseButton.TabIndex = 17;
        CloseButton.Text = "閉じる";
        CloseButton.UseVisualStyleBackColor = true;
        CloseButton.Click += CloseButton_Click;
        // 
        // NameTextBox
        // 
        NameTextBox.Location = new Point(143, 45);
        NameTextBox.Margin = new Padding(4, 3, 4, 3);
        NameTextBox.Name = "NameTextBox";
        NameTextBox.ReadOnly = true;
        NameTextBox.Size = new Size(148, 24);
        NameTextBox.TabIndex = 3;
        // 
        // IdTextBox
        // 
        IdTextBox.Location = new Point(143, 15);
        IdTextBox.Margin = new Padding(4, 3, 4, 3);
        IdTextBox.Name = "IdTextBox";
        IdTextBox.ReadOnly = true;
        IdTextBox.Size = new Size(148, 24);
        IdTextBox.TabIndex = 1;
        // 
        // IsMainSeriesTextBox
        // 
        IsMainSeriesTextBox.Location = new Point(143, 80);
        IsMainSeriesTextBox.Margin = new Padding(4, 3, 4, 3);
        IsMainSeriesTextBox.Name = "IsMainSeriesTextBox";
        IsMainSeriesTextBox.ReadOnly = true;
        IsMainSeriesTextBox.Size = new Size(148, 24);
        IsMainSeriesTextBox.TabIndex = 5;
        // 
        // RegionTextBox
        // 
        RegionTextBox.Location = new Point(143, 114);
        RegionTextBox.Margin = new Padding(4, 3, 4, 3);
        RegionTextBox.Name = "RegionTextBox";
        RegionTextBox.ReadOnly = true;
        RegionTextBox.Size = new Size(148, 24);
        RegionTextBox.TabIndex = 7;
        // 
        // PropertyButton
        // 
        PropertyButton.Location = new Point(645, 754);
        PropertyButton.Margin = new Padding(4, 3, 4, 3);
        PropertyButton.Name = "PropertyButton";
        PropertyButton.Size = new Size(76, 35);
        PropertyButton.TabIndex = 16;
        PropertyButton.Text = "プロパティ";
        PropertyButton.UseVisualStyleBackColor = true;
        PropertyButton.Click += PropertyButton_Click;
        // 
        // PokedexInfoForm
        // 
        AutoScaleDimensions = new SizeF(9F, 17F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(819, 806);
        Controls.Add(PropertyButton);
        Controls.Add(RegionTextBox);
        Controls.Add(IsMainSeriesTextBox);
        Controls.Add(NameTextBox);
        Controls.Add(IdTextBox);
        Controls.Add(CloseButton);
        Controls.Add(VersionGroupCaptionLabel);
        Controls.Add(VersionGroupDataGridView);
        Controls.Add(RegionButton);
        Controls.Add(PokemonEntriesCaptionLabel);
        Controls.Add(PokemonEntriesDataGridView);
        Controls.Add(NamesDataGridView);
        Controls.Add(NamesCaptionLabel);
        Controls.Add(DescriptionsCaptionLabel);
        Controls.Add(DescriptionsDataGridView);
        Controls.Add(IsMainSeriesCaptionLabel);
        Controls.Add(NameCaptionLabel);
        Controls.Add(IdCaptionLabel);
        Font = new Font("Meiryo UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 128);
        FormBorderStyle = FormBorderStyle.FixedSingle;
        Margin = new Padding(4, 3, 4, 3);
        MaximizeBox = false;
        Name = "PokedexInfoForm";
        StartPosition = FormStartPosition.CenterParent;
        Text = "ポケモン図鑑";
        ((System.ComponentModel.ISupportInitialize)DescriptionsDataGridView).EndInit();
        ((System.ComponentModel.ISupportInitialize)NamesDataGridView).EndInit();
        ((System.ComponentModel.ISupportInitialize)PokemonEntriesDataGridView).EndInit();
        ((System.ComponentModel.ISupportInitialize)VersionGroupDataGridView).EndInit();
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion
    private Label NameCaptionLabel;
    private Label IdCaptionLabel;
    private Label IsMainSeriesCaptionLabel;
    private DataGridView DescriptionsDataGridView;
    private Label DescriptionsCaptionLabel;
    private DataGridView NamesDataGridView;
    private Label NamesCaptionLabel;
    private DataGridView PokemonEntriesDataGridView;
    private Label PokemonEntriesCaptionLabel;
    private Button RegionButton;
    private DataGridView VersionGroupDataGridView;
    private Label VersionGroupCaptionLabel;
    private Button CloseButton;
    private DataGridViewTextBoxColumn DescriptionColumn;
    private DataGridViewTextBoxColumn EffectLanguageColumn;
    private DataGridViewButtonColumn EffectLanguageInfoButtonColumn;
    private DataGridViewTextBoxColumn NameColumn;
    private DataGridViewTextBoxColumn LanguageColumn;
    private DataGridViewButtonColumn DetailColumn;
    private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
    private DataGridViewButtonColumn dataGridViewButtonColumn4;
    private DataGridViewTextBoxColumn EntryNumberColumn;
    private DataGridViewTextBoxColumn PokemonSpeciesColumn;
    private DataGridViewButtonColumn PokemonSpeciesInfoColumn;
    private TextBox NameTextBox;
    private TextBox IdTextBox;
    private TextBox IsMainSeriesTextBox;
    private TextBox RegionTextBox;
    private Button PropertyButton;
}