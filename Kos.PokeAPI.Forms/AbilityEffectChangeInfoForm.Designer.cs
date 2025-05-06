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
        VersionGroupDetailButton = new Button();
        VersionGroupCaptionLabel = new Label();
        VersionGroupTextBox = new TextBox();
        EffectEntriesDataGridView = new DataGridView();
        EffectColumn = new DataGridViewTextBoxColumn();
        EffectLanguageColumn = new DataGridViewTextBoxColumn();
        EffectLanguageDetailButtonColumn = new DataGridViewButtonColumn();
        CloseButton = new Button();
        ((System.ComponentModel.ISupportInitialize)EffectEntriesDataGridView).BeginInit();
        SuspendLayout();
        // 
        // VersionGroupDetailButton
        // 
        VersionGroupDetailButton.Location = new Point(321, 10);
        VersionGroupDetailButton.Margin = new Padding(4, 3, 4, 3);
        VersionGroupDetailButton.Name = "VersionGroupDetailButton";
        VersionGroupDetailButton.Size = new Size(55, 27);
        VersionGroupDetailButton.TabIndex = 2;
        VersionGroupDetailButton.Text = "詳細";
        VersionGroupDetailButton.UseVisualStyleBackColor = true;
        VersionGroupDetailButton.Click += VersionGroupDetailButton_Click;
        // 
        // VersionGroupCaptionLabel
        // 
        VersionGroupCaptionLabel.AutoSize = true;
        VersionGroupCaptionLabel.Location = new Point(12, 15);
        VersionGroupCaptionLabel.Margin = new Padding(4, 0, 4, 0);
        VersionGroupCaptionLabel.Name = "VersionGroupCaptionLabel";
        VersionGroupCaptionLabel.Size = new Size(104, 17);
        VersionGroupCaptionLabel.TabIndex = 0;
        VersionGroupCaptionLabel.Text = "バージョングループ";
        VersionGroupCaptionLabel.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // VersionGroupTextBox
        // 
        VersionGroupTextBox.Location = new Point(123, 12);
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
        EffectEntriesDataGridView.TabIndex = 3;
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
        CloseButton.Location = new Point(781, 217);
        CloseButton.Margin = new Padding(4, 3, 4, 3);
        CloseButton.Name = "CloseButton";
        CloseButton.Size = new Size(82, 40);
        CloseButton.TabIndex = 4;
        CloseButton.Text = "閉じる";
        CloseButton.UseVisualStyleBackColor = true;
        CloseButton.Click += CloseButton_Click;
        // 
        // AbilityEffectChangeInfoForm
        // 
        AutoScaleDimensions = new SizeF(9F, 17F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(877, 265);
        Controls.Add(CloseButton);
        Controls.Add(EffectEntriesDataGridView);
        Controls.Add(VersionGroupDetailButton);
        Controls.Add(VersionGroupCaptionLabel);
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

    private Button VersionGroupDetailButton;
    private Label VersionGroupCaptionLabel;
    private TextBox VersionGroupTextBox;
    private DataGridView EffectEntriesDataGridView;
    private DataGridViewTextBoxColumn EffectColumn;
    private DataGridViewTextBoxColumn EffectLanguageColumn;
    private DataGridViewButtonColumn EffectLanguageDetailButtonColumn;
    private Button CloseButton;
}