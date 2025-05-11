namespace Kos.PokeAPI.Forms;

partial class PalParkEncounterSpeciesInfoForm
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
        PokemonSpeciesTextBox = new TextBox();
        BaseScoreTextBox = new TextBox();
        BaseScoreCaptionLabel = new Label();
        RateTextBox = new TextBox();
        RateCaptionLabel = new Label();
        PokemonSpeciesButton = new Button();
        CloseButton = new Button();
        button1 = new Button();
        PropertyButton = new Button();
        SuspendLayout();
        // 
        // PokemonSpeciesTextBox
        // 
        PokemonSpeciesTextBox.Location = new Point(105, 12);
        PokemonSpeciesTextBox.Name = "PokemonSpeciesTextBox";
        PokemonSpeciesTextBox.ReadOnly = true;
        PokemonSpeciesTextBox.Size = new Size(218, 24);
        PokemonSpeciesTextBox.TabIndex = 1;
        // 
        // BaseScoreTextBox
        // 
        BaseScoreTextBox.Location = new Point(105, 42);
        BaseScoreTextBox.Name = "BaseScoreTextBox";
        BaseScoreTextBox.ReadOnly = true;
        BaseScoreTextBox.Size = new Size(218, 24);
        BaseScoreTextBox.TabIndex = 3;
        // 
        // BaseScoreCaptionLabel
        // 
        BaseScoreCaptionLabel.AutoSize = true;
        BaseScoreCaptionLabel.Location = new Point(32, 45);
        BaseScoreCaptionLabel.Margin = new Padding(4, 0, 4, 0);
        BaseScoreCaptionLabel.Name = "BaseScoreCaptionLabel";
        BaseScoreCaptionLabel.Size = new Size(66, 17);
        BaseScoreCaptionLabel.TabIndex = 2;
        BaseScoreCaptionLabel.Text = "基本スコア";
        BaseScoreCaptionLabel.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // RateTextBox
        // 
        RateTextBox.Location = new Point(105, 72);
        RateTextBox.Name = "RateTextBox";
        RateTextBox.ReadOnly = true;
        RateTextBox.Size = new Size(218, 24);
        RateTextBox.TabIndex = 5;
        // 
        // RateCaptionLabel
        // 
        RateCaptionLabel.AutoSize = true;
        RateCaptionLabel.Location = new Point(51, 75);
        RateCaptionLabel.Margin = new Padding(4, 0, 4, 0);
        RateCaptionLabel.Name = "RateCaptionLabel";
        RateCaptionLabel.Size = new Size(47, 17);
        RateCaptionLabel.TabIndex = 4;
        RateCaptionLabel.Text = "遭遇率";
        RateCaptionLabel.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // PokemonSpeciesButton
        // 
        PokemonSpeciesButton.Location = new Point(13, 10);
        PokemonSpeciesButton.Margin = new Padding(4, 3, 4, 3);
        PokemonSpeciesButton.Name = "PokemonSpeciesButton";
        PokemonSpeciesButton.Size = new Size(85, 26);
        PokemonSpeciesButton.TabIndex = 0;
        PokemonSpeciesButton.Text = "ポケモン種族";
        PokemonSpeciesButton.UseVisualStyleBackColor = true;
        PokemonSpeciesButton.Click += PokemonSpeciesButton_Click;
        // 
        // CloseButton
        // 
        CloseButton.Location = new Point(247, 102);
        CloseButton.Margin = new Padding(4, 3, 4, 3);
        CloseButton.Name = "CloseButton";
        CloseButton.Size = new Size(76, 35);
        CloseButton.TabIndex = 7;
        CloseButton.Text = "閉じる";
        CloseButton.UseVisualStyleBackColor = true;
        CloseButton.Click += CloseButton_Click;
        // 
        // button1
        // 
        button1.Location = new Point(-100, 102);
        button1.Margin = new Padding(4, 3, 4, 3);
        button1.Name = "button1";
        button1.Size = new Size(114, 35);
        button1.TabIndex = 8;
        button1.Text = "プロパティ";
        button1.UseVisualStyleBackColor = true;
        // 
        // PropertyButton
        // 
        PropertyButton.Location = new Point(163, 102);
        PropertyButton.Margin = new Padding(4, 3, 4, 3);
        PropertyButton.Name = "PropertyButton";
        PropertyButton.Size = new Size(76, 35);
        PropertyButton.TabIndex = 6;
        PropertyButton.Text = "プロパティ";
        PropertyButton.UseVisualStyleBackColor = true;
        PropertyButton.Click += PropertyButton_Click;
        // 
        // PalParkEncounterSpeciesInfoForm
        // 
        AutoScaleDimensions = new SizeF(9F, 17F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(336, 149);
        Controls.Add(PropertyButton);
        Controls.Add(button1);
        Controls.Add(CloseButton);
        Controls.Add(PokemonSpeciesButton);
        Controls.Add(RateCaptionLabel);
        Controls.Add(RateTextBox);
        Controls.Add(BaseScoreTextBox);
        Controls.Add(BaseScoreCaptionLabel);
        Controls.Add(PokemonSpeciesTextBox);
        Font = new Font("Meiryo UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 128);
        FormBorderStyle = FormBorderStyle.FixedSingle;
        Margin = new Padding(4, 3, 4, 3);
        MaximizeBox = false;
        Name = "PalParkEncounterSpeciesInfoForm";
        StartPosition = FormStartPosition.CenterParent;
        Text = "パルパークエリア内で遭遇するポケモン種族";
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private TextBox PokemonSpeciesTextBox;
    private TextBox BaseScoreTextBox;
    private Label BaseScoreCaptionLabel;
    private TextBox RateTextBox;
    private Label RateCaptionLabel;
    private Button PokemonSpeciesButton;
    private Button CloseButton;
    private Button button1;
    private Button PropertyButton;
}