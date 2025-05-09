﻿namespace Kos.Core.Forms;

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
        Select1Button.Location = new Point(60, 34);
        Select1Button.Margin = new Padding(4, 3, 4, 3);
        Select1Button.Name = "Select1Button";
        Select1Button.Size = new Size(174, 53);
        Select1Button.TabIndex = 0;
        Select1Button.Text = "Select1";
        Select1Button.UseVisualStyleBackColor = true;
        Select1Button.Click += Select1Button_Click;
        // 
        // Select2Button
        // 
        Select2Button.Location = new Point(60, 118);
        Select2Button.Margin = new Padding(4, 3, 4, 3);
        Select2Button.Name = "Select2Button";
        Select2Button.Size = new Size(174, 53);
        Select2Button.TabIndex = 1;
        Select2Button.Text = "Select2";
        Select2Button.UseVisualStyleBackColor = true;
        Select2Button.Click += Select2Button_Click;
        // 
        // Select2Form
        // 
        AutoScaleDimensions = new SizeF(9F, 17F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(278, 212);
        Controls.Add(Select2Button);
        Controls.Add(Select1Button);
        Font = new Font("Meiryo UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 128);
        Margin = new Padding(4, 3, 4, 3);
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
