namespace Kos.PokeAPI.Forms;

partial class NaturePokeathlonStatAffectSetsInfoForm
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
        IncreaseCaptionLabel = new Label();
        IncreaseDataGridView = new DataGridView();
        dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
        dataGridViewButtonColumn1 = new DataGridViewButtonColumn();
        DecreaseCaptionLabel = new Label();
        DecreaseDataGridView = new DataGridView();
        dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
        dataGridViewButtonColumn2 = new DataGridViewButtonColumn();
        PropertyButton = new Button();
        CloseButton = new Button();
        ((System.ComponentModel.ISupportInitialize)IncreaseDataGridView).BeginInit();
        ((System.ComponentModel.ISupportInitialize)DecreaseDataGridView).BeginInit();
        SuspendLayout();
        // 
        // IncreaseCaptionLabel
        // 
        IncreaseCaptionLabel.AutoSize = true;
        IncreaseCaptionLabel.Location = new Point(14, 9);
        IncreaseCaptionLabel.Margin = new Padding(5, 0, 5, 0);
        IncreaseCaptionLabel.Name = "IncreaseCaptionLabel";
        IncreaseCaptionLabel.Size = new Size(111, 17);
        IncreaseCaptionLabel.TabIndex = 0;
        IncreaseCaptionLabel.Text = "上昇する性格リスト";
        IncreaseCaptionLabel.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // IncreaseDataGridView
        // 
        IncreaseDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        IncreaseDataGridView.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1, dataGridViewButtonColumn1 });
        IncreaseDataGridView.Location = new Point(16, 31);
        IncreaseDataGridView.Margin = new Padding(5, 3, 5, 3);
        IncreaseDataGridView.Name = "IncreaseDataGridView";
        IncreaseDataGridView.RowHeadersVisible = false;
        IncreaseDataGridView.Size = new Size(282, 271);
        IncreaseDataGridView.TabIndex = 1;
        IncreaseDataGridView.CellClick += IncreaseDataGridView_CellClick;
        IncreaseDataGridView.CellDoubleClick += IncreaseDataGridView_CellDoubleClick;
        // 
        // dataGridViewTextBoxColumn1
        // 
        dataGridViewTextBoxColumn1.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
        dataGridViewTextBoxColumn1.DataPropertyName = "Nature";
        dataGridViewTextBoxColumn1.HeaderText = "性格";
        dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
        dataGridViewTextBoxColumn1.ReadOnly = true;
        dataGridViewTextBoxColumn1.Width = 59;
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
        // DecreaseCaptionLabel
        // 
        DecreaseCaptionLabel.AutoSize = true;
        DecreaseCaptionLabel.Location = new Point(306, 9);
        DecreaseCaptionLabel.Margin = new Padding(5, 0, 5, 0);
        DecreaseCaptionLabel.Name = "DecreaseCaptionLabel";
        DecreaseCaptionLabel.Size = new Size(111, 17);
        DecreaseCaptionLabel.TabIndex = 2;
        DecreaseCaptionLabel.Text = "下降する性格リスト";
        DecreaseCaptionLabel.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // DecreaseDataGridView
        // 
        DecreaseDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        DecreaseDataGridView.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn2, dataGridViewButtonColumn2 });
        DecreaseDataGridView.Location = new Point(308, 31);
        DecreaseDataGridView.Margin = new Padding(5, 3, 5, 3);
        DecreaseDataGridView.Name = "DecreaseDataGridView";
        DecreaseDataGridView.RowHeadersVisible = false;
        DecreaseDataGridView.Size = new Size(282, 271);
        DecreaseDataGridView.TabIndex = 3;
        DecreaseDataGridView.CellClick += DecreaseDataGridView_CellClick;
        DecreaseDataGridView.CellDoubleClick += DecreaseDataGridView_CellDoubleClick;
        // 
        // dataGridViewTextBoxColumn2
        // 
        dataGridViewTextBoxColumn2.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
        dataGridViewTextBoxColumn2.DataPropertyName = "Nature";
        dataGridViewTextBoxColumn2.HeaderText = "性格";
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
        // PropertyButton
        // 
        PropertyButton.Location = new Point(430, 308);
        PropertyButton.Margin = new Padding(4, 3, 4, 3);
        PropertyButton.Name = "PropertyButton";
        PropertyButton.Size = new Size(76, 35);
        PropertyButton.TabIndex = 4;
        PropertyButton.Text = "プロパティ";
        PropertyButton.UseVisualStyleBackColor = true;
        PropertyButton.Click += PropertyButton_Click;
        // 
        // CloseButton
        // 
        CloseButton.Location = new Point(514, 308);
        CloseButton.Margin = new Padding(4, 3, 4, 3);
        CloseButton.Name = "CloseButton";
        CloseButton.Size = new Size(76, 35);
        CloseButton.TabIndex = 5;
        CloseButton.Text = "閉じる";
        CloseButton.UseVisualStyleBackColor = true;
        CloseButton.Click += CloseButton_Click;
        // 
        // NaturePokeathlonStatAffectSetsInfoForm
        // 
        AutoScaleDimensions = new SizeF(9F, 17F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(604, 352);
        Controls.Add(PropertyButton);
        Controls.Add(CloseButton);
        Controls.Add(DecreaseCaptionLabel);
        Controls.Add(DecreaseDataGridView);
        Controls.Add(IncreaseCaptionLabel);
        Controls.Add(IncreaseDataGridView);
        Font = new Font("Meiryo UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 128);
        FormBorderStyle = FormBorderStyle.FixedSingle;
        Margin = new Padding(4, 3, 4, 3);
        MaximizeBox = false;
        Name = "NaturePokeathlonStatAffectSetsInfoForm";
        StartPosition = FormStartPosition.CenterParent;
        Text = "性格が影響を与えるポケスロンのステータスセット";
        ((System.ComponentModel.ISupportInitialize)IncreaseDataGridView).EndInit();
        ((System.ComponentModel.ISupportInitialize)DecreaseDataGridView).EndInit();
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private Label IncreaseCaptionLabel;
    private DataGridView IncreaseDataGridView;
    private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
    private DataGridViewButtonColumn dataGridViewButtonColumn1;
    private Label DecreaseCaptionLabel;
    private DataGridView DecreaseDataGridView;
    private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
    private DataGridViewButtonColumn dataGridViewButtonColumn2;
    private Button PropertyButton;
    private Button CloseButton;
}