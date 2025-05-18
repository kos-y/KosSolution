namespace Kos.PokeAPI.Forms;

partial class VersionGameIndexInfoForm
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
        GameIndexCaptionLabel = new Label();
        GameIndexTextBox = new TextBox();
        PropertyButton = new Button();
        CloseButton = new Button();
        SuspendLayout();
        // 
        // VersionButton
        // 
        VersionButton.Location = new Point(12, 9);
        VersionButton.Name = "VersionButton";
        VersionButton.Size = new Size(71, 28);
        VersionButton.TabIndex = 0;
        VersionButton.Text = "バージョン";
        VersionButton.UseVisualStyleBackColor = true;
        VersionButton.Click += VersionButton_Click;
        // 
        // VersionTextBox
        // 
        VersionTextBox.Location = new Point(91, 12);
        VersionTextBox.Margin = new Padding(5, 3, 5, 3);
        VersionTextBox.Name = "VersionTextBox";
        VersionTextBox.ReadOnly = true;
        VersionTextBox.Size = new Size(172, 24);
        VersionTextBox.TabIndex = 1;
        // 
        // GameIndexCaptionLabel
        // 
        GameIndexCaptionLabel.AutoSize = true;
        GameIndexCaptionLabel.Location = new Point(13, 45);
        GameIndexCaptionLabel.Margin = new Padding(6, 0, 6, 0);
        GameIndexCaptionLabel.Name = "GameIndexCaptionLabel";
        GameIndexCaptionLabel.Size = new Size(70, 17);
        GameIndexCaptionLabel.TabIndex = 2;
        GameIndexCaptionLabel.Text = "インデックス";
        GameIndexCaptionLabel.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // GameIndexTextBox
        // 
        GameIndexTextBox.Location = new Point(91, 42);
        GameIndexTextBox.Margin = new Padding(5, 3, 5, 3);
        GameIndexTextBox.Name = "GameIndexTextBox";
        GameIndexTextBox.ReadOnly = true;
        GameIndexTextBox.Size = new Size(172, 24);
        GameIndexTextBox.TabIndex = 3;
        // 
        // PropertyButton
        // 
        PropertyButton.Location = new Point(103, 72);
        PropertyButton.Margin = new Padding(4, 3, 4, 3);
        PropertyButton.Name = "PropertyButton";
        PropertyButton.Size = new Size(76, 35);
        PropertyButton.TabIndex = 4;
        PropertyButton.Text = "プロパティ";
        PropertyButton.UseVisualStyleBackColor = true;
        PropertyButton.Click += PropertyButton_Click;
        // 
        // CloseButton
        // 
        CloseButton.Location = new Point(187, 72);
        CloseButton.Margin = new Padding(4, 3, 4, 3);
        CloseButton.Name = "CloseButton";
        CloseButton.Size = new Size(76, 35);
        CloseButton.TabIndex = 5;
        CloseButton.Text = "閉じる";
        CloseButton.UseVisualStyleBackColor = true;
        CloseButton.Click += CloseButton_Click;
        // 
        // VersionGameIndexInfoForm
        // 
        AutoScaleDimensions = new SizeF(9F, 17F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(278, 120);
        Controls.Add(PropertyButton);
        Controls.Add(CloseButton);
        Controls.Add(GameIndexTextBox);
        Controls.Add(GameIndexCaptionLabel);
        Controls.Add(VersionButton);
        Controls.Add(VersionTextBox);
        Font = new Font("Meiryo UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 128);
        FormBorderStyle = FormBorderStyle.FixedSingle;
        Margin = new Padding(4, 3, 4, 3);
        MaximizeBox = false;
        Name = "VersionGameIndexInfoForm";
        StartPosition = FormStartPosition.CenterParent;
        Text = "ゲーム内インデックス";
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private Button VersionButton;
    private TextBox VersionTextBox;
    private Label GameIndexCaptionLabel;
    private TextBox GameIndexTextBox;
    private Button PropertyButton;
    private Button CloseButton;
}