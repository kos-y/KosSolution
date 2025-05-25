namespace Kos.PokeAPI.Forms.Utility.CommonModels;

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
        GenerationTextBox.Location = new Point(75, 15);
        GenerationTextBox.Margin = new Padding(2, 3, 2, 3);
        GenerationTextBox.Name = "GenerationTextBox";
        GenerationTextBox.ReadOnly = true;
        GenerationTextBox.Size = new Size(155, 23);
        GenerationTextBox.TabIndex = 1;
        GenerationTextBox.Text = "generation-iii";
        // 
        // GameIndexCaptionLabel
        // 
        GameIndexCaptionLabel.AutoSize = true;
        GameIndexCaptionLabel.Location = new Point(11, 47);
        GameIndexCaptionLabel.Margin = new Padding(2, 0, 2, 0);
        GameIndexCaptionLabel.Name = "GameIndexCaptionLabel";
        GameIndexCaptionLabel.Size = new Size(60, 15);
        GameIndexCaptionLabel.TabIndex = 2;
        GameIndexCaptionLabel.Text = "インデックス";
        // 
        // GameIndexTextBox
        // 
        GameIndexTextBox.Location = new Point(75, 44);
        GameIndexTextBox.Margin = new Padding(2, 3, 2, 3);
        GameIndexTextBox.Name = "GameIndexTextBox";
        GameIndexTextBox.ReadOnly = true;
        GameIndexTextBox.Size = new Size(155, 23);
        GameIndexTextBox.TabIndex = 3;
        GameIndexTextBox.Text = "99999";
        // 
        // GenerationButton
        // 
        GenerationButton.Location = new Point(11, 12);
        GenerationButton.Margin = new Padding(2, 3, 2, 3);
        GenerationButton.Name = "GenerationButton";
        GenerationButton.Size = new Size(60, 26);
        GenerationButton.TabIndex = 0;
        GenerationButton.Text = "世代";
        GenerationButton.UseVisualStyleBackColor = true;
        GenerationButton.Click += GenerationButton_Click;
        // 
        // CloseButton
        // 
        CloseButton.Location = new Point(171, 73);
        CloseButton.Margin = new Padding(2, 3, 2, 3);
        CloseButton.Name = "CloseButton";
        CloseButton.Size = new Size(59, 31);
        CloseButton.TabIndex = 5;
        CloseButton.Text = "閉じる";
        CloseButton.UseVisualStyleBackColor = true;
        CloseButton.Click += CloseButton_Click;
        // 
        // PropertyButton
        // 
        PropertyButton.Location = new Point(108, 73);
        PropertyButton.Margin = new Padding(2, 3, 2, 3);
        PropertyButton.Name = "PropertyButton";
        PropertyButton.Size = new Size(59, 31);
        PropertyButton.TabIndex = 4;
        PropertyButton.Text = "プロパティ";
        PropertyButton.UseVisualStyleBackColor = true;
        PropertyButton.Click += PropertyButton_Click;
        // 
        // GenerationGameIndexInfoForm
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(241, 110);
        Controls.Add(PropertyButton);
        Controls.Add(CloseButton);
        Controls.Add(GenerationButton);
        Controls.Add(GameIndexTextBox);
        Controls.Add(GameIndexCaptionLabel);
        Controls.Add(GenerationTextBox);
        MaximizeBox = false;
        Name = "GenerationGameIndexInfoForm";
        StartPosition = FormStartPosition.CenterParent;
        Text = "ゲームインデックス";
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