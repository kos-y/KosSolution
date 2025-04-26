namespace Kos.PokeAPI.Forms;

partial class ItemHolderPokemonVersionDetailInfoForm
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
        RarityLabel = new Label();
        RarityCaptionLabel = new Label();
        VersionCaptionLabel = new Label();
        VersionLabel = new Label();
        VersionInfoButton = new Button();
        CloseButton = new Button();
        SuspendLayout();
        // 
        // RarityLabel
        // 
        RarityLabel.BorderStyle = BorderStyle.Fixed3D;
        RarityLabel.Location = new Point(75, 8);
        RarityLabel.Name = "RarityLabel";
        RarityLabel.Size = new Size(202, 23);
        RarityLabel.TabIndex = 1;
        RarityLabel.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // RarityCaptionLabel
        // 
        RarityCaptionLabel.Location = new Point(12, 9);
        RarityCaptionLabel.Name = "RarityCaptionLabel";
        RarityCaptionLabel.Size = new Size(57, 23);
        RarityCaptionLabel.TabIndex = 0;
        RarityCaptionLabel.Text = "rarity";
        RarityCaptionLabel.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // VersionCaptionLabel
        // 
        VersionCaptionLabel.Location = new Point(12, 34);
        VersionCaptionLabel.Name = "VersionCaptionLabel";
        VersionCaptionLabel.Size = new Size(57, 23);
        VersionCaptionLabel.TabIndex = 2;
        VersionCaptionLabel.Text = "version";
        VersionCaptionLabel.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // VersionLabel
        // 
        VersionLabel.BorderStyle = BorderStyle.Fixed3D;
        VersionLabel.Location = new Point(75, 34);
        VersionLabel.Name = "VersionLabel";
        VersionLabel.Size = new Size(202, 23);
        VersionLabel.TabIndex = 3;
        VersionLabel.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // VersionInfoButton
        // 
        VersionInfoButton.Location = new Point(283, 34);
        VersionInfoButton.Name = "VersionInfoButton";
        VersionInfoButton.Size = new Size(43, 23);
        VersionInfoButton.TabIndex = 4;
        VersionInfoButton.Text = "Info...";
        VersionInfoButton.UseVisualStyleBackColor = true;
        VersionInfoButton.Click += VersionInfoButton_Click;
        // 
        // CloseButton
        // 
        CloseButton.Location = new Point(251, 60);
        CloseButton.Name = "CloseButton";
        CloseButton.Size = new Size(75, 23);
        CloseButton.TabIndex = 5;
        CloseButton.Text = "Close";
        CloseButton.UseVisualStyleBackColor = true;
        CloseButton.Click += CloseButton_Click;
        // 
        // ItemHolderPokemonVersionDetailInfoForm
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(338, 92);
        Controls.Add(CloseButton);
        Controls.Add(VersionInfoButton);
        Controls.Add(VersionLabel);
        Controls.Add(VersionCaptionLabel);
        Controls.Add(RarityLabel);
        Controls.Add(RarityCaptionLabel);
        FormBorderStyle = FormBorderStyle.FixedSingle;
        MaximizeBox = false;
        Name = "ItemHolderPokemonVersionDetailInfoForm";
        Text = "Item Holder Pokemon Version Detail";
        ResumeLayout(false);
    }

    #endregion

    private Label RarityLabel;
    private Label RarityCaptionLabel;
    private Label VersionCaptionLabel;
    private Label VersionLabel;
    private Button VersionInfoButton;
    private Button CloseButton;
}