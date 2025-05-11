namespace Kos.PokeAPI.Forms;

partial class AbilityEffectChangeInfoForm
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
        VersionGroupButton = new Button();
        VersionGroupTextBox = new TextBox();
        EffectEntriesDataGridView = new DataGridView();
        EffectColumn = new DataGridViewTextBoxColumn();
        EffectLanguageColumn = new DataGridViewTextBoxColumn();
        EffectLanguageDetailButtonColumn = new DataGridViewButtonColumn();
        CloseButton = new Button();
        PropertyButton = new Button();
        ((System.ComponentModel.ISupportInitialize)EffectEntriesDataGridView).BeginInit();
        SuspendLayout();
        // 
        // VersionGroupButton
        // 
        VersionGroupButton.Location = new Point(13, 10);
        VersionGroupButton.Margin = new Padding(4, 3, 4, 3);
        VersionGroupButton.Name = "VersionGroupButton";
        VersionGroupButton.Size = new Size(115, 27);
        VersionGroupButton.TabIndex = 0;
        VersionGroupButton.Text = "バージョングループ";
        VersionGroupButton.UseVisualStyleBackColor = true;
        VersionGroupButton.Click += VersionGroupButton_Click;
        // 
        // VersionGroupTextBox
        // 
        VersionGroupTextBox.Location = new Point(135, 12);
        VersionGroupTextBox.Name = "VersionGroupTextBox";
        VersionGroupTextBox.ReadOnly = true;
        VersionGroupTextBox.Size = new Size(191, 24);
        VersionGroupTextBox.TabIndex = 1;
        // 
        // EffectEntriesDataGridView
        // 
        EffectEntriesDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        EffectEntriesDataGridView.Columns.AddRange(new DataGridViewColumn[] { EffectColumn, EffectLanguageColumn, EffectLanguageDetailButtonColumn });
        EffectEntriesDataGridView.Location = new Point(12, 43);
        EffectEntriesDataGridView.Margin = new Padding(4, 3, 4, 3);
        EffectEntriesDataGridView.Name = "EffectEntriesDataGridView";
        EffectEntriesDataGridView.RowHeadersVisible = false;
        EffectEntriesDataGridView.Size = new Size(851, 168);
        EffectEntriesDataGridView.TabIndex = 2;
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
        CloseButton.Location = new Point(787, 218);
        CloseButton.Margin = new Padding(4, 3, 4, 3);
        CloseButton.Name = "CloseButton";
        CloseButton.Size = new Size(76, 35);
        CloseButton.TabIndex = 4;
        CloseButton.Text = "閉じる";
        CloseButton.UseVisualStyleBackColor = true;
        CloseButton.Click += CloseButton_Click;
        // 
        // PropertyButton
        // 
        PropertyButton.Location = new Point(703, 218);
        PropertyButton.Margin = new Padding(4, 3, 4, 3);
        PropertyButton.Name = "PropertyButton";
        PropertyButton.Size = new Size(76, 35);
        PropertyButton.TabIndex = 3;
        PropertyButton.Text = "プロパティ";
        PropertyButton.UseVisualStyleBackColor = true;
        PropertyButton.Click += PropertyButton_Click;
        // 
        // AbilityEffectChangeInfoForm
        // 
        AutoScaleDimensions = new SizeF(9F, 17F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(877, 265);
        Controls.Add(PropertyButton);
        Controls.Add(CloseButton);
        Controls.Add(EffectEntriesDataGridView);
        Controls.Add(VersionGroupButton);
        Controls.Add(VersionGroupTextBox);
        Font = new Font("Meiryo UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 128);
        FormBorderStyle = FormBorderStyle.FixedSingle;
        Margin = new Padding(4, 3, 4, 3);
        MaximizeBox = false;
        Name = "AbilityEffectChangeInfoForm";
        StartPosition = FormStartPosition.CenterParent;
        Text = "バージョンごとの効果";
        ((System.ComponentModel.ISupportInitialize)EffectEntriesDataGridView).EndInit();
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private Button VersionGroupButton;
    private TextBox VersionGroupTextBox;
    private DataGridView EffectEntriesDataGridView;
    private DataGridViewTextBoxColumn EffectColumn;
    private DataGridViewTextBoxColumn EffectLanguageColumn;
    private DataGridViewButtonColumn EffectLanguageDetailButtonColumn;
    private Button CloseButton;
    private Button PropertyButton;
}