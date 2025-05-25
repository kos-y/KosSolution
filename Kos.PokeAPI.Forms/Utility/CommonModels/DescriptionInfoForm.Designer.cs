namespace Kos.PokeAPI.Forms.Utility.CommonModels;

partial class DescriptionInfoForm
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
        DescriptionTextBox = new TextBox();
        DescriptionCaptionLabel = new Label();
        プロパティボタン = new Button();
        SuspendLayout();
        // 
        // CloseButton
        // 
        CloseButton.Location = new Point(348, 70);
        CloseButton.Name = "CloseButton";
        CloseButton.Size = new Size(59, 31);
        CloseButton.TabIndex = 5;
        CloseButton.Text = "閉じる";
        CloseButton.UseVisualStyleBackColor = true;
        CloseButton.Click += CloseButton_Click;
        // 
        // LanguageButton
        // 
        LanguageButton.Location = new Point(12, 38);
        LanguageButton.Name = "LanguageButton";
        LanguageButton.Size = new Size(39, 23);
        LanguageButton.TabIndex = 2;
        LanguageButton.Text = "言語";
        LanguageButton.UseVisualStyleBackColor = true;
        LanguageButton.Click += LanguageDetailButton_Click;
        // 
        // LanguageTextBox
        // 
        LanguageTextBox.Location = new Point(57, 38);
        LanguageTextBox.Name = "LanguageTextBox";
        LanguageTextBox.ReadOnly = true;
        LanguageTextBox.Size = new Size(350, 23);
        LanguageTextBox.TabIndex = 3;
        LanguageTextBox.Text = "ja-Hrkt";
        // 
        // DescriptionTextBox
        // 
        DescriptionTextBox.Location = new Point(57, 10);
        DescriptionTextBox.Name = "DescriptionTextBox";
        DescriptionTextBox.ReadOnly = true;
        DescriptionTextBox.Size = new Size(350, 23);
        DescriptionTextBox.TabIndex = 1;
        DescriptionTextBox.Text = "ピカチュウ";
        // 
        // DescriptionCaptionLabel
        // 
        DescriptionCaptionLabel.AutoSize = true;
        DescriptionCaptionLabel.Location = new Point(20, 13);
        DescriptionCaptionLabel.Name = "DescriptionCaptionLabel";
        DescriptionCaptionLabel.Size = new Size(31, 15);
        DescriptionCaptionLabel.TabIndex = 0;
        DescriptionCaptionLabel.Text = "説明";
        // 
        // プロパティボタン
        // 
        プロパティボタン.Location = new Point(283, 70);
        プロパティボタン.Name = "プロパティボタン";
        プロパティボタン.Size = new Size(59, 31);
        プロパティボタン.TabIndex = 4;
        プロパティボタン.Text = "プロパティ";
        プロパティボタン.UseVisualStyleBackColor = true;
        プロパティボタン.Click += PropertyButton_Click;
        // 
        // DescriptionInfoForm
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(420, 112);
        Controls.Add(プロパティボタン);
        Controls.Add(CloseButton);
        Controls.Add(LanguageButton);
        Controls.Add(LanguageTextBox);
        Controls.Add(DescriptionTextBox);
        Controls.Add(DescriptionCaptionLabel);
        FormBorderStyle = FormBorderStyle.FixedSingle;
        MaximizeBox = false;
        Name = "DescriptionInfoForm";
        StartPosition = FormStartPosition.CenterParent;
        Text = "説明";
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private Button CloseButton;
    private Button LanguageButton;
    private TextBox LanguageTextBox;
    private TextBox DescriptionTextBox;
    private Label DescriptionCaptionLabel;
    private Button プロパティボタン;
}