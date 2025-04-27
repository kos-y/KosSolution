namespace Kos.PokeAPI.Forms;

partial class EvolutionChainInfoForm
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
        IdCaptionLabel = new Label();
        BabyTriggerItemCaptionLabel = new Label();
        BabyTriggerItemDetailButton = new Button();
        ChainCaptionLabel = new Label();
        ChainDetailButton = new Button();
        CloseButton = new Button();
        IdTextBox = new TextBox();
        BabyTriggerItemTextBox = new TextBox();
        ChainTextBox = new TextBox();
        SuspendLayout();
        // 
        // IdCaptionLabel
        // 
        IdCaptionLabel.AutoSize = true;
        IdCaptionLabel.Location = new Point(42, 10);
        IdCaptionLabel.Margin = new Padding(4, 0, 4, 0);
        IdCaptionLabel.Name = "IdCaptionLabel";
        IdCaptionLabel.Size = new Size(91, 17);
        IdCaptionLabel.TabIndex = 0;
        IdCaptionLabel.Text = "進化チェーンID";
        IdCaptionLabel.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // BabyTriggerItemCaptionLabel
        // 
        BabyTriggerItemCaptionLabel.AutoSize = true;
        BabyTriggerItemCaptionLabel.Location = new Point(15, 36);
        BabyTriggerItemCaptionLabel.Margin = new Padding(4, 0, 4, 0);
        BabyTriggerItemCaptionLabel.Name = "BabyTriggerItemCaptionLabel";
        BabyTriggerItemCaptionLabel.Size = new Size(118, 34);
        BabyTriggerItemCaptionLabel.TabIndex = 2;
        BabyTriggerItemCaptionLabel.Text = "ベビーポケモン\r\n進化トリガーアイテム";
        BabyTriggerItemCaptionLabel.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // BabyTriggerItemDetailButton
        // 
        BabyTriggerItemDetailButton.Location = new Point(397, 44);
        BabyTriggerItemDetailButton.Margin = new Padding(4, 3, 4, 3);
        BabyTriggerItemDetailButton.Name = "BabyTriggerItemDetailButton";
        BabyTriggerItemDetailButton.Size = new Size(44, 26);
        BabyTriggerItemDetailButton.TabIndex = 4;
        BabyTriggerItemDetailButton.Text = "詳細";
        BabyTriggerItemDetailButton.UseVisualStyleBackColor = true;
        BabyTriggerItemDetailButton.Click += BabyTriggerItemDetailButton_Click;
        // 
        // ChainCaptionLabel
        // 
        ChainCaptionLabel.AutoSize = true;
        ChainCaptionLabel.Location = new Point(85, 79);
        ChainCaptionLabel.Margin = new Padding(4, 0, 4, 0);
        ChainCaptionLabel.Name = "ChainCaptionLabel";
        ChainCaptionLabel.Size = new Size(48, 17);
        ChainCaptionLabel.TabIndex = 5;
        ChainCaptionLabel.Text = "チェーン";
        ChainCaptionLabel.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // ChainDetailButton
        // 
        ChainDetailButton.Location = new Point(397, 74);
        ChainDetailButton.Margin = new Padding(4, 3, 4, 3);
        ChainDetailButton.Name = "ChainDetailButton";
        ChainDetailButton.Size = new Size(44, 26);
        ChainDetailButton.TabIndex = 7;
        ChainDetailButton.Text = "詳細";
        ChainDetailButton.UseVisualStyleBackColor = true;
        ChainDetailButton.Click += ChainDetailButton_Click;
        // 
        // CloseButton
        // 
        CloseButton.Location = new Point(366, 116);
        CloseButton.Margin = new Padding(4, 3, 4, 3);
        CloseButton.Name = "CloseButton";
        CloseButton.Size = new Size(75, 35);
        CloseButton.TabIndex = 8;
        CloseButton.Text = "閉じる";
        CloseButton.UseVisualStyleBackColor = true;
        CloseButton.Click += CloseButton_Click;
        // 
        // IdTextBox
        // 
        IdTextBox.Location = new Point(140, 7);
        IdTextBox.Name = "IdTextBox";
        IdTextBox.ReadOnly = true;
        IdTextBox.Size = new Size(250, 24);
        IdTextBox.TabIndex = 1;
        // 
        // BabyTriggerItemTextBox
        // 
        BabyTriggerItemTextBox.Location = new Point(140, 42);
        BabyTriggerItemTextBox.Name = "BabyTriggerItemTextBox";
        BabyTriggerItemTextBox.ReadOnly = true;
        BabyTriggerItemTextBox.Size = new Size(250, 24);
        BabyTriggerItemTextBox.TabIndex = 3;
        // 
        // ChainTextBox
        // 
        ChainTextBox.Location = new Point(140, 76);
        ChainTextBox.Name = "ChainTextBox";
        ChainTextBox.ReadOnly = true;
        ChainTextBox.Size = new Size(250, 24);
        ChainTextBox.TabIndex = 6;
        // 
        // EvolutionChainInfoForm
        // 
        AutoScaleDimensions = new SizeF(9F, 17F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(450, 164);
        Controls.Add(ChainTextBox);
        Controls.Add(BabyTriggerItemTextBox);
        Controls.Add(IdTextBox);
        Controls.Add(CloseButton);
        Controls.Add(ChainDetailButton);
        Controls.Add(ChainCaptionLabel);
        Controls.Add(BabyTriggerItemDetailButton);
        Controls.Add(BabyTriggerItemCaptionLabel);
        Controls.Add(IdCaptionLabel);
        Font = new Font("Meiryo UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 128);
        FormBorderStyle = FormBorderStyle.FixedSingle;
        Margin = new Padding(4, 3, 4, 3);
        MaximizeBox = false;
        MinimizeBox = false;
        Name = "EvolutionChainInfoForm";
        StartPosition = FormStartPosition.CenterParent;
        Text = "進化チェーン";
        Load += EvolutionChainInfoForm_Load;
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion
    private Label IdCaptionLabel;
    private Label BabyTriggerItemCaptionLabel;
    private Button BabyTriggerItemDetailButton;
    private Label ChainCaptionLabel;
    private Button ChainDetailButton;
    private Button CloseButton;
    private TextBox IdTextBox;
    private TextBox BabyTriggerItemTextBox;
    private TextBox ChainTextBox;
}