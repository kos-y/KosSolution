namespace Kos.PokeAPI.Forms.Utility.CommonModels;

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
        VersionGroupButton.Location = new Point(10, 11);
        VersionGroupButton.Name = "VersionGroupButton";
        VersionGroupButton.Size = new Size(96, 24);
        VersionGroupButton.TabIndex = 0;
        VersionGroupButton.Text = "バージョングループ";
        VersionGroupButton.UseVisualStyleBackColor = true;
        VersionGroupButton.Click += VersionGroupButton_Click;
        // 
        // VersionGroupTextBox
        // 
        VersionGroupTextBox.Location = new Point(10, 40);
        VersionGroupTextBox.Margin = new Padding(2, 3, 2, 3);
        VersionGroupTextBox.Name = "VersionGroupTextBox";
        VersionGroupTextBox.ReadOnly = true;
        VersionGroupTextBox.Size = new Size(149, 23);
        VersionGroupTextBox.TabIndex = 1;
        // 
        // MachineButton
        // 
        MachineButton.Location = new Point(10, 66);
        MachineButton.Name = "MachineButton";
        MachineButton.Size = new Size(57, 24);
        MachineButton.TabIndex = 2;
        MachineButton.Text = "技マシン";
        MachineButton.UseVisualStyleBackColor = true;
        MachineButton.Click += MachineButton_Click;
        // 
        // CloseButton
        // 
        CloseButton.Location = new Point(100, 95);
        CloseButton.Name = "CloseButton";
        CloseButton.Size = new Size(59, 31);
        CloseButton.TabIndex = 4;
        CloseButton.Text = "閉じる";
        CloseButton.UseVisualStyleBackColor = true;
        CloseButton.Click += CloseButton_Click;
        // 
        // PropertyButton
        // 
        PropertyButton.Location = new Point(34, 95);
        PropertyButton.Name = "PropertyButton";
        PropertyButton.Size = new Size(59, 31);
        PropertyButton.TabIndex = 3;
        PropertyButton.Text = "プロパティ";
        PropertyButton.UseVisualStyleBackColor = true;
        PropertyButton.Click += PropertyButton_Click;
        // 
        // MachineVersionDetailInfoForm
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(175, 140);
        Controls.Add(PropertyButton);
        Controls.Add(CloseButton);
        Controls.Add(MachineButton);
        Controls.Add(VersionGroupButton);
        Controls.Add(VersionGroupTextBox);
        FormBorderStyle = FormBorderStyle.FixedSingle;
        MaximizeBox = false;
        Name = "MachineVersionDetailInfoForm";
        StartPosition = FormStartPosition.CenterParent;
        Text = "技マシン";
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