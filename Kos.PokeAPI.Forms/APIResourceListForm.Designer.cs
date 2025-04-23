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
        APIResourceListDataGridView.Location = new Point(12, 12);
        APIResourceListDataGridView.Name = "APIResourceListDataGridView";
        APIResourceListDataGridView.RowHeadersVisible = false;
        APIResourceListDataGridView.Size = new Size(776, 386);
        APIResourceListDataGridView.TabIndex = 0;
        APIResourceListDataGridView.CellClick += APIResourceListDataGridView_CellClick;
        APIResourceListDataGridView.CellDoubleClick += APIResourceListDataGridView_CellDoubleClick;
        // 
        // UrlColumn
        // 
        UrlColumn.DataPropertyName = "Url";
        UrlColumn.HeaderText = "url";
        UrlColumn.Name = "UrlColumn";
        UrlColumn.ReadOnly = true;
        UrlColumn.Width = 600;
        // 
        // InfoColumn
        // 
        InfoColumn.HeaderText = "Info";
        InfoColumn.Name = "InfoColumn";
        InfoColumn.Text = "Info...";
        InfoColumn.UseColumnTextForButtonValue = true;
        InfoColumn.Width = 70;
        // 
        // NextPageButton
        // 
        NextPageButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
        NextPageButton.Location = new Point(93, 404);
        NextPageButton.Name = "NextPageButton";
        NextPageButton.Size = new Size(75, 34);
        NextPageButton.TabIndex = 2;
        NextPageButton.Text = "Next";
        NextPageButton.UseVisualStyleBackColor = true;
        NextPageButton.Click += NextPageButton_Click;
        // 
        // PrevPageButton
        // 
        PrevPageButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
        PrevPageButton.Location = new Point(12, 404);
        PrevPageButton.Name = "PrevPageButton";
        PrevPageButton.Size = new Size(75, 34);
        PrevPageButton.TabIndex = 1;
        PrevPageButton.Text = "Previous";
        PrevPageButton.UseVisualStyleBackColor = true;
        PrevPageButton.Click += PrevPageButton_Click;
        // 
        // OpenButton
        // 
        OpenButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
        OpenButton.Location = new Point(632, 404);
        OpenButton.Name = "OpenButton";
        OpenButton.Size = new Size(75, 34);
        OpenButton.TabIndex = 3;
        OpenButton.Text = "Open";
        OpenButton.UseVisualStyleBackColor = true;
        OpenButton.Click += OpenButton_Click;
        // 
        // CloseButton
        // 
        CloseButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
        CloseButton.Location = new Point(713, 404);
        CloseButton.Name = "CloseButton";
        CloseButton.Size = new Size(75, 34);
        CloseButton.TabIndex = 4;
        CloseButton.Text = "Close";
        CloseButton.UseVisualStyleBackColor = true;
        CloseButton.Click += CloseButton_Click;
        // 
        // APIResourceListForm
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(800, 450);
        Controls.Add(NextPageButton);
        Controls.Add(PrevPageButton);
        Controls.Add(OpenButton);
        Controls.Add(CloseButton);
        Controls.Add(APIResourceListDataGridView);
        FormBorderStyle = FormBorderStyle.FixedSingle;
        MaximizeBox = false;
        Name = "APIResourceListForm";
        Text = "APIResourceList";
        Load += APIResourceListForm_Load;
        ((System.ComponentModel.ISupportInitialize)APIResourceListDataGridView).EndInit();
        ResumeLayout(false);
    }

    #endregion

    private DataGridView APIResourceListDataGridView;
    private DataGridViewTextBoxColumn UrlColumn;
    private DataGridViewButtonColumn InfoColumn;
    private Button NextPageButton;
    private Button PrevPageButton;
    private Button OpenButton;
    private Button CloseButton;
}