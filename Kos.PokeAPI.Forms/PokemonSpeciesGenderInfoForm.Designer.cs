namespace Kos.PokeAPI.Forms;

partial class PokemonSpeciesGenderInfoForm
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
        PokemonSpeciesButton = new Button();
        PokemonSpeciesTextBox = new TextBox();
        RateTextBox = new TextBox();
        RateCaptionLabel = new Label();
        PropertyButton = new Button();
        CloseButton = new Button();
        SuspendLayout();
        // 
        // PokemonSpeciesButton
        // 
        PokemonSpeciesButton.Location = new Point(13, 12);
        PokemonSpeciesButton.Margin = new Padding(4, 3, 4, 3);
        PokemonSpeciesButton.Name = "PokemonSpeciesButton";
        PokemonSpeciesButton.Size = new Size(84, 26);
        PokemonSpeciesButton.TabIndex = 0;
        PokemonSpeciesButton.Text = "ポケモン種族";
        PokemonSpeciesButton.UseVisualStyleBackColor = true;
        // 
        // PokemonSpeciesTextBox
        // 
        PokemonSpeciesTextBox.Location = new Point(105, 14);
        PokemonSpeciesTextBox.Name = "PokemonSpeciesTextBox";
        PokemonSpeciesTextBox.ReadOnly = true;
        PokemonSpeciesTextBox.Size = new Size(160, 24);
        PokemonSpeciesTextBox.TabIndex = 1;
        // 
        // RateTextBox
        // 
        RateTextBox.Location = new Point(105, 44);
        RateTextBox.Name = "RateTextBox";
        RateTextBox.ReadOnly = true;
        RateTextBox.Size = new Size(160, 24);
        RateTextBox.TabIndex = 3;
        // 
        // RateCaptionLabel
        // 
        RateCaptionLabel.AutoSize = true;
        RateCaptionLabel.Location = new Point(63, 47);
        RateCaptionLabel.Margin = new Padding(4, 0, 4, 0);
        RateCaptionLabel.Name = "RateCaptionLabel";
        RateCaptionLabel.Size = new Size(34, 17);
        RateCaptionLabel.TabIndex = 2;
        RateCaptionLabel.Text = "確率";
        RateCaptionLabel.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // PropertyButton
        // 
        PropertyButton.Location = new Point(107, 83);
        PropertyButton.Name = "PropertyButton";
        PropertyButton.Size = new Size(76, 35);
        PropertyButton.TabIndex = 4;
        PropertyButton.Text = "プロパティ";
        PropertyButton.UseVisualStyleBackColor = true;
        PropertyButton.Click += PropertyButton_Click;
        // 
        // CloseButton
        // 
        CloseButton.Location = new Point(189, 83);
        CloseButton.Name = "CloseButton";
        CloseButton.Size = new Size(76, 35);
        CloseButton.TabIndex = 5;
        CloseButton.Text = "閉じる";
        CloseButton.UseVisualStyleBackColor = true;
        CloseButton.Click += CloseButton_Click;
        // 
        // PokemonSpeciesGenderInfoForm
        // 
        AutoScaleDimensions = new SizeF(9F, 17F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(276, 134);
        Controls.Add(PropertyButton);
        Controls.Add(CloseButton);
        Controls.Add(RateTextBox);
        Controls.Add(RateCaptionLabel);
        Controls.Add(PokemonSpeciesButton);
        Controls.Add(PokemonSpeciesTextBox);
        Font = new Font("Meiryo UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 128);
        FormBorderStyle = FormBorderStyle.FixedSingle;
        Margin = new Padding(4, 3, 4, 3);
        MaximizeBox = false;
        Name = "PokemonSpeciesGenderInfoForm";
        StartPosition = FormStartPosition.CenterParent;
        Text = "ポケモンごとの性別確率";
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private Button PokemonSpeciesButton;
    private TextBox PokemonSpeciesTextBox;
    private TextBox RateTextBox;
    private Label RateCaptionLabel;
    private Button PropertyButton;
    private Button CloseButton;
}