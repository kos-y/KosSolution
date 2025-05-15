namespace Kos.PokeAPI.Forms;

partial class MoveBattleStylePreferenceInfoForm
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
        MoveBattleStyleButton = new Button();
        MoveBattleStyleTextBox = new TextBox();
        groupBox1 = new GroupBox();
        LowHPPreferenceCaptionLabel = new Label();
        LowHPPreferenceTextBox = new TextBox();
        HighHPPreferenceCaptionLabel = new Label();
        HighHPPreferenceTextBox = new TextBox();
        PropertyButton = new Button();
        CloseButton = new Button();
        groupBox1.SuspendLayout();
        SuspendLayout();
        // 
        // MoveBattleStyleButton
        // 
        MoveBattleStyleButton.Location = new Point(12, 12);
        MoveBattleStyleButton.Name = "MoveBattleStyleButton";
        MoveBattleStyleButton.Size = new Size(89, 24);
        MoveBattleStyleButton.TabIndex = 0;
        MoveBattleStyleButton.Text = "戦闘スタイル";
        MoveBattleStyleButton.UseVisualStyleBackColor = true;
        MoveBattleStyleButton.Click += MoveBattleStyleButton_Click;
        // 
        // MoveBattleStyleTextBox
        // 
        MoveBattleStyleTextBox.Location = new Point(107, 13);
        MoveBattleStyleTextBox.Name = "MoveBattleStyleTextBox";
        MoveBattleStyleTextBox.ReadOnly = true;
        MoveBattleStyleTextBox.Size = new Size(167, 24);
        MoveBattleStyleTextBox.TabIndex = 1;
        // 
        // groupBox1
        // 
        groupBox1.Controls.Add(LowHPPreferenceCaptionLabel);
        groupBox1.Controls.Add(LowHPPreferenceTextBox);
        groupBox1.Controls.Add(HighHPPreferenceCaptionLabel);
        groupBox1.Controls.Add(HighHPPreferenceTextBox);
        groupBox1.Location = new Point(12, 42);
        groupBox1.Name = "groupBox1";
        groupBox1.Size = new Size(284, 90);
        groupBox1.TabIndex = 2;
        groupBox1.TabStop = false;
        groupBox1.Text = "どのぐらい好まれるか";
        // 
        // LowHPPreferenceCaptionLabel
        // 
        LowHPPreferenceCaptionLabel.AutoSize = true;
        LowHPPreferenceCaptionLabel.Location = new Point(6, 56);
        LowHPPreferenceCaptionLabel.Name = "LowHPPreferenceCaptionLabel";
        LowHPPreferenceCaptionLabel.Size = new Size(89, 17);
        LowHPPreferenceCaptionLabel.TabIndex = 2;
        LowHPPreferenceCaptionLabel.Text = "HPが低い状態";
        // 
        // LowHPPreferenceTextBox
        // 
        LowHPPreferenceTextBox.Location = new Point(101, 53);
        LowHPPreferenceTextBox.Name = "LowHPPreferenceTextBox";
        LowHPPreferenceTextBox.ReadOnly = true;
        LowHPPreferenceTextBox.Size = new Size(167, 24);
        LowHPPreferenceTextBox.TabIndex = 3;
        // 
        // HighHPPreferenceCaptionLabel
        // 
        HighHPPreferenceCaptionLabel.AutoSize = true;
        HighHPPreferenceCaptionLabel.Location = new Point(6, 26);
        HighHPPreferenceCaptionLabel.Name = "HighHPPreferenceCaptionLabel";
        HighHPPreferenceCaptionLabel.Size = new Size(89, 17);
        HighHPPreferenceCaptionLabel.TabIndex = 0;
        HighHPPreferenceCaptionLabel.Text = "HPが高い状態";
        // 
        // HighHPPreferenceTextBox
        // 
        HighHPPreferenceTextBox.Location = new Point(101, 23);
        HighHPPreferenceTextBox.Name = "HighHPPreferenceTextBox";
        HighHPPreferenceTextBox.ReadOnly = true;
        HighHPPreferenceTextBox.Size = new Size(167, 24);
        HighHPPreferenceTextBox.TabIndex = 1;
        // 
        // PropertyButton
        // 
        PropertyButton.Location = new Point(136, 137);
        PropertyButton.Margin = new Padding(4, 3, 4, 3);
        PropertyButton.Name = "PropertyButton";
        PropertyButton.Size = new Size(76, 35);
        PropertyButton.TabIndex = 3;
        PropertyButton.Text = "プロパティ";
        PropertyButton.UseVisualStyleBackColor = true;
        PropertyButton.Click += PropertyButton_Click;
        // 
        // CloseButton
        // 
        CloseButton.Location = new Point(220, 138);
        CloseButton.Margin = new Padding(4, 3, 4, 3);
        CloseButton.Name = "CloseButton";
        CloseButton.Size = new Size(76, 35);
        CloseButton.TabIndex = 4;
        CloseButton.Text = "閉じる";
        CloseButton.UseVisualStyleBackColor = true;
        CloseButton.Click += CloseButton_Click;
        // 
        // MoveBattleStylePreferenceInfoForm
        // 
        AutoScaleDimensions = new SizeF(9F, 17F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(306, 184);
        Controls.Add(PropertyButton);
        Controls.Add(CloseButton);
        Controls.Add(groupBox1);
        Controls.Add(MoveBattleStyleTextBox);
        Controls.Add(MoveBattleStyleButton);
        Font = new Font("Meiryo UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 128);
        FormBorderStyle = FormBorderStyle.FixedSingle;
        Margin = new Padding(4, 3, 4, 3);
        MaximizeBox = false;
        Name = "MoveBattleStylePreferenceInfoForm";
        StartPosition = FormStartPosition.CenterParent;
        Text = "性格と戦闘スタイルの関係性";
        groupBox1.ResumeLayout(false);
        groupBox1.PerformLayout();
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private Button MoveBattleStyleButton;
    private TextBox MoveBattleStyleTextBox;
    private GroupBox groupBox1;
    private TextBox HighHPPreferenceTextBox;
    private Label HighHPPreferenceCaptionLabel;
    private TextBox LowHPPreferenceTextBox;
    private Label LowHPPreferenceCaptionLabel;
    private Button PropertyButton;
    private Button CloseButton;
}