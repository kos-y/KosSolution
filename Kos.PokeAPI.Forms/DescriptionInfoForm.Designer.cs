namespace Kos.PokeAPI.Forms;

partial class DescriptionInfoForm
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
        DescriptionTextBox = new TextBox();
        LanguageCaptionLabel = new Label();
        DescriptionCaptionLabel = new Label();
        SuspendLayout();
        // 
        // CloseButton
        // 
        CloseButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
        CloseButton.Location = new Point(387, 87);
        CloseButton.Margin = new Padding(4, 3, 4, 3);
        CloseButton.Name = "CloseButton";
        CloseButton.Size = new Size(81, 40);
        CloseButton.TabIndex = 5;
        CloseButton.Text = "閉じる";
        CloseButton.UseVisualStyleBackColor = true;
        CloseButton.Click += this.CloseButton_Click;
        // 
        // LanguageDetailButton
        // 
        LanguageDetailButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
        LanguageDetailButton.Location = new Point(424, 44);
        LanguageDetailButton.Margin = new Padding(4, 3, 4, 3);
        LanguageDetailButton.Name = "LanguageDetailButton";
        LanguageDetailButton.Size = new Size(44, 26);
        LanguageDetailButton.TabIndex = 4;
        LanguageDetailButton.Text = "詳細";
        LanguageDetailButton.UseVisualStyleBackColor = true;
        LanguageDetailButton.Click += LanguageDetailButton_Click;
        // 
        // LanguageTextBox
        // 
        LanguageTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        LanguageTextBox.Location = new Point(68, 44);
        LanguageTextBox.Margin = new Padding(4, 3, 4, 3);
        LanguageTextBox.Name = "LanguageTextBox";
        LanguageTextBox.ReadOnly = true;
        LanguageTextBox.Size = new Size(348, 24);
        LanguageTextBox.TabIndex = 3;
        LanguageTextBox.Text = "ja-Hrkt";
        // 
        // DescriptionTextBox
        // 
        DescriptionTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        DescriptionTextBox.Location = new Point(68, 10);
        DescriptionTextBox.Margin = new Padding(4, 3, 4, 3);
        DescriptionTextBox.Name = "DescriptionTextBox";
        DescriptionTextBox.ReadOnly = true;
        DescriptionTextBox.Size = new Size(399, 24);
        DescriptionTextBox.TabIndex = 1;
        DescriptionTextBox.Text = "ピカチュウ";
        // 
        // LanguageCaptionLabel
        // 
        LanguageCaptionLabel.AutoSize = true;
        LanguageCaptionLabel.Font = new Font("Meiryo UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 128);
        LanguageCaptionLabel.Location = new Point(17, 48);
        LanguageCaptionLabel.Margin = new Padding(4, 0, 4, 0);
        LanguageCaptionLabel.Name = "LanguageCaptionLabel";
        LanguageCaptionLabel.Size = new Size(34, 17);
        LanguageCaptionLabel.TabIndex = 2;
        LanguageCaptionLabel.Text = "言語";
        // 
        // DescriptionCaptionLabel
        // 
        DescriptionCaptionLabel.AutoSize = true;
        DescriptionCaptionLabel.Font = new Font("Meiryo UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 128);
        DescriptionCaptionLabel.Location = new Point(17, 14);
        DescriptionCaptionLabel.Margin = new Padding(4, 0, 4, 0);
        DescriptionCaptionLabel.Name = "DescriptionCaptionLabel";
        DescriptionCaptionLabel.Size = new Size(34, 17);
        DescriptionCaptionLabel.TabIndex = 0;
        DescriptionCaptionLabel.Text = "説明";
        // 
        // DescriptionInfoForm
        // 
        AutoScaleDimensions = new SizeF(9F, 17F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(485, 137);
        Controls.Add(CloseButton);
        Controls.Add(LanguageDetailButton);
        Controls.Add(LanguageTextBox);
        Controls.Add(DescriptionTextBox);
        Controls.Add(LanguageCaptionLabel);
        Controls.Add(DescriptionCaptionLabel);
        Font = new Font("Meiryo UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 128);
        Margin = new Padding(4, 3, 4, 3);
        Name = "DescriptionInfoForm";
        StartPosition = FormStartPosition.CenterParent;
        Text = "説明";
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private Button CloseButton;
    private Button LanguageDetailButton;
    private TextBox LanguageTextBox;
    private TextBox DescriptionTextBox;
    private Label LanguageCaptionLabel;
    private Label DescriptionCaptionLabel;
}