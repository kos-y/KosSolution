namespace AppPokeAPIViewer;

partial class PokeAPIViewer
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
        ResourceCategoryListBox = new ListBox();
        EndPointListBox = new ListBox();
        CloseButton = new Button();
        OpenButton = new Button();
        SuspendLayout();
        // 
        // ResourceCategoryListBox
        // 
        ResourceCategoryListBox.FormattingEnabled = true;
        ResourceCategoryListBox.ItemHeight = 15;
        ResourceCategoryListBox.Location = new Point(12, 12);
        ResourceCategoryListBox.Name = "ResourceCategoryListBox";
        ResourceCategoryListBox.Size = new Size(170, 289);
        ResourceCategoryListBox.TabIndex = 0;
        ResourceCategoryListBox.SelectedIndexChanged += ResourceCategoryListBox_SelectedIndexChanged;
        // 
        // EndPointListBox
        // 
        EndPointListBox.FormattingEnabled = true;
        EndPointListBox.ItemHeight = 15;
        EndPointListBox.Location = new Point(188, 12);
        EndPointListBox.Name = "EndPointListBox";
        EndPointListBox.Size = new Size(170, 289);
        EndPointListBox.TabIndex = 1;
        EndPointListBox.DoubleClick += EndPointListBox_DoubleClick;
        // 
        // CloseButton
        // 
        CloseButton.Location = new Point(283, 307);
        CloseButton.Name = "CloseButton";
        CloseButton.Size = new Size(75, 31);
        CloseButton.TabIndex = 3;
        CloseButton.Text = "閉じる";
        CloseButton.UseVisualStyleBackColor = true;
        CloseButton.Click += CloseButton_Click;
        // 
        // OpenButton
        // 
        OpenButton.Location = new Point(12, 307);
        OpenButton.Name = "OpenButton";
        OpenButton.Size = new Size(75, 31);
        OpenButton.TabIndex = 2;
        OpenButton.Text = "開く";
        OpenButton.UseVisualStyleBackColor = true;
        OpenButton.Click += OpenButton_Click;
        // 
        // PokeAPIViewer
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(372, 350);
        Controls.Add(OpenButton);
        Controls.Add(CloseButton);
        Controls.Add(EndPointListBox);
        Controls.Add(ResourceCategoryListBox);
        FormBorderStyle = FormBorderStyle.FixedDialog;
        MaximizeBox = false;
        Name = "PokeAPIViewer";
        Text = "PokeAPI Viewer";
        FormClosing += PokeAPIViewer_FormClosing;
        Load += PokeAPIViewer_Load;
        ResumeLayout(false);
    }

    #endregion

    private ListBox ResourceCategoryListBox;
    private ListBox EndPointListBox;
    private Button CloseButton;
    private Button OpenButton;
}
