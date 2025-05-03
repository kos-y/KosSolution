namespace Kos.PokeAPI.Forms;

partial class PokemonEncounterInfoForm
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
        PokemonCaptionLabel = new Label();
        PokemonTextBox = new TextBox();
        VersionDetailsCaptionLabel = new Label();
        EncounterDetailsDataGridView = new DataGridView();
        CloseButton = new Button();
        PokemonDetailButton = new Button();
        NameColumn = new DataGridViewTextBoxColumn();
        dataGridViewButtonColumn1 = new DataGridViewButtonColumn();
        ((System.ComponentModel.ISupportInitialize)EncounterDetailsDataGridView).BeginInit();
        SuspendLayout();
        // 
        // PokemonCaptionLabel
        // 
        PokemonCaptionLabel.AutoSize = true;
        PokemonCaptionLabel.Location = new Point(14, 15);
        PokemonCaptionLabel.Margin = new Padding(5, 0, 5, 0);
        PokemonCaptionLabel.Name = "PokemonCaptionLabel";
        PokemonCaptionLabel.Size = new Size(49, 17);
        PokemonCaptionLabel.TabIndex = 0;
        PokemonCaptionLabel.Text = "ポケモン";
        PokemonCaptionLabel.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // PokemonTextBox
        // 
        PokemonTextBox.Location = new Point(71, 12);
        PokemonTextBox.Name = "PokemonTextBox";
        PokemonTextBox.ReadOnly = true;
        PokemonTextBox.Size = new Size(226, 24);
        PokemonTextBox.TabIndex = 1;
        // 
        // VersionDetailsCaptionLabel
        // 
        VersionDetailsCaptionLabel.AutoSize = true;
        VersionDetailsCaptionLabel.Location = new Point(14, 61);
        VersionDetailsCaptionLabel.Margin = new Padding(5, 0, 5, 0);
        VersionDetailsCaptionLabel.Name = "VersionDetailsCaptionLabel";
        VersionDetailsCaptionLabel.Size = new Size(144, 17);
        VersionDetailsCaptionLabel.TabIndex = 3;
        VersionDetailsCaptionLabel.Text = "バージョンごとの遭遇詳細";
        VersionDetailsCaptionLabel.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // EncounterDetailsDataGridView
        // 
        EncounterDetailsDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        EncounterDetailsDataGridView.Columns.AddRange(new DataGridViewColumn[] { NameColumn, dataGridViewButtonColumn1 });
        EncounterDetailsDataGridView.Location = new Point(14, 81);
        EncounterDetailsDataGridView.Margin = new Padding(4, 3, 4, 3);
        EncounterDetailsDataGridView.Name = "EncounterDetailsDataGridView";
        EncounterDetailsDataGridView.RowHeadersVisible = false;
        EncounterDetailsDataGridView.Size = new Size(334, 170);
        EncounterDetailsDataGridView.TabIndex = 4;
        EncounterDetailsDataGridView.CellClick += EncounterDetailsDataGridView_CellClick;
        EncounterDetailsDataGridView.CellDoubleClick += EncounterDetailsDataGridView_CellDoubleClick;
        // 
        // CloseButton
        // 
        CloseButton.Location = new Point(285, 257);
        CloseButton.Name = "CloseButton";
        CloseButton.Size = new Size(63, 35);
        CloseButton.TabIndex = 5;
        CloseButton.Text = "閉じる";
        CloseButton.UseVisualStyleBackColor = true;
        CloseButton.Click += CloseButton_Click;
        // 
        // PokemonDetailButton
        // 
        PokemonDetailButton.Location = new Point(304, 10);
        PokemonDetailButton.Margin = new Padding(4, 3, 4, 3);
        PokemonDetailButton.Name = "PokemonDetailButton";
        PokemonDetailButton.Size = new Size(44, 26);
        PokemonDetailButton.TabIndex = 2;
        PokemonDetailButton.Text = "詳細";
        PokemonDetailButton.UseVisualStyleBackColor = true;
        PokemonDetailButton.Click += PokemonDetailButton_Click;
        // 
        // NameColumn
        // 
        NameColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
        NameColumn.DataPropertyName = "Version";
        NameColumn.HeaderText = "バージョン";
        NameColumn.Name = "NameColumn";
        NameColumn.ReadOnly = true;
        NameColumn.Width = 85;
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
        // PokemonEncounterInfoForm
        // 
        AutoScaleDimensions = new SizeF(9F, 17F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(368, 306);
        Controls.Add(PokemonDetailButton);
        Controls.Add(CloseButton);
        Controls.Add(EncounterDetailsDataGridView);
        Controls.Add(VersionDetailsCaptionLabel);
        Controls.Add(PokemonTextBox);
        Controls.Add(PokemonCaptionLabel);
        Font = new Font("Meiryo UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 128);
        FormBorderStyle = FormBorderStyle.FixedSingle;
        Margin = new Padding(4, 3, 4, 3);
        MaximizeBox = false;
        Name = "PokemonEncounterInfoForm";
        StartPosition = FormStartPosition.CenterParent;
        Text = "ポケモン 遭遇情報";
        ((System.ComponentModel.ISupportInitialize)EncounterDetailsDataGridView).EndInit();
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private Label PokemonCaptionLabel;
    private TextBox PokemonTextBox;
    private Label VersionDetailsCaptionLabel;
    private DataGridView EncounterDetailsDataGridView;
    private Button CloseButton;
    private Button PokemonDetailButton;
    private DataGridViewTextBoxColumn NameColumn;
    private DataGridViewButtonColumn dataGridViewButtonColumn1;
}