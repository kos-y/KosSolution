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
        VersionCaptionLabel = new Label();
        VersionDetailButton = new Button();
        CloseButton = new Button();
        VersionTextBox = new TextBox();
        RarityTextBox = new TextBox();
        SuspendLayout();
        // 
        // RarityCaptionLabel
        // 
        RarityCaptionLabel.AutoSize = true;
        RarityCaptionLabel.Location = new Point(15, 10);
        RarityCaptionLabel.Margin = new Padding(4, 0, 4, 0);
        RarityCaptionLabel.Name = "RarityCaptionLabel";
        RarityCaptionLabel.Size = new Size(60, 17);
        RarityCaptionLabel.TabIndex = 0;
        RarityCaptionLabel.Text = "所持確立";
        RarityCaptionLabel.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // VersionCaptionLabel
        // 
        VersionCaptionLabel.AutoSize = true;
        VersionCaptionLabel.Location = new Point(15, 43);
        VersionCaptionLabel.Margin = new Padding(4, 0, 4, 0);
        VersionCaptionLabel.Name = "VersionCaptionLabel";
        VersionCaptionLabel.Size = new Size(60, 17);
        VersionCaptionLabel.TabIndex = 2;
        VersionCaptionLabel.Text = "バージョン";
        VersionCaptionLabel.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // VersionDetailButton
        // 
        VersionDetailButton.Location = new Point(364, 38);
        VersionDetailButton.Margin = new Padding(4, 3, 4, 3);
        VersionDetailButton.Name = "VersionDetailButton";
        VersionDetailButton.Size = new Size(55, 26);
        VersionDetailButton.TabIndex = 4;
        VersionDetailButton.Text = "詳細";
        VersionDetailButton.UseVisualStyleBackColor = true;
        VersionDetailButton.Click += VersionDetailButton_Click;
        // 
        // CloseButton
        // 
        CloseButton.Location = new Point(350, 70);
        CloseButton.Margin = new Padding(4, 3, 4, 3);
        CloseButton.Name = "CloseButton";
        CloseButton.Size = new Size(69, 40);
        CloseButton.TabIndex = 5;
        CloseButton.Text = "閉じる";
        CloseButton.UseVisualStyleBackColor = true;
        CloseButton.Click += CloseButton_Click;
        // 
        // VersionTextBox
        // 
        VersionTextBox.Location = new Point(82, 40);
        VersionTextBox.Name = "VersionTextBox";
        VersionTextBox.ReadOnly = true;
        VersionTextBox.Size = new Size(275, 24);
        VersionTextBox.TabIndex = 3;
        // 
        // RarityTextBox
        // 
        RarityTextBox.Location = new Point(82, 10);
        RarityTextBox.Name = "RarityTextBox";
        RarityTextBox.ReadOnly = true;
        RarityTextBox.Size = new Size(275, 24);
        RarityTextBox.TabIndex = 1;
        // 
        // ItemHolderPokemonVersionDetailInfoForm
        // 
        AutoScaleDimensions = new SizeF(9F, 17F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(435, 122);
        Controls.Add(RarityTextBox);
        Controls.Add(VersionTextBox);
        Controls.Add(CloseButton);
        Controls.Add(VersionDetailButton);
        Controls.Add(VersionCaptionLabel);
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
    private Label VersionCaptionLabel;
    private Button VersionDetailButton;
    private Button CloseButton;
    private TextBox VersionTextBox;
    private TextBox RarityTextBox;
}