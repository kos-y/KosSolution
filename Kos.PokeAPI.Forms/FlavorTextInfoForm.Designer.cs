namespace Kos.PokeAPI.Forms;

partial class FlavorTextInfoForm
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
        FlavorTextCaptionLabel = new Label();
        FlavorTextTextBox = new TextBox();
        LanguageDetailButton = new Button();
        LanguageTextBox = new TextBox();
        LanguageCaptionLabel = new Label();
        VersionCaptionLabel = new Label();
        VersionTextBox = new TextBox();
        VersionDetailButton = new Button();
        CloseButton = new Button();
        SuspendLayout();
        // 
        // FlavorTextCaptionLabel
        // 
        FlavorTextCaptionLabel.AutoSize = true;
        FlavorTextCaptionLabel.Font = new Font("Meiryo UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 128);
        FlavorTextCaptionLabel.Location = new Point(12, 9);
        FlavorTextCaptionLabel.Name = "FlavorTextCaptionLabel";
        FlavorTextCaptionLabel.Size = new Size(103, 17);
        FlavorTextCaptionLabel.TabIndex = 0;
        FlavorTextCaptionLabel.Text = "フレーバーテキスト";
        // 
        // FlavorTextTextBox
        // 
        FlavorTextTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
        FlavorTextTextBox.Location = new Point(12, 29);
        FlavorTextTextBox.Multiline = true;
        FlavorTextTextBox.Name = "FlavorTextTextBox";
        FlavorTextTextBox.ReadOnly = true;
        FlavorTextTextBox.Size = new Size(297, 170);
        FlavorTextTextBox.TabIndex = 1;
        FlavorTextTextBox.Text = "ピカチュウ";
        // 
        // LanguageDetailButton
        // 
        LanguageDetailButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
        LanguageDetailButton.Location = new Point(258, 205);
        LanguageDetailButton.Name = "LanguageDetailButton";
        LanguageDetailButton.Size = new Size(53, 23);
        LanguageDetailButton.TabIndex = 4;
        LanguageDetailButton.Text = "詳細";
        LanguageDetailButton.UseVisualStyleBackColor = true;
        LanguageDetailButton.Click += LanguageDetailButton_Click;
        // 
        // LanguageTextBox
        // 
        LanguageTextBox.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
        LanguageTextBox.Location = new Point(80, 205);
        LanguageTextBox.Name = "LanguageTextBox";
        LanguageTextBox.ReadOnly = true;
        LanguageTextBox.Size = new Size(172, 24);
        LanguageTextBox.TabIndex = 3;
        LanguageTextBox.Text = "ピカチュウ";
        // 
        // LanguageCaptionLabel
        // 
        LanguageCaptionLabel.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
        LanguageCaptionLabel.AutoSize = true;
        LanguageCaptionLabel.Font = new Font("Meiryo UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 128);
        LanguageCaptionLabel.Location = new Point(14, 208);
        LanguageCaptionLabel.Name = "LanguageCaptionLabel";
        LanguageCaptionLabel.Size = new Size(34, 17);
        LanguageCaptionLabel.TabIndex = 2;
        LanguageCaptionLabel.Text = "言語";
        // 
        // VersionCaptionLabel
        // 
        VersionCaptionLabel.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
        VersionCaptionLabel.AutoSize = true;
        VersionCaptionLabel.Font = new Font("Meiryo UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 128);
        VersionCaptionLabel.Location = new Point(14, 237);
        VersionCaptionLabel.Name = "VersionCaptionLabel";
        VersionCaptionLabel.Size = new Size(60, 17);
        VersionCaptionLabel.TabIndex = 5;
        VersionCaptionLabel.Text = "バージョン";
        // 
        // VersionTextBox
        // 
        VersionTextBox.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
        VersionTextBox.Location = new Point(80, 235);
        VersionTextBox.Name = "VersionTextBox";
        VersionTextBox.ReadOnly = true;
        VersionTextBox.Size = new Size(172, 24);
        VersionTextBox.TabIndex = 6;
        VersionTextBox.Text = "ピカチュウ";
        // 
        // VersionDetailButton
        // 
        VersionDetailButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
        VersionDetailButton.Location = new Point(258, 234);
        VersionDetailButton.Name = "VersionDetailButton";
        VersionDetailButton.Size = new Size(53, 23);
        VersionDetailButton.TabIndex = 7;
        VersionDetailButton.Text = "詳細";
        VersionDetailButton.UseVisualStyleBackColor = true;
        VersionDetailButton.Click += VersionDetailButton_Click;
        // 
        // CloseButton
        // 
        CloseButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
        CloseButton.Location = new Point(258, 274);
        CloseButton.Name = "CloseButton";
        CloseButton.Size = new Size(63, 35);
        CloseButton.TabIndex = 8;
        CloseButton.Text = "閉じる";
        CloseButton.UseVisualStyleBackColor = true;
        // 
        // FlavorTextInfoForm
        // 
        AutoScaleDimensions = new SizeF(9F, 17F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(335, 322);
        Controls.Add(CloseButton);
        Controls.Add(VersionDetailButton);
        Controls.Add(VersionTextBox);
        Controls.Add(VersionCaptionLabel);
        Controls.Add(LanguageDetailButton);
        Controls.Add(LanguageTextBox);
        Controls.Add(LanguageCaptionLabel);
        Controls.Add(FlavorTextTextBox);
        Controls.Add(FlavorTextCaptionLabel);
        Font = new Font("Meiryo UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 128);
        Margin = new Padding(4, 3, 4, 3);
        Name = "FlavorTextInfoForm";
        StartPosition = FormStartPosition.CenterParent;
        Text = "フレーバーテキスト";
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private Label FlavorTextCaptionLabel;
    private TextBox FlavorTextTextBox;
    private Button LanguageDetailButton;
    private TextBox LanguageTextBox;
    private Label LanguageCaptionLabel;
    private Label VersionCaptionLabel;
    private TextBox VersionTextBox;
    private Button VersionDetailButton;
    private Button CloseButton;
}