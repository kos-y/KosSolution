namespace Kos.PokeAPI.Forms;

partial class PokemonHeldItemVersionInfoForm
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
        RarityTextBox = new TextBox();
        RarityCaptionLabel = new Label();
        VersionButton = new Button();
        VersionTextBox = new TextBox();
        PropertyButton = new Button();
        CloseButton = new Button();
        SuspendLayout();
        // 
        // RarityTextBox
        // 
        RarityTextBox.Location = new Point(93, 42);
        RarityTextBox.Name = "RarityTextBox";
        RarityTextBox.ReadOnly = true;
        RarityTextBox.Size = new Size(189, 24);
        RarityTextBox.TabIndex = 3;
        // 
        // RarityCaptionLabel
        // 
        RarityCaptionLabel.AutoSize = true;
        RarityCaptionLabel.Location = new Point(53, 45);
        RarityCaptionLabel.Name = "RarityCaptionLabel";
        RarityCaptionLabel.Size = new Size(34, 17);
        RarityCaptionLabel.TabIndex = 2;
        RarityCaptionLabel.Text = "確率";
        RarityCaptionLabel.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // VersionButton
        // 
        VersionButton.Location = new Point(12, 12);
        VersionButton.Name = "VersionButton";
        VersionButton.Size = new Size(73, 24);
        VersionButton.TabIndex = 0;
        VersionButton.Text = "バージョン";
        VersionButton.UseVisualStyleBackColor = true;
        // 
        // VersionTextBox
        // 
        VersionTextBox.Location = new Point(91, 12);
        VersionTextBox.Name = "VersionTextBox";
        VersionTextBox.ReadOnly = true;
        VersionTextBox.Size = new Size(191, 24);
        VersionTextBox.TabIndex = 1;
        // 
        // PropertyButton
        // 
        PropertyButton.Location = new Point(122, 72);
        PropertyButton.Margin = new Padding(4, 3, 4, 3);
        PropertyButton.Name = "PropertyButton";
        PropertyButton.Size = new Size(76, 35);
        PropertyButton.TabIndex = 4;
        PropertyButton.Text = "プロパティ";
        PropertyButton.UseVisualStyleBackColor = true;
        // 
        // CloseButton
        // 
        CloseButton.Location = new Point(206, 72);
        CloseButton.Margin = new Padding(4, 3, 4, 3);
        CloseButton.Name = "CloseButton";
        CloseButton.Size = new Size(76, 35);
        CloseButton.TabIndex = 5;
        CloseButton.Text = "閉じる";
        CloseButton.UseVisualStyleBackColor = true;
        // 
        // PokemonHeldItemVersionInfoForm
        // 
        AutoScaleDimensions = new SizeF(9F, 17F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(300, 121);
        Controls.Add(PropertyButton);
        Controls.Add(CloseButton);
        Controls.Add(VersionButton);
        Controls.Add(VersionTextBox);
        Controls.Add(RarityTextBox);
        Controls.Add(RarityCaptionLabel);
        Font = new Font("Meiryo UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 128);
        FormBorderStyle = FormBorderStyle.FixedSingle;
        Margin = new Padding(4, 3, 4, 3);
        MaximizeBox = false;
        Name = "PokemonHeldItemVersionInfoForm";
        StartPosition = FormStartPosition.CenterParent;
        Text = "ポケモン所持アイテム詳細";
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private TextBox RarityTextBox;
    private Label RarityCaptionLabel;
    private Button VersionButton;
    private TextBox VersionTextBox;
    private Button PropertyButton;
    private Button CloseButton;
}