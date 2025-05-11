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
        RarityCaptionLabel = new Label();
        VersionButton = new Button();
        CloseButton = new Button();
        VersionTextBox = new TextBox();
        RarityTextBox = new TextBox();
        PropertyButton = new Button();
        SuspendLayout();
        // 
        // RarityCaptionLabel
        // 
        RarityCaptionLabel.AutoSize = true;
        RarityCaptionLabel.Location = new Point(24, 44);
        RarityCaptionLabel.Margin = new Padding(4, 0, 4, 0);
        RarityCaptionLabel.Name = "RarityCaptionLabel";
        RarityCaptionLabel.Size = new Size(60, 17);
        RarityCaptionLabel.TabIndex = 2;
        RarityCaptionLabel.Text = "所持確立";
        RarityCaptionLabel.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // VersionButton
        // 
        VersionButton.Location = new Point(13, 12);
        VersionButton.Margin = new Padding(4, 3, 4, 3);
        VersionButton.Name = "VersionButton";
        VersionButton.Size = new Size(71, 26);
        VersionButton.TabIndex = 0;
        VersionButton.Text = "バージョン";
        VersionButton.UseVisualStyleBackColor = true;
        VersionButton.Click += VersionButton_Click;
        // 
        // CloseButton
        // 
        CloseButton.Location = new Point(187, 74);
        CloseButton.Margin = new Padding(4, 3, 4, 3);
        CloseButton.Name = "CloseButton";
        CloseButton.Size = new Size(76, 35);
        CloseButton.TabIndex = 5;
        CloseButton.Text = "閉じる";
        CloseButton.UseVisualStyleBackColor = true;
        CloseButton.Click += CloseButton_Click;
        // 
        // VersionTextBox
        // 
        VersionTextBox.Location = new Point(91, 14);
        VersionTextBox.Name = "VersionTextBox";
        VersionTextBox.ReadOnly = true;
        VersionTextBox.Size = new Size(172, 24);
        VersionTextBox.TabIndex = 1;
        // 
        // RarityTextBox
        // 
        RarityTextBox.Location = new Point(91, 44);
        RarityTextBox.Name = "RarityTextBox";
        RarityTextBox.ReadOnly = true;
        RarityTextBox.Size = new Size(172, 24);
        RarityTextBox.TabIndex = 3;
        // 
        // PropertyButton
        // 
        PropertyButton.Location = new Point(103, 74);
        PropertyButton.Margin = new Padding(4, 3, 4, 3);
        PropertyButton.Name = "PropertyButton";
        PropertyButton.Size = new Size(76, 35);
        PropertyButton.TabIndex = 4;
        PropertyButton.Text = "プロパティ";
        PropertyButton.UseVisualStyleBackColor = true;
        PropertyButton.Click += PropertyButton_Click;
        // 
        // ItemHolderPokemonVersionDetailInfoForm
        // 
        AutoScaleDimensions = new SizeF(9F, 17F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(276, 119);
        Controls.Add(PropertyButton);
        Controls.Add(RarityTextBox);
        Controls.Add(VersionTextBox);
        Controls.Add(CloseButton);
        Controls.Add(VersionButton);
        Controls.Add(RarityCaptionLabel);
        Font = new Font("Meiryo UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 128);
        FormBorderStyle = FormBorderStyle.FixedSingle;
        Margin = new Padding(4, 3, 4, 3);
        MaximizeBox = false;
        Name = "ItemHolderPokemonVersionDetailInfoForm";
        StartPosition = FormStartPosition.CenterParent;
        Text = "アイテム所持ポケモン バージョンごとの詳細";
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion
    private Label RarityCaptionLabel;
    private Button VersionButton;
    private Button CloseButton;
    private TextBox VersionTextBox;
    private TextBox RarityTextBox;
    private Button PropertyButton;
}