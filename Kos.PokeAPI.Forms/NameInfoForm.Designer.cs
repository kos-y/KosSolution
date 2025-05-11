namespace Kos.PokeAPI.Forms;

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
        NameCaptionLabel.Font = new Font("Meiryo UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 128);
        NameCaptionLabel.Location = new Point(31, 15);
        NameCaptionLabel.Name = "NameCaptionLabel";
        NameCaptionLabel.Size = new Size(34, 17);
        NameCaptionLabel.TabIndex = 0;
        NameCaptionLabel.Text = "名前";
        // 
        // NameTextBox
        // 
        NameTextBox.Location = new Point(71, 12);
        NameTextBox.Name = "NameTextBox";
        NameTextBox.ReadOnly = true;
        NameTextBox.Size = new Size(252, 24);
        NameTextBox.TabIndex = 1;
        NameTextBox.Text = "ピカチュウ";
        // 
        // LanguageTextBox
        // 
        LanguageTextBox.Location = new Point(71, 42);
        LanguageTextBox.Name = "LanguageTextBox";
        LanguageTextBox.ReadOnly = true;
        LanguageTextBox.Size = new Size(252, 24);
        LanguageTextBox.TabIndex = 3;
        LanguageTextBox.Text = "ja-Hrkt";
        // 
        // LanguageButton
        // 
        LanguageButton.Location = new Point(12, 42);
        LanguageButton.Name = "LanguageButton";
        LanguageButton.Size = new Size(53, 24);
        LanguageButton.TabIndex = 2;
        LanguageButton.Text = "言語";
        LanguageButton.UseVisualStyleBackColor = true;
        LanguageButton.Click += LanguageButton_Click;
        // 
        // CloseButton
        // 
        CloseButton.Location = new Point(247, 72);
        CloseButton.Name = "CloseButton";
        CloseButton.Size = new Size(76, 35);
        CloseButton.TabIndex = 5;
        CloseButton.Text = "閉じる";
        CloseButton.UseVisualStyleBackColor = true;
        CloseButton.Click += CloseButton_Click;
        // 
        // PropertyButton
        // 
        PropertyButton.Location = new Point(165, 74);
        PropertyButton.Name = "PropertyButton";
        PropertyButton.Size = new Size(76, 35);
        PropertyButton.TabIndex = 4;
        PropertyButton.Text = "プロパティ";
        PropertyButton.UseVisualStyleBackColor = true;
        PropertyButton.Click += PropertyButton_Click;
        // 
        // NameInfoForm
        // 
        AutoScaleDimensions = new SizeF(9F, 17F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(339, 121);
        Controls.Add(PropertyButton);
        Controls.Add(CloseButton);
        Controls.Add(LanguageButton);
        Controls.Add(LanguageTextBox);
        Controls.Add(NameTextBox);
        Controls.Add(NameCaptionLabel);
        Font = new Font("Meiryo UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 128);
        FormBorderStyle = FormBorderStyle.FixedSingle;
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