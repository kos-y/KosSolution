namespace Kos.PokeAPI.Forms;

partial class EncounterMethodRateInfoForm
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
        EncounterMethodTextBox = new TextBox();
        EncounterMethodCaptionLabel = new Label();
        EncounterMethodDetailButton = new Button();
        VersionDetailsCaptionLabel = new Label();
        VersionDetailsDataGridView = new DataGridView();
        NameColumn = new DataGridViewTextBoxColumn();
        RateColumn = new DataGridViewTextBoxColumn();
        DetailColumn = new DataGridViewButtonColumn();
        CloseButton = new Button();
        ((System.ComponentModel.ISupportInitialize)VersionDetailsDataGridView).BeginInit();
        SuspendLayout();
        // 
        // EncounterMethodTextBox
        // 
        EncounterMethodTextBox.Location = new Point(83, 12);
        EncounterMethodTextBox.Margin = new Padding(4, 3, 4, 3);
        EncounterMethodTextBox.Name = "EncounterMethodTextBox";
        EncounterMethodTextBox.ReadOnly = true;
        EncounterMethodTextBox.Size = new Size(204, 24);
        EncounterMethodTextBox.TabIndex = 1;
        // 
        // EncounterMethodCaptionLabel
        // 
        EncounterMethodCaptionLabel.AutoSize = true;
        EncounterMethodCaptionLabel.Location = new Point(14, 15);
        EncounterMethodCaptionLabel.Margin = new Padding(5, 0, 5, 0);
        EncounterMethodCaptionLabel.Name = "EncounterMethodCaptionLabel";
        EncounterMethodCaptionLabel.Size = new Size(60, 17);
        EncounterMethodCaptionLabel.TabIndex = 0;
        EncounterMethodCaptionLabel.Text = "遭遇方法";
        EncounterMethodCaptionLabel.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // EncounterMethodDetailButton
        // 
        EncounterMethodDetailButton.Location = new Point(296, 9);
        EncounterMethodDetailButton.Margin = new Padding(5, 3, 5, 3);
        EncounterMethodDetailButton.Name = "EncounterMethodDetailButton";
        EncounterMethodDetailButton.Size = new Size(42, 29);
        EncounterMethodDetailButton.TabIndex = 2;
        EncounterMethodDetailButton.Text = "詳細";
        EncounterMethodDetailButton.UseVisualStyleBackColor = true;
        EncounterMethodDetailButton.Click += EncounterMethodDetailButton_Click;
        // 
        // VersionDetailsCaptionLabel
        // 
        VersionDetailsCaptionLabel.AutoSize = true;
        VersionDetailsCaptionLabel.Location = new Point(14, 52);
        VersionDetailsCaptionLabel.Margin = new Padding(5, 0, 5, 0);
        VersionDetailsCaptionLabel.Name = "VersionDetailsCaptionLabel";
        VersionDetailsCaptionLabel.Size = new Size(131, 17);
        VersionDetailsCaptionLabel.TabIndex = 3;
        VersionDetailsCaptionLabel.Text = "バージョンごとの遭遇率";
        VersionDetailsCaptionLabel.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // VersionDetailsDataGridView
        // 
        VersionDetailsDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        VersionDetailsDataGridView.Columns.AddRange(new DataGridViewColumn[] { NameColumn, RateColumn, DetailColumn });
        VersionDetailsDataGridView.Location = new Point(14, 72);
        VersionDetailsDataGridView.Margin = new Padding(4, 3, 4, 3);
        VersionDetailsDataGridView.Name = "VersionDetailsDataGridView";
        VersionDetailsDataGridView.RowHeadersVisible = false;
        VersionDetailsDataGridView.Size = new Size(324, 170);
        VersionDetailsDataGridView.TabIndex = 4;
        VersionDetailsDataGridView.CellClick += VersionDetailsDataGridView_CellClick;
        VersionDetailsDataGridView.CellDoubleClick += VersionDetailsDataGridView_CellDoubleClick;
        // 
        // NameColumn
        // 
        NameColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
        NameColumn.DataPropertyName = "Version";
        NameColumn.HeaderText = "バージョン";
        NameColumn.Name = "NameColumn";
        NameColumn.ReadOnly = true;
        NameColumn.Width = 85;
        // 
        // RateColumn
        // 
        RateColumn.DataPropertyName = "Rate";
        RateColumn.HeaderText = "遭遇率";
        RateColumn.Name = "RateColumn";
        RateColumn.ReadOnly = true;
        // 
        // DetailColumn
        // 
        DetailColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
        DetailColumn.HeaderText = "詳細";
        DetailColumn.Name = "DetailColumn";
        DetailColumn.Text = "詳細";
        DetailColumn.UseColumnTextForButtonValue = true;
        DetailColumn.Width = 40;
        // 
        // CloseButton
        // 
        CloseButton.Location = new Point(275, 248);
        CloseButton.Name = "CloseButton";
        CloseButton.Size = new Size(63, 35);
        CloseButton.TabIndex = 5;
        CloseButton.Text = "閉じる";
        CloseButton.UseVisualStyleBackColor = true;
        CloseButton.Click += CloseButton_Click;
        // 
        // EncounterMethodRateInfoForm
        // 
        AutoScaleDimensions = new SizeF(9F, 17F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(357, 297);
        Controls.Add(CloseButton);
        Controls.Add(VersionDetailsDataGridView);
        Controls.Add(VersionDetailsCaptionLabel);
        Controls.Add(EncounterMethodDetailButton);
        Controls.Add(EncounterMethodCaptionLabel);
        Controls.Add(EncounterMethodTextBox);
        Font = new Font("Meiryo UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 128);
        FormBorderStyle = FormBorderStyle.FixedSingle;
        Margin = new Padding(4, 3, 4, 3);
        MaximizeBox = false;
        Name = "EncounterMethodRateInfoForm";
        StartPosition = FormStartPosition.CenterParent;
        Text = "遭遇方法とバージョンごとの遭遇率";
        ((System.ComponentModel.ISupportInitialize)VersionDetailsDataGridView).EndInit();
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private TextBox EncounterMethodTextBox;
    private Label EncounterMethodCaptionLabel;
    private Button EncounterMethodDetailButton;
    private Label VersionDetailsCaptionLabel;
    private DataGridView VersionDetailsDataGridView;
    private DataGridViewTextBoxColumn NameColumn;
    private DataGridViewTextBoxColumn RateColumn;
    private DataGridViewButtonColumn DetailColumn;
    private Button CloseButton;
}