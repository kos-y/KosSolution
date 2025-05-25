namespace Kos.PokeAPI.Forms.Utility.CommonModels;

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
        FlavorTextTextBox.Location = new Point(119, 73);
        FlavorTextTextBox.Name = "FlavorTextTextBox";
        FlavorTextTextBox.ReadOnly = true;
        FlavorTextTextBox.Size = new Size(588, 23);
        FlavorTextTextBox.TabIndex = 5;
        FlavorTextTextBox.Text = "フレーバーテキスト";
        // 
        // FlavorTextCaptionLabel
        // 
        FlavorTextCaptionLabel.AutoSize = true;
        FlavorTextCaptionLabel.Location = new Point(28, 76);
        FlavorTextCaptionLabel.Name = "FlavorTextCaptionLabel";
        FlavorTextCaptionLabel.Size = new Size(85, 15);
        FlavorTextCaptionLabel.TabIndex = 4;
        FlavorTextCaptionLabel.Text = "フレーバーテキスト";
        // 
        // LanguageButton
        // 
        LanguageButton.Location = new Point(11, 41);
        LanguageButton.Margin = new Padding(2, 3, 2, 3);
        LanguageButton.Name = "LanguageButton";
        LanguageButton.Size = new Size(102, 26);
        LanguageButton.TabIndex = 2;
        LanguageButton.Text = "言語";
        LanguageButton.UseVisualStyleBackColor = true;
        LanguageButton.Click += LanguageButton_Click;
        // 
        // LanguageTextBox
        // 
        LanguageTextBox.Location = new Point(117, 44);
        LanguageTextBox.Margin = new Padding(2, 3, 2, 3);
        LanguageTextBox.Name = "LanguageTextBox";
        LanguageTextBox.ReadOnly = true;
        LanguageTextBox.Size = new Size(193, 23);
        LanguageTextBox.TabIndex = 3;
        LanguageTextBox.Text = "ja-Hrkt";
        // 
        // VersionGroupTextBox
        // 
        VersionGroupTextBox.Location = new Point(117, 15);
        VersionGroupTextBox.Margin = new Padding(2, 3, 2, 3);
        VersionGroupTextBox.Name = "VersionGroupTextBox";
        VersionGroupTextBox.ReadOnly = true;
        VersionGroupTextBox.Size = new Size(193, 23);
        VersionGroupTextBox.TabIndex = 1;
        VersionGroupTextBox.Text = "ja-Hrkt";
        // 
        // VersionGroupButton
        // 
        VersionGroupButton.Location = new Point(11, 12);
        VersionGroupButton.Margin = new Padding(2, 3, 2, 3);
        VersionGroupButton.Name = "VersionGroupButton";
        VersionGroupButton.Size = new Size(102, 26);
        VersionGroupButton.TabIndex = 0;
        VersionGroupButton.Text = "バージョングループ";
        VersionGroupButton.UseVisualStyleBackColor = true;
        VersionGroupButton.Click += VersionGroupButton_Click;
        // 
        // CloseButton
        // 
        CloseButton.Location = new Point(648, 102);
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
        PropertyButton.Location = new Point(585, 102);
        PropertyButton.Margin = new Padding(2, 3, 2, 3);
        PropertyButton.Name = "PropertyButton";
        PropertyButton.Size = new Size(59, 31);
        PropertyButton.TabIndex = 6;
        PropertyButton.Text = "プロパティ";
        PropertyButton.UseVisualStyleBackColor = true;
        PropertyButton.Click += PropertyButton_Click;
        // 
        // VersionGroupFlavorTextInfoForm
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(722, 142);
        Controls.Add(PropertyButton);
        Controls.Add(CloseButton);
        Controls.Add(VersionGroupButton);
        Controls.Add(VersionGroupTextBox);
        Controls.Add(LanguageButton);
        Controls.Add(LanguageTextBox);
        Controls.Add(FlavorTextTextBox);
        Controls.Add(FlavorTextCaptionLabel);
        FormBorderStyle = FormBorderStyle.FixedSingle;
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