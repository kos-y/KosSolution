namespace Kos.PokeAPI.Forms;

partial class ContestComboSetsInfoForm
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
        NormalButton = new Button();
        SuperButton = new Button();
        CloseButton = new Button();
        PropertyButton = new Button();
        SuspendLayout();
        // 
        // NormalButton
        // 
        NormalButton.Location = new Point(37, 12);
        NormalButton.Name = "NormalButton";
        NormalButton.Size = new Size(169, 35);
        NormalButton.TabIndex = 0;
        NormalButton.Text = "ポケモンコンテスト";
        NormalButton.UseVisualStyleBackColor = true;
        NormalButton.Click += NormalButton_Click;
        // 
        // SuperButton
        // 
        SuperButton.Location = new Point(37, 53);
        SuperButton.Name = "SuperButton";
        SuperButton.Size = new Size(169, 35);
        SuperButton.TabIndex = 1;
        SuperButton.Text = "スーパーコンテスト";
        SuperButton.UseVisualStyleBackColor = true;
        SuperButton.Click += SuperButton_Click;
        // 
        // CloseButton
        // 
        CloseButton.Location = new Point(162, 99);
        CloseButton.Name = "CloseButton";
        CloseButton.Size = new Size(76, 35);
        CloseButton.TabIndex = 3;
        CloseButton.Text = "閉じる";
        CloseButton.UseVisualStyleBackColor = true;
        CloseButton.Click += CloseButton_Click;
        // 
        // PropertyButton
        // 
        PropertyButton.Location = new Point(80, 99);
        PropertyButton.Name = "PropertyButton";
        PropertyButton.Size = new Size(76, 35);
        PropertyButton.TabIndex = 2;
        PropertyButton.Text = "プロパティ";
        PropertyButton.UseVisualStyleBackColor = true;
        PropertyButton.Click += PropertyButton_Click;
        // 
        // ContestComboSetsInfoForm
        // 
        AutoScaleDimensions = new SizeF(9F, 17F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(250, 146);
        Controls.Add(PropertyButton);
        Controls.Add(CloseButton);
        Controls.Add(SuperButton);
        Controls.Add(NormalButton);
        Font = new Font("Meiryo UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 128);
        FormBorderStyle = FormBorderStyle.FixedSingle;
        Margin = new Padding(4, 3, 4, 3);
        MaximizeBox = false;
        Name = "ContestComboSetsInfoForm";
        StartPosition = FormStartPosition.CenterParent;
        Text = "コンテストのコンボセット";
        ResumeLayout(false);
    }

    #endregion

    private Button NormalButton;
    private Button SuperButton;
    private Button CloseButton;
    private Button PropertyButton;
}