namespace Kos.PokeAPI.Forms;

partial class VersionEncounterDetailInfoForm
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
        VersionTextBox = new TextBox();
        MaxChanceTextBox = new TextBox();
        MaxChanceCaptionLabel = new Label();
        VersionButton = new Button();
        EncounterDetailsCaptionLabel = new Label();
        EncounterDetailsDataGridView = new DataGridView();
        ValuesNameColumn = new DataGridViewTextBoxColumn();
        dataGridViewButtonColumn1 = new DataGridViewButtonColumn();
        CloseButton = new Button();
        PropertyButton = new Button();
        ((System.ComponentModel.ISupportInitialize)EncounterDetailsDataGridView).BeginInit();
        SuspendLayout();
        // 
        // VersionTextBox
        // 
        VersionTextBox.Location = new Point(106, 14);
        VersionTextBox.Name = "VersionTextBox";
        VersionTextBox.ReadOnly = true;
        VersionTextBox.Size = new Size(199, 24);
        VersionTextBox.TabIndex = 1;
        // 
        // MaxChanceTextBox
        // 
        MaxChanceTextBox.Location = new Point(106, 44);
        MaxChanceTextBox.Name = "MaxChanceTextBox";
        MaxChanceTextBox.ReadOnly = true;
        MaxChanceTextBox.Size = new Size(188, 24);
        MaxChanceTextBox.TabIndex = 3;
        // 
        // MaxChanceCaptionLabel
        // 
        MaxChanceCaptionLabel.AutoSize = true;
        MaxChanceCaptionLabel.Location = new Point(13, 44);
        MaxChanceCaptionLabel.Margin = new Padding(4, 0, 4, 0);
        MaxChanceCaptionLabel.Name = "MaxChanceCaptionLabel";
        MaxChanceCaptionLabel.Size = new Size(86, 17);
        MaxChanceCaptionLabel.TabIndex = 2;
        MaxChanceCaptionLabel.Text = "最大遭遇確立";
        MaxChanceCaptionLabel.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // VersionButton
        // 
        VersionButton.Location = new Point(13, 12);
        VersionButton.Margin = new Padding(4, 3, 4, 3);
        VersionButton.Name = "VersionButton";
        VersionButton.Size = new Size(86, 26);
        VersionButton.TabIndex = 0;
        VersionButton.Text = "バージョン";
        VersionButton.UseVisualStyleBackColor = true;
        VersionButton.Click += VersionButton_Click;
        // 
        // EncounterDetailsCaptionLabel
        // 
        EncounterDetailsCaptionLabel.AutoSize = true;
        EncounterDetailsCaptionLabel.Location = new Point(13, 79);
        EncounterDetailsCaptionLabel.Margin = new Padding(4, 0, 4, 0);
        EncounterDetailsCaptionLabel.Name = "EncounterDetailsCaptionLabel";
        EncounterDetailsCaptionLabel.Size = new Size(86, 17);
        EncounterDetailsCaptionLabel.TabIndex = 4;
        EncounterDetailsCaptionLabel.Text = "遭遇情報詳細";
        EncounterDetailsCaptionLabel.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // EncounterDetailsDataGridView
        // 
        EncounterDetailsDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        EncounterDetailsDataGridView.Columns.AddRange(new DataGridViewColumn[] { ValuesNameColumn, dataGridViewButtonColumn1 });
        EncounterDetailsDataGridView.Location = new Point(13, 99);
        EncounterDetailsDataGridView.Margin = new Padding(4, 3, 4, 3);
        EncounterDetailsDataGridView.Name = "EncounterDetailsDataGridView";
        EncounterDetailsDataGridView.RowHeadersVisible = false;
        EncounterDetailsDataGridView.Size = new Size(334, 170);
        EncounterDetailsDataGridView.TabIndex = 5;
        EncounterDetailsDataGridView.CellClick += EncounterDetailsDataGridView_CellClick;
        EncounterDetailsDataGridView.CellDoubleClick += EncounterDetailsDataGridView_CellDoubleClick;
        // 
        // ValuesNameColumn
        // 
        ValuesNameColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
        ValuesNameColumn.DataPropertyName = "Text";
        ValuesNameColumn.HeaderText = "遭遇情報";
        ValuesNameColumn.Name = "ValuesNameColumn";
        ValuesNameColumn.ReadOnly = true;
        ValuesNameColumn.Width = 85;
        // 
        // dataGridViewButtonColumn1
        // 
        dataGridViewButtonColumn1.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
        dataGridViewButtonColumn1.HeaderText = "詳細";
        dataGridViewButtonColumn1.Name = "dataGridViewButtonColumn1";
        dataGridViewButtonColumn1.Text = "詳細";
        dataGridViewButtonColumn1.UseColumnTextForButtonValue = true;
        dataGridViewButtonColumn1.Width = 40;
        // 
        // CloseButton
        // 
        CloseButton.Location = new Point(271, 275);
        CloseButton.Name = "CloseButton";
        CloseButton.Size = new Size(76, 35);
        CloseButton.TabIndex = 7;
        CloseButton.Text = "閉じる";
        CloseButton.UseVisualStyleBackColor = true;
        CloseButton.Click += CloseButton_Click;
        // 
        // PropertyButton
        // 
        PropertyButton.Location = new Point(189, 275);
        PropertyButton.Name = "PropertyButton";
        PropertyButton.Size = new Size(76, 35);
        PropertyButton.TabIndex = 6;
        PropertyButton.Text = "プロパティ";
        PropertyButton.UseVisualStyleBackColor = true;
        PropertyButton.Click += PropertyButton_Click;
        // 
        // VersionEncounterDetailInfoForm
        // 
        AutoScaleDimensions = new SizeF(9F, 17F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(356, 319);
        Controls.Add(PropertyButton);
        Controls.Add(CloseButton);
        Controls.Add(EncounterDetailsDataGridView);
        Controls.Add(EncounterDetailsCaptionLabel);
        Controls.Add(VersionButton);
        Controls.Add(MaxChanceCaptionLabel);
        Controls.Add(MaxChanceTextBox);
        Controls.Add(VersionTextBox);
        Font = new Font("Meiryo UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 128);
        FormBorderStyle = FormBorderStyle.FixedSingle;
        Margin = new Padding(4, 3, 4, 3);
        MaximizeBox = false;
        Name = "VersionEncounterDetailInfoForm";
        StartPosition = FormStartPosition.CenterParent;
        Text = "バージョンごとの遭遇情報";
        ((System.ComponentModel.ISupportInitialize)EncounterDetailsDataGridView).EndInit();
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private TextBox VersionTextBox;
    private TextBox MaxChanceTextBox;
    private Label MaxChanceCaptionLabel;
    private Button VersionButton;
    private Label EncounterDetailsCaptionLabel;
    private DataGridView EncounterDetailsDataGridView;
    private Button CloseButton;
    private DataGridViewTextBoxColumn ValuesNameColumn;
    private DataGridViewButtonColumn dataGridViewButtonColumn1;
    private Button PropertyButton;
}