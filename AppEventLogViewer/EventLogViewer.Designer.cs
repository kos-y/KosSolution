namespace AppEventLogViewer;

partial class EventLogViewer
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
        EventLogEntriesDataGridView = new DataGridView();
        EventLogListBox = new ListBox();
        LocalComputerButton = new Button();
        ((System.ComponentModel.ISupportInitialize)EventLogEntriesDataGridView).BeginInit();
        SuspendLayout();
        // 
        // EventLogEntriesDataGridView
        // 
        EventLogEntriesDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        EventLogEntriesDataGridView.Location = new Point(132, 43);
        EventLogEntriesDataGridView.Name = "EventLogEntriesDataGridView";
        EventLogEntriesDataGridView.Size = new Size(656, 394);
        EventLogEntriesDataGridView.TabIndex = 5;
        // 
        // EventLogListBox
        // 
        EventLogListBox.FormattingEnabled = true;
        EventLogListBox.ItemHeight = 15;
        EventLogListBox.Location = new Point(12, 43);
        EventLogListBox.Name = "EventLogListBox";
        EventLogListBox.Size = new Size(114, 394);
        EventLogListBox.TabIndex = 4;
        EventLogListBox.SelectedIndexChanged += EventLogListBox_SelectedIndexChanged;
        // 
        // LocalComputerButton
        // 
        LocalComputerButton.Location = new Point(12, 14);
        LocalComputerButton.Name = "LocalComputerButton";
        LocalComputerButton.Size = new Size(114, 23);
        LocalComputerButton.TabIndex = 3;
        LocalComputerButton.Text = "ローカルコンピューター";
        LocalComputerButton.UseVisualStyleBackColor = true;
        LocalComputerButton.Click += LocalComputerButton_Click;
        // 
        // EventLogViewer
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(800, 450);
        Controls.Add(EventLogEntriesDataGridView);
        Controls.Add(EventLogListBox);
        Controls.Add(LocalComputerButton);
        Name = "EventLogViewer";
        Text = "イベントログ ビューアー";
        ((System.ComponentModel.ISupportInitialize)EventLogEntriesDataGridView).EndInit();
        ResumeLayout(false);
    }

    #endregion

    private DataGridView EventLogEntriesDataGridView;
    private ListBox EventLogListBox;
    private Button LocalComputerButton;
}
