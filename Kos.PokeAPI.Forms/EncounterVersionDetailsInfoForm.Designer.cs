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
        VersionButton = new Button();
        VersionTextBox = new TextBox();
        RateTextBox = new TextBox();
        RateCaptionLabel = new Label();
        CloseButton = new Button();
        PropertyButton = new Button();
        SuspendLayout();
        // 
        // VersionButton
        // 
        VersionButton.Location = new Point(14, 12);
        VersionButton.Margin = new Padding(5, 3, 5, 3);
        VersionButton.Name = "VersionButton";
        VersionButton.Size = new Size(72, 29);
        VersionButton.TabIndex = 0;
        VersionButton.Text = "バージョン";
        VersionButton.UseVisualStyleBackColor = true;
        VersionButton.Click += VersionButton_Click;
        // 
        // VersionTextBox
        // 
        VersionTextBox.Location = new Point(95, 15);
        VersionTextBox.Margin = new Padding(4, 3, 4, 3);
        VersionTextBox.Name = "VersionTextBox";
        VersionTextBox.ReadOnly = true;
        VersionTextBox.Size = new Size(168, 24);
        VersionTextBox.TabIndex = 1;
        // 
        // RateTextBox
        // 
        RateTextBox.Location = new Point(86, 45);
        RateTextBox.Margin = new Padding(4, 3, 4, 3);
        RateTextBox.Name = "RateTextBox";
        RateTextBox.ReadOnly = true;
        RateTextBox.Size = new Size(177, 24);
        RateTextBox.TabIndex = 3;
        // 
        // RateCaptionLabel
        // 
        RateCaptionLabel.AutoSize = true;
        RateCaptionLabel.Location = new Point(39, 48);
        RateCaptionLabel.Margin = new Padding(5, 0, 5, 0);
        RateCaptionLabel.Name = "RateCaptionLabel";
        RateCaptionLabel.Size = new Size(47, 17);
        RateCaptionLabel.TabIndex = 2;
        RateCaptionLabel.Text = "遭遇率";
        RateCaptionLabel.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // CloseButton
        // 
        CloseButton.Location = new Point(187, 75);
        CloseButton.Name = "CloseButton";
        CloseButton.Size = new Size(76, 35);
        CloseButton.TabIndex = 5;
        CloseButton.Text = "閉じる";
        CloseButton.UseVisualStyleBackColor = true;
        CloseButton.Click += CloseButton_Click;
        // 
        // PropertyButton
        // 
        PropertyButton.Location = new Point(105, 75);
        PropertyButton.Name = "PropertyButton";
        PropertyButton.Size = new Size(76, 35);
        PropertyButton.TabIndex = 4;
        PropertyButton.Text = "プロパティ";
        PropertyButton.UseVisualStyleBackColor = true;
        PropertyButton.Click += PropertyButton_Click;
        // 
        // EncounterVersionDetailsInfoForm
        // 
        AutoScaleDimensions = new SizeF(9F, 17F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(275, 120);
        Controls.Add(PropertyButton);
        Controls.Add(CloseButton);
        Controls.Add(RateCaptionLabel);
        Controls.Add(RateTextBox);
        Controls.Add(VersionButton);
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

    private Button VersionButton;
    private TextBox VersionTextBox;
    private TextBox RateTextBox;
    private Label RateCaptionLabel;
    private Button CloseButton;
    private Button PropertyButton;
}