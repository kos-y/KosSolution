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
        EncounterMethodButton = new Button();
        VersionDetailsCaptionLabel = new Label();
        VersionDetailsDataGridView = new DataGridView();
        CloseButton = new Button();
        PropertyButton = new Button();
        NameColumn = new DataGridViewTextBoxColumn();
        RateColumn = new DataGridViewTextBoxColumn();
        DetailColumn = new DataGridViewButtonColumn();
        ((System.ComponentModel.ISupportInitialize)VersionDetailsDataGridView).BeginInit();
        SuspendLayout();
        // 
        // EncounterMethodTextBox
        // 
        EncounterMethodTextBox.Location = new Point(94, 15);
        EncounterMethodTextBox.Margin = new Padding(4, 3, 4, 3);
        EncounterMethodTextBox.Name = "EncounterMethodTextBox";
        EncounterMethodTextBox.ReadOnly = true;
        EncounterMethodTextBox.Size = new Size(204, 24);
        EncounterMethodTextBox.TabIndex = 1;
        // 
        // EncounterMethodButton
        // 
        EncounterMethodButton.Location = new Point(14, 12);
        EncounterMethodButton.Margin = new Padding(5, 3, 5, 3);
        EncounterMethodButton.Name = "EncounterMethodButton";
        EncounterMethodButton.Size = new Size(71, 29);
        EncounterMethodButton.TabIndex = 0;
        EncounterMethodButton.Text = "遭遇方法";
        EncounterMethodButton.UseVisualStyleBackColor = true;
        EncounterMethodButton.Click += EncounterMethodButton_Click;
        // 
        // VersionDetailsCaptionLabel
        // 
        VersionDetailsCaptionLabel.AutoSize = true;
        VersionDetailsCaptionLabel.Location = new Point(14, 52);
        VersionDetailsCaptionLabel.Margin = new Padding(5, 0, 5, 0);
        VersionDetailsCaptionLabel.Name = "VersionDetailsCaptionLabel";
        VersionDetailsCaptionLabel.Size = new Size(131, 17);
        VersionDetailsCaptionLabel.TabIndex = 2;
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
        VersionDetailsDataGridView.TabIndex = 3;
        VersionDetailsDataGridView.CellClick += VersionDetailsDataGridView_CellClick;
        VersionDetailsDataGridView.CellDoubleClick += VersionDetailsDataGridView_CellDoubleClick;
        // 
        // CloseButton
        // 
        CloseButton.Location = new Point(262, 248);
        CloseButton.Name = "CloseButton";
        CloseButton.Size = new Size(76, 35);
        CloseButton.TabIndex = 5;
        CloseButton.Text = "閉じる";
        CloseButton.UseVisualStyleBackColor = true;
        CloseButton.Click += CloseButton_Click;
        // 
        // PropertyButton
        // 
        PropertyButton.Location = new Point(180, 248);
        PropertyButton.Name = "PropertyButton";
        PropertyButton.Size = new Size(76, 35);
        PropertyButton.TabIndex = 4;
        PropertyButton.Text = "プロパティ";
        PropertyButton.UseVisualStyleBackColor = true;
        PropertyButton.Click += PropertyButton_Click;
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
        RateColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
        RateColumn.DataPropertyName = "Rate";
        RateColumn.HeaderText = "遭遇率";
        RateColumn.Name = "RateColumn";
        RateColumn.ReadOnly = true;
        RateColumn.Width = 72;
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
        // EncounterMethodRateInfoForm
        // 
        AutoScaleDimensions = new SizeF(9F, 17F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(357, 297);
        Controls.Add(PropertyButton);
        Controls.Add(CloseButton);
        Controls.Add(VersionDetailsDataGridView);
        Controls.Add(VersionDetailsCaptionLabel);
        Controls.Add(EncounterMethodButton);
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
    private Button EncounterMethodButton;
    private Label VersionDetailsCaptionLabel;
    private DataGridView VersionDetailsDataGridView;
    private Button CloseButton;
    private Button PropertyButton;
    private DataGridViewTextBoxColumn NameColumn;
    private DataGridViewTextBoxColumn RateColumn;
    private DataGridViewButtonColumn DetailColumn;
}