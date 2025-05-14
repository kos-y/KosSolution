namespace Kos.PokeAPI.Forms;

partial class GrowthRateInfoForm
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
        FormulaCaptionLabel = new Label();
        FormulaTextBox = new TextBox();
        DescriptionsDataGridView = new DataGridView();
        DescriptionColumn = new DataGridViewTextBoxColumn();
        dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
        dataGridViewButtonColumn2 = new DataGridViewButtonColumn();
        DescriptionsCaptionLabel = new Label();
        LevelsDataGridView = new DataGridView();
        dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
        dataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
        PokemonSpeciesDataGridView = new DataGridView();
        dataGridViewTextBoxColumn4 = new DataGridViewTextBoxColumn();
        dataGridViewButtonColumn3 = new DataGridViewButtonColumn();
        PokemonSpeciesCaptionLabel = new Label();
        LevelsCaptionLabel = new Label();
        PropertyButton = new Button();
        CloseButton = new Button();
        ((System.ComponentModel.ISupportInitialize)DescriptionsDataGridView).BeginInit();
        ((System.ComponentModel.ISupportInitialize)LevelsDataGridView).BeginInit();
        ((System.ComponentModel.ISupportInitialize)PokemonSpeciesDataGridView).BeginInit();
        SuspendLayout();
        // 
        // NameTextBox
        // 
        NameTextBox.Location = new Point(144, 42);
        NameTextBox.Name = "NameTextBox";
        NameTextBox.ReadOnly = true;
        NameTextBox.Size = new Size(183, 24);
        NameTextBox.TabIndex = 3;
        // 
        // IdTextBox
        // 
        IdTextBox.Location = new Point(144, 12);
        IdTextBox.Name = "IdTextBox";
        IdTextBox.ReadOnly = true;
        IdTextBox.Size = new Size(183, 24);
        IdTextBox.TabIndex = 1;
        // 
        // NameCaptionLabel
        // 
        NameCaptionLabel.AutoSize = true;
        NameCaptionLabel.Location = new Point(13, 45);
        NameCaptionLabel.Margin = new Padding(4, 0, 4, 0);
        NameCaptionLabel.Name = "NameCaptionLabel";
        NameCaptionLabel.Size = new Size(124, 17);
        NameCaptionLabel.TabIndex = 2;
        NameCaptionLabel.Text = "経験値増加量の名前";
        NameCaptionLabel.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // IdCaptionLabel
        // 
        IdCaptionLabel.AutoSize = true;
        IdCaptionLabel.Location = new Point(34, 15);
        IdCaptionLabel.Margin = new Padding(4, 0, 4, 0);
        IdCaptionLabel.Name = "IdCaptionLabel";
        IdCaptionLabel.Size = new Size(103, 17);
        IdCaptionLabel.TabIndex = 0;
        IdCaptionLabel.Text = "経験値増加量ID";
        IdCaptionLabel.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // FormulaCaptionLabel
        // 
        FormulaCaptionLabel.AutoSize = true;
        FormulaCaptionLabel.Location = new Point(77, 75);
        FormulaCaptionLabel.Margin = new Padding(4, 0, 4, 0);
        FormulaCaptionLabel.Name = "FormulaCaptionLabel";
        FormulaCaptionLabel.Size = new Size(60, 17);
        FormulaCaptionLabel.TabIndex = 4;
        FormulaCaptionLabel.Text = "計算種別";
        FormulaCaptionLabel.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // FormulaTextBox
        // 
        FormulaTextBox.Location = new Point(144, 72);
        FormulaTextBox.Name = "FormulaTextBox";
        FormulaTextBox.ReadOnly = true;
        FormulaTextBox.Size = new Size(183, 24);
        FormulaTextBox.TabIndex = 5;
        // 
        // DescriptionsDataGridView
        // 
        DescriptionsDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        DescriptionsDataGridView.Columns.AddRange(new DataGridViewColumn[] { DescriptionColumn, dataGridViewTextBoxColumn2, dataGridViewButtonColumn2 });
        DescriptionsDataGridView.Location = new Point(13, 226);
        DescriptionsDataGridView.Margin = new Padding(4, 3, 4, 3);
        DescriptionsDataGridView.Name = "DescriptionsDataGridView";
        DescriptionsDataGridView.RowHeadersVisible = false;
        DescriptionsDataGridView.Size = new Size(314, 170);
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
        // dataGridViewTextBoxColumn2
        // 
        dataGridViewTextBoxColumn2.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
        dataGridViewTextBoxColumn2.DataPropertyName = "Language";
        dataGridViewTextBoxColumn2.HeaderText = "言語";
        dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
        dataGridViewTextBoxColumn2.ReadOnly = true;
        dataGridViewTextBoxColumn2.Width = 59;
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
        // DescriptionsCaptionLabel
        // 
        DescriptionsCaptionLabel.AutoSize = true;
        DescriptionsCaptionLabel.Location = new Point(13, 203);
        DescriptionsCaptionLabel.Margin = new Padding(4, 0, 4, 0);
        DescriptionsCaptionLabel.Name = "DescriptionsCaptionLabel";
        DescriptionsCaptionLabel.Size = new Size(92, 17);
        DescriptionsCaptionLabel.TabIndex = 8;
        DescriptionsCaptionLabel.Text = "言語ごとの説明";
        DescriptionsCaptionLabel.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // LevelsDataGridView
        // 
        LevelsDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        LevelsDataGridView.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1, dataGridViewTextBoxColumn3 });
        LevelsDataGridView.Location = new Point(334, 29);
        LevelsDataGridView.Margin = new Padding(4, 3, 4, 3);
        LevelsDataGridView.Name = "LevelsDataGridView";
        LevelsDataGridView.RowHeadersVisible = false;
        LevelsDataGridView.Size = new Size(278, 170);
        LevelsDataGridView.TabIndex = 7;
        // 
        // dataGridViewTextBoxColumn1
        // 
        dataGridViewTextBoxColumn1.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
        dataGridViewTextBoxColumn1.DataPropertyName = "Level";
        dataGridViewTextBoxColumn1.HeaderText = "レベル";
        dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
        dataGridViewTextBoxColumn1.ReadOnly = true;
        dataGridViewTextBoxColumn1.Width = 65;
        // 
        // dataGridViewTextBoxColumn3
        // 
        dataGridViewTextBoxColumn3.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
        dataGridViewTextBoxColumn3.DataPropertyName = "Experience";
        dataGridViewTextBoxColumn3.HeaderText = "経験値";
        dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
        dataGridViewTextBoxColumn3.ReadOnly = true;
        dataGridViewTextBoxColumn3.Width = 72;
        // 
        // PokemonSpeciesDataGridView
        // 
        PokemonSpeciesDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        PokemonSpeciesDataGridView.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn4, dataGridViewButtonColumn3 });
        PokemonSpeciesDataGridView.Location = new Point(335, 226);
        PokemonSpeciesDataGridView.Margin = new Padding(4, 3, 4, 3);
        PokemonSpeciesDataGridView.Name = "PokemonSpeciesDataGridView";
        PokemonSpeciesDataGridView.RowHeadersVisible = false;
        PokemonSpeciesDataGridView.Size = new Size(277, 170);
        PokemonSpeciesDataGridView.TabIndex = 11;
        PokemonSpeciesDataGridView.CellClick += PokemonSpeciesDataGridView_CellClick;
        // 
        // dataGridViewTextBoxColumn4
        // 
        dataGridViewTextBoxColumn4.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
        dataGridViewTextBoxColumn4.DataPropertyName = "Name";
        dataGridViewTextBoxColumn4.HeaderText = "ポケモン種族";
        dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
        dataGridViewTextBoxColumn4.ReadOnly = true;
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
        // PokemonSpeciesCaptionLabel
        // 
        PokemonSpeciesCaptionLabel.AutoSize = true;
        PokemonSpeciesCaptionLabel.Location = new Point(335, 206);
        PokemonSpeciesCaptionLabel.Margin = new Padding(4, 0, 4, 0);
        PokemonSpeciesCaptionLabel.Name = "PokemonSpeciesCaptionLabel";
        PokemonSpeciesCaptionLabel.Size = new Size(75, 17);
        PokemonSpeciesCaptionLabel.TabIndex = 10;
        PokemonSpeciesCaptionLabel.Text = "ポケモン種族";
        PokemonSpeciesCaptionLabel.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // LevelsCaptionLabel
        // 
        LevelsCaptionLabel.AutoSize = true;
        LevelsCaptionLabel.Location = new Point(334, 9);
        LevelsCaptionLabel.Margin = new Padding(4, 0, 4, 0);
        LevelsCaptionLabel.Name = "LevelsCaptionLabel";
        LevelsCaptionLabel.Size = new Size(137, 17);
        LevelsCaptionLabel.TabIndex = 6;
        LevelsCaptionLabel.Text = "レベルごとの必要経験値";
        LevelsCaptionLabel.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // PropertyButton
        // 
        PropertyButton.Location = new Point(452, 402);
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
        CloseButton.Location = new Point(536, 402);
        CloseButton.Margin = new Padding(4, 3, 4, 3);
        CloseButton.Name = "CloseButton";
        CloseButton.Size = new Size(76, 35);
        CloseButton.TabIndex = 13;
        CloseButton.Text = "閉じる";
        CloseButton.UseVisualStyleBackColor = true;
        CloseButton.Click += CloseButton_Click;
        // 
        // GrowthRateInfoForm
        // 
        AutoScaleDimensions = new SizeF(9F, 17F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(629, 447);
        Controls.Add(PropertyButton);
        Controls.Add(CloseButton);
        Controls.Add(LevelsCaptionLabel);
        Controls.Add(PokemonSpeciesDataGridView);
        Controls.Add(PokemonSpeciesCaptionLabel);
        Controls.Add(LevelsDataGridView);
        Controls.Add(DescriptionsDataGridView);
        Controls.Add(DescriptionsCaptionLabel);
        Controls.Add(FormulaTextBox);
        Controls.Add(FormulaCaptionLabel);
        Controls.Add(NameTextBox);
        Controls.Add(IdTextBox);
        Controls.Add(NameCaptionLabel);
        Controls.Add(IdCaptionLabel);
        Font = new Font("Meiryo UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 128);
        FormBorderStyle = FormBorderStyle.FixedSingle;
        Margin = new Padding(4, 3, 4, 3);
        MaximizeBox = false;
        Name = "GrowthRateInfoForm";
        StartPosition = FormStartPosition.CenterParent;
        Text = "レベルアップに必要な経験値の増加量";
        ((System.ComponentModel.ISupportInitialize)DescriptionsDataGridView).EndInit();
        ((System.ComponentModel.ISupportInitialize)LevelsDataGridView).EndInit();
        ((System.ComponentModel.ISupportInitialize)PokemonSpeciesDataGridView).EndInit();
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private TextBox NameTextBox;
    private TextBox IdTextBox;
    private Label NameCaptionLabel;
    private Label IdCaptionLabel;
    private Label FormulaCaptionLabel;
    private TextBox FormulaTextBox;
    private DataGridView DescriptionsDataGridView;
    private DataGridViewTextBoxColumn DescriptionColumn;
    private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
    private DataGridViewButtonColumn dataGridViewButtonColumn2;
    private Label DescriptionsCaptionLabel;
    private DataGridView LevelsDataGridView;
    private DataGridView PokemonSpeciesDataGridView;
    private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
    private DataGridViewButtonColumn dataGridViewButtonColumn3;
    private Label PokemonSpeciesCaptionLabel;
    private Label LevelsCaptionLabel;
    private Button PropertyButton;
    private Button CloseButton;
    private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
    private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
}