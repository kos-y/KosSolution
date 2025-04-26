namespace Kos.PokeAPI.Forms;

partial class ContestNameInfoForm
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
        ContestNameTextBox = new TextBox();
        LanguageCaptionLabel = new Label();
        ContestNameCaptionLabel = new Label();
        ColorTextBox = new TextBox();
        ColorCaptionLabel = new Label();
        SuspendLayout();
        // 
        // CloseButton
        // 
        CloseButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
        CloseButton.Location = new Point(389, 113);
        CloseButton.Name = "CloseButton";
        CloseButton.Size = new Size(63, 35);
        CloseButton.TabIndex = 7;
        CloseButton.Text = "閉じる";
        CloseButton.UseVisualStyleBackColor = true;
        CloseButton.Click += CloseButton_Click;
        // 
        // LanguageDetailButton
        // 
        LanguageDetailButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
        LanguageDetailButton.Location = new Point(399, 66);
        LanguageDetailButton.Name = "LanguageDetailButton";
        LanguageDetailButton.Size = new Size(53, 27);
        LanguageDetailButton.TabIndex = 6;
        LanguageDetailButton.Text = "詳細";
        LanguageDetailButton.UseVisualStyleBackColor = true;
        LanguageDetailButton.Click += LanguageDetailButton_Click;
        // 
        // LanguageTextBox
        // 
        LanguageTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        LanguageTextBox.Location = new Point(124, 66);
        LanguageTextBox.Name = "LanguageTextBox";
        LanguageTextBox.ReadOnly = true;
        LanguageTextBox.Size = new Size(269, 24);
        LanguageTextBox.TabIndex = 5;
        LanguageTextBox.Text = "ja-Hrkt";
        // 
        // ContestNameTextBox
        // 
        ContestNameTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        ContestNameTextBox.Location = new Point(124, 6);
        ContestNameTextBox.Name = "ContestNameTextBox";
        ContestNameTextBox.ReadOnly = true;
        ContestNameTextBox.Size = new Size(328, 24);
        ContestNameTextBox.TabIndex = 1;
        ContestNameTextBox.Text = "ピカチュウ";
        // 
        // LanguageCaptionLabel
        // 
        LanguageCaptionLabel.AutoSize = true;
        LanguageCaptionLabel.Font = new Font("Meiryo UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 128);
        LanguageCaptionLabel.Location = new Point(75, 69);
        LanguageCaptionLabel.Name = "LanguageCaptionLabel";
        LanguageCaptionLabel.Size = new Size(34, 17);
        LanguageCaptionLabel.TabIndex = 4;
        LanguageCaptionLabel.Text = "言語";
        // 
        // ContestNameCaptionLabel
        // 
        ContestNameCaptionLabel.AutoSize = true;
        ContestNameCaptionLabel.Font = new Font("Meiryo UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 128);
        ContestNameCaptionLabel.Location = new Point(12, 9);
        ContestNameCaptionLabel.Name = "ContestNameCaptionLabel";
        ContestNameCaptionLabel.Size = new Size(97, 17);
        ContestNameCaptionLabel.TabIndex = 0;
        ContestNameCaptionLabel.Text = "コンテストの名前";
        // 
        // ColorTextBox
        // 
        ColorTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        ColorTextBox.Location = new Point(124, 36);
        ColorTextBox.Name = "ColorTextBox";
        ColorTextBox.ReadOnly = true;
        ColorTextBox.Size = new Size(328, 24);
        ColorTextBox.TabIndex = 3;
        ColorTextBox.Text = "ピカチュウ";
        // 
        // ColorCaptionLabel
        // 
        ColorCaptionLabel.AutoSize = true;
        ColorCaptionLabel.Font = new Font("Meiryo UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 128);
        ColorCaptionLabel.Location = new Point(88, 39);
        ColorCaptionLabel.Name = "ColorCaptionLabel";
        ColorCaptionLabel.Size = new Size(21, 17);
        ColorCaptionLabel.TabIndex = 2;
        ColorCaptionLabel.Text = "色";
        // 
        // ContestNameInfoForm
        // 
        AutoScaleDimensions = new SizeF(9F, 17F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(464, 160);
        Controls.Add(ColorTextBox);
        Controls.Add(ColorCaptionLabel);
        Controls.Add(CloseButton);
        Controls.Add(LanguageDetailButton);
        Controls.Add(LanguageTextBox);
        Controls.Add(ContestNameTextBox);
        Controls.Add(LanguageCaptionLabel);
        Controls.Add(ContestNameCaptionLabel);
        Font = new Font("Meiryo UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 128);
        Margin = new Padding(4, 3, 4, 3);
        MaximizeBox = false;
        Name = "ContestNameInfoForm";
        StartPosition = FormStartPosition.CenterParent;
        Text = "コンテストの名前";
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private Button CloseButton;
    private Button LanguageDetailButton;
    private TextBox LanguageTextBox;
    private TextBox ContestNameTextBox;
    private Label LanguageCaptionLabel;
    private Label ContestNameCaptionLabel;
    private TextBox ColorTextBox;
    private Label ColorCaptionLabel;
}