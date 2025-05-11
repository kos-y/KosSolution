namespace Kos.PokeAPI.Forms;

partial class ItemFlingEffectInfoForm
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
        EffectCaptionLabel = new Label();
        EffectEntriesDataGridView = new DataGridView();
        EffectColumn = new DataGridViewTextBoxColumn();
        EffectLanguageColumn = new DataGridViewTextBoxColumn();
        EffectLanguageDetailButtonColumn = new DataGridViewButtonColumn();
        CloseButton = new Button();
        ItemDataGridView = new DataGridView();
        ItemNameColumn = new DataGridViewTextBoxColumn();
        dataGridViewButtonColumn1 = new DataGridViewButtonColumn();
        ItemCaptionLabel = new Label();
        PropertyButton = new Button();
        ((System.ComponentModel.ISupportInitialize)EffectEntriesDataGridView).BeginInit();
        ((System.ComponentModel.ISupportInitialize)ItemDataGridView).BeginInit();
        SuspendLayout();
        // 
        // NameTextBox
        // 
        NameTextBox.Location = new Point(154, 42);
        NameTextBox.Name = "NameTextBox";
        NameTextBox.ReadOnly = true;
        NameTextBox.Size = new Size(578, 24);
        NameTextBox.TabIndex = 3;
        // 
        // IdTextBox
        // 
        IdTextBox.Location = new Point(154, 12);
        IdTextBox.Name = "IdTextBox";
        IdTextBox.ReadOnly = true;
        IdTextBox.Size = new Size(578, 24);
        IdTextBox.TabIndex = 1;
        // 
        // NameCaptionLabel
        // 
        NameCaptionLabel.AutoSize = true;
        NameCaptionLabel.Location = new Point(17, 45);
        NameCaptionLabel.Margin = new Padding(4, 0, 4, 0);
        NameCaptionLabel.Name = "NameCaptionLabel";
        NameCaptionLabel.Size = new Size(130, 17);
        NameCaptionLabel.TabIndex = 2;
        NameCaptionLabel.Text = "「投げつける」の効果名";
        NameCaptionLabel.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // IdCaptionLabel
        // 
        IdCaptionLabel.AutoSize = true;
        IdCaptionLabel.Location = new Point(13, 15);
        IdCaptionLabel.Margin = new Padding(4, 0, 4, 0);
        IdCaptionLabel.Name = "IdCaptionLabel";
        IdCaptionLabel.Size = new Size(134, 17);
        IdCaptionLabel.TabIndex = 0;
        IdCaptionLabel.Text = "「投げつける」の効果ID";
        IdCaptionLabel.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // EffectCaptionLabel
        // 
        EffectCaptionLabel.AutoSize = true;
        EffectCaptionLabel.Location = new Point(13, 78);
        EffectCaptionLabel.Margin = new Padding(4, 0, 4, 0);
        EffectCaptionLabel.Name = "EffectCaptionLabel";
        EffectCaptionLabel.Size = new Size(34, 17);
        EffectCaptionLabel.TabIndex = 4;
        EffectCaptionLabel.Text = "効果";
        EffectCaptionLabel.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // EffectEntriesDataGridView
        // 
        EffectEntriesDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        EffectEntriesDataGridView.Columns.AddRange(new DataGridViewColumn[] { EffectColumn, EffectLanguageColumn, EffectLanguageDetailButtonColumn });
        EffectEntriesDataGridView.Location = new Point(13, 98);
        EffectEntriesDataGridView.Margin = new Padding(4, 3, 4, 3);
        EffectEntriesDataGridView.Name = "EffectEntriesDataGridView";
        EffectEntriesDataGridView.RowHeadersVisible = false;
        EffectEntriesDataGridView.Size = new Size(356, 168);
        EffectEntriesDataGridView.TabIndex = 5;
        EffectEntriesDataGridView.CellClick += EffectEntriesDataGridView_CellClick;
        EffectEntriesDataGridView.CellDoubleClick += EffectEntriesDataGridView_CellDoubleClick;
        // 
        // EffectColumn
        // 
        EffectColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
        EffectColumn.DataPropertyName = "Text";
        EffectColumn.HeaderText = "効果";
        EffectColumn.Name = "EffectColumn";
        EffectColumn.ReadOnly = true;
        EffectColumn.Width = 59;
        // 
        // EffectLanguageColumn
        // 
        EffectLanguageColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
        EffectLanguageColumn.DataPropertyName = "Language";
        EffectLanguageColumn.HeaderText = "言語";
        EffectLanguageColumn.Name = "EffectLanguageColumn";
        EffectLanguageColumn.ReadOnly = true;
        EffectLanguageColumn.Width = 59;
        // 
        // EffectLanguageDetailButtonColumn
        // 
        EffectLanguageDetailButtonColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
        EffectLanguageDetailButtonColumn.HeaderText = "詳細";
        EffectLanguageDetailButtonColumn.Name = "EffectLanguageDetailButtonColumn";
        EffectLanguageDetailButtonColumn.Text = "詳細";
        EffectLanguageDetailButtonColumn.UseColumnTextForButtonValue = true;
        EffectLanguageDetailButtonColumn.Width = 40;
        // 
        // CloseButton
        // 
        CloseButton.Location = new Point(657, 272);
        CloseButton.Margin = new Padding(4, 3, 4, 3);
        CloseButton.Name = "CloseButton";
        CloseButton.Size = new Size(76, 35);
        CloseButton.TabIndex = 9;
        CloseButton.Text = "閉じる";
        CloseButton.UseVisualStyleBackColor = true;
        CloseButton.Click += CloseButton_Click;
        // 
        // ItemDataGridView
        // 
        ItemDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        ItemDataGridView.Columns.AddRange(new DataGridViewColumn[] { ItemNameColumn, dataGridViewButtonColumn1 });
        ItemDataGridView.Location = new Point(377, 98);
        ItemDataGridView.Margin = new Padding(4, 3, 4, 3);
        ItemDataGridView.Name = "ItemDataGridView";
        ItemDataGridView.RowHeadersVisible = false;
        ItemDataGridView.Size = new Size(355, 168);
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
        ItemCaptionLabel.Location = new Point(375, 78);
        ItemCaptionLabel.Margin = new Padding(4, 0, 4, 0);
        ItemCaptionLabel.Name = "ItemCaptionLabel";
        ItemCaptionLabel.Size = new Size(51, 17);
        ItemCaptionLabel.TabIndex = 6;
        ItemCaptionLabel.Text = "アイテム";
        ItemCaptionLabel.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // PropertyButton
        // 
        PropertyButton.Location = new Point(573, 272);
        PropertyButton.Margin = new Padding(4, 3, 4, 3);
        PropertyButton.Name = "PropertyButton";
        PropertyButton.Size = new Size(76, 35);
        PropertyButton.TabIndex = 8;
        PropertyButton.Text = "プロパティ";
        PropertyButton.UseVisualStyleBackColor = true;
        PropertyButton.Click += PropertyButton_Click;
        // 
        // ItemFlingEffectInfoForm
        // 
        AutoScaleDimensions = new SizeF(9F, 17F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(746, 316);
        Controls.Add(PropertyButton);
        Controls.Add(ItemDataGridView);
        Controls.Add(ItemCaptionLabel);
        Controls.Add(CloseButton);
        Controls.Add(EffectEntriesDataGridView);
        Controls.Add(EffectCaptionLabel);
        Controls.Add(NameTextBox);
        Controls.Add(IdTextBox);
        Controls.Add(NameCaptionLabel);
        Controls.Add(IdCaptionLabel);
        Font = new Font("Meiryo UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 128);
        FormBorderStyle = FormBorderStyle.FixedSingle;
        Margin = new Padding(4, 3, 4, 3);
        MaximizeBox = false;
        Name = "ItemFlingEffectInfoForm";
        StartPosition = FormStartPosition.CenterParent;
        Text = "「投げつける」の効果";
        ((System.ComponentModel.ISupportInitialize)EffectEntriesDataGridView).EndInit();
        ((System.ComponentModel.ISupportInitialize)ItemDataGridView).EndInit();
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private TextBox NameTextBox;
    private TextBox IdTextBox;
    private Label NameCaptionLabel;
    private Label IdCaptionLabel;
    private Label EffectCaptionLabel;
    private DataGridView EffectEntriesDataGridView;
    private DataGridViewTextBoxColumn EffectColumn;
    private DataGridViewTextBoxColumn EffectLanguageColumn;
    private DataGridViewButtonColumn EffectLanguageDetailButtonColumn;
    private Button CloseButton;
    private DataGridView ItemDataGridView;
    private DataGridViewTextBoxColumn ItemNameColumn;
    private DataGridViewButtonColumn dataGridViewButtonColumn1;
    private Label ItemCaptionLabel;
    private Button PropertyButton;
}