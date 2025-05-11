namespace Kos.PokeAPI.Forms;

partial class ItemPocketInfoForm
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
        CategoriesDataGridView = new DataGridView();
        dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
        dataGridViewButtonColumn1 = new DataGridViewButtonColumn();
        CategoryCaptionLabel = new Label();
        NamesDataGridView = new DataGridView();
        NameColumn = new DataGridViewTextBoxColumn();
        LanguageColumn = new DataGridViewTextBoxColumn();
        DetailColumn = new DataGridViewButtonColumn();
        NamesCaptionLabel = new Label();
        CloseButton = new Button();
        PropertyButton = new Button();
        ((System.ComponentModel.ISupportInitialize)CategoriesDataGridView).BeginInit();
        ((System.ComponentModel.ISupportInitialize)NamesDataGridView).BeginInit();
        SuspendLayout();
        // 
        // NameTextBox
        // 
        NameTextBox.Location = new Point(130, 42);
        NameTextBox.Margin = new Padding(4, 3, 4, 3);
        NameTextBox.Name = "NameTextBox";
        NameTextBox.ReadOnly = true;
        NameTextBox.Size = new Size(244, 24);
        NameTextBox.TabIndex = 3;
        // 
        // IdTextBox
        // 
        IdTextBox.Location = new Point(130, 12);
        IdTextBox.Margin = new Padding(4, 3, 4, 3);
        IdTextBox.Name = "IdTextBox";
        IdTextBox.ReadOnly = true;
        IdTextBox.Size = new Size(244, 24);
        IdTextBox.TabIndex = 1;
        // 
        // NameCaptionLabel
        // 
        NameCaptionLabel.AutoSize = true;
        NameCaptionLabel.Location = new Point(18, 45);
        NameCaptionLabel.Margin = new Padding(5, 0, 5, 0);
        NameCaptionLabel.Name = "NameCaptionLabel";
        NameCaptionLabel.Size = new Size(103, 17);
        NameCaptionLabel.TabIndex = 2;
        NameCaptionLabel.Text = "アイテムポケット名";
        NameCaptionLabel.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // IdCaptionLabel
        // 
        IdCaptionLabel.AutoSize = true;
        IdCaptionLabel.Location = new Point(14, 15);
        IdCaptionLabel.Margin = new Padding(5, 0, 5, 0);
        IdCaptionLabel.Name = "IdCaptionLabel";
        IdCaptionLabel.Size = new Size(107, 17);
        IdCaptionLabel.TabIndex = 0;
        IdCaptionLabel.Text = "アイテムポケットID";
        IdCaptionLabel.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // CategoriesDataGridView
        // 
        CategoriesDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        CategoriesDataGridView.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1, dataGridViewButtonColumn1 });
        CategoriesDataGridView.Location = new Point(14, 95);
        CategoriesDataGridView.Margin = new Padding(4, 3, 4, 3);
        CategoriesDataGridView.Name = "CategoriesDataGridView";
        CategoriesDataGridView.RowHeadersVisible = false;
        CategoriesDataGridView.Size = new Size(339, 170);
        CategoriesDataGridView.TabIndex = 5;
        CategoriesDataGridView.CellClick += CategoriesDataGridView_CellClick;
        CategoriesDataGridView.CellDoubleClick += CategoriesDataGridView_CellDoubleClick;
        // 
        // dataGridViewTextBoxColumn1
        // 
        dataGridViewTextBoxColumn1.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
        dataGridViewTextBoxColumn1.DataPropertyName = "Name";
        dataGridViewTextBoxColumn1.HeaderText = "カテゴリ";
        dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
        dataGridViewTextBoxColumn1.ReadOnly = true;
        dataGridViewTextBoxColumn1.Width = 73;
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
        // CategoryCaptionLabel
        // 
        CategoryCaptionLabel.AutoSize = true;
        CategoryCaptionLabel.Location = new Point(13, 75);
        CategoryCaptionLabel.Margin = new Padding(4, 0, 4, 0);
        CategoryCaptionLabel.Name = "CategoryCaptionLabel";
        CategoryCaptionLabel.Size = new Size(48, 17);
        CategoryCaptionLabel.TabIndex = 4;
        CategoryCaptionLabel.Text = "カテゴリ";
        CategoryCaptionLabel.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // NamesDataGridView
        // 
        NamesDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        NamesDataGridView.Columns.AddRange(new DataGridViewColumn[] { NameColumn, LanguageColumn, DetailColumn });
        NamesDataGridView.Location = new Point(361, 95);
        NamesDataGridView.Margin = new Padding(4, 3, 4, 3);
        NamesDataGridView.Name = "NamesDataGridView";
        NamesDataGridView.RowHeadersVisible = false;
        NamesDataGridView.Size = new Size(379, 170);
        NamesDataGridView.TabIndex = 7;
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
        NamesCaptionLabel.Location = new Point(361, 75);
        NamesCaptionLabel.Margin = new Padding(4, 0, 4, 0);
        NamesCaptionLabel.Name = "NamesCaptionLabel";
        NamesCaptionLabel.Size = new Size(92, 17);
        NamesCaptionLabel.TabIndex = 6;
        NamesCaptionLabel.Text = "言語ごとの名前";
        NamesCaptionLabel.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // CloseButton
        // 
        CloseButton.Location = new Point(664, 271);
        CloseButton.Margin = new Padding(4, 3, 4, 3);
        CloseButton.Name = "CloseButton";
        CloseButton.Size = new Size(76, 35);
        CloseButton.TabIndex = 9;
        CloseButton.Text = "閉じる";
        CloseButton.UseVisualStyleBackColor = true;
        CloseButton.Click += CloseButton_Click;
        // 
        // PropertyButton
        // 
        PropertyButton.Location = new Point(580, 271);
        PropertyButton.Margin = new Padding(4, 3, 4, 3);
        PropertyButton.Name = "PropertyButton";
        PropertyButton.Size = new Size(76, 35);
        PropertyButton.TabIndex = 8;
        PropertyButton.Text = "プロパティ";
        PropertyButton.UseVisualStyleBackColor = true;
        PropertyButton.Click += PropertyButton_Click;
        // 
        // ItemPocketInfoForm
        // 
        AutoScaleDimensions = new SizeF(9F, 17F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(755, 312);
        Controls.Add(PropertyButton);
        Controls.Add(CloseButton);
        Controls.Add(NamesDataGridView);
        Controls.Add(NamesCaptionLabel);
        Controls.Add(CategoriesDataGridView);
        Controls.Add(CategoryCaptionLabel);
        Controls.Add(NameTextBox);
        Controls.Add(IdTextBox);
        Controls.Add(NameCaptionLabel);
        Controls.Add(IdCaptionLabel);
        Font = new Font("Meiryo UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 128);
        FormBorderStyle = FormBorderStyle.FixedSingle;
        Margin = new Padding(4, 3, 4, 3);
        MaximizeBox = false;
        Name = "ItemPocketInfoForm";
        StartPosition = FormStartPosition.CenterParent;
        Text = "アイテムポケット";
        ((System.ComponentModel.ISupportInitialize)CategoriesDataGridView).EndInit();
        ((System.ComponentModel.ISupportInitialize)NamesDataGridView).EndInit();
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private TextBox NameTextBox;
    private TextBox IdTextBox;
    private Label NameCaptionLabel;
    private Label IdCaptionLabel;
    private DataGridView CategoriesDataGridView;
    private Label CategoryCaptionLabel;
    private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
    private DataGridViewButtonColumn dataGridViewButtonColumn1;
    private DataGridView NamesDataGridView;
    private DataGridViewTextBoxColumn NameColumn;
    private DataGridViewTextBoxColumn LanguageColumn;
    private DataGridViewButtonColumn DetailColumn;
    private Label NamesCaptionLabel;
    private Button CloseButton;
    private Button PropertyButton;
}