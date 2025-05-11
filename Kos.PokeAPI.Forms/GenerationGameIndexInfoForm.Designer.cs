namespace Kos.PokeAPI.Forms;

partial class GenerationGameIndexInfoForm
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
        GenerationTextBox = new TextBox();
        GameIndexCaptionLabel = new Label();
        GameIndexTextBox = new TextBox();
        GenerationButton = new Button();
        CloseButton = new Button();
        PropertyButton = new Button();
        SuspendLayout();
        // 
        // GenerationTextBox
        // 
        GenerationTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        GenerationTextBox.Location = new Point(146, 12);
        GenerationTextBox.Name = "GenerationTextBox";
        GenerationTextBox.ReadOnly = true;
        GenerationTextBox.Size = new Size(198, 24);
        GenerationTextBox.TabIndex = 1;
        GenerationTextBox.Text = "generation-iii";
        // 
        // GameIndexCaptionLabel
        // 
        GameIndexCaptionLabel.AutoSize = true;
        GameIndexCaptionLabel.Font = new Font("Meiryo UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 128);
        GameIndexCaptionLabel.Location = new Point(12, 45);
        GameIndexCaptionLabel.Name = "GameIndexCaptionLabel";
        GameIndexCaptionLabel.Size = new Size(128, 17);
        GameIndexCaptionLabel.TabIndex = 2;
        GameIndexCaptionLabel.Text = "ゲーム上のインデックス";
        // 
        // GameIndexTextBox
        // 
        GameIndexTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        GameIndexTextBox.Location = new Point(146, 42);
        GameIndexTextBox.Name = "GameIndexTextBox";
        GameIndexTextBox.ReadOnly = true;
        GameIndexTextBox.Size = new Size(198, 24);
        GameIndexTextBox.TabIndex = 3;
        GameIndexTextBox.Text = "99999";
        // 
        // GenerationButton
        // 
        GenerationButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
        GenerationButton.Location = new Point(12, 12);
        GenerationButton.Name = "GenerationButton";
        GenerationButton.Size = new Size(128, 30);
        GenerationButton.TabIndex = 0;
        GenerationButton.Text = "世代";
        GenerationButton.UseVisualStyleBackColor = true;
        GenerationButton.Click += GenerationButton_Click;
        // 
        // CloseButton
        // 
        CloseButton.Location = new Point(268, 77);
        CloseButton.Name = "CloseButton";
        CloseButton.Size = new Size(76, 35);
        CloseButton.TabIndex = 5;
        CloseButton.Text = "閉じる";
        CloseButton.UseVisualStyleBackColor = true;
        CloseButton.Click += CloseButton_Click;
        // 
        // PropertyButton
        // 
        PropertyButton.Location = new Point(186, 77);
        PropertyButton.Name = "PropertyButton";
        PropertyButton.Size = new Size(76, 35);
        PropertyButton.TabIndex = 4;
        PropertyButton.Text = "プロパティ";
        PropertyButton.UseVisualStyleBackColor = true;
        PropertyButton.Click += PropertyButton_Click;
        // 
        // GenerationGameIndexInfoForm
        // 
        AutoScaleDimensions = new SizeF(9F, 17F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(356, 119);
        Controls.Add(PropertyButton);
        Controls.Add(CloseButton);
        Controls.Add(GenerationButton);
        Controls.Add(GameIndexTextBox);
        Controls.Add(GameIndexCaptionLabel);
        Controls.Add(GenerationTextBox);
        Font = new Font("Meiryo UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 128);
        Margin = new Padding(4, 3, 4, 3);
        MaximizeBox = false;
        Name = "GenerationGameIndexInfoForm";
        StartPosition = FormStartPosition.CenterParent;
        Text = "世代ごとのゲームインデックス";
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private TextBox GenerationTextBox;
    private Label GameIndexCaptionLabel;
    private TextBox GameIndexTextBox;
    private Button GenerationButton;
    private Button CloseButton;
    private Button PropertyButton;
}