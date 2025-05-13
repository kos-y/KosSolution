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
        NameTextBox.Location = new Point(92, 42);
        NameTextBox.Name = "NameTextBox";
        NameTextBox.ReadOnly = true;
        NameTextBox.Size = new Size(183, 24);
        NameTextBox.TabIndex = 3;
        // 
        // IdTextBox
        // 
        IdTextBox.Location = new Point(92, 12);
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
        NameCaptionLabel.Size = new Size(72, 17);
        NameCaptionLabel.TabIndex = 2;
        NameCaptionLabel.Text = "性別の名前";
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
        IdCaptionLabel.Text = "性別ID";
        IdCaptionLabel.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // PokemonSpeciesDataGridView
        // 
        PokemonSpeciesDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        PokemonSpeciesDataGridView.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn2, dataGridViewButtonColumn2 });
        PokemonSpeciesDataGridView.Location = new Point(283, 29);
        PokemonSpeciesDataGridView.Margin = new Padding(4, 3, 4, 3);
        PokemonSpeciesDataGridView.Name = "PokemonSpeciesDataGridView";
        PokemonSpeciesDataGridView.RowHeadersVisible = false;
        PokemonSpeciesDataGridView.Size = new Size(191, 239);
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
        // PokemonSpeciesCaptionLabel
        // 
        PokemonSpeciesCaptionLabel.AutoSize = true;
        PokemonSpeciesCaptionLabel.Location = new Point(283, 9);
        PokemonSpeciesCaptionLabel.Margin = new Padding(4, 0, 4, 0);
        PokemonSpeciesCaptionLabel.Name = "PokemonSpeciesCaptionLabel";
        PokemonSpeciesCaptionLabel.Size = new Size(75, 17);
        PokemonSpeciesCaptionLabel.TabIndex = 6;
        PokemonSpeciesCaptionLabel.Text = "ポケモン種族";
        PokemonSpeciesCaptionLabel.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // RequiredForEvolutionDataGridView
        // 
        RequiredForEvolutionDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        RequiredForEvolutionDataGridView.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1, dataGridViewButtonColumn1 });
        RequiredForEvolutionDataGridView.Location = new Point(13, 98);
        RequiredForEvolutionDataGridView.Margin = new Padding(4, 3, 4, 3);
        RequiredForEvolutionDataGridView.Name = "RequiredForEvolutionDataGridView";
        RequiredForEvolutionDataGridView.RowHeadersVisible = false;
        RequiredForEvolutionDataGridView.Size = new Size(262, 170);
        RequiredForEvolutionDataGridView.TabIndex = 5;
        // 
        // dataGridViewTextBoxColumn1
        // 
        dataGridViewTextBoxColumn1.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
        dataGridViewTextBoxColumn1.DataPropertyName = "Name";
        dataGridViewTextBoxColumn1.HeaderText = "名前";
        dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
        dataGridViewTextBoxColumn1.ReadOnly = true;
        dataGridViewTextBoxColumn1.Width = 59;
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
        // RequiredForEvolutionCaptionLabel
        // 
        RequiredForEvolutionCaptionLabel.AutoSize = true;
        RequiredForEvolutionCaptionLabel.Location = new Point(13, 78);
        RequiredForEvolutionCaptionLabel.Margin = new Padding(4, 0, 4, 0);
        RequiredForEvolutionCaptionLabel.Name = "RequiredForEvolutionCaptionLabel";
        RequiredForEvolutionCaptionLabel.Size = new Size(129, 17);
        RequiredForEvolutionCaptionLabel.TabIndex = 4;
        RequiredForEvolutionCaptionLabel.Text = "性別が要求される進化";
        RequiredForEvolutionCaptionLabel.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // PropertyButton
        // 
        PropertyButton.Location = new Point(314, 274);
        PropertyButton.Margin = new Padding(4, 3, 4, 3);
        PropertyButton.Name = "PropertyButton";
        PropertyButton.Size = new Size(76, 35);
        PropertyButton.TabIndex = 8;
        PropertyButton.Text = "プロパティ";
        PropertyButton.UseVisualStyleBackColor = true;
        PropertyButton.Click += PropertyButton_Click;
        // 
        // CloseButton
        // 
        CloseButton.Location = new Point(398, 274);
        CloseButton.Margin = new Padding(4, 3, 4, 3);
        CloseButton.Name = "CloseButton";
        CloseButton.Size = new Size(76, 35);
        CloseButton.TabIndex = 9;
        CloseButton.Text = "閉じる";
        CloseButton.UseVisualStyleBackColor = true;
        CloseButton.Click += CloseButton_Click;
        // 
        // GenderInfoForm
        // 
        AutoScaleDimensions = new SizeF(9F, 17F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(487, 322);
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
        Font = new Font("Meiryo UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 128);
        FormBorderStyle = FormBorderStyle.FixedSingle;
        Margin = new Padding(4, 3, 4, 3);
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