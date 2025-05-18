namespace Kos.PokeAPI.Forms;

partial class PokemonHeldItemInfoForm
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
        ItemTextBox = new TextBox();
        ItemButton = new Button();
        VersionDetailsDataGridView = new DataGridView();
        PropertyButton = new Button();
        CloseButton = new Button();
        dataGridViewTextBoxColumn7 = new DataGridViewTextBoxColumn();
        dataGridViewButtonColumn6 = new DataGridViewButtonColumn();
        ((System.ComponentModel.ISupportInitialize)VersionDetailsDataGridView).BeginInit();
        SuspendLayout();
        // 
        // ItemTextBox
        // 
        ItemTextBox.Location = new Point(89, 13);
        ItemTextBox.Margin = new Padding(4, 3, 4, 3);
        ItemTextBox.Name = "ItemTextBox";
        ItemTextBox.ReadOnly = true;
        ItemTextBox.Size = new Size(175, 24);
        ItemTextBox.TabIndex = 1;
        // 
        // ItemButton
        // 
        ItemButton.Location = new Point(12, 12);
        ItemButton.Name = "ItemButton";
        ItemButton.Size = new Size(70, 25);
        ItemButton.TabIndex = 0;
        ItemButton.Text = "アイテム";
        ItemButton.UseVisualStyleBackColor = true;
        // 
        // VersionDetailsDataGridView
        // 
        VersionDetailsDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        VersionDetailsDataGridView.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn7, dataGridViewButtonColumn6 });
        VersionDetailsDataGridView.Location = new Point(12, 43);
        VersionDetailsDataGridView.Margin = new Padding(4, 3, 4, 3);
        VersionDetailsDataGridView.Name = "VersionDetailsDataGridView";
        VersionDetailsDataGridView.RowHeadersVisible = false;
        VersionDetailsDataGridView.Size = new Size(332, 246);
        VersionDetailsDataGridView.TabIndex = 2;
        // 
        // PropertyButton
        // 
        PropertyButton.Location = new Point(184, 295);
        PropertyButton.Margin = new Padding(4, 3, 4, 3);
        PropertyButton.Name = "PropertyButton";
        PropertyButton.Size = new Size(76, 35);
        PropertyButton.TabIndex = 3;
        PropertyButton.Text = "プロパティ";
        PropertyButton.UseVisualStyleBackColor = true;
        // 
        // CloseButton
        // 
        CloseButton.Location = new Point(268, 295);
        CloseButton.Margin = new Padding(4, 3, 4, 3);
        CloseButton.Name = "CloseButton";
        CloseButton.Size = new Size(76, 35);
        CloseButton.TabIndex = 4;
        CloseButton.Text = "閉じる";
        CloseButton.UseVisualStyleBackColor = true;
        // 
        // dataGridViewTextBoxColumn7
        // 
        dataGridViewTextBoxColumn7.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
        dataGridViewTextBoxColumn7.DataPropertyName = "Version";
        dataGridViewTextBoxColumn7.HeaderText = "バージョン";
        dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
        dataGridViewTextBoxColumn7.ReadOnly = true;
        dataGridViewTextBoxColumn7.Width = 85;
        // 
        // dataGridViewButtonColumn6
        // 
        dataGridViewButtonColumn6.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
        dataGridViewButtonColumn6.HeaderText = "詳細";
        dataGridViewButtonColumn6.Name = "dataGridViewButtonColumn6";
        dataGridViewButtonColumn6.Text = "詳細";
        dataGridViewButtonColumn6.UseColumnTextForButtonValue = true;
        dataGridViewButtonColumn6.Width = 40;
        // 
        // PokemonHeldItemInfoForm
        // 
        AutoScaleDimensions = new SizeF(9F, 17F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(362, 341);
        Controls.Add(PropertyButton);
        Controls.Add(CloseButton);
        Controls.Add(VersionDetailsDataGridView);
        Controls.Add(ItemTextBox);
        Controls.Add(ItemButton);
        Font = new Font("Meiryo UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 128);
        FormBorderStyle = FormBorderStyle.FixedSingle;
        Margin = new Padding(4, 3, 4, 3);
        MaximizeBox = false;
        Name = "PokemonHeldItemInfoForm";
        StartPosition = FormStartPosition.CenterParent;
        Text = "ポケモン所持アイテム";
        ((System.ComponentModel.ISupportInitialize)VersionDetailsDataGridView).EndInit();
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private TextBox ItemTextBox;
    private Button ItemButton;
    private DataGridView VersionDetailsDataGridView;
    private Button PropertyButton;
    private Button CloseButton;
    private DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
    private DataGridViewButtonColumn dataGridViewButtonColumn6;
}