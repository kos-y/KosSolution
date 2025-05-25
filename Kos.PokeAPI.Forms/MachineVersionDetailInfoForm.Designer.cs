namespace Kos.PokeAPI.Forms;

partial class MachineVersionDetailInfoForm
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
        MachineButton = new Button();
        CloseButton = new Button();
        PropertyButton = new Button();
        SuspendLayout();
        // 
        // VersionGroupButton
        // 
        VersionGroupButton.Location = new Point(13, 12);
        VersionGroupButton.Margin = new Padding(4, 3, 4, 3);
        VersionGroupButton.Name = "VersionGroupButton";
        VersionGroupButton.Size = new Size(124, 27);
        VersionGroupButton.TabIndex = 0;
        VersionGroupButton.Text = "バージョングループ";
        VersionGroupButton.UseVisualStyleBackColor = true;
        VersionGroupButton.Click += VersionGroupButton_Click;
        // 
        // VersionGroupTextBox
        // 
        VersionGroupTextBox.Location = new Point(13, 45);
        VersionGroupTextBox.Name = "VersionGroupTextBox";
        VersionGroupTextBox.ReadOnly = true;
        VersionGroupTextBox.Size = new Size(191, 24);
        VersionGroupTextBox.TabIndex = 1;
        // 
        // MachineButton
        // 
        MachineButton.Location = new Point(13, 75);
        MachineButton.Margin = new Padding(4, 3, 4, 3);
        MachineButton.Name = "MachineButton";
        MachineButton.Size = new Size(66, 27);
        MachineButton.TabIndex = 2;
        MachineButton.Text = "技マシン";
        MachineButton.UseVisualStyleBackColor = true;
        MachineButton.Click += MachineButton_Click;
        // 
        // CloseButton
        // 
        CloseButton.Location = new Point(128, 108);
        CloseButton.Margin = new Padding(4, 3, 4, 3);
        CloseButton.Name = "CloseButton";
        CloseButton.Size = new Size(76, 35);
        CloseButton.TabIndex = 4;
        CloseButton.Text = "閉じる";
        CloseButton.UseVisualStyleBackColor = true;
        CloseButton.Click += CloseButton_Click;
        // 
        // PropertyButton
        // 
        PropertyButton.Location = new Point(44, 108);
        PropertyButton.Margin = new Padding(4, 3, 4, 3);
        PropertyButton.Name = "PropertyButton";
        PropertyButton.Size = new Size(76, 35);
        PropertyButton.TabIndex = 3;
        PropertyButton.Text = "プロパティ";
        PropertyButton.UseVisualStyleBackColor = true;
        PropertyButton.Click += PropertyButton_Click;
        // 
        // MachineVersionDetailInfoForm
        // 
        AutoScaleDimensions = new SizeF(9F, 17F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(225, 159);
        Controls.Add(PropertyButton);
        Controls.Add(CloseButton);
        Controls.Add(MachineButton);
        Controls.Add(VersionGroupButton);
        Controls.Add(VersionGroupTextBox);
        Font = new Font("Meiryo UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 128);
        FormBorderStyle = FormBorderStyle.FixedSingle;
        Margin = new Padding(4, 3, 4, 3);
        MaximizeBox = false;
        Name = "MachineVersionDetailInfoForm";
        StartPosition = FormStartPosition.CenterParent;
        Text = "バージョンごとの技マシン情報";
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private Button VersionGroupButton;
    private TextBox VersionGroupTextBox;
    private Button MachineButton;
    private Button CloseButton;
    private Button PropertyButton;
}