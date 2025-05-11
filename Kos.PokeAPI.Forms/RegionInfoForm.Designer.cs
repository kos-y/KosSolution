namespace Kos.PokeAPI.Forms;

partial class RegionInfoForm
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
        LocationsDataGridView = new DataGridView();
        dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
        dataGridViewButtonColumn1 = new DataGridViewButtonColumn();
        LocationsCaptionLabel = new Label();
        NamesDataGridView = new DataGridView();
        NameColumn = new DataGridViewTextBoxColumn();
        LanguageColumn = new DataGridViewTextBoxColumn();
        DetailColumn = new DataGridViewButtonColumn();
        NamesCaptionLabel = new Label();
        MainGenerationTextBox = new TextBox();
        PokedexesDataGridView = new DataGridView();
        dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
        dataGridViewButtonColumn2 = new DataGridViewButtonColumn();
        PokedexesCaptionLabel = new Label();
        VersionGroupDataGridView = new DataGridView();
        dataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
        dataGridViewButtonColumn3 = new DataGridViewButtonColumn();
        VersionGroupCaptionLabel = new Label();
        CloseButton = new Button();
        MainGenerationButton = new Button();
        PropertyButton = new Button();
        ((System.ComponentModel.ISupportInitialize)LocationsDataGridView).BeginInit();
        ((System.ComponentModel.ISupportInitialize)NamesDataGridView).BeginInit();
        ((System.ComponentModel.ISupportInitialize)PokedexesDataGridView).BeginInit();
        ((System.ComponentModel.ISupportInitialize)VersionGroupDataGridView).BeginInit();
        SuspendLayout();
        // 
        // NameTextBox
        // 
        NameTextBox.Location = new Point(91, 42);
        NameTextBox.Margin = new Padding(5, 3, 5, 3);
        NameTextBox.Name = "NameTextBox";
        NameTextBox.ReadOnly = true;
        NameTextBox.Size = new Size(172, 24);
        NameTextBox.TabIndex = 3;
        // 
        // IdTextBox
        // 
        IdTextBox.Location = new Point(91, 12);
        IdTextBox.Margin = new Padding(5, 3, 5, 3);
        IdTextBox.Name = "IdTextBox";
        IdTextBox.ReadOnly = true;
        IdTextBox.Size = new Size(172, 24);
        IdTextBox.TabIndex = 1;
        // 
        // NameCaptionLabel
        // 
        NameCaptionLabel.AutoSize = true;
        NameCaptionLabel.Location = new Point(37, 45);
        NameCaptionLabel.Margin = new Padding(6, 0, 6, 0);
        NameCaptionLabel.Name = "NameCaptionLabel";
        NameCaptionLabel.Size = new Size(47, 17);
        NameCaptionLabel.TabIndex = 2;
        NameCaptionLabel.Text = "地域名";
        NameCaptionLabel.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // IdCaptionLabel
        // 
        IdCaptionLabel.AutoSize = true;
        IdCaptionLabel.Location = new Point(33, 15);
        IdCaptionLabel.Margin = new Padding(6, 0, 6, 0);
        IdCaptionLabel.Name = "IdCaptionLabel";
        IdCaptionLabel.Size = new Size(51, 17);
        IdCaptionLabel.TabIndex = 0;
        IdCaptionLabel.Text = "地域ID";
        IdCaptionLabel.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // LocationsDataGridView
        // 
        LocationsDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        LocationsDataGridView.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1, dataGridViewButtonColumn1 });
        LocationsDataGridView.Location = new Point(15, 127);
        LocationsDataGridView.Margin = new Padding(4, 3, 4, 3);
        LocationsDataGridView.Name = "LocationsDataGridView";
        LocationsDataGridView.RowHeadersVisible = false;
        LocationsDataGridView.Size = new Size(339, 170);
        LocationsDataGridView.TabIndex = 7;
        LocationsDataGridView.CellClick += LocationsDataGridView_CellClick;
        LocationsDataGridView.CellDoubleClick += LocationsDataGridView_CellDoubleClick;
        // 
        // dataGridViewTextBoxColumn1
        // 
        dataGridViewTextBoxColumn1.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
        dataGridViewTextBoxColumn1.DataPropertyName = "Name";
        dataGridViewTextBoxColumn1.HeaderText = "場所";
        dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
        dataGridViewTextBoxColumn1.ReadOnly = true;
        dataGridViewTextBoxColumn1.Width = 59;
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
        // LocationsCaptionLabel
        // 
        LocationsCaptionLabel.AutoSize = true;
        LocationsCaptionLabel.Location = new Point(15, 107);
        LocationsCaptionLabel.Margin = new Padding(4, 0, 4, 0);
        LocationsCaptionLabel.Name = "LocationsCaptionLabel";
        LocationsCaptionLabel.Size = new Size(34, 17);
        LocationsCaptionLabel.TabIndex = 6;
        LocationsCaptionLabel.Text = "場所";
        LocationsCaptionLabel.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // NamesDataGridView
        // 
        NamesDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        NamesDataGridView.Columns.AddRange(new DataGridViewColumn[] { NameColumn, LanguageColumn, DetailColumn });
        NamesDataGridView.Location = new Point(360, 127);
        NamesDataGridView.Margin = new Padding(4, 3, 4, 3);
        NamesDataGridView.Name = "NamesDataGridView";
        NamesDataGridView.RowHeadersVisible = false;
        NamesDataGridView.Size = new Size(379, 170);
        NamesDataGridView.TabIndex = 9;
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
        NamesCaptionLabel.Location = new Point(360, 107);
        NamesCaptionLabel.Margin = new Padding(4, 0, 4, 0);
        NamesCaptionLabel.Name = "NamesCaptionLabel";
        NamesCaptionLabel.Size = new Size(92, 17);
        NamesCaptionLabel.TabIndex = 8;
        NamesCaptionLabel.Text = "言語ごとの名前";
        NamesCaptionLabel.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // MainGenerationTextBox
        // 
        MainGenerationTextBox.Location = new Point(91, 72);
        MainGenerationTextBox.Margin = new Padding(5, 3, 5, 3);
        MainGenerationTextBox.Name = "MainGenerationTextBox";
        MainGenerationTextBox.ReadOnly = true;
        MainGenerationTextBox.Size = new Size(172, 24);
        MainGenerationTextBox.TabIndex = 5;
        // 
        // PokedexesDataGridView
        // 
        PokedexesDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        PokedexesDataGridView.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn2, dataGridViewButtonColumn2 });
        PokedexesDataGridView.Location = new Point(15, 320);
        PokedexesDataGridView.Margin = new Padding(4, 3, 4, 3);
        PokedexesDataGridView.Name = "PokedexesDataGridView";
        PokedexesDataGridView.RowHeadersVisible = false;
        PokedexesDataGridView.Size = new Size(339, 170);
        PokedexesDataGridView.TabIndex = 11;
        PokedexesDataGridView.CellClick += PokedexesDataGridView_CellClick;
        PokedexesDataGridView.CellDoubleClick += PokedexesDataGridView_CellDoubleClick;
        // 
        // dataGridViewTextBoxColumn2
        // 
        dataGridViewTextBoxColumn2.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
        dataGridViewTextBoxColumn2.DataPropertyName = "Name";
        dataGridViewTextBoxColumn2.HeaderText = "ポケモン図鑑";
        dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
        dataGridViewTextBoxColumn2.ReadOnly = true;
        // 
        // dataGridViewButtonColumn2
        // 
        dataGridViewButtonColumn2.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
        dataGridViewButtonColumn2.HeaderText = "詳細";
        dataGridViewButtonColumn2.Name = "dataGridViewButtonColumn2";
        dataGridViewButtonColumn2.Text = "詳細";
        dataGridViewButtonColumn2.UseColumnTextForButtonValue = true;
        dataGridViewButtonColumn2.Width = 40;
        // 
        // PokedexesCaptionLabel
        // 
        PokedexesCaptionLabel.AutoSize = true;
        PokedexesCaptionLabel.Location = new Point(15, 300);
        PokedexesCaptionLabel.Margin = new Padding(4, 0, 4, 0);
        PokedexesCaptionLabel.Name = "PokedexesCaptionLabel";
        PokedexesCaptionLabel.Size = new Size(75, 17);
        PokedexesCaptionLabel.TabIndex = 10;
        PokedexesCaptionLabel.Text = "ポケモン図鑑";
        PokedexesCaptionLabel.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // VersionGroupDataGridView
        // 
        VersionGroupDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        VersionGroupDataGridView.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn3, dataGridViewButtonColumn3 });
        VersionGroupDataGridView.Location = new Point(360, 320);
        VersionGroupDataGridView.Margin = new Padding(4, 3, 4, 3);
        VersionGroupDataGridView.Name = "VersionGroupDataGridView";
        VersionGroupDataGridView.RowHeadersVisible = false;
        VersionGroupDataGridView.Size = new Size(379, 170);
        VersionGroupDataGridView.TabIndex = 13;
        VersionGroupDataGridView.CellClick += VersionGroupDataGridView_CellClick;
        VersionGroupDataGridView.CellDoubleClick += VersionGroupDataGridView_CellDoubleClick;
        // 
        // dataGridViewTextBoxColumn3
        // 
        dataGridViewTextBoxColumn3.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
        dataGridViewTextBoxColumn3.DataPropertyName = "Name";
        dataGridViewTextBoxColumn3.HeaderText = "バージョングループ";
        dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
        dataGridViewTextBoxColumn3.ReadOnly = true;
        dataGridViewTextBoxColumn3.Width = 88;
        // 
        // dataGridViewButtonColumn3
        // 
        dataGridViewButtonColumn3.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
        dataGridViewButtonColumn3.HeaderText = "詳細";
        dataGridViewButtonColumn3.Name = "dataGridViewButtonColumn3";
        dataGridViewButtonColumn3.Text = "詳細";
        dataGridViewButtonColumn3.UseColumnTextForButtonValue = true;
        dataGridViewButtonColumn3.Width = 36;
        // 
        // VersionGroupCaptionLabel
        // 
        VersionGroupCaptionLabel.AutoSize = true;
        VersionGroupCaptionLabel.Location = new Point(360, 300);
        VersionGroupCaptionLabel.Margin = new Padding(4, 0, 4, 0);
        VersionGroupCaptionLabel.Name = "VersionGroupCaptionLabel";
        VersionGroupCaptionLabel.Size = new Size(104, 17);
        VersionGroupCaptionLabel.TabIndex = 12;
        VersionGroupCaptionLabel.Text = "バージョングループ";
        VersionGroupCaptionLabel.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // CloseButton
        // 
        CloseButton.Location = new Point(663, 496);
        CloseButton.Margin = new Padding(4, 3, 4, 3);
        CloseButton.Name = "CloseButton";
        CloseButton.Size = new Size(76, 35);
        CloseButton.TabIndex = 15;
        CloseButton.Text = "閉じる";
        CloseButton.UseVisualStyleBackColor = true;
        CloseButton.Click += CloseButton_Click;
        // 
        // MainGenerationButton
        // 
        MainGenerationButton.Location = new Point(12, 69);
        MainGenerationButton.Name = "MainGenerationButton";
        MainGenerationButton.Size = new Size(78, 28);
        MainGenerationButton.TabIndex = 4;
        MainGenerationButton.Text = "メイン世代";
        MainGenerationButton.UseVisualStyleBackColor = true;
        MainGenerationButton.Click += MainGenerationDetailButton_Click;
        // 
        // PropertyButton
        // 
        PropertyButton.Location = new Point(579, 496);
        PropertyButton.Margin = new Padding(4, 3, 4, 3);
        PropertyButton.Name = "PropertyButton";
        PropertyButton.Size = new Size(76, 35);
        PropertyButton.TabIndex = 14;
        PropertyButton.Text = "プロパティ";
        PropertyButton.UseVisualStyleBackColor = true;
        PropertyButton.Click += PropertyButton_Click;
        // 
        // RegionInfoForm
        // 
        AutoScaleDimensions = new SizeF(9F, 17F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(748, 547);
        Controls.Add(PropertyButton);
        Controls.Add(MainGenerationButton);
        Controls.Add(CloseButton);
        Controls.Add(VersionGroupDataGridView);
        Controls.Add(VersionGroupCaptionLabel);
        Controls.Add(PokedexesDataGridView);
        Controls.Add(PokedexesCaptionLabel);
        Controls.Add(MainGenerationTextBox);
        Controls.Add(NamesDataGridView);
        Controls.Add(NamesCaptionLabel);
        Controls.Add(LocationsDataGridView);
        Controls.Add(LocationsCaptionLabel);
        Controls.Add(NameTextBox);
        Controls.Add(IdTextBox);
        Controls.Add(NameCaptionLabel);
        Controls.Add(IdCaptionLabel);
        Font = new Font("Meiryo UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 128);
        FormBorderStyle = FormBorderStyle.FixedSingle;
        Margin = new Padding(4, 3, 4, 3);
        MaximizeBox = false;
        Name = "RegionInfoForm";
        StartPosition = FormStartPosition.CenterParent;
        Text = "地域";
        ((System.ComponentModel.ISupportInitialize)LocationsDataGridView).EndInit();
        ((System.ComponentModel.ISupportInitialize)NamesDataGridView).EndInit();
        ((System.ComponentModel.ISupportInitialize)PokedexesDataGridView).EndInit();
        ((System.ComponentModel.ISupportInitialize)VersionGroupDataGridView).EndInit();
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private TextBox NameTextBox;
    private TextBox IdTextBox;
    private Label NameCaptionLabel;
    private Label IdCaptionLabel;
    private DataGridView LocationsDataGridView;
    private Label LocationsCaptionLabel;
    private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
    private DataGridViewButtonColumn dataGridViewButtonColumn1;
    private DataGridView NamesDataGridView;
    private DataGridViewTextBoxColumn NameColumn;
    private DataGridViewTextBoxColumn LanguageColumn;
    private DataGridViewButtonColumn DetailColumn;
    private Label NamesCaptionLabel;
    private Label MainGenerationCaptionLabel;
    private TextBox MainGenerationTextBox;
    private DataGridView PokedexesDataGridView;
    private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
    private DataGridViewButtonColumn dataGridViewButtonColumn2;
    private Label PokedexesCaptionLabel;
    private DataGridView VersionGroupDataGridView;
    private Label VersionGroupCaptionLabel;
    private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
    private DataGridViewButtonColumn dataGridViewButtonColumn3;
    private Button CloseButton;
    private Button MainGenerationButton;
    private Button PropertyButton;
}