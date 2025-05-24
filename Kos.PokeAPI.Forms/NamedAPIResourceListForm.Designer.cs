namespace Kos.PokeAPI.Forms;

partial class NamedAPIResourceListForm
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
        NextPageButton = new Button();
        PrevPageButton = new Button();
        OpenButton = new Button();
        CloseButton = new Button();
        NamedAPIResourceListDataGridView = new DataGridView();
        NameColumn = new DataGridViewTextBoxColumn();
        UrlColumn = new DataGridViewTextBoxColumn();
        InfoColumn = new DataGridViewButtonColumn();
        ((System.ComponentModel.ISupportInitialize)NamedAPIResourceListDataGridView).BeginInit();
        SuspendLayout();
        // 
        // NextPageButton
        // 
        NextPageButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
        NextPageButton.Location = new Point(93, 404);
        NextPageButton.Name = "NextPageButton";
        NextPageButton.Size = new Size(75, 34);
        NextPageButton.TabIndex = 7;
        NextPageButton.Text = "次ページ";
        NextPageButton.UseVisualStyleBackColor = true;
        NextPageButton.Click += NextPageButton_Click;
        // 
        // PrevPageButton
        // 
        PrevPageButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
        PrevPageButton.Location = new Point(12, 404);
        PrevPageButton.Name = "PrevPageButton";
        PrevPageButton.Size = new Size(75, 34);
        PrevPageButton.TabIndex = 6;
        PrevPageButton.Text = "前ページ";
        PrevPageButton.UseVisualStyleBackColor = true;
        PrevPageButton.Click += PrevPageButton_Click;
        // 
        // OpenButton
        // 
        OpenButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
        OpenButton.Location = new Point(632, 404);
        OpenButton.Name = "OpenButton";
        OpenButton.Size = new Size(75, 34);
        OpenButton.TabIndex = 8;
        OpenButton.Text = "開く";
        OpenButton.UseVisualStyleBackColor = true;
        OpenButton.Click += OpenButton_Click;
        // 
        // CloseButton
        // 
        CloseButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
        CloseButton.Location = new Point(713, 404);
        CloseButton.Name = "CloseButton";
        CloseButton.Size = new Size(75, 34);
        CloseButton.TabIndex = 9;
        CloseButton.Text = "閉じる";
        CloseButton.UseVisualStyleBackColor = true;
        CloseButton.Click += CloseButton_Click;
        // 
        // NamedAPIResourceListDataGridView
        // 
        NamedAPIResourceListDataGridView.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
        NamedAPIResourceListDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        NamedAPIResourceListDataGridView.Columns.AddRange(new DataGridViewColumn[] { NameColumn, UrlColumn, InfoColumn });
        NamedAPIResourceListDataGridView.Location = new Point(12, 12);
        NamedAPIResourceListDataGridView.Name = "NamedAPIResourceListDataGridView";
        NamedAPIResourceListDataGridView.RowHeadersVisible = false;
        NamedAPIResourceListDataGridView.Size = new Size(776, 386);
        NamedAPIResourceListDataGridView.TabIndex = 5;
        NamedAPIResourceListDataGridView.CellClick += NamedAPIResourceListDataGridView_CellClick;
        NamedAPIResourceListDataGridView.CellDoubleClick += NamedAPIResourceListDataGridView_CellDoubleClick;
        // 
        // NameColumn
        // 
        NameColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
        NameColumn.DataPropertyName = "Name";
        NameColumn.HeaderText = "名前";
        NameColumn.Name = "NameColumn";
        NameColumn.ReadOnly = true;
        NameColumn.Width = 56;
        // 
        // UrlColumn
        // 
        UrlColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
        UrlColumn.DataPropertyName = "Url";
        UrlColumn.HeaderText = "URL";
        UrlColumn.Name = "UrlColumn";
        UrlColumn.ReadOnly = true;
        UrlColumn.Width = 53;
        // 
        // InfoColumn
        // 
        InfoColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
        InfoColumn.HeaderText = "詳細";
        InfoColumn.Name = "InfoColumn";
        InfoColumn.Text = "詳細";
        InfoColumn.UseColumnTextForButtonValue = true;
        InfoColumn.Width = 37;
        // 
        // NamedAPIResourceListForm
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(800, 450);
        Controls.Add(NextPageButton);
        Controls.Add(PrevPageButton);
        Controls.Add(OpenButton);
        Controls.Add(CloseButton);
        Controls.Add(NamedAPIResourceListDataGridView);
        FormBorderStyle = FormBorderStyle.FixedSingle;
        MaximizeBox = false;
        Name = "NamedAPIResourceListForm";
        StartPosition = FormStartPosition.CenterParent;
        Text = "名前付きAPIリソース";
        Load += NamedAPIResourceListForm_Load;
        ((System.ComponentModel.ISupportInitialize)NamedAPIResourceListDataGridView).EndInit();
        ResumeLayout(false);
    }

    #endregion

    private Button NextPageButton;
    private Button PrevPageButton;
    private Button OpenButton;
    private Button CloseButton;
    private DataGridView NamedAPIResourceListDataGridView;
    private DataGridViewTextBoxColumn NameColumn;
    private DataGridViewTextBoxColumn UrlColumn;
    private DataGridViewButtonColumn InfoColumn;
}
