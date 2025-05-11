namespace Kos.PokeAPI.Forms;

partial class MoveFlavorTextInfoForm
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
        VersionGroupButton = new Button();
        VersionGroupTextBox = new TextBox();
        LanguageTextBox = new TextBox();
        LanguageButton = new Button();
        FlavorTextCaptionLabel = new Label();
        FlavorTextTextBox = new TextBox();
        CloseButton = new Button();
        PropertyGrid = new Button();
        SuspendLayout();
        // 
        // VersionGroupButton
        // 
        VersionGroupButton.Location = new Point(13, 10);
        VersionGroupButton.Margin = new Padding(4, 3, 4, 3);
        VersionGroupButton.Name = "VersionGroupButton";
        VersionGroupButton.Size = new Size(113, 27);
        VersionGroupButton.TabIndex = 0;
        VersionGroupButton.Text = "バージョングループ";
        VersionGroupButton.UseVisualStyleBackColor = true;
        VersionGroupButton.Click += VersionGroupButton_Click;
        // 
        // VersionGroupTextBox
        // 
        VersionGroupTextBox.Location = new Point(133, 12);
        VersionGroupTextBox.Name = "VersionGroupTextBox";
        VersionGroupTextBox.ReadOnly = true;
        VersionGroupTextBox.Size = new Size(191, 24);
        VersionGroupTextBox.TabIndex = 1;
        // 
        // LanguageTextBox
        // 
        LanguageTextBox.Location = new Point(133, 42);
        LanguageTextBox.Name = "LanguageTextBox";
        LanguageTextBox.ReadOnly = true;
        LanguageTextBox.Size = new Size(191, 24);
        LanguageTextBox.TabIndex = 3;
        // 
        // LanguageButton
        // 
        LanguageButton.Location = new Point(13, 40);
        LanguageButton.Margin = new Padding(4, 3, 4, 3);
        LanguageButton.Name = "LanguageButton";
        LanguageButton.Size = new Size(113, 27);
        LanguageButton.TabIndex = 2;
        LanguageButton.Text = "言語";
        LanguageButton.UseVisualStyleBackColor = true;
        LanguageButton.Click += LanguageButton_Click;
        // 
        // FlavorTextCaptionLabel
        // 
        FlavorTextCaptionLabel.AutoSize = true;
        FlavorTextCaptionLabel.Location = new Point(13, 79);
        FlavorTextCaptionLabel.Margin = new Padding(4, 0, 4, 0);
        FlavorTextCaptionLabel.Name = "FlavorTextCaptionLabel";
        FlavorTextCaptionLabel.Size = new Size(103, 17);
        FlavorTextCaptionLabel.TabIndex = 4;
        FlavorTextCaptionLabel.Text = "フレーバーテキスト";
        FlavorTextCaptionLabel.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // FlavorTextTextBox
        // 
        FlavorTextTextBox.Location = new Point(13, 99);
        FlavorTextTextBox.Multiline = true;
        FlavorTextTextBox.Name = "FlavorTextTextBox";
        FlavorTextTextBox.ReadOnly = true;
        FlavorTextTextBox.Size = new Size(364, 170);
        FlavorTextTextBox.TabIndex = 5;
        FlavorTextTextBox.Text = "ピカチュウ";
        // 
        // CloseButton
        // 
        CloseButton.Location = new Point(301, 275);
        CloseButton.Name = "CloseButton";
        CloseButton.Size = new Size(76, 35);
        CloseButton.TabIndex = 7;
        CloseButton.Text = "閉じる";
        CloseButton.UseVisualStyleBackColor = true;
        CloseButton.Click += CloseButton_Click;
        // 
        // PropertyGrid
        // 
        PropertyGrid.Location = new Point(219, 275);
        PropertyGrid.Name = "PropertyGrid";
        PropertyGrid.Size = new Size(76, 35);
        PropertyGrid.TabIndex = 6;
        PropertyGrid.Text = "プロパティ";
        PropertyGrid.UseVisualStyleBackColor = true;
        PropertyGrid.Click += PropertyGrid_Click;
        // 
        // MoveFlavorTextInfoForm
        // 
        AutoScaleDimensions = new SizeF(9F, 17F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(397, 322);
        Controls.Add(PropertyGrid);
        Controls.Add(CloseButton);
        Controls.Add(FlavorTextTextBox);
        Controls.Add(FlavorTextCaptionLabel);
        Controls.Add(LanguageButton);
        Controls.Add(LanguageTextBox);
        Controls.Add(VersionGroupButton);
        Controls.Add(VersionGroupTextBox);
        Font = new Font("Meiryo UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 128);
        FormBorderStyle = FormBorderStyle.FixedSingle;
        Margin = new Padding(4, 3, 4, 3);
        MaximizeBox = false;
        Name = "MoveFlavorTextInfoForm";
        StartPosition = FormStartPosition.CenterParent;
        Text = "技のフレーバーテキスト";
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private Button VersionGroupButton;
    private TextBox VersionGroupTextBox;
    private TextBox LanguageTextBox;
    private Button LanguageButton;
    private Label FlavorTextCaptionLabel;
    private TextBox FlavorTextTextBox;
    private Button CloseButton;
    private Button PropertyGrid;
}