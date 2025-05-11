namespace Kos.PokeAPI.Forms;

partial class MachineInfoForm
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
        ItemTextBox = new TextBox();
        IdTextBox = new TextBox();
        IdCaptionLabel = new Label();
        MoveTextBox = new TextBox();
        VersionGroupTextBox = new TextBox();
        MoveButton = new Button();
        VersionGroupButton = new Button();
        CloseButton = new Button();
        ItemButton = new Button();
        PropertyButton = new Button();
        SuspendLayout();
        // 
        // ItemTextBox
        // 
        ItemTextBox.Location = new Point(135, 42);
        ItemTextBox.Name = "ItemTextBox";
        ItemTextBox.ReadOnly = true;
        ItemTextBox.Size = new Size(191, 24);
        ItemTextBox.TabIndex = 3;
        // 
        // IdTextBox
        // 
        IdTextBox.Location = new Point(135, 12);
        IdTextBox.Name = "IdTextBox";
        IdTextBox.ReadOnly = true;
        IdTextBox.Size = new Size(191, 24);
        IdTextBox.TabIndex = 1;
        // 
        // IdCaptionLabel
        // 
        IdCaptionLabel.AutoSize = true;
        IdCaptionLabel.Location = new Point(48, 15);
        IdCaptionLabel.Margin = new Padding(4, 0, 4, 0);
        IdCaptionLabel.Name = "IdCaptionLabel";
        IdCaptionLabel.Size = new Size(69, 17);
        IdCaptionLabel.TabIndex = 0;
        IdCaptionLabel.Text = "技マシンID";
        IdCaptionLabel.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // MoveTextBox
        // 
        MoveTextBox.Location = new Point(135, 72);
        MoveTextBox.Name = "MoveTextBox";
        MoveTextBox.ReadOnly = true;
        MoveTextBox.Size = new Size(191, 24);
        MoveTextBox.TabIndex = 5;
        // 
        // VersionGroupTextBox
        // 
        VersionGroupTextBox.Location = new Point(135, 102);
        VersionGroupTextBox.Name = "VersionGroupTextBox";
        VersionGroupTextBox.ReadOnly = true;
        VersionGroupTextBox.Size = new Size(191, 24);
        VersionGroupTextBox.TabIndex = 7;
        // 
        // MoveButton
        // 
        MoveButton.Location = new Point(13, 70);
        MoveButton.Margin = new Padding(4, 3, 4, 3);
        MoveButton.Name = "MoveButton";
        MoveButton.Size = new Size(115, 27);
        MoveButton.TabIndex = 4;
        MoveButton.Text = "技";
        MoveButton.UseVisualStyleBackColor = true;
        MoveButton.Click += MoveButton_Click;
        // 
        // VersionGroupButton
        // 
        VersionGroupButton.Location = new Point(13, 100);
        VersionGroupButton.Margin = new Padding(4, 3, 4, 3);
        VersionGroupButton.Name = "VersionGroupButton";
        VersionGroupButton.Size = new Size(115, 27);
        VersionGroupButton.TabIndex = 6;
        VersionGroupButton.Text = "バージョングループ";
        VersionGroupButton.UseVisualStyleBackColor = true;
        VersionGroupButton.Click += VersionGroupButton_Click;
        // 
        // CloseButton
        // 
        CloseButton.Location = new Point(250, 135);
        CloseButton.Margin = new Padding(4, 3, 4, 3);
        CloseButton.Name = "CloseButton";
        CloseButton.Size = new Size(76, 35);
        CloseButton.TabIndex = 9;
        CloseButton.Text = "閉じる";
        CloseButton.UseVisualStyleBackColor = true;
        CloseButton.Click += CloseButton_Click;
        // 
        // ItemButton
        // 
        ItemButton.Location = new Point(13, 40);
        ItemButton.Margin = new Padding(4, 3, 4, 3);
        ItemButton.Name = "ItemButton";
        ItemButton.Size = new Size(115, 27);
        ItemButton.TabIndex = 2;
        ItemButton.Text = "アイテム";
        ItemButton.UseVisualStyleBackColor = true;
        ItemButton.Click += ItemButton_Click;
        // 
        // PropertyButton
        // 
        PropertyButton.Location = new Point(166, 135);
        PropertyButton.Margin = new Padding(4, 3, 4, 3);
        PropertyButton.Name = "PropertyButton";
        PropertyButton.Size = new Size(76, 35);
        PropertyButton.TabIndex = 8;
        PropertyButton.Text = "プロパティ";
        PropertyButton.UseVisualStyleBackColor = true;
        PropertyButton.Click += PropertyButton_Click;
        // 
        // MachineInfoForm
        // 
        AutoScaleDimensions = new SizeF(9F, 17F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(337, 182);
        Controls.Add(PropertyButton);
        Controls.Add(ItemButton);
        Controls.Add(CloseButton);
        Controls.Add(VersionGroupButton);
        Controls.Add(MoveButton);
        Controls.Add(VersionGroupTextBox);
        Controls.Add(MoveTextBox);
        Controls.Add(ItemTextBox);
        Controls.Add(IdTextBox);
        Controls.Add(IdCaptionLabel);
        Font = new Font("Meiryo UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 128);
        FormBorderStyle = FormBorderStyle.FixedSingle;
        Margin = new Padding(4, 3, 4, 3);
        MaximizeBox = false;
        Name = "MachineInfoForm";
        StartPosition = FormStartPosition.CenterParent;
        Text = "技マシン";
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private TextBox ItemTextBox;
    private TextBox IdTextBox;
    private Label ItemCaptionLabel;
    private Label IdCaptionLabel;
    private TextBox MoveTextBox;
    private TextBox VersionGroupTextBox;
    private Button MoveButton;
    private Button VersionGroupButton;
    private Button CloseButton;
    private Button ItemButton;
    private Button PropertyButton;
}