namespace Kos.PokeAPI.Forms;

partial class LocationInfoForm
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
        NameTextBox = new TextBox();
        IdTextBox = new TextBox();
        NameCaptionLabel = new Label();
        IdCaptionLabel = new Label();
        RegionTextBox = new TextBox();
        RegionCaptionLabel = new Label();
        RegionDetailButton = new Button();
        NamesDataGridView = new DataGridView();
        NameColumn = new DataGridViewTextBoxColumn();
        LanguageColumn = new DataGridViewTextBoxColumn();
        DetailColumn = new DataGridViewButtonColumn();
        NamesCaptionLabel = new Label();
        GameIndiceDataGridView = new DataGridView();
        GenerationColumn = new DataGridViewTextBoxColumn();
        GameIndexColumn = new DataGridViewTextBoxColumn();
        DetailButtonColumn = new DataGridViewButtonColumn();
        GameIndiceCaptionLabel = new Label();
        AreasDataGridView = new DataGridView();
        dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
        dataGridViewButtonColumn1 = new DataGridViewButtonColumn();
        AreasCaptionLabel = new Label();
        CloseButton = new Button();
        ((System.ComponentModel.ISupportInitialize)NamesDataGridView).BeginInit();
        ((System.ComponentModel.ISupportInitialize)GameIndiceDataGridView).BeginInit();
        ((System.ComponentModel.ISupportInitialize)AreasDataGridView).BeginInit();
        SuspendLayout();
        // 
        // NameTextBox
        // 
        NameTextBox.Location = new Point(70, 42);
        NameTextBox.Name = "NameTextBox";
        NameTextBox.ReadOnly = true;
        NameTextBox.Size = new Size(191, 24);
        NameTextBox.TabIndex = 3;
        // 
        // IdTextBox
        // 
        IdTextBox.Location = new Point(70, 12);
        IdTextBox.Name = "IdTextBox";
        IdTextBox.ReadOnly = true;
        IdTextBox.Size = new Size(191, 24);
        IdTextBox.TabIndex = 1;
        // 
        // NameCaptionLabel
        // 
        NameCaptionLabel.AutoSize = true;
        NameCaptionLabel.Location = new Point(16, 45);
        NameCaptionLabel.Margin = new Padding(4, 0, 4, 0);
        NameCaptionLabel.Name = "NameCaptionLabel";
        NameCaptionLabel.Size = new Size(47, 17);
        NameCaptionLabel.TabIndex = 2;
        NameCaptionLabel.Text = "場所名";
        NameCaptionLabel.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // IdCaptionLabel
        // 
        IdCaptionLabel.AutoSize = true;
        IdCaptionLabel.Location = new Point(12, 15);
        IdCaptionLabel.Margin = new Padding(4, 0, 4, 0);
        IdCaptionLabel.Name = "IdCaptionLabel";
        IdCaptionLabel.Size = new Size(51, 17);
        IdCaptionLabel.TabIndex = 0;
        IdCaptionLabel.Text = "場所ID";
        IdCaptionLabel.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // RegionTextBox
        // 
        RegionTextBox.Location = new Point(70, 72);
        RegionTextBox.Name = "RegionTextBox";
        RegionTextBox.ReadOnly = true;
        RegionTextBox.Size = new Size(191, 24);
        RegionTextBox.TabIndex = 5;
        // 
        // RegionCaptionLabel
        // 
        RegionCaptionLabel.AutoSize = true;
        RegionCaptionLabel.Location = new Point(29, 75);
        RegionCaptionLabel.Margin = new Padding(4, 0, 4, 0);
        RegionCaptionLabel.Name = "RegionCaptionLabel";
        RegionCaptionLabel.Size = new Size(34, 17);
        RegionCaptionLabel.TabIndex = 4;
        RegionCaptionLabel.Text = "地域";
        RegionCaptionLabel.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // RegionDetailButton
        // 
        RegionDetailButton.Location = new Point(268, 70);
        RegionDetailButton.Margin = new Padding(4, 3, 4, 3);
        RegionDetailButton.Name = "RegionDetailButton";
        RegionDetailButton.Size = new Size(55, 26);
        RegionDetailButton.TabIndex = 6;
        RegionDetailButton.Text = "詳細";
        RegionDetailButton.UseVisualStyleBackColor = true;
        RegionDetailButton.Click += RegionDetailButton_Click;
        // 
        // NamesDataGridView
        // 
        NamesDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        NamesDataGridView.Columns.AddRange(new DataGridViewColumn[] { NameColumn, LanguageColumn, DetailColumn });
        NamesDataGridView.Location = new Point(14, 119);
        NamesDataGridView.Margin = new Padding(4, 3, 4, 3);
        NamesDataGridView.Name = "NamesDataGridView";
        NamesDataGridView.RowHeadersVisible = false;
        NamesDataGridView.Size = new Size(379, 170);
        NamesDataGridView.TabIndex = 8;
        NamesDataGridView.CellClick += NamesDataGridView_CellClick;
        NamesDataGridView.CellDoubleClick += NamesDataGridView_CellDoubleClick;
        // 
        // NameColumn
        // 
        NameColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
        NameColumn.DataPropertyName = "Text";
        NameColumn.HeaderText = "名前";
        NameColumn.Name = "NameColumn";
        NameColumn.ReadOnly = true;
        NameColumn.Width = 59;
        // 
        // LanguageColumn
        // 
        LanguageColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
        LanguageColumn.DataPropertyName = "Language";
        LanguageColumn.HeaderText = "言語";
        LanguageColumn.Name = "LanguageColumn";
        LanguageColumn.ReadOnly = true;
        LanguageColumn.Width = 59;
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
        // NamesCaptionLabel
        // 
        NamesCaptionLabel.AutoSize = true;
        NamesCaptionLabel.Location = new Point(12, 99);
        NamesCaptionLabel.Margin = new Padding(4, 0, 4, 0);
        NamesCaptionLabel.Name = "NamesCaptionLabel";
        NamesCaptionLabel.Size = new Size(92, 17);
        NamesCaptionLabel.TabIndex = 7;
        NamesCaptionLabel.Text = "言語ごとの名前";
        NamesCaptionLabel.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // GameIndiceDataGridView
        // 
        GameIndiceDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        GameIndiceDataGridView.Columns.AddRange(new DataGridViewColumn[] { GenerationColumn, GameIndexColumn, DetailButtonColumn });
        GameIndiceDataGridView.Location = new Point(401, 119);
        GameIndiceDataGridView.Margin = new Padding(4, 3, 4, 3);
        GameIndiceDataGridView.Name = "GameIndiceDataGridView";
        GameIndiceDataGridView.RowHeadersVisible = false;
        GameIndiceDataGridView.Size = new Size(342, 170);
        GameIndiceDataGridView.TabIndex = 10;
        GameIndiceDataGridView.CellClick += GameIndiceDataGridView_CellClick;
        GameIndiceDataGridView.CellDoubleClick += GameIndiceDataGridView_CellDoubleClick;
        // 
        // GenerationColumn
        // 
        GenerationColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
        GenerationColumn.DataPropertyName = "Generation";
        GenerationColumn.HeaderText = "世代";
        GenerationColumn.Name = "GenerationColumn";
        GenerationColumn.ReadOnly = true;
        GenerationColumn.Width = 59;
        // 
        // GameIndexColumn
        // 
        GameIndexColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
        GameIndexColumn.DataPropertyName = "GameIndex";
        GameIndexColumn.HeaderText = "インデックス";
        GameIndexColumn.Name = "GameIndexColumn";
        GameIndexColumn.ReadOnly = true;
        GameIndexColumn.Width = 95;
        // 
        // DetailButtonColumn
        // 
        DetailButtonColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
        DetailButtonColumn.HeaderText = "詳細";
        DetailButtonColumn.Name = "DetailButtonColumn";
        DetailButtonColumn.Text = "詳細";
        DetailButtonColumn.UseColumnTextForButtonValue = true;
        DetailButtonColumn.Width = 40;
        // 
        // GameIndiceCaptionLabel
        // 
        GameIndiceCaptionLabel.AutoSize = true;
        GameIndiceCaptionLabel.Location = new Point(401, 99);
        GameIndiceCaptionLabel.Margin = new Padding(4, 0, 4, 0);
        GameIndiceCaptionLabel.Name = "GameIndiceCaptionLabel";
        GameIndiceCaptionLabel.Size = new Size(116, 17);
        GameIndiceCaptionLabel.TabIndex = 9;
        GameIndiceCaptionLabel.Text = "ゲーム内インデックス";
        GameIndiceCaptionLabel.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // AreasDataGridView
        // 
        AreasDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        AreasDataGridView.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1, dataGridViewButtonColumn1 });
        AreasDataGridView.Location = new Point(14, 312);
        AreasDataGridView.Margin = new Padding(4, 3, 4, 3);
        AreasDataGridView.Name = "AreasDataGridView";
        AreasDataGridView.RowHeadersVisible = false;
        AreasDataGridView.Size = new Size(729, 170);
        AreasDataGridView.TabIndex = 12;
        AreasDataGridView.CellClick += AreasDataGridView_CellClick;
        AreasDataGridView.CellDoubleClick += AreasDataGridView_CellDoubleClick;
        // 
        // dataGridViewTextBoxColumn1
        // 
        dataGridViewTextBoxColumn1.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
        dataGridViewTextBoxColumn1.DataPropertyName = "Name";
        dataGridViewTextBoxColumn1.HeaderText = "エリア";
        dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
        dataGridViewTextBoxColumn1.ReadOnly = true;
        dataGridViewTextBoxColumn1.Width = 63;
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
        // AreasCaptionLabel
        // 
        AreasCaptionLabel.AutoSize = true;
        AreasCaptionLabel.Location = new Point(12, 292);
        AreasCaptionLabel.Margin = new Padding(4, 0, 4, 0);
        AreasCaptionLabel.Name = "AreasCaptionLabel";
        AreasCaptionLabel.Size = new Size(38, 17);
        AreasCaptionLabel.TabIndex = 11;
        AreasCaptionLabel.Text = "エリア";
        AreasCaptionLabel.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // CloseButton
        // 
        CloseButton.Location = new Point(670, 488);
        CloseButton.Margin = new Padding(4, 3, 4, 3);
        CloseButton.Name = "CloseButton";
        CloseButton.Size = new Size(82, 40);
        CloseButton.TabIndex = 13;
        CloseButton.Text = "閉じる";
        CloseButton.UseVisualStyleBackColor = true;
        CloseButton.Click += CloseButton_Click;
        // 
        // LocationInfoForm
        // 
        AutoScaleDimensions = new SizeF(9F, 17F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(765, 543);
        Controls.Add(CloseButton);
        Controls.Add(AreasDataGridView);
        Controls.Add(AreasCaptionLabel);
        Controls.Add(GameIndiceDataGridView);
        Controls.Add(GameIndiceCaptionLabel);
        Controls.Add(NamesDataGridView);
        Controls.Add(NamesCaptionLabel);
        Controls.Add(RegionDetailButton);
        Controls.Add(RegionCaptionLabel);
        Controls.Add(RegionTextBox);
        Controls.Add(NameTextBox);
        Controls.Add(IdTextBox);
        Controls.Add(NameCaptionLabel);
        Controls.Add(IdCaptionLabel);
        Font = new Font("Meiryo UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 128);
        Margin = new Padding(4, 3, 4, 3);
        Name = "LocationInfoForm";
        StartPosition = FormStartPosition.CenterParent;
        Text = "場所";
        ((System.ComponentModel.ISupportInitialize)NamesDataGridView).EndInit();
        ((System.ComponentModel.ISupportInitialize)GameIndiceDataGridView).EndInit();
        ((System.ComponentModel.ISupportInitialize)AreasDataGridView).EndInit();
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private TextBox NameTextBox;
    private TextBox IdTextBox;
    private Label NameCaptionLabel;
    private Label IdCaptionLabel;
    private TextBox RegionTextBox;
    private Label RegionCaptionLabel;
    private Button RegionDetailButton;
    private DataGridView NamesDataGridView;
    private DataGridViewTextBoxColumn NameColumn;
    private DataGridViewTextBoxColumn LanguageColumn;
    private DataGridViewButtonColumn DetailColumn;
    private Label NamesCaptionLabel;
    private DataGridView GameIndiceDataGridView;
    private DataGridViewTextBoxColumn GenerationColumn;
    private DataGridViewTextBoxColumn GameIndexColumn;
    private DataGridViewButtonColumn DetailButtonColumn;
    private Label GameIndiceCaptionLabel;
    private DataGridView AreasDataGridView;
    private Label AreasCaptionLabel;
    private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
    private DataGridViewButtonColumn dataGridViewButtonColumn1;
    private Button CloseButton;
}