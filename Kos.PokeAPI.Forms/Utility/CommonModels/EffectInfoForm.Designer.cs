namespace Kos.PokeAPI.Forms.Utility.CommonModels;

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
        LanguageButton = new Button();
        LanguageTextBox = new TextBox();
        EffectTextBox = new TextBox();
        EffectCaptionLabel = new Label();
        PropertyButton = new Button();
        SuspendLayout();
        // 
        // CloseButton
        // 
        CloseButton.Location = new Point(499, 68);
        CloseButton.Margin = new Padding(2, 3, 2, 3);
        CloseButton.Name = "CloseButton";
        CloseButton.Size = new Size(59, 31);
        CloseButton.TabIndex = 5;
        CloseButton.Text = "閉じる";
        CloseButton.UseVisualStyleBackColor = true;
        CloseButton.Click += CloseButton_Click;
        // 
        // LanguageButton
        // 
        LanguageButton.Location = new Point(11, 38);
        LanguageButton.Margin = new Padding(2, 3, 2, 3);
        LanguageButton.Name = "LanguageButton";
        LanguageButton.Size = new Size(41, 22);
        LanguageButton.TabIndex = 2;
        LanguageButton.Text = "言語";
        LanguageButton.UseVisualStyleBackColor = true;
        LanguageButton.Click += LanguageButton_Click;
        // 
        // LanguageTextBox
        // 
        LanguageTextBox.Location = new Point(54, 39);
        LanguageTextBox.Margin = new Padding(2, 3, 2, 3);
        LanguageTextBox.Name = "LanguageTextBox";
        LanguageTextBox.ReadOnly = true;
        LanguageTextBox.Size = new Size(504, 23);
        LanguageTextBox.TabIndex = 3;
        LanguageTextBox.Text = "ja-Hrkt";
        // 
        // EffectTextBox
        // 
        EffectTextBox.Location = new Point(58, 10);
        EffectTextBox.Margin = new Padding(2, 3, 2, 3);
        EffectTextBox.Name = "EffectTextBox";
        EffectTextBox.ReadOnly = true;
        EffectTextBox.Size = new Size(504, 23);
        EffectTextBox.TabIndex = 1;
        EffectTextBox.Text = "ピカチュウ";
        // 
        // EffectCaptionLabel
        // 
        EffectCaptionLabel.AutoSize = true;
        EffectCaptionLabel.Location = new Point(21, 13);
        EffectCaptionLabel.Margin = new Padding(2, 0, 2, 0);
        EffectCaptionLabel.Name = "EffectCaptionLabel";
        EffectCaptionLabel.Size = new Size(31, 15);
        EffectCaptionLabel.TabIndex = 0;
        EffectCaptionLabel.Text = "効果";
        // 
        // PropertyButton
        // 
        PropertyButton.Location = new Point(436, 68);
        PropertyButton.Margin = new Padding(2, 3, 2, 3);
        PropertyButton.Name = "PropertyButton";
        PropertyButton.Size = new Size(59, 31);
        PropertyButton.TabIndex = 4;
        PropertyButton.Text = "プロパティ";
        PropertyButton.UseVisualStyleBackColor = true;
        PropertyButton.Click += PropertyButton_Click;
        // 
        // EffectInfoForm
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(573, 111);
        Controls.Add(PropertyButton);
        Controls.Add(CloseButton);
        Controls.Add(LanguageButton);
        Controls.Add(LanguageTextBox);
        Controls.Add(EffectTextBox);
        Controls.Add(EffectCaptionLabel);
        MaximizeBox = false;
        Name = "EffectInfoForm";
        StartPosition = FormStartPosition.CenterParent;
        Text = "効果";
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private Button CloseButton;
    private Button LanguageButton;
    private TextBox LanguageTextBox;
    private TextBox EffectTextBox;
    private Label EffectCaptionLabel;
    private Button PropertyButton;
}