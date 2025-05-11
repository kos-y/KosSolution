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
        PokemonButton = new Button();
        VersionDetailsCaptionLabel = new Label();
        VersionDetailsDataGridView = new DataGridView();
        dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
        Column1 = new DataGridViewTextBoxColumn();
        dataGridViewButtonColumn1 = new DataGridViewButtonColumn();
        CloseButton = new Button();
        PokemonTextBox = new TextBox();
        PropertyButton = new Button();
        ((System.ComponentModel.ISupportInitialize)VersionDetailsDataGridView).BeginInit();
        SuspendLayout();
        // 
        // PokemonButton
        // 
        PokemonButton.Location = new Point(13, 12);
        PokemonButton.Margin = new Padding(4, 3, 4, 3);
        PokemonButton.Name = "PokemonButton";
        PokemonButton.Size = new Size(62, 26);
        PokemonButton.TabIndex = 0;
        PokemonButton.Text = "ポケモン";
        PokemonButton.UseVisualStyleBackColor = true;
        // 
        // VersionDetailsCaptionLabel
        // 
        VersionDetailsCaptionLabel.AutoSize = true;
        VersionDetailsCaptionLabel.Location = new Point(15, 58);
        VersionDetailsCaptionLabel.Margin = new Padding(4, 0, 4, 0);
        VersionDetailsCaptionLabel.Name = "VersionDetailsCaptionLabel";
        VersionDetailsCaptionLabel.Size = new Size(118, 17);
        VersionDetailsCaptionLabel.TabIndex = 2;
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
        VersionDetailsDataGridView.Size = new Size(286, 170);
        VersionDetailsDataGridView.TabIndex = 3;
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
        CloseButton.Location = new Point(225, 254);
        CloseButton.Margin = new Padding(4, 3, 4, 3);
        CloseButton.Name = "CloseButton";
        CloseButton.Size = new Size(76, 35);
        CloseButton.TabIndex = 5;
        CloseButton.Text = "閉じる";
        CloseButton.UseVisualStyleBackColor = true;
        CloseButton.Click += CloseButton_Click;
        // 
        // PokemonTextBox
        // 
        PokemonTextBox.Location = new Point(82, 14);
        PokemonTextBox.Name = "PokemonTextBox";
        PokemonTextBox.ReadOnly = true;
        PokemonTextBox.Size = new Size(219, 24);
        PokemonTextBox.TabIndex = 1;
        // 
        // PropertyButton
        // 
        PropertyButton.Location = new Point(141, 254);
        PropertyButton.Margin = new Padding(4, 3, 4, 3);
        PropertyButton.Name = "PropertyButton";
        PropertyButton.Size = new Size(76, 35);
        PropertyButton.TabIndex = 4;
        PropertyButton.Text = "プロパティ";
        PropertyButton.UseVisualStyleBackColor = true;
        PropertyButton.Click += PropertyButton_Click;
        // 
        // ItemHolderPokemonInfoForm
        // 
        AutoScaleDimensions = new SizeF(9F, 17F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(325, 301);
        Controls.Add(PropertyButton);
        Controls.Add(PokemonTextBox);
        Controls.Add(CloseButton);
        Controls.Add(VersionDetailsDataGridView);
        Controls.Add(VersionDetailsCaptionLabel);
        Controls.Add(PokemonButton);
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

    private Button PokemonButton;
    private Label VersionDetailsCaptionLabel;
    private DataGridView VersionDetailsDataGridView;
    private Button CloseButton;
    private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
    private DataGridViewTextBoxColumn Column1;
    private DataGridViewButtonColumn dataGridViewButtonColumn1;
    private TextBox PokemonTextBox;
    private Button PropertyButton;
}