namespace Kos.PokeAPI.Forms;

partial class PastMoveStatValuesInfoForm
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
        DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
        AccuracyTextBox = new TextBox();
        AccuracyCaptionLabel = new Label();
        EffectChanceCaptionLabel = new Label();
        EffectChanceTextBox = new TextBox();
        PowerTextBox = new TextBox();
        PowerCaptionLabel = new Label();
        PPTextBox = new TextBox();
        PPCaptionLabel = new Label();
        TypeTextBox = new TextBox();
        TypeCaptionLabel = new Label();
        VersionGroupTextBox = new TextBox();
        VersionGroupCaptionLabel = new Label();
        VersionGroupDetailButton = new Button();
        TypeDetailButton = new Button();
        CloseButton = new Button();
        EffectEntriesDataGridView = new DataGridView();
        EffectColumn = new DataGridViewTextBoxColumn();
        EffectDetailColumn = new DataGridViewButtonColumn();
        ((System.ComponentModel.ISupportInitialize)EffectEntriesDataGridView).BeginInit();
        SuspendLayout();
        // 
        // AccuracyTextBox
        // 
        AccuracyTextBox.Location = new Point(122, 102);
        AccuracyTextBox.Name = "AccuracyTextBox";
        AccuracyTextBox.ReadOnly = true;
        AccuracyTextBox.Size = new Size(185, 24);
        AccuracyTextBox.TabIndex = 9;
        AccuracyTextBox.Text = "100";
        // 
        // AccuracyCaptionLabel
        // 
        AccuracyCaptionLabel.AutoSize = true;
        AccuracyCaptionLabel.Font = new Font("Meiryo UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 128);
        AccuracyCaptionLabel.Location = new Point(69, 105);
        AccuracyCaptionLabel.Name = "AccuracyCaptionLabel";
        AccuracyCaptionLabel.Size = new Size(47, 17);
        AccuracyCaptionLabel.TabIndex = 8;
        AccuracyCaptionLabel.Text = "命中率";
        // 
        // EffectChanceCaptionLabel
        // 
        EffectChanceCaptionLabel.AutoSize = true;
        EffectChanceCaptionLabel.Font = new Font("Meiryo UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 128);
        EffectChanceCaptionLabel.Location = new Point(43, 135);
        EffectChanceCaptionLabel.Name = "EffectChanceCaptionLabel";
        EffectChanceCaptionLabel.Size = new Size(73, 17);
        EffectChanceCaptionLabel.TabIndex = 10;
        EffectChanceCaptionLabel.Text = "効果発生率";
        // 
        // EffectChanceTextBox
        // 
        EffectChanceTextBox.Location = new Point(122, 132);
        EffectChanceTextBox.Name = "EffectChanceTextBox";
        EffectChanceTextBox.ReadOnly = true;
        EffectChanceTextBox.Size = new Size(185, 24);
        EffectChanceTextBox.TabIndex = 11;
        EffectChanceTextBox.Text = "100";
        // 
        // PowerTextBox
        // 
        PowerTextBox.Location = new Point(122, 162);
        PowerTextBox.Name = "PowerTextBox";
        PowerTextBox.ReadOnly = true;
        PowerTextBox.Size = new Size(185, 24);
        PowerTextBox.TabIndex = 13;
        PowerTextBox.Text = "100";
        // 
        // PowerCaptionLabel
        // 
        PowerCaptionLabel.AutoSize = true;
        PowerCaptionLabel.Font = new Font("Meiryo UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 128);
        PowerCaptionLabel.Location = new Point(82, 165);
        PowerCaptionLabel.Name = "PowerCaptionLabel";
        PowerCaptionLabel.Size = new Size(34, 17);
        PowerCaptionLabel.TabIndex = 12;
        PowerCaptionLabel.Text = "威力";
        // 
        // PPTextBox
        // 
        PPTextBox.Location = new Point(122, 72);
        PPTextBox.Name = "PPTextBox";
        PPTextBox.ReadOnly = true;
        PPTextBox.Size = new Size(185, 24);
        PPTextBox.TabIndex = 7;
        PPTextBox.Text = "100";
        // 
        // PPCaptionLabel
        // 
        PPCaptionLabel.AutoSize = true;
        PPCaptionLabel.Font = new Font("Meiryo UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 128);
        PPCaptionLabel.Location = new Point(64, 75);
        PPCaptionLabel.Name = "PPCaptionLabel";
        PPCaptionLabel.Size = new Size(52, 17);
        PPCaptionLabel.TabIndex = 6;
        PPCaptionLabel.Text = "消費PP";
        // 
        // TypeTextBox
        // 
        TypeTextBox.Location = new Point(122, 42);
        TypeTextBox.Name = "TypeTextBox";
        TypeTextBox.ReadOnly = true;
        TypeTextBox.Size = new Size(185, 24);
        TypeTextBox.TabIndex = 4;
        TypeTextBox.Text = "Normal";
        // 
        // TypeCaptionLabel
        // 
        TypeCaptionLabel.AutoSize = true;
        TypeCaptionLabel.Font = new Font("Meiryo UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 128);
        TypeCaptionLabel.Location = new Point(76, 45);
        TypeCaptionLabel.Name = "TypeCaptionLabel";
        TypeCaptionLabel.Size = new Size(40, 17);
        TypeCaptionLabel.TabIndex = 3;
        TypeCaptionLabel.Text = "タイプ";
        // 
        // VersionGroupTextBox
        // 
        VersionGroupTextBox.Location = new Point(122, 12);
        VersionGroupTextBox.Name = "VersionGroupTextBox";
        VersionGroupTextBox.ReadOnly = true;
        VersionGroupTextBox.Size = new Size(185, 24);
        VersionGroupTextBox.TabIndex = 1;
        VersionGroupTextBox.Text = "Normal";
        // 
        // VersionGroupCaptionLabel
        // 
        VersionGroupCaptionLabel.AutoSize = true;
        VersionGroupCaptionLabel.Font = new Font("Meiryo UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 128);
        VersionGroupCaptionLabel.Location = new Point(12, 15);
        VersionGroupCaptionLabel.Name = "VersionGroupCaptionLabel";
        VersionGroupCaptionLabel.Size = new Size(104, 17);
        VersionGroupCaptionLabel.TabIndex = 0;
        VersionGroupCaptionLabel.Text = "バージョングループ";
        // 
        // VersionGroupDetailButton
        // 
        VersionGroupDetailButton.Location = new Point(313, 11);
        VersionGroupDetailButton.Name = "VersionGroupDetailButton";
        VersionGroupDetailButton.Size = new Size(53, 24);
        VersionGroupDetailButton.TabIndex = 2;
        VersionGroupDetailButton.Text = "詳細";
        VersionGroupDetailButton.UseVisualStyleBackColor = true;
        VersionGroupDetailButton.Click += VersionGroupDetailButton_Click;
        // 
        // TypeDetailButton
        // 
        TypeDetailButton.Location = new Point(313, 39);
        TypeDetailButton.Name = "TypeDetailButton";
        TypeDetailButton.Size = new Size(53, 27);
        TypeDetailButton.TabIndex = 5;
        TypeDetailButton.Text = "詳細";
        TypeDetailButton.UseVisualStyleBackColor = true;
        TypeDetailButton.Click += TypeDetailButton_Click;
        // 
        // CloseButton
        // 
        CloseButton.Location = new Point(657, 487);
        CloseButton.Name = "CloseButton";
        CloseButton.Size = new Size(63, 35);
        CloseButton.TabIndex = 15;
        CloseButton.Text = "閉じる";
        CloseButton.UseVisualStyleBackColor = true;
        CloseButton.Click += CloseButton_Click;
        // 
        // EffectEntriesDataGridView
        // 
        EffectEntriesDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        EffectEntriesDataGridView.Columns.AddRange(new DataGridViewColumn[] { EffectColumn, EffectDetailColumn });
        EffectEntriesDataGridView.Location = new Point(13, 192);
        EffectEntriesDataGridView.Margin = new Padding(4, 3, 4, 3);
        EffectEntriesDataGridView.Name = "EffectEntriesDataGridView";
        EffectEntriesDataGridView.RowHeadersVisible = false;
        EffectEntriesDataGridView.Size = new Size(707, 289);
        EffectEntriesDataGridView.TabIndex = 14;
        EffectEntriesDataGridView.CellClick += EffectEntriesDataGridView_CellClick;
        EffectEntriesDataGridView.CellDoubleClick += EffectEntriesDataGridView_CellDoubleClick;
        // 
        // EffectColumn
        // 
        EffectColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
        EffectColumn.DataPropertyName = "ShortEffect";
        dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
        EffectColumn.DefaultCellStyle = dataGridViewCellStyle1;
        EffectColumn.HeaderText = "効果";
        EffectColumn.Name = "EffectColumn";
        EffectColumn.ReadOnly = true;
        EffectColumn.Width = 59;
        // 
        // EffectDetailColumn
        // 
        EffectDetailColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
        EffectDetailColumn.HeaderText = "詳細";
        EffectDetailColumn.Name = "EffectDetailColumn";
        EffectDetailColumn.Text = "詳細";
        EffectDetailColumn.UseColumnTextForButtonValue = true;
        EffectDetailColumn.Width = 40;
        // 
        // PastMoveStatValuesInfoForm
        // 
        AutoScaleDimensions = new SizeF(9F, 17F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(735, 534);
        Controls.Add(EffectEntriesDataGridView);
        Controls.Add(CloseButton);
        Controls.Add(TypeDetailButton);
        Controls.Add(VersionGroupDetailButton);
        Controls.Add(VersionGroupCaptionLabel);
        Controls.Add(VersionGroupTextBox);
        Controls.Add(TypeCaptionLabel);
        Controls.Add(TypeTextBox);
        Controls.Add(PPCaptionLabel);
        Controls.Add(PPTextBox);
        Controls.Add(PowerCaptionLabel);
        Controls.Add(PowerTextBox);
        Controls.Add(EffectChanceTextBox);
        Controls.Add(EffectChanceCaptionLabel);
        Controls.Add(AccuracyTextBox);
        Controls.Add(AccuracyCaptionLabel);
        Font = new Font("Meiryo UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 128);
        FormBorderStyle = FormBorderStyle.FixedSingle;
        Margin = new Padding(4, 3, 4, 3);
        MaximizeBox = false;
        Name = "PastMoveStatValuesInfoForm";
        StartPosition = FormStartPosition.CenterParent;
        Text = "技がもつ過去のステータス値";
        ((System.ComponentModel.ISupportInitialize)EffectEntriesDataGridView).EndInit();
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private TextBox AccuracyTextBox;
    private Label AccuracyCaptionLabel;
    private Label EffectChanceCaptionLabel;
    private TextBox EffectChanceTextBox;
    private TextBox PowerTextBox;
    private Label PowerCaptionLabel;
    private TextBox PPTextBox;
    private Label PPCaptionLabel;
    private TextBox TypeTextBox;
    private Label TypeCaptionLabel;
    private TextBox VersionGroupTextBox;
    private Label VersionGroupCaptionLabel;
    private Button VersionGroupDetailButton;
    private Button TypeDetailButton;
    private Button CloseButton;
    private DataGridView EffectEntriesDataGridView;
    private DataGridViewTextBoxColumn EffectColumn;
    private DataGridViewButtonColumn EffectDetailColumn;
}