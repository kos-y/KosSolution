namespace Kos.PokeAPI.Forms;

partial class AbilityPokemonInfoForm
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
        PokemonButton = new Button();
        PokemonTextBox = new TextBox();
        IsHiddenCaptionLabel = new Label();
        IsHiddenTextBox = new TextBox();
        SlotCaptionLabel = new Label();
        SlotTextBox = new TextBox();
        CloseButton = new Button();
        PropertyButton = new Button();
        SuspendLayout();
        // 
        // PokemonButton
        // 
        PokemonButton.Location = new Point(13, 9);
        PokemonButton.Margin = new Padding(4, 3, 4, 3);
        PokemonButton.Name = "PokemonButton";
        PokemonButton.Size = new Size(60, 27);
        PokemonButton.TabIndex = 0;
        PokemonButton.Text = "ポケモン";
        PokemonButton.UseVisualStyleBackColor = true;
        // 
        // PokemonTextBox
        // 
        PokemonTextBox.Location = new Point(80, 12);
        PokemonTextBox.Name = "PokemonTextBox";
        PokemonTextBox.ReadOnly = true;
        PokemonTextBox.Size = new Size(191, 24);
        PokemonTextBox.TabIndex = 1;
        // 
        // IsHiddenCaptionLabel
        // 
        IsHiddenCaptionLabel.AutoSize = true;
        IsHiddenCaptionLabel.Location = new Point(15, 75);
        IsHiddenCaptionLabel.Margin = new Padding(4, 0, 4, 0);
        IsHiddenCaptionLabel.Name = "IsHiddenCaptionLabel";
        IsHiddenCaptionLabel.Size = new Size(58, 17);
        IsHiddenCaptionLabel.TabIndex = 4;
        IsHiddenCaptionLabel.Text = "隠れ特性";
        IsHiddenCaptionLabel.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // IsHiddenTextBox
        // 
        IsHiddenTextBox.Location = new Point(80, 72);
        IsHiddenTextBox.Name = "IsHiddenTextBox";
        IsHiddenTextBox.ReadOnly = true;
        IsHiddenTextBox.Size = new Size(191, 24);
        IsHiddenTextBox.TabIndex = 5;
        // 
        // SlotCaptionLabel
        // 
        SlotCaptionLabel.AutoSize = true;
        SlotCaptionLabel.Location = new Point(26, 45);
        SlotCaptionLabel.Margin = new Padding(4, 0, 4, 0);
        SlotCaptionLabel.Name = "SlotCaptionLabel";
        SlotCaptionLabel.Size = new Size(47, 17);
        SlotCaptionLabel.TabIndex = 2;
        SlotCaptionLabel.Text = "スロット";
        SlotCaptionLabel.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // SlotTextBox
        // 
        SlotTextBox.Location = new Point(80, 42);
        SlotTextBox.Name = "SlotTextBox";
        SlotTextBox.ReadOnly = true;
        SlotTextBox.Size = new Size(191, 24);
        SlotTextBox.TabIndex = 3;
        // 
        // CloseButton
        // 
        CloseButton.Location = new Point(195, 102);
        CloseButton.Margin = new Padding(4, 3, 4, 3);
        CloseButton.Name = "CloseButton";
        CloseButton.Size = new Size(76, 35);
        CloseButton.TabIndex = 7;
        CloseButton.Text = "閉じる";
        CloseButton.UseVisualStyleBackColor = true;
        CloseButton.Click += CloseButton_Click;
        // 
        // PropertyButton
        // 
        PropertyButton.Location = new Point(111, 102);
        PropertyButton.Margin = new Padding(4, 3, 4, 3);
        PropertyButton.Name = "PropertyButton";
        PropertyButton.Size = new Size(76, 35);
        PropertyButton.TabIndex = 6;
        PropertyButton.Text = "プロパティ";
        PropertyButton.UseVisualStyleBackColor = true;
        PropertyButton.Click += PropertyButton_Click;
        // 
        // AbilityPokemonInfoForm
        // 
        AutoScaleDimensions = new SizeF(9F, 17F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(291, 145);
        Controls.Add(PropertyButton);
        Controls.Add(CloseButton);
        Controls.Add(SlotCaptionLabel);
        Controls.Add(SlotTextBox);
        Controls.Add(IsHiddenCaptionLabel);
        Controls.Add(IsHiddenTextBox);
        Controls.Add(PokemonButton);
        Controls.Add(PokemonTextBox);
        Font = new Font("Meiryo UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 128);
        FormBorderStyle = FormBorderStyle.FixedSingle;
        Margin = new Padding(4, 3, 4, 3);
        MaximizeBox = false;
        Name = "AbilityPokemonInfoForm";
        StartPosition = FormStartPosition.CenterParent;
        Text = "ポケモンの特性";
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private Button PokemonButton;
    private TextBox PokemonTextBox;
    private Label IsHiddenCaptionLabel;
    private TextBox IsHiddenTextBox;
    private Label SlotCaptionLabel;
    private TextBox SlotTextBox;
    private Button CloseButton;
    private Button PropertyButton;
}