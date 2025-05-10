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
        BabyTriggerItemButton = new Button();
        ChainButton = new Button();
        CloseButton = new Button();
        IdTextBox = new TextBox();
        BabyTriggerItemTextBox = new TextBox();
        ChainTextBox = new TextBox();
        PropertyButton = new Button();
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
        // BabyTriggerItemButton
        // 
        BabyTriggerItemButton.Location = new Point(13, 42);
        BabyTriggerItemButton.Margin = new Padding(4, 3, 4, 3);
        BabyTriggerItemButton.Name = "BabyTriggerItemButton";
        BabyTriggerItemButton.Size = new Size(132, 43);
        BabyTriggerItemButton.TabIndex = 2;
        BabyTriggerItemButton.Text = "ベビーポケモン\r\n進化トリガーアイテム\r\n";
        BabyTriggerItemButton.UseVisualStyleBackColor = true;
        BabyTriggerItemButton.Click += BabyTriggerItemDetailButton_Click;
        // 
        // ChainButton
        // 
        ChainButton.Location = new Point(13, 91);
        ChainButton.Margin = new Padding(4, 3, 4, 3);
        ChainButton.Name = "ChainButton";
        ChainButton.Size = new Size(132, 26);
        ChainButton.TabIndex = 4;
        ChainButton.Text = "チェーン";
        ChainButton.UseVisualStyleBackColor = true;
        ChainButton.Click += ChainButton_Click;
        // 
        // CloseButton
        // 
        CloseButton.Location = new Point(327, 123);
        CloseButton.Margin = new Padding(4, 3, 4, 3);
        CloseButton.Name = "CloseButton";
        CloseButton.Size = new Size(76, 35);
        CloseButton.TabIndex = 6;
        CloseButton.Text = "閉じる";
        CloseButton.UseVisualStyleBackColor = true;
        CloseButton.Click += CloseButton_Click;
        // 
        // IdTextBox
        // 
        IdTextBox.Location = new Point(152, 7);
        IdTextBox.Name = "IdTextBox";
        IdTextBox.ReadOnly = true;
        IdTextBox.Size = new Size(250, 24);
        IdTextBox.TabIndex = 1;
        // 
        // BabyTriggerItemTextBox
        // 
        BabyTriggerItemTextBox.Location = new Point(152, 52);
        BabyTriggerItemTextBox.Name = "BabyTriggerItemTextBox";
        BabyTriggerItemTextBox.ReadOnly = true;
        BabyTriggerItemTextBox.Size = new Size(250, 24);
        BabyTriggerItemTextBox.TabIndex = 3;
        // 
        // ChainTextBox
        // 
        ChainTextBox.Location = new Point(152, 93);
        ChainTextBox.Name = "ChainTextBox";
        ChainTextBox.ReadOnly = true;
        ChainTextBox.Size = new Size(250, 24);
        ChainTextBox.TabIndex = 5;
        // 
        // PropertyButton
        // 
        PropertyButton.Location = new Point(244, 123);
        PropertyButton.Margin = new Padding(4, 3, 4, 3);
        PropertyButton.Name = "PropertyButton";
        PropertyButton.Size = new Size(76, 35);
        PropertyButton.TabIndex = 7;
        PropertyButton.Text = "プロパティ";
        PropertyButton.UseVisualStyleBackColor = true;
        PropertyButton.Click += PropertyButton_Click;
        // 
        // EvolutionChainInfoForm
        // 
        AutoScaleDimensions = new SizeF(9F, 17F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(418, 164);
        Controls.Add(PropertyButton);
        Controls.Add(ChainTextBox);
        Controls.Add(BabyTriggerItemTextBox);
        Controls.Add(IdTextBox);
        Controls.Add(CloseButton);
        Controls.Add(ChainButton);
        Controls.Add(BabyTriggerItemButton);
        Controls.Add(IdCaptionLabel);
        Font = new Font("Meiryo UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 128);
        FormBorderStyle = FormBorderStyle.FixedSingle;
        Margin = new Padding(4, 3, 4, 3);
        MaximizeBox = false;
        Name = "EvolutionChainInfoForm";
        StartPosition = FormStartPosition.CenterParent;
        Text = "進化チェーン";
        Load += EvolutionChainInfoForm_Load;
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion
    private Label IdCaptionLabel;
    private Button BabyTriggerItemButton;
    private Button ChainButton;
    private Button CloseButton;
    private TextBox IdTextBox;
    private TextBox BabyTriggerItemTextBox;
    private TextBox ChainTextBox;
    private Button PropertyButton;
}