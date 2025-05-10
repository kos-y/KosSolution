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
        SpeciesButton = new Button();
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
        PropertyButton = new Button();
        ((System.ComponentModel.ISupportInitialize)EvolutionDetailsDataGridView).BeginInit();
        ((System.ComponentModel.ISupportInitialize)EvolvesToDataGridView).BeginInit();
        SuspendLayout();
        // 
        // IsBabyCaptionLabel
        // 
        IsBabyCaptionLabel.AutoSize = true;
        IsBabyCaptionLabel.Location = new Point(13, 9);
        IsBabyCaptionLabel.Margin = new Padding(4, 0, 4, 0);
        IsBabyCaptionLabel.Name = "IsBabyCaptionLabel";
        IsBabyCaptionLabel.Size = new Size(81, 17);
        IsBabyCaptionLabel.TabIndex = 0;
        IsBabyCaptionLabel.Text = "ベビーポケモン";
        IsBabyCaptionLabel.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // SpeciesButton
        // 
        SpeciesButton.Location = new Point(9, 35);
        SpeciesButton.Margin = new Padding(4, 3, 4, 3);
        SpeciesButton.Name = "SpeciesButton";
        SpeciesButton.Size = new Size(87, 26);
        SpeciesButton.TabIndex = 2;
        SpeciesButton.Text = "ポケモン種族";
        SpeciesButton.UseVisualStyleBackColor = true;
        // 
        // EvolutionDetailsCaptionLabel
        // 
        EvolutionDetailsCaptionLabel.AutoSize = true;
        EvolutionDetailsCaptionLabel.Location = new Point(9, 64);
        EvolutionDetailsCaptionLabel.Margin = new Padding(4, 0, 4, 0);
        EvolutionDetailsCaptionLabel.Name = "EvolutionDetailsCaptionLabel";
        EvolutionDetailsCaptionLabel.Size = new Size(60, 17);
        EvolutionDetailsCaptionLabel.TabIndex = 4;
        EvolutionDetailsCaptionLabel.Text = "進化詳細";
        EvolutionDetailsCaptionLabel.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // EvolutionDetailsDataGridView
        // 
        EvolutionDetailsDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        EvolutionDetailsDataGridView.Columns.AddRange(new DataGridViewColumn[] { EvolutionDetailColumn, DetailColumn });
        EvolutionDetailsDataGridView.Location = new Point(13, 84);
        EvolutionDetailsDataGridView.Margin = new Padding(4, 3, 4, 3);
        EvolutionDetailsDataGridView.Name = "EvolutionDetailsDataGridView";
        EvolutionDetailsDataGridView.RowHeadersVisible = false;
        EvolutionDetailsDataGridView.Size = new Size(558, 170);
        EvolutionDetailsDataGridView.TabIndex = 5;
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
        EvolvesToCaptionLabel.Location = new Point(13, 257);
        EvolvesToCaptionLabel.Margin = new Padding(4, 0, 4, 0);
        EvolvesToCaptionLabel.Name = "EvolvesToCaptionLabel";
        EvolvesToCaptionLabel.Size = new Size(47, 17);
        EvolvesToCaptionLabel.TabIndex = 6;
        EvolvesToCaptionLabel.Text = "進化先";
        EvolvesToCaptionLabel.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // EvolvesToDataGridView
        // 
        EvolvesToDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        EvolvesToDataGridView.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1, dataGridViewButtonColumn1 });
        EvolvesToDataGridView.Location = new Point(13, 277);
        EvolvesToDataGridView.Margin = new Padding(4, 3, 4, 3);
        EvolvesToDataGridView.Name = "EvolvesToDataGridView";
        EvolvesToDataGridView.RowHeadersVisible = false;
        EvolvesToDataGridView.Size = new Size(558, 170);
        EvolvesToDataGridView.TabIndex = 7;
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
        CloseButton.Location = new Point(495, 453);
        CloseButton.Margin = new Padding(4, 3, 4, 3);
        CloseButton.Name = "CloseButton";
        CloseButton.Size = new Size(76, 35);
        CloseButton.TabIndex = 9;
        CloseButton.Text = "閉じる";
        CloseButton.UseVisualStyleBackColor = true;
        CloseButton.Click += CloseButton_Click;
        // 
        // IsBabyTextBox
        // 
        IsBabyTextBox.Location = new Point(101, 7);
        IsBabyTextBox.Name = "IsBabyTextBox";
        IsBabyTextBox.ReadOnly = true;
        IsBabyTextBox.Size = new Size(190, 24);
        IsBabyTextBox.TabIndex = 1;
        // 
        // SpeciesTextBox
        // 
        SpeciesTextBox.Location = new Point(103, 37);
        SpeciesTextBox.Name = "SpeciesTextBox";
        SpeciesTextBox.ReadOnly = true;
        SpeciesTextBox.Size = new Size(190, 24);
        SpeciesTextBox.TabIndex = 3;
        // 
        // PropertyButton
        // 
        PropertyButton.Location = new Point(411, 453);
        PropertyButton.Margin = new Padding(4, 3, 4, 3);
        PropertyButton.Name = "PropertyButton";
        PropertyButton.Size = new Size(76, 35);
        PropertyButton.TabIndex = 8;
        PropertyButton.Text = "プロパティ";
        PropertyButton.UseVisualStyleBackColor = true;
        PropertyButton.Click += PropertyButton_Click;
        // 
        // ChainLinkInfoForm
        // 
        AutoScaleDimensions = new SizeF(9F, 17F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(590, 501);
        Controls.Add(PropertyButton);
        Controls.Add(SpeciesTextBox);
        Controls.Add(IsBabyTextBox);
        Controls.Add(CloseButton);
        Controls.Add(EvolvesToDataGridView);
        Controls.Add(EvolvesToCaptionLabel);
        Controls.Add(EvolutionDetailsDataGridView);
        Controls.Add(EvolutionDetailsCaptionLabel);
        Controls.Add(SpeciesButton);
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
    private Button SpeciesButton;
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
    private Button PropertyButton;
}