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
        LanguageCaptionLabel = new Label();
        LanguageTextBox = new TextBox();
        LanguageDetailButton = new Button();
        CloseButton = new Button();
        SuspendLayout();
        // 
        // ShortEffectCaptionLabel
        // 
        ShortEffectCaptionLabel.AutoSize = true;
        ShortEffectCaptionLabel.Font = new Font("Meiryo UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 128);
        ShortEffectCaptionLabel.Location = new Point(12, 9);
        ShortEffectCaptionLabel.Name = "ShortEffectCaptionLabel";
        ShortEffectCaptionLabel.Size = new Size(64, 17);
        ShortEffectCaptionLabel.TabIndex = 0;
        ShortEffectCaptionLabel.Text = "効果 概略";
        // 
        // ShortEffectTextBox
        // 
        ShortEffectTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        ShortEffectTextBox.Location = new Point(82, 6);
        ShortEffectTextBox.Name = "ShortEffectTextBox";
        ShortEffectTextBox.ReadOnly = true;
        ShortEffectTextBox.Size = new Size(418, 24);
        ShortEffectTextBox.TabIndex = 1;
        ShortEffectTextBox.Text = "ピカチュウ";
        // 
        // EffectCaptionLabel
        // 
        EffectCaptionLabel.AutoSize = true;
        EffectCaptionLabel.Font = new Font("Meiryo UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 128);
        EffectCaptionLabel.Location = new Point(12, 33);
        EffectCaptionLabel.Name = "EffectCaptionLabel";
        EffectCaptionLabel.Size = new Size(64, 17);
        EffectCaptionLabel.TabIndex = 2;
        EffectCaptionLabel.Text = "効果 詳細";
        // 
        // EffectTextBox
        // 
        EffectTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
        EffectTextBox.Location = new Point(12, 53);
        EffectTextBox.Multiline = true;
        EffectTextBox.Name = "EffectTextBox";
        EffectTextBox.ReadOnly = true;
        EffectTextBox.Size = new Size(488, 172);
        EffectTextBox.TabIndex = 3;
        EffectTextBox.Text = "ピカチュウ";
        // 
        // LanguageCaptionLabel
        // 
        LanguageCaptionLabel.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
        LanguageCaptionLabel.AutoSize = true;
        LanguageCaptionLabel.Font = new Font("Meiryo UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 128);
        LanguageCaptionLabel.Location = new Point(12, 234);
        LanguageCaptionLabel.Name = "LanguageCaptionLabel";
        LanguageCaptionLabel.Size = new Size(34, 17);
        LanguageCaptionLabel.TabIndex = 4;
        LanguageCaptionLabel.Text = "言語";
        // 
        // LanguageTextBox
        // 
        LanguageTextBox.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
        LanguageTextBox.Location = new Point(52, 231);
        LanguageTextBox.Name = "LanguageTextBox";
        LanguageTextBox.ReadOnly = true;
        LanguageTextBox.Size = new Size(389, 24);
        LanguageTextBox.TabIndex = 5;
        LanguageTextBox.Text = "ピカチュウ";
        // 
        // LanguageDetailButton
        // 
        LanguageDetailButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
        LanguageDetailButton.Location = new Point(447, 231);
        LanguageDetailButton.Name = "LanguageDetailButton";
        LanguageDetailButton.Size = new Size(53, 23);
        LanguageDetailButton.TabIndex = 6;
        LanguageDetailButton.Text = "詳細";
        LanguageDetailButton.UseVisualStyleBackColor = true;
        LanguageDetailButton.Click += LanguageDetailButton_Click;
        // 
        // CloseButton
        // 
        CloseButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
        CloseButton.Location = new Point(437, 272);
        CloseButton.Name = "CloseButton";
        CloseButton.Size = new Size(63, 35);
        CloseButton.TabIndex = 7;
        CloseButton.Text = "閉じる";
        CloseButton.UseVisualStyleBackColor = true;
        CloseButton.Click += CloseButton_Click;
        // 
        // VerboseEffectInfoForm
        // 
        AutoScaleDimensions = new SizeF(9F, 17F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(512, 312);
        Controls.Add(CloseButton);
        Controls.Add(LanguageDetailButton);
        Controls.Add(LanguageTextBox);
        Controls.Add(LanguageCaptionLabel);
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
    private Label LanguageCaptionLabel;
    private TextBox LanguageTextBox;
    private Button LanguageDetailButton;
    private Button CloseButton;
}