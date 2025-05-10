namespace Kos.PokeAPI.Forms;

partial class SuperContestEffectInfoForm
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
        AppealCaptionLabel = new Label();
        IdCaptionLabel = new Label();
        FlavorTextEntriesDataGridView = new DataGridView();
        FlavorTextColumn = new DataGridViewTextBoxColumn();
        FlavorTextLanguageColumn = new DataGridViewTextBoxColumn();
        FlavorTextButtonColumn = new DataGridViewButtonColumn();
        FlavorTextEntriesCaptionLabel = new Label();
        MovesDataGridView = new DataGridView();
        MovesColumn = new DataGridViewTextBoxColumn();
        MovesInfoColumn = new DataGridViewButtonColumn();
        MovesCaptionLabel = new Label();
        CloseButton = new Button();
        PropetyButton = new Button();
        IdTextBox = new TextBox();
        AppealTextBox = new TextBox();
        ((System.ComponentModel.ISupportInitialize)FlavorTextEntriesDataGridView).BeginInit();
        ((System.ComponentModel.ISupportInitialize)MovesDataGridView).BeginInit();
        SuspendLayout();
        // 
        // AppealCaptionLabel
        // 
        AppealCaptionLabel.AutoSize = true;
        AppealCaptionLabel.Location = new Point(121, 45);
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
        IdCaptionLabel.Location = new Point(13, 12);
        IdCaptionLabel.Margin = new Padding(4, 0, 4, 0);
        IdCaptionLabel.Name = "IdCaptionLabel";
        IdCaptionLabel.Size = new Size(159, 22);
        IdCaptionLabel.TabIndex = 0;
        IdCaptionLabel.Text = "スーパーコンテストの効果ID";
        IdCaptionLabel.TextAlign = ContentAlignment.MiddleLeft;
        IdCaptionLabel.UseCompatibleTextRendering = true;
        // 
        // FlavorTextEntriesDataGridView
        // 
        FlavorTextEntriesDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        FlavorTextEntriesDataGridView.Columns.AddRange(new DataGridViewColumn[] { FlavorTextColumn, FlavorTextLanguageColumn, FlavorTextButtonColumn });
        FlavorTextEntriesDataGridView.Location = new Point(13, 86);
        FlavorTextEntriesDataGridView.Margin = new Padding(4, 3, 4, 3);
        FlavorTextEntriesDataGridView.Name = "FlavorTextEntriesDataGridView";
        FlavorTextEntriesDataGridView.RowHeadersVisible = false;
        FlavorTextEntriesDataGridView.Size = new Size(790, 170);
        FlavorTextEntriesDataGridView.TabIndex = 5;
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
        // FlavorTextButtonColumn
        // 
        FlavorTextButtonColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
        FlavorTextButtonColumn.HeaderText = "詳細";
        FlavorTextButtonColumn.Name = "FlavorTextButtonColumn";
        FlavorTextButtonColumn.Text = "詳細";
        FlavorTextButtonColumn.UseColumnTextForButtonValue = true;
        FlavorTextButtonColumn.Width = 36;
        // 
        // FlavorTextEntriesCaptionLabel
        // 
        FlavorTextEntriesCaptionLabel.AutoSize = true;
        FlavorTextEntriesCaptionLabel.Location = new Point(13, 66);
        FlavorTextEntriesCaptionLabel.Margin = new Padding(4, 0, 4, 0);
        FlavorTextEntriesCaptionLabel.Name = "FlavorTextEntriesCaptionLabel";
        FlavorTextEntriesCaptionLabel.Size = new Size(103, 17);
        FlavorTextEntriesCaptionLabel.TabIndex = 4;
        FlavorTextEntriesCaptionLabel.Text = "フレーバーテキスト";
        FlavorTextEntriesCaptionLabel.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // MovesDataGridView
        // 
        MovesDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        MovesDataGridView.Columns.AddRange(new DataGridViewColumn[] { MovesColumn, MovesInfoColumn });
        MovesDataGridView.Location = new Point(13, 279);
        MovesDataGridView.Margin = new Padding(4, 3, 4, 3);
        MovesDataGridView.Name = "MovesDataGridView";
        MovesDataGridView.RowHeadersVisible = false;
        MovesDataGridView.Size = new Size(423, 170);
        MovesDataGridView.TabIndex = 7;
        MovesDataGridView.CellClick += MovesDataGridView_CellClick;
        MovesDataGridView.CellDoubleClick += MovesDataGridView_CellDoubleClick;
        // 
        // MovesColumn
        // 
        MovesColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
        MovesColumn.DataPropertyName = "Name";
        MovesColumn.HeaderText = "技";
        MovesColumn.Name = "MovesColumn";
        MovesColumn.ReadOnly = true;
        MovesColumn.Width = 46;
        // 
        // MovesInfoColumn
        // 
        MovesInfoColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
        MovesInfoColumn.HeaderText = "詳細";
        MovesInfoColumn.Name = "MovesInfoColumn";
        MovesInfoColumn.Text = "詳細";
        MovesInfoColumn.UseColumnTextForButtonValue = true;
        MovesInfoColumn.Width = 40;
        // 
        // MovesCaptionLabel
        // 
        MovesCaptionLabel.AutoSize = true;
        MovesCaptionLabel.Location = new Point(13, 259);
        MovesCaptionLabel.Margin = new Padding(4, 0, 4, 0);
        MovesCaptionLabel.Name = "MovesCaptionLabel";
        MovesCaptionLabel.Size = new Size(21, 17);
        MovesCaptionLabel.TabIndex = 6;
        MovesCaptionLabel.Text = "技";
        MovesCaptionLabel.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // CloseButton
        // 
        CloseButton.Location = new Point(727, 414);
        CloseButton.Margin = new Padding(4, 3, 4, 3);
        CloseButton.Name = "CloseButton";
        CloseButton.Size = new Size(76, 35);
        CloseButton.TabIndex = 9;
        CloseButton.Text = "閉じる";
        CloseButton.UseVisualStyleBackColor = true;
        CloseButton.Click += CloseButton_Click;
        // 
        // PropetyButton
        // 
        PropetyButton.Location = new Point(653, 414);
        PropetyButton.Margin = new Padding(4, 3, 4, 3);
        PropetyButton.Name = "PropetyButton";
        PropetyButton.Size = new Size(76, 35);
        PropetyButton.TabIndex = 8;
        PropetyButton.Text = "プロパティ";
        PropetyButton.UseVisualStyleBackColor = true;
        PropetyButton.Click += PropetyButton_Click;
        // 
        // IdTextBox
        // 
        IdTextBox.Location = new Point(181, 12);
        IdTextBox.Margin = new Padding(5, 3, 5, 3);
        IdTextBox.Name = "IdTextBox";
        IdTextBox.ReadOnly = true;
        IdTextBox.Size = new Size(172, 24);
        IdTextBox.TabIndex = 1;
        // 
        // AppealTextBox
        // 
        AppealTextBox.Location = new Point(181, 42);
        AppealTextBox.Margin = new Padding(5, 3, 5, 3);
        AppealTextBox.Name = "AppealTextBox";
        AppealTextBox.ReadOnly = true;
        AppealTextBox.Size = new Size(172, 24);
        AppealTextBox.TabIndex = 3;
        // 
        // SuperContestEffectInfoForm
        // 
        AutoScaleDimensions = new SizeF(9F, 17F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(822, 456);
        Controls.Add(AppealTextBox);
        Controls.Add(IdTextBox);
        Controls.Add(PropetyButton);
        Controls.Add(CloseButton);
        Controls.Add(MovesCaptionLabel);
        Controls.Add(MovesDataGridView);
        Controls.Add(FlavorTextEntriesCaptionLabel);
        Controls.Add(FlavorTextEntriesDataGridView);
        Controls.Add(AppealCaptionLabel);
        Controls.Add(IdCaptionLabel);
        Font = new Font("Meiryo UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 128);
        FormBorderStyle = FormBorderStyle.FixedSingle;
        Margin = new Padding(4, 3, 4, 3);
        MaximizeBox = false;
        MinimizeBox = false;
        Name = "SuperContestEffectInfoForm";
        StartPosition = FormStartPosition.CenterParent;
        Text = "スーパーコンテストの効果";
        Load += SuperContestEffectInfoForm_Load;
        ((System.ComponentModel.ISupportInitialize)FlavorTextEntriesDataGridView).EndInit();
        ((System.ComponentModel.ISupportInitialize)MovesDataGridView).EndInit();
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion
    private Label AppealCaptionLabel;
    private Label IdCaptionLabel;
    private DataGridView FlavorTextEntriesDataGridView;
    private Label FlavorTextEntriesCaptionLabel;
    private DataGridView MovesDataGridView;
    private Label MovesCaptionLabel;
    private Button CloseButton;
    private DataGridViewTextBoxColumn MovesColumn;
    private DataGridViewButtonColumn MovesInfoColumn;
    private Button PropetyButton;
    private TextBox IdTextBox;
    private TextBox AppealTextBox;
    private DataGridViewTextBoxColumn FlavorTextColumn;
    private DataGridViewTextBoxColumn FlavorTextLanguageColumn;
    private DataGridViewButtonColumn FlavorTextButtonColumn;
}