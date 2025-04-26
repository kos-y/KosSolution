namespace Kos.PokeAPI.Forms;

partial class NameInfoForm
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
        NameCaptionLabel = new Label();
        LanguageCaptionLabel = new Label();
        NameTextBox = new TextBox();
        LanguageTextBox = new TextBox();
        LanguageDetailButton = new Button();
        CloseButton = new Button();
        SuspendLayout();
        // 
        // NameCaptionLabel
        // 
        NameCaptionLabel.AutoSize = true;
        NameCaptionLabel.Font = new Font("Meiryo UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 128);
        NameCaptionLabel.Location = new Point(14, 9);
        NameCaptionLabel.Name = "NameCaptionLabel";
        NameCaptionLabel.Size = new Size(34, 17);
        NameCaptionLabel.TabIndex = 0;
        NameCaptionLabel.Text = "名前";
        // 
        // LanguageCaptionLabel
        // 
        LanguageCaptionLabel.AutoSize = true;
        LanguageCaptionLabel.Font = new Font("Meiryo UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 128);
        LanguageCaptionLabel.Location = new Point(14, 39);
        LanguageCaptionLabel.Name = "LanguageCaptionLabel";
        LanguageCaptionLabel.Size = new Size(34, 17);
        LanguageCaptionLabel.TabIndex = 2;
        LanguageCaptionLabel.Text = "言語";
        // 
        // NameTextBox
        // 
        NameTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        NameTextBox.Location = new Point(54, 6);
        NameTextBox.Name = "NameTextBox";
        NameTextBox.ReadOnly = true;
        NameTextBox.Size = new Size(311, 24);
        NameTextBox.TabIndex = 1;
        NameTextBox.Text = "ピカチュウ";
        // 
        // LanguageTextBox
        // 
        LanguageTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        LanguageTextBox.Location = new Point(54, 36);
        LanguageTextBox.Name = "LanguageTextBox";
        LanguageTextBox.ReadOnly = true;
        LanguageTextBox.Size = new Size(252, 24);
        LanguageTextBox.TabIndex = 3;
        LanguageTextBox.Text = "ja-Hrkt";
        // 
        // LanguageDetailButton
        // 
        LanguageDetailButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
        LanguageDetailButton.Location = new Point(312, 36);
        LanguageDetailButton.Name = "LanguageDetailButton";
        LanguageDetailButton.Size = new Size(53, 23);
        LanguageDetailButton.TabIndex = 4;
        LanguageDetailButton.Text = "詳細";
        LanguageDetailButton.UseVisualStyleBackColor = true;
        LanguageDetailButton.Click += LanguageDetailButton_Click;
        // 
        // CloseButton
        // 
        CloseButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
        CloseButton.Location = new Point(302, 74);
        CloseButton.Name = "CloseButton";
        CloseButton.Size = new Size(63, 35);
        CloseButton.TabIndex = 5;
        CloseButton.Text = "閉じる";
        CloseButton.UseVisualStyleBackColor = true;
        CloseButton.Click += CloseButton_Click;
        // 
        // NameInfoForm
        // 
        AutoScaleDimensions = new SizeF(9F, 17F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(377, 121);
        Controls.Add(CloseButton);
        Controls.Add(LanguageDetailButton);
        Controls.Add(LanguageTextBox);
        Controls.Add(NameTextBox);
        Controls.Add(LanguageCaptionLabel);
        Controls.Add(NameCaptionLabel);
        Font = new Font("Meiryo UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 128);
        MaximizeBox = false;
        Name = "NameInfoForm";
        StartPosition = FormStartPosition.CenterParent;
        Text = "名前";
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private Label NameCaptionLabel;
    private Label LanguageCaptionLabel;
    private TextBox NameTextBox;
    private TextBox LanguageTextBox;
    private Button LanguageDetailButton;
    private Button CloseButton;
}