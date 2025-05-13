namespace Kos.PokeAPI.Forms;

partial class GrowthRateExperienceLevelInfoForm
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
        PropertyButton = new Button();
        CloseButton = new Button();
        ExperienceTextBox = new TextBox();
        LevelTextBox = new TextBox();
        LevelCaptionLabel = new Label();
        ExperienceCaptionLabel = new Label();
        SuspendLayout();
        // 
        // PropertyButton
        // 
        PropertyButton.Location = new Point(82, 73);
        PropertyButton.Margin = new Padding(5, 3, 5, 3);
        PropertyButton.Name = "PropertyButton";
        PropertyButton.Size = new Size(76, 35);
        PropertyButton.TabIndex = 4;
        PropertyButton.Text = "プロパティ";
        PropertyButton.UseVisualStyleBackColor = true;
        PropertyButton.Click += PropertyButton_Click;
        // 
        // CloseButton
        // 
        CloseButton.Location = new Point(168, 72);
        CloseButton.Margin = new Padding(5, 3, 5, 3);
        CloseButton.Name = "CloseButton";
        CloseButton.Size = new Size(76, 35);
        CloseButton.TabIndex = 5;
        CloseButton.Text = "閉じる";
        CloseButton.UseVisualStyleBackColor = true;
        CloseButton.Click += CloseButton_Click;
        // 
        // ExperienceTextBox
        // 
        ExperienceTextBox.Location = new Point(61, 42);
        ExperienceTextBox.Margin = new Padding(5, 3, 5, 3);
        ExperienceTextBox.Name = "ExperienceTextBox";
        ExperienceTextBox.ReadOnly = true;
        ExperienceTextBox.Size = new Size(183, 24);
        ExperienceTextBox.TabIndex = 3;
        ExperienceTextBox.Text = "99999999";
        // 
        // LevelTextBox
        // 
        LevelTextBox.Location = new Point(61, 12);
        LevelTextBox.Margin = new Padding(5, 3, 5, 3);
        LevelTextBox.Name = "LevelTextBox";
        LevelTextBox.ReadOnly = true;
        LevelTextBox.Size = new Size(183, 24);
        LevelTextBox.TabIndex = 1;
        LevelTextBox.Text = "100";
        // 
        // LevelCaptionLabel
        // 
        LevelCaptionLabel.AutoSize = true;
        LevelCaptionLabel.Font = new Font("Meiryo UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 128);
        LevelCaptionLabel.Location = new Point(14, 15);
        LevelCaptionLabel.Margin = new Padding(5, 0, 5, 0);
        LevelCaptionLabel.Name = "LevelCaptionLabel";
        LevelCaptionLabel.Size = new Size(40, 17);
        LevelCaptionLabel.TabIndex = 0;
        LevelCaptionLabel.Text = "レベル";
        // 
        // ExperienceCaptionLabel
        // 
        ExperienceCaptionLabel.AutoSize = true;
        ExperienceCaptionLabel.Font = new Font("Meiryo UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 128);
        ExperienceCaptionLabel.Location = new Point(7, 45);
        ExperienceCaptionLabel.Margin = new Padding(5, 0, 5, 0);
        ExperienceCaptionLabel.Name = "ExperienceCaptionLabel";
        ExperienceCaptionLabel.Size = new Size(47, 17);
        ExperienceCaptionLabel.TabIndex = 2;
        ExperienceCaptionLabel.Text = "経験値";
        // 
        // GrowthRateExperienceLevelInfoForm
        // 
        AutoScaleDimensions = new SizeF(9F, 17F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(258, 120);
        Controls.Add(ExperienceCaptionLabel);
        Controls.Add(PropertyButton);
        Controls.Add(CloseButton);
        Controls.Add(ExperienceTextBox);
        Controls.Add(LevelTextBox);
        Controls.Add(LevelCaptionLabel);
        Font = new Font("Meiryo UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 128);
        FormBorderStyle = FormBorderStyle.FixedSingle;
        Margin = new Padding(4, 3, 4, 3);
        MaximizeBox = false;
        Name = "GrowthRateExperienceLevelInfoForm";
        StartPosition = FormStartPosition.CenterParent;
        Text = "レベルごとの必要な経験値";
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private Button PropertyButton;
    private Button CloseButton;
    private TextBox ExperienceTextBox;
    private TextBox LevelTextBox;
    private Label LevelCaptionLabel;
    private Label ExperienceCaptionLabel;
}