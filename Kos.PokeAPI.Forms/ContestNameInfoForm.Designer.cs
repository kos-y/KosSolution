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
        LanguageButton = new Button();
        LanguageTextBox = new TextBox();
        ContestNameTextBox = new TextBox();
        ContestNameCaptionLabel = new Label();
        ColorTextBox = new TextBox();
        ColorCaptionLabel = new Label();
        PropertyButton = new Button();
        SuspendLayout();
        // 
        // CloseButton
        // 
        CloseButton.Location = new Point(262, 96);
        CloseButton.Name = "CloseButton";
        CloseButton.Size = new Size(76, 35);
        CloseButton.TabIndex = 7;
        CloseButton.Text = "閉じる";
        CloseButton.UseVisualStyleBackColor = true;
        CloseButton.Click += CloseButton_Click;
        // 
        // LanguageButton
        // 
        LanguageButton.Location = new Point(56, 66);
        LanguageButton.Name = "LanguageButton";
        LanguageButton.Size = new Size(53, 27);
        LanguageButton.TabIndex = 4;
        LanguageButton.Text = "言語";
        LanguageButton.UseVisualStyleBackColor = true;
        LanguageButton.Click += LanguageDetailButton_Click;
        // 
        // LanguageTextBox
        // 
        LanguageTextBox.Location = new Point(115, 66);
        LanguageTextBox.Name = "LanguageTextBox";
        LanguageTextBox.ReadOnly = true;
        LanguageTextBox.Size = new Size(223, 24);
        LanguageTextBox.TabIndex = 5;
        LanguageTextBox.Text = "ja-Hrkt";
        // 
        // ContestNameTextBox
        // 
        ContestNameTextBox.Location = new Point(115, 6);
        ContestNameTextBox.Name = "ContestNameTextBox";
        ContestNameTextBox.ReadOnly = true;
        ContestNameTextBox.Size = new Size(223, 24);
        ContestNameTextBox.TabIndex = 1;
        ContestNameTextBox.Text = "ピカチュウ";
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
        ColorTextBox.Location = new Point(115, 36);
        ColorTextBox.Name = "ColorTextBox";
        ColorTextBox.ReadOnly = true;
        ColorTextBox.Size = new Size(223, 24);
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
        // PropertyButton
        // 
        PropertyButton.Location = new Point(180, 96);
        PropertyButton.Name = "PropertyButton";
        PropertyButton.Size = new Size(76, 35);
        PropertyButton.TabIndex = 6;
        PropertyButton.Text = "プロパティ";
        PropertyButton.UseVisualStyleBackColor = true;
        PropertyButton.Click += PropertyButton_Click;
        // 
        // ContestNameInfoForm
        // 
        AutoScaleDimensions = new SizeF(9F, 17F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(358, 143);
        Controls.Add(PropertyButton);
        Controls.Add(ColorTextBox);
        Controls.Add(ColorCaptionLabel);
        Controls.Add(CloseButton);
        Controls.Add(LanguageButton);
        Controls.Add(LanguageTextBox);
        Controls.Add(ContestNameTextBox);
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
    private Button LanguageButton;
    private TextBox LanguageTextBox;
    private TextBox ContestNameTextBox;
    private Label ContestNameCaptionLabel;
    private TextBox ColorTextBox;
    private Label ColorCaptionLabel;
    private Button PropertyButton;
}