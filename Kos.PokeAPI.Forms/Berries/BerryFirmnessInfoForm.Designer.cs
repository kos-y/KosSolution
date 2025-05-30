﻿namespace Kos.PokeAPI.Forms.Berries;

partial class BerryFirmnessInfoForm
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
        NameCaptionLabel = new Label();
        IdCaptionLabel = new Label();
        BerriesCaptionLabel = new Label();
        BerriesDataGridView = new DataGridView();
        BerriesNameColumn = new DataGridViewTextBoxColumn();
        BerrieDetailButtonColumn = new DataGridViewButtonColumn();
        NamesDataGridView = new DataGridView();
        NameColumn = new DataGridViewTextBoxColumn();
        LanguageColumn = new DataGridViewTextBoxColumn();
        DetailColumn = new DataGridViewButtonColumn();
        NamesCaptionLabel = new Label();
        CloseButton = new Button();
        IdTextBox = new TextBox();
        NameTextBox = new TextBox();
        PropertyButton = new Button();
        ((System.ComponentModel.ISupportInitialize)BerriesDataGridView).BeginInit();
        ((System.ComponentModel.ISupportInitialize)NamesDataGridView).BeginInit();
        SuspendLayout();
        // 
        // NameCaptionLabel
        // 
        NameCaptionLabel.AutoSize = true;
        NameCaptionLabel.Location = new Point(12, 44);
        NameCaptionLabel.Name = "NameCaptionLabel";
        NameCaptionLabel.Size = new Size(79, 15);
        NameCaptionLabel.TabIndex = 2;
        NameCaptionLabel.Text = "きのみの硬さ名";
        NameCaptionLabel.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // IdCaptionLabel
        // 
        IdCaptionLabel.AutoSize = true;
        IdCaptionLabel.Location = new Point(12, 15);
        IdCaptionLabel.Name = "IdCaptionLabel";
        IdCaptionLabel.Size = new Size(78, 15);
        IdCaptionLabel.TabIndex = 0;
        IdCaptionLabel.Text = "きのみの硬さID";
        IdCaptionLabel.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // BerriesCaptionLabel
        // 
        BerriesCaptionLabel.AutoSize = true;
        BerriesCaptionLabel.Location = new Point(12, 74);
        BerriesCaptionLabel.Name = "BerriesCaptionLabel";
        BerriesCaptionLabel.Size = new Size(37, 15);
        BerriesCaptionLabel.TabIndex = 4;
        BerriesCaptionLabel.Text = "きのみ";
        BerriesCaptionLabel.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // BerriesDataGridView
        // 
        BerriesDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        BerriesDataGridView.Columns.AddRange(new DataGridViewColumn[] { BerriesNameColumn, BerrieDetailButtonColumn });
        BerriesDataGridView.Location = new Point(12, 92);
        BerriesDataGridView.Name = "BerriesDataGridView";
        BerriesDataGridView.RowHeadersVisible = false;
        BerriesDataGridView.Size = new Size(226, 150);
        BerriesDataGridView.TabIndex = 5;
        BerriesDataGridView.CellClick += BerriesDataGridView_CellClick;
        BerriesDataGridView.CellDoubleClick += BerriesDataGridView_CellDoubleClick;
        // 
        // BerriesNameColumn
        // 
        BerriesNameColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
        BerriesNameColumn.DataPropertyName = "Name";
        BerriesNameColumn.HeaderText = "きのみ";
        BerriesNameColumn.Name = "BerriesNameColumn";
        BerriesNameColumn.ReadOnly = true;
        BerriesNameColumn.Width = 62;
        // 
        // BerrieDetailButtonColumn
        // 
        BerrieDetailButtonColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
        BerrieDetailButtonColumn.HeaderText = "詳細";
        BerrieDetailButtonColumn.Name = "BerrieDetailButtonColumn";
        BerrieDetailButtonColumn.ReadOnly = true;
        BerrieDetailButtonColumn.Text = "詳細";
        BerrieDetailButtonColumn.UseColumnTextForButtonValue = true;
        BerrieDetailButtonColumn.Width = 37;
        // 
        // NamesDataGridView
        // 
        NamesDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        NamesDataGridView.Columns.AddRange(new DataGridViewColumn[] { NameColumn, LanguageColumn, DetailColumn });
        NamesDataGridView.Location = new Point(244, 92);
        NamesDataGridView.Name = "NamesDataGridView";
        NamesDataGridView.RowHeadersVisible = false;
        NamesDataGridView.Size = new Size(230, 150);
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
        NameColumn.Width = 56;
        // 
        // LanguageColumn
        // 
        LanguageColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
        LanguageColumn.DataPropertyName = "Language";
        LanguageColumn.HeaderText = "言語";
        LanguageColumn.Name = "LanguageColumn";
        LanguageColumn.ReadOnly = true;
        LanguageColumn.Width = 56;
        // 
        // DetailColumn
        // 
        DetailColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
        DetailColumn.HeaderText = "詳細";
        DetailColumn.Name = "DetailColumn";
        DetailColumn.Text = "詳細";
        DetailColumn.UseColumnTextForButtonValue = true;
        DetailColumn.Width = 37;
        // 
        // NamesCaptionLabel
        // 
        NamesCaptionLabel.AutoSize = true;
        NamesCaptionLabel.Location = new Point(244, 74);
        NamesCaptionLabel.Name = "NamesCaptionLabel";
        NamesCaptionLabel.Size = new Size(82, 15);
        NamesCaptionLabel.TabIndex = 6;
        NamesCaptionLabel.Text = "言語ごとの名前";
        NamesCaptionLabel.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // CloseButton
        // 
        CloseButton.Location = new Point(415, 247);
        CloseButton.Name = "CloseButton";
        CloseButton.Size = new Size(59, 31);
        CloseButton.TabIndex = 9;
        CloseButton.Text = "閉じる";
        CloseButton.UseVisualStyleBackColor = true;
        CloseButton.Click += CloseButton_Click;
        // 
        // IdTextBox
        // 
        IdTextBox.Location = new Point(95, 12);
        IdTextBox.Margin = new Padding(2, 3, 2, 3);
        IdTextBox.Name = "IdTextBox";
        IdTextBox.ReadOnly = true;
        IdTextBox.Size = new Size(92, 23);
        IdTextBox.TabIndex = 1;
        // 
        // NameTextBox
        // 
        NameTextBox.Location = new Point(95, 41);
        NameTextBox.Margin = new Padding(2, 3, 2, 3);
        NameTextBox.Name = "NameTextBox";
        NameTextBox.ReadOnly = true;
        NameTextBox.Size = new Size(92, 23);
        NameTextBox.TabIndex = 3;
        // 
        // PropertyButton
        // 
        PropertyButton.Location = new Point(350, 247);
        PropertyButton.Name = "PropertyButton";
        PropertyButton.Size = new Size(59, 31);
        PropertyButton.TabIndex = 8;
        PropertyButton.Text = "プロパティ";
        PropertyButton.UseVisualStyleBackColor = true;
        PropertyButton.Click += PropertyButton_Click;
        // 
        // BerryFirmnessInfoForm
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(490, 290);
        Controls.Add(PropertyButton);
        Controls.Add(NameTextBox);
        Controls.Add(IdTextBox);
        Controls.Add(CloseButton);
        Controls.Add(NamesDataGridView);
        Controls.Add(NamesCaptionLabel);
        Controls.Add(BerriesDataGridView);
        Controls.Add(BerriesCaptionLabel);
        Controls.Add(NameCaptionLabel);
        Controls.Add(IdCaptionLabel);
        FormBorderStyle = FormBorderStyle.FixedSingle;
        MaximizeBox = false;
        Name = "BerryFirmnessInfoForm";
        StartPosition = FormStartPosition.CenterParent;
        Text = "きのみの硬さ";
        Load += BerryFirmnessInfoForm_Load;
        ((System.ComponentModel.ISupportInitialize)BerriesDataGridView).EndInit();
        ((System.ComponentModel.ISupportInitialize)NamesDataGridView).EndInit();
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion
    private Label NameCaptionLabel;
    private Label IdCaptionLabel;
    private Label BerriesCaptionLabel;
    private DataGridView BerriesDataGridView;
    private DataGridView NamesDataGridView;
    private Label NamesCaptionLabel;
    private Button CloseButton;
    private DataGridViewTextBoxColumn BerriesNameColumn;
    private DataGridViewButtonColumn BerrieDetailButtonColumn;
    private DataGridViewTextBoxColumn NameColumn;
    private DataGridViewTextBoxColumn LanguageColumn;
    private DataGridViewButtonColumn DetailColumn;
    private TextBox IdTextBox;
    private TextBox NameTextBox;
    private Button PropertyButton;
}