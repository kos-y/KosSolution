namespace Kos.PokeAPI.Forms;

partial class GenerationInfoForm
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
        AbilitiesCaptionLabel = new Label();
        AbilitiesDataGridView = new DataGridView();
        dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
        dataGridViewButtonColumn1 = new DataGridViewButtonColumn();
        NamesDataGridView = new DataGridView();
        NameColumn = new DataGridViewTextBoxColumn();
        LanguageColumn = new DataGridViewTextBoxColumn();
        DetailColumn = new DataGridViewButtonColumn();
        NamesCaptionLabel = new Label();
        PokemonSpeciesCaptionLabel = new Label();
        PokemonSpeciesDataGridView = new DataGridView();
        dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
        dataGridViewButtonColumn2 = new DataGridViewButtonColumn();
        TypesCaptionLabel = new Label();
        TypesDataGridView = new DataGridView();
        dataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
        dataGridViewButtonColumn3 = new DataGridViewButtonColumn();
        VersionGroupCaptionLabel = new Label();
        VersionGroupDataGridView = new DataGridView();
        dataGridViewTextBoxColumn4 = new DataGridViewTextBoxColumn();
        dataGridViewButtonColumn4 = new DataGridViewButtonColumn();
        CloseButton = new Button();
        NameTextBox = new TextBox();
        IdTextBox = new TextBox();
        ((System.ComponentModel.ISupportInitialize)AbilitiesDataGridView).BeginInit();
        ((System.ComponentModel.ISupportInitialize)NamesDataGridView).BeginInit();
        ((System.ComponentModel.ISupportInitialize)PokemonSpeciesDataGridView).BeginInit();
        ((System.ComponentModel.ISupportInitialize)TypesDataGridView).BeginInit();
        ((System.ComponentModel.ISupportInitialize)VersionGroupDataGridView).BeginInit();
        SuspendLayout();
        // 
        // NameCaptionLabel
        // 
        NameCaptionLabel.AutoSize = true;
        NameCaptionLabel.Location = new Point(15, 45);
        NameCaptionLabel.Margin = new Padding(4, 0, 4, 0);
        NameCaptionLabel.Name = "NameCaptionLabel";
        NameCaptionLabel.Size = new Size(47, 17);
        NameCaptionLabel.TabIndex = 2;
        NameCaptionLabel.Text = "世代名";
        NameCaptionLabel.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // IdCaptionLabel
        // 
        IdCaptionLabel.AutoSize = true;
        IdCaptionLabel.Location = new Point(11, 15);
        IdCaptionLabel.Margin = new Padding(4, 0, 4, 0);
        IdCaptionLabel.Name = "IdCaptionLabel";
        IdCaptionLabel.Size = new Size(51, 17);
        IdCaptionLabel.TabIndex = 0;
        IdCaptionLabel.Text = "世代ID";
        IdCaptionLabel.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // AbilitiesCaptionLabel
        // 
        AbilitiesCaptionLabel.AutoSize = true;
        AbilitiesCaptionLabel.Location = new Point(15, 72);
        AbilitiesCaptionLabel.Margin = new Padding(4, 0, 4, 0);
        AbilitiesCaptionLabel.Name = "AbilitiesCaptionLabel";
        AbilitiesCaptionLabel.Size = new Size(34, 17);
        AbilitiesCaptionLabel.TabIndex = 4;
        AbilitiesCaptionLabel.Text = "特性";
        AbilitiesCaptionLabel.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // AbilitiesDataGridView
        // 
        AbilitiesDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        AbilitiesDataGridView.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1, dataGridViewButtonColumn1 });
        AbilitiesDataGridView.Location = new Point(15, 92);
        AbilitiesDataGridView.Margin = new Padding(4, 3, 4, 3);
        AbilitiesDataGridView.Name = "AbilitiesDataGridView";
        AbilitiesDataGridView.RowHeadersVisible = false;
        AbilitiesDataGridView.Size = new Size(558, 170);
        AbilitiesDataGridView.TabIndex = 5;
        AbilitiesDataGridView.CellClick += AbilitiesDataGridView_CellClick;
        // 
        // dataGridViewTextBoxColumn1
        // 
        dataGridViewTextBoxColumn1.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
        dataGridViewTextBoxColumn1.DataPropertyName = "Name";
        dataGridViewTextBoxColumn1.HeaderText = "特性";
        dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
        dataGridViewTextBoxColumn1.ReadOnly = true;
        dataGridViewTextBoxColumn1.Width = 59;
        // 
        // dataGridViewButtonColumn1
        // 
        dataGridViewButtonColumn1.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
        dataGridViewButtonColumn1.HeaderText = "詳細";
        dataGridViewButtonColumn1.Name = "dataGridViewButtonColumn1";
        dataGridViewButtonColumn1.Text = "syousai ";
        dataGridViewButtonColumn1.UseColumnTextForButtonValue = true;
        dataGridViewButtonColumn1.Width = 40;
        // 
        // NamesDataGridView
        // 
        NamesDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        NamesDataGridView.Columns.AddRange(new DataGridViewColumn[] { NameColumn, LanguageColumn, DetailColumn });
        NamesDataGridView.Location = new Point(15, 294);
        NamesDataGridView.Margin = new Padding(4, 3, 4, 3);
        NamesDataGridView.Name = "NamesDataGridView";
        NamesDataGridView.RowHeadersVisible = false;
        NamesDataGridView.Size = new Size(558, 170);
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
        NamesCaptionLabel.Location = new Point(13, 274);
        NamesCaptionLabel.Margin = new Padding(4, 0, 4, 0);
        NamesCaptionLabel.Name = "NamesCaptionLabel";
        NamesCaptionLabel.Size = new Size(92, 17);
        NamesCaptionLabel.TabIndex = 8;
        NamesCaptionLabel.Text = "言語ごとの名前";
        NamesCaptionLabel.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // PokemonSpeciesCaptionLabel
        // 
        PokemonSpeciesCaptionLabel.AutoSize = true;
        PokemonSpeciesCaptionLabel.Location = new Point(581, 72);
        PokemonSpeciesCaptionLabel.Margin = new Padding(4, 0, 4, 0);
        PokemonSpeciesCaptionLabel.Name = "PokemonSpeciesCaptionLabel";
        PokemonSpeciesCaptionLabel.Size = new Size(75, 17);
        PokemonSpeciesCaptionLabel.TabIndex = 6;
        PokemonSpeciesCaptionLabel.Text = "ポケモン種族";
        PokemonSpeciesCaptionLabel.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // PokemonSpeciesDataGridView
        // 
        PokemonSpeciesDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        PokemonSpeciesDataGridView.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn2, dataGridViewButtonColumn2 });
        PokemonSpeciesDataGridView.Location = new Point(581, 92);
        PokemonSpeciesDataGridView.Margin = new Padding(4, 3, 4, 3);
        PokemonSpeciesDataGridView.Name = "PokemonSpeciesDataGridView";
        PokemonSpeciesDataGridView.RowHeadersVisible = false;
        PokemonSpeciesDataGridView.Size = new Size(558, 170);
        PokemonSpeciesDataGridView.TabIndex = 7;
        // 
        // dataGridViewTextBoxColumn2
        // 
        dataGridViewTextBoxColumn2.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
        dataGridViewTextBoxColumn2.DataPropertyName = "Name";
        dataGridViewTextBoxColumn2.HeaderText = "ポケモン種族";
        dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
        dataGridViewTextBoxColumn2.ReadOnly = true;
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
        // TypesCaptionLabel
        // 
        TypesCaptionLabel.AutoSize = true;
        TypesCaptionLabel.Location = new Point(581, 274);
        TypesCaptionLabel.Margin = new Padding(4, 0, 4, 0);
        TypesCaptionLabel.Name = "TypesCaptionLabel";
        TypesCaptionLabel.Size = new Size(40, 17);
        TypesCaptionLabel.TabIndex = 10;
        TypesCaptionLabel.Text = "タイプ";
        TypesCaptionLabel.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // TypesDataGridView
        // 
        TypesDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        TypesDataGridView.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn3, dataGridViewButtonColumn3 });
        TypesDataGridView.Location = new Point(581, 294);
        TypesDataGridView.Margin = new Padding(4, 3, 4, 3);
        TypesDataGridView.Name = "TypesDataGridView";
        TypesDataGridView.RowHeadersVisible = false;
        TypesDataGridView.Size = new Size(558, 170);
        TypesDataGridView.TabIndex = 11;
        // 
        // dataGridViewTextBoxColumn3
        // 
        dataGridViewTextBoxColumn3.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
        dataGridViewTextBoxColumn3.DataPropertyName = "Name";
        dataGridViewTextBoxColumn3.HeaderText = "タイプ";
        dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
        dataGridViewTextBoxColumn3.ReadOnly = true;
        dataGridViewTextBoxColumn3.Width = 65;
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
        // VersionGroupCaptionLabel
        // 
        VersionGroupCaptionLabel.AutoSize = true;
        VersionGroupCaptionLabel.Location = new Point(15, 478);
        VersionGroupCaptionLabel.Margin = new Padding(4, 0, 4, 0);
        VersionGroupCaptionLabel.Name = "VersionGroupCaptionLabel";
        VersionGroupCaptionLabel.Size = new Size(104, 17);
        VersionGroupCaptionLabel.TabIndex = 12;
        VersionGroupCaptionLabel.Text = "バージョングループ";
        VersionGroupCaptionLabel.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // VersionGroupDataGridView
        // 
        VersionGroupDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        VersionGroupDataGridView.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn4, dataGridViewButtonColumn4 });
        VersionGroupDataGridView.Location = new Point(15, 498);
        VersionGroupDataGridView.Margin = new Padding(4, 3, 4, 3);
        VersionGroupDataGridView.Name = "VersionGroupDataGridView";
        VersionGroupDataGridView.RowHeadersVisible = false;
        VersionGroupDataGridView.Size = new Size(558, 170);
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
        // CloseButton
        // 
        CloseButton.Location = new Point(1066, 666);
        CloseButton.Margin = new Padding(4, 3, 4, 3);
        CloseButton.Name = "CloseButton";
        CloseButton.Size = new Size(73, 35);
        CloseButton.TabIndex = 14;
        CloseButton.Text = "閉じる";
        CloseButton.UseVisualStyleBackColor = true;
        CloseButton.Click += CloseButton_Click;
        // 
        // NameTextBox
        // 
        NameTextBox.Location = new Point(69, 42);
        NameTextBox.Name = "NameTextBox";
        NameTextBox.ReadOnly = true;
        NameTextBox.Size = new Size(191, 24);
        NameTextBox.TabIndex = 3;
        // 
        // IdTextBox
        // 
        IdTextBox.Location = new Point(69, 12);
        IdTextBox.Name = "IdTextBox";
        IdTextBox.ReadOnly = true;
        IdTextBox.Size = new Size(191, 24);
        IdTextBox.TabIndex = 1;
        // 
        // GenerationInfoForm
        // 
        AutoScaleDimensions = new SizeF(9F, 17F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(1161, 721);
        Controls.Add(NameTextBox);
        Controls.Add(IdTextBox);
        Controls.Add(CloseButton);
        Controls.Add(VersionGroupDataGridView);
        Controls.Add(VersionGroupCaptionLabel);
        Controls.Add(TypesDataGridView);
        Controls.Add(TypesCaptionLabel);
        Controls.Add(PokemonSpeciesDataGridView);
        Controls.Add(PokemonSpeciesCaptionLabel);
        Controls.Add(NamesCaptionLabel);
        Controls.Add(NamesDataGridView);
        Controls.Add(AbilitiesDataGridView);
        Controls.Add(AbilitiesCaptionLabel);
        Controls.Add(NameCaptionLabel);
        Controls.Add(IdCaptionLabel);
        Font = new Font("Meiryo UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 128);
        FormBorderStyle = FormBorderStyle.FixedSingle;
        Margin = new Padding(4, 3, 4, 3);
        MaximizeBox = false;
        Name = "GenerationInfoForm";
        StartPosition = FormStartPosition.CenterParent;
        Text = "世代";
        ((System.ComponentModel.ISupportInitialize)AbilitiesDataGridView).EndInit();
        ((System.ComponentModel.ISupportInitialize)NamesDataGridView).EndInit();
        ((System.ComponentModel.ISupportInitialize)PokemonSpeciesDataGridView).EndInit();
        ((System.ComponentModel.ISupportInitialize)TypesDataGridView).EndInit();
        ((System.ComponentModel.ISupportInitialize)VersionGroupDataGridView).EndInit();
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion
    private Label NameCaptionLabel;
    private Label IdCaptionLabel;
    private Label AbilitiesCaptionLabel;
    private DataGridView AbilitiesDataGridView;
    private DataGridView NamesDataGridView;
    private Label NamesCaptionLabel;
    private Label PokemonSpeciesCaptionLabel;
    private DataGridView PokemonSpeciesDataGridView;
    private Label TypesCaptionLabel;
    private DataGridView TypesDataGridView;
    private Label VersionGroupCaptionLabel;
    private DataGridView VersionGroupDataGridView;
    private Button CloseButton;
    private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
    private DataGridViewButtonColumn dataGridViewButtonColumn1;
    private DataGridViewTextBoxColumn NameColumn;
    private DataGridViewTextBoxColumn LanguageColumn;
    private DataGridViewButtonColumn DetailColumn;
    private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
    private DataGridViewButtonColumn dataGridViewButtonColumn2;
    private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
    private DataGridViewButtonColumn dataGridViewButtonColumn3;
    private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
    private DataGridViewButtonColumn dataGridViewButtonColumn4;
    private TextBox NameTextBox;
    private TextBox IdTextBox;
}