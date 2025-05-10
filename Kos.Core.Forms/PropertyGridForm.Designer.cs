namespace Kos.Core.Forms;

partial class PropertyGridForm
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
        CloseButton = new Button();
        PropertyGrid = new PropertyGrid();
        SuspendLayout();
        // 
        // CloseButton
        // 
        CloseButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
        CloseButton.Location = new Point(939, 463);
        CloseButton.Margin = new Padding(5, 3, 5, 3);
        CloseButton.Name = "CloseButton";
        CloseButton.Size = new Size(76, 35);
        CloseButton.TabIndex = 1;
        CloseButton.Text = "閉じる";
        CloseButton.UseVisualStyleBackColor = true;
        CloseButton.Click += CloseButton_Click;
        // 
        // PropertyGrid
        // 
        PropertyGrid.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
        PropertyGrid.CommandsVisibleIfAvailable = false;
        PropertyGrid.Location = new Point(12, 12);
        PropertyGrid.Name = "PropertyGrid";
        PropertyGrid.Size = new Size(1005, 445);
        PropertyGrid.TabIndex = 0;
        // 
        // PropertyGridForm
        // 
        AutoScaleDimensions = new SizeF(9F, 17F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(1029, 510);
        Controls.Add(PropertyGrid);
        Controls.Add(CloseButton);
        Font = new Font("Meiryo UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 128);
        Margin = new Padding(4, 3, 4, 3);
        Name = "PropertyGridForm";
        StartPosition = FormStartPosition.CenterParent;
        Text = "プロパティ情報";
        ResumeLayout(false);
    }

    #endregion

    private Button CloseButton;
    private PropertyGrid PropertyGrid;
}