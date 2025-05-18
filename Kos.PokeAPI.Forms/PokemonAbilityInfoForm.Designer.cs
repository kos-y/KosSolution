namespace Kos.PokeAPI.Forms;

partial class PokemonAbilityInfoForm
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
        SlotCaptionLabel = new Label();
        SlotTextBox = new TextBox();
        AbilityButton = new Button();
        AbilityTextBox = new TextBox();
        IsHiddenTextBox = new TextBox();
        IsHiddenCaptionLabel = new Label();
        CloseButton = new Button();
        PropertyButton = new Button();
        SuspendLayout();
        // 
        // SlotCaptionLabel
        // 
        SlotCaptionLabel.AutoSize = true;
        SlotCaptionLabel.Location = new Point(14, 15);
        SlotCaptionLabel.Margin = new Padding(5, 0, 5, 0);
        SlotCaptionLabel.Name = "SlotCaptionLabel";
        SlotCaptionLabel.Size = new Size(47, 17);
        SlotCaptionLabel.TabIndex = 0;
        SlotCaptionLabel.Text = "スロット";
        SlotCaptionLabel.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // SlotTextBox
        // 
        SlotTextBox.Location = new Point(80, 12);
        SlotTextBox.Margin = new Padding(4, 3, 4, 3);
        SlotTextBox.Name = "SlotTextBox";
        SlotTextBox.ReadOnly = true;
        SlotTextBox.Size = new Size(167, 24);
        SlotTextBox.TabIndex = 1;
        // 
        // AbilityButton
        // 
        AbilityButton.Location = new Point(12, 42);
        AbilityButton.Name = "AbilityButton";
        AbilityButton.Size = new Size(59, 25);
        AbilityButton.TabIndex = 2;
        AbilityButton.Text = "特性";
        AbilityButton.UseVisualStyleBackColor = true;
        AbilityButton.Click += AbilityButton_Click;
        // 
        // AbilityTextBox
        // 
        AbilityTextBox.Location = new Point(80, 42);
        AbilityTextBox.Margin = new Padding(4, 3, 4, 3);
        AbilityTextBox.Name = "AbilityTextBox";
        AbilityTextBox.ReadOnly = true;
        AbilityTextBox.Size = new Size(167, 24);
        AbilityTextBox.TabIndex = 3;
        // 
        // IsHiddenTextBox
        // 
        IsHiddenTextBox.Location = new Point(80, 72);
        IsHiddenTextBox.Margin = new Padding(4, 3, 4, 3);
        IsHiddenTextBox.Name = "IsHiddenTextBox";
        IsHiddenTextBox.ReadOnly = true;
        IsHiddenTextBox.Size = new Size(167, 24);
        IsHiddenTextBox.TabIndex = 5;
        // 
        // IsHiddenCaptionLabel
        // 
        IsHiddenCaptionLabel.AutoSize = true;
        IsHiddenCaptionLabel.Location = new Point(14, 75);
        IsHiddenCaptionLabel.Margin = new Padding(5, 0, 5, 0);
        IsHiddenCaptionLabel.Name = "IsHiddenCaptionLabel";
        IsHiddenCaptionLabel.Size = new Size(57, 17);
        IsHiddenCaptionLabel.TabIndex = 4;
        IsHiddenCaptionLabel.Text = "隠し特性";
        IsHiddenCaptionLabel.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // CloseButton
        // 
        CloseButton.Location = new Point(171, 102);
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
        PropertyButton.Location = new Point(88, 100);
        PropertyButton.Name = "PropertyButton";
        PropertyButton.Size = new Size(76, 35);
        PropertyButton.TabIndex = 6;
        PropertyButton.Text = "プロパティ";
        PropertyButton.UseVisualStyleBackColor = true;
        PropertyButton.Click += PropertyButton_Click;
        // 
        // PokemonAbilityInfoForm
        // 
        AutoScaleDimensions = new SizeF(9F, 17F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(269, 147);
        Controls.Add(PropertyButton);
        Controls.Add(CloseButton);
        Controls.Add(IsHiddenCaptionLabel);
        Controls.Add(IsHiddenTextBox);
        Controls.Add(AbilityTextBox);
        Controls.Add(AbilityButton);
        Controls.Add(SlotCaptionLabel);
        Controls.Add(SlotTextBox);
        Font = new Font("Meiryo UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 128);
        Margin = new Padding(4, 3, 4, 3);
        MaximizeBox = false;
        Name = "PokemonAbilityInfoForm";
        StartPosition = FormStartPosition.CenterParent;
        Text = "ポケモンの特性";
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private Label SlotCaptionLabel;
    private TextBox SlotTextBox;
    private Button AbilityButton;
    private TextBox AbilityTextBox;
    private TextBox IsHiddenTextBox;
    private Label IsHiddenCaptionLabel;
    private Button CloseButton;
    private Button PropertyButton;
}