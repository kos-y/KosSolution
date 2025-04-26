namespace Kos.PokeAPI.Forms;

partial class EffectInfoForm
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
        CloseButton = new Button();
        LanguageDetailButton = new Button();
        LanguageTextBox = new TextBox();
        EffectTextBox = new TextBox();
        LanguageCaptionLabel = new Label();
        EffectCaptionLabel = new Label();
        SuspendLayout();
        // 
        // CloseButton
        // 
        CloseButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
        CloseButton.Location = new Point(700, 79);
        CloseButton.Name = "CloseButton";
        CloseButton.Size = new Size(63, 35);
        CloseButton.TabIndex = 11;
        CloseButton.Text = "閉じる";
        CloseButton.UseVisualStyleBackColor = true;
        CloseButton.Click += CloseButton_Click;
        // 
        // LanguageDetailButton
        // 
        LanguageDetailButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
        LanguageDetailButton.Location = new Point(710, 42);
        LanguageDetailButton.Name = "LanguageDetailButton";
        LanguageDetailButton.Size = new Size(53, 23);
        LanguageDetailButton.TabIndex = 10;
        LanguageDetailButton.Text = "詳細";
        LanguageDetailButton.UseVisualStyleBackColor = true;
        LanguageDetailButton.Click += LanguageDetailButton_Click;
        // 
        // LanguageTextBox
        // 
        LanguageTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        LanguageTextBox.Location = new Point(57, 42);
        LanguageTextBox.Name = "LanguageTextBox";
        LanguageTextBox.ReadOnly = true;
        LanguageTextBox.Size = new Size(647, 24);
        LanguageTextBox.TabIndex = 9;
        LanguageTextBox.Text = "ja-Hrkt";
        // 
        // EffectTextBox
        // 
        EffectTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        EffectTextBox.Location = new Point(57, 12);
        EffectTextBox.Name = "EffectTextBox";
        EffectTextBox.ReadOnly = true;
        EffectTextBox.Size = new Size(706, 24);
        EffectTextBox.TabIndex = 7;
        EffectTextBox.Text = "ピカチュウ";
        // 
        // LanguageCaptionLabel
        // 
        LanguageCaptionLabel.AutoSize = true;
        LanguageCaptionLabel.Font = new Font("Meiryo UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 128);
        LanguageCaptionLabel.Location = new Point(17, 45);
        LanguageCaptionLabel.Name = "LanguageCaptionLabel";
        LanguageCaptionLabel.Size = new Size(34, 17);
        LanguageCaptionLabel.TabIndex = 8;
        LanguageCaptionLabel.Text = "言語";
        // 
        // EffectCaptionLabel
        // 
        EffectCaptionLabel.AutoSize = true;
        EffectCaptionLabel.Font = new Font("Meiryo UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 128);
        EffectCaptionLabel.Location = new Point(17, 15);
        EffectCaptionLabel.Name = "EffectCaptionLabel";
        EffectCaptionLabel.Size = new Size(34, 17);
        EffectCaptionLabel.TabIndex = 6;
        EffectCaptionLabel.Text = "効果";
        // 
        // EffectInfoForm
        // 
        AutoScaleDimensions = new SizeF(9F, 17F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(770, 126);
        Controls.Add(CloseButton);
        Controls.Add(LanguageDetailButton);
        Controls.Add(LanguageTextBox);
        Controls.Add(EffectTextBox);
        Controls.Add(LanguageCaptionLabel);
        Controls.Add(EffectCaptionLabel);
        Font = new Font("Meiryo UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 128);
        Margin = new Padding(4, 3, 4, 3);
        MaximizeBox = false;
        Name = "EffectInfoForm";
        StartPosition = FormStartPosition.CenterParent;
        Text = "効果";
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private Button CloseButton;
    private Button LanguageDetailButton;
    private TextBox LanguageTextBox;
    private TextBox EffectTextBox;
    private Label LanguageCaptionLabel;
    private Label EffectCaptionLabel;
}