namespace Kos.PokeAPI.Forms;

partial class PokemonMoveVersionInfoForm
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
        VersionGroupTextBox = new TextBox();
        VersionGroupButton = new Button();
        MoveLearnMethodButton = new Button();
        MoveLearnMethodTextBox = new TextBox();
        LevelLearnedCaptionLabel = new Label();
        LevelLearnedAtTextBox = new TextBox();
        PropertyButton = new Button();
        CloseButton = new Button();
        SuspendLayout();
        // 
        // VersionGroupTextBox
        // 
        VersionGroupTextBox.Location = new Point(138, 15);
        VersionGroupTextBox.Margin = new Padding(5, 3, 5, 3);
        VersionGroupTextBox.Name = "VersionGroupTextBox";
        VersionGroupTextBox.ReadOnly = true;
        VersionGroupTextBox.Size = new Size(217, 24);
        VersionGroupTextBox.TabIndex = 1;
        // 
        // VersionGroupButton
        // 
        VersionGroupButton.Location = new Point(13, 12);
        VersionGroupButton.Margin = new Padding(4, 3, 4, 3);
        VersionGroupButton.Name = "VersionGroupButton";
        VersionGroupButton.Size = new Size(116, 28);
        VersionGroupButton.TabIndex = 0;
        VersionGroupButton.Text = "バージョングループ";
        VersionGroupButton.UseVisualStyleBackColor = true;
        // 
        // MoveLearnMethodButton
        // 
        MoveLearnMethodButton.Location = new Point(13, 46);
        MoveLearnMethodButton.Margin = new Padding(4, 3, 4, 3);
        MoveLearnMethodButton.Name = "MoveLearnMethodButton";
        MoveLearnMethodButton.Size = new Size(116, 28);
        MoveLearnMethodButton.TabIndex = 2;
        MoveLearnMethodButton.Text = "技の習得方法";
        MoveLearnMethodButton.UseVisualStyleBackColor = true;
        // 
        // MoveLearnMethodTextBox
        // 
        MoveLearnMethodTextBox.Location = new Point(138, 49);
        MoveLearnMethodTextBox.Margin = new Padding(5, 3, 5, 3);
        MoveLearnMethodTextBox.Name = "MoveLearnMethodTextBox";
        MoveLearnMethodTextBox.ReadOnly = true;
        MoveLearnMethodTextBox.Size = new Size(217, 24);
        MoveLearnMethodTextBox.TabIndex = 3;
        // 
        // LevelLearnedCaptionLabel
        // 
        LevelLearnedCaptionLabel.AutoSize = true;
        LevelLearnedCaptionLabel.Location = new Point(37, 82);
        LevelLearnedCaptionLabel.Margin = new Padding(5, 0, 5, 0);
        LevelLearnedCaptionLabel.Name = "LevelLearnedCaptionLabel";
        LevelLearnedCaptionLabel.Size = new Size(92, 17);
        LevelLearnedCaptionLabel.TabIndex = 4;
        LevelLearnedCaptionLabel.Text = "習得最低レベル";
        LevelLearnedCaptionLabel.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // LevelLearnedAtTextBox
        // 
        LevelLearnedAtTextBox.Location = new Point(138, 79);
        LevelLearnedAtTextBox.Margin = new Padding(5, 3, 5, 3);
        LevelLearnedAtTextBox.Name = "LevelLearnedAtTextBox";
        LevelLearnedAtTextBox.ReadOnly = true;
        LevelLearnedAtTextBox.Size = new Size(217, 24);
        LevelLearnedAtTextBox.TabIndex = 5;
        // 
        // PropertyButton
        // 
        PropertyButton.Location = new Point(195, 109);
        PropertyButton.Margin = new Padding(4, 3, 4, 3);
        PropertyButton.Name = "PropertyButton";
        PropertyButton.Size = new Size(76, 35);
        PropertyButton.TabIndex = 6;
        PropertyButton.Text = "プロパティ";
        PropertyButton.UseVisualStyleBackColor = true;
        // 
        // CloseButton
        // 
        CloseButton.Location = new Point(279, 109);
        CloseButton.Margin = new Padding(4, 3, 4, 3);
        CloseButton.Name = "CloseButton";
        CloseButton.Size = new Size(76, 35);
        CloseButton.TabIndex = 7;
        CloseButton.Text = "閉じる";
        CloseButton.UseVisualStyleBackColor = true;
        // 
        // PokemonMoveVersionInfoForm
        // 
        AutoScaleDimensions = new SizeF(9F, 17F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(374, 157);
        Controls.Add(PropertyButton);
        Controls.Add(CloseButton);
        Controls.Add(LevelLearnedAtTextBox);
        Controls.Add(LevelLearnedCaptionLabel);
        Controls.Add(MoveLearnMethodTextBox);
        Controls.Add(MoveLearnMethodButton);
        Controls.Add(VersionGroupTextBox);
        Controls.Add(VersionGroupButton);
        Font = new Font("Meiryo UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 128);
        FormBorderStyle = FormBorderStyle.FixedDialog;
        Margin = new Padding(4, 3, 4, 3);
        MaximizeBox = false;
        Name = "PokemonMoveVersionInfoForm";
        StartPosition = FormStartPosition.CenterParent;
        Text = "ポケモンの技";
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private TextBox VersionGroupTextBox;
    private Button VersionGroupButton;
    private Button MoveLearnMethodButton;
    private TextBox MoveLearnMethodTextBox;
    private Label LevelLearnedCaptionLabel;
    private TextBox LevelLearnedAtTextBox;
    private Button PropertyButton;
    private Button CloseButton;
}