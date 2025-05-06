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
        ItemCaptionLabel = new Label();
        IdCaptionLabel = new Label();
        MoveTextBox = new TextBox();
        MoveCaptionLabel = new Label();
        VersionGroupTextBox = new TextBox();
        VersionGroupCaptionLabel = new Label();
        MoveDetailButton = new Button();
        VersionGroupDetailButton = new Button();
        CloseButton = new Button();
        ItemDetailButton = new Button();
        SuspendLayout();
        // 
        // ItemTextBox
        // 
        ItemTextBox.Location = new Point(124, 42);
        ItemTextBox.Name = "ItemTextBox";
        ItemTextBox.ReadOnly = true;
        ItemTextBox.Size = new Size(191, 24);
        ItemTextBox.TabIndex = 3;
        // 
        // IdTextBox
        // 
        IdTextBox.Location = new Point(124, 12);
        IdTextBox.Name = "IdTextBox";
        IdTextBox.ReadOnly = true;
        IdTextBox.Size = new Size(191, 24);
        IdTextBox.TabIndex = 1;
        // 
        // ItemCaptionLabel
        // 
        ItemCaptionLabel.AutoSize = true;
        ItemCaptionLabel.Location = new Point(66, 45);
        ItemCaptionLabel.Margin = new Padding(4, 0, 4, 0);
        ItemCaptionLabel.Name = "ItemCaptionLabel";
        ItemCaptionLabel.Size = new Size(51, 17);
        ItemCaptionLabel.TabIndex = 2;
        ItemCaptionLabel.Text = "アイテム";
        ItemCaptionLabel.TextAlign = ContentAlignment.MiddleLeft;
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
        MoveTextBox.Location = new Point(124, 72);
        MoveTextBox.Name = "MoveTextBox";
        MoveTextBox.ReadOnly = true;
        MoveTextBox.Size = new Size(191, 24);
        MoveTextBox.TabIndex = 6;
        // 
        // MoveCaptionLabel
        // 
        MoveCaptionLabel.AutoSize = true;
        MoveCaptionLabel.Location = new Point(96, 75);
        MoveCaptionLabel.Margin = new Padding(4, 0, 4, 0);
        MoveCaptionLabel.Name = "MoveCaptionLabel";
        MoveCaptionLabel.Size = new Size(21, 17);
        MoveCaptionLabel.TabIndex = 5;
        MoveCaptionLabel.Text = "技";
        MoveCaptionLabel.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // VersionGroupTextBox
        // 
        VersionGroupTextBox.Location = new Point(124, 102);
        VersionGroupTextBox.Name = "VersionGroupTextBox";
        VersionGroupTextBox.ReadOnly = true;
        VersionGroupTextBox.Size = new Size(191, 24);
        VersionGroupTextBox.TabIndex = 9;
        // 
        // VersionGroupCaptionLabel
        // 
        VersionGroupCaptionLabel.AutoSize = true;
        VersionGroupCaptionLabel.Location = new Point(13, 105);
        VersionGroupCaptionLabel.Margin = new Padding(4, 0, 4, 0);
        VersionGroupCaptionLabel.Name = "VersionGroupCaptionLabel";
        VersionGroupCaptionLabel.Size = new Size(104, 17);
        VersionGroupCaptionLabel.TabIndex = 8;
        VersionGroupCaptionLabel.Text = "バージョングループ";
        VersionGroupCaptionLabel.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // MoveDetailButton
        // 
        MoveDetailButton.Location = new Point(322, 70);
        MoveDetailButton.Margin = new Padding(4, 3, 4, 3);
        MoveDetailButton.Name = "MoveDetailButton";
        MoveDetailButton.Size = new Size(55, 27);
        MoveDetailButton.TabIndex = 7;
        MoveDetailButton.Text = "詳細";
        MoveDetailButton.UseVisualStyleBackColor = true;
        MoveDetailButton.Click += MoveDetailButton_Click;
        // 
        // VersionGroupDetailButton
        // 
        VersionGroupDetailButton.Location = new Point(322, 100);
        VersionGroupDetailButton.Margin = new Padding(4, 3, 4, 3);
        VersionGroupDetailButton.Name = "VersionGroupDetailButton";
        VersionGroupDetailButton.Size = new Size(55, 27);
        VersionGroupDetailButton.TabIndex = 10;
        VersionGroupDetailButton.Text = "詳細";
        VersionGroupDetailButton.UseVisualStyleBackColor = true;
        VersionGroupDetailButton.Click += VersionGroupDetailButton_Click;
        // 
        // CloseButton
        // 
        CloseButton.Location = new Point(295, 133);
        CloseButton.Margin = new Padding(4, 3, 4, 3);
        CloseButton.Name = "CloseButton";
        CloseButton.Size = new Size(82, 40);
        CloseButton.TabIndex = 11;
        CloseButton.Text = "閉じる";
        CloseButton.UseVisualStyleBackColor = true;
        CloseButton.Click += CloseButton_Click;
        // 
        // ItemDetailButton
        // 
        ItemDetailButton.Location = new Point(322, 40);
        ItemDetailButton.Margin = new Padding(4, 3, 4, 3);
        ItemDetailButton.Name = "ItemDetailButton";
        ItemDetailButton.Size = new Size(55, 27);
        ItemDetailButton.TabIndex = 4;
        ItemDetailButton.Text = "詳細";
        ItemDetailButton.UseVisualStyleBackColor = true;
        ItemDetailButton.Click += ItemDetailButton_Click;
        // 
        // MachineInfoForm
        // 
        AutoScaleDimensions = new SizeF(9F, 17F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(396, 182);
        Controls.Add(ItemDetailButton);
        Controls.Add(CloseButton);
        Controls.Add(VersionGroupDetailButton);
        Controls.Add(MoveDetailButton);
        Controls.Add(VersionGroupCaptionLabel);
        Controls.Add(VersionGroupTextBox);
        Controls.Add(MoveCaptionLabel);
        Controls.Add(MoveTextBox);
        Controls.Add(ItemTextBox);
        Controls.Add(IdTextBox);
        Controls.Add(ItemCaptionLabel);
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
    private Label MoveCaptionLabel;
    private TextBox VersionGroupTextBox;
    private Label VersionGroupCaptionLabel;
    private Button MoveDetailButton;
    private Button VersionGroupDetailButton;
    private Button CloseButton;
    private Button ItemDetailButton;
}