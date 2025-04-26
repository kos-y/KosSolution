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
        GenerationCaptionLabel = new Label();
        GameIndexCaptionLabel = new Label();
        GameIndexTextBox = new TextBox();
        GenerationDetailButton = new Button();
        CloseButton = new Button();
        SuspendLayout();
        // 
        // GenerationTextBox
        // 
        GenerationTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        GenerationTextBox.Location = new Point(146, 6);
        GenerationTextBox.Name = "GenerationTextBox";
        GenerationTextBox.ReadOnly = true;
        GenerationTextBox.Size = new Size(142, 24);
        GenerationTextBox.TabIndex = 1;
        GenerationTextBox.Text = "generation-iii";
        // 
        // GenerationCaptionLabel
        // 
        GenerationCaptionLabel.AutoSize = true;
        GenerationCaptionLabel.Font = new Font("Meiryo UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 128);
        GenerationCaptionLabel.Location = new Point(106, 9);
        GenerationCaptionLabel.Name = "GenerationCaptionLabel";
        GenerationCaptionLabel.Size = new Size(34, 17);
        GenerationCaptionLabel.TabIndex = 0;
        GenerationCaptionLabel.Text = "世代";
        // 
        // GameIndexCaptionLabel
        // 
        GameIndexCaptionLabel.AutoSize = true;
        GameIndexCaptionLabel.Font = new Font("Meiryo UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 128);
        GameIndexCaptionLabel.Location = new Point(12, 39);
        GameIndexCaptionLabel.Name = "GameIndexCaptionLabel";
        GameIndexCaptionLabel.Size = new Size(128, 17);
        GameIndexCaptionLabel.TabIndex = 3;
        GameIndexCaptionLabel.Text = "ゲーム上のインデックス";
        // 
        // GameIndexTextBox
        // 
        GameIndexTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        GameIndexTextBox.Location = new Point(146, 36);
        GameIndexTextBox.Name = "GameIndexTextBox";
        GameIndexTextBox.ReadOnly = true;
        GameIndexTextBox.Size = new Size(198, 24);
        GameIndexTextBox.TabIndex = 4;
        GameIndexTextBox.Text = "99999";
        // 
        // GenerationDetailButton
        // 
        GenerationDetailButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
        GenerationDetailButton.Location = new Point(294, 6);
        GenerationDetailButton.Name = "GenerationDetailButton";
        GenerationDetailButton.Size = new Size(53, 23);
        GenerationDetailButton.TabIndex = 2;
        GenerationDetailButton.Text = "詳細";
        GenerationDetailButton.UseVisualStyleBackColor = true;
        GenerationDetailButton.Click += GenerationDetailButton_Click;
        // 
        // CloseButton
        // 
        CloseButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
        CloseButton.Location = new Point(281, 67);
        CloseButton.Name = "CloseButton";
        CloseButton.Size = new Size(63, 35);
        CloseButton.TabIndex = 5;
        CloseButton.Text = "閉じる";
        CloseButton.UseVisualStyleBackColor = true;
        CloseButton.Click += CloseButton_Click;
        // 
        // GenerationGameIndexInfoForm
        // 
        AutoScaleDimensions = new SizeF(9F, 17F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(356, 114);
        Controls.Add(CloseButton);
        Controls.Add(GenerationDetailButton);
        Controls.Add(GameIndexTextBox);
        Controls.Add(GameIndexCaptionLabel);
        Controls.Add(GenerationCaptionLabel);
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
    private Label GenerationCaptionLabel;
    private Label GameIndexCaptionLabel;
    private TextBox GameIndexTextBox;
    private Button GenerationDetailButton;
    private Button CloseButton;
}