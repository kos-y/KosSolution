namespace Kos.PokeAPI.Forms;

partial class AbilityFlavorTextInfoForm
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
        VersionGroupButton = new Button();
        VersionGroupTextBox = new TextBox();
        LanguageTextBox = new TextBox();
        LanguageButton = new Button();
        FlavorTextCaptionLabel = new Label();
        FlavorTextTextBox = new TextBox();
        CloseButton = new Button();
        PropertyButton = new Button();
        SuspendLayout();
        // 
        // VersionGroupButton
        // 
        VersionGroupButton.Location = new Point(13, 9);
        VersionGroupButton.Margin = new Padding(4, 3, 4, 3);
        VersionGroupButton.Name = "VersionGroupButton";
        VersionGroupButton.Size = new Size(118, 27);
        VersionGroupButton.TabIndex = 0;
        VersionGroupButton.Text = "バージョングループ";
        VersionGroupButton.UseVisualStyleBackColor = true;
        VersionGroupButton.Click += VersionGroupButton_Click;
        // 
        // VersionGroupTextBox
        // 
        VersionGroupTextBox.Location = new Point(138, 11);
        VersionGroupTextBox.Name = "VersionGroupTextBox";
        VersionGroupTextBox.ReadOnly = true;
        VersionGroupTextBox.Size = new Size(191, 24);
        VersionGroupTextBox.TabIndex = 1;
        // 
        // LanguageTextBox
        // 
        LanguageTextBox.Location = new Point(138, 44);
        LanguageTextBox.Name = "LanguageTextBox";
        LanguageTextBox.ReadOnly = true;
        LanguageTextBox.Size = new Size(191, 24);
        LanguageTextBox.TabIndex = 3;
        // 
        // LanguageButton
        // 
        LanguageButton.Location = new Point(13, 42);
        LanguageButton.Margin = new Padding(4, 3, 4, 3);
        LanguageButton.Name = "LanguageButton";
        LanguageButton.Size = new Size(118, 27);
        LanguageButton.TabIndex = 2;
        LanguageButton.Text = "言語";
        LanguageButton.UseVisualStyleBackColor = true;
        LanguageButton.Click += LanguageButton_Click;
        // 
        // FlavorTextCaptionLabel
        // 
        FlavorTextCaptionLabel.AutoSize = true;
        FlavorTextCaptionLabel.Font = new Font("Meiryo UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 128);
        FlavorTextCaptionLabel.Location = new Point(13, 78);
        FlavorTextCaptionLabel.Name = "FlavorTextCaptionLabel";
        FlavorTextCaptionLabel.Size = new Size(103, 17);
        FlavorTextCaptionLabel.TabIndex = 4;
        FlavorTextCaptionLabel.Text = "フレーバーテキスト";
        // 
        // FlavorTextTextBox
        // 
        FlavorTextTextBox.Location = new Point(13, 98);
        FlavorTextTextBox.Multiline = true;
        FlavorTextTextBox.Name = "FlavorTextTextBox";
        FlavorTextTextBox.ReadOnly = true;
        FlavorTextTextBox.Size = new Size(364, 170);
        FlavorTextTextBox.TabIndex = 5;
        FlavorTextTextBox.Text = "ピカチュウ";
        // 
        // CloseButton
        // 
        CloseButton.Location = new Point(301, 274);
        CloseButton.Name = "CloseButton";
        CloseButton.Size = new Size(76, 35);
        CloseButton.TabIndex = 7;
        CloseButton.Text = "閉じる";
        CloseButton.UseVisualStyleBackColor = true;
        CloseButton.Click += CloseButton_Click;
        // 
        // PropertyButton
        // 
        PropertyButton.Location = new Point(219, 274);
        PropertyButton.Name = "PropertyButton";
        PropertyButton.Size = new Size(76, 35);
        PropertyButton.TabIndex = 6;
        PropertyButton.Text = "プロパティ";
        PropertyButton.UseVisualStyleBackColor = true;
        PropertyButton.Click += PropertyButton_Click;
        // 
        // AbilityFlavorTextInfoForm
        // 
        AutoScaleDimensions = new SizeF(9F, 17F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(399, 321);
        Controls.Add(PropertyButton);
        Controls.Add(CloseButton);
        Controls.Add(FlavorTextTextBox);
        Controls.Add(FlavorTextCaptionLabel);
        Controls.Add(LanguageButton);
        Controls.Add(LanguageTextBox);
        Controls.Add(VersionGroupButton);
        Controls.Add(VersionGroupTextBox);
        Font = new Font("Meiryo UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 128);
        FormBorderStyle = FormBorderStyle.FixedSingle;
        Margin = new Padding(4, 3, 4, 3);
        MaximizeBox = false;
        Name = "AbilityFlavorTextInfoForm";
        StartPosition = FormStartPosition.CenterParent;
        Text = "特性のフレーバーテキスト";
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private Button VersionGroupButton;
    private TextBox VersionGroupTextBox;
    private TextBox LanguageTextBox;
    private Button LanguageButton;
    private Label FlavorTextCaptionLabel;
    private TextBox FlavorTextTextBox;
    private Button CloseButton;
    private Button PropertyButton;
}