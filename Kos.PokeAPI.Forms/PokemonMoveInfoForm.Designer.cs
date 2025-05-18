namespace Kos.PokeAPI.Forms;

partial class PokemonMoveInfoForm
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
        MoveTextBox = new TextBox();
        MoveButton = new Button();
        VersionDetailsDataGridView = new DataGridView();
        dataGridViewTextBoxColumn7 = new DataGridViewTextBoxColumn();
        dataGridViewButtonColumn6 = new DataGridViewButtonColumn();
        PropertyButton = new Button();
        CloseButton = new Button();
        ((System.ComponentModel.ISupportInitialize)VersionDetailsDataGridView).BeginInit();
        SuspendLayout();
        // 
        // MoveTextBox
        // 
        MoveTextBox.Location = new Point(95, 13);
        MoveTextBox.Margin = new Padding(4, 3, 4, 3);
        MoveTextBox.Name = "MoveTextBox";
        MoveTextBox.ReadOnly = true;
        MoveTextBox.Size = new Size(138, 24);
        MoveTextBox.TabIndex = 1;
        // 
        // MoveButton
        // 
        MoveButton.Location = new Point(12, 12);
        MoveButton.Name = "MoveButton";
        MoveButton.Size = new Size(76, 25);
        MoveButton.TabIndex = 0;
        MoveButton.Text = "技";
        MoveButton.UseVisualStyleBackColor = true;
        // 
        // VersionDetailsDataGridView
        // 
        VersionDetailsDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        VersionDetailsDataGridView.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn7, dataGridViewButtonColumn6 });
        VersionDetailsDataGridView.Location = new Point(13, 43);
        VersionDetailsDataGridView.Margin = new Padding(4, 3, 4, 3);
        VersionDetailsDataGridView.Name = "VersionDetailsDataGridView";
        VersionDetailsDataGridView.RowHeadersVisible = false;
        VersionDetailsDataGridView.Size = new Size(355, 246);
        VersionDetailsDataGridView.TabIndex = 2;
        // 
        // dataGridViewTextBoxColumn7
        // 
        dataGridViewTextBoxColumn7.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
        dataGridViewTextBoxColumn7.DataPropertyName = "VersionGroup";
        dataGridViewTextBoxColumn7.HeaderText = "バージョングループ";
        dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
        dataGridViewTextBoxColumn7.ReadOnly = true;
        dataGridViewTextBoxColumn7.Width = 88;
        // 
        // dataGridViewButtonColumn6
        // 
        dataGridViewButtonColumn6.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
        dataGridViewButtonColumn6.HeaderText = "詳細";
        dataGridViewButtonColumn6.Name = "dataGridViewButtonColumn6";
        dataGridViewButtonColumn6.Text = "詳細";
        dataGridViewButtonColumn6.UseColumnTextForButtonValue = true;
        dataGridViewButtonColumn6.Width = 36;
        // 
        // PropertyButton
        // 
        PropertyButton.Location = new Point(208, 295);
        PropertyButton.Margin = new Padding(4, 3, 4, 3);
        PropertyButton.Name = "PropertyButton";
        PropertyButton.Size = new Size(76, 35);
        PropertyButton.TabIndex = 3;
        PropertyButton.Text = "プロパティ";
        PropertyButton.UseVisualStyleBackColor = true;
        // 
        // CloseButton
        // 
        CloseButton.Location = new Point(292, 295);
        CloseButton.Margin = new Padding(4, 3, 4, 3);
        CloseButton.Name = "CloseButton";
        CloseButton.Size = new Size(76, 35);
        CloseButton.TabIndex = 4;
        CloseButton.Text = "閉じる";
        CloseButton.UseVisualStyleBackColor = true;
        // 
        // PokemonMoveInfoForm
        // 
        AutoScaleDimensions = new SizeF(9F, 17F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(380, 341);
        Controls.Add(PropertyButton);
        Controls.Add(CloseButton);
        Controls.Add(VersionDetailsDataGridView);
        Controls.Add(MoveTextBox);
        Controls.Add(MoveButton);
        Font = new Font("Meiryo UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 128);
        FormBorderStyle = FormBorderStyle.FixedSingle;
        Margin = new Padding(4, 3, 4, 3);
        MaximizeBox = false;
        Name = "PokemonMoveInfoForm";
        StartPosition = FormStartPosition.CenterParent;
        Text = "ポケモンの技";
        ((System.ComponentModel.ISupportInitialize)VersionDetailsDataGridView).EndInit();
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private TextBox MoveTextBox;
    private Button MoveButton;
    private DataGridView VersionDetailsDataGridView;
    private DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
    private DataGridViewButtonColumn dataGridViewButtonColumn6;
    private Button PropertyButton;
    private Button CloseButton;
}