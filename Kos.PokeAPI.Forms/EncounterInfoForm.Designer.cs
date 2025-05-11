namespace Kos.PokeAPI.Forms;

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
        MethodTextBox.Location = new Point(95, 12);
        MethodTextBox.Name = "MethodTextBox";
        MethodTextBox.ReadOnly = true;
        MethodTextBox.Size = new Size(129, 24);
        MethodTextBox.TabIndex = 1;
        MethodTextBox.Text = "ピカチュウ";
        // 
        // ChanceTextBox
        // 
        ChanceTextBox.Location = new Point(95, 42);
        ChanceTextBox.Name = "ChanceTextBox";
        ChanceTextBox.ReadOnly = true;
        ChanceTextBox.Size = new Size(129, 24);
        ChanceTextBox.TabIndex = 3;
        ChanceTextBox.Text = "ピカチュウ";
        // 
        // ChanceCaptionLabel
        // 
        ChanceCaptionLabel.AutoSize = true;
        ChanceCaptionLabel.Font = new Font("Meiryo UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 128);
        ChanceCaptionLabel.Location = new Point(42, 45);
        ChanceCaptionLabel.Name = "ChanceCaptionLabel";
        ChanceCaptionLabel.Size = new Size(47, 17);
        ChanceCaptionLabel.TabIndex = 2;
        ChanceCaptionLabel.Text = "遭遇率";
        // 
        // MethodButton
        // 
        MethodButton.Location = new Point(12, 10);
        MethodButton.Name = "MethodButton";
        MethodButton.Size = new Size(77, 27);
        MethodButton.TabIndex = 0;
        MethodButton.Text = "遭遇方法";
        MethodButton.UseVisualStyleBackColor = true;
        MethodButton.Click += MethodButton_Click;
        // 
        // LevelCaptionLabel
        // 
        LevelCaptionLabel.AutoSize = true;
        LevelCaptionLabel.Font = new Font("Meiryo UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 128);
        LevelCaptionLabel.Location = new Point(49, 75);
        LevelCaptionLabel.Name = "LevelCaptionLabel";
        LevelCaptionLabel.Size = new Size(40, 17);
        LevelCaptionLabel.TabIndex = 4;
        LevelCaptionLabel.Text = "レベル";
        // 
        // MinLevelTextBox
        // 
        MinLevelTextBox.Location = new Point(95, 72);
        MinLevelTextBox.Name = "MinLevelTextBox";
        MinLevelTextBox.ReadOnly = true;
        MinLevelTextBox.Size = new Size(39, 24);
        MinLevelTextBox.TabIndex = 5;
        MinLevelTextBox.Text = "100";
        // 
        // MaxLevelTextBox
        // 
        MaxLevelTextBox.Location = new Point(167, 72);
        MaxLevelTextBox.Name = "MaxLevelTextBox";
        MaxLevelTextBox.ReadOnly = true;
        MaxLevelTextBox.Size = new Size(39, 24);
        MaxLevelTextBox.TabIndex = 7;
        MaxLevelTextBox.Text = "100";
        // 
        // LevelRangeLabel
        // 
        LevelRangeLabel.AutoSize = true;
        LevelRangeLabel.Font = new Font("Meiryo UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 128);
        LevelRangeLabel.Location = new Point(140, 75);
        LevelRangeLabel.Name = "LevelRangeLabel";
        LevelRangeLabel.Size = new Size(21, 17);
        LevelRangeLabel.TabIndex = 6;
        LevelRangeLabel.Text = "～";
        // 
        // ConditionValueCaptionLabel
        // 
        ConditionValueCaptionLabel.AutoSize = true;
        ConditionValueCaptionLabel.Font = new Font("Meiryo UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 128);
        ConditionValueCaptionLabel.Location = new Point(230, 15);
        ConditionValueCaptionLabel.Name = "ConditionValueCaptionLabel";
        ConditionValueCaptionLabel.Size = new Size(73, 17);
        ConditionValueCaptionLabel.TabIndex = 8;
        ConditionValueCaptionLabel.Text = "遭遇条件値";
        // 
        // ConditionValuesDataGridView
        // 
        ConditionValuesDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        ConditionValuesDataGridView.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn3, dataGridViewButtonColumn3 });
        ConditionValuesDataGridView.Location = new Point(230, 35);
        ConditionValuesDataGridView.Name = "ConditionValuesDataGridView";
        ConditionValuesDataGridView.RowHeadersVisible = false;
        ConditionValuesDataGridView.Size = new Size(260, 150);
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
        dataGridViewTextBoxColumn3.Width = 72;
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
        // CloseButton
        // 
        CloseButton.Location = new Point(414, 191);
        CloseButton.Margin = new Padding(4, 3, 4, 3);
        CloseButton.Name = "CloseButton";
        CloseButton.Size = new Size(76, 35);
        CloseButton.TabIndex = 11;
        CloseButton.Text = "閉じる";
        CloseButton.UseVisualStyleBackColor = true;
        CloseButton.Click += CloseButton_Click;
        // 
        // PropertyButton
        // 
        PropertyButton.Location = new Point(330, 191);
        PropertyButton.Margin = new Padding(4, 3, 4, 3);
        PropertyButton.Name = "PropertyButton";
        PropertyButton.Size = new Size(76, 35);
        PropertyButton.TabIndex = 10;
        PropertyButton.Text = "プロパティ";
        PropertyButton.UseVisualStyleBackColor = true;
        PropertyButton.Click += PropertyButton_Click;
        // 
        // EncounterInfoForm
        // 
        AutoScaleDimensions = new SizeF(9F, 17F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(504, 237);
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
        Font = new Font("Meiryo UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 128);
        FormBorderStyle = FormBorderStyle.FixedSingle;
        Margin = new Padding(4, 3, 4, 3);
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