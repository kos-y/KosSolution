namespace Kos.PokeAPI.Forms;

partial class VerboseEffectInfoForm
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
        ShortEffectCaptionLabel = new Label();
        ShortEffectTextBox = new TextBox();
        EffectCaptionLabel = new Label();
        EffectTextBox = new TextBox();
        LanguageTextBox = new TextBox();
        LanguageButton = new Button();
        CloseButton = new Button();
        PropertyButton = new Button();
        SuspendLayout();
        // 
        // ShortEffectCaptionLabel
        // 
        ShortEffectCaptionLabel.AutoSize = true;
        ShortEffectCaptionLabel.Font = new Font("Meiryo UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 128);
        ShortEffectCaptionLabel.Location = new Point(12, 45);
        ShortEffectCaptionLabel.Name = "ShortEffectCaptionLabel";
        ShortEffectCaptionLabel.Size = new Size(64, 17);
        ShortEffectCaptionLabel.TabIndex = 2;
        ShortEffectCaptionLabel.Text = "効果 概略";
        // 
        // ShortEffectTextBox
        // 
        ShortEffectTextBox.Location = new Point(12, 65);
        ShortEffectTextBox.Name = "ShortEffectTextBox";
        ShortEffectTextBox.ReadOnly = true;
        ShortEffectTextBox.Size = new Size(488, 24);
        ShortEffectTextBox.TabIndex = 3;
        ShortEffectTextBox.Text = "ピカチュウ";
        // 
        // EffectCaptionLabel
        // 
        EffectCaptionLabel.AutoSize = true;
        EffectCaptionLabel.Font = new Font("Meiryo UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 128);
        EffectCaptionLabel.Location = new Point(12, 97);
        EffectCaptionLabel.Name = "EffectCaptionLabel";
        EffectCaptionLabel.Size = new Size(64, 17);
        EffectCaptionLabel.TabIndex = 4;
        EffectCaptionLabel.Text = "効果 詳細";
        // 
        // EffectTextBox
        // 
        EffectTextBox.Location = new Point(12, 117);
        EffectTextBox.Multiline = true;
        EffectTextBox.Name = "EffectTextBox";
        EffectTextBox.ReadOnly = true;
        EffectTextBox.Size = new Size(488, 172);
        EffectTextBox.TabIndex = 5;
        EffectTextBox.Text = "ピカチュウ";
        // 
        // LanguageTextBox
        // 
        LanguageTextBox.Location = new Point(71, 13);
        LanguageTextBox.Name = "LanguageTextBox";
        LanguageTextBox.ReadOnly = true;
        LanguageTextBox.Size = new Size(201, 24);
        LanguageTextBox.TabIndex = 1;
        LanguageTextBox.Text = "ja-Hrkt";
        // 
        // LanguageButton
        // 
        LanguageButton.Location = new Point(12, 12);
        LanguageButton.Name = "LanguageButton";
        LanguageButton.Size = new Size(53, 24);
        LanguageButton.TabIndex = 0;
        LanguageButton.Text = "言語";
        LanguageButton.UseVisualStyleBackColor = true;
        LanguageButton.Click += LanguageButton_Click;
        // 
        // CloseButton
        // 
        CloseButton.Location = new Point(424, 295);
        CloseButton.Name = "CloseButton";
        CloseButton.Size = new Size(76, 35);
        CloseButton.TabIndex = 7;
        CloseButton.Text = "閉じる";
        CloseButton.UseVisualStyleBackColor = true;
        CloseButton.Click += CloseButton_Click;
        // 
        // PropertyButton
        // 
        PropertyButton.Location = new Point(342, 295);
        PropertyButton.Name = "PropertyButton";
        PropertyButton.Size = new Size(76, 35);
        PropertyButton.TabIndex = 6;
        PropertyButton.Text = "プロパティ";
        PropertyButton.UseVisualStyleBackColor = true;
        PropertyButton.Click += PropertyButton_Click;
        // 
        // VerboseEffectInfoForm
        // 
        AutoScaleDimensions = new SizeF(9F, 17F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(512, 344);
        Controls.Add(PropertyButton);
        Controls.Add(CloseButton);
        Controls.Add(LanguageButton);
        Controls.Add(LanguageTextBox);
        Controls.Add(EffectTextBox);
        Controls.Add(EffectCaptionLabel);
        Controls.Add(ShortEffectTextBox);
        Controls.Add(ShortEffectCaptionLabel);
        Font = new Font("Meiryo UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 128);
        Margin = new Padding(4, 3, 4, 3);
        MaximizeBox = false;
        Name = "VerboseEffectInfoForm";
        Text = "効果";
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private Label ShortEffectCaptionLabel;
    private TextBox ShortEffectTextBox;
    private Label EffectCaptionLabel;
    private TextBox EffectTextBox;
    private TextBox LanguageTextBox;
    private Button LanguageButton;
    private Button CloseButton;
    private Button PropertyButton;
}