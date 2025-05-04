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
        PokemonSpeciesCaptionLabel = new Label();
        BaseScoreTextBox = new TextBox();
        BaseSCoreCaptionLabel = new Label();
        RateTextBox = new TextBox();
        RateCaptionLabel = new Label();
        PokemonSpeciesDetailButton = new Button();
        CloseButton = new Button();
        SuspendLayout();
        // 
        // PokemonSpeciesTextBox
        // 
        PokemonSpeciesTextBox.Location = new Point(95, 12);
        PokemonSpeciesTextBox.Name = "PokemonSpeciesTextBox";
        PokemonSpeciesTextBox.ReadOnly = true;
        PokemonSpeciesTextBox.Size = new Size(190, 24);
        PokemonSpeciesTextBox.TabIndex = 1;
        // 
        // PokemonSpeciesCaptionLabel
        // 
        PokemonSpeciesCaptionLabel.AutoSize = true;
        PokemonSpeciesCaptionLabel.Location = new Point(13, 15);
        PokemonSpeciesCaptionLabel.Margin = new Padding(4, 0, 4, 0);
        PokemonSpeciesCaptionLabel.Name = "PokemonSpeciesCaptionLabel";
        PokemonSpeciesCaptionLabel.Size = new Size(75, 17);
        PokemonSpeciesCaptionLabel.TabIndex = 0;
        PokemonSpeciesCaptionLabel.Text = "ポケモン種族";
        PokemonSpeciesCaptionLabel.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // BaseScoreTextBox
        // 
        BaseScoreTextBox.Location = new Point(95, 42);
        BaseScoreTextBox.Name = "BaseScoreTextBox";
        BaseScoreTextBox.ReadOnly = true;
        BaseScoreTextBox.Size = new Size(190, 24);
        BaseScoreTextBox.TabIndex = 4;
        // 
        // BaseSCoreCaptionLabel
        // 
        BaseSCoreCaptionLabel.AutoSize = true;
        BaseSCoreCaptionLabel.Location = new Point(22, 45);
        BaseSCoreCaptionLabel.Margin = new Padding(4, 0, 4, 0);
        BaseSCoreCaptionLabel.Name = "BaseSCoreCaptionLabel";
        BaseSCoreCaptionLabel.Size = new Size(66, 17);
        BaseSCoreCaptionLabel.TabIndex = 3;
        BaseSCoreCaptionLabel.Text = "基本スコア";
        BaseSCoreCaptionLabel.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // RateTextBox
        // 
        RateTextBox.Location = new Point(95, 72);
        RateTextBox.Name = "RateTextBox";
        RateTextBox.ReadOnly = true;
        RateTextBox.Size = new Size(190, 24);
        RateTextBox.TabIndex = 6;
        // 
        // RateCaptionLabel
        // 
        RateCaptionLabel.AutoSize = true;
        RateCaptionLabel.Location = new Point(41, 75);
        RateCaptionLabel.Margin = new Padding(4, 0, 4, 0);
        RateCaptionLabel.Name = "RateCaptionLabel";
        RateCaptionLabel.Size = new Size(47, 17);
        RateCaptionLabel.TabIndex = 5;
        RateCaptionLabel.Text = "遭遇率";
        RateCaptionLabel.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // PokemonSpeciesDetailButton
        // 
        PokemonSpeciesDetailButton.Location = new Point(292, 10);
        PokemonSpeciesDetailButton.Margin = new Padding(4, 3, 4, 3);
        PokemonSpeciesDetailButton.Name = "PokemonSpeciesDetailButton";
        PokemonSpeciesDetailButton.Size = new Size(47, 26);
        PokemonSpeciesDetailButton.TabIndex = 2;
        PokemonSpeciesDetailButton.Text = "詳細";
        PokemonSpeciesDetailButton.UseVisualStyleBackColor = true;
        PokemonSpeciesDetailButton.Click += PokemonSpeciesDetailButton_Click;
        // 
        // CloseButton
        // 
        CloseButton.Location = new Point(263, 102);
        CloseButton.Margin = new Padding(4, 3, 4, 3);
        CloseButton.Name = "CloseButton";
        CloseButton.Size = new Size(76, 39);
        CloseButton.TabIndex = 7;
        CloseButton.Text = "閉じる";
        CloseButton.UseVisualStyleBackColor = true;
        CloseButton.Click += CloseButton_Click;
        // 
        // PalParkEncounterSpeciesInfoForm
        // 
        AutoScaleDimensions = new SizeF(9F, 17F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(354, 149);
        Controls.Add(CloseButton);
        Controls.Add(PokemonSpeciesDetailButton);
        Controls.Add(RateCaptionLabel);
        Controls.Add(RateTextBox);
        Controls.Add(BaseScoreTextBox);
        Controls.Add(BaseSCoreCaptionLabel);
        Controls.Add(PokemonSpeciesTextBox);
        Controls.Add(PokemonSpeciesCaptionLabel);
        Font = new Font("Meiryo UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 128);
        Margin = new Padding(4, 3, 4, 3);
        Name = "PalParkEncounterSpeciesInfoForm";
        StartPosition = FormStartPosition.CenterParent;
        Text = "パルパークエリア内で遭遇するポケモン種族";
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private TextBox PokemonSpeciesTextBox;
    private Label PokemonSpeciesCaptionLabel;
    private TextBox BaseScoreTextBox;
    private Label BaseSCoreCaptionLabel;
    private TextBox RateTextBox;
    private Label RateCaptionLabel;
    private Button PokemonSpeciesDetailButton;
    private Button CloseButton;
}