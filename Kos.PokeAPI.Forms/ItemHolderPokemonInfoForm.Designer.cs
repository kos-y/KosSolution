namespace Kos.PokeAPI.Forms;

partial class ItemHolderPokemonInfoForm
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
        PokemonDetailButton = new Button();
        PokemonLabel = new Label();
        PokemonCaptionLabel = new Label();
        VersionDetailsCaptionLabel = new Label();
        VersionDetailsDataGridView = new DataGridView();
        dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
        Column1 = new DataGridViewTextBoxColumn();
        dataGridViewButtonColumn1 = new DataGridViewButtonColumn();
        CloseButton = new Button();
        ((System.ComponentModel.ISupportInitialize)VersionDetailsDataGridView).BeginInit();
        SuspendLayout();
        // 
        // PokemonDetailButton
        // 
        PokemonDetailButton.Location = new Point(364, 10);
        PokemonDetailButton.Margin = new Padding(4, 3, 4, 3);
        PokemonDetailButton.Name = "PokemonDetailButton";
        PokemonDetailButton.Size = new Size(55, 26);
        PokemonDetailButton.TabIndex = 2;
        PokemonDetailButton.Text = "詳細";
        PokemonDetailButton.UseVisualStyleBackColor = true;
        // 
        // PokemonLabel
        // 
        PokemonLabel.BorderStyle = BorderStyle.Fixed3D;
        PokemonLabel.Location = new Point(96, 10);
        PokemonLabel.Margin = new Padding(4, 0, 4, 0);
        PokemonLabel.Name = "PokemonLabel";
        PokemonLabel.Size = new Size(260, 26);
        PokemonLabel.TabIndex = 1;
        PokemonLabel.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // PokemonCaptionLabel
        // 
        PokemonCaptionLabel.Location = new Point(15, 10);
        PokemonCaptionLabel.Margin = new Padding(4, 0, 4, 0);
        PokemonCaptionLabel.Name = "PokemonCaptionLabel";
        PokemonCaptionLabel.Size = new Size(73, 26);
        PokemonCaptionLabel.TabIndex = 0;
        PokemonCaptionLabel.Text = "ポケモン";
        PokemonCaptionLabel.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // VersionDetailsCaptionLabel
        // 
        VersionDetailsCaptionLabel.AutoSize = true;
        VersionDetailsCaptionLabel.Location = new Point(15, 58);
        VersionDetailsCaptionLabel.Margin = new Padding(4, 0, 4, 0);
        VersionDetailsCaptionLabel.Name = "VersionDetailsCaptionLabel";
        VersionDetailsCaptionLabel.Size = new Size(118, 17);
        VersionDetailsCaptionLabel.TabIndex = 3;
        VersionDetailsCaptionLabel.Text = "バージョンごとの詳細";
        VersionDetailsCaptionLabel.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // VersionDetailsDataGridView
        // 
        VersionDetailsDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        VersionDetailsDataGridView.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1, Column1, dataGridViewButtonColumn1 });
        VersionDetailsDataGridView.Location = new Point(15, 78);
        VersionDetailsDataGridView.Margin = new Padding(4, 3, 4, 3);
        VersionDetailsDataGridView.Name = "VersionDetailsDataGridView";
        VersionDetailsDataGridView.RowHeadersVisible = false;
        VersionDetailsDataGridView.Size = new Size(558, 170);
        VersionDetailsDataGridView.TabIndex = 4;
        VersionDetailsDataGridView.CellClick += VersionDetailsDataGridView_CellClick;
        VersionDetailsDataGridView.CellDoubleClick += VersionDetailsDataGridView_CellDoubleClick;
        // 
        // dataGridViewTextBoxColumn1
        // 
        dataGridViewTextBoxColumn1.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
        dataGridViewTextBoxColumn1.DataPropertyName = "Version";
        dataGridViewTextBoxColumn1.HeaderText = "バージョン";
        dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
        dataGridViewTextBoxColumn1.ReadOnly = true;
        dataGridViewTextBoxColumn1.Width = 85;
        // 
        // Column1
        // 
        Column1.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
        Column1.DataPropertyName = "Rarity";
        Column1.HeaderText = "確率";
        Column1.Name = "Column1";
        Column1.ReadOnly = true;
        Column1.Width = 59;
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
        CloseButton.Location = new Point(505, 255);
        CloseButton.Margin = new Padding(4, 3, 4, 3);
        CloseButton.Name = "CloseButton";
        CloseButton.Size = new Size(68, 41);
        CloseButton.TabIndex = 5;
        CloseButton.Text = "閉じる";
        CloseButton.UseVisualStyleBackColor = true;
        CloseButton.Click += CloseButton_Click;
        // 
        // ItemHolderPokemonInfoForm
        // 
        AutoScaleDimensions = new SizeF(9F, 17F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(588, 301);
        Controls.Add(CloseButton);
        Controls.Add(VersionDetailsDataGridView);
        Controls.Add(VersionDetailsCaptionLabel);
        Controls.Add(PokemonDetailButton);
        Controls.Add(PokemonLabel);
        Controls.Add(PokemonCaptionLabel);
        Font = new Font("Meiryo UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 128);
        FormBorderStyle = FormBorderStyle.FixedSingle;
        Margin = new Padding(4, 3, 4, 3);
        MaximizeBox = false;
        Name = "ItemHolderPokemonInfoForm";
        StartPosition = FormStartPosition.CenterParent;
        Text = "アイテム所持ポケモン";
        ((System.ComponentModel.ISupportInitialize)VersionDetailsDataGridView).EndInit();
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private Button PokemonDetailButton;
    private Label PokemonLabel;
    private Label PokemonCaptionLabel;
    private Label VersionDetailsCaptionLabel;
    private DataGridView VersionDetailsDataGridView;
    private Button CloseButton;
    private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
    private DataGridViewTextBoxColumn Column1;
    private DataGridViewButtonColumn dataGridViewButtonColumn1;
}