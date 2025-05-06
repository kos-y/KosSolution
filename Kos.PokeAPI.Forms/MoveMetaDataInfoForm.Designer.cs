namespace Kos.PokeAPI.Forms;

partial class MoveMetaDataInfoForm
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
        CategoryDetailButton = new Button();
        CategoryCaptionLabel = new Label();
        CategoryTextBox = new TextBox();
        HitsCaptionLabel = new Label();
        MinHitsTextBox = new TextBox();
        MaxHitsTextBox = new TextBox();
        HitsRangeLabel = new Label();
        TurnCaptionLabel = new Label();
        MinTurnsTextBox = new TextBox();
        TurnsRangeLabel = new Label();
        MaxTurnsTextBox = new TextBox();
        DrainCaptionLabel = new Label();
        DrainTextBox = new TextBox();
        HealingTextBox = new TextBox();
        HealingCaptionLabel = new Label();
        AilmentTextBox = new TextBox();
        AilmentDetailButton = new Button();
        AilmentCaptionLabel = new Label();
        AilmentChanceTextBox = new TextBox();
        AilmentChanceCaptionLabel = new Label();
        FlinchChanceTextBox = new TextBox();
        FlinchChanceCaptionLabel = new Label();
        StatChanceTextBox = new TextBox();
        StateChanceCaptionLabel = new Label();
        CloseButton = new Button();
        CritRateTextBox = new TextBox();
        CritRateCaptionLabel = new Label();
        SuspendLayout();
        // 
        // CategoryDetailButton
        // 
        CategoryDetailButton.Location = new Point(316, 2);
        CategoryDetailButton.Name = "CategoryDetailButton";
        CategoryDetailButton.Size = new Size(53, 30);
        CategoryDetailButton.TabIndex = 2;
        CategoryDetailButton.Text = "詳細";
        CategoryDetailButton.UseVisualStyleBackColor = true;
        // 
        // CategoryCaptionLabel
        // 
        CategoryCaptionLabel.AutoSize = true;
        CategoryCaptionLabel.Font = new Font("Meiryo UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 128);
        CategoryCaptionLabel.Location = new Point(122, 9);
        CategoryCaptionLabel.Name = "CategoryCaptionLabel";
        CategoryCaptionLabel.Size = new Size(59, 17);
        CategoryCaptionLabel.TabIndex = 0;
        CategoryCaptionLabel.Text = "カテゴリー";
        // 
        // CategoryTextBox
        // 
        CategoryTextBox.Location = new Point(187, 6);
        CategoryTextBox.Name = "CategoryTextBox";
        CategoryTextBox.ReadOnly = true;
        CategoryTextBox.Size = new Size(124, 24);
        CategoryTextBox.TabIndex = 1;
        CategoryTextBox.Text = "Normal";
        // 
        // HitsCaptionLabel
        // 
        HitsCaptionLabel.AutoSize = true;
        HitsCaptionLabel.Font = new Font("Meiryo UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 128);
        HitsCaptionLabel.Location = new Point(121, 39);
        HitsCaptionLabel.Name = "HitsCaptionLabel";
        HitsCaptionLabel.Size = new Size(60, 17);
        HitsCaptionLabel.TabIndex = 3;
        HitsCaptionLabel.Text = "攻撃回数";
        // 
        // MinHitsTextBox
        // 
        MinHitsTextBox.Location = new Point(187, 36);
        MinHitsTextBox.Name = "MinHitsTextBox";
        MinHitsTextBox.ReadOnly = true;
        MinHitsTextBox.Size = new Size(37, 24);
        MinHitsTextBox.TabIndex = 4;
        MinHitsTextBox.Text = "99";
        // 
        // MaxHitsTextBox
        // 
        MaxHitsTextBox.Location = new Point(252, 36);
        MaxHitsTextBox.Name = "MaxHitsTextBox";
        MaxHitsTextBox.ReadOnly = true;
        MaxHitsTextBox.Size = new Size(37, 24);
        MaxHitsTextBox.TabIndex = 6;
        MaxHitsTextBox.Text = "99";
        // 
        // HitsRangeLabel
        // 
        HitsRangeLabel.AutoSize = true;
        HitsRangeLabel.Font = new Font("Meiryo UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 128);
        HitsRangeLabel.Location = new Point(225, 39);
        HitsRangeLabel.Name = "HitsRangeLabel";
        HitsRangeLabel.Size = new Size(21, 17);
        HitsRangeLabel.TabIndex = 5;
        HitsRangeLabel.Text = "～";
        // 
        // TurnCaptionLabel
        // 
        TurnCaptionLabel.AutoSize = true;
        TurnCaptionLabel.Font = new Font("Meiryo UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 128);
        TurnCaptionLabel.Location = new Point(129, 69);
        TurnCaptionLabel.Name = "TurnCaptionLabel";
        TurnCaptionLabel.Size = new Size(52, 17);
        TurnCaptionLabel.TabIndex = 7;
        TurnCaptionLabel.Text = "ターン数";
        // 
        // MinTurnsTextBox
        // 
        MinTurnsTextBox.Location = new Point(187, 66);
        MinTurnsTextBox.Name = "MinTurnsTextBox";
        MinTurnsTextBox.ReadOnly = true;
        MinTurnsTextBox.Size = new Size(37, 24);
        MinTurnsTextBox.TabIndex = 8;
        MinTurnsTextBox.Text = "99";
        // 
        // TurnsRangeLabel
        // 
        TurnsRangeLabel.AutoSize = true;
        TurnsRangeLabel.Font = new Font("Meiryo UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 128);
        TurnsRangeLabel.Location = new Point(225, 69);
        TurnsRangeLabel.Name = "TurnsRangeLabel";
        TurnsRangeLabel.Size = new Size(21, 17);
        TurnsRangeLabel.TabIndex = 9;
        TurnsRangeLabel.Text = "～";
        // 
        // MaxTurnsTextBox
        // 
        MaxTurnsTextBox.Location = new Point(252, 66);
        MaxTurnsTextBox.Name = "MaxTurnsTextBox";
        MaxTurnsTextBox.ReadOnly = true;
        MaxTurnsTextBox.Size = new Size(37, 24);
        MaxTurnsTextBox.TabIndex = 10;
        MaxTurnsTextBox.Text = "99";
        // 
        // DrainCaptionLabel
        // 
        DrainCaptionLabel.AutoSize = true;
        DrainCaptionLabel.Font = new Font("Meiryo UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 128);
        DrainCaptionLabel.Location = new Point(134, 129);
        DrainCaptionLabel.Name = "DrainCaptionLabel";
        DrainCaptionLabel.Size = new Size(47, 17);
        DrainCaptionLabel.TabIndex = 13;
        DrainCaptionLabel.Text = "吸収量";
        // 
        // DrainTextBox
        // 
        DrainTextBox.Location = new Point(187, 126);
        DrainTextBox.Name = "DrainTextBox";
        DrainTextBox.ReadOnly = true;
        DrainTextBox.Size = new Size(56, 24);
        DrainTextBox.TabIndex = 14;
        DrainTextBox.Text = "99";
        // 
        // HealingTextBox
        // 
        HealingTextBox.Location = new Point(187, 156);
        HealingTextBox.Name = "HealingTextBox";
        HealingTextBox.ReadOnly = true;
        HealingTextBox.Size = new Size(56, 24);
        HealingTextBox.TabIndex = 16;
        HealingTextBox.Text = "99";
        // 
        // HealingCaptionLabel
        // 
        HealingCaptionLabel.AutoSize = true;
        HealingCaptionLabel.Font = new Font("Meiryo UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 128);
        HealingCaptionLabel.Location = new Point(134, 159);
        HealingCaptionLabel.Name = "HealingCaptionLabel";
        HealingCaptionLabel.Size = new Size(47, 17);
        HealingCaptionLabel.TabIndex = 15;
        HealingCaptionLabel.Text = "回復量";
        // 
        // AilmentTextBox
        // 
        AilmentTextBox.Location = new Point(187, 186);
        AilmentTextBox.Name = "AilmentTextBox";
        AilmentTextBox.ReadOnly = true;
        AilmentTextBox.Size = new Size(124, 24);
        AilmentTextBox.TabIndex = 18;
        AilmentTextBox.Text = "Normal";
        // 
        // AilmentDetailButton
        // 
        AilmentDetailButton.Location = new Point(317, 182);
        AilmentDetailButton.Name = "AilmentDetailButton";
        AilmentDetailButton.Size = new Size(53, 30);
        AilmentDetailButton.TabIndex = 19;
        AilmentDetailButton.Text = "詳細";
        AilmentDetailButton.UseVisualStyleBackColor = true;
        // 
        // AilmentCaptionLabel
        // 
        AilmentCaptionLabel.AutoSize = true;
        AilmentCaptionLabel.Font = new Font("Meiryo UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 128);
        AilmentCaptionLabel.Location = new Point(121, 189);
        AilmentCaptionLabel.Name = "AilmentCaptionLabel";
        AilmentCaptionLabel.Size = new Size(60, 17);
        AilmentCaptionLabel.TabIndex = 17;
        AilmentCaptionLabel.Text = "状態異常";
        // 
        // AilmentChanceTextBox
        // 
        AilmentChanceTextBox.Location = new Point(187, 216);
        AilmentChanceTextBox.Name = "AilmentChanceTextBox";
        AilmentChanceTextBox.ReadOnly = true;
        AilmentChanceTextBox.Size = new Size(56, 24);
        AilmentChanceTextBox.TabIndex = 21;
        AilmentChanceTextBox.Text = "99";
        // 
        // AilmentChanceCaptionLabel
        // 
        AilmentChanceCaptionLabel.AutoSize = true;
        AilmentChanceCaptionLabel.Font = new Font("Meiryo UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 128);
        AilmentChanceCaptionLabel.Location = new Point(83, 219);
        AilmentChanceCaptionLabel.Name = "AilmentChanceCaptionLabel";
        AilmentChanceCaptionLabel.Size = new Size(98, 17);
        AilmentChanceCaptionLabel.TabIndex = 20;
        AilmentChanceCaptionLabel.Text = "状態異常の確率";
        // 
        // FlinchChanceTextBox
        // 
        FlinchChanceTextBox.Location = new Point(187, 246);
        FlinchChanceTextBox.Name = "FlinchChanceTextBox";
        FlinchChanceTextBox.ReadOnly = true;
        FlinchChanceTextBox.Size = new Size(56, 24);
        FlinchChanceTextBox.TabIndex = 23;
        FlinchChanceTextBox.Text = "99";
        // 
        // FlinchChanceCaptionLabel
        // 
        FlinchChanceCaptionLabel.AutoSize = true;
        FlinchChanceCaptionLabel.Font = new Font("Meiryo UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 128);
        FlinchChanceCaptionLabel.Location = new Point(78, 249);
        FlinchChanceCaptionLabel.Name = "FlinchChanceCaptionLabel";
        FlinchChanceCaptionLabel.Size = new Size(103, 17);
        FlinchChanceCaptionLabel.TabIndex = 22;
        FlinchChanceCaptionLabel.Text = "相手ガひるむ確率";
        // 
        // StatChanceTextBox
        // 
        StatChanceTextBox.Location = new Point(187, 276);
        StatChanceTextBox.Name = "StatChanceTextBox";
        StatChanceTextBox.ReadOnly = true;
        StatChanceTextBox.Size = new Size(56, 24);
        StatChanceTextBox.TabIndex = 25;
        StatChanceTextBox.Text = "99";
        // 
        // StateChanceCaptionLabel
        // 
        StateChanceCaptionLabel.AutoSize = true;
        StateChanceCaptionLabel.Font = new Font("Meiryo UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 128);
        StateChanceCaptionLabel.Location = new Point(12, 279);
        StateChanceCaptionLabel.Name = "StateChanceCaptionLabel";
        StateChanceCaptionLabel.Size = new Size(169, 17);
        StateChanceCaptionLabel.TabIndex = 24;
        StateChanceCaptionLabel.Text = "ステータスに影響を与える確率";
        // 
        // CloseButton
        // 
        CloseButton.Location = new Point(306, 310);
        CloseButton.Name = "CloseButton";
        CloseButton.Size = new Size(63, 35);
        CloseButton.TabIndex = 26;
        CloseButton.Text = "閉じる";
        CloseButton.UseVisualStyleBackColor = true;
        CloseButton.Click += CloseButton_Click;
        // 
        // CritRateTextBox
        // 
        CritRateTextBox.Location = new Point(187, 96);
        CritRateTextBox.Name = "CritRateTextBox";
        CritRateTextBox.ReadOnly = true;
        CritRateTextBox.Size = new Size(56, 24);
        CritRateTextBox.TabIndex = 12;
        CritRateTextBox.Text = "99";
        // 
        // CritRateCaptionLabel
        // 
        CritRateCaptionLabel.AutoSize = true;
        CritRateCaptionLabel.Font = new Font("Meiryo UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 128);
        CritRateCaptionLabel.Location = new Point(134, 99);
        CritRateCaptionLabel.Name = "CritRateCaptionLabel";
        CritRateCaptionLabel.Size = new Size(47, 17);
        CritRateCaptionLabel.TabIndex = 11;
        CritRateCaptionLabel.Text = "急所率";
        // 
        // MoveMetaDataInfoForm
        // 
        AutoScaleDimensions = new SizeF(9F, 17F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(386, 358);
        Controls.Add(CritRateCaptionLabel);
        Controls.Add(CritRateTextBox);
        Controls.Add(CloseButton);
        Controls.Add(StateChanceCaptionLabel);
        Controls.Add(StatChanceTextBox);
        Controls.Add(FlinchChanceCaptionLabel);
        Controls.Add(FlinchChanceTextBox);
        Controls.Add(AilmentChanceCaptionLabel);
        Controls.Add(AilmentChanceTextBox);
        Controls.Add(AilmentCaptionLabel);
        Controls.Add(AilmentDetailButton);
        Controls.Add(AilmentTextBox);
        Controls.Add(HealingCaptionLabel);
        Controls.Add(HealingTextBox);
        Controls.Add(DrainTextBox);
        Controls.Add(DrainCaptionLabel);
        Controls.Add(MaxTurnsTextBox);
        Controls.Add(TurnsRangeLabel);
        Controls.Add(MinTurnsTextBox);
        Controls.Add(TurnCaptionLabel);
        Controls.Add(HitsRangeLabel);
        Controls.Add(MaxHitsTextBox);
        Controls.Add(MinHitsTextBox);
        Controls.Add(HitsCaptionLabel);
        Controls.Add(CategoryDetailButton);
        Controls.Add(CategoryCaptionLabel);
        Controls.Add(CategoryTextBox);
        Font = new Font("Meiryo UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 128);
        FormBorderStyle = FormBorderStyle.FixedSingle;
        Margin = new Padding(4, 3, 4, 3);
        MaximizeBox = false;
        Name = "MoveMetaDataInfoForm";
        StartPosition = FormStartPosition.CenterParent;
        Text = "技の詳細";
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private Button CategoryDetailButton;
    private Label CategoryCaptionLabel;
    private TextBox CategoryTextBox;
    private Label HitsCaptionLabel;
    private TextBox MinHitsTextBox;
    private TextBox MaxHitsTextBox;
    private Label HitsRangeLabel;
    private Label TurnCaptionLabel;
    private TextBox MinTurnsTextBox;
    private Label TurnsRangeLabel;
    private TextBox MaxTurnsTextBox;
    private Label DrainCaptionLabel;
    private TextBox DrainTextBox;
    private TextBox HealingTextBox;
    private Label HealingCaptionLabel;
    private TextBox AilmentTextBox;
    private Button AilmentDetailButton;
    private Label AilmentCaptionLabel;
    private TextBox AilmentChanceTextBox;
    private Label AilmentChanceCaptionLabel;
    private TextBox FlinchChanceTextBox;
    private Label FlinchChanceCaptionLabel;
    private TextBox StatChanceTextBox;
    private Label StateChanceCaptionLabel;
    private Button CloseButton;
    private TextBox CritRateTextBox;
    private Label CritRateCaptionLabel;
}