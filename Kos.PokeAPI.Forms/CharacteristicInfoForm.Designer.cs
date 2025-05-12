namespace Kos.PokeAPI.Forms;

partial class CharacteristicInfoForm
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
        IdTextBox = new TextBox();
        IdCaptionLabel = new Label();
        GeneModuloTextBox = new TextBox();
        GeneModuloCaptionLabel = new Label();
        PossibleValuesDataGridView = new DataGridView();
        dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
        HighestStatTextBox = new TextBox();
        HightStatButton = new Button();
        PossibleValuesCaptionLabel = new Label();
        DescriptionsCaptionLabel = new Label();
        DescriptionsDataGridView = new DataGridView();
        DescriptionColumn = new DataGridViewTextBoxColumn();
        dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
        dataGridViewButtonColumn2 = new DataGridViewButtonColumn();
        PropertyButton = new Button();
        CloseButton = new Button();
        ((System.ComponentModel.ISupportInitialize)PossibleValuesDataGridView).BeginInit();
        ((System.ComponentModel.ISupportInitialize)DescriptionsDataGridView).BeginInit();
        SuspendLayout();
        // 
        // IdTextBox
        // 
        IdTextBox.Location = new Point(128, 12);
        IdTextBox.Name = "IdTextBox";
        IdTextBox.ReadOnly = true;
        IdTextBox.Size = new Size(190, 24);
        IdTextBox.TabIndex = 1;
        // 
        // IdCaptionLabel
        // 
        IdCaptionLabel.AutoSize = true;
        IdCaptionLabel.Location = new Point(70, 15);
        IdCaptionLabel.Margin = new Padding(4, 0, 4, 0);
        IdCaptionLabel.Name = "IdCaptionLabel";
        IdCaptionLabel.Size = new Size(51, 17);
        IdCaptionLabel.TabIndex = 0;
        IdCaptionLabel.Text = "個性ID";
        IdCaptionLabel.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // GeneModuloTextBox
        // 
        GeneModuloTextBox.Location = new Point(128, 42);
        GeneModuloTextBox.Name = "GeneModuloTextBox";
        GeneModuloTextBox.ReadOnly = true;
        GeneModuloTextBox.Size = new Size(190, 24);
        GeneModuloTextBox.TabIndex = 3;
        // 
        // GeneModuloCaptionLabel
        // 
        GeneModuloCaptionLabel.AutoSize = true;
        GeneModuloCaptionLabel.Location = new Point(36, 45);
        GeneModuloCaptionLabel.Margin = new Padding(4, 0, 4, 0);
        GeneModuloCaptionLabel.Name = "GeneModuloCaptionLabel";
        GeneModuloCaptionLabel.Size = new Size(85, 17);
        GeneModuloCaptionLabel.TabIndex = 2;
        GeneModuloCaptionLabel.Text = "個性の条件値";
        GeneModuloCaptionLabel.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // PossibleValuesDataGridView
        // 
        PossibleValuesDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        PossibleValuesDataGridView.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1 });
        PossibleValuesDataGridView.Location = new Point(325, 35);
        PossibleValuesDataGridView.Margin = new Padding(4, 3, 4, 3);
        PossibleValuesDataGridView.Name = "PossibleValuesDataGridView";
        PossibleValuesDataGridView.RowHeadersVisible = false;
        PossibleValuesDataGridView.Size = new Size(125, 283);
        PossibleValuesDataGridView.TabIndex = 7;
        // 
        // dataGridViewTextBoxColumn1
        // 
        dataGridViewTextBoxColumn1.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
        dataGridViewTextBoxColumn1.HeaderText = "条件値";
        dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
        dataGridViewTextBoxColumn1.ReadOnly = true;
        dataGridViewTextBoxColumn1.Width = 72;
        // 
        // HighestStatTextBox
        // 
        HighestStatTextBox.Location = new Point(128, 72);
        HighestStatTextBox.Name = "HighestStatTextBox";
        HighestStatTextBox.ReadOnly = true;
        HighestStatTextBox.Size = new Size(190, 24);
        HighestStatTextBox.TabIndex = 5;
        // 
        // HightStatButton
        // 
        HightStatButton.Location = new Point(13, 70);
        HightStatButton.Margin = new Padding(4, 3, 4, 3);
        HightStatButton.Name = "HightStatButton";
        HightStatButton.Size = new Size(108, 26);
        HightStatButton.TabIndex = 4;
        HightStatButton.Text = "最高のステータス";
        HightStatButton.UseVisualStyleBackColor = true;
        // 
        // PossibleValuesCaptionLabel
        // 
        PossibleValuesCaptionLabel.AutoSize = true;
        PossibleValuesCaptionLabel.Location = new Point(325, 15);
        PossibleValuesCaptionLabel.Margin = new Padding(4, 0, 4, 0);
        PossibleValuesCaptionLabel.Name = "PossibleValuesCaptionLabel";
        PossibleValuesCaptionLabel.Size = new Size(85, 17);
        PossibleValuesCaptionLabel.TabIndex = 6;
        PossibleValuesCaptionLabel.Text = "個性の条件値";
        PossibleValuesCaptionLabel.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // DescriptionsCaptionLabel
        // 
        DescriptionsCaptionLabel.AutoSize = true;
        DescriptionsCaptionLabel.Location = new Point(13, 128);
        DescriptionsCaptionLabel.Margin = new Padding(4, 0, 4, 0);
        DescriptionsCaptionLabel.Name = "DescriptionsCaptionLabel";
        DescriptionsCaptionLabel.Size = new Size(92, 17);
        DescriptionsCaptionLabel.TabIndex = 8;
        DescriptionsCaptionLabel.Text = "言語ごとの説明";
        DescriptionsCaptionLabel.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // DescriptionsDataGridView
        // 
        DescriptionsDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        DescriptionsDataGridView.Columns.AddRange(new DataGridViewColumn[] { DescriptionColumn, dataGridViewTextBoxColumn2, dataGridViewButtonColumn2 });
        DescriptionsDataGridView.Location = new Point(13, 148);
        DescriptionsDataGridView.Margin = new Padding(4, 3, 4, 3);
        DescriptionsDataGridView.Name = "DescriptionsDataGridView";
        DescriptionsDataGridView.RowHeadersVisible = false;
        DescriptionsDataGridView.Size = new Size(305, 170);
        DescriptionsDataGridView.TabIndex = 9;
        DescriptionsDataGridView.CellClick += DescriptionsDataGridView_CellClick;
        DescriptionsDataGridView.CellDoubleClick += DescriptionsDataGridView_CellDoubleClick;
        // 
        // DescriptionColumn
        // 
        DescriptionColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
        DescriptionColumn.DataPropertyName = "Text";
        DescriptionColumn.HeaderText = "説明";
        DescriptionColumn.Name = "DescriptionColumn";
        DescriptionColumn.ReadOnly = true;
        DescriptionColumn.Width = 59;
        // 
        // dataGridViewTextBoxColumn2
        // 
        dataGridViewTextBoxColumn2.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
        dataGridViewTextBoxColumn2.DataPropertyName = "Language";
        dataGridViewTextBoxColumn2.HeaderText = "言語";
        dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
        dataGridViewTextBoxColumn2.ReadOnly = true;
        dataGridViewTextBoxColumn2.Width = 59;
        // 
        // dataGridViewButtonColumn2
        // 
        dataGridViewButtonColumn2.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
        dataGridViewButtonColumn2.HeaderText = "詳細";
        dataGridViewButtonColumn2.Name = "dataGridViewButtonColumn2";
        dataGridViewButtonColumn2.Text = "詳細";
        dataGridViewButtonColumn2.UseColumnTextForButtonValue = true;
        dataGridViewButtonColumn2.Width = 40;
        // 
        // PropertyButton
        // 
        PropertyButton.Location = new Point(290, 324);
        PropertyButton.Margin = new Padding(4, 3, 4, 3);
        PropertyButton.Name = "PropertyButton";
        PropertyButton.Size = new Size(76, 35);
        PropertyButton.TabIndex = 10;
        PropertyButton.Text = "プロパティ";
        PropertyButton.UseVisualStyleBackColor = true;
        PropertyButton.Click += PropertyButton_Click;
        // 
        // CloseButton
        // 
        CloseButton.Location = new Point(374, 324);
        CloseButton.Margin = new Padding(4, 3, 4, 3);
        CloseButton.Name = "CloseButton";
        CloseButton.Size = new Size(76, 35);
        CloseButton.TabIndex = 11;
        CloseButton.Text = "閉じる";
        CloseButton.UseVisualStyleBackColor = true;
        CloseButton.Click += CloseButton_Click;
        // 
        // CharacteristicInfoForm
        // 
        AutoScaleDimensions = new SizeF(9F, 17F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(471, 368);
        Controls.Add(PropertyButton);
        Controls.Add(CloseButton);
        Controls.Add(DescriptionsDataGridView);
        Controls.Add(DescriptionsCaptionLabel);
        Controls.Add(PossibleValuesCaptionLabel);
        Controls.Add(HightStatButton);
        Controls.Add(HighestStatTextBox);
        Controls.Add(PossibleValuesDataGridView);
        Controls.Add(GeneModuloCaptionLabel);
        Controls.Add(GeneModuloTextBox);
        Controls.Add(IdTextBox);
        Controls.Add(IdCaptionLabel);
        Font = new Font("Meiryo UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 128);
        FormBorderStyle = FormBorderStyle.FixedSingle;
        Margin = new Padding(4, 3, 4, 3);
        MaximizeBox = false;
        Name = "CharacteristicInfoForm";
        StartPosition = FormStartPosition.CenterParent;
        Text = "個性";
        ((System.ComponentModel.ISupportInitialize)PossibleValuesDataGridView).EndInit();
        ((System.ComponentModel.ISupportInitialize)DescriptionsDataGridView).EndInit();
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private TextBox IdTextBox;
    private Label IdCaptionLabel;
    private TextBox GeneModuloTextBox;
    private Label GeneModuloCaptionLabel;
    private DataGridView PossibleValuesDataGridView;
    private TextBox HighestStatTextBox;
    private Button HightStatButton;
    private Label PossibleValuesCaptionLabel;
    private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
    private Label DescriptionsCaptionLabel;
    private DataGridView DescriptionsDataGridView;
    private DataGridViewTextBoxColumn DescriptionColumn;
    private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
    private DataGridViewButtonColumn dataGridViewButtonColumn2;
    private Button PropertyButton;
    private Button CloseButton;
}