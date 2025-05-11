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
        PokemonTextBox = new TextBox();
        VersionDetailsCaptionLabel = new Label();
        VersionDetailsDataGridView = new DataGridView();
        NameColumn = new DataGridViewTextBoxColumn();
        dataGridViewButtonColumn1 = new DataGridViewButtonColumn();
        CloseButton = new Button();
        PokemonButton = new Button();
        PropertyButton = new Button();
        ((System.ComponentModel.ISupportInitialize)VersionDetailsDataGridView).BeginInit();
        SuspendLayout();
        // 
        // PokemonTextBox
        // 
        PokemonTextBox.Location = new Point(78, 14);
        PokemonTextBox.Name = "PokemonTextBox";
        PokemonTextBox.ReadOnly = true;
        PokemonTextBox.Size = new Size(226, 24);
        PokemonTextBox.TabIndex = 1;
        // 
        // VersionDetailsCaptionLabel
        // 
        VersionDetailsCaptionLabel.AutoSize = true;
        VersionDetailsCaptionLabel.Location = new Point(13, 41);
        VersionDetailsCaptionLabel.Margin = new Padding(5, 0, 5, 0);
        VersionDetailsCaptionLabel.Name = "VersionDetailsCaptionLabel";
        VersionDetailsCaptionLabel.Size = new Size(144, 17);
        VersionDetailsCaptionLabel.TabIndex = 2;
        VersionDetailsCaptionLabel.Text = "バージョンごとの遭遇詳細";
        VersionDetailsCaptionLabel.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // VersionDetailsDataGridView
        // 
        VersionDetailsDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        VersionDetailsDataGridView.Columns.AddRange(new DataGridViewColumn[] { NameColumn, dataGridViewButtonColumn1 });
        VersionDetailsDataGridView.Location = new Point(14, 61);
        VersionDetailsDataGridView.Margin = new Padding(4, 3, 4, 3);
        VersionDetailsDataGridView.Name = "VersionDetailsDataGridView";
        VersionDetailsDataGridView.RowHeadersVisible = false;
        VersionDetailsDataGridView.Size = new Size(334, 170);
        VersionDetailsDataGridView.TabIndex = 3;
        VersionDetailsDataGridView.CellClick += EncounterDetailsDataGridView_CellClick;
        VersionDetailsDataGridView.CellDoubleClick += EncounterDetailsDataGridView_CellDoubleClick;
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
        // CloseButton
        // 
        CloseButton.Location = new Point(272, 237);
        CloseButton.Name = "CloseButton";
        CloseButton.Size = new Size(76, 35);
        CloseButton.TabIndex = 5;
        CloseButton.Text = "閉じる";
        CloseButton.UseVisualStyleBackColor = true;
        CloseButton.Click += CloseButton_Click;
        // 
        // PokemonButton
        // 
        PokemonButton.Location = new Point(13, 12);
        PokemonButton.Margin = new Padding(4, 3, 4, 3);
        PokemonButton.Name = "PokemonButton";
        PokemonButton.Size = new Size(58, 26);
        PokemonButton.TabIndex = 0;
        PokemonButton.Text = "ポケモン";
        PokemonButton.UseVisualStyleBackColor = true;
        PokemonButton.Click += PokemonButton_Click;
        // 
        // PropertyButton
        // 
        PropertyButton.Location = new Point(190, 237);
        PropertyButton.Name = "PropertyButton";
        PropertyButton.Size = new Size(76, 35);
        PropertyButton.TabIndex = 4;
        PropertyButton.Text = "プロパティ";
        PropertyButton.UseVisualStyleBackColor = true;
        PropertyButton.Click += PropertyButton_Click;
        // 
        // PokemonEncounterInfoForm
        // 
        AutoScaleDimensions = new SizeF(9F, 17F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(368, 290);
        Controls.Add(PropertyButton);
        Controls.Add(PokemonButton);
        Controls.Add(CloseButton);
        Controls.Add(VersionDetailsDataGridView);
        Controls.Add(VersionDetailsCaptionLabel);
        Controls.Add(PokemonTextBox);
        Font = new Font("Meiryo UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 128);
        FormBorderStyle = FormBorderStyle.FixedSingle;
        Margin = new Padding(4, 3, 4, 3);
        MaximizeBox = false;
        Name = "PokemonEncounterInfoForm";
        StartPosition = FormStartPosition.CenterParent;
        Text = "ポケモン 遭遇情報";
        ((System.ComponentModel.ISupportInitialize)VersionDetailsDataGridView).EndInit();
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion
    private TextBox PokemonTextBox;
    private Label VersionDetailsCaptionLabel;
    private DataGridView VersionDetailsDataGridView;
    private Button CloseButton;
    private Button PokemonButton;
    private DataGridViewTextBoxColumn NameColumn;
    private DataGridViewButtonColumn dataGridViewButtonColumn1;
    private Button PropertyButton;
}