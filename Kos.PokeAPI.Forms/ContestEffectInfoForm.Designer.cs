namespace Kos.PokeAPI.Forms;

partial class ContestEffectInfoForm
{
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
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
    ///  Required method for Designer support - do not modify
    ///  the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        AppealCaptionLabel = new Label();
        IdCaptionLabel = new Label();
        JamCaptionLabel = new Label();
        EffectEntriesDataGridView = new DataGridView();
        EffectColumn = new DataGridViewTextBoxColumn();
        EffectLanguageColumn = new DataGridViewTextBoxColumn();
        EffectLanguageDetailButtonColumn = new DataGridViewButtonColumn();
        EffectEntriesCaptionLabel = new Label();
        FlavorTextEntriesDataGridView = new DataGridView();
        FlavorTextColumn = new DataGridViewTextBoxColumn();
        FlavorTextLanguageColumn = new DataGridViewTextBoxColumn();
        FlavorVersionColumn = new DataGridViewTextBoxColumn();
        FlavorTextDetailButtonColumn = new DataGridViewButtonColumn();
        CloseButton = new Button();
        FlavorTextEntriesCaptionLabel = new Label();
        IdTextBox = new TextBox();
        AppealTextBox = new TextBox();
        JamTextBox = new TextBox();
        PropertyButton = new Button();
        ((System.ComponentModel.ISupportInitialize)EffectEntriesDataGridView).BeginInit();
        ((System.ComponentModel.ISupportInitialize)FlavorTextEntriesDataGridView).BeginInit();
        SuspendLayout();
        // 
        // AppealCaptionLabel
        // 
        AppealCaptionLabel.AutoSize = true;
        AppealCaptionLabel.Location = new Point(35, 45);
        AppealCaptionLabel.Margin = new Padding(4, 0, 4, 0);
        AppealCaptionLabel.Name = "AppealCaptionLabel";
        AppealCaptionLabel.Size = new Size(51, 17);
        AppealCaptionLabel.TabIndex = 2;
        AppealCaptionLabel.Text = "アピール";
        AppealCaptionLabel.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // IdCaptionLabel
        // 
        IdCaptionLabel.AutoSize = true;
        IdCaptionLabel.Location = new Point(9, 15);
        IdCaptionLabel.Margin = new Padding(4, 0, 4, 0);
        IdCaptionLabel.Name = "IdCaptionLabel";
        IdCaptionLabel.Size = new Size(76, 17);
        IdCaptionLabel.TabIndex = 0;
        IdCaptionLabel.Text = "コンテストID";
        IdCaptionLabel.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // JamCaptionLabel
        // 
        JamCaptionLabel.AutoSize = true;
        JamCaptionLabel.Location = new Point(51, 72);
        JamCaptionLabel.Margin = new Padding(4, 0, 4, 0);
        JamCaptionLabel.Name = "JamCaptionLabel";
        JamCaptionLabel.Size = new Size(34, 17);
        JamCaptionLabel.TabIndex = 4;
        JamCaptionLabel.Text = "邪魔";
        JamCaptionLabel.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // EffectEntriesDataGridView
        // 
        EffectEntriesDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        EffectEntriesDataGridView.Columns.AddRange(new DataGridViewColumn[] { EffectColumn, EffectLanguageColumn, EffectLanguageDetailButtonColumn });
        EffectEntriesDataGridView.Location = new Point(13, 117);
        EffectEntriesDataGridView.Margin = new Padding(4, 3, 4, 3);
        EffectEntriesDataGridView.Name = "EffectEntriesDataGridView";
        EffectEntriesDataGridView.RowHeadersVisible = false;
        EffectEntriesDataGridView.Size = new Size(750, 168);
        EffectEntriesDataGridView.TabIndex = 7;
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
        // EffectEntriesCaptionLabel
        // 
        EffectEntriesCaptionLabel.AutoSize = true;
        EffectEntriesCaptionLabel.Location = new Point(13, 97);
        EffectEntriesCaptionLabel.Margin = new Padding(4, 0, 4, 0);
        EffectEntriesCaptionLabel.Name = "EffectEntriesCaptionLabel";
        EffectEntriesCaptionLabel.Size = new Size(34, 17);
        EffectEntriesCaptionLabel.TabIndex = 6;
        EffectEntriesCaptionLabel.Text = "効果";
        EffectEntriesCaptionLabel.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // FlavorTextEntriesDataGridView
        // 
        FlavorTextEntriesDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        FlavorTextEntriesDataGridView.Columns.AddRange(new DataGridViewColumn[] { FlavorTextColumn, FlavorTextLanguageColumn, FlavorVersionColumn, FlavorTextDetailButtonColumn });
        FlavorTextEntriesDataGridView.Location = new Point(13, 308);
        FlavorTextEntriesDataGridView.Margin = new Padding(4, 3, 4, 3);
        FlavorTextEntriesDataGridView.Name = "FlavorTextEntriesDataGridView";
        FlavorTextEntriesDataGridView.RowHeadersVisible = false;
        FlavorTextEntriesDataGridView.Size = new Size(750, 168);
        FlavorTextEntriesDataGridView.TabIndex = 9;
        FlavorTextEntriesDataGridView.CellClick += FlavorTextEntriesDataGridView_CellClick;
        FlavorTextEntriesDataGridView.CellDoubleClick += FlavorTextEntriesDataGridView_CellDoubleClick;
        // 
        // FlavorTextColumn
        // 
        FlavorTextColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
        FlavorTextColumn.DataPropertyName = "Text";
        FlavorTextColumn.HeaderText = "フレーバーテキスト";
        FlavorTextColumn.Name = "FlavorTextColumn";
        FlavorTextColumn.ReadOnly = true;
        FlavorTextColumn.Width = 88;
        // 
        // FlavorTextLanguageColumn
        // 
        FlavorTextLanguageColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
        FlavorTextLanguageColumn.DataPropertyName = "Language";
        FlavorTextLanguageColumn.HeaderText = "言語";
        FlavorTextLanguageColumn.Name = "FlavorTextLanguageColumn";
        FlavorTextLanguageColumn.ReadOnly = true;
        FlavorTextLanguageColumn.Width = 55;
        // 
        // FlavorVersionColumn
        // 
        FlavorVersionColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
        FlavorVersionColumn.DataPropertyName = "Version";
        FlavorVersionColumn.HeaderText = "バージョン";
        FlavorVersionColumn.Name = "FlavorVersionColumn";
        FlavorVersionColumn.ReadOnly = true;
        FlavorVersionColumn.Width = 62;
        // 
        // FlavorTextDetailButtonColumn
        // 
        FlavorTextDetailButtonColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
        FlavorTextDetailButtonColumn.HeaderText = "詳細";
        FlavorTextDetailButtonColumn.Name = "FlavorTextDetailButtonColumn";
        FlavorTextDetailButtonColumn.Text = "詳細";
        FlavorTextDetailButtonColumn.UseColumnTextForButtonValue = true;
        FlavorTextDetailButtonColumn.Width = 36;
        // 
        // CloseButton
        // 
        CloseButton.Location = new Point(687, 482);
        CloseButton.Margin = new Padding(4, 3, 4, 3);
        CloseButton.Name = "CloseButton";
        CloseButton.Size = new Size(76, 35);
        CloseButton.TabIndex = 11;
        CloseButton.Text = "閉じる";
        CloseButton.UseVisualStyleBackColor = true;
        CloseButton.Click += CloseButton_Click;
        // 
        // FlavorTextEntriesCaptionLabel
        // 
        FlavorTextEntriesCaptionLabel.AutoSize = true;
        FlavorTextEntriesCaptionLabel.Location = new Point(13, 288);
        FlavorTextEntriesCaptionLabel.Margin = new Padding(4, 0, 4, 0);
        FlavorTextEntriesCaptionLabel.Name = "FlavorTextEntriesCaptionLabel";
        FlavorTextEntriesCaptionLabel.Size = new Size(103, 17);
        FlavorTextEntriesCaptionLabel.TabIndex = 8;
        FlavorTextEntriesCaptionLabel.Text = "フレーバーテキスト";
        FlavorTextEntriesCaptionLabel.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // IdTextBox
        // 
        IdTextBox.Location = new Point(93, 12);
        IdTextBox.Name = "IdTextBox";
        IdTextBox.ReadOnly = true;
        IdTextBox.Size = new Size(74, 24);
        IdTextBox.TabIndex = 1;
        // 
        // AppealTextBox
        // 
        AppealTextBox.Location = new Point(93, 42);
        AppealTextBox.Name = "AppealTextBox";
        AppealTextBox.ReadOnly = true;
        AppealTextBox.Size = new Size(74, 24);
        AppealTextBox.TabIndex = 3;
        // 
        // JamTextBox
        // 
        JamTextBox.Location = new Point(92, 72);
        JamTextBox.Name = "JamTextBox";
        JamTextBox.ReadOnly = true;
        JamTextBox.Size = new Size(75, 24);
        JamTextBox.TabIndex = 5;
        // 
        // PropertyButton
        // 
        PropertyButton.Location = new Point(603, 482);
        PropertyButton.Margin = new Padding(4, 3, 4, 3);
        PropertyButton.Name = "PropertyButton";
        PropertyButton.Size = new Size(76, 35);
        PropertyButton.TabIndex = 10;
        PropertyButton.Text = "プロパティ";
        PropertyButton.UseVisualStyleBackColor = true;
        PropertyButton.Click += PropertyButton_Click;
        // 
        // ContestEffectInfoForm
        // 
        AutoScaleDimensions = new SizeF(9F, 17F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(772, 529);
        Controls.Add(PropertyButton);
        Controls.Add(JamTextBox);
        Controls.Add(AppealTextBox);
        Controls.Add(IdTextBox);
        Controls.Add(FlavorTextEntriesCaptionLabel);
        Controls.Add(CloseButton);
        Controls.Add(FlavorTextEntriesDataGridView);
        Controls.Add(EffectEntriesCaptionLabel);
        Controls.Add(EffectEntriesDataGridView);
        Controls.Add(JamCaptionLabel);
        Controls.Add(AppealCaptionLabel);
        Controls.Add(IdCaptionLabel);
        Font = new Font("Meiryo UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 128);
        FormBorderStyle = FormBorderStyle.FixedSingle;
        Margin = new Padding(4, 3, 4, 3);
        MaximizeBox = false;
        Name = "ContestEffectInfoForm";
        StartPosition = FormStartPosition.CenterParent;
        Text = "コンテスト効果";
        Load += ContestEffectInfoForm_Load;
        ((System.ComponentModel.ISupportInitialize)EffectEntriesDataGridView).EndInit();
        ((System.ComponentModel.ISupportInitialize)FlavorTextEntriesDataGridView).EndInit();
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion
    private Label AppealCaptionLabel;
    private Label IdCaptionLabel;
    private Label JamCaptionLabel;
    private DataGridView EffectEntriesDataGridView;
    private Label EffectEntriesCaptionLabel;
    private DataGridView FlavorTextEntriesDataGridView;
    private Button CloseButton;
    private Label FlavorTextEntriesCaptionLabel;
    private DataGridViewTextBoxColumn EffectColumn;
    private DataGridViewTextBoxColumn EffectLanguageColumn;
    private DataGridViewButtonColumn EffectLanguageDetailButtonColumn;
    private DataGridViewTextBoxColumn FlavorTextColumn;
    private DataGridViewTextBoxColumn FlavorTextLanguageColumn;
    private DataGridViewTextBoxColumn FlavorVersionColumn;
    private DataGridViewButtonColumn FlavorTextDetailButtonColumn;
    private TextBox IdTextBox;
    private TextBox AppealTextBox;
    private TextBox JamTextBox;
    private Button PropertyButton;
}
