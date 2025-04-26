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
        PokemonInfoButton = new Button();
        PokemonLabel = new Label();
        PokemonCaptionLabel = new Label();
        VersionDetailsCaptionLabel = new Label();
        VersionDetailsDataGridView = new DataGridView();
        dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
        dataGridViewButtonColumn1 = new DataGridViewButtonColumn();
        CloseButton = new Button();
        ((System.ComponentModel.ISupportInitialize)VersionDetailsDataGridView).BeginInit();
        SuspendLayout();
        // 
        // PokemonInfoButton
        // 
        PokemonInfoButton.Location = new Point(283, 9);
        PokemonInfoButton.Name = "PokemonInfoButton";
        PokemonInfoButton.Size = new Size(43, 23);
        PokemonInfoButton.TabIndex = 2;
        PokemonInfoButton.Text = "Info...";
        PokemonInfoButton.UseVisualStyleBackColor = true;
        // 
        // PokemonLabel
        // 
        PokemonLabel.BorderStyle = BorderStyle.Fixed3D;
        PokemonLabel.Location = new Point(75, 9);
        PokemonLabel.Name = "PokemonLabel";
        PokemonLabel.Size = new Size(202, 23);
        PokemonLabel.TabIndex = 1;
        PokemonLabel.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // PokemonCaptionLabel
        // 
        PokemonCaptionLabel.Location = new Point(12, 9);
        PokemonCaptionLabel.Name = "PokemonCaptionLabel";
        PokemonCaptionLabel.Size = new Size(57, 23);
        PokemonCaptionLabel.TabIndex = 0;
        PokemonCaptionLabel.Text = "pokemon";
        PokemonCaptionLabel.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // VersionDetailsCaptionLabel
        // 
        VersionDetailsCaptionLabel.Location = new Point(12, 43);
        VersionDetailsCaptionLabel.Name = "VersionDetailsCaptionLabel";
        VersionDetailsCaptionLabel.Size = new Size(87, 23);
        VersionDetailsCaptionLabel.TabIndex = 3;
        VersionDetailsCaptionLabel.Text = "version_details";
        VersionDetailsCaptionLabel.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // VersionDetailsDataGridView
        // 
        VersionDetailsDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        VersionDetailsDataGridView.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1, dataGridViewButtonColumn1 });
        VersionDetailsDataGridView.Location = new Point(12, 69);
        VersionDetailsDataGridView.Name = "VersionDetailsDataGridView";
        VersionDetailsDataGridView.RowHeadersVisible = false;
        VersionDetailsDataGridView.Size = new Size(434, 150);
        VersionDetailsDataGridView.TabIndex = 4;
        VersionDetailsDataGridView.CellClick += VersionDetailsDataGridView_CellClick;
        VersionDetailsDataGridView.CellDoubleClick += VersionDetailsDataGridView_CellDoubleClick;
        // 
        // dataGridViewTextBoxColumn1
        // 
        dataGridViewTextBoxColumn1.DataPropertyName = "Name";
        dataGridViewTextBoxColumn1.HeaderText = "name";
        dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
        dataGridViewTextBoxColumn1.ReadOnly = true;
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
        CloseButton.Location = new Point(371, 225);
        CloseButton.Name = "CloseButton";
        CloseButton.Size = new Size(75, 23);
        CloseButton.TabIndex = 5;
        CloseButton.Text = "Close";
        CloseButton.UseVisualStyleBackColor = true;
        CloseButton.Click += CloseButton_Click;
        // 
        // ItemHolderPokemonInfoForm
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(464, 260);
        Controls.Add(CloseButton);
        Controls.Add(VersionDetailsDataGridView);
        Controls.Add(VersionDetailsCaptionLabel);
        Controls.Add(PokemonInfoButton);
        Controls.Add(PokemonLabel);
        Controls.Add(PokemonCaptionLabel);
        FormBorderStyle = FormBorderStyle.FixedSingle;
        MaximizeBox = false;
        Name = "ItemHolderPokemonInfoForm";
        Text = "Item Holdrer Pokemon";
        ((System.ComponentModel.ISupportInitialize)VersionDetailsDataGridView).EndInit();
        ResumeLayout(false);
    }

    #endregion

    private Button PokemonInfoButton;
    private Label PokemonLabel;
    private Label PokemonCaptionLabel;
    private Label VersionDetailsCaptionLabel;
    private DataGridView VersionDetailsDataGridView;
    private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
    private DataGridViewButtonColumn dataGridViewButtonColumn1;
    private Button CloseButton;
}