namespace Kos.PokeAPI.Forms;

partial class ContestComboSetsInfoForm
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
        NormalDetailButton = new Button();
        NormalCaptionLabel = new Label();
        SuperCaptionLabel = new Label();
        SuperDetailButton = new Button();
        CloseButton = new Button();
        SuspendLayout();
        // 
        // NormalDetailButton
        // 
        NormalDetailButton.Location = new Point(142, 10);
        NormalDetailButton.Name = "NormalDetailButton";
        NormalDetailButton.Size = new Size(53, 27);
        NormalDetailButton.TabIndex = 1;
        NormalDetailButton.Text = "詳細";
        NormalDetailButton.UseVisualStyleBackColor = true;
        NormalDetailButton.Click += NormalDetailButton_Click;
        // 
        // NormalCaptionLabel
        // 
        NormalCaptionLabel.AutoSize = true;
        NormalCaptionLabel.Font = new Font("Meiryo UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 128);
        NormalCaptionLabel.Location = new Point(12, 15);
        NormalCaptionLabel.Name = "NormalCaptionLabel";
        NormalCaptionLabel.Size = new Size(100, 17);
        NormalCaptionLabel.TabIndex = 0;
        NormalCaptionLabel.Text = "ポケモンコンテスト";
        // 
        // SuperCaptionLabel
        // 
        SuperCaptionLabel.AutoSize = true;
        SuperCaptionLabel.Font = new Font("Meiryo UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 128);
        SuperCaptionLabel.Location = new Point(8, 48);
        SuperCaptionLabel.Name = "SuperCaptionLabel";
        SuperCaptionLabel.Size = new Size(104, 17);
        SuperCaptionLabel.TabIndex = 2;
        SuperCaptionLabel.Text = "スーパーコンテスト";
        // 
        // SuperDetailButton
        // 
        SuperDetailButton.Location = new Point(142, 43);
        SuperDetailButton.Name = "SuperDetailButton";
        SuperDetailButton.Size = new Size(53, 27);
        SuperDetailButton.TabIndex = 3;
        SuperDetailButton.Text = "詳細";
        SuperDetailButton.UseVisualStyleBackColor = true;
        SuperDetailButton.Click += SuperDetailButton_Click;
        // 
        // CloseButton
        // 
        CloseButton.Location = new Point(200, 78);
        CloseButton.Name = "CloseButton";
        CloseButton.Size = new Size(63, 35);
        CloseButton.TabIndex = 4;
        CloseButton.Text = "閉じる";
        CloseButton.UseVisualStyleBackColor = true;
        CloseButton.Click += CloseButton_Click;
        // 
        // ContestComboSetsInfoForm
        // 
        AutoScaleDimensions = new SizeF(9F, 17F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(275, 125);
        Controls.Add(CloseButton);
        Controls.Add(SuperDetailButton);
        Controls.Add(SuperCaptionLabel);
        Controls.Add(NormalDetailButton);
        Controls.Add(NormalCaptionLabel);
        Font = new Font("Meiryo UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 128);
        FormBorderStyle = FormBorderStyle.FixedSingle;
        Margin = new Padding(4, 3, 4, 3);
        MaximizeBox = false;
        Name = "ContestComboSetsInfoForm";
        StartPosition = FormStartPosition.CenterParent;
        Text = "コンテストのコンボセット";
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private Button NormalDetailButton;
    private Label NormalCaptionLabel;
    private Label SuperCaptionLabel;
    private Button SuperDetailButton;
    private Button CloseButton;
}