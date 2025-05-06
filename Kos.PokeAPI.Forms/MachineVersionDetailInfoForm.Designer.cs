namespace Kos.PokeAPI.Forms;

partial class MachineVersionDetailInfoForm
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
        VersionGroupDetailButton = new Button();
        VersionGroupCaptionLabel = new Label();
        VersionGroupTextBox = new TextBox();
        MachineCaptionLabel = new Label();
        MachineDetailButton = new Button();
        CloseButton = new Button();
        SuspendLayout();
        // 
        // VersionGroupDetailButton
        // 
        VersionGroupDetailButton.Location = new Point(322, 9);
        VersionGroupDetailButton.Margin = new Padding(4, 3, 4, 3);
        VersionGroupDetailButton.Name = "VersionGroupDetailButton";
        VersionGroupDetailButton.Size = new Size(55, 27);
        VersionGroupDetailButton.TabIndex = 2;
        VersionGroupDetailButton.Text = "詳細";
        VersionGroupDetailButton.UseVisualStyleBackColor = true;
        VersionGroupDetailButton.Click += VersionGroupDetailButton_Click;
        // 
        // VersionGroupCaptionLabel
        // 
        VersionGroupCaptionLabel.AutoSize = true;
        VersionGroupCaptionLabel.Location = new Point(13, 14);
        VersionGroupCaptionLabel.Margin = new Padding(4, 0, 4, 0);
        VersionGroupCaptionLabel.Name = "VersionGroupCaptionLabel";
        VersionGroupCaptionLabel.Size = new Size(104, 17);
        VersionGroupCaptionLabel.TabIndex = 0;
        VersionGroupCaptionLabel.Text = "バージョングループ";
        VersionGroupCaptionLabel.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // VersionGroupTextBox
        // 
        VersionGroupTextBox.Location = new Point(124, 12);
        VersionGroupTextBox.Name = "VersionGroupTextBox";
        VersionGroupTextBox.ReadOnly = true;
        VersionGroupTextBox.Size = new Size(191, 24);
        VersionGroupTextBox.TabIndex = 1;
        // 
        // MachineCaptionLabel
        // 
        MachineCaptionLabel.AutoSize = true;
        MachineCaptionLabel.Location = new Point(65, 47);
        MachineCaptionLabel.Margin = new Padding(4, 0, 4, 0);
        MachineCaptionLabel.Name = "MachineCaptionLabel";
        MachineCaptionLabel.Size = new Size(52, 17);
        MachineCaptionLabel.TabIndex = 3;
        MachineCaptionLabel.Text = "技マシン";
        MachineCaptionLabel.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // MachineDetailButton
        // 
        MachineDetailButton.Location = new Point(124, 42);
        MachineDetailButton.Margin = new Padding(4, 3, 4, 3);
        MachineDetailButton.Name = "MachineDetailButton";
        MachineDetailButton.Size = new Size(55, 27);
        MachineDetailButton.TabIndex = 4;
        MachineDetailButton.Text = "詳細";
        MachineDetailButton.UseVisualStyleBackColor = true;
        MachineDetailButton.Click += MachineDetailButton_Click;
        // 
        // CloseButton
        // 
        CloseButton.Location = new Point(306, 82);
        CloseButton.Margin = new Padding(4, 3, 4, 3);
        CloseButton.Name = "CloseButton";
        CloseButton.Size = new Size(71, 31);
        CloseButton.TabIndex = 5;
        CloseButton.Text = "閉じる";
        CloseButton.UseVisualStyleBackColor = true;
        CloseButton.Click += CloseButton_Click;
        // 
        // MachineVersionDetailInfoForm
        // 
        AutoScaleDimensions = new SizeF(9F, 17F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(389, 124);
        Controls.Add(CloseButton);
        Controls.Add(MachineDetailButton);
        Controls.Add(MachineCaptionLabel);
        Controls.Add(VersionGroupDetailButton);
        Controls.Add(VersionGroupCaptionLabel);
        Controls.Add(VersionGroupTextBox);
        Font = new Font("Meiryo UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 128);
        FormBorderStyle = FormBorderStyle.FixedSingle;
        Margin = new Padding(4, 3, 4, 3);
        MaximizeBox = false;
        Name = "MachineVersionDetailInfoForm";
        StartPosition = FormStartPosition.CenterParent;
        Text = "バージョンごとの技マシン情報";
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private Button VersionGroupDetailButton;
    private Label VersionGroupCaptionLabel;
    private TextBox VersionGroupTextBox;
    private Label MachineCaptionLabel;
    private Button MachineDetailButton;
    private Button CloseButton;
}