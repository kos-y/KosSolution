namespace Kos.PokeAPI.Forms;

partial class LocationAreaInfoForm
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
        GameIndexCaptionLabel = new Label();
        GameIndexTextBox = new TextBox();
        LocationTextBox = new TextBox();
        LocationCatpionLabel = new Label();
        NamesDataGridView = new DataGridView();
        NameColumn = new DataGridViewTextBoxColumn();
        LanguageColumn = new DataGridViewTextBoxColumn();
        DetailColumn = new DataGridViewButtonColumn();
        NamesCaptionLabel = new Label();
        EncounterMethodRateDataGridView = new DataGridView();
        dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
        dataGridViewButtonColumn1 = new DataGridViewButtonColumn();
        EncounterMethodRateCaptionLabel = new Label();
        PokemonEncountersCaptionLabel = new Label();
        PokemonEncountersDataGridView = new DataGridView();
        CloseButton = new Button();
        LocationDetailButton = new Button();
        dataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
        dataGridViewButtonColumn3 = new DataGridViewButtonColumn();
        ((System.ComponentModel.ISupportInitialize)NamesDataGridView).BeginInit();
        ((System.ComponentModel.ISupportInitialize)EncounterMethodRateDataGridView).BeginInit();
        ((System.ComponentModel.ISupportInitialize)PokemonEncountersDataGridView).BeginInit();
        SuspendLayout();
        // 
        // NameTextBox
        // 
        NameTextBox.Location = new Point(101, 36);
        NameTextBox.Name = "NameTextBox";
        NameTextBox.ReadOnly = true;
        NameTextBox.Size = new Size(413, 24);
        NameTextBox.TabIndex = 3;
        // 
        // IdTextBox
        // 
        IdTextBox.Location = new Point(101, 6);
        IdTextBox.Name = "IdTextBox";
        IdTextBox.ReadOnly = true;
        IdTextBox.Size = new Size(413, 24);
        IdTextBox.TabIndex = 1;
        // 
        // NameCaptionLabel
        // 
        NameCaptionLabel.AutoSize = true;
        NameCaptionLabel.Location = new Point(17, 39);
        NameCaptionLabel.Margin = new Padding(4, 0, 4, 0);
        NameCaptionLabel.Name = "NameCaptionLabel";
        NameCaptionLabel.Size = new Size(77, 17);
        NameCaptionLabel.TabIndex = 2;
        NameCaptionLabel.Text = "場所エリア名";
        NameCaptionLabel.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // IdCaptionLabel
        // 
        IdCaptionLabel.AutoSize = true;
        IdCaptionLabel.Location = new Point(13, 9);
        IdCaptionLabel.Margin = new Padding(4, 0, 4, 0);
        IdCaptionLabel.Name = "IdCaptionLabel";
        IdCaptionLabel.Size = new Size(81, 17);
        IdCaptionLabel.TabIndex = 0;
        IdCaptionLabel.Text = "場所エリアID";
        IdCaptionLabel.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // GameIndexCaptionLabel
        // 
        GameIndexCaptionLabel.AutoSize = true;
        GameIndexCaptionLabel.Location = new Point(45, 69);
        GameIndexCaptionLabel.Margin = new Padding(4, 0, 4, 0);
        GameIndexCaptionLabel.Name = "GameIndexCaptionLabel";
        GameIndexCaptionLabel.Size = new Size(49, 17);
        GameIndexCaptionLabel.TabIndex = 4;
        GameIndexCaptionLabel.Text = "Index";
        GameIndexCaptionLabel.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // GameIndexTextBox
        // 
        GameIndexTextBox.Location = new Point(101, 66);
        GameIndexTextBox.Name = "GameIndexTextBox";
        GameIndexTextBox.ReadOnly = true;
        GameIndexTextBox.Size = new Size(413, 24);
        GameIndexTextBox.TabIndex = 5;
        // 
        // LocationTextBox
        // 
        LocationTextBox.Location = new Point(101, 96);
        LocationTextBox.Name = "LocationTextBox";
        LocationTextBox.ReadOnly = true;
        LocationTextBox.Size = new Size(354, 24);
        LocationTextBox.TabIndex = 7;
        // 
        // LocationCatpionLabel
        // 
        LocationCatpionLabel.AutoSize = true;
        LocationCatpionLabel.Location = new Point(60, 99);
        LocationCatpionLabel.Margin = new Padding(4, 0, 4, 0);
        LocationCatpionLabel.Name = "LocationCatpionLabel";
        LocationCatpionLabel.Size = new Size(34, 17);
        LocationCatpionLabel.TabIndex = 6;
        LocationCatpionLabel.Text = "場所";
        LocationCatpionLabel.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // NamesDataGridView
        // 
        NamesDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        NamesDataGridView.Columns.AddRange(new DataGridViewColumn[] { NameColumn, LanguageColumn, DetailColumn });
        NamesDataGridView.Location = new Point(17, 143);
        NamesDataGridView.Margin = new Padding(4, 3, 4, 3);
        NamesDataGridView.Name = "NamesDataGridView";
        NamesDataGridView.RowHeadersVisible = false;
        NamesDataGridView.Size = new Size(224, 170);
        NamesDataGridView.TabIndex = 10;
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
        NamesCaptionLabel.Location = new Point(17, 123);
        NamesCaptionLabel.Margin = new Padding(4, 0, 4, 0);
        NamesCaptionLabel.Name = "NamesCaptionLabel";
        NamesCaptionLabel.Size = new Size(92, 17);
        NamesCaptionLabel.TabIndex = 9;
        NamesCaptionLabel.Text = "言語ごとの名前";
        NamesCaptionLabel.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // EncounterMethodRateDataGridView
        // 
        EncounterMethodRateDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        EncounterMethodRateDataGridView.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1, dataGridViewButtonColumn1 });
        EncounterMethodRateDataGridView.Location = new Point(249, 143);
        EncounterMethodRateDataGridView.Margin = new Padding(4, 3, 4, 3);
        EncounterMethodRateDataGridView.Name = "EncounterMethodRateDataGridView";
        EncounterMethodRateDataGridView.RowHeadersVisible = false;
        EncounterMethodRateDataGridView.Size = new Size(265, 170);
        EncounterMethodRateDataGridView.TabIndex = 12;
        EncounterMethodRateDataGridView.CellClick += EncounterMethodRateDataGridView_CellClick;
        EncounterMethodRateDataGridView.CellDoubleClick += EncounterMethodRateDataGridView_CellDoubleClick;
        // 
        // dataGridViewTextBoxColumn1
        // 
        dataGridViewTextBoxColumn1.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
        dataGridViewTextBoxColumn1.DataPropertyName = "EncounterMethod";
        dataGridViewTextBoxColumn1.HeaderText = "遭遇方法";
        dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
        dataGridViewTextBoxColumn1.ReadOnly = true;
        dataGridViewTextBoxColumn1.Width = 85;
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
        // EncounterMethodRateCaptionLabel
        // 
        EncounterMethodRateCaptionLabel.AutoSize = true;
        EncounterMethodRateCaptionLabel.Location = new Point(249, 123);
        EncounterMethodRateCaptionLabel.Margin = new Padding(4, 0, 4, 0);
        EncounterMethodRateCaptionLabel.Name = "EncounterMethodRateCaptionLabel";
        EncounterMethodRateCaptionLabel.Size = new Size(47, 17);
        EncounterMethodRateCaptionLabel.TabIndex = 11;
        EncounterMethodRateCaptionLabel.Text = "遭遇率";
        EncounterMethodRateCaptionLabel.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // PokemonEncountersCaptionLabel
        // 
        PokemonEncountersCaptionLabel.AutoSize = true;
        PokemonEncountersCaptionLabel.Location = new Point(17, 316);
        PokemonEncountersCaptionLabel.Margin = new Padding(4, 0, 4, 0);
        PokemonEncountersCaptionLabel.Name = "PokemonEncountersCaptionLabel";
        PokemonEncountersCaptionLabel.Size = new Size(75, 17);
        PokemonEncountersCaptionLabel.TabIndex = 13;
        PokemonEncountersCaptionLabel.Text = "遭遇ポケモン";
        PokemonEncountersCaptionLabel.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // PokemonEncountersDataGridView
        // 
        PokemonEncountersDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        PokemonEncountersDataGridView.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn3, dataGridViewButtonColumn3 });
        PokemonEncountersDataGridView.Location = new Point(17, 336);
        PokemonEncountersDataGridView.Name = "PokemonEncountersDataGridView";
        PokemonEncountersDataGridView.RowHeadersVisible = false;
        PokemonEncountersDataGridView.Size = new Size(497, 150);
        PokemonEncountersDataGridView.TabIndex = 14;
        PokemonEncountersDataGridView.CellClick += PokemonEncountersDataGridView_CellClick;
        PokemonEncountersDataGridView.CellDoubleClick += PokemonEncountersDataGridView_CellDoubleClick;
        // 
        // CloseButton
        // 
        CloseButton.Location = new Point(451, 492);
        CloseButton.Name = "CloseButton";
        CloseButton.Size = new Size(63, 35);
        CloseButton.TabIndex = 15;
        CloseButton.Text = "閉じる";
        CloseButton.UseVisualStyleBackColor = true;
        CloseButton.Click += CloseButton_Click;
        // 
        // LocationDetailButton
        // 
        LocationDetailButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
        LocationDetailButton.Location = new Point(461, 96);
        LocationDetailButton.Name = "LocationDetailButton";
        LocationDetailButton.Size = new Size(53, 24);
        LocationDetailButton.TabIndex = 8;
        LocationDetailButton.Text = "詳細";
        LocationDetailButton.UseVisualStyleBackColor = true;
        LocationDetailButton.Click += LocationDetailButton_Click;
        // 
        // dataGridViewTextBoxColumn3
        // 
        dataGridViewTextBoxColumn3.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
        dataGridViewTextBoxColumn3.DataPropertyName = "Pokemon";
        dataGridViewTextBoxColumn3.HeaderText = "ポケモン";
        dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
        dataGridViewTextBoxColumn3.ReadOnly = true;
        dataGridViewTextBoxColumn3.Width = 74;
        // 
        // dataGridViewButtonColumn3
        // 
        dataGridViewButtonColumn3.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
        dataGridViewButtonColumn3.HeaderText = "詳細";
        dataGridViewButtonColumn3.Name = "dataGridViewButtonColumn3";
        dataGridViewButtonColumn3.Text = "詳細";
        dataGridViewButtonColumn3.UseColumnTextForButtonValue = true;
        dataGridViewButtonColumn3.Width = 40;
        // 
        // LocationAreaInfoForm
        // 
        AutoScaleDimensions = new SizeF(9F, 17F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(531, 536);
        Controls.Add(LocationDetailButton);
        Controls.Add(CloseButton);
        Controls.Add(PokemonEncountersDataGridView);
        Controls.Add(PokemonEncountersCaptionLabel);
        Controls.Add(EncounterMethodRateDataGridView);
        Controls.Add(EncounterMethodRateCaptionLabel);
        Controls.Add(NamesDataGridView);
        Controls.Add(NamesCaptionLabel);
        Controls.Add(LocationCatpionLabel);
        Controls.Add(LocationTextBox);
        Controls.Add(GameIndexTextBox);
        Controls.Add(GameIndexCaptionLabel);
        Controls.Add(NameTextBox);
        Controls.Add(IdTextBox);
        Controls.Add(NameCaptionLabel);
        Controls.Add(IdCaptionLabel);
        Font = new Font("Meiryo UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 128);
        FormBorderStyle = FormBorderStyle.FixedSingle;
        Margin = new Padding(4, 3, 4, 3);
        MaximizeBox = false;
        Name = "LocationAreaInfoForm";
        StartPosition = FormStartPosition.CenterParent;
        Text = "場所エリア";
        ((System.ComponentModel.ISupportInitialize)NamesDataGridView).EndInit();
        ((System.ComponentModel.ISupportInitialize)EncounterMethodRateDataGridView).EndInit();
        ((System.ComponentModel.ISupportInitialize)PokemonEncountersDataGridView).EndInit();
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private TextBox NameTextBox;
    private TextBox IdTextBox;
    private Label NameCaptionLabel;
    private Label IdCaptionLabel;
    private Label GameIndexCaptionLabel;
    private TextBox GameIndexTextBox;
    private TextBox LocationTextBox;
    private Label LocationCatpionLabel;
    private DataGridView NamesDataGridView;
    private DataGridViewTextBoxColumn NameColumn;
    private DataGridViewTextBoxColumn LanguageColumn;
    private DataGridViewButtonColumn DetailColumn;
    private Label NamesCaptionLabel;
    private DataGridView EncounterMethodRateDataGridView;
    private Label EncounterMethodRateCaptionLabel;
    private Label PokemonEncountersCaptionLabel;
    private DataGridView PokemonEncountersDataGridView;
    private Button CloseButton;
    private Button LocationDetailButton;
    private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
    private DataGridViewButtonColumn dataGridViewButtonColumn1;
    private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
    private DataGridViewButtonColumn dataGridViewButtonColumn3;
}