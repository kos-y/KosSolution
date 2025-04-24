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
        NameLabel = new Label();
        NameCaptionLabel = new Label();
        IdLabel = new Label();
        IdCaptionLabel = new Label();
        IsMainSeriesCaptionLabel = new Label();
        IsMainSeriesLabel = new Label();
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
        RegionLabel = new Label();
        RegionCaptionLabel = new Label();
        RegionInfoButton = new Button();
        VersionGroupDataGridView = new DataGridView();
        dataGridViewTextBoxColumn4 = new DataGridViewTextBoxColumn();
        dataGridViewButtonColumn4 = new DataGridViewButtonColumn();
        VersionGroupCaptionLabel = new Label();
        CloseButton = new Button();
        ((System.ComponentModel.ISupportInitialize)DescriptionsDataGridView).BeginInit();
        ((System.ComponentModel.ISupportInitialize)NamesDataGridView).BeginInit();
        ((System.ComponentModel.ISupportInitialize)PokemonEntriesDataGridView).BeginInit();
        ((System.ComponentModel.ISupportInitialize)VersionGroupDataGridView).BeginInit();
        SuspendLayout();
        // 
        // NameLabel
        // 
        NameLabel.BorderStyle = BorderStyle.Fixed3D;
        NameLabel.Location = new Point(133, 32);
        NameLabel.Name = "NameLabel";
        NameLabel.Size = new Size(147, 23);
        NameLabel.TabIndex = 3;
        NameLabel.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // NameCaptionLabel
        // 
        NameCaptionLabel.Location = new Point(12, 32);
        NameCaptionLabel.Name = "NameCaptionLabel";
        NameCaptionLabel.Size = new Size(115, 23);
        NameCaptionLabel.TabIndex = 2;
        NameCaptionLabel.Text = "name";
        NameCaptionLabel.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // IdLabel
        // 
        IdLabel.BorderStyle = BorderStyle.Fixed3D;
        IdLabel.Location = new Point(133, 9);
        IdLabel.Name = "IdLabel";
        IdLabel.Size = new Size(147, 23);
        IdLabel.TabIndex = 1;
        IdLabel.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // IdCaptionLabel
        // 
        IdCaptionLabel.Location = new Point(12, 9);
        IdCaptionLabel.Name = "IdCaptionLabel";
        IdCaptionLabel.Size = new Size(115, 23);
        IdCaptionLabel.TabIndex = 0;
        IdCaptionLabel.Text = "id";
        IdCaptionLabel.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // IsMainSeriesCaptionLabel
        // 
        IsMainSeriesCaptionLabel.Location = new Point(12, 55);
        IsMainSeriesCaptionLabel.Name = "IsMainSeriesCaptionLabel";
        IsMainSeriesCaptionLabel.Size = new Size(115, 23);
        IsMainSeriesCaptionLabel.TabIndex = 4;
        IsMainSeriesCaptionLabel.Text = "is_main_series";
        IsMainSeriesCaptionLabel.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // IsMainSeriesLabel
        // 
        IsMainSeriesLabel.BorderStyle = BorderStyle.Fixed3D;
        IsMainSeriesLabel.Location = new Point(133, 55);
        IsMainSeriesLabel.Name = "IsMainSeriesLabel";
        IsMainSeriesLabel.Size = new Size(147, 23);
        IsMainSeriesLabel.TabIndex = 5;
        IsMainSeriesLabel.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // DescriptionsDataGridView
        // 
        DescriptionsDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        DescriptionsDataGridView.Columns.AddRange(new DataGridViewColumn[] { DescriptionColumn, EffectLanguageColumn, EffectLanguageInfoButtonColumn });
        DescriptionsDataGridView.Location = new Point(133, 81);
        DescriptionsDataGridView.Name = "DescriptionsDataGridView";
        DescriptionsDataGridView.RowHeadersVisible = false;
        DescriptionsDataGridView.Size = new Size(672, 150);
        DescriptionsDataGridView.TabIndex = 7;
        DescriptionsDataGridView.CellClick += DescriptionsDataGridView_CellClick;
        DescriptionsDataGridView.CellDoubleClick += DescriptionsDataGridView_CellDoubleClick;
        // 
        // DescriptionColumn
        // 
        DescriptionColumn.DataPropertyName = "Text";
        DescriptionColumn.HeaderText = "description";
        DescriptionColumn.Name = "DescriptionColumn";
        DescriptionColumn.ReadOnly = true;
        DescriptionColumn.Width = 450;
        // 
        // EffectLanguageColumn
        // 
        EffectLanguageColumn.DataPropertyName = "Language";
        EffectLanguageColumn.HeaderText = "language";
        EffectLanguageColumn.Name = "EffectLanguageColumn";
        EffectLanguageColumn.ReadOnly = true;
        // 
        // EffectLanguageInfoButtonColumn
        // 
        EffectLanguageInfoButtonColumn.HeaderText = "LanguageInfo";
        EffectLanguageInfoButtonColumn.Name = "EffectLanguageInfoButtonColumn";
        EffectLanguageInfoButtonColumn.Text = "Info..";
        EffectLanguageInfoButtonColumn.UseColumnTextForButtonValue = true;
        // 
        // DescriptionsCaptionLabel
        // 
        DescriptionsCaptionLabel.Location = new Point(12, 81);
        DescriptionsCaptionLabel.Name = "DescriptionsCaptionLabel";
        DescriptionsCaptionLabel.Size = new Size(115, 23);
        DescriptionsCaptionLabel.TabIndex = 6;
        DescriptionsCaptionLabel.Text = "descriptions";
        DescriptionsCaptionLabel.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // NamesDataGridView
        // 
        NamesDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        NamesDataGridView.Columns.AddRange(new DataGridViewColumn[] { NameColumn, LanguageColumn, DetailColumn });
        NamesDataGridView.Location = new Point(133, 237);
        NamesDataGridView.Name = "NamesDataGridView";
        NamesDataGridView.RowHeadersVisible = false;
        NamesDataGridView.Size = new Size(668, 150);
        NamesDataGridView.TabIndex = 9;
        NamesDataGridView.CellClick += NamesDataGridView_CellClick;
        NamesDataGridView.CellDoubleClick += NamesDataGridView_CellDoubleClick;
        // 
        // NameColumn
        // 
        NameColumn.DataPropertyName = "Text";
        NameColumn.HeaderText = "name";
        NameColumn.Name = "NameColumn";
        NameColumn.ReadOnly = true;
        // 
        // LanguageColumn
        // 
        LanguageColumn.DataPropertyName = "Language";
        LanguageColumn.HeaderText = "language";
        LanguageColumn.Name = "LanguageColumn";
        LanguageColumn.ReadOnly = true;
        // 
        // DetailColumn
        // 
        DetailColumn.HeaderText = "Info";
        DetailColumn.Name = "DetailColumn";
        DetailColumn.Text = "Info..";
        DetailColumn.UseColumnTextForButtonValue = true;
        // 
        // NamesCaptionLabel
        // 
        NamesCaptionLabel.Location = new Point(12, 237);
        NamesCaptionLabel.Name = "NamesCaptionLabel";
        NamesCaptionLabel.Size = new Size(115, 23);
        NamesCaptionLabel.TabIndex = 8;
        NamesCaptionLabel.Text = "names";
        NamesCaptionLabel.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // PokemonEntriesDataGridView
        // 
        PokemonEntriesDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        PokemonEntriesDataGridView.Columns.AddRange(new DataGridViewColumn[] { EntryNumberColumn, PokemonSpeciesColumn, PokemonSpeciesInfoColumn });
        PokemonEntriesDataGridView.Location = new Point(133, 393);
        PokemonEntriesDataGridView.Name = "PokemonEntriesDataGridView";
        PokemonEntriesDataGridView.RowHeadersVisible = false;
        PokemonEntriesDataGridView.Size = new Size(668, 150);
        PokemonEntriesDataGridView.TabIndex = 11;
        // 
        // EntryNumberColumn
        // 
        EntryNumberColumn.DataPropertyName = "EntryNumber";
        EntryNumberColumn.HeaderText = "entry_number";
        EntryNumberColumn.Name = "EntryNumberColumn";
        EntryNumberColumn.ReadOnly = true;
        // 
        // PokemonSpeciesColumn
        // 
        PokemonSpeciesColumn.DataPropertyName = "PokemonSpecies";
        PokemonSpeciesColumn.HeaderText = "pokemon_species";
        PokemonSpeciesColumn.Name = "PokemonSpeciesColumn";
        PokemonSpeciesColumn.ReadOnly = true;
        // 
        // PokemonSpeciesInfoColumn
        // 
        PokemonSpeciesInfoColumn.HeaderText = "Info";
        PokemonSpeciesInfoColumn.Name = "PokemonSpeciesInfoColumn";
        PokemonSpeciesInfoColumn.Text = "Info..";
        PokemonSpeciesInfoColumn.UseColumnTextForButtonValue = true;
        // 
        // PokemonEntriesCaptionLabel
        // 
        PokemonEntriesCaptionLabel.Location = new Point(12, 393);
        PokemonEntriesCaptionLabel.Name = "PokemonEntriesCaptionLabel";
        PokemonEntriesCaptionLabel.Size = new Size(115, 23);
        PokemonEntriesCaptionLabel.TabIndex = 10;
        PokemonEntriesCaptionLabel.Text = "pokemon_entries";
        PokemonEntriesCaptionLabel.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // RegionLabel
        // 
        RegionLabel.BorderStyle = BorderStyle.Fixed3D;
        RegionLabel.Location = new Point(133, 546);
        RegionLabel.Name = "RegionLabel";
        RegionLabel.Size = new Size(147, 23);
        RegionLabel.TabIndex = 13;
        RegionLabel.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // RegionCaptionLabel
        // 
        RegionCaptionLabel.Location = new Point(12, 546);
        RegionCaptionLabel.Name = "RegionCaptionLabel";
        RegionCaptionLabel.Size = new Size(115, 23);
        RegionCaptionLabel.TabIndex = 12;
        RegionCaptionLabel.Text = "region";
        RegionCaptionLabel.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // RegionInfoButton
        // 
        RegionInfoButton.Location = new Point(286, 546);
        RegionInfoButton.Name = "RegionInfoButton";
        RegionInfoButton.Size = new Size(43, 23);
        RegionInfoButton.TabIndex = 14;
        RegionInfoButton.Text = "Info...";
        RegionInfoButton.UseVisualStyleBackColor = true;
        // 
        // VersionGroupDataGridView
        // 
        VersionGroupDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        VersionGroupDataGridView.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn4, dataGridViewButtonColumn4 });
        VersionGroupDataGridView.Location = new Point(133, 572);
        VersionGroupDataGridView.Name = "VersionGroupDataGridView";
        VersionGroupDataGridView.RowHeadersVisible = false;
        VersionGroupDataGridView.Size = new Size(434, 150);
        VersionGroupDataGridView.TabIndex = 16;
        // 
        // dataGridViewTextBoxColumn4
        // 
        dataGridViewTextBoxColumn4.DataPropertyName = "Name";
        dataGridViewTextBoxColumn4.HeaderText = "name";
        dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
        dataGridViewTextBoxColumn4.ReadOnly = true;
        // 
        // dataGridViewButtonColumn4
        // 
        dataGridViewButtonColumn4.HeaderText = "Info";
        dataGridViewButtonColumn4.Name = "dataGridViewButtonColumn4";
        dataGridViewButtonColumn4.Text = "Info..";
        dataGridViewButtonColumn4.UseColumnTextForButtonValue = true;
        // 
        // VersionGroupCaptionLabel
        // 
        VersionGroupCaptionLabel.Location = new Point(12, 572);
        VersionGroupCaptionLabel.Name = "VersionGroupCaptionLabel";
        VersionGroupCaptionLabel.Size = new Size(115, 23);
        VersionGroupCaptionLabel.TabIndex = 15;
        VersionGroupCaptionLabel.Text = "version_group";
        VersionGroupCaptionLabel.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // CloseButton
        // 
        CloseButton.Location = new Point(726, 699);
        CloseButton.Name = "CloseButton";
        CloseButton.Size = new Size(75, 23);
        CloseButton.TabIndex = 17;
        CloseButton.Text = "Close";
        CloseButton.UseVisualStyleBackColor = true;
        CloseButton.Click += CloseButton_Click;
        // 
        // PokedexInfoForm
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(813, 740);
        Controls.Add(CloseButton);
        Controls.Add(VersionGroupCaptionLabel);
        Controls.Add(VersionGroupDataGridView);
        Controls.Add(RegionInfoButton);
        Controls.Add(RegionCaptionLabel);
        Controls.Add(RegionLabel);
        Controls.Add(PokemonEntriesCaptionLabel);
        Controls.Add(PokemonEntriesDataGridView);
        Controls.Add(NamesDataGridView);
        Controls.Add(NamesCaptionLabel);
        Controls.Add(DescriptionsCaptionLabel);
        Controls.Add(DescriptionsDataGridView);
        Controls.Add(IsMainSeriesLabel);
        Controls.Add(IsMainSeriesCaptionLabel);
        Controls.Add(NameLabel);
        Controls.Add(NameCaptionLabel);
        Controls.Add(IdLabel);
        Controls.Add(IdCaptionLabel);
        FormBorderStyle = FormBorderStyle.FixedSingle;
        MinimizeBox = false;
        Name = "PokedexInfoForm";
        StartPosition = FormStartPosition.CenterParent;
        Text = "ポケモン図鑑";
        ((System.ComponentModel.ISupportInitialize)DescriptionsDataGridView).EndInit();
        ((System.ComponentModel.ISupportInitialize)NamesDataGridView).EndInit();
        ((System.ComponentModel.ISupportInitialize)PokemonEntriesDataGridView).EndInit();
        ((System.ComponentModel.ISupportInitialize)VersionGroupDataGridView).EndInit();
        ResumeLayout(false);
    }

    #endregion

    private Label NameLabel;
    private Label NameCaptionLabel;
    private Label IdLabel;
    private Label IdCaptionLabel;
    private Label IsMainSeriesCaptionLabel;
    private Label IsMainSeriesLabel;
    private DataGridView DescriptionsDataGridView;
    private DataGridViewTextBoxColumn DescriptionColumn;
    private DataGridViewTextBoxColumn EffectLanguageColumn;
    private DataGridViewButtonColumn EffectLanguageInfoButtonColumn;
    private Label DescriptionsCaptionLabel;
    private DataGridView NamesDataGridView;
    private DataGridViewTextBoxColumn NameColumn;
    private DataGridViewTextBoxColumn LanguageColumn;
    private DataGridViewButtonColumn DetailColumn;
    private Label NamesCaptionLabel;
    private DataGridView PokemonEntriesDataGridView;
    private Label PokemonEntriesCaptionLabel;
    private DataGridViewTextBoxColumn EntryNumberColumn;
    private DataGridViewTextBoxColumn PokemonSpeciesColumn;
    private DataGridViewButtonColumn PokemonSpeciesInfoColumn;
    private Label RegionLabel;
    private Label RegionCaptionLabel;
    private Button RegionInfoButton;
    private DataGridView VersionGroupDataGridView;
    private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
    private DataGridViewButtonColumn dataGridViewButtonColumn4;
    private Label VersionGroupCaptionLabel;
    private Button CloseButton;
}