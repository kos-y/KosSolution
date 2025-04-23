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
        IdLabel = new Label();
        IdCaptionLabel = new Label();
        BabyTriggerItemLabel = new Label();
        BabyTriggerItemCaptionLabel = new Label();
        BabyTriggerItemInfoButton = new Button();
        ChainCaptionLabel = new Label();
        ChainLabel = new Label();
        ChainInfoButton = new Button();
        CloseButton = new Button();
        SuspendLayout();
        // 
        // IdLabel
        // 
        IdLabel.BorderStyle = BorderStyle.Fixed3D;
        IdLabel.Location = new Point(133, 9);
        IdLabel.Name = "IdLabel";
        IdLabel.Size = new Size(147, 23);
        IdLabel.TabIndex = 1;
        IdLabel.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // IdCaptionLabel
        // 
        IdCaptionLabel.Location = new Point(12, 9);
        IdCaptionLabel.Name = "IdCaptionLabel";
        IdCaptionLabel.Size = new Size(115, 23);
        IdCaptionLabel.TabIndex = 0;
        IdCaptionLabel.Text = "id";
        IdCaptionLabel.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // BabyTriggerItemLabel
        // 
        BabyTriggerItemLabel.BorderStyle = BorderStyle.Fixed3D;
        BabyTriggerItemLabel.Location = new Point(133, 32);
        BabyTriggerItemLabel.Name = "BabyTriggerItemLabel";
        BabyTriggerItemLabel.Size = new Size(147, 23);
        BabyTriggerItemLabel.TabIndex = 3;
        BabyTriggerItemLabel.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // BabyTriggerItemCaptionLabel
        // 
        BabyTriggerItemCaptionLabel.Location = new Point(12, 32);
        BabyTriggerItemCaptionLabel.Name = "BabyTriggerItemCaptionLabel";
        BabyTriggerItemCaptionLabel.Size = new Size(115, 23);
        BabyTriggerItemCaptionLabel.TabIndex = 2;
        BabyTriggerItemCaptionLabel.Text = "baby_trigger_item";
        BabyTriggerItemCaptionLabel.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // BabyTriggerItemInfoButton
        // 
        BabyTriggerItemInfoButton.Location = new Point(286, 32);
        BabyTriggerItemInfoButton.Name = "BabyTriggerItemInfoButton";
        BabyTriggerItemInfoButton.Size = new Size(43, 23);
        BabyTriggerItemInfoButton.TabIndex = 4;
        BabyTriggerItemInfoButton.Text = "Info...";
        BabyTriggerItemInfoButton.UseVisualStyleBackColor = true;
        BabyTriggerItemInfoButton.Click += BabyTriggerItemInfoButton_Click;
        // 
        // ChainCaptionLabel
        // 
        ChainCaptionLabel.Location = new Point(12, 55);
        ChainCaptionLabel.Name = "ChainCaptionLabel";
        ChainCaptionLabel.Size = new Size(115, 23);
        ChainCaptionLabel.TabIndex = 5;
        ChainCaptionLabel.Text = "chain";
        ChainCaptionLabel.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // ChainLabel
        // 
        ChainLabel.BorderStyle = BorderStyle.Fixed3D;
        ChainLabel.Location = new Point(133, 55);
        ChainLabel.Name = "ChainLabel";
        ChainLabel.Size = new Size(147, 23);
        ChainLabel.TabIndex = 6;
        ChainLabel.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // ChainInfoButton
        // 
        ChainInfoButton.Location = new Point(286, 55);
        ChainInfoButton.Name = "ChainInfoButton";
        ChainInfoButton.Size = new Size(43, 23);
        ChainInfoButton.TabIndex = 7;
        ChainInfoButton.Text = "Info...";
        ChainInfoButton.UseVisualStyleBackColor = true;
        ChainInfoButton.Click += ChainInfoButton_Click;
        // 
        // CloseButton
        // 
        CloseButton.Location = new Point(254, 84);
        CloseButton.Name = "CloseButton";
        CloseButton.Size = new Size(75, 23);
        CloseButton.TabIndex = 8;
        CloseButton.Text = "Close";
        CloseButton.UseVisualStyleBackColor = true;
        CloseButton.Click += CloseButton_Click;
        // 
        // EvolutionChainInfoForm
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(345, 126);
        Controls.Add(CloseButton);
        Controls.Add(ChainInfoButton);
        Controls.Add(ChainLabel);
        Controls.Add(ChainCaptionLabel);
        Controls.Add(BabyTriggerItemInfoButton);
        Controls.Add(BabyTriggerItemCaptionLabel);
        Controls.Add(BabyTriggerItemLabel);
        Controls.Add(IdLabel);
        Controls.Add(IdCaptionLabel);
        FormBorderStyle = FormBorderStyle.FixedSingle;
        MaximizeBox = false;
        MinimizeBox = false;
        Name = "EvolutionChainInfoForm";
        Text = "Evolution Chain";
        Load += EvolutionChainInfoForm_Load;
        ResumeLayout(false);
    }

    #endregion

    private Label IdLabel;
    private Label IdCaptionLabel;
    private Label BabyTriggerItemLabel;
    private Label BabyTriggerItemCaptionLabel;
    private Button BabyTriggerItemInfoButton;
    private Label ChainCaptionLabel;
    private Label ChainLabel;
    private Button ChainInfoButton;
    private Button CloseButton;
}