namespace Kos.PokeAPI.Forms;

partial class EncounterVersionDetailsInfoForm
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
        VersionDetailButton = new Button();
        VersionCaptionLabel = new Label();
        VersionTextBox = new TextBox();
        RateTextBox = new TextBox();
        RateCaptionLabel = new Label();
        CloseButton = new Button();
        SuspendLayout();
        // 
        // VersionDetailButton
        // 
        VersionDetailButton.Location = new Point(299, 4);
        VersionDetailButton.Margin = new Padding(5, 3, 5, 3);
        VersionDetailButton.Name = "VersionDetailButton";
        VersionDetailButton.Size = new Size(42, 29);
        VersionDetailButton.TabIndex = 2;
        VersionDetailButton.Text = "詳細";
        VersionDetailButton.UseVisualStyleBackColor = true;
        VersionDetailButton.Click += VersionDetailButton_Click;
        // 
        // VersionCaptionLabel
        // 
        VersionCaptionLabel.AutoSize = true;
        VersionCaptionLabel.Location = new Point(17, 10);
        VersionCaptionLabel.Margin = new Padding(5, 0, 5, 0);
        VersionCaptionLabel.Name = "VersionCaptionLabel";
        VersionCaptionLabel.Size = new Size(60, 17);
        VersionCaptionLabel.TabIndex = 0;
        VersionCaptionLabel.Text = "バージョン";
        VersionCaptionLabel.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // VersionTextBox
        // 
        VersionTextBox.Location = new Point(86, 7);
        VersionTextBox.Margin = new Padding(4, 3, 4, 3);
        VersionTextBox.Name = "VersionTextBox";
        VersionTextBox.ReadOnly = true;
        VersionTextBox.Size = new Size(204, 24);
        VersionTextBox.TabIndex = 1;
        // 
        // RateTextBox
        // 
        RateTextBox.Location = new Point(86, 37);
        RateTextBox.Margin = new Padding(4, 3, 4, 3);
        RateTextBox.Name = "RateTextBox";
        RateTextBox.ReadOnly = true;
        RateTextBox.Size = new Size(255, 24);
        RateTextBox.TabIndex = 4;
        // 
        // RateCaptionLabel
        // 
        RateCaptionLabel.AutoSize = true;
        RateCaptionLabel.Location = new Point(30, 40);
        RateCaptionLabel.Margin = new Padding(5, 0, 5, 0);
        RateCaptionLabel.Name = "RateCaptionLabel";
        RateCaptionLabel.Size = new Size(47, 17);
        RateCaptionLabel.TabIndex = 3;
        RateCaptionLabel.Text = "遭遇率";
        RateCaptionLabel.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // CloseButton
        // 
        CloseButton.Location = new Point(278, 67);
        CloseButton.Name = "CloseButton";
        CloseButton.Size = new Size(63, 35);
        CloseButton.TabIndex = 5;
        CloseButton.Text = "閉じる";
        CloseButton.UseVisualStyleBackColor = true;
        CloseButton.Click += CloseButton_Click;
        // 
        // EncounterVersionDetailsInfoForm
        // 
        AutoScaleDimensions = new SizeF(9F, 17F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(352, 109);
        Controls.Add(CloseButton);
        Controls.Add(RateCaptionLabel);
        Controls.Add(RateTextBox);
        Controls.Add(VersionDetailButton);
        Controls.Add(VersionCaptionLabel);
        Controls.Add(VersionTextBox);
        Font = new Font("Meiryo UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 128);
        FormBorderStyle = FormBorderStyle.FixedSingle;
        Margin = new Padding(4, 3, 4, 3);
        MaximizeBox = false;
        Name = "EncounterVersionDetailsInfoForm";
        StartPosition = FormStartPosition.CenterParent;
        Text = "バージョンごとの遭遇情報";
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private Button VersionDetailButton;
    private Label VersionCaptionLabel;
    private TextBox VersionTextBox;
    private TextBox RateTextBox;
    private Label RateCaptionLabel;
    private Button CloseButton;
}