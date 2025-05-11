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
        LanguageButton = new Button();
        LanguageTextBox = new TextBox();
        VersionGroupTextBox = new TextBox();
        VersionGroupButton = new Button();
        CloseButton = new Button();
        PropertyButton = new Button();
        SuspendLayout();
        // 
        // FlavorTextTextBox
        // 
        FlavorTextTextBox.Location = new Point(131, 80);
        FlavorTextTextBox.Margin = new Padding(4, 3, 4, 3);
        FlavorTextTextBox.Name = "FlavorTextTextBox";
        FlavorTextTextBox.ReadOnly = true;
        FlavorTextTextBox.Size = new Size(755, 24);
        FlavorTextTextBox.TabIndex = 5;
        FlavorTextTextBox.Text = "フレーバーテキスト";
        // 
        // FlavorTextCaptionLabel
        // 
        FlavorTextCaptionLabel.AutoSize = true;
        FlavorTextCaptionLabel.Font = new Font("Meiryo UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 128);
        FlavorTextCaptionLabel.Location = new Point(22, 83);
        FlavorTextCaptionLabel.Margin = new Padding(4, 0, 4, 0);
        FlavorTextCaptionLabel.Name = "FlavorTextCaptionLabel";
        FlavorTextCaptionLabel.Size = new Size(103, 17);
        FlavorTextCaptionLabel.TabIndex = 4;
        FlavorTextCaptionLabel.Text = "フレーバーテキスト";
        // 
        // LanguageButton
        // 
        LanguageButton.Location = new Point(12, 12);
        LanguageButton.Name = "LanguageButton";
        LanguageButton.Size = new Size(113, 30);
        LanguageButton.TabIndex = 0;
        LanguageButton.Text = "言語";
        LanguageButton.UseVisualStyleBackColor = true;
        LanguageButton.Click += LanguageButton_Click;
        // 
        // LanguageTextBox
        // 
        LanguageTextBox.Location = new Point(131, 16);
        LanguageTextBox.Name = "LanguageTextBox";
        LanguageTextBox.ReadOnly = true;
        LanguageTextBox.Size = new Size(247, 24);
        LanguageTextBox.TabIndex = 1;
        LanguageTextBox.Text = "ja-Hrkt";
        // 
        // VersionGroupTextBox
        // 
        VersionGroupTextBox.Location = new Point(131, 50);
        VersionGroupTextBox.Name = "VersionGroupTextBox";
        VersionGroupTextBox.ReadOnly = true;
        VersionGroupTextBox.Size = new Size(247, 24);
        VersionGroupTextBox.TabIndex = 3;
        VersionGroupTextBox.Text = "ja-Hrkt";
        // 
        // VersionGroupButton
        // 
        VersionGroupButton.Location = new Point(12, 48);
        VersionGroupButton.Name = "VersionGroupButton";
        VersionGroupButton.Size = new Size(113, 26);
        VersionGroupButton.TabIndex = 2;
        VersionGroupButton.Text = "バージョングループ";
        VersionGroupButton.UseVisualStyleBackColor = true;
        VersionGroupButton.Click += VersionGroupButton_Click;
        // 
        // CloseButton
        // 
        CloseButton.Location = new Point(813, 110);
        CloseButton.Name = "CloseButton";
        CloseButton.Size = new Size(73, 35);
        CloseButton.TabIndex = 7;
        CloseButton.Text = "閉じる";
        CloseButton.UseVisualStyleBackColor = true;
        CloseButton.Click += CloseButton_Click;
        // 
        // PropertyButton
        // 
        PropertyButton.Location = new Point(734, 110);
        PropertyButton.Name = "PropertyButton";
        PropertyButton.Size = new Size(73, 35);
        PropertyButton.TabIndex = 6;
        PropertyButton.Text = "プロパティ";
        PropertyButton.UseVisualStyleBackColor = true;
        PropertyButton.Click += PropertyButton_Click;
        // 
        // VersionGroupFlavorTextInfoForm
        // 
        AutoScaleDimensions = new SizeF(9F, 17F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(899, 157);
        Controls.Add(PropertyButton);
        Controls.Add(CloseButton);
        Controls.Add(VersionGroupButton);
        Controls.Add(VersionGroupTextBox);
        Controls.Add(LanguageButton);
        Controls.Add(LanguageTextBox);
        Controls.Add(FlavorTextTextBox);
        Controls.Add(FlavorTextCaptionLabel);
        Font = new Font("Meiryo UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 128);
        FormBorderStyle = FormBorderStyle.FixedSingle;
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
    private Button LanguageButton;
    private TextBox LanguageTextBox;
    private TextBox VersionGroupTextBox;
    private Button VersionGroupButton;
    private Button CloseButton;
    private Button PropertyButton;
}