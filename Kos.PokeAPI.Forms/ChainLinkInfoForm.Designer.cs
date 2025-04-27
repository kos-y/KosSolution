namespace Kos.PokeAPI.Forms;

partial class ChainLinkInfoForm
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
        IsBabyCaptionLabel = new Label();
        SpeciesCaptionLabel = new Label();
        SpeciesDetailButton = new Button();
        EvolutionDetailsCaptionLabel = new Label();
        EvolutionDetailsDataGridView = new DataGridView();
        EvolutionDetailColumn = new DataGridViewTextBoxColumn();
        DetailColumn = new DataGridViewButtonColumn();
        EvolvesToCaptionLabel = new Label();
        EvolvesToDataGridView = new DataGridView();
        dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
        dataGridViewButtonColumn1 = new DataGridViewButtonColumn();
        CloseButton = new Button();
        IsBabyTextBox = new TextBox();
        SpeciesTextBox = new TextBox();
        ((System.ComponentModel.ISupportInitialize)EvolutionDetailsDataGridView).BeginInit();
        ((System.ComponentModel.ISupportInitialize)EvolvesToDataGridView).BeginInit();
        SuspendLayout();
        // 
        // IsBabyCaptionLabel
        // 
        IsBabyCaptionLabel.AutoSize = true;
        IsBabyCaptionLabel.Location = new Point(15, 10);
        IsBabyCaptionLabel.Margin = new Padding(4, 0, 4, 0);
        IsBabyCaptionLabel.Name = "IsBabyCaptionLabel";
        IsBabyCaptionLabel.Size = new Size(81, 17);
        IsBabyCaptionLabel.TabIndex = 0;
        IsBabyCaptionLabel.Text = "ベビーポケモン";
        IsBabyCaptionLabel.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // SpeciesCaptionLabel
        // 
        SpeciesCaptionLabel.AutoSize = true;
        SpeciesCaptionLabel.Location = new Point(21, 36);
        SpeciesCaptionLabel.Margin = new Padding(4, 0, 4, 0);
        SpeciesCaptionLabel.Name = "SpeciesCaptionLabel";
        SpeciesCaptionLabel.Size = new Size(75, 17);
        SpeciesCaptionLabel.TabIndex = 2;
        SpeciesCaptionLabel.Text = "ポケモン種族";
        SpeciesCaptionLabel.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // SpeciesDetailButton
        // 
        SpeciesDetailButton.Location = new Point(301, 31);
        SpeciesDetailButton.Margin = new Padding(4, 3, 4, 3);
        SpeciesDetailButton.Name = "SpeciesDetailButton";
        SpeciesDetailButton.Size = new Size(55, 26);
        SpeciesDetailButton.TabIndex = 4;
        SpeciesDetailButton.Text = "詳細";
        SpeciesDetailButton.UseVisualStyleBackColor = true;
        // 
        // EvolutionDetailsCaptionLabel
        // 
        EvolutionDetailsCaptionLabel.AutoSize = true;
        EvolutionDetailsCaptionLabel.Location = new Point(36, 64);
        EvolutionDetailsCaptionLabel.Margin = new Padding(4, 0, 4, 0);
        EvolutionDetailsCaptionLabel.Name = "EvolutionDetailsCaptionLabel";
        EvolutionDetailsCaptionLabel.Size = new Size(60, 17);
        EvolutionDetailsCaptionLabel.TabIndex = 5;
        EvolutionDetailsCaptionLabel.Text = "進化詳細";
        EvolutionDetailsCaptionLabel.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // EvolutionDetailsDataGridView
        // 
        EvolutionDetailsDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        EvolutionDetailsDataGridView.Columns.AddRange(new DataGridViewColumn[] { EvolutionDetailColumn, DetailColumn });
        EvolutionDetailsDataGridView.Location = new Point(104, 64);
        EvolutionDetailsDataGridView.Margin = new Padding(4, 3, 4, 3);
        EvolutionDetailsDataGridView.Name = "EvolutionDetailsDataGridView";
        EvolutionDetailsDataGridView.RowHeadersVisible = false;
        EvolutionDetailsDataGridView.Size = new Size(558, 170);
        EvolutionDetailsDataGridView.TabIndex = 6;
        EvolutionDetailsDataGridView.CellClick += EvolutionDetailsDataGridView_CellClick;
        EvolutionDetailsDataGridView.CellDoubleClick += EvolutionDetailsDataGridView_CellDoubleClick;
        // 
        // EvolutionDetailColumn
        // 
        EvolutionDetailColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
        EvolutionDetailColumn.DataPropertyName = "Text";
        EvolutionDetailColumn.HeaderText = "進化詳細";
        EvolutionDetailColumn.Name = "EvolutionDetailColumn";
        EvolutionDetailColumn.ReadOnly = true;
        EvolutionDetailColumn.Width = 85;
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
        // EvolvesToCaptionLabel
        // 
        EvolvesToCaptionLabel.AutoSize = true;
        EvolvesToCaptionLabel.Location = new Point(49, 238);
        EvolvesToCaptionLabel.Margin = new Padding(4, 0, 4, 0);
        EvolvesToCaptionLabel.Name = "EvolvesToCaptionLabel";
        EvolvesToCaptionLabel.Size = new Size(47, 17);
        EvolvesToCaptionLabel.TabIndex = 7;
        EvolvesToCaptionLabel.Text = "進化先";
        EvolvesToCaptionLabel.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // EvolvesToDataGridView
        // 
        EvolvesToDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        EvolvesToDataGridView.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1, dataGridViewButtonColumn1 });
        EvolvesToDataGridView.Location = new Point(104, 238);
        EvolvesToDataGridView.Margin = new Padding(4, 3, 4, 3);
        EvolvesToDataGridView.Name = "EvolvesToDataGridView";
        EvolvesToDataGridView.RowHeadersVisible = false;
        EvolvesToDataGridView.Size = new Size(558, 170);
        EvolvesToDataGridView.TabIndex = 8;
        EvolvesToDataGridView.CellClick += EvolvesToDataGridView_CellClick;
        EvolvesToDataGridView.CellDoubleClick += EvolvesToDataGridView_CellDoubleClick;
        // 
        // dataGridViewTextBoxColumn1
        // 
        dataGridViewTextBoxColumn1.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
        dataGridViewTextBoxColumn1.DataPropertyName = "Text";
        dataGridViewTextBoxColumn1.HeaderText = "進化先";
        dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
        dataGridViewTextBoxColumn1.ReadOnly = true;
        dataGridViewTextBoxColumn1.Width = 72;
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
        // CloseButton
        // 
        CloseButton.Location = new Point(596, 414);
        CloseButton.Margin = new Padding(4, 3, 4, 3);
        CloseButton.Name = "CloseButton";
        CloseButton.Size = new Size(66, 37);
        CloseButton.TabIndex = 9;
        CloseButton.Text = "閉じる";
        CloseButton.UseVisualStyleBackColor = true;
        CloseButton.Click += CloseButton_Click;
        // 
        // IsBabyTextBox
        // 
        IsBabyTextBox.Location = new Point(104, 7);
        IsBabyTextBox.Name = "IsBabyTextBox";
        IsBabyTextBox.ReadOnly = true;
        IsBabyTextBox.Size = new Size(190, 24);
        IsBabyTextBox.TabIndex = 1;
        // 
        // SpeciesTextBox
        // 
        SpeciesTextBox.Location = new Point(103, 33);
        SpeciesTextBox.Name = "SpeciesTextBox";
        SpeciesTextBox.ReadOnly = true;
        SpeciesTextBox.Size = new Size(190, 24);
        SpeciesTextBox.TabIndex = 3;
        // 
        // ChainLinkInfoForm
        // 
        AutoScaleDimensions = new SizeF(9F, 17F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(679, 463);
        Controls.Add(SpeciesTextBox);
        Controls.Add(IsBabyTextBox);
        Controls.Add(CloseButton);
        Controls.Add(EvolvesToDataGridView);
        Controls.Add(EvolvesToCaptionLabel);
        Controls.Add(EvolutionDetailsDataGridView);
        Controls.Add(EvolutionDetailsCaptionLabel);
        Controls.Add(SpeciesDetailButton);
        Controls.Add(SpeciesCaptionLabel);
        Controls.Add(IsBabyCaptionLabel);
        Font = new Font("Meiryo UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 128);
        FormBorderStyle = FormBorderStyle.FixedSingle;
        Margin = new Padding(4, 3, 4, 3);
        MaximizeBox = false;
        Name = "ChainLinkInfoForm";
        StartPosition = FormStartPosition.CenterParent;
        Text = "進化チェーンリンク";
        ((System.ComponentModel.ISupportInitialize)EvolutionDetailsDataGridView).EndInit();
        ((System.ComponentModel.ISupportInitialize)EvolvesToDataGridView).EndInit();
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private Label IsBabyCaptionLabel;
    private Label SpeciesCaptionLabel;
    private Button SpeciesDetailButton;
    private Label EvolutionDetailsCaptionLabel;
    private DataGridView EvolutionDetailsDataGridView;
    private Label EvolvesToCaptionLabel;
    private DataGridView EvolvesToDataGridView;
    private Button CloseButton;
    private DataGridViewTextBoxColumn EvolutionDetailColumn;
    private DataGridViewButtonColumn DetailColumn;
    private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
    private DataGridViewButtonColumn dataGridViewButtonColumn1;
    private TextBox IsBabyTextBox;
    private TextBox SpeciesTextBox;
}