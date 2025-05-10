namespace Kos.PokeAPI.Forms;

partial class EvolutionDetailInfoForm
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
        ItemButton = new Button();
        TriggerButton = new Button();
        GenderCaptionLabel = new Label();
        LocationButton = new Button();
        HeldItemButton = new Button();
        KnownMoveButton = new Button();
        KnownMoveTypeButton = new Button();
        MinLevelCaptionLabel = new Label();
        MinHappinessCaptionLabel = new Label();
        MinBeautyCaptionLabel = new Label();
        MinAffectionCaptionLabel = new Label();
        NeedsOverworldRainCaptionLabel = new Label();
        PartySpeciesButton = new Button();
        PartyTypeButton = new Button();
        RelativePhysicalStatsCaptionLabel = new Label();
        TimeOfDayCaptionLabel = new Label();
        TradeSpeciesDetailButton = new Button();
        TurnUpsideDownCaptionlabel = new Label();
        CloseButton = new Button();
        ItemTextBox = new TextBox();
        TriggerTextBox = new TextBox();
        LocationTextBox = new TextBox();
        GenderTextBox = new TextBox();
        HeldItemTextBox = new TextBox();
        KnownMoveTextBox = new TextBox();
        KnownMoveTypeTextBox = new TextBox();
        MinLevelTextBox = new TextBox();
        MinHappinessTextBox = new TextBox();
        MinBeautyTextBox = new TextBox();
        MinAffectionTextBox = new TextBox();
        NeedsOverworldRainTextBox = new TextBox();
        PartySpeciesTextBox = new TextBox();
        PartyTypeTextBox = new TextBox();
        RelativePhysicalStatsTextBox = new TextBox();
        TimeOfDayTextBox = new TextBox();
        TradeSpeciesTextBox = new TextBox();
        TurnUpsideDownTextBox = new TextBox();
        PropertyButton = new Button();
        PokemonGroupBox = new GroupBox();
        ItemGroupBox = new GroupBox();
        KnownMoveGroupBox = new GroupBox();
        PokemonMinGroupBox = new GroupBox();
        PartyGroupBox = new GroupBox();
        PokemonGroupBox.SuspendLayout();
        ItemGroupBox.SuspendLayout();
        KnownMoveGroupBox.SuspendLayout();
        PokemonMinGroupBox.SuspendLayout();
        PartyGroupBox.SuspendLayout();
        SuspendLayout();
        // 
        // ItemButton
        // 
        ItemButton.Location = new Point(7, 23);
        ItemButton.Margin = new Padding(4, 3, 4, 3);
        ItemButton.Name = "ItemButton";
        ItemButton.Size = new Size(50, 26);
        ItemButton.TabIndex = 0;
        ItemButton.Text = "使用";
        ItemButton.UseVisualStyleBackColor = true;
        ItemButton.Click += ItemButton_Click;
        // 
        // TriggerButton
        // 
        TriggerButton.Location = new Point(13, 12);
        TriggerButton.Margin = new Padding(4, 3, 4, 3);
        TriggerButton.Name = "TriggerButton";
        TriggerButton.Size = new Size(100, 26);
        TriggerButton.TabIndex = 0;
        TriggerButton.Text = "進化発動条件";
        TriggerButton.UseVisualStyleBackColor = true;
        TriggerButton.Click += TriggerButton_Click;
        // 
        // GenderCaptionLabel
        // 
        GenderCaptionLabel.AutoSize = true;
        GenderCaptionLabel.Location = new Point(15, 30);
        GenderCaptionLabel.Margin = new Padding(4, 0, 4, 0);
        GenderCaptionLabel.Name = "GenderCaptionLabel";
        GenderCaptionLabel.Size = new Size(34, 17);
        GenderCaptionLabel.TabIndex = 0;
        GenderCaptionLabel.Text = "性別";
        GenderCaptionLabel.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // LocationButton
        // 
        LocationButton.Location = new Point(520, 179);
        LocationButton.Margin = new Padding(4, 3, 4, 3);
        LocationButton.Name = "LocationButton";
        LocationButton.Size = new Size(109, 26);
        LocationButton.TabIndex = 6;
        LocationButton.Text = "場所";
        LocationButton.UseVisualStyleBackColor = true;
        LocationButton.Click += LocationButton_Click;
        // 
        // HeldItemButton
        // 
        HeldItemButton.Location = new Point(7, 55);
        HeldItemButton.Margin = new Padding(4, 3, 4, 3);
        HeldItemButton.Name = "HeldItemButton";
        HeldItemButton.Size = new Size(50, 26);
        HeldItemButton.TabIndex = 2;
        HeldItemButton.Text = "所持";
        HeldItemButton.UseVisualStyleBackColor = true;
        HeldItemButton.Click += HeldItemButton_Click;
        // 
        // KnownMoveButton
        // 
        KnownMoveButton.Location = new Point(7, 26);
        KnownMoveButton.Margin = new Padding(4, 3, 4, 3);
        KnownMoveButton.Name = "KnownMoveButton";
        KnownMoveButton.Size = new Size(57, 26);
        KnownMoveButton.TabIndex = 0;
        KnownMoveButton.Text = "技";
        KnownMoveButton.UseVisualStyleBackColor = true;
        KnownMoveButton.Click += KnownMoveButton_Click;
        // 
        // KnownMoveTypeButton
        // 
        KnownMoveTypeButton.Location = new Point(8, 58);
        KnownMoveTypeButton.Margin = new Padding(4, 3, 4, 3);
        KnownMoveTypeButton.Name = "KnownMoveTypeButton";
        KnownMoveTypeButton.Size = new Size(56, 26);
        KnownMoveTypeButton.TabIndex = 2;
        KnownMoveTypeButton.Text = "タイプ";
        KnownMoveTypeButton.UseVisualStyleBackColor = true;
        KnownMoveTypeButton.Click += KnownMoveTypeButton_Click;
        // 
        // MinLevelCaptionLabel
        // 
        MinLevelCaptionLabel.AutoSize = true;
        MinLevelCaptionLabel.Location = new Point(25, 26);
        MinLevelCaptionLabel.Margin = new Padding(4, 0, 4, 0);
        MinLevelCaptionLabel.Name = "MinLevelCaptionLabel";
        MinLevelCaptionLabel.Size = new Size(40, 17);
        MinLevelCaptionLabel.TabIndex = 0;
        MinLevelCaptionLabel.Text = "レベル";
        MinLevelCaptionLabel.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // MinHappinessCaptionLabel
        // 
        MinHappinessCaptionLabel.AutoSize = true;
        MinHappinessCaptionLabel.Location = new Point(11, 59);
        MinHappinessCaptionLabel.Margin = new Padding(4, 0, 4, 0);
        MinHappinessCaptionLabel.Name = "MinHappinessCaptionLabel";
        MinHappinessCaptionLabel.Size = new Size(54, 17);
        MinHappinessCaptionLabel.TabIndex = 2;
        MinHappinessCaptionLabel.Text = "なつき度";
        MinHappinessCaptionLabel.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // MinBeautyCaptionLabel
        // 
        MinBeautyCaptionLabel.AutoSize = true;
        MinBeautyCaptionLabel.Location = new Point(7, 89);
        MinBeautyCaptionLabel.Margin = new Padding(4, 0, 4, 0);
        MinBeautyCaptionLabel.Name = "MinBeautyCaptionLabel";
        MinBeautyCaptionLabel.Size = new Size(58, 17);
        MinBeautyCaptionLabel.TabIndex = 4;
        MinBeautyCaptionLabel.Text = "かっこよさ";
        MinBeautyCaptionLabel.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // MinAffectionCaptionLabel
        // 
        MinAffectionCaptionLabel.AutoSize = true;
        MinAffectionCaptionLabel.Location = new Point(18, 119);
        MinAffectionCaptionLabel.Margin = new Padding(4, 0, 4, 0);
        MinAffectionCaptionLabel.Name = "MinAffectionCaptionLabel";
        MinAffectionCaptionLabel.Size = new Size(47, 17);
        MinAffectionCaptionLabel.TabIndex = 6;
        MinAffectionCaptionLabel.Text = "親密度";
        MinAffectionCaptionLabel.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // NeedsOverworldRainCaptionLabel
        // 
        NeedsOverworldRainCaptionLabel.AutoSize = true;
        NeedsOverworldRainCaptionLabel.Location = new Point(535, 213);
        NeedsOverworldRainCaptionLabel.Margin = new Padding(4, 0, 4, 0);
        NeedsOverworldRainCaptionLabel.Name = "NeedsOverworldRainCaptionLabel";
        NeedsOverworldRainCaptionLabel.Size = new Size(98, 17);
        NeedsOverworldRainCaptionLabel.TabIndex = 8;
        NeedsOverworldRainCaptionLabel.Text = "天候の影響有無";
        NeedsOverworldRainCaptionLabel.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // PartySpeciesButton
        // 
        PartySpeciesButton.Location = new Point(9, 23);
        PartySpeciesButton.Margin = new Padding(4, 3, 4, 3);
        PartySpeciesButton.Name = "PartySpeciesButton";
        PartySpeciesButton.Size = new Size(84, 26);
        PartySpeciesButton.TabIndex = 0;
        PartySpeciesButton.Text = "ポケモン種族";
        PartySpeciesButton.UseVisualStyleBackColor = true;
        // 
        // PartyTypeButton
        // 
        PartyTypeButton.Location = new Point(9, 53);
        PartyTypeButton.Margin = new Padding(4, 3, 4, 3);
        PartyTypeButton.Name = "PartyTypeButton";
        PartyTypeButton.Size = new Size(85, 26);
        PartyTypeButton.TabIndex = 2;
        PartyTypeButton.Text = "タイプ";
        PartyTypeButton.UseVisualStyleBackColor = true;
        // 
        // RelativePhysicalStatsCaptionLabel
        // 
        RelativePhysicalStatsCaptionLabel.AutoSize = true;
        RelativePhysicalStatsCaptionLabel.Location = new Point(15, 216);
        RelativePhysicalStatsCaptionLabel.Margin = new Padding(4, 0, 4, 0);
        RelativePhysicalStatsCaptionLabel.Name = "RelativePhysicalStatsCaptionLabel";
        RelativePhysicalStatsCaptionLabel.Size = new Size(125, 34);
        RelativePhysicalStatsCaptionLabel.TabIndex = 3;
        RelativePhysicalStatsCaptionLabel.Text = "「こうげき」と「ぼうぎょ」\r\nの関係性";
        RelativePhysicalStatsCaptionLabel.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // TimeOfDayCaptionLabel
        // 
        TimeOfDayCaptionLabel.AutoSize = true;
        TimeOfDayCaptionLabel.Location = new Point(586, 243);
        TimeOfDayCaptionLabel.Margin = new Padding(4, 0, 4, 0);
        TimeOfDayCaptionLabel.Name = "TimeOfDayCaptionLabel";
        TimeOfDayCaptionLabel.Size = new Size(47, 17);
        TimeOfDayCaptionLabel.TabIndex = 10;
        TimeOfDayCaptionLabel.Text = "時間帯";
        TimeOfDayCaptionLabel.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // TradeSpeciesDetailButton
        // 
        TradeSpeciesDetailButton.Location = new Point(519, 147);
        TradeSpeciesDetailButton.Margin = new Padding(4, 3, 4, 3);
        TradeSpeciesDetailButton.Name = "TradeSpeciesDetailButton";
        TradeSpeciesDetailButton.Size = new Size(110, 26);
        TradeSpeciesDetailButton.TabIndex = 4;
        TradeSpeciesDetailButton.Text = "交換ポケモン種族";
        TradeSpeciesDetailButton.UseVisualStyleBackColor = true;
        // 
        // TurnUpsideDownCaptionlabel
        // 
        TurnUpsideDownCaptionlabel.AutoSize = true;
        TurnUpsideDownCaptionlabel.Location = new Point(515, 273);
        TurnUpsideDownCaptionlabel.Margin = new Padding(4, 0, 4, 0);
        TurnUpsideDownCaptionlabel.Name = "TurnUpsideDownCaptionlabel";
        TurnUpsideDownCaptionlabel.Size = new Size(118, 17);
        TurnUpsideDownCaptionlabel.TabIndex = 12;
        TurnUpsideDownCaptionlabel.Text = "ゲーム機の上下反転";
        TurnUpsideDownCaptionlabel.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // CloseButton
        // 
        CloseButton.Location = new Point(711, 300);
        CloseButton.Margin = new Padding(4, 3, 4, 3);
        CloseButton.Name = "CloseButton";
        CloseButton.Size = new Size(76, 35);
        CloseButton.TabIndex = 15;
        CloseButton.Text = "閉じる";
        CloseButton.UseVisualStyleBackColor = true;
        CloseButton.Click += CloseButton_Click;
        // 
        // ItemTextBox
        // 
        ItemTextBox.Location = new Point(64, 25);
        ItemTextBox.Name = "ItemTextBox";
        ItemTextBox.ReadOnly = true;
        ItemTextBox.Size = new Size(191, 24);
        ItemTextBox.TabIndex = 1;
        // 
        // TriggerTextBox
        // 
        TriggerTextBox.Location = new Point(117, 14);
        TriggerTextBox.Name = "TriggerTextBox";
        TriggerTextBox.ReadOnly = true;
        TriggerTextBox.Size = new Size(182, 24);
        TriggerTextBox.TabIndex = 1;
        // 
        // LocationTextBox
        // 
        LocationTextBox.Location = new Point(640, 179);
        LocationTextBox.Name = "LocationTextBox";
        LocationTextBox.ReadOnly = true;
        LocationTextBox.Size = new Size(143, 24);
        LocationTextBox.TabIndex = 7;
        // 
        // GenderTextBox
        // 
        GenderTextBox.Location = new Point(60, 23);
        GenderTextBox.Name = "GenderTextBox";
        GenderTextBox.ReadOnly = true;
        GenderTextBox.Size = new Size(78, 24);
        GenderTextBox.TabIndex = 1;
        // 
        // HeldItemTextBox
        // 
        HeldItemTextBox.Location = new Point(59, 57);
        HeldItemTextBox.Name = "HeldItemTextBox";
        HeldItemTextBox.ReadOnly = true;
        HeldItemTextBox.Size = new Size(196, 24);
        HeldItemTextBox.TabIndex = 3;
        // 
        // KnownMoveTextBox
        // 
        KnownMoveTextBox.Location = new Point(71, 26);
        KnownMoveTextBox.Name = "KnownMoveTextBox";
        KnownMoveTextBox.ReadOnly = true;
        KnownMoveTextBox.Size = new Size(184, 24);
        KnownMoveTextBox.TabIndex = 1;
        // 
        // KnownMoveTypeTextBox
        // 
        KnownMoveTypeTextBox.Location = new Point(71, 56);
        KnownMoveTypeTextBox.Name = "KnownMoveTypeTextBox";
        KnownMoveTypeTextBox.ReadOnly = true;
        KnownMoveTypeTextBox.Size = new Size(184, 24);
        KnownMoveTypeTextBox.TabIndex = 3;
        // 
        // MinLevelTextBox
        // 
        MinLevelTextBox.Location = new Point(72, 23);
        MinLevelTextBox.Name = "MinLevelTextBox";
        MinLevelTextBox.ReadOnly = true;
        MinLevelTextBox.Size = new Size(78, 24);
        MinLevelTextBox.TabIndex = 1;
        // 
        // MinHappinessTextBox
        // 
        MinHappinessTextBox.Location = new Point(72, 53);
        MinHappinessTextBox.Name = "MinHappinessTextBox";
        MinHappinessTextBox.ReadOnly = true;
        MinHappinessTextBox.Size = new Size(78, 24);
        MinHappinessTextBox.TabIndex = 3;
        // 
        // MinBeautyTextBox
        // 
        MinBeautyTextBox.Location = new Point(72, 86);
        MinBeautyTextBox.Name = "MinBeautyTextBox";
        MinBeautyTextBox.ReadOnly = true;
        MinBeautyTextBox.Size = new Size(78, 24);
        MinBeautyTextBox.TabIndex = 5;
        // 
        // MinAffectionTextBox
        // 
        MinAffectionTextBox.Location = new Point(72, 116);
        MinAffectionTextBox.Name = "MinAffectionTextBox";
        MinAffectionTextBox.ReadOnly = true;
        MinAffectionTextBox.Size = new Size(78, 24);
        MinAffectionTextBox.TabIndex = 7;
        // 
        // NeedsOverworldRainTextBox
        // 
        NeedsOverworldRainTextBox.Location = new Point(640, 210);
        NeedsOverworldRainTextBox.Name = "NeedsOverworldRainTextBox";
        NeedsOverworldRainTextBox.ReadOnly = true;
        NeedsOverworldRainTextBox.Size = new Size(147, 24);
        NeedsOverworldRainTextBox.TabIndex = 9;
        // 
        // PartySpeciesTextBox
        // 
        PartySpeciesTextBox.Location = new Point(101, 25);
        PartySpeciesTextBox.Name = "PartySpeciesTextBox";
        PartySpeciesTextBox.ReadOnly = true;
        PartySpeciesTextBox.Size = new Size(149, 24);
        PartySpeciesTextBox.TabIndex = 1;
        // 
        // PartyTypeTextBox
        // 
        PartyTypeTextBox.Location = new Point(101, 55);
        PartyTypeTextBox.Name = "PartyTypeTextBox";
        PartyTypeTextBox.ReadOnly = true;
        PartyTypeTextBox.Size = new Size(149, 24);
        PartyTypeTextBox.TabIndex = 3;
        // 
        // RelativePhysicalStatsTextBox
        // 
        RelativePhysicalStatsTextBox.Location = new Point(147, 222);
        RelativePhysicalStatsTextBox.Name = "RelativePhysicalStatsTextBox";
        RelativePhysicalStatsTextBox.ReadOnly = true;
        RelativePhysicalStatsTextBox.Size = new Size(44, 24);
        RelativePhysicalStatsTextBox.TabIndex = 4;
        // 
        // TimeOfDayTextBox
        // 
        TimeOfDayTextBox.Location = new Point(640, 240);
        TimeOfDayTextBox.Name = "TimeOfDayTextBox";
        TimeOfDayTextBox.ReadOnly = true;
        TimeOfDayTextBox.Size = new Size(147, 24);
        TimeOfDayTextBox.TabIndex = 11;
        // 
        // TradeSpeciesTextBox
        // 
        TradeSpeciesTextBox.Location = new Point(640, 149);
        TradeSpeciesTextBox.Name = "TradeSpeciesTextBox";
        TradeSpeciesTextBox.ReadOnly = true;
        TradeSpeciesTextBox.Size = new Size(143, 24);
        TradeSpeciesTextBox.TabIndex = 5;
        // 
        // TurnUpsideDownTextBox
        // 
        TurnUpsideDownTextBox.Location = new Point(640, 270);
        TurnUpsideDownTextBox.Name = "TurnUpsideDownTextBox";
        TurnUpsideDownTextBox.ReadOnly = true;
        TurnUpsideDownTextBox.Size = new Size(147, 24);
        TurnUpsideDownTextBox.TabIndex = 13;
        // 
        // PropertyButton
        // 
        PropertyButton.Location = new Point(627, 300);
        PropertyButton.Margin = new Padding(4, 3, 4, 3);
        PropertyButton.Name = "PropertyButton";
        PropertyButton.Size = new Size(76, 35);
        PropertyButton.TabIndex = 14;
        PropertyButton.Text = "プロパティ";
        PropertyButton.UseVisualStyleBackColor = true;
        PropertyButton.Click += PropertyButton_Click;
        // 
        // PokemonGroupBox
        // 
        PokemonGroupBox.Controls.Add(ItemGroupBox);
        PokemonGroupBox.Controls.Add(KnownMoveGroupBox);
        PokemonGroupBox.Controls.Add(PokemonMinGroupBox);
        PokemonGroupBox.Controls.Add(GenderTextBox);
        PokemonGroupBox.Controls.Add(GenderCaptionLabel);
        PokemonGroupBox.Controls.Add(RelativePhysicalStatsCaptionLabel);
        PokemonGroupBox.Controls.Add(RelativePhysicalStatsTextBox);
        PokemonGroupBox.Location = new Point(16, 44);
        PokemonGroupBox.Name = "PokemonGroupBox";
        PokemonGroupBox.Size = new Size(497, 268);
        PokemonGroupBox.TabIndex = 2;
        PokemonGroupBox.TabStop = false;
        PokemonGroupBox.Text = "ポケモン";
        // 
        // ItemGroupBox
        // 
        ItemGroupBox.Controls.Add(ItemButton);
        ItemGroupBox.Controls.Add(HeldItemButton);
        ItemGroupBox.Controls.Add(ItemTextBox);
        ItemGroupBox.Controls.Add(HeldItemTextBox);
        ItemGroupBox.Location = new Point(206, 155);
        ItemGroupBox.Name = "ItemGroupBox";
        ItemGroupBox.Size = new Size(276, 100);
        ItemGroupBox.TabIndex = 6;
        ItemGroupBox.TabStop = false;
        ItemGroupBox.Text = "アイテム";
        // 
        // KnownMoveGroupBox
        // 
        KnownMoveGroupBox.Controls.Add(KnownMoveButton);
        KnownMoveGroupBox.Controls.Add(KnownMoveTypeButton);
        KnownMoveGroupBox.Controls.Add(KnownMoveTextBox);
        KnownMoveGroupBox.Controls.Add(KnownMoveTypeTextBox);
        KnownMoveGroupBox.Location = new Point(206, 53);
        KnownMoveGroupBox.Name = "KnownMoveGroupBox";
        KnownMoveGroupBox.Size = new Size(276, 96);
        KnownMoveGroupBox.TabIndex = 5;
        KnownMoveGroupBox.TabStop = false;
        KnownMoveGroupBox.Text = "覚えている技";
        // 
        // PokemonMinGroupBox
        // 
        PokemonMinGroupBox.Controls.Add(MinLevelCaptionLabel);
        PokemonMinGroupBox.Controls.Add(MinLevelTextBox);
        PokemonMinGroupBox.Controls.Add(MinHappinessTextBox);
        PokemonMinGroupBox.Controls.Add(MinAffectionTextBox);
        PokemonMinGroupBox.Controls.Add(MinBeautyTextBox);
        PokemonMinGroupBox.Controls.Add(MinHappinessCaptionLabel);
        PokemonMinGroupBox.Controls.Add(MinBeautyCaptionLabel);
        PokemonMinGroupBox.Controls.Add(MinAffectionCaptionLabel);
        PokemonMinGroupBox.Location = new Point(15, 53);
        PokemonMinGroupBox.Name = "PokemonMinGroupBox";
        PokemonMinGroupBox.Size = new Size(176, 149);
        PokemonMinGroupBox.TabIndex = 2;
        PokemonMinGroupBox.TabStop = false;
        PokemonMinGroupBox.Text = "最低値";
        // 
        // PartyGroupBox
        // 
        PartyGroupBox.Controls.Add(PartySpeciesButton);
        PartyGroupBox.Controls.Add(PartyTypeButton);
        PartyGroupBox.Controls.Add(PartySpeciesTextBox);
        PartyGroupBox.Controls.Add(PartyTypeTextBox);
        PartyGroupBox.Location = new Point(519, 44);
        PartyGroupBox.Name = "PartyGroupBox";
        PartyGroupBox.Size = new Size(264, 100);
        PartyGroupBox.TabIndex = 3;
        PartyGroupBox.TabStop = false;
        PartyGroupBox.Text = "手持ちポケモン";
        // 
        // EvolutionDetailInfoForm
        // 
        AutoScaleDimensions = new SizeF(9F, 17F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(810, 352);
        Controls.Add(PartyGroupBox);
        Controls.Add(PokemonGroupBox);
        Controls.Add(PropertyButton);
        Controls.Add(TurnUpsideDownTextBox);
        Controls.Add(TradeSpeciesTextBox);
        Controls.Add(TimeOfDayTextBox);
        Controls.Add(NeedsOverworldRainTextBox);
        Controls.Add(LocationTextBox);
        Controls.Add(TriggerTextBox);
        Controls.Add(CloseButton);
        Controls.Add(TurnUpsideDownCaptionlabel);
        Controls.Add(TradeSpeciesDetailButton);
        Controls.Add(TimeOfDayCaptionLabel);
        Controls.Add(NeedsOverworldRainCaptionLabel);
        Controls.Add(LocationButton);
        Controls.Add(TriggerButton);
        Font = new Font("Meiryo UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 128);
        FormBorderStyle = FormBorderStyle.FixedSingle;
        Margin = new Padding(4, 3, 4, 3);
        MaximizeBox = false;
        Name = "EvolutionDetailInfoForm";
        StartPosition = FormStartPosition.CenterParent;
        Text = "進化詳細";
        PokemonGroupBox.ResumeLayout(false);
        PokemonGroupBox.PerformLayout();
        ItemGroupBox.ResumeLayout(false);
        ItemGroupBox.PerformLayout();
        KnownMoveGroupBox.ResumeLayout(false);
        KnownMoveGroupBox.PerformLayout();
        PokemonMinGroupBox.ResumeLayout(false);
        PokemonMinGroupBox.PerformLayout();
        PartyGroupBox.ResumeLayout(false);
        PartyGroupBox.PerformLayout();
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private Button ItemButton;
    private Button TriggerButton;
    private Label TriggerCaptionLabel;
    private Label GenderCaptionLabel;
    private Button HeldItemButton;
    private Label HeldItemCaptionLabel;
    private Button KnownMoveButton;
    private Label KnownMoveCaptionLabel;
    private Button KnownMoveTypeButton;
    private Label KnownMoveTypeCaptionLabel;
    private Button LocationButton;
    private Label LocationCaptionLabel;
    private Label MinLevelCaptionLabel;
    private Label MinHappinessCaptionLabel;
    private Label MinBeautyCaptionLabel;
    private Label MinAffectionCaptionLabel;
    private Label NeedsOverworldRainCaptionLabel;
    private Button PartySpeciesButton;
    private Label PartySpeciesCaptionLabel;
    private Button PartyTypeButton;
    private Label RelativePhysicalStatsCaptionLabel;
    private Label TimeOfDayCaptionLabel;
    private Button TradeSpeciesDetailButton;
    private Label TurnUpsideDownCaptionlabel;
    private Button CloseButton;
    private TextBox ItemTextBox;
    private TextBox TriggerTextBox;
    private TextBox LocationTextBox;
    private TextBox GenderTextBox;
    private TextBox HeldItemTextBox;
    private TextBox KnownMoveTextBox;
    private TextBox KnownMoveTypeTextBox;
    private TextBox MinLevelTextBox;
    private TextBox MinHappinessTextBox;
    private TextBox MinBeautyTextBox;
    private TextBox MinAffectionTextBox;
    private TextBox NeedsOverworldRainTextBox;
    private TextBox PartySpeciesTextBox;
    private TextBox PartyTypeTextBox;
    private TextBox RelativePhysicalStatsTextBox;
    private TextBox TimeOfDayTextBox;
    private TextBox TradeSpeciesTextBox;
    private TextBox TurnUpsideDownTextBox;
    private Button PropertyButton;
    private GroupBox PokemonGroupBox;
    private GroupBox PokemonMinGroupBox;
    private GroupBox KnownMoveGroupBox;
    private GroupBox ItemGroupBox;
    private GroupBox PartyGroupBox;
}