namespace Kos.PokeAPI.Forms;

partial class EncounterMethodInfoForm
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
        OrderCaptionLabel = new Label();
        NamesCaptionLabel = new Label();
        CloseButton = new Button();
        NamesDataGridView = new DataGridView();
        NameColumn = new DataGridViewTextBoxColumn();
        LanguageColumn = new DataGridViewTextBoxColumn();
        DetailColumn = new DataGridViewButtonColumn();
        IdTextBox = new TextBox();
        NameTextBox = new TextBox();
        OrderTextBox = new TextBox();
        ((System.ComponentModel.ISupportInitialize)NamesDataGridView).BeginInit();
        SuspendLayout();
        // 
        // NameCaptionLabel
        // 
        NameCaptionLabel.AutoSize = true;
        NameCaptionLabel.Location = new Point(32, 40);
        NameCaptionLabel.Margin = new Padding(4, 0, 4, 0);
        NameCaptionLabel.Name = "NameCaptionLabel";
        NameCaptionLabel.Size = new Size(73, 17);
        NameCaptionLabel.TabIndex = 2;
        NameCaptionLabel.Text = "遭遇方法名";
        NameCaptionLabel.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // IdCaptionLabel
        // 
        IdCaptionLabel.AutoSize = true;
        IdCaptionLabel.Location = new Point(28, 10);
        IdCaptionLabel.Margin = new Padding(4, 0, 4, 0);
        IdCaptionLabel.Name = "IdCaptionLabel";
        IdCaptionLabel.Size = new Size(77, 17);
        IdCaptionLabel.TabIndex = 0;
        IdCaptionLabel.Text = "遭遇方法ID";
        IdCaptionLabel.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // OrderCaptionLabel
        // 
        OrderCaptionLabel.AutoSize = true;
        OrderCaptionLabel.Location = new Point(71, 70);
        OrderCaptionLabel.Margin = new Padding(4, 0, 4, 0);
        OrderCaptionLabel.Name = "OrderCaptionLabel";
        OrderCaptionLabel.Size = new Size(34, 17);
        OrderCaptionLabel.TabIndex = 4;
        OrderCaptionLabel.Text = "順番";
        OrderCaptionLabel.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // NamesCaptionLabel
        // 
        NamesCaptionLabel.AutoSize = true;
        NamesCaptionLabel.Location = new Point(13, 97);
        NamesCaptionLabel.Margin = new Padding(4, 0, 4, 0);
        NamesCaptionLabel.Name = "NamesCaptionLabel";
        NamesCaptionLabel.Size = new Size(92, 17);
        NamesCaptionLabel.TabIndex = 6;
        NamesCaptionLabel.Text = "言語ごとの名前";
        NamesCaptionLabel.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // CloseButton
        // 
        CloseButton.Location = new Point(828, 273);
        CloseButton.Margin = new Padding(4, 3, 4, 3);
        CloseButton.Name = "CloseButton";
        CloseButton.Size = new Size(66, 50);
        CloseButton.TabIndex = 8;
        CloseButton.Text = "閉じる";
        CloseButton.UseVisualStyleBackColor = true;
        CloseButton.Click += CloseButton_Click;
        // 
        // NamesDataGridView
        // 
        NamesDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        NamesDataGridView.Columns.AddRange(new DataGridViewColumn[] { NameColumn, LanguageColumn, DetailColumn });
        NamesDataGridView.Location = new Point(115, 97);
        NamesDataGridView.Margin = new Padding(4, 3, 4, 3);
        NamesDataGridView.Name = "NamesDataGridView";
        NamesDataGridView.RowHeadersVisible = false;
        NamesDataGridView.Size = new Size(779, 170);
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
        // IdTextBox
        // 
        IdTextBox.Location = new Point(112, 7);
        IdTextBox.Name = "IdTextBox";
        IdTextBox.ReadOnly = true;
        IdTextBox.Size = new Size(782, 24);
        IdTextBox.TabIndex = 1;
        // 
        // NameTextBox
        // 
        NameTextBox.Location = new Point(112, 37);
        NameTextBox.Name = "NameTextBox";
        NameTextBox.ReadOnly = true;
        NameTextBox.Size = new Size(782, 24);
        NameTextBox.TabIndex = 3;
        // 
        // OrderTextBox
        // 
        OrderTextBox.Location = new Point(112, 67);
        OrderTextBox.Name = "OrderTextBox";
        OrderTextBox.ReadOnly = true;
        OrderTextBox.Size = new Size(782, 24);
        OrderTextBox.TabIndex = 5;
        // 
        // EncounterMethodInfoForm
        // 
        AutoScaleDimensions = new SizeF(9F, 17F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(907, 327);
        Controls.Add(OrderTextBox);
        Controls.Add(NameTextBox);
        Controls.Add(IdTextBox);
        Controls.Add(NamesDataGridView);
        Controls.Add(CloseButton);
        Controls.Add(NamesCaptionLabel);
        Controls.Add(OrderCaptionLabel);
        Controls.Add(NameCaptionLabel);
        Controls.Add(IdCaptionLabel);
        Font = new Font("Meiryo UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 128);
        FormBorderStyle = FormBorderStyle.FixedSingle;
        Margin = new Padding(4, 3, 4, 3);
        MaximizeBox = false;
        MinimizeBox = false;
        Name = "EncounterMethodInfoForm";
        StartPosition = FormStartPosition.CenterParent;
        Text = "遭遇方法";
        Load += EncounterMethodInfoForm_Load;
        ((System.ComponentModel.ISupportInitialize)NamesDataGridView).EndInit();
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion
    private Label NameCaptionLabel;
    private Label IdCaptionLabel;
    private Label OrderCaptionLabel;
    private Label NamesCaptionLabel;
    private Button CloseButton;
    private DataGridView NamesDataGridView;
    private DataGridViewTextBoxColumn NameColumn;
    private DataGridViewTextBoxColumn LanguageColumn;
    private DataGridViewButtonColumn DetailColumn;
    private TextBox IdTextBox;
    private TextBox NameTextBox;
    private TextBox OrderTextBox;
}