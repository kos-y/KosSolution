namespace Kos.PokeAPI.Forms;

partial class APIResourceListForm
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
        APIResourceListDataGridView = new DataGridView();
        UrlColumn = new DataGridViewTextBoxColumn();
        InfoColumn = new DataGridViewButtonColumn();
        NextPageButton = new Button();
        PrevPageButton = new Button();
        OpenButton = new Button();
        CloseButton = new Button();
        ((System.ComponentModel.ISupportInitialize)APIResourceListDataGridView).BeginInit();
        SuspendLayout();
        // 
        // APIResourceListDataGridView
        // 
        APIResourceListDataGridView.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
        APIResourceListDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        APIResourceListDataGridView.Columns.AddRange(new DataGridViewColumn[] { UrlColumn, InfoColumn });
        APIResourceListDataGridView.Location = new Point(14, 12);
        APIResourceListDataGridView.Name = "APIResourceListDataGridView";
        APIResourceListDataGridView.RowHeadersVisible = false;
        APIResourceListDataGridView.Size = new Size(887, 386);
        APIResourceListDataGridView.TabIndex = 0;
        APIResourceListDataGridView.CellClick += APIResourceListDataGridView_CellClick;
        APIResourceListDataGridView.CellDoubleClick += APIResourceListDataGridView_CellDoubleClick;
        // 
        // UrlColumn
        // 
        UrlColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
        UrlColumn.DataPropertyName = "Url";
        UrlColumn.HeaderText = "URL";
        UrlColumn.Name = "UrlColumn";
        UrlColumn.ReadOnly = true;
        UrlColumn.Width = 57;
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
        // NextPageButton
        // 
        NextPageButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
        NextPageButton.Location = new Point(106, 404);
        NextPageButton.Name = "NextPageButton";
        NextPageButton.Size = new Size(86, 34);
        NextPageButton.TabIndex = 2;
        NextPageButton.Text = "次ページ";
        NextPageButton.UseVisualStyleBackColor = true;
        NextPageButton.Click += NextPageButton_Click;
        // 
        // PrevPageButton
        // 
        PrevPageButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
        PrevPageButton.Location = new Point(14, 404);
        PrevPageButton.Name = "PrevPageButton";
        PrevPageButton.Size = new Size(86, 34);
        PrevPageButton.TabIndex = 1;
        PrevPageButton.Text = "前ページ";
        PrevPageButton.UseVisualStyleBackColor = true;
        PrevPageButton.Click += PrevPageButton_Click;
        // 
        // OpenButton
        // 
        OpenButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
        OpenButton.Location = new Point(722, 404);
        OpenButton.Name = "OpenButton";
        OpenButton.Size = new Size(86, 34);
        OpenButton.TabIndex = 3;
        OpenButton.Text = "開く";
        OpenButton.UseVisualStyleBackColor = true;
        OpenButton.Click += OpenButton_Click;
        // 
        // CloseButton
        // 
        CloseButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
        CloseButton.Location = new Point(815, 404);
        CloseButton.Name = "CloseButton";
        CloseButton.Size = new Size(86, 34);
        CloseButton.TabIndex = 4;
        CloseButton.Text = "閉じる";
        CloseButton.UseVisualStyleBackColor = true;
        CloseButton.Click += CloseButton_Click;
        // 
        // APIResourceListForm
        // 
        AutoScaleDimensions = new SizeF(8F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(914, 450);
        Controls.Add(NextPageButton);
        Controls.Add(PrevPageButton);
        Controls.Add(OpenButton);
        Controls.Add(CloseButton);
        Controls.Add(APIResourceListDataGridView);
        Font = new Font("Meiryo UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 128);
        FormBorderStyle = FormBorderStyle.FixedSingle;
        MaximizeBox = false;
        Name = "APIResourceListForm";
        StartPosition = FormStartPosition.CenterParent;
        Text = "APIResourceList";
        Load += APIResourceListForm_Load;
        ((System.ComponentModel.ISupportInitialize)APIResourceListDataGridView).EndInit();
        ResumeLayout(false);
    }

    #endregion

    private DataGridView APIResourceListDataGridView;
    private Button NextPageButton;
    private Button PrevPageButton;
    private Button OpenButton;
    private Button CloseButton;
    private DataGridViewTextBoxColumn UrlColumn;
    private DataGridViewButtonColumn InfoColumn;
}