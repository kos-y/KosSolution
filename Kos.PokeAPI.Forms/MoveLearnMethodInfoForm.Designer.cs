namespace Kos.PokeAPI.Forms;

partial class MoveLearnMethodInfoForm
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
        NamesDataGridView = new DataGridView();
        NameColumn = new DataGridViewTextBoxColumn();
        LanguageColumn = new DataGridViewTextBoxColumn();
        DetailColumn = new DataGridViewButtonColumn();
        NamesCaptionLabel = new Label();
        DescriptionsDataGridView = new DataGridView();
        DescriptionColumn = new DataGridViewTextBoxColumn();
        dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
        dataGridViewButtonColumn2 = new DataGridViewButtonColumn();
        DescriptionsCaptionLabel = new Label();
        VersionGroupCaptionLabel = new Label();
        VersionGroupDataGridView = new DataGridView();
        dataGridViewTextBoxColumn4 = new DataGridViewTextBoxColumn();
        dataGridViewButtonColumn4 = new DataGridViewButtonColumn();
        CloseButton = new Button();
        PropertyButton = new Button();
        ((System.ComponentModel.ISupportInitialize)NamesDataGridView).BeginInit();
        ((System.ComponentModel.ISupportInitialize)DescriptionsDataGridView).BeginInit();
        ((System.ComponentModel.ISupportInitialize)VersionGroupDataGridView).BeginInit();
        SuspendLayout();
        // 
        // NameTextBox
        // 
        NameTextBox.Location = new Point(124, 42);
        NameTextBox.Margin = new Padding(4, 3, 4, 3);
        NameTextBox.Name = "NameTextBox";
        NameTextBox.ReadOnly = true;
        NameTextBox.Size = new Size(179, 24);
        NameTextBox.TabIndex = 3;
        // 
        // IdTextBox
        // 
        IdTextBox.Location = new Point(124, 12);
        IdTextBox.Margin = new Padding(4, 3, 4, 3);
        IdTextBox.Name = "IdTextBox";
        IdTextBox.ReadOnly = true;
        IdTextBox.Size = new Size(179, 24);
        IdTextBox.TabIndex = 1;
        // 
        // NameCaptionLabel
        // 
        NameCaptionLabel.AutoSize = true;
        NameCaptionLabel.Location = new Point(20, 45);
        NameCaptionLabel.Margin = new Padding(4, 0, 4, 0);
        NameCaptionLabel.Name = "NameCaptionLabel";
        NameCaptionLabel.Size = new Size(98, 17);
        NameCaptionLabel.TabIndex = 2;
        NameCaptionLabel.Text = "技の習得方法名";
        NameCaptionLabel.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // IdCaptionLabel
        // 
        IdCaptionLabel.AutoSize = true;
        IdCaptionLabel.Location = new Point(16, 15);
        IdCaptionLabel.Margin = new Padding(4, 0, 4, 0);
        IdCaptionLabel.Name = "IdCaptionLabel";
        IdCaptionLabel.Size = new Size(102, 17);
        IdCaptionLabel.TabIndex = 0;
        IdCaptionLabel.Text = "技の習得方法ID";
        IdCaptionLabel.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // NamesDataGridView
        // 
        NamesDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        NamesDataGridView.Columns.AddRange(new DataGridViewColumn[] { NameColumn, LanguageColumn, DetailColumn });
        NamesDataGridView.Location = new Point(20, 104);
        NamesDataGridView.Margin = new Padding(4, 3, 4, 3);
        NamesDataGridView.Name = "NamesDataGridView";
        NamesDataGridView.RowHeadersVisible = false;
        NamesDataGridView.Size = new Size(319, 192);
        NamesDataGridView.TabIndex = 5;
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
        NamesCaptionLabel.Location = new Point(20, 82);
        NamesCaptionLabel.Margin = new Padding(4, 0, 4, 0);
        NamesCaptionLabel.Name = "NamesCaptionLabel";
        NamesCaptionLabel.Size = new Size(92, 17);
        NamesCaptionLabel.TabIndex = 4;
        NamesCaptionLabel.Text = "言語ごとの名前";
        NamesCaptionLabel.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // DescriptionsDataGridView
        // 
        DescriptionsDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        DescriptionsDataGridView.Columns.AddRange(new DataGridViewColumn[] { DescriptionColumn, dataGridViewTextBoxColumn2, dataGridViewButtonColumn2 });
        DescriptionsDataGridView.Location = new Point(20, 328);
        DescriptionsDataGridView.Margin = new Padding(4, 3, 4, 3);
        DescriptionsDataGridView.Name = "DescriptionsDataGridView";
        DescriptionsDataGridView.RowHeadersVisible = false;
        DescriptionsDataGridView.Size = new Size(723, 170);
        DescriptionsDataGridView.TabIndex = 9;
        DescriptionsDataGridView.CellClick += DescriptionsDataGridView_CellClick;
        DescriptionsDataGridView.CellDoubleClick += DescriptionsDataGridView_CellDoubleClick;
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
        // DescriptionsCaptionLabel
        // 
        DescriptionsCaptionLabel.AutoSize = true;
        DescriptionsCaptionLabel.Location = new Point(18, 308);
        DescriptionsCaptionLabel.Margin = new Padding(4, 0, 4, 0);
        DescriptionsCaptionLabel.Name = "DescriptionsCaptionLabel";
        DescriptionsCaptionLabel.Size = new Size(92, 17);
        DescriptionsCaptionLabel.TabIndex = 8;
        DescriptionsCaptionLabel.Text = "言語ごとの説明";
        DescriptionsCaptionLabel.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // VersionGroupCaptionLabel
        // 
        VersionGroupCaptionLabel.AutoSize = true;
        VersionGroupCaptionLabel.Location = new Point(345, 84);
        VersionGroupCaptionLabel.Margin = new Padding(4, 0, 4, 0);
        VersionGroupCaptionLabel.Name = "VersionGroupCaptionLabel";
        VersionGroupCaptionLabel.Size = new Size(104, 17);
        VersionGroupCaptionLabel.TabIndex = 6;
        VersionGroupCaptionLabel.Text = "バージョングループ";
        VersionGroupCaptionLabel.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // VersionGroupDataGridView
        // 
        VersionGroupDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        VersionGroupDataGridView.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn4, dataGridViewButtonColumn4 });
        VersionGroupDataGridView.Location = new Point(347, 104);
        VersionGroupDataGridView.Margin = new Padding(4, 3, 4, 3);
        VersionGroupDataGridView.Name = "VersionGroupDataGridView";
        VersionGroupDataGridView.RowHeadersVisible = false;
        VersionGroupDataGridView.Size = new Size(396, 192);
        VersionGroupDataGridView.TabIndex = 7;
        VersionGroupDataGridView.CellClick += VersionGroupDataGridView_CellClick;
        VersionGroupDataGridView.CellDoubleClick += VersionGroupDataGridView_CellDoubleClick;
        // 
        // dataGridViewTextBoxColumn4
        // 
        dataGridViewTextBoxColumn4.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
        dataGridViewTextBoxColumn4.DataPropertyName = "Name";
        dataGridViewTextBoxColumn4.HeaderText = "バージョングループ";
        dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
        dataGridViewTextBoxColumn4.ReadOnly = true;
        dataGridViewTextBoxColumn4.Width = 88;
        // 
        // dataGridViewButtonColumn4
        // 
        dataGridViewButtonColumn4.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
        dataGridViewButtonColumn4.HeaderText = "詳細";
        dataGridViewButtonColumn4.Name = "dataGridViewButtonColumn4";
        dataGridViewButtonColumn4.Text = "詳細";
        dataGridViewButtonColumn4.UseColumnTextForButtonValue = true;
        dataGridViewButtonColumn4.Width = 36;
        // 
        // CloseButton
        // 
        CloseButton.Location = new Point(667, 504);
        CloseButton.Margin = new Padding(4, 3, 4, 3);
        CloseButton.Name = "CloseButton";
        CloseButton.Size = new Size(76, 35);
        CloseButton.TabIndex = 11;
        CloseButton.Text = "閉じる";
        CloseButton.UseVisualStyleBackColor = true;
        CloseButton.Click += CloseButton_Click;
        // 
        // PropertyButton
        // 
        PropertyButton.Location = new Point(583, 504);
        PropertyButton.Margin = new Padding(4, 3, 4, 3);
        PropertyButton.Name = "PropertyButton";
        PropertyButton.Size = new Size(76, 35);
        PropertyButton.TabIndex = 10;
        PropertyButton.Text = "プロパティ";
        PropertyButton.UseVisualStyleBackColor = true;
        PropertyButton.Click += PropertyButton_Click;
        // 
        // MoveLearnMethodInfoForm
        // 
        AutoScaleDimensions = new SizeF(9F, 17F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(766, 554);
        Controls.Add(PropertyButton);
        Controls.Add(CloseButton);
        Controls.Add(VersionGroupCaptionLabel);
        Controls.Add(VersionGroupDataGridView);
        Controls.Add(DescriptionsDataGridView);
        Controls.Add(DescriptionsCaptionLabel);
        Controls.Add(NamesDataGridView);
        Controls.Add(NamesCaptionLabel);
        Controls.Add(NameTextBox);
        Controls.Add(IdTextBox);
        Controls.Add(NameCaptionLabel);
        Controls.Add(IdCaptionLabel);
        Font = new Font("Meiryo UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 128);
        FormBorderStyle = FormBorderStyle.FixedSingle;
        Margin = new Padding(4, 3, 4, 3);
        MaximizeBox = false;
        Name = "MoveLearnMethodInfoForm";
        StartPosition = FormStartPosition.CenterParent;
        Text = "技の習得方法";
        ((System.ComponentModel.ISupportInitialize)NamesDataGridView).EndInit();
        ((System.ComponentModel.ISupportInitialize)DescriptionsDataGridView).EndInit();
        ((System.ComponentModel.ISupportInitialize)VersionGroupDataGridView).EndInit();
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private TextBox NameTextBox;
    private TextBox IdTextBox;
    private Label NameCaptionLabel;
    private Label IdCaptionLabel;
    private DataGridView NamesDataGridView;
    private DataGridViewTextBoxColumn NameColumn;
    private DataGridViewTextBoxColumn LanguageColumn;
    private DataGridViewButtonColumn DetailColumn;
    private Label NamesCaptionLabel;
    private DataGridView DescriptionsDataGridView;
    private DataGridViewTextBoxColumn DescriptionColumn;
    private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
    private DataGridViewButtonColumn dataGridViewButtonColumn2;
    private Label DescriptionsCaptionLabel;
    private Label VersionGroupCaptionLabel;
    private DataGridView VersionGroupDataGridView;
    private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
    private DataGridViewButtonColumn dataGridViewButtonColumn4;
    private Button CloseButton;
    private Button PropertyButton;
}