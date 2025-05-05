namespace Kos.PokeAPI.Forms;

partial class PalParkAreaInfoForm
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
        NamesDataGridView = new DataGridView();
        NameColumn = new DataGridViewTextBoxColumn();
        LanguageColumn = new DataGridViewTextBoxColumn();
        DetailColumn = new DataGridViewButtonColumn();
        NamesCaptionLabel = new Label();
        PokemonEncountersDataGridView = new DataGridView();
        SpeciesColumn = new DataGridViewTextBoxColumn();
        BaseScoreRate = new DataGridViewTextBoxColumn();
        Column1 = new DataGridViewTextBoxColumn();
        DetailButtonColumn = new DataGridViewButtonColumn();
        PokemonEncountersCaptionLabel = new Label();
        CloseButton = new Button();
        ((System.ComponentModel.ISupportInitialize)NamesDataGridView).BeginInit();
        ((System.ComponentModel.ISupportInitialize)PokemonEncountersDataGridView).BeginInit();
        SuspendLayout();
        // 
        // NameTextBox
        // 
        NameTextBox.Location = new Point(135, 42);
        NameTextBox.Margin = new Padding(4, 3, 4, 3);
        NameTextBox.Name = "NameTextBox";
        NameTextBox.ReadOnly = true;
        NameTextBox.Size = new Size(244, 24);
        NameTextBox.TabIndex = 3;
        // 
        // IdTextBox
        // 
        IdTextBox.Location = new Point(135, 12);
        IdTextBox.Margin = new Padding(4, 3, 4, 3);
        IdTextBox.Name = "IdTextBox";
        IdTextBox.ReadOnly = true;
        IdTextBox.Size = new Size(244, 24);
        IdTextBox.TabIndex = 1;
        // 
        // NameCaptionLabel
        // 
        NameCaptionLabel.AutoSize = true;
        NameCaptionLabel.Location = new Point(18, 45);
        NameCaptionLabel.Margin = new Padding(5, 0, 5, 0);
        NameCaptionLabel.Name = "NameCaptionLabel";
        NameCaptionLabel.Size = new Size(108, 17);
        NameCaptionLabel.TabIndex = 2;
        NameCaptionLabel.Text = "パルパークエリア名";
        NameCaptionLabel.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // IdCaptionLabel
        // 
        IdCaptionLabel.AutoSize = true;
        IdCaptionLabel.Location = new Point(14, 15);
        IdCaptionLabel.Margin = new Padding(5, 0, 5, 0);
        IdCaptionLabel.Name = "IdCaptionLabel";
        IdCaptionLabel.Size = new Size(112, 17);
        IdCaptionLabel.TabIndex = 0;
        IdCaptionLabel.Text = "パルパークエリアID";
        IdCaptionLabel.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // NamesDataGridView
        // 
        NamesDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        NamesDataGridView.Columns.AddRange(new DataGridViewColumn[] { NameColumn, LanguageColumn, DetailColumn });
        NamesDataGridView.Location = new Point(16, 93);
        NamesDataGridView.Margin = new Padding(4, 3, 4, 3);
        NamesDataGridView.Name = "NamesDataGridView";
        NamesDataGridView.RowHeadersVisible = false;
        NamesDataGridView.Size = new Size(363, 170);
        NamesDataGridView.TabIndex = 5;
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
        NamesCaptionLabel.Location = new Point(14, 73);
        NamesCaptionLabel.Margin = new Padding(4, 0, 4, 0);
        NamesCaptionLabel.Name = "NamesCaptionLabel";
        NamesCaptionLabel.Size = new Size(92, 17);
        NamesCaptionLabel.TabIndex = 4;
        NamesCaptionLabel.Text = "言語ごとの名前";
        NamesCaptionLabel.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // PokemonEncountersDataGridView
        // 
        PokemonEncountersDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        PokemonEncountersDataGridView.Columns.AddRange(new DataGridViewColumn[] { SpeciesColumn, BaseScoreRate, Column1, DetailButtonColumn });
        PokemonEncountersDataGridView.Location = new Point(387, 93);
        PokemonEncountersDataGridView.Margin = new Padding(4, 3, 4, 3);
        PokemonEncountersDataGridView.Name = "PokemonEncountersDataGridView";
        PokemonEncountersDataGridView.RowHeadersVisible = false;
        PokemonEncountersDataGridView.Size = new Size(342, 170);
        PokemonEncountersDataGridView.TabIndex = 7;
        PokemonEncountersDataGridView.CellClick += PokemonEncountersDataGridView_CellClick;
        PokemonEncountersDataGridView.CellDoubleClick += PokemonEncountersDataGridView_CellDoubleClick;
        // 
        // SpeciesColumn
        // 
        SpeciesColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
        SpeciesColumn.DataPropertyName = "PokemonSpecies";
        SpeciesColumn.HeaderText = "ポケモン";
        SpeciesColumn.Name = "SpeciesColumn";
        SpeciesColumn.ReadOnly = true;
        SpeciesColumn.Width = 74;
        // 
        // BaseScoreRate
        // 
        BaseScoreRate.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
        BaseScoreRate.DataPropertyName = "BaseScore";
        BaseScoreRate.HeaderText = "インデックス";
        BaseScoreRate.Name = "BaseScoreRate";
        BaseScoreRate.ReadOnly = true;
        BaseScoreRate.Width = 95;
        // 
        // Column1
        // 
        Column1.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
        Column1.DataPropertyName = "Rate";
        Column1.HeaderText = "遭遇率";
        Column1.Name = "Column1";
        Column1.Width = 72;
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
        // PokemonEncountersCaptionLabel
        // 
        PokemonEncountersCaptionLabel.AutoSize = true;
        PokemonEncountersCaptionLabel.Location = new Point(387, 73);
        PokemonEncountersCaptionLabel.Margin = new Padding(4, 0, 4, 0);
        PokemonEncountersCaptionLabel.Name = "PokemonEncountersCaptionLabel";
        PokemonEncountersCaptionLabel.Size = new Size(75, 17);
        PokemonEncountersCaptionLabel.TabIndex = 6;
        PokemonEncountersCaptionLabel.Text = "遭遇ポケモン";
        PokemonEncountersCaptionLabel.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // CloseButton
        // 
        CloseButton.Location = new Point(655, 269);
        CloseButton.Margin = new Padding(4, 3, 4, 3);
        CloseButton.Name = "CloseButton";
        CloseButton.Size = new Size(74, 34);
        CloseButton.TabIndex = 8;
        CloseButton.Text = "閉じる";
        CloseButton.UseVisualStyleBackColor = true;
        CloseButton.Click += CloseButton_Click;
        // 
        // PalParkAreaInfoForm
        // 
        AutoScaleDimensions = new SizeF(9F, 17F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(741, 315);
        Controls.Add(CloseButton);
        Controls.Add(PokemonEncountersDataGridView);
        Controls.Add(PokemonEncountersCaptionLabel);
        Controls.Add(NamesDataGridView);
        Controls.Add(NamesCaptionLabel);
        Controls.Add(NameTextBox);
        Controls.Add(IdTextBox);
        Controls.Add(NameCaptionLabel);
        Controls.Add(IdCaptionLabel);
        Font = new Font("Meiryo UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 128);
        FormBorderStyle = FormBorderStyle.FixedSingle;
        Margin = new Padding(4, 3, 4, 3);
        MaximizeBox = false;
        Name = "PalParkAreaInfoForm";
        StartPosition = FormStartPosition.CenterParent;
        Text = "パルパークエリア";
        ((System.ComponentModel.ISupportInitialize)NamesDataGridView).EndInit();
        ((System.ComponentModel.ISupportInitialize)PokemonEncountersDataGridView).EndInit();
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private TextBox NameTextBox;
    private TextBox IdTextBox;
    private Label NameCaptionLabel;
    private Label IdCaptionLabel;
    private DataGridView NamesDataGridView;
    private DataGridViewTextBoxColumn NameColumn;
    private DataGridViewTextBoxColumn LanguageColumn;
    private DataGridViewButtonColumn DetailColumn;
    private Label NamesCaptionLabel;
    private DataGridView PokemonEncountersDataGridView;
    private Label PokemonEncountersCaptionLabel;
    private Button CloseButton;
    private DataGridViewTextBoxColumn SpeciesColumn;
    private DataGridViewTextBoxColumn BaseScoreRate;
    private DataGridViewTextBoxColumn Column1;
    private DataGridViewButtonColumn DetailButtonColumn;
}