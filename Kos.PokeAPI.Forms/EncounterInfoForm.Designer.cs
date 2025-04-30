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
        MethodCaptionLabel = new Label();
        MethodTextBox = new TextBox();
        ChanceTextBox = new TextBox();
        ChanceCaptionLabel = new Label();
        MethodDetailButton = new Button();
        LevelCaptionLabel = new Label();
        MinLevelTextBox = new TextBox();
        MaxLevelTextBox = new TextBox();
        LevelRangeLabel = new Label();
        ConditionValueCaptionLabel = new Label();
        ConditionValuesDataGridView = new DataGridView();
        dataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
        dataGridViewButtonColumn3 = new DataGridViewButtonColumn();
        CloseButton = new Button();
        ((System.ComponentModel.ISupportInitialize)ConditionValuesDataGridView).BeginInit();
        SuspendLayout();
        // 
        // MethodCaptionLabel
        // 
        MethodCaptionLabel.AutoSize = true;
        MethodCaptionLabel.Font = new Font("Meiryo UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 128);
        MethodCaptionLabel.Location = new Point(12, 15);
        MethodCaptionLabel.Name = "MethodCaptionLabel";
        MethodCaptionLabel.Size = new Size(60, 17);
        MethodCaptionLabel.TabIndex = 0;
        MethodCaptionLabel.Text = "遭遇方法";
        // 
        // MethodTextBox
        // 
        MethodTextBox.Location = new Point(84, 12);
        MethodTextBox.Name = "MethodTextBox";
        MethodTextBox.ReadOnly = true;
        MethodTextBox.Size = new Size(129, 24);
        MethodTextBox.TabIndex = 1;
        MethodTextBox.Text = "ピカチュウ";
        // 
        // ChanceTextBox
        // 
        ChanceTextBox.Location = new Point(84, 42);
        ChanceTextBox.Name = "ChanceTextBox";
        ChanceTextBox.ReadOnly = true;
        ChanceTextBox.Size = new Size(129, 24);
        ChanceTextBox.TabIndex = 4;
        ChanceTextBox.Text = "ピカチュウ";
        // 
        // ChanceCaptionLabel
        // 
        ChanceCaptionLabel.AutoSize = true;
        ChanceCaptionLabel.Font = new Font("Meiryo UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 128);
        ChanceCaptionLabel.Location = new Point(25, 45);
        ChanceCaptionLabel.Name = "ChanceCaptionLabel";
        ChanceCaptionLabel.Size = new Size(47, 17);
        ChanceCaptionLabel.TabIndex = 3;
        ChanceCaptionLabel.Text = "遭遇率";
        // 
        // MethodDetailButton
        // 
        MethodDetailButton.Location = new Point(219, 10);
        MethodDetailButton.Name = "MethodDetailButton";
        MethodDetailButton.Size = new Size(53, 27);
        MethodDetailButton.TabIndex = 2;
        MethodDetailButton.Text = "詳細";
        MethodDetailButton.UseVisualStyleBackColor = true;
        MethodDetailButton.Click += MethodDetailButton_Click;
        // 
        // LevelCaptionLabel
        // 
        LevelCaptionLabel.AutoSize = true;
        LevelCaptionLabel.Font = new Font("Meiryo UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 128);
        LevelCaptionLabel.Location = new Point(32, 75);
        LevelCaptionLabel.Name = "LevelCaptionLabel";
        LevelCaptionLabel.Size = new Size(40, 17);
        LevelCaptionLabel.TabIndex = 5;
        LevelCaptionLabel.Text = "レベル";
        // 
        // MinLevelTextBox
        // 
        MinLevelTextBox.Location = new Point(84, 72);
        MinLevelTextBox.Name = "MinLevelTextBox";
        MinLevelTextBox.ReadOnly = true;
        MinLevelTextBox.Size = new Size(39, 24);
        MinLevelTextBox.TabIndex = 6;
        MinLevelTextBox.Text = "100";
        // 
        // MaxLevelTextBox
        // 
        MaxLevelTextBox.Location = new Point(156, 76);
        MaxLevelTextBox.Name = "MaxLevelTextBox";
        MaxLevelTextBox.ReadOnly = true;
        MaxLevelTextBox.Size = new Size(39, 24);
        MaxLevelTextBox.TabIndex = 8;
        MaxLevelTextBox.Text = "100";
        // 
        // LevelRangeLabel
        // 
        LevelRangeLabel.AutoSize = true;
        LevelRangeLabel.Font = new Font("Meiryo UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 128);
        LevelRangeLabel.Location = new Point(129, 79);
        LevelRangeLabel.Name = "LevelRangeLabel";
        LevelRangeLabel.Size = new Size(21, 17);
        LevelRangeLabel.TabIndex = 7;
        LevelRangeLabel.Text = "～";
        // 
        // ConditionValueCaptionLabel
        // 
        ConditionValueCaptionLabel.AutoSize = true;
        ConditionValueCaptionLabel.Font = new Font("Meiryo UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 128);
        ConditionValueCaptionLabel.Location = new Point(278, 15);
        ConditionValueCaptionLabel.Name = "ConditionValueCaptionLabel";
        ConditionValueCaptionLabel.Size = new Size(73, 17);
        ConditionValueCaptionLabel.TabIndex = 9;
        ConditionValueCaptionLabel.Text = "遭遇条件値";
        // 
        // ConditionValuesDataGridView
        // 
        ConditionValuesDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        ConditionValuesDataGridView.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn3, dataGridViewButtonColumn3 });
        ConditionValuesDataGridView.Location = new Point(278, 35);
        ConditionValuesDataGridView.Name = "ConditionValuesDataGridView";
        ConditionValuesDataGridView.RowHeadersVisible = false;
        ConditionValuesDataGridView.Size = new Size(260, 150);
        ConditionValuesDataGridView.TabIndex = 10;
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
        CloseButton.Location = new Point(453, 191);
        CloseButton.Margin = new Padding(4, 3, 4, 3);
        CloseButton.Name = "CloseButton";
        CloseButton.Size = new Size(85, 43);
        CloseButton.TabIndex = 11;
        CloseButton.Text = "閉じる";
        CloseButton.UseVisualStyleBackColor = true;
        CloseButton.Click += CloseButton_Click;
        // 
        // EncounterInfoForm
        // 
        AutoScaleDimensions = new SizeF(9F, 17F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(562, 249);
        Controls.Add(CloseButton);
        Controls.Add(ConditionValuesDataGridView);
        Controls.Add(ConditionValueCaptionLabel);
        Controls.Add(LevelRangeLabel);
        Controls.Add(MaxLevelTextBox);
        Controls.Add(MinLevelTextBox);
        Controls.Add(LevelCaptionLabel);
        Controls.Add(MethodDetailButton);
        Controls.Add(ChanceCaptionLabel);
        Controls.Add(ChanceTextBox);
        Controls.Add(MethodTextBox);
        Controls.Add(MethodCaptionLabel);
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

    private Label MethodCaptionLabel;
    private TextBox MethodTextBox;
    private TextBox ChanceTextBox;
    private Label ChanceCaptionLabel;
    private Button MethodDetailButton;
    private Label LevelCaptionLabel;
    private TextBox MinLevelTextBox;
    private TextBox MaxLevelTextBox;
    private Label LevelRangeLabel;
    private Label ConditionValueCaptionLabel;
    private DataGridView ConditionValuesDataGridView;
    private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
    private DataGridViewButtonColumn dataGridViewButtonColumn3;
    private Button CloseButton;
}