namespace Kos.PokeAPI.Forms;

partial class NaturePokeathlonStatAffectInfoForm
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
        NatureTextBox = new TextBox();
        NatureButton = new Button();
        MaxChangeCaptionLabel = new Label();
        MaxChangeTextBox = new TextBox();
        PropertyButton = new Button();
        CloseButton = new Button();
        SuspendLayout();
        // 
        // NatureTextBox
        // 
        NatureTextBox.Location = new Point(92, 13);
        NatureTextBox.Name = "NatureTextBox";
        NatureTextBox.ReadOnly = true;
        NatureTextBox.Size = new Size(227, 24);
        NatureTextBox.TabIndex = 1;
        // 
        // NatureButton
        // 
        NatureButton.Location = new Point(12, 12);
        NatureButton.Name = "NatureButton";
        NatureButton.Size = new Size(74, 24);
        NatureButton.TabIndex = 0;
        NatureButton.Text = "性格";
        NatureButton.UseVisualStyleBackColor = true;
        NatureButton.Click += NatureButton_Click;
        // 
        // MaxChangeCaptionLabel
        // 
        MaxChangeCaptionLabel.AutoSize = true;
        MaxChangeCaptionLabel.Location = new Point(13, 46);
        MaxChangeCaptionLabel.Margin = new Padding(4, 0, 4, 0);
        MaxChangeCaptionLabel.Name = "MaxChangeCaptionLabel";
        MaxChangeCaptionLabel.Size = new Size(73, 17);
        MaxChangeCaptionLabel.TabIndex = 2;
        MaxChangeCaptionLabel.Text = "最大変化量";
        MaxChangeCaptionLabel.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // MaxChangeTextBox
        // 
        MaxChangeTextBox.Location = new Point(93, 43);
        MaxChangeTextBox.Name = "MaxChangeTextBox";
        MaxChangeTextBox.ReadOnly = true;
        MaxChangeTextBox.Size = new Size(227, 24);
        MaxChangeTextBox.TabIndex = 3;
        // 
        // PropertyButton
        // 
        PropertyButton.Location = new Point(159, 73);
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
        CloseButton.Location = new Point(243, 73);
        CloseButton.Margin = new Padding(4, 3, 4, 3);
        CloseButton.Name = "CloseButton";
        CloseButton.Size = new Size(76, 35);
        CloseButton.TabIndex = 5;
        CloseButton.Text = "閉じる";
        CloseButton.UseVisualStyleBackColor = true;
        CloseButton.Click += CloseButton_Click;
        // 
        // NaturePokeathlonStatAffectInfoForm
        // 
        AutoScaleDimensions = new SizeF(9F, 17F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(332, 116);
        Controls.Add(PropertyButton);
        Controls.Add(CloseButton);
        Controls.Add(MaxChangeTextBox);
        Controls.Add(MaxChangeCaptionLabel);
        Controls.Add(NatureTextBox);
        Controls.Add(NatureButton);
        Font = new Font("Meiryo UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 128);
        FormBorderStyle = FormBorderStyle.FixedSingle;
        Margin = new Padding(4, 3, 4, 3);
        MaximizeBox = false;
        Name = "NaturePokeathlonStatAffectInfoForm";
        StartPosition = FormStartPosition.CenterParent;
        Text = "性格が影響を与えるポケスロンのステータス";
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private TextBox NatureTextBox;
    private Button NatureButton;
    private Label MaxChangeCaptionLabel;
    private TextBox MaxChangeTextBox;
    private Button PropertyButton;
    private Button CloseButton;
}