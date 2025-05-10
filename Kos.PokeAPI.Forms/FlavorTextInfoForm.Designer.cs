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
        FlavorTextCaptionLabel.Font = new Font("Meiryo UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 128);
        FlavorTextCaptionLabel.Location = new Point(12, 69);
        FlavorTextCaptionLabel.Name = "FlavorTextCaptionLabel";
        FlavorTextCaptionLabel.Size = new Size(103, 17);
        FlavorTextCaptionLabel.TabIndex = 4;
        FlavorTextCaptionLabel.Text = "フレーバーテキスト";
        // 
        // FlavorTextTextBox
        // 
        FlavorTextTextBox.Location = new Point(12, 89);
        FlavorTextTextBox.Multiline = true;
        FlavorTextTextBox.Name = "FlavorTextTextBox";
        FlavorTextTextBox.ReadOnly = true;
        FlavorTextTextBox.Size = new Size(297, 170);
        FlavorTextTextBox.TabIndex = 5;
        FlavorTextTextBox.Text = "ピカチュウ";
        // 
        // LanguageButton
        // 
        LanguageButton.Location = new Point(12, 41);
        LanguageButton.Name = "LanguageButton";
        LanguageButton.Size = new Size(72, 25);
        LanguageButton.TabIndex = 2;
        LanguageButton.Text = "言語";
        LanguageButton.UseVisualStyleBackColor = true;
        LanguageButton.Click += LanguageButton_Click;
        // 
        // LanguageTextBox
        // 
        LanguageTextBox.Location = new Point(90, 42);
        LanguageTextBox.Name = "LanguageTextBox";
        LanguageTextBox.ReadOnly = true;
        LanguageTextBox.Size = new Size(172, 24);
        LanguageTextBox.TabIndex = 3;
        LanguageTextBox.Text = "ja-Hrkt";
        // 
        // VersionTextBox
        // 
        VersionTextBox.Location = new Point(90, 12);
        VersionTextBox.Name = "VersionTextBox";
        VersionTextBox.ReadOnly = true;
        VersionTextBox.Size = new Size(172, 24);
        VersionTextBox.TabIndex = 1;
        VersionTextBox.Text = "Red";
        // 
        // VersionButton
        // 
        VersionButton.Location = new Point(12, 12);
        VersionButton.Name = "VersionButton";
        VersionButton.Size = new Size(72, 24);
        VersionButton.TabIndex = 0;
        VersionButton.Text = "バージョン";
        VersionButton.UseVisualStyleBackColor = true;
        VersionButton.Click += VersionDetailButton_Click;
        // 
        // CloseButton
        // 
        CloseButton.Location = new Point(233, 265);
        CloseButton.Name = "CloseButton";
        CloseButton.Size = new Size(76, 35);
        CloseButton.TabIndex = 7;
        CloseButton.Text = "閉じる";
        CloseButton.UseVisualStyleBackColor = true;
        CloseButton.Click += CloseButton_Click;
        // 
        // PropertyButton
        // 
        PropertyButton.Location = new Point(151, 265);
        PropertyButton.Name = "PropertyButton";
        PropertyButton.Size = new Size(76, 35);
        PropertyButton.TabIndex = 6;
        PropertyButton.Text = "プロパティ";
        PropertyButton.UseVisualStyleBackColor = true;
        PropertyButton.Click += PropertyButton_Click;
        // 
        // FlavorTextInfoForm
        // 
        AutoScaleDimensions = new SizeF(9F, 17F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(327, 312);
        Controls.Add(PropertyButton);
        Controls.Add(CloseButton);
        Controls.Add(VersionButton);
        Controls.Add(VersionTextBox);
        Controls.Add(LanguageButton);
        Controls.Add(LanguageTextBox);
        Controls.Add(FlavorTextTextBox);
        Controls.Add(FlavorTextCaptionLabel);
        Font = new Font("Meiryo UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 128);
        FormBorderStyle = FormBorderStyle.FixedSingle;
        Margin = new Padding(4, 3, 4, 3);
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