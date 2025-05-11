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
        LanguageButton = new Button();
        LanguageTextBox = new TextBox();
        EffectTextBox = new TextBox();
        EffectCaptionLabel = new Label();
        PropertyButton = new Button();
        SuspendLayout();
        // 
        // CloseButton
        // 
        CloseButton.Location = new Point(642, 71);
        CloseButton.Name = "CloseButton";
        CloseButton.Size = new Size(76, 35);
        CloseButton.TabIndex = 5;
        CloseButton.Text = "閉じる";
        CloseButton.UseVisualStyleBackColor = true;
        CloseButton.Click += CloseButton_Click;
        // 
        // LanguageButton
        // 
        LanguageButton.Location = new Point(12, 42);
        LanguageButton.Name = "LanguageButton";
        LanguageButton.Size = new Size(53, 23);
        LanguageButton.TabIndex = 2;
        LanguageButton.Text = "言語";
        LanguageButton.UseVisualStyleBackColor = true;
        LanguageButton.Click += LanguageButton_Click;
        // 
        // LanguageTextBox
        // 
        LanguageTextBox.Location = new Point(71, 41);
        LanguageTextBox.Name = "LanguageTextBox";
        LanguageTextBox.ReadOnly = true;
        LanguageTextBox.Size = new Size(647, 24);
        LanguageTextBox.TabIndex = 3;
        LanguageTextBox.Text = "ja-Hrkt";
        // 
        // EffectTextBox
        // 
        EffectTextBox.Location = new Point(71, 12);
        EffectTextBox.Name = "EffectTextBox";
        EffectTextBox.ReadOnly = true;
        EffectTextBox.Size = new Size(647, 24);
        EffectTextBox.TabIndex = 1;
        EffectTextBox.Text = "ピカチュウ";
        // 
        // EffectCaptionLabel
        // 
        EffectCaptionLabel.AutoSize = true;
        EffectCaptionLabel.Font = new Font("Meiryo UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 128);
        EffectCaptionLabel.Location = new Point(17, 15);
        EffectCaptionLabel.Name = "EffectCaptionLabel";
        EffectCaptionLabel.Size = new Size(34, 17);
        EffectCaptionLabel.TabIndex = 0;
        EffectCaptionLabel.Text = "効果";
        // 
        // PropertyButton
        // 
        PropertyButton.Location = new Point(560, 71);
        PropertyButton.Name = "PropertyButton";
        PropertyButton.Size = new Size(76, 35);
        PropertyButton.TabIndex = 4;
        PropertyButton.Text = "プロパティ";
        PropertyButton.UseVisualStyleBackColor = true;
        PropertyButton.Click += PropertyButton_Click;
        // 
        // EffectInfoForm
        // 
        AutoScaleDimensions = new SizeF(9F, 17F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(737, 111);
        Controls.Add(PropertyButton);
        Controls.Add(CloseButton);
        Controls.Add(LanguageButton);
        Controls.Add(LanguageTextBox);
        Controls.Add(EffectTextBox);
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
    private Button LanguageButton;
    private TextBox LanguageTextBox;
    private TextBox EffectTextBox;
    private Label EffectCaptionLabel;
    private Button PropertyButton;
}