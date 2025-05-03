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
        VersionCaptionLabel = new Label();
        MaxChanceTextBox = new TextBox();
        MaxChanceCaptionLabel = new Label();
        VersionDetailButton = new Button();
        EncounterDetailsCaptionLabel = new Label();
        EncounterDetailsDataGridView = new DataGridView();
        ValuesNameColumn = new DataGridViewTextBoxColumn();
        dataGridViewButtonColumn1 = new DataGridViewButtonColumn();
        CloseButton = new Button();
        ((System.ComponentModel.ISupportInitialize)EncounterDetailsDataGridView).BeginInit();
        SuspendLayout();
        // 
        // VersionTextBox
        // 
        VersionTextBox.Location = new Point(106, 12);
        VersionTextBox.Name = "VersionTextBox";
        VersionTextBox.ReadOnly = true;
        VersionTextBox.Size = new Size(199, 24);
        VersionTextBox.TabIndex = 1;
        // 
        // VersionCaptionLabel
        // 
        VersionCaptionLabel.AutoSize = true;
        VersionCaptionLabel.Location = new Point(39, 15);
        VersionCaptionLabel.Margin = new Padding(4, 0, 4, 0);
        VersionCaptionLabel.Name = "VersionCaptionLabel";
        VersionCaptionLabel.Size = new Size(60, 17);
        VersionCaptionLabel.TabIndex = 0;
        VersionCaptionLabel.Text = "バージョン";
        VersionCaptionLabel.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // MaxChanceTextBox
        // 
        MaxChanceTextBox.Location = new Point(106, 42);
        MaxChanceTextBox.Name = "MaxChanceTextBox";
        MaxChanceTextBox.ReadOnly = true;
        MaxChanceTextBox.Size = new Size(250, 24);
        MaxChanceTextBox.TabIndex = 4;
        // 
        // MaxChanceCaptionLabel
        // 
        MaxChanceCaptionLabel.AutoSize = true;
        MaxChanceCaptionLabel.Location = new Point(13, 45);
        MaxChanceCaptionLabel.Margin = new Padding(4, 0, 4, 0);
        MaxChanceCaptionLabel.Name = "MaxChanceCaptionLabel";
        MaxChanceCaptionLabel.Size = new Size(86, 17);
        MaxChanceCaptionLabel.TabIndex = 3;
        MaxChanceCaptionLabel.Text = "最大遭遇確立";
        MaxChanceCaptionLabel.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // VersionDetailButton
        // 
        VersionDetailButton.Location = new Point(312, 10);
        VersionDetailButton.Margin = new Padding(4, 3, 4, 3);
        VersionDetailButton.Name = "VersionDetailButton";
        VersionDetailButton.Size = new Size(44, 26);
        VersionDetailButton.TabIndex = 2;
        VersionDetailButton.Text = "詳細";
        VersionDetailButton.UseVisualStyleBackColor = true;
        VersionDetailButton.Click += VersionDetailButton_Click;
        // 
        // EncounterDetailsCaptionLabel
        // 
        EncounterDetailsCaptionLabel.AutoSize = true;
        EncounterDetailsCaptionLabel.Location = new Point(13, 73);
        EncounterDetailsCaptionLabel.Margin = new Padding(4, 0, 4, 0);
        EncounterDetailsCaptionLabel.Name = "EncounterDetailsCaptionLabel";
        EncounterDetailsCaptionLabel.Size = new Size(86, 17);
        EncounterDetailsCaptionLabel.TabIndex = 5;
        EncounterDetailsCaptionLabel.Text = "遭遇情報詳細";
        EncounterDetailsCaptionLabel.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // EncounterDetailsDataGridView
        // 
        EncounterDetailsDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        EncounterDetailsDataGridView.Columns.AddRange(new DataGridViewColumn[] { ValuesNameColumn, dataGridViewButtonColumn1 });
        EncounterDetailsDataGridView.Location = new Point(22, 93);
        EncounterDetailsDataGridView.Margin = new Padding(4, 3, 4, 3);
        EncounterDetailsDataGridView.Name = "EncounterDetailsDataGridView";
        EncounterDetailsDataGridView.RowHeadersVisible = false;
        EncounterDetailsDataGridView.Size = new Size(334, 170);
        EncounterDetailsDataGridView.TabIndex = 6;
        EncounterDetailsDataGridView.CellClick += EncounterDetailsDataGridView_CellClick;
        EncounterDetailsDataGridView.CellDoubleClick += EncounterDetailsDataGridView_CellDoubleClick;
        // 
        // ValuesNameColumn
        // 
        ValuesNameColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
        ValuesNameColumn.DataPropertyName = "Name";
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
        CloseButton.Location = new Point(293, 269);
        CloseButton.Name = "CloseButton";
        CloseButton.Size = new Size(63, 35);
        CloseButton.TabIndex = 7;
        CloseButton.Text = "閉じる";
        CloseButton.UseVisualStyleBackColor = true;
        CloseButton.Click += CloseButton_Click;
        // 
        // VersionEncounterDetailInfoForm
        // 
        AutoScaleDimensions = new SizeF(9F, 17F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(378, 317);
        Controls.Add(CloseButton);
        Controls.Add(EncounterDetailsDataGridView);
        Controls.Add(EncounterDetailsCaptionLabel);
        Controls.Add(VersionDetailButton);
        Controls.Add(MaxChanceCaptionLabel);
        Controls.Add(MaxChanceTextBox);
        Controls.Add(VersionCaptionLabel);
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
    private Label VersionCaptionLabel;
    private TextBox MaxChanceTextBox;
    private Label MaxChanceCaptionLabel;
    private Button VersionDetailButton;
    private Label EncounterDetailsCaptionLabel;
    private DataGridView EncounterDetailsDataGridView;
    private DataGridViewTextBoxColumn ValuesNameColumn;
    private DataGridViewButtonColumn dataGridViewButtonColumn1;
    private Button CloseButton;
}