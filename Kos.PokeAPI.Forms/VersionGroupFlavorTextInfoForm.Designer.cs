namespace Kos.PokeAPI.Forms;

partial class VersionGroupFlavorTextInfoForm
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
        FlavorTextTextBox = new TextBox();
        FlavorTextCaptionLabel = new Label();
        LanguageDetailButton = new Button();
        LanguageTextBox = new TextBox();
        LanguageCaptionLabel = new Label();
        VersionGroupCaptionLabel = new Label();
        VersionGroupTextBox = new TextBox();
        VersionGroupDetailButton = new Button();
        CloseButton = new Button();
        SuspendLayout();
        // 
        // FlavorTextTextBox
        // 
        FlavorTextTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        FlavorTextTextBox.Location = new Point(124, 12);
        FlavorTextTextBox.Margin = new Padding(4, 3, 4, 3);
        FlavorTextTextBox.Name = "FlavorTextTextBox";
        FlavorTextTextBox.ReadOnly = true;
        FlavorTextTextBox.Size = new Size(755, 24);
        FlavorTextTextBox.TabIndex = 1;
        FlavorTextTextBox.Text = "フレーバーテキスト";
        // 
        // FlavorTextCaptionLabel
        // 
        FlavorTextCaptionLabel.AutoSize = true;
        FlavorTextCaptionLabel.Font = new Font("Meiryo UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 128);
        FlavorTextCaptionLabel.Location = new Point(13, 15);
        FlavorTextCaptionLabel.Margin = new Padding(4, 0, 4, 0);
        FlavorTextCaptionLabel.Name = "FlavorTextCaptionLabel";
        FlavorTextCaptionLabel.Size = new Size(103, 17);
        FlavorTextCaptionLabel.TabIndex = 0;
        FlavorTextCaptionLabel.Text = "フレーバーテキスト";
        // 
        // LanguageDetailButton
        // 
        LanguageDetailButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
        LanguageDetailButton.Location = new Point(826, 43);
        LanguageDetailButton.Name = "LanguageDetailButton";
        LanguageDetailButton.Size = new Size(53, 23);
        LanguageDetailButton.TabIndex = 4;
        LanguageDetailButton.Text = "詳細";
        LanguageDetailButton.UseVisualStyleBackColor = true;
        LanguageDetailButton.Click += LanguageDetailButton_Click;
        // 
        // LanguageTextBox
        // 
        LanguageTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        LanguageTextBox.Location = new Point(124, 42);
        LanguageTextBox.Name = "LanguageTextBox";
        LanguageTextBox.ReadOnly = true;
        LanguageTextBox.Size = new Size(696, 24);
        LanguageTextBox.TabIndex = 3;
        LanguageTextBox.Text = "ja-Hrkt";
        // 
        // LanguageCaptionLabel
        // 
        LanguageCaptionLabel.AutoSize = true;
        LanguageCaptionLabel.Font = new Font("Meiryo UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 128);
        LanguageCaptionLabel.Location = new Point(84, 45);
        LanguageCaptionLabel.Name = "LanguageCaptionLabel";
        LanguageCaptionLabel.Size = new Size(34, 17);
        LanguageCaptionLabel.TabIndex = 2;
        LanguageCaptionLabel.Text = "言語";
        // 
        // VersionGroupCaptionLabel
        // 
        VersionGroupCaptionLabel.AutoSize = true;
        VersionGroupCaptionLabel.Font = new Font("Meiryo UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 128);
        VersionGroupCaptionLabel.Location = new Point(12, 75);
        VersionGroupCaptionLabel.Margin = new Padding(4, 0, 4, 0);
        VersionGroupCaptionLabel.Name = "VersionGroupCaptionLabel";
        VersionGroupCaptionLabel.Size = new Size(104, 17);
        VersionGroupCaptionLabel.TabIndex = 5;
        VersionGroupCaptionLabel.Text = "バージョングループ";
        // 
        // VersionGroupTextBox
        // 
        VersionGroupTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        VersionGroupTextBox.Location = new Point(124, 72);
        VersionGroupTextBox.Name = "VersionGroupTextBox";
        VersionGroupTextBox.ReadOnly = true;
        VersionGroupTextBox.Size = new Size(696, 24);
        VersionGroupTextBox.TabIndex = 6;
        VersionGroupTextBox.Text = "ja-Hrkt";
        // 
        // VersionGroupDetailButton
        // 
        VersionGroupDetailButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
        VersionGroupDetailButton.Location = new Point(826, 72);
        VersionGroupDetailButton.Name = "VersionGroupDetailButton";
        VersionGroupDetailButton.Size = new Size(53, 23);
        VersionGroupDetailButton.TabIndex = 7;
        VersionGroupDetailButton.Text = "詳細";
        VersionGroupDetailButton.UseVisualStyleBackColor = true;
        VersionGroupDetailButton.Click += VersionGroupDetailButton_Click;
        // 
        // CloseButton
        // 
        CloseButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
        CloseButton.Location = new Point(816, 112);
        CloseButton.Name = "CloseButton";
        CloseButton.Size = new Size(63, 35);
        CloseButton.TabIndex = 8;
        CloseButton.Text = "閉じる";
        CloseButton.UseVisualStyleBackColor = true;
        CloseButton.Click += CloseButton_Click;
        // 
        // VersionGroupFlavorTextInfoForm
        // 
        AutoScaleDimensions = new SizeF(9F, 17F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(891, 156);
        Controls.Add(CloseButton);
        Controls.Add(VersionGroupDetailButton);
        Controls.Add(VersionGroupTextBox);
        Controls.Add(VersionGroupCaptionLabel);
        Controls.Add(LanguageDetailButton);
        Controls.Add(LanguageTextBox);
        Controls.Add(LanguageCaptionLabel);
        Controls.Add(FlavorTextTextBox);
        Controls.Add(FlavorTextCaptionLabel);
        Font = new Font("Meiryo UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 128);
        Margin = new Padding(4, 3, 4, 3);
        MaximizeBox = false;
        Name = "VersionGroupFlavorTextInfoForm";
        Text = "フレーバーテキスト";
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private TextBox FlavorTextTextBox;
    private Label FlavorTextCaptionLabel;
    private Button LanguageDetailButton;
    private TextBox LanguageTextBox;
    private Label LanguageCaptionLabel;
    private Label VersionGroupCaptionLabel;
    private TextBox VersionGroupTextBox;
    private Button VersionGroupDetailButton;
    private Button CloseButton;
}