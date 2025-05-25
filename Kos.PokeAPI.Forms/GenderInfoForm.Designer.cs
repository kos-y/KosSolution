namespace Kos.PokeAPI.Forms;

partial class GenderInfoForm
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
        PokemonSpeciesDataGridView = new DataGridView();
        dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
        dataGridViewButtonColumn2 = new DataGridViewButtonColumn();
        PokemonSpeciesCaptionLabel = new Label();
        RequiredForEvolutionDataGridView = new DataGridView();
        dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
        dataGridViewButtonColumn1 = new DataGridViewButtonColumn();
        RequiredForEvolutionCaptionLabel = new Label();
        PropertyButton = new Button();
        CloseButton = new Button();
        ((System.ComponentModel.ISupportInitialize)PokemonSpeciesDataGridView).BeginInit();
        ((System.ComponentModel.ISupportInitialize)RequiredForEvolutionDataGridView).BeginInit();
        SuspendLayout();
        // 
        // NameTextBox
        // 
        NameTextBox.Location = new Point(82, 41);
        NameTextBox.Margin = new Padding(2, 3, 2, 3);
        NameTextBox.Name = "NameTextBox";
        NameTextBox.ReadOnly = true;
        NameTextBox.Size = new Size(143, 23);
        NameTextBox.TabIndex = 3;
        // 
        // IdTextBox
        // 
        IdTextBox.Location = new Point(82, 12);
        IdTextBox.Margin = new Padding(2, 3, 2, 3);
        IdTextBox.Name = "IdTextBox";
        IdTextBox.ReadOnly = true;
        IdTextBox.Size = new Size(143, 23);
        IdTextBox.TabIndex = 1;
        // 
        // NameCaptionLabel
        // 
        NameCaptionLabel.AutoSize = true;
        NameCaptionLabel.Location = new Point(12, 44);
        NameCaptionLabel.Name = "NameCaptionLabel";
        NameCaptionLabel.Size = new Size(65, 15);
        NameCaptionLabel.TabIndex = 2;
        NameCaptionLabel.Text = "性別の名前";
        NameCaptionLabel.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // IdCaptionLabel
        // 
        IdCaptionLabel.AutoSize = true;
        IdCaptionLabel.Location = new Point(35, 15);
        IdCaptionLabel.Name = "IdCaptionLabel";
        IdCaptionLabel.Size = new Size(42, 15);
        IdCaptionLabel.TabIndex = 0;
        IdCaptionLabel.Text = "性別ID";
        IdCaptionLabel.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // PokemonSpeciesDataGridView
        // 
        PokemonSpeciesDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        PokemonSpeciesDataGridView.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn2, dataGridViewButtonColumn2 });
        PokemonSpeciesDataGridView.Location = new Point(240, 30);
        PokemonSpeciesDataGridView.Name = "PokemonSpeciesDataGridView";
        PokemonSpeciesDataGridView.RowHeadersVisible = false;
        PokemonSpeciesDataGridView.Size = new Size(149, 215);
        PokemonSpeciesDataGridView.TabIndex = 7;
        PokemonSpeciesDataGridView.CellClick += PokemonSpeciesDataGridView_CellClick;
        PokemonSpeciesDataGridView.CellDoubleClick += PokemonSpeciesDataGridView_CellDoubleClick;
        // 
        // dataGridViewTextBoxColumn2
        // 
        dataGridViewTextBoxColumn2.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
        dataGridViewTextBoxColumn2.DataPropertyName = "PokemonSpecies";
        dataGridViewTextBoxColumn2.HeaderText = "ポケモン種族";
        dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
        dataGridViewTextBoxColumn2.ReadOnly = true;
        dataGridViewTextBoxColumn2.Width = 93;
        // 
        // dataGridViewButtonColumn2
        // 
        dataGridViewButtonColumn2.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
        dataGridViewButtonColumn2.HeaderText = "詳細";
        dataGridViewButtonColumn2.Name = "dataGridViewButtonColumn2";
        dataGridViewButtonColumn2.Text = "詳細";
        dataGridViewButtonColumn2.UseColumnTextForButtonValue = true;
        dataGridViewButtonColumn2.Width = 37;
        // 
        // PokemonSpeciesCaptionLabel
        // 
        PokemonSpeciesCaptionLabel.AutoSize = true;
        PokemonSpeciesCaptionLabel.Location = new Point(240, 12);
        PokemonSpeciesCaptionLabel.Name = "PokemonSpeciesCaptionLabel";
        PokemonSpeciesCaptionLabel.Size = new Size(68, 15);
        PokemonSpeciesCaptionLabel.TabIndex = 6;
        PokemonSpeciesCaptionLabel.Text = "ポケモン種族";
        PokemonSpeciesCaptionLabel.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // RequiredForEvolutionDataGridView
        // 
        RequiredForEvolutionDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        RequiredForEvolutionDataGridView.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1, dataGridViewButtonColumn1 });
        RequiredForEvolutionDataGridView.Location = new Point(12, 95);
        RequiredForEvolutionDataGridView.Name = "RequiredForEvolutionDataGridView";
        RequiredForEvolutionDataGridView.RowHeadersVisible = false;
        RequiredForEvolutionDataGridView.Size = new Size(204, 150);
        RequiredForEvolutionDataGridView.TabIndex = 5;
        // 
        // dataGridViewTextBoxColumn1
        // 
        dataGridViewTextBoxColumn1.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
        dataGridViewTextBoxColumn1.DataPropertyName = "Name";
        dataGridViewTextBoxColumn1.HeaderText = "名前";
        dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
        dataGridViewTextBoxColumn1.ReadOnly = true;
        dataGridViewTextBoxColumn1.Width = 56;
        // 
        // dataGridViewButtonColumn1
        // 
        dataGridViewButtonColumn1.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
        dataGridViewButtonColumn1.HeaderText = "詳細";
        dataGridViewButtonColumn1.Name = "dataGridViewButtonColumn1";
        dataGridViewButtonColumn1.Text = "詳細";
        dataGridViewButtonColumn1.UseColumnTextForButtonValue = true;
        dataGridViewButtonColumn1.Width = 37;
        // 
        // RequiredForEvolutionCaptionLabel
        // 
        RequiredForEvolutionCaptionLabel.AutoSize = true;
        RequiredForEvolutionCaptionLabel.Location = new Point(12, 77);
        RequiredForEvolutionCaptionLabel.Name = "RequiredForEvolutionCaptionLabel";
        RequiredForEvolutionCaptionLabel.Size = new Size(117, 15);
        RequiredForEvolutionCaptionLabel.TabIndex = 4;
        RequiredForEvolutionCaptionLabel.Text = "性別が要求される進化";
        RequiredForEvolutionCaptionLabel.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // PropertyButton
        // 
        PropertyButton.Location = new Point(264, 251);
        PropertyButton.Name = "PropertyButton";
        PropertyButton.Size = new Size(59, 31);
        PropertyButton.TabIndex = 8;
        PropertyButton.Text = "プロパティ";
        PropertyButton.UseVisualStyleBackColor = true;
        PropertyButton.Click += PropertyButton_Click;
        // 
        // CloseButton
        // 
        CloseButton.Location = new Point(330, 251);
        CloseButton.Name = "CloseButton";
        CloseButton.Size = new Size(59, 31);
        CloseButton.TabIndex = 9;
        CloseButton.Text = "閉じる";
        CloseButton.UseVisualStyleBackColor = true;
        CloseButton.Click += CloseButton_Click;
        // 
        // GenderInfoForm
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(406, 295);
        Controls.Add(PropertyButton);
        Controls.Add(CloseButton);
        Controls.Add(RequiredForEvolutionDataGridView);
        Controls.Add(RequiredForEvolutionCaptionLabel);
        Controls.Add(PokemonSpeciesDataGridView);
        Controls.Add(PokemonSpeciesCaptionLabel);
        Controls.Add(NameTextBox);
        Controls.Add(IdTextBox);
        Controls.Add(NameCaptionLabel);
        Controls.Add(IdCaptionLabel);
        FormBorderStyle = FormBorderStyle.FixedSingle;
        MaximizeBox = false;
        Name = "GenderInfoForm";
        StartPosition = FormStartPosition.CenterParent;
        Text = "性別";
        ((System.ComponentModel.ISupportInitialize)PokemonSpeciesDataGridView).EndInit();
        ((System.ComponentModel.ISupportInitialize)RequiredForEvolutionDataGridView).EndInit();
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private TextBox NameTextBox;
    private TextBox IdTextBox;
    private Label NameCaptionLabel;
    private Label IdCaptionLabel;
    private DataGridView PokemonSpeciesDataGridView;
    private Label PokemonSpeciesCaptionLabel;
    private DataGridView RequiredForEvolutionDataGridView;
    private Label RequiredForEvolutionCaptionLabel;
    private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
    private DataGridViewButtonColumn dataGridViewButtonColumn1;
    private Button PropertyButton;
    private Button CloseButton;
    private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
    private DataGridViewButtonColumn dataGridViewButtonColumn2;
}