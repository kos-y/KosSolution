namespace Kos.PokeAPI.Forms;

partial class ItemCategoryInfoForm
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
        ItemDataGridView = new DataGridView();
        ItemNameColumn = new DataGridViewTextBoxColumn();
        dataGridViewButtonColumn1 = new DataGridViewButtonColumn();
        ItemCaptionLabel = new Label();
        NamesDataGridView = new DataGridView();
        NameColumn = new DataGridViewTextBoxColumn();
        LanguageColumn = new DataGridViewTextBoxColumn();
        DetailColumn = new DataGridViewButtonColumn();
        NamesCaptionLabel = new Label();
        PocketTextBox = new TextBox();
        CloseButton = new Button();
        PocketButton = new Button();
        button1 = new Button();
        ((System.ComponentModel.ISupportInitialize)ItemDataGridView).BeginInit();
        ((System.ComponentModel.ISupportInitialize)NamesDataGridView).BeginInit();
        SuspendLayout();
        // 
        // NameTextBox
        // 
        NameTextBox.Location = new Point(139, 42);
        NameTextBox.Name = "NameTextBox";
        NameTextBox.ReadOnly = true;
        NameTextBox.Size = new Size(215, 24);
        NameTextBox.TabIndex = 3;
        // 
        // IdTextBox
        // 
        IdTextBox.Location = new Point(139, 12);
        IdTextBox.Name = "IdTextBox";
        IdTextBox.ReadOnly = true;
        IdTextBox.Size = new Size(214, 24);
        IdTextBox.TabIndex = 1;
        // 
        // NameCaptionLabel
        // 
        NameCaptionLabel.AutoSize = true;
        NameCaptionLabel.Location = new Point(17, 45);
        NameCaptionLabel.Margin = new Padding(4, 0, 4, 0);
        NameCaptionLabel.Name = "NameCaptionLabel";
        NameCaptionLabel.Size = new Size(115, 17);
        NameCaptionLabel.TabIndex = 2;
        NameCaptionLabel.Text = "アイテムカテゴリー名";
        NameCaptionLabel.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // IdCaptionLabel
        // 
        IdCaptionLabel.AutoSize = true;
        IdCaptionLabel.Location = new Point(13, 15);
        IdCaptionLabel.Margin = new Padding(4, 0, 4, 0);
        IdCaptionLabel.Name = "IdCaptionLabel";
        IdCaptionLabel.Size = new Size(119, 17);
        IdCaptionLabel.TabIndex = 0;
        IdCaptionLabel.Text = "アイテムカテゴリーID";
        IdCaptionLabel.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // ItemDataGridView
        // 
        ItemDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        ItemDataGridView.Columns.AddRange(new DataGridViewColumn[] { ItemNameColumn, dataGridViewButtonColumn1 });
        ItemDataGridView.Location = new Point(13, 132);
        ItemDataGridView.Margin = new Padding(4, 3, 4, 3);
        ItemDataGridView.Name = "ItemDataGridView";
        ItemDataGridView.RowHeadersVisible = false;
        ItemDataGridView.Size = new Size(340, 237);
        ItemDataGridView.TabIndex = 7;
        ItemDataGridView.CellClick += ItemDataGridView_CellClick;
        ItemDataGridView.CellDoubleClick += ItemDataGridView_CellDoubleClick;
        // 
        // ItemNameColumn
        // 
        ItemNameColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
        ItemNameColumn.DataPropertyName = "Name";
        ItemNameColumn.HeaderText = "アイテム";
        ItemNameColumn.Name = "ItemNameColumn";
        ItemNameColumn.ReadOnly = true;
        ItemNameColumn.Width = 76;
        // 
        // dataGridViewButtonColumn1
        // 
        dataGridViewButtonColumn1.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
        dataGridViewButtonColumn1.HeaderText = "詳細";
        dataGridViewButtonColumn1.Name = "dataGridViewButtonColumn1";
        dataGridViewButtonColumn1.Text = "詳細";
        dataGridViewButtonColumn1.UseColumnTextForButtonValue = true;
        dataGridViewButtonColumn1.Width = 23;
        // 
        // ItemCaptionLabel
        // 
        ItemCaptionLabel.AutoSize = true;
        ItemCaptionLabel.Location = new Point(13, 112);
        ItemCaptionLabel.Margin = new Padding(4, 0, 4, 0);
        ItemCaptionLabel.Name = "ItemCaptionLabel";
        ItemCaptionLabel.Size = new Size(51, 17);
        ItemCaptionLabel.TabIndex = 6;
        ItemCaptionLabel.Text = "アイテム";
        ItemCaptionLabel.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // NamesDataGridView
        // 
        NamesDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        NamesDataGridView.Columns.AddRange(new DataGridViewColumn[] { NameColumn, LanguageColumn, DetailColumn });
        NamesDataGridView.Location = new Point(361, 132);
        NamesDataGridView.Margin = new Padding(4, 3, 4, 3);
        NamesDataGridView.Name = "NamesDataGridView";
        NamesDataGridView.RowHeadersVisible = false;
        NamesDataGridView.Size = new Size(379, 237);
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
        NamesCaptionLabel.Location = new Point(361, 112);
        NamesCaptionLabel.Margin = new Padding(4, 0, 4, 0);
        NamesCaptionLabel.Name = "NamesCaptionLabel";
        NamesCaptionLabel.Size = new Size(92, 17);
        NamesCaptionLabel.TabIndex = 8;
        NamesCaptionLabel.Text = "言語ごとの名前";
        NamesCaptionLabel.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // PocketTextBox
        // 
        PocketTextBox.Location = new Point(138, 72);
        PocketTextBox.Name = "PocketTextBox";
        PocketTextBox.ReadOnly = true;
        PocketTextBox.Size = new Size(215, 24);
        PocketTextBox.TabIndex = 5;
        // 
        // CloseButton
        // 
        CloseButton.Location = new Point(667, 375);
        CloseButton.Margin = new Padding(4, 3, 4, 3);
        CloseButton.Name = "CloseButton";
        CloseButton.Size = new Size(76, 35);
        CloseButton.TabIndex = 11;
        CloseButton.Text = "閉じる";
        CloseButton.UseVisualStyleBackColor = true;
        CloseButton.Click += CloseButton_Click;
        // 
        // PocketButton
        // 
        PocketButton.Location = new Point(73, 72);
        PocketButton.Margin = new Padding(4, 3, 4, 3);
        PocketButton.Name = "PocketButton";
        PocketButton.Size = new Size(58, 26);
        PocketButton.TabIndex = 4;
        PocketButton.Text = "ポケット";
        PocketButton.UseVisualStyleBackColor = true;
        PocketButton.Click += PocketButton_Click;
        // 
        // button1
        // 
        button1.Location = new Point(583, 375);
        button1.Margin = new Padding(4, 3, 4, 3);
        button1.Name = "button1";
        button1.Size = new Size(76, 35);
        button1.TabIndex = 10;
        button1.Text = "プロパティ";
        button1.UseVisualStyleBackColor = true;
        button1.Click += button1_Click;
        // 
        // ItemCategoryInfoForm
        // 
        AutoScaleDimensions = new SizeF(9F, 17F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(756, 420);
        Controls.Add(button1);
        Controls.Add(PocketButton);
        Controls.Add(CloseButton);
        Controls.Add(PocketTextBox);
        Controls.Add(NamesDataGridView);
        Controls.Add(NamesCaptionLabel);
        Controls.Add(ItemDataGridView);
        Controls.Add(ItemCaptionLabel);
        Controls.Add(NameTextBox);
        Controls.Add(IdTextBox);
        Controls.Add(NameCaptionLabel);
        Controls.Add(IdCaptionLabel);
        Font = new Font("Meiryo UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 128);
        FormBorderStyle = FormBorderStyle.FixedSingle;
        Margin = new Padding(4, 3, 4, 3);
        MaximizeBox = false;
        Name = "ItemCategoryInfoForm";
        StartPosition = FormStartPosition.CenterParent;
        Text = "アイテムカテゴリー";
        ((System.ComponentModel.ISupportInitialize)ItemDataGridView).EndInit();
        ((System.ComponentModel.ISupportInitialize)NamesDataGridView).EndInit();
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private TextBox NameTextBox;
    private TextBox IdTextBox;
    private Label NameCaptionLabel;
    private Label IdCaptionLabel;
    private DataGridView ItemDataGridView;
    private DataGridViewTextBoxColumn ItemNameColumn;
    private DataGridViewButtonColumn dataGridViewButtonColumn1;
    private Label ItemCaptionLabel;
    private DataGridView NamesDataGridView;
    private Label NamesCaptionLabel;
    private TextBox PocketTextBox;
    private Button CloseButton;
    private Button PocketButton;
    private DataGridViewTextBoxColumn NameColumn;
    private DataGridViewTextBoxColumn LanguageColumn;
    private DataGridViewButtonColumn DetailColumn;
    private Button button1;
}