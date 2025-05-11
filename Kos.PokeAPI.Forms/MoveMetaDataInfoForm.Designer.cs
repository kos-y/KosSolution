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
        CategoryButton = new Button();
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
        AilmentButton = new Button();
        AilmentChanceTextBox = new TextBox();
        AilmentChanceCaptionLabel = new Label();
        FlinchChanceTextBox = new TextBox();
        FlinchChanceCaptionLabel = new Label();
        StatChanceTextBox = new TextBox();
        StateChanceCaptionLabel = new Label();
        CloseButton = new Button();
        CritRateTextBox = new TextBox();
        CritRateCaptionLabel = new Label();
        PropertyButton = new Button();
        SuspendLayout();
        // 
        // CategoryButton
        // 
        CategoryButton.Location = new Point(48, 6);
        CategoryButton.Name = "CategoryButton";
        CategoryButton.Size = new Size(78, 30);
        CategoryButton.TabIndex = 0;
        CategoryButton.Text = "カテゴリー";
        CategoryButton.UseVisualStyleBackColor = true;
        CategoryButton.Click += CategoryButton_Click;
        // 
        // CategoryTextBox
        // 
        CategoryTextBox.Location = new Point(126, 10);
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
        HitsCaptionLabel.Location = new Point(61, 43);
        HitsCaptionLabel.Name = "HitsCaptionLabel";
        HitsCaptionLabel.Size = new Size(60, 17);
        HitsCaptionLabel.TabIndex = 2;
        HitsCaptionLabel.Text = "攻撃回数";
        // 
        // MinHitsTextBox
        // 
        MinHitsTextBox.Location = new Point(127, 40);
        MinHitsTextBox.Name = "MinHitsTextBox";
        MinHitsTextBox.ReadOnly = true;
        MinHitsTextBox.Size = new Size(37, 24);
        MinHitsTextBox.TabIndex = 3;
        MinHitsTextBox.Text = "99";
        // 
        // MaxHitsTextBox
        // 
        MaxHitsTextBox.Location = new Point(192, 40);
        MaxHitsTextBox.Name = "MaxHitsTextBox";
        MaxHitsTextBox.ReadOnly = true;
        MaxHitsTextBox.Size = new Size(37, 24);
        MaxHitsTextBox.TabIndex = 5;
        MaxHitsTextBox.Text = "99";
        // 
        // HitsRangeLabel
        // 
        HitsRangeLabel.AutoSize = true;
        HitsRangeLabel.Font = new Font("Meiryo UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 128);
        HitsRangeLabel.Location = new Point(165, 43);
        HitsRangeLabel.Name = "HitsRangeLabel";
        HitsRangeLabel.Size = new Size(21, 17);
        HitsRangeLabel.TabIndex = 4;
        HitsRangeLabel.Text = "～";
        // 
        // TurnCaptionLabel
        // 
        TurnCaptionLabel.AutoSize = true;
        TurnCaptionLabel.Font = new Font("Meiryo UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 128);
        TurnCaptionLabel.Location = new Point(69, 73);
        TurnCaptionLabel.Name = "TurnCaptionLabel";
        TurnCaptionLabel.Size = new Size(52, 17);
        TurnCaptionLabel.TabIndex = 6;
        TurnCaptionLabel.Text = "ターン数";
        // 
        // MinTurnsTextBox
        // 
        MinTurnsTextBox.Location = new Point(126, 70);
        MinTurnsTextBox.Name = "MinTurnsTextBox";
        MinTurnsTextBox.ReadOnly = true;
        MinTurnsTextBox.Size = new Size(37, 24);
        MinTurnsTextBox.TabIndex = 7;
        MinTurnsTextBox.Text = "99";
        // 
        // TurnsRangeLabel
        // 
        TurnsRangeLabel.AutoSize = true;
        TurnsRangeLabel.Font = new Font("Meiryo UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 128);
        TurnsRangeLabel.Location = new Point(165, 73);
        TurnsRangeLabel.Name = "TurnsRangeLabel";
        TurnsRangeLabel.Size = new Size(21, 17);
        TurnsRangeLabel.TabIndex = 8;
        TurnsRangeLabel.Text = "～";
        // 
        // MaxTurnsTextBox
        // 
        MaxTurnsTextBox.Location = new Point(192, 70);
        MaxTurnsTextBox.Name = "MaxTurnsTextBox";
        MaxTurnsTextBox.ReadOnly = true;
        MaxTurnsTextBox.Size = new Size(37, 24);
        MaxTurnsTextBox.TabIndex = 9;
        MaxTurnsTextBox.Text = "99";
        // 
        // DrainCaptionLabel
        // 
        DrainCaptionLabel.AutoSize = true;
        DrainCaptionLabel.Font = new Font("Meiryo UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 128);
        DrainCaptionLabel.Location = new Point(73, 133);
        DrainCaptionLabel.Name = "DrainCaptionLabel";
        DrainCaptionLabel.Size = new Size(47, 17);
        DrainCaptionLabel.TabIndex = 12;
        DrainCaptionLabel.Text = "吸収量";
        // 
        // DrainTextBox
        // 
        DrainTextBox.Location = new Point(126, 130);
        DrainTextBox.Name = "DrainTextBox";
        DrainTextBox.ReadOnly = true;
        DrainTextBox.Size = new Size(56, 24);
        DrainTextBox.TabIndex = 13;
        DrainTextBox.Text = "99";
        // 
        // HealingTextBox
        // 
        HealingTextBox.Location = new Point(126, 160);
        HealingTextBox.Name = "HealingTextBox";
        HealingTextBox.ReadOnly = true;
        HealingTextBox.Size = new Size(56, 24);
        HealingTextBox.TabIndex = 15;
        HealingTextBox.Text = "99";
        // 
        // HealingCaptionLabel
        // 
        HealingCaptionLabel.AutoSize = true;
        HealingCaptionLabel.Font = new Font("Meiryo UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 128);
        HealingCaptionLabel.Location = new Point(73, 162);
        HealingCaptionLabel.Name = "HealingCaptionLabel";
        HealingCaptionLabel.Size = new Size(47, 17);
        HealingCaptionLabel.TabIndex = 14;
        HealingCaptionLabel.Text = "回復量";
        // 
        // AilmentTextBox
        // 
        AilmentTextBox.Location = new Point(127, 190);
        AilmentTextBox.Name = "AilmentTextBox";
        AilmentTextBox.ReadOnly = true;
        AilmentTextBox.Size = new Size(124, 24);
        AilmentTextBox.TabIndex = 17;
        AilmentTextBox.Text = "Normal";
        // 
        // AilmentButton
        // 
        AilmentButton.Location = new Point(48, 186);
        AilmentButton.Name = "AilmentButton";
        AilmentButton.Size = new Size(73, 30);
        AilmentButton.TabIndex = 16;
        AilmentButton.Text = "状態異常";
        AilmentButton.UseVisualStyleBackColor = true;
        AilmentButton.Click += AilmentButton_Click;
        // 
        // AilmentChanceTextBox
        // 
        AilmentChanceTextBox.Location = new Point(126, 220);
        AilmentChanceTextBox.Name = "AilmentChanceTextBox";
        AilmentChanceTextBox.ReadOnly = true;
        AilmentChanceTextBox.Size = new Size(56, 24);
        AilmentChanceTextBox.TabIndex = 19;
        AilmentChanceTextBox.Text = "99";
        // 
        // AilmentChanceCaptionLabel
        // 
        AilmentChanceCaptionLabel.AutoSize = true;
        AilmentChanceCaptionLabel.Font = new Font("Meiryo UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 128);
        AilmentChanceCaptionLabel.Location = new Point(23, 223);
        AilmentChanceCaptionLabel.Name = "AilmentChanceCaptionLabel";
        AilmentChanceCaptionLabel.Size = new Size(98, 17);
        AilmentChanceCaptionLabel.TabIndex = 18;
        AilmentChanceCaptionLabel.Text = "状態異常の確率";
        // 
        // FlinchChanceTextBox
        // 
        FlinchChanceTextBox.Location = new Point(127, 250);
        FlinchChanceTextBox.Name = "FlinchChanceTextBox";
        FlinchChanceTextBox.ReadOnly = true;
        FlinchChanceTextBox.Size = new Size(56, 24);
        FlinchChanceTextBox.TabIndex = 21;
        FlinchChanceTextBox.Text = "99";
        // 
        // FlinchChanceCaptionLabel
        // 
        FlinchChanceCaptionLabel.AutoSize = true;
        FlinchChanceCaptionLabel.Font = new Font("Meiryo UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 128);
        FlinchChanceCaptionLabel.Location = new Point(18, 253);
        FlinchChanceCaptionLabel.Name = "FlinchChanceCaptionLabel";
        FlinchChanceCaptionLabel.Size = new Size(103, 17);
        FlinchChanceCaptionLabel.TabIndex = 20;
        FlinchChanceCaptionLabel.Text = "相手ガひるむ確率";
        // 
        // StatChanceTextBox
        // 
        StatChanceTextBox.Location = new Point(126, 280);
        StatChanceTextBox.Name = "StatChanceTextBox";
        StatChanceTextBox.ReadOnly = true;
        StatChanceTextBox.Size = new Size(56, 24);
        StatChanceTextBox.TabIndex = 23;
        StatChanceTextBox.Text = "99";
        // 
        // StateChanceCaptionLabel
        // 
        StateChanceCaptionLabel.AutoSize = true;
        StateChanceCaptionLabel.Font = new Font("Meiryo UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 128);
        StateChanceCaptionLabel.Location = new Point(12, 283);
        StateChanceCaptionLabel.Name = "StateChanceCaptionLabel";
        StateChanceCaptionLabel.Size = new Size(109, 34);
        StateChanceCaptionLabel.TabIndex = 22;
        StateChanceCaptionLabel.Text = "ステータスに影響を\r\n与える確率";
        // 
        // CloseButton
        // 
        CloseButton.Location = new Point(192, 311);
        CloseButton.Name = "CloseButton";
        CloseButton.Size = new Size(76, 35);
        CloseButton.TabIndex = 25;
        CloseButton.Text = "閉じる";
        CloseButton.UseVisualStyleBackColor = true;
        CloseButton.Click += CloseButton_Click;
        // 
        // CritRateTextBox
        // 
        CritRateTextBox.Location = new Point(127, 100);
        CritRateTextBox.Name = "CritRateTextBox";
        CritRateTextBox.ReadOnly = true;
        CritRateTextBox.Size = new Size(56, 24);
        CritRateTextBox.TabIndex = 11;
        CritRateTextBox.Text = "99";
        // 
        // CritRateCaptionLabel
        // 
        CritRateCaptionLabel.AutoSize = true;
        CritRateCaptionLabel.Font = new Font("Meiryo UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 128);
        CritRateCaptionLabel.Location = new Point(74, 103);
        CritRateCaptionLabel.Name = "CritRateCaptionLabel";
        CritRateCaptionLabel.Size = new Size(47, 17);
        CritRateCaptionLabel.TabIndex = 10;
        CritRateCaptionLabel.Text = "急所率";
        // 
        // PropertyButton
        // 
        PropertyButton.Location = new Point(110, 311);
        PropertyButton.Name = "PropertyButton";
        PropertyButton.Size = new Size(76, 35);
        PropertyButton.TabIndex = 24;
        PropertyButton.Text = "プロパティ";
        PropertyButton.UseVisualStyleBackColor = true;
        PropertyButton.Click += PropertyButton_Click;
        // 
        // MoveMetaDataInfoForm
        // 
        AutoScaleDimensions = new SizeF(9F, 17F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(280, 358);
        Controls.Add(PropertyButton);
        Controls.Add(CritRateCaptionLabel);
        Controls.Add(CritRateTextBox);
        Controls.Add(CloseButton);
        Controls.Add(StateChanceCaptionLabel);
        Controls.Add(StatChanceTextBox);
        Controls.Add(FlinchChanceCaptionLabel);
        Controls.Add(FlinchChanceTextBox);
        Controls.Add(AilmentChanceCaptionLabel);
        Controls.Add(AilmentChanceTextBox);
        Controls.Add(AilmentButton);
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
        Controls.Add(CategoryButton);
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

    private Button CategoryButton;
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
    private Button AilmentButton;
    private TextBox AilmentChanceTextBox;
    private Label AilmentChanceCaptionLabel;
    private TextBox FlinchChanceTextBox;
    private Label FlinchChanceCaptionLabel;
    private TextBox StatChanceTextBox;
    private Label StateChanceCaptionLabel;
    private Button CloseButton;
    private TextBox CritRateTextBox;
    private Label CritRateCaptionLabel;
    private Button PropertyButton;
}