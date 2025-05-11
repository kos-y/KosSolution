namespace Kos.PokeAPI.Forms;

partial class MoveCategoryInfoForm
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
        MovesDataGridView = new DataGridView();
        dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
        dataGridViewButtonColumn1 = new DataGridViewButtonColumn();
        MoveCaptionLabel = new Label();
        DescriptionsDataGridView = new DataGridView();
        DescriptionColumn = new DataGridViewTextBoxColumn();
        dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
        dataGridViewButtonColumn2 = new DataGridViewButtonColumn();
        DescriptionsCaptionLabel = new Label();
        CloseButton = new Button();
        PropertyButton = new Button();
        ((System.ComponentModel.ISupportInitialize)MovesDataGridView).BeginInit();
        ((System.ComponentModel.ISupportInitialize)DescriptionsDataGridView).BeginInit();
        SuspendLayout();
        // 
        // NameTextBox
        // 
        NameTextBox.Location = new Point(132, 42);
        NameTextBox.Margin = new Padding(4, 3, 4, 3);
        NameTextBox.Name = "NameTextBox";
        NameTextBox.ReadOnly = true;
        NameTextBox.Size = new Size(179, 24);
        NameTextBox.TabIndex = 3;
        // 
        // IdTextBox
        // 
        IdTextBox.Location = new Point(132, 12);
        IdTextBox.Margin = new Padding(4, 3, 4, 3);
        IdTextBox.Name = "IdTextBox";
        IdTextBox.ReadOnly = true;
        IdTextBox.Size = new Size(179, 24);
        IdTextBox.TabIndex = 1;
        // 
        // NameCaptionLabel
        // 
        NameCaptionLabel.AutoSize = true;
        NameCaptionLabel.Location = new Point(13, 45);
        NameCaptionLabel.Margin = new Padding(4, 0, 4, 0);
        NameCaptionLabel.Name = "NameCaptionLabel";
        NameCaptionLabel.Size = new Size(111, 17);
        NameCaptionLabel.TabIndex = 2;
        NameCaptionLabel.Text = "技のカテゴリの名前";
        NameCaptionLabel.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // IdCaptionLabel
        // 
        IdCaptionLabel.AutoSize = true;
        IdCaptionLabel.Location = new Point(34, 15);
        IdCaptionLabel.Margin = new Padding(4, 0, 4, 0);
        IdCaptionLabel.Name = "IdCaptionLabel";
        IdCaptionLabel.Size = new Size(90, 17);
        IdCaptionLabel.TabIndex = 0;
        IdCaptionLabel.Text = "技のカテゴリID";
        IdCaptionLabel.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // MovesDataGridView
        // 
        MovesDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        MovesDataGridView.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1, dataGridViewButtonColumn1 });
        MovesDataGridView.Location = new Point(13, 291);
        MovesDataGridView.Margin = new Padding(4, 3, 4, 3);
        MovesDataGridView.Name = "MovesDataGridView";
        MovesDataGridView.RowHeadersVisible = false;
        MovesDataGridView.Size = new Size(329, 192);
        MovesDataGridView.TabIndex = 7;
        MovesDataGridView.CellClick += MovesDataGridView_CellClick;
        MovesDataGridView.CellDoubleClick += MovesDataGridView_CellDoubleClick;
        // 
        // dataGridViewTextBoxColumn1
        // 
        dataGridViewTextBoxColumn1.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
        dataGridViewTextBoxColumn1.DataPropertyName = "Name";
        dataGridViewTextBoxColumn1.HeaderText = "技";
        dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
        dataGridViewTextBoxColumn1.ReadOnly = true;
        dataGridViewTextBoxColumn1.Width = 46;
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
        // MoveCaptionLabel
        // 
        MoveCaptionLabel.AutoSize = true;
        MoveCaptionLabel.Location = new Point(13, 271);
        MoveCaptionLabel.Margin = new Padding(4, 0, 4, 0);
        MoveCaptionLabel.Name = "MoveCaptionLabel";
        MoveCaptionLabel.Size = new Size(21, 17);
        MoveCaptionLabel.TabIndex = 6;
        MoveCaptionLabel.Text = "技";
        MoveCaptionLabel.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // DescriptionsDataGridView
        // 
        DescriptionsDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        DescriptionsDataGridView.Columns.AddRange(new DataGridViewColumn[] { DescriptionColumn, dataGridViewTextBoxColumn2, dataGridViewButtonColumn2 });
        DescriptionsDataGridView.Location = new Point(13, 97);
        DescriptionsDataGridView.Margin = new Padding(4, 3, 4, 3);
        DescriptionsDataGridView.Name = "DescriptionsDataGridView";
        DescriptionsDataGridView.RowHeadersVisible = false;
        DescriptionsDataGridView.Size = new Size(723, 170);
        DescriptionsDataGridView.TabIndex = 5;
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
        DescriptionsCaptionLabel.Location = new Point(13, 77);
        DescriptionsCaptionLabel.Margin = new Padding(4, 0, 4, 0);
        DescriptionsCaptionLabel.Name = "DescriptionsCaptionLabel";
        DescriptionsCaptionLabel.Size = new Size(92, 17);
        DescriptionsCaptionLabel.TabIndex = 4;
        DescriptionsCaptionLabel.Text = "言語ごとの説明";
        DescriptionsCaptionLabel.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // CloseButton
        // 
        CloseButton.Location = new Point(660, 448);
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
        PropertyButton.Location = new Point(576, 448);
        PropertyButton.Margin = new Padding(4, 3, 4, 3);
        PropertyButton.Name = "PropertyButton";
        PropertyButton.Size = new Size(76, 35);
        PropertyButton.TabIndex = 8;
        PropertyButton.Text = "プロパティ";
        PropertyButton.UseVisualStyleBackColor = true;
        PropertyButton.Click += PropertyButton_Click;
        // 
        // MoveCategoryInfoForm
        // 
        AutoScaleDimensions = new SizeF(9F, 17F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(752, 499);
        Controls.Add(PropertyButton);
        Controls.Add(CloseButton);
        Controls.Add(DescriptionsDataGridView);
        Controls.Add(DescriptionsCaptionLabel);
        Controls.Add(MovesDataGridView);
        Controls.Add(MoveCaptionLabel);
        Controls.Add(NameTextBox);
        Controls.Add(IdTextBox);
        Controls.Add(NameCaptionLabel);
        Controls.Add(IdCaptionLabel);
        Font = new Font("Meiryo UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 128);
        FormBorderStyle = FormBorderStyle.FixedSingle;
        Margin = new Padding(4, 3, 4, 3);
        MaximizeBox = false;
        Name = "MoveCategoryInfoForm";
        StartPosition = FormStartPosition.CenterParent;
        Text = "技のカテゴリ";
        ((System.ComponentModel.ISupportInitialize)MovesDataGridView).EndInit();
        ((System.ComponentModel.ISupportInitialize)DescriptionsDataGridView).EndInit();
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private TextBox NameTextBox;
    private TextBox IdTextBox;
    private Label NameCaptionLabel;
    private Label IdCaptionLabel;
    private DataGridView MovesDataGridView;
    private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
    private DataGridViewButtonColumn dataGridViewButtonColumn1;
    private Label MoveCaptionLabel;
    private DataGridView DescriptionsDataGridView;
    private DataGridViewTextBoxColumn DescriptionColumn;
    private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
    private DataGridViewButtonColumn dataGridViewButtonColumn2;
    private Label DescriptionsCaptionLabel;
    private Button CloseButton;
    private Button PropertyButton;
}