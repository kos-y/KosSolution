namespace Kos.PokeAPI.Forms;

partial class MoveStatChangeInfoForm
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
        StatTextBox = new TextBox();
        StatCaptionLabel = new Label();
        ChangeTextBox = new TextBox();
        ChangeCaptionLabel = new Label();
        StatDetailButton = new Button();
        CloseButton = new Button();
        SuspendLayout();
        // 
        // StatTextBox
        // 
        StatTextBox.Location = new Point(79, 12);
        StatTextBox.Name = "StatTextBox";
        StatTextBox.ReadOnly = true;
        StatTextBox.Size = new Size(124, 24);
        StatTextBox.TabIndex = 2;
        StatTextBox.Text = "Normal";
        // 
        // StatCaptionLabel
        // 
        StatCaptionLabel.AutoSize = true;
        StatCaptionLabel.Font = new Font("Meiryo UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 128);
        StatCaptionLabel.Location = new Point(12, 15);
        StatCaptionLabel.Name = "StatCaptionLabel";
        StatCaptionLabel.Size = new Size(61, 17);
        StatCaptionLabel.TabIndex = 3;
        StatCaptionLabel.Text = "ステータス";
        // 
        // ChangeTextBox
        // 
        ChangeTextBox.Location = new Point(79, 42);
        ChangeTextBox.Name = "ChangeTextBox";
        ChangeTextBox.ReadOnly = true;
        ChangeTextBox.Size = new Size(124, 24);
        ChangeTextBox.TabIndex = 4;
        ChangeTextBox.Text = "999";
        // 
        // ChangeCaptionLabel
        // 
        ChangeCaptionLabel.AutoSize = true;
        ChangeCaptionLabel.Font = new Font("Meiryo UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 128);
        ChangeCaptionLabel.Location = new Point(26, 45);
        ChangeCaptionLabel.Name = "ChangeCaptionLabel";
        ChangeCaptionLabel.Size = new Size(47, 17);
        ChangeCaptionLabel.TabIndex = 5;
        ChangeCaptionLabel.Text = "変化量";
        // 
        // StatDetailButton
        // 
        StatDetailButton.Location = new Point(209, 8);
        StatDetailButton.Name = "StatDetailButton";
        StatDetailButton.Size = new Size(53, 30);
        StatDetailButton.TabIndex = 6;
        StatDetailButton.Text = "詳細";
        StatDetailButton.UseVisualStyleBackColor = true;
        StatDetailButton.Click += StatDetailButton_Click;
        // 
        // CloseButton
        // 
        CloseButton.Location = new Point(199, 72);
        CloseButton.Name = "CloseButton";
        CloseButton.Size = new Size(63, 35);
        CloseButton.TabIndex = 16;
        CloseButton.Text = "閉じる";
        CloseButton.UseVisualStyleBackColor = true;
        CloseButton.Click += CloseButton_Click;
        // 
        // MoveStatChangeInfoForm
        // 
        AutoScaleDimensions = new SizeF(9F, 17F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(279, 126);
        Controls.Add(CloseButton);
        Controls.Add(StatDetailButton);
        Controls.Add(ChangeCaptionLabel);
        Controls.Add(ChangeTextBox);
        Controls.Add(StatCaptionLabel);
        Controls.Add(StatTextBox);
        Font = new Font("Meiryo UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 128);
        FormBorderStyle = FormBorderStyle.FixedSingle;
        Margin = new Padding(4, 3, 4, 3);
        MaximizeBox = false;
        Name = "MoveStatChangeInfoForm";
        StartPosition = FormStartPosition.CenterParent;
        Text = "技が影響を与えるステータス";
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private TextBox StatTextBox;
    private Label StatCaptionLabel;
    private TextBox ChangeTextBox;
    private Label ChangeCaptionLabel;
    private Button StatDetailButton;
    private Button CloseButton;
}