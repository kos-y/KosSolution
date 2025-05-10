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
        PokemonDetailButton = new Button();
        PokemonCaptionLabel = new Label();
        PokemonTextBox = new TextBox();
        label1 = new Label();
        IsHiddenTextBox = new TextBox();
        SlotCaptionLabel = new Label();
        SlotTextBox = new TextBox();
        CloseButton = new Button();
        SuspendLayout();
        // 
        // PokemonDetailButton
        // 
        PokemonDetailButton.Location = new Point(278, 10);
        PokemonDetailButton.Margin = new Padding(4, 3, 4, 3);
        PokemonDetailButton.Name = "PokemonDetailButton";
        PokemonDetailButton.Size = new Size(55, 27);
        PokemonDetailButton.TabIndex = 2;
        PokemonDetailButton.Text = "詳細";
        PokemonDetailButton.UseVisualStyleBackColor = true;
        // 
        // PokemonCaptionLabel
        // 
        PokemonCaptionLabel.AutoSize = true;
        PokemonCaptionLabel.Location = new Point(13, 15);
        PokemonCaptionLabel.Margin = new Padding(4, 0, 4, 0);
        PokemonCaptionLabel.Name = "PokemonCaptionLabel";
        PokemonCaptionLabel.Size = new Size(49, 17);
        PokemonCaptionLabel.TabIndex = 0;
        PokemonCaptionLabel.Text = "ポケモン";
        PokemonCaptionLabel.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // PokemonTextBox
        // 
        PokemonTextBox.Location = new Point(80, 12);
        PokemonTextBox.Name = "PokemonTextBox";
        PokemonTextBox.ReadOnly = true;
        PokemonTextBox.Size = new Size(191, 24);
        PokemonTextBox.TabIndex = 1;
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.Location = new Point(15, 75);
        label1.Margin = new Padding(4, 0, 4, 0);
        label1.Name = "label1";
        label1.Size = new Size(58, 17);
        label1.TabIndex = 5;
        label1.Text = "隠れ特性";
        label1.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // IsHiddenTextBox
        // 
        IsHiddenTextBox.Location = new Point(80, 72);
        IsHiddenTextBox.Name = "IsHiddenTextBox";
        IsHiddenTextBox.ReadOnly = true;
        IsHiddenTextBox.Size = new Size(191, 24);
        IsHiddenTextBox.TabIndex = 6;
        // 
        // SlotCaptionLabel
        // 
        SlotCaptionLabel.AutoSize = true;
        SlotCaptionLabel.Location = new Point(15, 45);
        SlotCaptionLabel.Margin = new Padding(4, 0, 4, 0);
        SlotCaptionLabel.Name = "SlotCaptionLabel";
        SlotCaptionLabel.Size = new Size(47, 17);
        SlotCaptionLabel.TabIndex = 3;
        SlotCaptionLabel.Text = "スロッド";
        SlotCaptionLabel.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // SlotTextBox
        // 
        SlotTextBox.Location = new Point(80, 42);
        SlotTextBox.Name = "SlotTextBox";
        SlotTextBox.ReadOnly = true;
        SlotTextBox.Size = new Size(191, 24);
        SlotTextBox.TabIndex = 4;
        // 
        // CloseButton
        // 
        CloseButton.Location = new Point(264, 102);
        CloseButton.Margin = new Padding(4, 3, 4, 3);
        CloseButton.Name = "CloseButton";
        CloseButton.Size = new Size(69, 36);
        CloseButton.TabIndex = 7;
        CloseButton.Text = "閉じる";
        CloseButton.UseVisualStyleBackColor = true;
        CloseButton.Click += CloseButton_Click;
        // 
        // AbilityPokemonInfoForm
        // 
        AutoScaleDimensions = new SizeF(9F, 17F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(355, 161);
        Controls.Add(CloseButton);
        Controls.Add(SlotCaptionLabel);
        Controls.Add(SlotTextBox);
        Controls.Add(label1);
        Controls.Add(IsHiddenTextBox);
        Controls.Add(PokemonDetailButton);
        Controls.Add(PokemonCaptionLabel);
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

    private Button PokemonDetailButton;
    private Label PokemonCaptionLabel;
    private TextBox PokemonTextBox;
    private Label label1;
    private TextBox IsHiddenTextBox;
    private Label SlotCaptionLabel;
    private TextBox SlotTextBox;
    private Button CloseButton;
}