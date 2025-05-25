namespace Kos.PokeAPI.Forms.Utility.CommonModels;

partial class NameInfoForm
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
        NameCaptionLabel = new Label();
        NameTextBox = new TextBox();
        LanguageTextBox = new TextBox();
        LanguageButton = new Button();
        CloseButton = new Button();
        PropertyButton = new Button();
        SuspendLayout();
        // 
        // NameCaptionLabel
        // 
        NameCaptionLabel.AutoSize = true;
        NameCaptionLabel.Location = new Point(19, 14);
        NameCaptionLabel.Margin = new Padding(2, 0, 2, 0);
        NameCaptionLabel.Name = "NameCaptionLabel";
        NameCaptionLabel.Size = new Size(31, 15);
        NameCaptionLabel.TabIndex = 0;
        NameCaptionLabel.Text = "名前";
        // 
        // NameTextBox
        // 
        NameTextBox.Location = new Point(55, 11);
        NameTextBox.Margin = new Padding(2, 3, 2, 3);
        NameTextBox.Name = "NameTextBox";
        NameTextBox.ReadOnly = true;
        NameTextBox.Size = new Size(197, 23);
        NameTextBox.TabIndex = 1;
        NameTextBox.Text = "ピカチュウ";
        // 
        // LanguageTextBox
        // 
        LanguageTextBox.Location = new Point(55, 37);
        LanguageTextBox.Margin = new Padding(2, 3, 2, 3);
        LanguageTextBox.Name = "LanguageTextBox";
        LanguageTextBox.ReadOnly = true;
        LanguageTextBox.Size = new Size(197, 23);
        LanguageTextBox.TabIndex = 3;
        LanguageTextBox.Text = "ja-Hrkt";
        // 
        // LanguageButton
        // 
        LanguageButton.Location = new Point(9, 37);
        LanguageButton.Margin = new Padding(2, 3, 2, 3);
        LanguageButton.Name = "LanguageButton";
        LanguageButton.Size = new Size(41, 21);
        LanguageButton.TabIndex = 2;
        LanguageButton.Text = "言語";
        LanguageButton.UseVisualStyleBackColor = true;
        LanguageButton.Click += LanguageButton_Click;
        // 
        // CloseButton
        // 
        CloseButton.Location = new Point(192, 64);
        CloseButton.Margin = new Padding(2, 3, 2, 3);
        CloseButton.Name = "CloseButton";
        CloseButton.Size = new Size(59, 31);
        CloseButton.TabIndex = 5;
        CloseButton.Text = "閉じる";
        CloseButton.UseVisualStyleBackColor = true;
        CloseButton.Click += CloseButton_Click;
        // 
        // PropertyButton
        // 
        PropertyButton.Location = new Point(128, 65);
        PropertyButton.Margin = new Padding(2, 3, 2, 3);
        PropertyButton.Name = "PropertyButton";
        PropertyButton.Size = new Size(59, 31);
        PropertyButton.TabIndex = 4;
        PropertyButton.Text = "プロパティ";
        PropertyButton.UseVisualStyleBackColor = true;
        PropertyButton.Click += PropertyButton_Click;
        // 
        // NameInfoForm
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(264, 107);
        Controls.Add(PropertyButton);
        Controls.Add(CloseButton);
        Controls.Add(LanguageButton);
        Controls.Add(LanguageTextBox);
        Controls.Add(NameTextBox);
        Controls.Add(NameCaptionLabel);
        FormBorderStyle = FormBorderStyle.FixedSingle;
        Margin = new Padding(2, 3, 2, 3);
        MaximizeBox = false;
        Name = "NameInfoForm";
        StartPosition = FormStartPosition.CenterParent;
        Text = "名前";
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private Label NameCaptionLabel;
    private TextBox NameTextBox;
    private TextBox LanguageTextBox;
    private Button LanguageButton;
    private Button CloseButton;
    private Button PropertyButton;
}