namespace Kos.PokeAPI.Forms;

partial class VersionInfoForm
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
        NameLabel = new Label();
        NameCaptionLabel = new Label();
        IdLabel = new Label();
        IdCaptionLabel = new Label();
        NamesDataGridView = new DataGridView();
        NameColumn = new DataGridViewTextBoxColumn();
        LanguageColumn = new DataGridViewTextBoxColumn();
        DetailColumn = new DataGridViewButtonColumn();
        NamesCaptionLabel = new Label();
        VersionGroupCaptionLabel = new Label();
        CloseButton = new Button();
        VersionGroupLabel = new Label();
        VersionGroupInfoButton = new Button();
        ((System.ComponentModel.ISupportInitialize)NamesDataGridView).BeginInit();
        SuspendLayout();
        // 
        // NameLabel
        // 
        NameLabel.BorderStyle = BorderStyle.Fixed3D;
        NameLabel.Location = new Point(117, 31);
        NameLabel.Name = "NameLabel";
        NameLabel.Size = new Size(147, 23);
        NameLabel.TabIndex = 3;
        NameLabel.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // NameCaptionLabel
        // 
        NameCaptionLabel.Location = new Point(12, 32);
        NameCaptionLabel.Name = "NameCaptionLabel";
        NameCaptionLabel.Size = new Size(99, 23);
        NameCaptionLabel.TabIndex = 2;
        NameCaptionLabel.Text = "name";
        NameCaptionLabel.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // IdLabel
        // 
        IdLabel.BorderStyle = BorderStyle.Fixed3D;
        IdLabel.Location = new Point(117, 8);
        IdLabel.Name = "IdLabel";
        IdLabel.Size = new Size(147, 23);
        IdLabel.TabIndex = 1;
        IdLabel.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // IdCaptionLabel
        // 
        IdCaptionLabel.Location = new Point(12, 9);
        IdCaptionLabel.Name = "IdCaptionLabel";
        IdCaptionLabel.Size = new Size(99, 23);
        IdCaptionLabel.TabIndex = 0;
        IdCaptionLabel.Text = "id";
        IdCaptionLabel.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // NamesDataGridView
        // 
        NamesDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        NamesDataGridView.Columns.AddRange(new DataGridViewColumn[] { NameColumn, LanguageColumn, DetailColumn });
        NamesDataGridView.Location = new Point(117, 57);
        NamesDataGridView.Name = "NamesDataGridView";
        NamesDataGridView.RowHeadersVisible = false;
        NamesDataGridView.Size = new Size(434, 150);
        NamesDataGridView.TabIndex = 5;
        NamesDataGridView.CellClick += NamesDataGridView_CellClick;
        NamesDataGridView.CellDoubleClick += NamesDataGridView_CellDoubleClick;
        // 
        // NameColumn
        // 
        NameColumn.DataPropertyName = "Text";
        NameColumn.HeaderText = "name";
        NameColumn.Name = "NameColumn";
        NameColumn.ReadOnly = true;
        // 
        // LanguageColumn
        // 
        LanguageColumn.DataPropertyName = "Language";
        LanguageColumn.HeaderText = "language";
        LanguageColumn.Name = "LanguageColumn";
        LanguageColumn.ReadOnly = true;
        // 
        // DetailColumn
        // 
        DetailColumn.HeaderText = "Info";
        DetailColumn.Name = "DetailColumn";
        DetailColumn.Text = "Info..";
        DetailColumn.UseColumnTextForButtonValue = true;
        // 
        // NamesCaptionLabel
        // 
        NamesCaptionLabel.Location = new Point(12, 57);
        NamesCaptionLabel.Name = "NamesCaptionLabel";
        NamesCaptionLabel.Size = new Size(99, 23);
        NamesCaptionLabel.TabIndex = 4;
        NamesCaptionLabel.Text = "names";
        NamesCaptionLabel.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // VersionGroupCaptionLabel
        // 
        VersionGroupCaptionLabel.Location = new Point(12, 213);
        VersionGroupCaptionLabel.Name = "VersionGroupCaptionLabel";
        VersionGroupCaptionLabel.Size = new Size(99, 23);
        VersionGroupCaptionLabel.TabIndex = 6;
        VersionGroupCaptionLabel.Text = "version_groups";
        VersionGroupCaptionLabel.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // CloseButton
        // 
        CloseButton.Location = new Point(476, 213);
        CloseButton.Name = "CloseButton";
        CloseButton.Size = new Size(75, 23);
        CloseButton.TabIndex = 9;
        CloseButton.Text = "Close";
        CloseButton.UseVisualStyleBackColor = true;
        CloseButton.Click += CloseButton_Click;
        // 
        // VersionGroupLabel
        // 
        VersionGroupLabel.BorderStyle = BorderStyle.Fixed3D;
        VersionGroupLabel.Location = new Point(117, 213);
        VersionGroupLabel.Name = "VersionGroupLabel";
        VersionGroupLabel.Size = new Size(252, 23);
        VersionGroupLabel.TabIndex = 7;
        VersionGroupLabel.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // VersionGroupInfoButton
        // 
        VersionGroupInfoButton.Location = new Point(375, 213);
        VersionGroupInfoButton.Name = "VersionGroupInfoButton";
        VersionGroupInfoButton.Size = new Size(43, 23);
        VersionGroupInfoButton.TabIndex = 8;
        VersionGroupInfoButton.Text = "Info...";
        VersionGroupInfoButton.UseVisualStyleBackColor = true;
        VersionGroupInfoButton.Click += VersionGroupInfoButton_Click;
        // 
        // VersionInfoForm
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(570, 251);
        Controls.Add(VersionGroupInfoButton);
        Controls.Add(VersionGroupLabel);
        Controls.Add(CloseButton);
        Controls.Add(VersionGroupCaptionLabel);
        Controls.Add(NamesDataGridView);
        Controls.Add(NamesCaptionLabel);
        Controls.Add(NameLabel);
        Controls.Add(NameCaptionLabel);
        Controls.Add(IdLabel);
        Controls.Add(IdCaptionLabel);
        FormBorderStyle = FormBorderStyle.FixedSingle;
        MaximizeBox = false;
        Name = "VersionInfoForm";
        StartPosition = FormStartPosition.CenterParent;
        Text = "Version";
        ((System.ComponentModel.ISupportInitialize)NamesDataGridView).EndInit();
        ResumeLayout(false);
    }

    #endregion

    private Label NameLabel;
    private Label NameCaptionLabel;
    private Label IdLabel;
    private Label IdCaptionLabel;
    private DataGridView NamesDataGridView;
    private DataGridViewTextBoxColumn NameColumn;
    private DataGridViewTextBoxColumn LanguageColumn;
    private DataGridViewButtonColumn DetailColumn;
    private Label NamesCaptionLabel;
    private DataGridView VersionGroupDataGridView;
    private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
    private DataGridViewButtonColumn dataGridViewButtonColumn4;
    private Label VersionGroupCaptionLabel;
    private Button CloseButton;
    private Label VersionGroupLabel;
    private Button VersionGroupInfoButton;
}