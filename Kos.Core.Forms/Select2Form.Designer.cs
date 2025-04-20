namespace Kos.Core.Forms;

partial class Select2Form
{
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
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
    ///  Required method for Designer support - do not modify
    ///  the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        Select1Button = new Button();
        Select2Button = new Button();
        SuspendLayout();
        // 
        // Select1Button
        // 
        Select1Button.Location = new Point(47, 30);
        Select1Button.Name = "Select1Button";
        Select1Button.Size = new Size(255, 60);
        Select1Button.TabIndex = 0;
        Select1Button.Text = "Select1";
        Select1Button.UseVisualStyleBackColor = true;
        Select1Button.Click += Select1Button_Click;
        // 
        // Select2Button
        // 
        Select2Button.Location = new Point(47, 117);
        Select2Button.Name = "Select2Button";
        Select2Button.Size = new Size(255, 60);
        Select2Button.TabIndex = 1;
        Select2Button.Text = "Select2";
        Select2Button.UseVisualStyleBackColor = true;
        Select2Button.Click += Select2Button_Click;
        // 
        // Select2Form
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(351, 218);
        Controls.Add(Select2Button);
        Controls.Add(Select1Button);
        MaximizeBox = false;
        Name = "Select2Form";
        Text = "選択";
        Load += Select2Form_Load;
        ResumeLayout(false);
    }

    #endregion

    private Button Select1Button;
    private Button Select2Button;
}
