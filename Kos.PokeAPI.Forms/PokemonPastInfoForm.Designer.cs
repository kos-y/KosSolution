namespace Kos.PokeAPI.Forms;

partial class PokemonPastInfoForm
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
        CloseButton = new Button();
        PastTypesDataGridView = new DataGridView();
        dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
        dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
        dataGridViewButtonColumn1 = new DataGridViewButtonColumn();
        PastTypesCaptionLabel = new Label();
        PastAbilitiesDataGridView = new DataGridView();
        dataGridViewTextBoxColumn4 = new DataGridViewTextBoxColumn();
        dataGridViewTextBoxColumn5 = new DataGridViewTextBoxColumn();
        dataGridViewButtonColumn3 = new DataGridViewButtonColumn();
        PastAbilitiesCaptionLabel = new Label();
        CriesLegacytButton = new Button();
        ((System.ComponentModel.ISupportInitialize)PastTypesDataGridView).BeginInit();
        ((System.ComponentModel.ISupportInitialize)PastAbilitiesDataGridView).BeginInit();
        SuspendLayout();
        // 
        // CloseButton
        // 
        CloseButton.Location = new Point(390, 153);
        CloseButton.Margin = new Padding(4, 3, 4, 3);
        CloseButton.Name = "CloseButton";
        CloseButton.Size = new Size(76, 35);
        CloseButton.TabIndex = 5;
        CloseButton.Text = "閉じる";
        CloseButton.UseVisualStyleBackColor = true;
        // 
        // PastTypesDataGridView
        // 
        PastTypesDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        PastTypesDataGridView.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1, dataGridViewTextBoxColumn2, dataGridViewButtonColumn1 });
        PastTypesDataGridView.Location = new Point(12, 29);
        PastTypesDataGridView.Margin = new Padding(4, 3, 4, 3);
        PastTypesDataGridView.Name = "PastTypesDataGridView";
        PastTypesDataGridView.RowHeadersVisible = false;
        PastTypesDataGridView.Size = new Size(223, 118);
        PastTypesDataGridView.TabIndex = 1;
        // 
        // dataGridViewTextBoxColumn1
        // 
        dataGridViewTextBoxColumn1.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
        dataGridViewTextBoxColumn1.DataPropertyName = "Slot";
        dataGridViewTextBoxColumn1.HeaderText = "";
        dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
        dataGridViewTextBoxColumn1.ReadOnly = true;
        dataGridViewTextBoxColumn1.Width = 21;
        // 
        // dataGridViewTextBoxColumn2
        // 
        dataGridViewTextBoxColumn2.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
        dataGridViewTextBoxColumn2.DataPropertyName = "Type";
        dataGridViewTextBoxColumn2.HeaderText = "タイプ";
        dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
        dataGridViewTextBoxColumn2.ReadOnly = true;
        dataGridViewTextBoxColumn2.Width = 65;
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
        // PastTypesCaptionLabel
        // 
        PastTypesCaptionLabel.AutoSize = true;
        PastTypesCaptionLabel.Location = new Point(13, 9);
        PastTypesCaptionLabel.Margin = new Padding(4, 0, 4, 0);
        PastTypesCaptionLabel.Name = "PastTypesCaptionLabel";
        PastTypesCaptionLabel.Size = new Size(40, 17);
        PastTypesCaptionLabel.TabIndex = 0;
        PastTypesCaptionLabel.Text = "タイプ";
        PastTypesCaptionLabel.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // PastAbilitiesDataGridView
        // 
        PastAbilitiesDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        PastAbilitiesDataGridView.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn4, dataGridViewTextBoxColumn5, dataGridViewButtonColumn3 });
        PastAbilitiesDataGridView.Location = new Point(243, 29);
        PastAbilitiesDataGridView.Margin = new Padding(4, 3, 4, 3);
        PastAbilitiesDataGridView.Name = "PastAbilitiesDataGridView";
        PastAbilitiesDataGridView.RowHeadersVisible = false;
        PastAbilitiesDataGridView.Size = new Size(223, 118);
        PastAbilitiesDataGridView.TabIndex = 3;
        // 
        // dataGridViewTextBoxColumn4
        // 
        dataGridViewTextBoxColumn4.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
        dataGridViewTextBoxColumn4.DataPropertyName = "Slot";
        dataGridViewTextBoxColumn4.HeaderText = "";
        dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
        dataGridViewTextBoxColumn4.ReadOnly = true;
        dataGridViewTextBoxColumn4.Width = 21;
        // 
        // dataGridViewTextBoxColumn5
        // 
        dataGridViewTextBoxColumn5.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
        dataGridViewTextBoxColumn5.DataPropertyName = "Ability";
        dataGridViewTextBoxColumn5.HeaderText = "特性";
        dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
        dataGridViewTextBoxColumn5.ReadOnly = true;
        dataGridViewTextBoxColumn5.Width = 59;
        // 
        // dataGridViewButtonColumn3
        // 
        dataGridViewButtonColumn3.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
        dataGridViewButtonColumn3.HeaderText = "詳細";
        dataGridViewButtonColumn3.Name = "dataGridViewButtonColumn3";
        dataGridViewButtonColumn3.Text = "詳細";
        dataGridViewButtonColumn3.UseColumnTextForButtonValue = true;
        dataGridViewButtonColumn3.Width = 40;
        // 
        // PastAbilitiesCaptionLabel
        // 
        PastAbilitiesCaptionLabel.AutoSize = true;
        PastAbilitiesCaptionLabel.Location = new Point(244, 9);
        PastAbilitiesCaptionLabel.Margin = new Padding(4, 0, 4, 0);
        PastAbilitiesCaptionLabel.Name = "PastAbilitiesCaptionLabel";
        PastAbilitiesCaptionLabel.Size = new Size(34, 17);
        PastAbilitiesCaptionLabel.TabIndex = 2;
        PastAbilitiesCaptionLabel.Text = "特性";
        PastAbilitiesCaptionLabel.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // CriesLegacytButton
        // 
        CriesLegacytButton.Location = new Point(13, 153);
        CriesLegacytButton.Margin = new Padding(4, 3, 4, 3);
        CriesLegacytButton.Name = "CriesLegacytButton";
        CriesLegacytButton.Size = new Size(76, 35);
        CriesLegacytButton.TabIndex = 4;
        CriesLegacytButton.Text = "鳴き声";
        CriesLegacytButton.UseVisualStyleBackColor = true;
        // 
        // PokemonPastInfoForm
        // 
        AutoScaleDimensions = new SizeF(9F, 17F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(476, 195);
        Controls.Add(CriesLegacytButton);
        Controls.Add(PastAbilitiesDataGridView);
        Controls.Add(PastAbilitiesCaptionLabel);
        Controls.Add(PastTypesDataGridView);
        Controls.Add(PastTypesCaptionLabel);
        Controls.Add(CloseButton);
        Font = new Font("Meiryo UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 128);
        FormBorderStyle = FormBorderStyle.FixedSingle;
        Margin = new Padding(4, 3, 4, 3);
        MaximizeBox = false;
        Name = "PokemonPastInfoForm";
        StartPosition = FormStartPosition.CenterParent;
        Text = "ポケモン 過去情報";
        ((System.ComponentModel.ISupportInitialize)PastTypesDataGridView).EndInit();
        ((System.ComponentModel.ISupportInitialize)PastAbilitiesDataGridView).EndInit();
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private Button CloseButton;
    private DataGridView PastTypesDataGridView;
    private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
    private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
    private DataGridViewButtonColumn dataGridViewButtonColumn1;
    private Label PastTypesCaptionLabel;
    private DataGridView PastAbilitiesDataGridView;
    private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
    private DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
    private DataGridViewButtonColumn dataGridViewButtonColumn3;
    private Label PastAbilitiesCaptionLabel;
    private Button CriesLegacytButton;
}