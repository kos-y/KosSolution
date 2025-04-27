namespace Kos.PokeAPI.Forms;

partial class ItemAttributeInfoForm
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
        NameLabel = new Label();
        NameCaptionLabel = new Label();
        IdLabel = new Label();
        IdCaptionLabel = new Label();
        NamesDataGridView = new DataGridView();
        NameColumn = new DataGridViewTextBoxColumn();
        LanguageColumn = new DataGridViewTextBoxColumn();
        DetailColumn = new DataGridViewButtonColumn();
        NamesCaptionLabel = new Label();
        ItemDataGridView = new DataGridView();
        ItemCaptionLabel = new Label();
        ItemNameColumn = new DataGridViewTextBoxColumn();
        dataGridViewButtonColumn1 = new DataGridViewButtonColumn();
        DescriptionsDataGridView = new DataGridView();
        DescriptionsCaptionLabel = new Label();
        DescriptionColumn = new DataGridViewTextBoxColumn();
        dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
        dataGridViewButtonColumn2 = new DataGridViewButtonColumn();
        CloseButton = new Button();
        ((System.ComponentModel.ISupportInitialize)NamesDataGridView).BeginInit();
        ((System.ComponentModel.ISupportInitialize)ItemDataGridView).BeginInit();
        ((System.ComponentModel.ISupportInitialize)DescriptionsDataGridView).BeginInit();
        SuspendLayout();
        // 
        // NameLabel
        // 
        NameLabel.BorderStyle = BorderStyle.Fixed3D;
        NameLabel.Location = new Point(118, 46);
        NameLabel.Margin = new Padding(5, 0, 5, 0);
        NameLabel.Name = "NameLabel";
        NameLabel.Size = new Size(271, 29);
        NameLabel.TabIndex = 7;
        NameLabel.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // NameCaptionLabel
        // 
        NameCaptionLabel.AutoSize = true;
        NameCaptionLabel.Location = new Point(13, 52);
        NameCaptionLabel.Margin = new Padding(5, 0, 5, 0);
        NameCaptionLabel.Name = "NameCaptionLabel";
        NameCaptionLabel.Size = new Size(90, 17);
        NameCaptionLabel.TabIndex = 6;
        NameCaptionLabel.Text = "アイテム特性名";
        NameCaptionLabel.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // IdLabel
        // 
        IdLabel.BorderStyle = BorderStyle.Fixed3D;
        IdLabel.Location = new Point(118, 9);
        IdLabel.Margin = new Padding(5, 0, 5, 0);
        IdLabel.Name = "IdLabel";
        IdLabel.Size = new Size(271, 29);
        IdLabel.TabIndex = 5;
        IdLabel.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // IdCaptionLabel
        // 
        IdCaptionLabel.AutoSize = true;
        IdCaptionLabel.Location = new Point(14, 15);
        IdCaptionLabel.Margin = new Padding(5, 0, 5, 0);
        IdCaptionLabel.Name = "IdCaptionLabel";
        IdCaptionLabel.Size = new Size(94, 17);
        IdCaptionLabel.TabIndex = 4;
        IdCaptionLabel.Text = "アイテム特性ID";
        IdCaptionLabel.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // NamesDataGridView
        // 
        NamesDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        NamesDataGridView.Columns.AddRange(new DataGridViewColumn[] { NameColumn, LanguageColumn, DetailColumn });
        NamesDataGridView.Location = new Point(15, 96);
        NamesDataGridView.Margin = new Padding(4, 3, 4, 3);
        NamesDataGridView.Name = "NamesDataGridView";
        NamesDataGridView.RowHeadersVisible = false;
        NamesDataGridView.Size = new Size(379, 170);
        NamesDataGridView.TabIndex = 13;
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
        NamesCaptionLabel.Location = new Point(13, 76);
        NamesCaptionLabel.Margin = new Padding(4, 0, 4, 0);
        NamesCaptionLabel.Name = "NamesCaptionLabel";
        NamesCaptionLabel.Size = new Size(92, 17);
        NamesCaptionLabel.TabIndex = 12;
        NamesCaptionLabel.Text = "言語ごとの名前";
        NamesCaptionLabel.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // ItemDataGridView
        // 
        ItemDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        ItemDataGridView.Columns.AddRange(new DataGridViewColumn[] { ItemNameColumn, dataGridViewButtonColumn1 });
        ItemDataGridView.Location = new Point(400, 29);
        ItemDataGridView.Margin = new Padding(4, 3, 4, 3);
        ItemDataGridView.Name = "ItemDataGridView";
        ItemDataGridView.RowHeadersVisible = false;
        ItemDataGridView.Size = new Size(339, 237);
        ItemDataGridView.TabIndex = 17;
        // 
        // ItemCaptionLabel
        // 
        ItemCaptionLabel.AutoSize = true;
        ItemCaptionLabel.Location = new Point(398, 9);
        ItemCaptionLabel.Margin = new Padding(4, 0, 4, 0);
        ItemCaptionLabel.Name = "ItemCaptionLabel";
        ItemCaptionLabel.Size = new Size(51, 17);
        ItemCaptionLabel.TabIndex = 16;
        ItemCaptionLabel.Text = "アイテム";
        ItemCaptionLabel.TextAlign = ContentAlignment.MiddleLeft;
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
        // DescriptionsDataGridView
        // 
        DescriptionsDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        DescriptionsDataGridView.Columns.AddRange(new DataGridViewColumn[] { DescriptionColumn, dataGridViewTextBoxColumn2, dataGridViewButtonColumn2 });
        DescriptionsDataGridView.Location = new Point(16, 289);
        DescriptionsDataGridView.Margin = new Padding(4, 3, 4, 3);
        DescriptionsDataGridView.Name = "DescriptionsDataGridView";
        DescriptionsDataGridView.RowHeadersVisible = false;
        DescriptionsDataGridView.Size = new Size(723, 170);
        DescriptionsDataGridView.TabIndex = 19;
        // 
        // DescriptionsCaptionLabel
        // 
        DescriptionsCaptionLabel.AutoSize = true;
        DescriptionsCaptionLabel.Location = new Point(14, 269);
        DescriptionsCaptionLabel.Margin = new Padding(4, 0, 4, 0);
        DescriptionsCaptionLabel.Name = "DescriptionsCaptionLabel";
        DescriptionsCaptionLabel.Size = new Size(92, 17);
        DescriptionsCaptionLabel.TabIndex = 18;
        DescriptionsCaptionLabel.Text = "言語ごとの名前";
        DescriptionsCaptionLabel.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // DescriptionColumn
        // 
        DescriptionColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
        DescriptionColumn.DataPropertyName = "Text";
        DescriptionColumn.HeaderText = "説明";
        DescriptionColumn.Name = "DescriptionColumn";
        DescriptionColumn.ReadOnly = true;
        DescriptionColumn.Width = 59;
        // 
        // dataGridViewTextBoxColumn2
        // 
        dataGridViewTextBoxColumn2.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
        dataGridViewTextBoxColumn2.DataPropertyName = "Language";
        dataGridViewTextBoxColumn2.HeaderText = "言語";
        dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
        dataGridViewTextBoxColumn2.ReadOnly = true;
        dataGridViewTextBoxColumn2.Width = 59;
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
        // CloseButton
        // 
        CloseButton.Location = new Point(643, 465);
        CloseButton.Margin = new Padding(4, 3, 4, 3);
        CloseButton.Name = "CloseButton";
        CloseButton.Size = new Size(96, 52);
        CloseButton.TabIndex = 23;
        CloseButton.Text = "閉じる";
        CloseButton.UseVisualStyleBackColor = true;
        // 
        // ItemAttributeInfoForm
        // 
        AutoScaleDimensions = new SizeF(9F, 17F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(756, 524);
        Controls.Add(CloseButton);
        Controls.Add(DescriptionsDataGridView);
        Controls.Add(DescriptionsCaptionLabel);
        Controls.Add(ItemDataGridView);
        Controls.Add(ItemCaptionLabel);
        Controls.Add(NamesDataGridView);
        Controls.Add(NamesCaptionLabel);
        Controls.Add(NameLabel);
        Controls.Add(NameCaptionLabel);
        Controls.Add(IdLabel);
        Controls.Add(IdCaptionLabel);
        Font = new Font("Meiryo UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 128);
        FormBorderStyle = FormBorderStyle.FixedSingle;
        Margin = new Padding(4, 3, 4, 3);
        MaximizeBox = false;
        Name = "ItemAttributeInfoForm";
        StartPosition = FormStartPosition.CenterParent;
        Text = "アイテム特性";
        ((System.ComponentModel.ISupportInitialize)NamesDataGridView).EndInit();
        ((System.ComponentModel.ISupportInitialize)ItemDataGridView).EndInit();
        ((System.ComponentModel.ISupportInitialize)DescriptionsDataGridView).EndInit();
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private Label NameLabel;
    private Label NameCaptionLabel;
    private Label IdLabel;
    private Label IdCaptionLabel;
    private DataGridView NamesDataGridView;
    private DataGridViewTextBoxColumn NameColumn;
    private DataGridViewTextBoxColumn LanguageColumn;
    private DataGridViewButtonColumn DetailColumn;
    private Label NamesCaptionLabel;
    private DataGridView ItemDataGridView;
    private DataGridViewTextBoxColumn ItemNameColumn;
    private DataGridViewButtonColumn dataGridViewButtonColumn1;
    private Label ItemCaptionLabel;
    private DataGridView DescriptionsDataGridView;
    private DataGridViewTextBoxColumn DescriptionColumn;
    private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
    private DataGridViewButtonColumn dataGridViewButtonColumn2;
    private Label DescriptionsCaptionLabel;
    private Button CloseButton;
}