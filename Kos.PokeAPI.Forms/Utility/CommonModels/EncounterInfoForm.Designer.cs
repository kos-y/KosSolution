namespace Kos.PokeAPI.Forms.Utility.CommonModels;

partial class EncounterInfoForm
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
        MethodTextBox = new TextBox();
        ChanceTextBox = new TextBox();
        ChanceCaptionLabel = new Label();
        MethodButton = new Button();
        LevelCaptionLabel = new Label();
        MinLevelTextBox = new TextBox();
        MaxLevelTextBox = new TextBox();
        LevelRangeLabel = new Label();
        ConditionValueCaptionLabel = new Label();
        ConditionValuesDataGridView = new DataGridView();
        dataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
        dataGridViewButtonColumn3 = new DataGridViewButtonColumn();
        CloseButton = new Button();
        PropertyButton = new Button();
        ((System.ComponentModel.ISupportInitialize)ConditionValuesDataGridView).BeginInit();
        SuspendLayout();
        // 
        // MethodTextBox
        // 
        MethodTextBox.Location = new Point(81, 14);
        MethodTextBox.Margin = new Padding(2, 3, 2, 3);
        MethodTextBox.Name = "MethodTextBox";
        MethodTextBox.ReadOnly = true;
        MethodTextBox.Size = new Size(101, 23);
        MethodTextBox.TabIndex = 1;
        MethodTextBox.Text = "ピカチュウ";
        // 
        // ChanceTextBox
        // 
        ChanceTextBox.Location = new Point(81, 43);
        ChanceTextBox.Margin = new Padding(2, 3, 2, 3);
        ChanceTextBox.Name = "ChanceTextBox";
        ChanceTextBox.ReadOnly = true;
        ChanceTextBox.Size = new Size(101, 23);
        ChanceTextBox.TabIndex = 3;
        ChanceTextBox.Text = "ピカチュウ";
        // 
        // ChanceCaptionLabel
        // 
        ChanceCaptionLabel.AutoSize = true;
        ChanceCaptionLabel.Location = new Point(34, 46);
        ChanceCaptionLabel.Margin = new Padding(2, 0, 2, 0);
        ChanceCaptionLabel.Name = "ChanceCaptionLabel";
        ChanceCaptionLabel.Size = new Size(43, 15);
        ChanceCaptionLabel.TabIndex = 2;
        ChanceCaptionLabel.Text = "遭遇率";
        // 
        // MethodButton
        // 
        MethodButton.Location = new Point(11, 12);
        MethodButton.Margin = new Padding(2, 3, 2, 3);
        MethodButton.Name = "MethodButton";
        MethodButton.Size = new Size(66, 24);
        MethodButton.TabIndex = 0;
        MethodButton.Text = "遭遇方法";
        MethodButton.UseVisualStyleBackColor = true;
        MethodButton.Click += MethodButton_Click;
        // 
        // LevelCaptionLabel
        // 
        LevelCaptionLabel.AutoSize = true;
        LevelCaptionLabel.Location = new Point(41, 75);
        LevelCaptionLabel.Margin = new Padding(2, 0, 2, 0);
        LevelCaptionLabel.Name = "LevelCaptionLabel";
        LevelCaptionLabel.Size = new Size(36, 15);
        LevelCaptionLabel.TabIndex = 4;
        LevelCaptionLabel.Text = "レベル";
        // 
        // MinLevelTextBox
        // 
        MinLevelTextBox.Location = new Point(81, 72);
        MinLevelTextBox.Margin = new Padding(2, 3, 2, 3);
        MinLevelTextBox.Name = "MinLevelTextBox";
        MinLevelTextBox.ReadOnly = true;
        MinLevelTextBox.Size = new Size(31, 23);
        MinLevelTextBox.TabIndex = 5;
        MinLevelTextBox.Text = "100";
        // 
        // MaxLevelTextBox
        // 
        MaxLevelTextBox.Location = new Point(141, 72);
        MaxLevelTextBox.Margin = new Padding(2, 3, 2, 3);
        MaxLevelTextBox.Name = "MaxLevelTextBox";
        MaxLevelTextBox.ReadOnly = true;
        MaxLevelTextBox.Size = new Size(31, 23);
        MaxLevelTextBox.TabIndex = 7;
        MaxLevelTextBox.Text = "100";
        // 
        // LevelRangeLabel
        // 
        LevelRangeLabel.AutoSize = true;
        LevelRangeLabel.Font = new Font("Meiryo UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 128);
        LevelRangeLabel.Location = new Point(116, 73);
        LevelRangeLabel.Margin = new Padding(2, 0, 2, 0);
        LevelRangeLabel.Name = "LevelRangeLabel";
        LevelRangeLabel.Size = new Size(21, 17);
        LevelRangeLabel.TabIndex = 6;
        LevelRangeLabel.Text = "～";
        // 
        // ConditionValueCaptionLabel
        // 
        ConditionValueCaptionLabel.AutoSize = true;
        ConditionValueCaptionLabel.Location = new Point(196, 14);
        ConditionValueCaptionLabel.Margin = new Padding(2, 0, 2, 0);
        ConditionValueCaptionLabel.Name = "ConditionValueCaptionLabel";
        ConditionValueCaptionLabel.Size = new Size(67, 15);
        ConditionValueCaptionLabel.TabIndex = 8;
        ConditionValueCaptionLabel.Text = "遭遇条件値";
        // 
        // ConditionValuesDataGridView
        // 
        ConditionValuesDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        ConditionValuesDataGridView.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn3, dataGridViewButtonColumn3 });
        ConditionValuesDataGridView.Location = new Point(196, 32);
        ConditionValuesDataGridView.Margin = new Padding(2, 3, 2, 3);
        ConditionValuesDataGridView.Name = "ConditionValuesDataGridView";
        ConditionValuesDataGridView.RowHeadersVisible = false;
        ConditionValuesDataGridView.Size = new Size(202, 132);
        ConditionValuesDataGridView.TabIndex = 9;
        ConditionValuesDataGridView.CellClick += ConditionValuesDataGridView_CellClick;
        ConditionValuesDataGridView.CellDoubleClick += ConditionValuesDataGridView_CellDoubleClick;
        // 
        // dataGridViewTextBoxColumn3
        // 
        dataGridViewTextBoxColumn3.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
        dataGridViewTextBoxColumn3.DataPropertyName = "Name";
        dataGridViewTextBoxColumn3.HeaderText = "条件値";
        dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
        dataGridViewTextBoxColumn3.ReadOnly = true;
        dataGridViewTextBoxColumn3.Width = 68;
        // 
        // dataGridViewButtonColumn3
        // 
        dataGridViewButtonColumn3.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
        dataGridViewButtonColumn3.HeaderText = "詳細";
        dataGridViewButtonColumn3.Name = "dataGridViewButtonColumn3";
        dataGridViewButtonColumn3.Text = "詳細";
        dataGridViewButtonColumn3.UseColumnTextForButtonValue = true;
        dataGridViewButtonColumn3.Width = 37;
        // 
        // CloseButton
        // 
        CloseButton.Location = new Point(339, 170);
        CloseButton.Name = "CloseButton";
        CloseButton.Size = new Size(59, 31);
        CloseButton.TabIndex = 11;
        CloseButton.Text = "閉じる";
        CloseButton.UseVisualStyleBackColor = true;
        CloseButton.Click += CloseButton_Click;
        // 
        // PropertyButton
        // 
        PropertyButton.Location = new Point(284, 170);
        PropertyButton.Name = "PropertyButton";
        PropertyButton.Size = new Size(59, 31);
        PropertyButton.TabIndex = 10;
        PropertyButton.Text = "プロパティ";
        PropertyButton.UseVisualStyleBackColor = true;
        PropertyButton.Click += PropertyButton_Click;
        // 
        // EncounterInfoForm
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(421, 220);
        Controls.Add(PropertyButton);
        Controls.Add(CloseButton);
        Controls.Add(ConditionValuesDataGridView);
        Controls.Add(ConditionValueCaptionLabel);
        Controls.Add(LevelRangeLabel);
        Controls.Add(MaxLevelTextBox);
        Controls.Add(MinLevelTextBox);
        Controls.Add(LevelCaptionLabel);
        Controls.Add(MethodButton);
        Controls.Add(ChanceCaptionLabel);
        Controls.Add(ChanceTextBox);
        Controls.Add(MethodTextBox);
        FormBorderStyle = FormBorderStyle.FixedSingle;
        MaximizeBox = false;
        Name = "EncounterInfoForm";
        StartPosition = FormStartPosition.CenterParent;
        Text = "遭遇";
        ((System.ComponentModel.ISupportInitialize)ConditionValuesDataGridView).EndInit();
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion
    private TextBox MethodTextBox;
    private TextBox ChanceTextBox;
    private Label ChanceCaptionLabel;
    private Button MethodButton;
    private Label LevelCaptionLabel;
    private TextBox MinLevelTextBox;
    private TextBox MaxLevelTextBox;
    private Label LevelRangeLabel;
    private Label ConditionValueCaptionLabel;
    private DataGridView ConditionValuesDataGridView;
    private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
    private DataGridViewButtonColumn dataGridViewButtonColumn3;
    private Button CloseButton;
    private Button PropertyButton;
}