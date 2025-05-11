namespace Kos.PokeAPI.Forms;

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
        CloseButton.Location = new Point(396, 72);
        CloseButton.Margin = new Padding(4, 3, 4, 3);
        CloseButton.Name = "CloseButton";
        CloseButton.Size = new Size(76, 35);
        CloseButton.TabIndex = 5;
        CloseButton.Text = "閉じる";
        CloseButton.UseVisualStyleBackColor = true;
        CloseButton.Click += CloseButton_Click;
        // 
        // LanguageButton
        // 
        LanguageButton.Location = new Point(17, 40);
        LanguageButton.Margin = new Padding(4, 3, 4, 3);
        LanguageButton.Name = "LanguageButton";
        LanguageButton.Size = new Size(44, 26);
        LanguageButton.TabIndex = 2;
        LanguageButton.Text = "言語";
        LanguageButton.UseVisualStyleBackColor = true;
        LanguageButton.Click += LanguageDetailButton_Click;
        // 
        // LanguageTextBox
        // 
        LanguageTextBox.Location = new Point(68, 42);
        LanguageTextBox.Margin = new Padding(4, 3, 4, 3);
        LanguageTextBox.Name = "LanguageTextBox";
        LanguageTextBox.ReadOnly = true;
        LanguageTextBox.Size = new Size(399, 24);
        LanguageTextBox.TabIndex = 3;
        LanguageTextBox.Text = "ja-Hrkt";
        // 
        // DescriptionTextBox
        // 
        DescriptionTextBox.Location = new Point(68, 12);
        DescriptionTextBox.Margin = new Padding(4, 3, 4, 3);
        DescriptionTextBox.Name = "DescriptionTextBox";
        DescriptionTextBox.ReadOnly = true;
        DescriptionTextBox.Size = new Size(399, 24);
        DescriptionTextBox.TabIndex = 1;
        DescriptionTextBox.Text = "ピカチュウ";
        // 
        // DescriptionCaptionLabel
        // 
        DescriptionCaptionLabel.AutoSize = true;
        DescriptionCaptionLabel.Font = new Font("Meiryo UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 128);
        DescriptionCaptionLabel.Location = new Point(27, 15);
        DescriptionCaptionLabel.Margin = new Padding(4, 0, 4, 0);
        DescriptionCaptionLabel.Name = "DescriptionCaptionLabel";
        DescriptionCaptionLabel.Size = new Size(34, 17);
        DescriptionCaptionLabel.TabIndex = 0;
        DescriptionCaptionLabel.Text = "説明";
        // 
        // プロパティボタン
        // 
        プロパティボタン.Location = new Point(312, 72);
        プロパティボタン.Margin = new Padding(4, 3, 4, 3);
        プロパティボタン.Name = "プロパティボタン";
        プロパティボタン.Size = new Size(76, 35);
        プロパティボタン.TabIndex = 4;
        プロパティボタン.Text = "プロパティ";
        プロパティボタン.UseVisualStyleBackColor = true;
        プロパティボタン.Click += PropertyButton_Click;
        // 
        // DescriptionInfoForm
        // 
        AutoScaleDimensions = new SizeF(9F, 17F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(482, 118);
        Controls.Add(プロパティボタン);
        Controls.Add(CloseButton);
        Controls.Add(LanguageButton);
        Controls.Add(LanguageTextBox);
        Controls.Add(DescriptionTextBox);
        Controls.Add(DescriptionCaptionLabel);
        Font = new Font("Meiryo UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 128);
        FormBorderStyle = FormBorderStyle.FixedSingle;
        Margin = new Padding(4, 3, 4, 3);
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