namespace KCSEventLogViewer;

partial class Form1
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
        _btnLocalComputer = new Button();
        _lbEventLog = new ListBox();
        _dgvEventLogEntries = new DataGridView();
        ((System.ComponentModel.ISupportInitialize)_dgvEventLogEntries).BeginInit();
        SuspendLayout();
        // 
        // _btnLocalComputer
        // 
        _btnLocalComputer.Location = new Point(12, 12);
        _btnLocalComputer.Name = "_btnLocalComputer";
        _btnLocalComputer.Size = new Size(114, 23);
        _btnLocalComputer.TabIndex = 0;
        _btnLocalComputer.Text = "ローカルコンピューター";
        _btnLocalComputer.UseVisualStyleBackColor = true;
        _btnLocalComputer.Click += ButtonClickEvent;
        // 
        // _lbEventLog
        // 
        _lbEventLog.FormattingEnabled = true;
        _lbEventLog.ItemHeight = 15;
        _lbEventLog.Location = new Point(12, 41);
        _lbEventLog.Name = "_lbEventLog";
        _lbEventLog.Size = new Size(114, 394);
        _lbEventLog.TabIndex = 1;
        _lbEventLog.SelectedIndexChanged += ListBoxSelectedIndexChanged;
        // 
        // _dgvEventLogEntries
        // 
        _dgvEventLogEntries.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        _dgvEventLogEntries.Location = new Point(132, 41);
        _dgvEventLogEntries.Name = "_dgvEventLogEntries";
        _dgvEventLogEntries.Size = new Size(656, 394);
        _dgvEventLogEntries.TabIndex = 2;
        // 
        // Form1
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(800, 450);
        Controls.Add(_dgvEventLogEntries);
        Controls.Add(_lbEventLog);
        Controls.Add(_btnLocalComputer);
        Name = "Form1";
        Text = "Form1";
        ((System.ComponentModel.ISupportInitialize)_dgvEventLogEntries).EndInit();
        ResumeLayout(false);
    }

    #endregion

    private Button _btnLocalComputer;
    private ListBox _lbEventLog;
    private DataGridView _dgvEventLogEntries;
}
