namespace Kos.PokeAPI.Forms;

partial class PokemonStatInfoForm
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
        StatButton = new Button();
        StatTextBox = new TextBox();
        BaseStatTextBox = new TextBox();
        BaseStatCaptionLabel = new Label();
        EffortTextBox = new TextBox();
        EffortCaptionLabel = new Label();
        CloseButton = new Button();
        PropertyButton = new Button();
        SuspendLayout();
        // 
        // StatButton
        // 
        StatButton.Location = new Point(12, 12);
        StatButton.Name = "StatButton";
        StatButton.Size = new Size(76, 25);
        StatButton.TabIndex = 0;
        StatButton.Text = "ステータス";
        StatButton.UseVisualStyleBackColor = true;
        // 
        // StatTextBox
        // 
        StatTextBox.Location = new Point(95, 13);
        StatTextBox.Margin = new Padding(4, 3, 4, 3);
        StatTextBox.Name = "StatTextBox";
        StatTextBox.ReadOnly = true;
        StatTextBox.Size = new Size(138, 24);
        StatTextBox.TabIndex = 1;
        // 
        // BaseStatTextBox
        // 
        BaseStatTextBox.Location = new Point(95, 43);
        BaseStatTextBox.Margin = new Padding(4, 3, 4, 3);
        BaseStatTextBox.Name = "BaseStatTextBox";
        BaseStatTextBox.ReadOnly = true;
        BaseStatTextBox.Size = new Size(138, 24);
        BaseStatTextBox.TabIndex = 3;
        // 
        // BaseStatCaptionLabel
        // 
        BaseStatCaptionLabel.AutoSize = true;
        BaseStatCaptionLabel.Location = new Point(39, 46);
        BaseStatCaptionLabel.Margin = new Padding(5, 0, 5, 0);
        BaseStatCaptionLabel.Name = "BaseStatCaptionLabel";
        BaseStatCaptionLabel.Size = new Size(47, 17);
        BaseStatCaptionLabel.TabIndex = 2;
        BaseStatCaptionLabel.Text = "種族値";
        BaseStatCaptionLabel.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // EffortTextBox
        // 
        EffortTextBox.Location = new Point(95, 73);
        EffortTextBox.Margin = new Padding(4, 3, 4, 3);
        EffortTextBox.Name = "EffortTextBox";
        EffortTextBox.ReadOnly = true;
        EffortTextBox.Size = new Size(138, 24);
        EffortTextBox.TabIndex = 5;
        // 
        // EffortCaptionLabel
        // 
        EffortCaptionLabel.AutoSize = true;
        EffortCaptionLabel.Location = new Point(41, 76);
        EffortCaptionLabel.Margin = new Padding(5, 0, 5, 0);
        EffortCaptionLabel.Name = "EffortCaptionLabel";
        EffortCaptionLabel.Size = new Size(47, 17);
        EffortCaptionLabel.TabIndex = 4;
        EffortCaptionLabel.Text = "努力値";
        EffortCaptionLabel.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // CloseButton
        // 
        CloseButton.Location = new Point(157, 103);
        CloseButton.Margin = new Padding(4, 3, 4, 3);
        CloseButton.Name = "CloseButton";
        CloseButton.Size = new Size(76, 35);
        CloseButton.TabIndex = 7;
        CloseButton.Text = "閉じる";
        CloseButton.UseVisualStyleBackColor = true;
        // 
        // PropertyButton
        // 
        PropertyButton.Location = new Point(73, 103);
        PropertyButton.Margin = new Padding(4, 3, 4, 3);
        PropertyButton.Name = "PropertyButton";
        PropertyButton.Size = new Size(76, 35);
        PropertyButton.TabIndex = 6;
        PropertyButton.Text = "プロパティ";
        PropertyButton.UseVisualStyleBackColor = true;
        // 
        // PokemonStatInfoForm
        // 
        AutoScaleDimensions = new SizeF(9F, 17F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(247, 148);
        Controls.Add(PropertyButton);
        Controls.Add(CloseButton);
        Controls.Add(EffortCaptionLabel);
        Controls.Add(EffortTextBox);
        Controls.Add(BaseStatCaptionLabel);
        Controls.Add(BaseStatTextBox);
        Controls.Add(StatTextBox);
        Controls.Add(StatButton);
        Font = new Font("Meiryo UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 128);
        Margin = new Padding(4, 3, 4, 3);
        MaximizeBox = false;
        Name = "PokemonStatInfoForm";
        StartPosition = FormStartPosition.CenterParent;
        Text = "ポケモンのステータス";
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private Button StatButton;
    private TextBox StatTextBox;
    private TextBox BaseStatTextBox;
    private Label BaseStatCaptionLabel;
    private TextBox EffortTextBox;
    private Label EffortCaptionLabel;
    private Button CloseButton;
    private Button PropertyButton;
}