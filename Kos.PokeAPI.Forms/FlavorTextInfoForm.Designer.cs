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
        LanguageButton = new Button();
        LanguageTextBox = new TextBox();
        VersionTextBox = new TextBox();
        VersionButton = new Button();
        CloseButton = new Button();
        PropertyButton = new Button();
        SuspendLayout();
        // 
        // FlavorTextCaptionLabel
        // 
        FlavorTextCaptionLabel.AutoSize = true;
        FlavorTextCaptionLabel.Location = new Point(11, 78);
        FlavorTextCaptionLabel.Margin = new Padding(2, 0, 2, 0);
        FlavorTextCaptionLabel.Name = "FlavorTextCaptionLabel";
        FlavorTextCaptionLabel.Size = new Size(85, 15);
        FlavorTextCaptionLabel.TabIndex = 4;
        FlavorTextCaptionLabel.Text = "フレーバーテキスト";
        // 
        // FlavorTextTextBox
        // 
        FlavorTextTextBox.Location = new Point(11, 96);
        FlavorTextTextBox.Margin = new Padding(2, 3, 2, 3);
        FlavorTextTextBox.Multiline = true;
        FlavorTextTextBox.Name = "FlavorTextTextBox";
        FlavorTextTextBox.ReadOnly = true;
        FlavorTextTextBox.Size = new Size(232, 150);
        FlavorTextTextBox.TabIndex = 5;
        FlavorTextTextBox.Text = "ピカチュウ";
        // 
        // LanguageButton
        // 
        LanguageButton.Location = new Point(11, 41);
        LanguageButton.Margin = new Padding(2, 3, 2, 3);
        LanguageButton.Name = "LanguageButton";
        LanguageButton.Size = new Size(63, 23);
        LanguageButton.TabIndex = 2;
        LanguageButton.Text = "言語";
        LanguageButton.UseVisualStyleBackColor = true;
        LanguageButton.Click += LanguageButton_Click;
        // 
        // LanguageTextBox
        // 
        LanguageTextBox.Location = new Point(78, 42);
        LanguageTextBox.Margin = new Padding(2, 3, 2, 3);
        LanguageTextBox.Name = "LanguageTextBox";
        LanguageTextBox.ReadOnly = true;
        LanguageTextBox.Size = new Size(165, 23);
        LanguageTextBox.TabIndex = 3;
        LanguageTextBox.Text = "ja-Hrkt";
        // 
        // VersionTextBox
        // 
        VersionTextBox.Location = new Point(78, 12);
        VersionTextBox.Margin = new Padding(2, 3, 2, 3);
        VersionTextBox.Name = "VersionTextBox";
        VersionTextBox.ReadOnly = true;
        VersionTextBox.Size = new Size(165, 23);
        VersionTextBox.TabIndex = 1;
        VersionTextBox.Text = "Red";
        // 
        // VersionButton
        // 
        VersionButton.Location = new Point(11, 11);
        VersionButton.Margin = new Padding(2, 3, 2, 3);
        VersionButton.Name = "VersionButton";
        VersionButton.Size = new Size(63, 23);
        VersionButton.TabIndex = 0;
        VersionButton.Text = "バージョン";
        VersionButton.UseVisualStyleBackColor = true;
        VersionButton.Click += VersionDetailButton_Click;
        // 
        // CloseButton
        // 
        CloseButton.Location = new Point(184, 252);
        CloseButton.Margin = new Padding(2, 3, 2, 3);
        CloseButton.Name = "CloseButton";
        CloseButton.Size = new Size(59, 31);
        CloseButton.TabIndex = 7;
        CloseButton.Text = "閉じる";
        CloseButton.UseVisualStyleBackColor = true;
        CloseButton.Click += CloseButton_Click;
        // 
        // PropertyButton
        // 
        PropertyButton.Location = new Point(121, 252);
        PropertyButton.Margin = new Padding(2, 3, 2, 3);
        PropertyButton.Name = "PropertyButton";
        PropertyButton.Size = new Size(59, 31);
        PropertyButton.TabIndex = 6;
        PropertyButton.Text = "プロパティ";
        PropertyButton.UseVisualStyleBackColor = true;
        PropertyButton.Click += PropertyButton_Click;
        // 
        // FlavorTextInfoForm
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(256, 292);
        Controls.Add(PropertyButton);
        Controls.Add(CloseButton);
        Controls.Add(VersionButton);
        Controls.Add(VersionTextBox);
        Controls.Add(LanguageButton);
        Controls.Add(LanguageTextBox);
        Controls.Add(FlavorTextTextBox);
        Controls.Add(FlavorTextCaptionLabel);
        FormBorderStyle = FormBorderStyle.FixedSingle;
        MaximizeBox = false;
        Name = "FlavorTextInfoForm";
        StartPosition = FormStartPosition.CenterParent;
        Text = "フレーバーテキスト";
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private Label FlavorTextCaptionLabel;
    private TextBox FlavorTextTextBox;
    private Button LanguageButton;
    private TextBox LanguageTextBox;
    private TextBox VersionTextBox;
    private Button VersionButton;
    private Button CloseButton;
    private Button PropertyButton;
}