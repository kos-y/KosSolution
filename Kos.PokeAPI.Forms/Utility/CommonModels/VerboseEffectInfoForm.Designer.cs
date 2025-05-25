namespace Kos.PokeAPI.Forms.Utility.CommonModels;

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
        ShortEffectCaptionLabel.Location = new Point(9, 40);
        ShortEffectCaptionLabel.Margin = new Padding(2, 0, 2, 0);
        ShortEffectCaptionLabel.Name = "ShortEffectCaptionLabel";
        ShortEffectCaptionLabel.Size = new Size(58, 15);
        ShortEffectCaptionLabel.TabIndex = 2;
        ShortEffectCaptionLabel.Text = "効果 概略";
        // 
        // ShortEffectTextBox
        // 
        ShortEffectTextBox.Location = new Point(9, 57);
        ShortEffectTextBox.Margin = new Padding(2, 3, 2, 3);
        ShortEffectTextBox.Name = "ShortEffectTextBox";
        ShortEffectTextBox.ReadOnly = true;
        ShortEffectTextBox.Size = new Size(380, 23);
        ShortEffectTextBox.TabIndex = 3;
        ShortEffectTextBox.Text = "ピカチュウ";
        // 
        // EffectCaptionLabel
        // 
        EffectCaptionLabel.AutoSize = true;
        EffectCaptionLabel.Location = new Point(9, 86);
        EffectCaptionLabel.Margin = new Padding(2, 0, 2, 0);
        EffectCaptionLabel.Name = "EffectCaptionLabel";
        EffectCaptionLabel.Size = new Size(58, 15);
        EffectCaptionLabel.TabIndex = 4;
        EffectCaptionLabel.Text = "効果 詳細";
        // 
        // EffectTextBox
        // 
        EffectTextBox.Location = new Point(9, 103);
        EffectTextBox.Margin = new Padding(2, 3, 2, 3);
        EffectTextBox.Multiline = true;
        EffectTextBox.Name = "EffectTextBox";
        EffectTextBox.ReadOnly = true;
        EffectTextBox.Size = new Size(380, 152);
        EffectTextBox.TabIndex = 5;
        EffectTextBox.Text = "ピカチュウ";
        // 
        // LanguageTextBox
        // 
        LanguageTextBox.Location = new Point(55, 11);
        LanguageTextBox.Margin = new Padding(2, 3, 2, 3);
        LanguageTextBox.Name = "LanguageTextBox";
        LanguageTextBox.ReadOnly = true;
        LanguageTextBox.Size = new Size(157, 23);
        LanguageTextBox.TabIndex = 1;
        LanguageTextBox.Text = "ja-Hrkt";
        // 
        // LanguageButton
        // 
        LanguageButton.Location = new Point(11, 8);
        LanguageButton.Margin = new Padding(2, 3, 2, 3);
        LanguageButton.Name = "LanguageButton";
        LanguageButton.Size = new Size(41, 26);
        LanguageButton.TabIndex = 0;
        LanguageButton.Text = "言語";
        LanguageButton.UseVisualStyleBackColor = true;
        LanguageButton.Click += LanguageButton_Click;
        // 
        // CloseButton
        // 
        CloseButton.Location = new Point(330, 260);
        CloseButton.Margin = new Padding(2, 3, 2, 3);
        CloseButton.Name = "CloseButton";
        CloseButton.Size = new Size(59, 31);
        CloseButton.TabIndex = 7;
        CloseButton.Text = "閉じる";
        CloseButton.UseVisualStyleBackColor = true;
        CloseButton.Click += CloseButton_Click;
        // 
        // PropertyButton
        // 
        PropertyButton.Location = new Point(266, 260);
        PropertyButton.Margin = new Padding(2, 3, 2, 3);
        PropertyButton.Name = "PropertyButton";
        PropertyButton.Size = new Size(59, 31);
        PropertyButton.TabIndex = 6;
        PropertyButton.Text = "プロパティ";
        PropertyButton.UseVisualStyleBackColor = true;
        PropertyButton.Click += PropertyButton_Click;
        // 
        // VerboseEffectInfoForm
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(398, 299);
        Controls.Add(PropertyButton);
        Controls.Add(CloseButton);
        Controls.Add(LanguageButton);
        Controls.Add(LanguageTextBox);
        Controls.Add(EffectTextBox);
        Controls.Add(EffectCaptionLabel);
        Controls.Add(ShortEffectTextBox);
        Controls.Add(ShortEffectCaptionLabel);
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