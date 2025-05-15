namespace Kos.PokeAPI.Forms;

partial class NatureStatChangeInfoForm
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
        PokeathlonStatButton = new Button();
        PokeathlonStatTextBox = new TextBox();
        MaxChangeCaptionLabel = new Label();
        MaxChangeTextBox = new TextBox();
        PropertyButton = new Button();
        CloseButton = new Button();
        SuspendLayout();
        // 
        // PokeathlonStatButton
        // 
        PokeathlonStatButton.Location = new Point(12, 12);
        PokeathlonStatButton.Name = "PokeathlonStatButton";
        PokeathlonStatButton.Size = new Size(74, 24);
        PokeathlonStatButton.TabIndex = 0;
        PokeathlonStatButton.Text = "ステータス";
        PokeathlonStatButton.UseVisualStyleBackColor = true;
        PokeathlonStatButton.Click += PokeathlonStatButton_Click;
        // 
        // PokeathlonStatTextBox
        // 
        PokeathlonStatTextBox.Location = new Point(92, 12);
        PokeathlonStatTextBox.Name = "PokeathlonStatTextBox";
        PokeathlonStatTextBox.ReadOnly = true;
        PokeathlonStatTextBox.Size = new Size(191, 24);
        PokeathlonStatTextBox.TabIndex = 1;
        // 
        // MaxChangeCaptionLabel
        // 
        MaxChangeCaptionLabel.AutoSize = true;
        MaxChangeCaptionLabel.Location = new Point(12, 45);
        MaxChangeCaptionLabel.Margin = new Padding(4, 0, 4, 0);
        MaxChangeCaptionLabel.Name = "MaxChangeCaptionLabel";
        MaxChangeCaptionLabel.Size = new Size(73, 17);
        MaxChangeCaptionLabel.TabIndex = 2;
        MaxChangeCaptionLabel.Text = "最大変化量";
        MaxChangeCaptionLabel.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // MaxChangeTextBox
        // 
        MaxChangeTextBox.Location = new Point(92, 42);
        MaxChangeTextBox.Name = "MaxChangeTextBox";
        MaxChangeTextBox.ReadOnly = true;
        MaxChangeTextBox.Size = new Size(191, 24);
        MaxChangeTextBox.TabIndex = 3;
        // 
        // PropertyButton
        // 
        PropertyButton.Location = new Point(123, 72);
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
        CloseButton.Location = new Point(207, 72);
        CloseButton.Margin = new Padding(4, 3, 4, 3);
        CloseButton.Name = "CloseButton";
        CloseButton.Size = new Size(76, 35);
        CloseButton.TabIndex = 5;
        CloseButton.Text = "閉じる";
        CloseButton.UseVisualStyleBackColor = true;
        CloseButton.Click += CloseButton_Click;
        // 
        // NatureStatChangeInfoForm
        // 
        AutoScaleDimensions = new SizeF(9F, 17F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(305, 122);
        Controls.Add(PropertyButton);
        Controls.Add(CloseButton);
        Controls.Add(MaxChangeTextBox);
        Controls.Add(MaxChangeCaptionLabel);
        Controls.Add(PokeathlonStatTextBox);
        Controls.Add(PokeathlonStatButton);
        Font = new Font("Meiryo UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 128);
        FormBorderStyle = FormBorderStyle.FixedSingle;
        Margin = new Padding(4, 3, 4, 3);
        MaximizeBox = false;
        Name = "NatureStatChangeInfoForm";
        StartPosition = FormStartPosition.CenterParent;
        Text = "影響を与えるポケスロンのステータス";
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private Button PokeathlonStatButton;
    private TextBox PokeathlonStatTextBox;
    private Label MaxChangeCaptionLabel;
    private TextBox MaxChangeTextBox;
    private Button PropertyButton;
    private Button CloseButton;
}