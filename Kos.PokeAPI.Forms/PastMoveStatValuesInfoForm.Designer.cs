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
        DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
        AccuracyTextBox = new TextBox();
        AccuracyCaptionLabel = new Label();
        EffectChanceCaptionLabel = new Label();
        EffectChanceTextBox = new TextBox();
        PowerTextBox = new TextBox();
        PowerCaptionLabel = new Label();
        PPTextBox = new TextBox();
        PPCaptionLabel = new Label();
        TypeTextBox = new TextBox();
        VersionGroupTextBox = new TextBox();
        VersionGroupButton = new Button();
        TypeButton = new Button();
        CloseButton = new Button();
        EffectEntriesDataGridView = new DataGridView();
        EffectColumn = new DataGridViewTextBoxColumn();
        EffectDetailColumn = new DataGridViewButtonColumn();
        PropertyButton = new Button();
        ((System.ComponentModel.ISupportInitialize)EffectEntriesDataGridView).BeginInit();
        SuspendLayout();
        // 
        // AccuracyTextBox
        // 
        AccuracyTextBox.Location = new Point(131, 105);
        AccuracyTextBox.Name = "AccuracyTextBox";
        AccuracyTextBox.ReadOnly = true;
        AccuracyTextBox.Size = new Size(185, 24);
        AccuracyTextBox.TabIndex = 7;
        AccuracyTextBox.Text = "100";
        // 
        // AccuracyCaptionLabel
        // 
        AccuracyCaptionLabel.AutoSize = true;
        AccuracyCaptionLabel.Font = new Font("Meiryo UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 128);
        AccuracyCaptionLabel.Location = new Point(82, 108);
        AccuracyCaptionLabel.Name = "AccuracyCaptionLabel";
        AccuracyCaptionLabel.Size = new Size(47, 17);
        AccuracyCaptionLabel.TabIndex = 6;
        AccuracyCaptionLabel.Text = "命中率";
        // 
        // EffectChanceCaptionLabel
        // 
        EffectChanceCaptionLabel.AutoSize = true;
        EffectChanceCaptionLabel.Font = new Font("Meiryo UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 128);
        EffectChanceCaptionLabel.Location = new Point(52, 138);
        EffectChanceCaptionLabel.Name = "EffectChanceCaptionLabel";
        EffectChanceCaptionLabel.Size = new Size(73, 17);
        EffectChanceCaptionLabel.TabIndex = 8;
        EffectChanceCaptionLabel.Text = "効果発生率";
        // 
        // EffectChanceTextBox
        // 
        EffectChanceTextBox.Location = new Point(131, 135);
        EffectChanceTextBox.Name = "EffectChanceTextBox";
        EffectChanceTextBox.ReadOnly = true;
        EffectChanceTextBox.Size = new Size(185, 24);
        EffectChanceTextBox.TabIndex = 9;
        EffectChanceTextBox.Text = "100";
        // 
        // PowerTextBox
        // 
        PowerTextBox.Location = new Point(131, 165);
        PowerTextBox.Name = "PowerTextBox";
        PowerTextBox.ReadOnly = true;
        PowerTextBox.Size = new Size(185, 24);
        PowerTextBox.TabIndex = 11;
        PowerTextBox.Text = "100";
        // 
        // PowerCaptionLabel
        // 
        PowerCaptionLabel.AutoSize = true;
        PowerCaptionLabel.Font = new Font("Meiryo UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 128);
        PowerCaptionLabel.Location = new Point(91, 168);
        PowerCaptionLabel.Name = "PowerCaptionLabel";
        PowerCaptionLabel.Size = new Size(34, 17);
        PowerCaptionLabel.TabIndex = 10;
        PowerCaptionLabel.Text = "威力";
        // 
        // PPTextBox
        // 
        PPTextBox.Location = new Point(131, 73);
        PPTextBox.Name = "PPTextBox";
        PPTextBox.ReadOnly = true;
        PPTextBox.Size = new Size(185, 24);
        PPTextBox.TabIndex = 5;
        PPTextBox.Text = "100";
        // 
        // PPCaptionLabel
        // 
        PPCaptionLabel.AutoSize = true;
        PPCaptionLabel.Font = new Font("Meiryo UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 128);
        PPCaptionLabel.Location = new Point(73, 76);
        PPCaptionLabel.Name = "PPCaptionLabel";
        PPCaptionLabel.Size = new Size(52, 17);
        PPCaptionLabel.TabIndex = 4;
        PPCaptionLabel.Text = "消費PP";
        // 
        // TypeTextBox
        // 
        TypeTextBox.Location = new Point(131, 43);
        TypeTextBox.Name = "TypeTextBox";
        TypeTextBox.ReadOnly = true;
        TypeTextBox.Size = new Size(185, 24);
        TypeTextBox.TabIndex = 3;
        TypeTextBox.Text = "Normal";
        // 
        // VersionGroupTextBox
        // 
        VersionGroupTextBox.Location = new Point(131, 13);
        VersionGroupTextBox.Name = "VersionGroupTextBox";
        VersionGroupTextBox.ReadOnly = true;
        VersionGroupTextBox.Size = new Size(185, 24);
        VersionGroupTextBox.TabIndex = 1;
        VersionGroupTextBox.Text = "Normal";
        // 
        // VersionGroupButton
        // 
        VersionGroupButton.Location = new Point(12, 12);
        VersionGroupButton.Name = "VersionGroupButton";
        VersionGroupButton.Size = new Size(113, 24);
        VersionGroupButton.TabIndex = 0;
        VersionGroupButton.Text = "バージョングループ";
        VersionGroupButton.UseVisualStyleBackColor = true;
        VersionGroupButton.Click += VersionGroupButton_Click;
        // 
        // TypeButton
        // 
        TypeButton.Location = new Point(13, 45);
        TypeButton.Name = "TypeButton";
        TypeButton.Size = new Size(112, 27);
        TypeButton.TabIndex = 2;
        TypeButton.Text = "タイプ";
        TypeButton.UseVisualStyleBackColor = true;
        TypeButton.Click += TypeButton_Click;
        // 
        // CloseButton
        // 
        CloseButton.Location = new Point(647, 490);
        CloseButton.Name = "CloseButton";
        CloseButton.Size = new Size(76, 35);
        CloseButton.TabIndex = 14;
        CloseButton.Text = "閉じる";
        CloseButton.UseVisualStyleBackColor = true;
        CloseButton.Click += CloseButton_Click;
        // 
        // EffectEntriesDataGridView
        // 
        EffectEntriesDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        EffectEntriesDataGridView.Columns.AddRange(new DataGridViewColumn[] { EffectColumn, EffectDetailColumn });
        EffectEntriesDataGridView.Location = new Point(13, 195);
        EffectEntriesDataGridView.Margin = new Padding(4, 3, 4, 3);
        EffectEntriesDataGridView.Name = "EffectEntriesDataGridView";
        EffectEntriesDataGridView.RowHeadersVisible = false;
        EffectEntriesDataGridView.Size = new Size(707, 289);
        EffectEntriesDataGridView.TabIndex = 12;
        EffectEntriesDataGridView.CellClick += EffectEntriesDataGridView_CellClick;
        EffectEntriesDataGridView.CellDoubleClick += EffectEntriesDataGridView_CellDoubleClick;
        // 
        // EffectColumn
        // 
        EffectColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
        EffectColumn.DataPropertyName = "ShortEffect";
        dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
        EffectColumn.DefaultCellStyle = dataGridViewCellStyle2;
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
        // PropertyButton
        // 
        PropertyButton.Location = new Point(565, 490);
        PropertyButton.Name = "PropertyButton";
        PropertyButton.Size = new Size(76, 35);
        PropertyButton.TabIndex = 13;
        PropertyButton.Text = "プロパティ";
        PropertyButton.UseVisualStyleBackColor = true;
        PropertyButton.Click += PropertyButton_Click;
        // 
        // PastMoveStatValuesInfoForm
        // 
        AutoScaleDimensions = new SizeF(9F, 17F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(735, 534);
        Controls.Add(PropertyButton);
        Controls.Add(EffectEntriesDataGridView);
        Controls.Add(CloseButton);
        Controls.Add(TypeButton);
        Controls.Add(VersionGroupButton);
        Controls.Add(VersionGroupTextBox);
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
    private TextBox VersionGroupTextBox;
    private Button VersionGroupButton;
    private Button TypeButton;
    private Button CloseButton;
    private DataGridView EffectEntriesDataGridView;
    private DataGridViewTextBoxColumn EffectColumn;
    private DataGridViewButtonColumn EffectDetailColumn;
    private Button PropertyButton;
}