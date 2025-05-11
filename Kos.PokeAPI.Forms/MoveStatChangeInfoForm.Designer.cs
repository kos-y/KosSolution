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
        ChangeTextBox = new TextBox();
        ChangeCaptionLabel = new Label();
        StatButton = new Button();
        CloseButton = new Button();
        PropertyButton = new Button();
        SuspendLayout();
        // 
        // StatTextBox
        // 
        StatTextBox.Location = new Point(88, 16);
        StatTextBox.Name = "StatTextBox";
        StatTextBox.ReadOnly = true;
        StatTextBox.Size = new Size(124, 24);
        StatTextBox.TabIndex = 1;
        StatTextBox.Text = "Normal";
        // 
        // ChangeTextBox
        // 
        ChangeTextBox.Location = new Point(88, 46);
        ChangeTextBox.Name = "ChangeTextBox";
        ChangeTextBox.ReadOnly = true;
        ChangeTextBox.Size = new Size(124, 24);
        ChangeTextBox.TabIndex = 3;
        ChangeTextBox.Text = "999";
        // 
        // ChangeCaptionLabel
        // 
        ChangeCaptionLabel.AutoSize = true;
        ChangeCaptionLabel.Font = new Font("Meiryo UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 128);
        ChangeCaptionLabel.Location = new Point(35, 49);
        ChangeCaptionLabel.Name = "ChangeCaptionLabel";
        ChangeCaptionLabel.Size = new Size(47, 17);
        ChangeCaptionLabel.TabIndex = 2;
        ChangeCaptionLabel.Text = "変化量";
        // 
        // StatButton
        // 
        StatButton.Location = new Point(12, 12);
        StatButton.Name = "StatButton";
        StatButton.Size = new Size(70, 30);
        StatButton.TabIndex = 0;
        StatButton.Text = "ステータス";
        StatButton.UseVisualStyleBackColor = true;
        StatButton.Click += StatButton_Click;
        // 
        // CloseButton
        // 
        CloseButton.Location = new Point(136, 79);
        CloseButton.Name = "CloseButton";
        CloseButton.Size = new Size(76, 35);
        CloseButton.TabIndex = 5;
        CloseButton.Text = "閉じる";
        CloseButton.UseVisualStyleBackColor = true;
        CloseButton.Click += CloseButton_Click;
        // 
        // PropertyButton
        // 
        PropertyButton.Location = new Point(54, 79);
        PropertyButton.Name = "PropertyButton";
        PropertyButton.Size = new Size(76, 35);
        PropertyButton.TabIndex = 4;
        PropertyButton.Text = "プロパティ";
        PropertyButton.UseVisualStyleBackColor = true;
        PropertyButton.Click += PropertyButton_Click;
        // 
        // MoveStatChangeInfoForm
        // 
        AutoScaleDimensions = new SizeF(9F, 17F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(228, 126);
        Controls.Add(PropertyButton);
        Controls.Add(CloseButton);
        Controls.Add(StatButton);
        Controls.Add(ChangeCaptionLabel);
        Controls.Add(ChangeTextBox);
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
    private TextBox ChangeTextBox;
    private Label ChangeCaptionLabel;
    private Button StatButton;
    private Button CloseButton;
    private Button PropertyButton;
}