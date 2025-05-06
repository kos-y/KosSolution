namespace Kos.PokeAPI.Forms;

partial class MoveFlavorTextInfoForm
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
        VersionGroupDetailButton = new Button();
        VersionGroupCaptionLabel = new Label();
        VersionGroupTextBox = new TextBox();
        LanguageCaptionLabel = new Label();
        LanguageTextBox = new TextBox();
        LanguageDetailButton = new Button();
        FlavorTextCaptionLabel = new Label();
        FlavorTextTextBox = new TextBox();
        CloseButton = new Button();
        SuspendLayout();
        // 
        // VersionGroupDetailButton
        // 
        VersionGroupDetailButton.Location = new Point(322, 10);
        VersionGroupDetailButton.Margin = new Padding(4, 3, 4, 3);
        VersionGroupDetailButton.Name = "VersionGroupDetailButton";
        VersionGroupDetailButton.Size = new Size(55, 27);
        VersionGroupDetailButton.TabIndex = 2;
        VersionGroupDetailButton.Text = "詳細";
        VersionGroupDetailButton.UseVisualStyleBackColor = true;
        VersionGroupDetailButton.Click += VersionGroupDetailButton_Click;
        // 
        // VersionGroupCaptionLabel
        // 
        VersionGroupCaptionLabel.AutoSize = true;
        VersionGroupCaptionLabel.Location = new Point(13, 15);
        VersionGroupCaptionLabel.Margin = new Padding(4, 0, 4, 0);
        VersionGroupCaptionLabel.Name = "VersionGroupCaptionLabel";
        VersionGroupCaptionLabel.Size = new Size(104, 17);
        VersionGroupCaptionLabel.TabIndex = 0;
        VersionGroupCaptionLabel.Text = "バージョングループ";
        VersionGroupCaptionLabel.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // VersionGroupTextBox
        // 
        VersionGroupTextBox.Location = new Point(124, 12);
        VersionGroupTextBox.Name = "VersionGroupTextBox";
        VersionGroupTextBox.ReadOnly = true;
        VersionGroupTextBox.Size = new Size(191, 24);
        VersionGroupTextBox.TabIndex = 1;
        // 
        // LanguageCaptionLabel
        // 
        LanguageCaptionLabel.AutoSize = true;
        LanguageCaptionLabel.Location = new Point(83, 45);
        LanguageCaptionLabel.Margin = new Padding(4, 0, 4, 0);
        LanguageCaptionLabel.Name = "LanguageCaptionLabel";
        LanguageCaptionLabel.Size = new Size(34, 17);
        LanguageCaptionLabel.TabIndex = 3;
        LanguageCaptionLabel.Text = "言語";
        LanguageCaptionLabel.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // LanguageTextBox
        // 
        LanguageTextBox.Location = new Point(124, 42);
        LanguageTextBox.Name = "LanguageTextBox";
        LanguageTextBox.ReadOnly = true;
        LanguageTextBox.Size = new Size(191, 24);
        LanguageTextBox.TabIndex = 4;
        // 
        // LanguageDetailButton
        // 
        LanguageDetailButton.Location = new Point(322, 40);
        LanguageDetailButton.Margin = new Padding(4, 3, 4, 3);
        LanguageDetailButton.Name = "LanguageDetailButton";
        LanguageDetailButton.Size = new Size(55, 27);
        LanguageDetailButton.TabIndex = 5;
        LanguageDetailButton.Text = "詳細";
        LanguageDetailButton.UseVisualStyleBackColor = true;
        LanguageDetailButton.Click += LanguageDetailButton_Click;
        // 
        // FlavorTextCaptionLabel
        // 
        FlavorTextCaptionLabel.AutoSize = true;
        FlavorTextCaptionLabel.Location = new Point(13, 79);
        FlavorTextCaptionLabel.Margin = new Padding(4, 0, 4, 0);
        FlavorTextCaptionLabel.Name = "FlavorTextCaptionLabel";
        FlavorTextCaptionLabel.Size = new Size(103, 17);
        FlavorTextCaptionLabel.TabIndex = 6;
        FlavorTextCaptionLabel.Text = "フレーバーテキスト";
        FlavorTextCaptionLabel.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // FlavorTextTextBox
        // 
        FlavorTextTextBox.Location = new Point(13, 99);
        FlavorTextTextBox.Multiline = true;
        FlavorTextTextBox.Name = "FlavorTextTextBox";
        FlavorTextTextBox.ReadOnly = true;
        FlavorTextTextBox.Size = new Size(364, 170);
        FlavorTextTextBox.TabIndex = 7;
        FlavorTextTextBox.Text = "ピカチュウ";
        // 
        // CloseButton
        // 
        CloseButton.Location = new Point(314, 275);
        CloseButton.Name = "CloseButton";
        CloseButton.Size = new Size(63, 35);
        CloseButton.TabIndex = 8;
        CloseButton.Text = "閉じる";
        CloseButton.UseVisualStyleBackColor = true;
        CloseButton.Click += CloseButton_Click;
        // 
        // MoveFlavorTextInfoForm
        // 
        AutoScaleDimensions = new SizeF(9F, 17F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(397, 322);
        Controls.Add(CloseButton);
        Controls.Add(FlavorTextTextBox);
        Controls.Add(FlavorTextCaptionLabel);
        Controls.Add(LanguageDetailButton);
        Controls.Add(LanguageTextBox);
        Controls.Add(LanguageCaptionLabel);
        Controls.Add(VersionGroupDetailButton);
        Controls.Add(VersionGroupCaptionLabel);
        Controls.Add(VersionGroupTextBox);
        Font = new Font("Meiryo UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 128);
        FormBorderStyle = FormBorderStyle.FixedSingle;
        Margin = new Padding(4, 3, 4, 3);
        MaximizeBox = false;
        Name = "MoveFlavorTextInfoForm";
        StartPosition = FormStartPosition.CenterParent;
        Text = "技のフレーバーテキスト";
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private Button VersionGroupDetailButton;
    private Label VersionGroupCaptionLabel;
    private TextBox VersionGroupTextBox;
    private Label LanguageCaptionLabel;
    private TextBox LanguageTextBox;
    private Button LanguageDetailButton;
    private Label FlavorTextCaptionLabel;
    private TextBox FlavorTextTextBox;
    private Button CloseButton;
}