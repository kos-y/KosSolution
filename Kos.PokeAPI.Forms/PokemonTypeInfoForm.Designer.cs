namespace Kos.PokeAPI.Forms;

partial class PokemonTypeInfoForm
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
        TypeButton = new Button();
        TypeTextBox = new TextBox();
        CloseButton = new Button();
        SuspendLayout();
        // 
        // SlotCaptionLabel
        // 
        SlotCaptionLabel.AutoSize = true;
        SlotCaptionLabel.Location = new Point(23, 15);
        SlotCaptionLabel.Margin = new Padding(5, 0, 5, 0);
        SlotCaptionLabel.Name = "SlotCaptionLabel";
        SlotCaptionLabel.Size = new Size(47, 17);
        SlotCaptionLabel.TabIndex = 0;
        SlotCaptionLabel.Text = "スロット";
        SlotCaptionLabel.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // SlotTextBox
        // 
        SlotTextBox.Location = new Point(79, 12);
        SlotTextBox.Margin = new Padding(4, 3, 4, 3);
        SlotTextBox.Name = "SlotTextBox";
        SlotTextBox.ReadOnly = true;
        SlotTextBox.Size = new Size(125, 24);
        SlotTextBox.TabIndex = 1;
        // 
        // TypeButton
        // 
        TypeButton.Location = new Point(12, 42);
        TypeButton.Name = "TypeButton";
        TypeButton.Size = new Size(60, 25);
        TypeButton.TabIndex = 2;
        TypeButton.Text = "タイプ";
        TypeButton.UseVisualStyleBackColor = true;
        // 
        // TypeTextBox
        // 
        TypeTextBox.Location = new Point(79, 42);
        TypeTextBox.Margin = new Padding(4, 3, 4, 3);
        TypeTextBox.Name = "TypeTextBox";
        TypeTextBox.ReadOnly = true;
        TypeTextBox.Size = new Size(125, 24);
        TypeTextBox.TabIndex = 3;
        // 
        // CloseButton
        // 
        CloseButton.Location = new Point(128, 72);
        CloseButton.Margin = new Padding(4, 3, 4, 3);
        CloseButton.Name = "CloseButton";
        CloseButton.Size = new Size(76, 35);
        CloseButton.TabIndex = 4;
        CloseButton.Text = "閉じる";
        CloseButton.UseVisualStyleBackColor = true;
        // 
        // PokemonTypeInfoForm
        // 
        AutoScaleDimensions = new SizeF(9F, 17F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(217, 117);
        Controls.Add(CloseButton);
        Controls.Add(TypeTextBox);
        Controls.Add(TypeButton);
        Controls.Add(SlotTextBox);
        Controls.Add(SlotCaptionLabel);
        Font = new Font("Meiryo UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 128);
        FormBorderStyle = FormBorderStyle.FixedSingle;
        Margin = new Padding(4, 3, 4, 3);
        MaximizeBox = false;
        Name = "PokemonTypeInfoForm";
        StartPosition = FormStartPosition.CenterParent;
        Text = "ポケモンのタイプ";
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private Label SlotCaptionLabel;
    private TextBox SlotTextBox;
    private Button TypeButton;
    private TextBox TypeTextBox;
    private Button CloseButton;
}