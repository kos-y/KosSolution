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
        IsBabyLabel = new Label();
        SpeciesCaptionLabel = new Label();
        SpeciesLabel = new Label();
        SpeciesInfoButton = new Button();
        EvolutionDetailsCaptionLabel = new Label();
        EvolutionDetailsDataGridView = new DataGridView();
        EvolutionDetailColumn = new DataGridViewTextBoxColumn();
        DetailColumn = new DataGridViewButtonColumn();
        EvolvesToCaptionLabel = new Label();
        EvolvesToDataGridView = new DataGridView();
        dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
        dataGridViewButtonColumn1 = new DataGridViewButtonColumn();
        CloseButton = new Button();
        ((System.ComponentModel.ISupportInitialize)EvolutionDetailsDataGridView).BeginInit();
        ((System.ComponentModel.ISupportInitialize)EvolvesToDataGridView).BeginInit();
        SuspendLayout();
        // 
        // IsBabyCaptionLabel
        // 
        IsBabyCaptionLabel.Location = new Point(12, 9);
        IsBabyCaptionLabel.Name = "IsBabyCaptionLabel";
        IsBabyCaptionLabel.Size = new Size(104, 23);
        IsBabyCaptionLabel.TabIndex = 0;
        IsBabyCaptionLabel.Text = "is_baby";
        IsBabyCaptionLabel.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // IsBabyLabel
        // 
        IsBabyLabel.BorderStyle = BorderStyle.Fixed3D;
        IsBabyLabel.Location = new Point(122, 3);
        IsBabyLabel.Name = "IsBabyLabel";
        IsBabyLabel.Size = new Size(147, 23);
        IsBabyLabel.TabIndex = 1;
        IsBabyLabel.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // SpeciesCaptionLabel
        // 
        SpeciesCaptionLabel.Location = new Point(12, 32);
        SpeciesCaptionLabel.Name = "SpeciesCaptionLabel";
        SpeciesCaptionLabel.Size = new Size(104, 23);
        SpeciesCaptionLabel.TabIndex = 2;
        SpeciesCaptionLabel.Text = "species";
        SpeciesCaptionLabel.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // SpeciesLabel
        // 
        SpeciesLabel.BorderStyle = BorderStyle.Fixed3D;
        SpeciesLabel.Location = new Point(122, 26);
        SpeciesLabel.Name = "SpeciesLabel";
        SpeciesLabel.Size = new Size(147, 23);
        SpeciesLabel.TabIndex = 3;
        SpeciesLabel.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // SpeciesInfoButton
        // 
        SpeciesInfoButton.Location = new Point(275, 26);
        SpeciesInfoButton.Name = "SpeciesInfoButton";
        SpeciesInfoButton.Size = new Size(43, 23);
        SpeciesInfoButton.TabIndex = 4;
        SpeciesInfoButton.Text = "Info...";
        SpeciesInfoButton.UseVisualStyleBackColor = true;
        // 
        // EvolutionDetailsCaptionLabel
        // 
        EvolutionDetailsCaptionLabel.Location = new Point(12, 55);
        EvolutionDetailsCaptionLabel.Name = "EvolutionDetailsCaptionLabel";
        EvolutionDetailsCaptionLabel.Size = new Size(104, 23);
        EvolutionDetailsCaptionLabel.TabIndex = 5;
        EvolutionDetailsCaptionLabel.Text = "evolution_details";
        EvolutionDetailsCaptionLabel.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // EvolutionDetailsDataGridView
        // 
        EvolutionDetailsDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        EvolutionDetailsDataGridView.Columns.AddRange(new DataGridViewColumn[] { EvolutionDetailColumn, DetailColumn });
        EvolutionDetailsDataGridView.Location = new Point(122, 55);
        EvolutionDetailsDataGridView.Name = "EvolutionDetailsDataGridView";
        EvolutionDetailsDataGridView.RowHeadersVisible = false;
        EvolutionDetailsDataGridView.Size = new Size(434, 150);
        EvolutionDetailsDataGridView.TabIndex = 6;
        EvolutionDetailsDataGridView.CellClick += EvolutionDetailsDataGridView_CellClick;
        EvolutionDetailsDataGridView.CellDoubleClick += EvolutionDetailsDataGridView_CellDoubleClick;
        // 
        // EvolutionDetailColumn
        // 
        EvolutionDetailColumn.DataPropertyName = "Text";
        EvolutionDetailColumn.HeaderText = "detail";
        EvolutionDetailColumn.Name = "EvolutionDetailColumn";
        EvolutionDetailColumn.ReadOnly = true;
        EvolutionDetailColumn.Width = 250;
        // 
        // DetailColumn
        // 
        DetailColumn.HeaderText = "Info";
        DetailColumn.Name = "DetailColumn";
        DetailColumn.Text = "Info..";
        DetailColumn.UseColumnTextForButtonValue = true;
        // 
        // EvolvesToCaptionLabel
        // 
        EvolvesToCaptionLabel.Location = new Point(12, 214);
        EvolvesToCaptionLabel.Name = "EvolvesToCaptionLabel";
        EvolvesToCaptionLabel.Size = new Size(104, 23);
        EvolvesToCaptionLabel.TabIndex = 7;
        EvolvesToCaptionLabel.Text = "evolves_to";
        EvolvesToCaptionLabel.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // EvolvesToDataGridView
        // 
        EvolvesToDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        EvolvesToDataGridView.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1, dataGridViewButtonColumn1 });
        EvolvesToDataGridView.Location = new Point(122, 208);
        EvolvesToDataGridView.Name = "EvolvesToDataGridView";
        EvolvesToDataGridView.RowHeadersVisible = false;
        EvolvesToDataGridView.Size = new Size(434, 150);
        EvolvesToDataGridView.TabIndex = 8;
        EvolvesToDataGridView.CellClick += EvolvesToDataGridView_CellClick;
        EvolvesToDataGridView.CellDoubleClick += EvolvesToDataGridView_CellDoubleClick;
        // 
        // dataGridViewTextBoxColumn1
        // 
        dataGridViewTextBoxColumn1.DataPropertyName = "Text";
        dataGridViewTextBoxColumn1.HeaderText = "detail";
        dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
        dataGridViewTextBoxColumn1.ReadOnly = true;
        dataGridViewTextBoxColumn1.Width = 250;
        // 
        // dataGridViewButtonColumn1
        // 
        dataGridViewButtonColumn1.HeaderText = "Info";
        dataGridViewButtonColumn1.Name = "dataGridViewButtonColumn1";
        dataGridViewButtonColumn1.Text = "Info..";
        dataGridViewButtonColumn1.UseColumnTextForButtonValue = true;
        // 
        // CloseButton
        // 
        CloseButton.Location = new Point(481, 364);
        CloseButton.Name = "CloseButton";
        CloseButton.Size = new Size(75, 23);
        CloseButton.TabIndex = 9;
        CloseButton.Text = "Close";
        CloseButton.UseVisualStyleBackColor = true;
        CloseButton.Click += CloseButton_Click;
        // 
        // ChainLinkInfoForm
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(566, 393);
        Controls.Add(CloseButton);
        Controls.Add(EvolvesToDataGridView);
        Controls.Add(EvolvesToCaptionLabel);
        Controls.Add(EvolutionDetailsDataGridView);
        Controls.Add(EvolutionDetailsCaptionLabel);
        Controls.Add(SpeciesInfoButton);
        Controls.Add(SpeciesCaptionLabel);
        Controls.Add(SpeciesLabel);
        Controls.Add(IsBabyCaptionLabel);
        Controls.Add(IsBabyLabel);
        FormBorderStyle = FormBorderStyle.FixedSingle;
        MaximizeBox = false;
        Name = "ChainLinkInfoForm";
        Text = "Chain Link";
        ((System.ComponentModel.ISupportInitialize)EvolutionDetailsDataGridView).EndInit();
        ((System.ComponentModel.ISupportInitialize)EvolvesToDataGridView).EndInit();
        ResumeLayout(false);
    }

    #endregion

    private Label IsBabyCaptionLabel;
    private Label IsBabyLabel;
    private Label SpeciesCaptionLabel;
    private Label SpeciesLabel;
    private Button SpeciesInfoButton;
    private Label EvolutionDetailsCaptionLabel;
    private DataGridView EvolutionDetailsDataGridView;
    private Label EvolvesToCaptionLabel;
    private DataGridView EvolvesToDataGridView;
    private Button CloseButton;
    private DataGridViewTextBoxColumn EvolutionDetailColumn;
    private DataGridViewButtonColumn DetailColumn;
    private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
    private DataGridViewButtonColumn dataGridViewButtonColumn1;
}