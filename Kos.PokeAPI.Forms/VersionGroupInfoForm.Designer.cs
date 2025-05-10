namespace Kos.PokeAPI.Forms;

partial class VersionGroupInfoForm
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
        GenerationButton = new Button();
        MoveLearnMethodsDataGridView = new DataGridView();
        dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
        dataGridViewButtonColumn1 = new DataGridViewButtonColumn();
        MoveLearnMethodsCaptionLabel = new Label();
        PokedexesCaptionLabel = new Label();
        PokedexesDataGridView = new DataGridView();
        dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
        dataGridViewButtonColumn2 = new DataGridViewButtonColumn();
        RegionsCaptionLabel = new Label();
        RegionsDataGridView = new DataGridView();
        dataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
        dataGridViewButtonColumn3 = new DataGridViewButtonColumn();
        VersionsCaptionLabel = new Label();
        VersionsDataGridView = new DataGridView();
        dataGridViewTextBoxColumn4 = new DataGridViewTextBoxColumn();
        dataGridViewButtonColumn4 = new DataGridViewButtonColumn();
        CloseButton = new Button();
        NameTextBox = new TextBox();
        IdTextBox = new TextBox();
        OrderTextBox = new TextBox();
        GenerationTextBox = new TextBox();
        PropertyButton = new Button();
        ((System.ComponentModel.ISupportInitialize)MoveLearnMethodsDataGridView).BeginInit();
        ((System.ComponentModel.ISupportInitialize)PokedexesDataGridView).BeginInit();
        ((System.ComponentModel.ISupportInitialize)RegionsDataGridView).BeginInit();
        ((System.ComponentModel.ISupportInitialize)VersionsDataGridView).BeginInit();
        SuspendLayout();
        // 
        // NameCaptionLabel
        // 
        NameCaptionLabel.AutoSize = true;
        NameCaptionLabel.Location = new Point(15, 36);
        NameCaptionLabel.Margin = new Padding(4, 0, 4, 0);
        NameCaptionLabel.Name = "NameCaptionLabel";
        NameCaptionLabel.Size = new Size(142, 17);
        NameCaptionLabel.TabIndex = 2;
        NameCaptionLabel.Text = "バージョングループの名前";
        NameCaptionLabel.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // IdCaptionLabel
        // 
        IdCaptionLabel.AutoSize = true;
        IdCaptionLabel.Location = new Point(36, 10);
        IdCaptionLabel.Margin = new Padding(4, 0, 4, 0);
        IdCaptionLabel.Name = "IdCaptionLabel";
        IdCaptionLabel.Size = new Size(121, 17);
        IdCaptionLabel.TabIndex = 0;
        IdCaptionLabel.Text = "バージョングループID";
        IdCaptionLabel.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // OrderCaptionLabel
        // 
        OrderCaptionLabel.AutoSize = true;
        OrderCaptionLabel.Location = new Point(123, 70);
        OrderCaptionLabel.Margin = new Padding(4, 0, 4, 0);
        OrderCaptionLabel.Name = "OrderCaptionLabel";
        OrderCaptionLabel.Size = new Size(34, 17);
        OrderCaptionLabel.TabIndex = 4;
        OrderCaptionLabel.Text = "順番";
        OrderCaptionLabel.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // GenerationButton
        // 
        GenerationButton.Location = new Point(102, 95);
        GenerationButton.Margin = new Padding(4, 3, 4, 3);
        GenerationButton.Name = "GenerationButton";
        GenerationButton.Size = new Size(55, 26);
        GenerationButton.TabIndex = 6;
        GenerationButton.Text = "世代";
        GenerationButton.UseVisualStyleBackColor = true;
        GenerationButton.Click += GenerationInfoButton_Click;
        // 
        // MoveLearnMethodsDataGridView
        // 
        MoveLearnMethodsDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        MoveLearnMethodsDataGridView.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1, dataGridViewButtonColumn1 });
        MoveLearnMethodsDataGridView.Location = new Point(15, 153);
        MoveLearnMethodsDataGridView.Margin = new Padding(4, 3, 4, 3);
        MoveLearnMethodsDataGridView.Name = "MoveLearnMethodsDataGridView";
        MoveLearnMethodsDataGridView.RowHeadersVisible = false;
        MoveLearnMethodsDataGridView.Size = new Size(298, 170);
        MoveLearnMethodsDataGridView.TabIndex = 9;
        MoveLearnMethodsDataGridView.CellClick += MoveLearnMethodsDataGridView_CellClick;
        MoveLearnMethodsDataGridView.CellDoubleClick += MoveLearnMethodsDataGridView_CellDoubleClick;
        // 
        // dataGridViewTextBoxColumn1
        // 
        dataGridViewTextBoxColumn1.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
        dataGridViewTextBoxColumn1.DataPropertyName = "Name";
        dataGridViewTextBoxColumn1.HeaderText = "技の習得方法";
        dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
        dataGridViewTextBoxColumn1.ReadOnly = true;
        dataGridViewTextBoxColumn1.Width = 110;
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
        // MoveLearnMethodsCaptionLabel
        // 
        MoveLearnMethodsCaptionLabel.AutoSize = true;
        MoveLearnMethodsCaptionLabel.Location = new Point(15, 133);
        MoveLearnMethodsCaptionLabel.Margin = new Padding(4, 0, 4, 0);
        MoveLearnMethodsCaptionLabel.Name = "MoveLearnMethodsCaptionLabel";
        MoveLearnMethodsCaptionLabel.Size = new Size(85, 17);
        MoveLearnMethodsCaptionLabel.TabIndex = 8;
        MoveLearnMethodsCaptionLabel.Text = "技の習得方法";
        MoveLearnMethodsCaptionLabel.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // PokedexesCaptionLabel
        // 
        PokedexesCaptionLabel.AutoSize = true;
        PokedexesCaptionLabel.Location = new Point(321, 326);
        PokedexesCaptionLabel.Margin = new Padding(4, 0, 4, 0);
        PokedexesCaptionLabel.Name = "PokedexesCaptionLabel";
        PokedexesCaptionLabel.Size = new Size(75, 17);
        PokedexesCaptionLabel.TabIndex = 14;
        PokedexesCaptionLabel.Text = "ポケモン図鑑";
        PokedexesCaptionLabel.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // PokedexesDataGridView
        // 
        PokedexesDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        PokedexesDataGridView.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn2, dataGridViewButtonColumn2 });
        PokedexesDataGridView.Location = new Point(321, 346);
        PokedexesDataGridView.Margin = new Padding(4, 3, 4, 3);
        PokedexesDataGridView.Name = "PokedexesDataGridView";
        PokedexesDataGridView.RowHeadersVisible = false;
        PokedexesDataGridView.Size = new Size(278, 170);
        PokedexesDataGridView.TabIndex = 15;
        PokedexesDataGridView.CellClick += PokedexesDataGridView_CellClick;
        PokedexesDataGridView.CellDoubleClick += PokedexesDataGridView_CellDoubleClick;
        // 
        // dataGridViewTextBoxColumn2
        // 
        dataGridViewTextBoxColumn2.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
        dataGridViewTextBoxColumn2.DataPropertyName = "Name";
        dataGridViewTextBoxColumn2.HeaderText = "ポケモン図鑑";
        dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
        dataGridViewTextBoxColumn2.ReadOnly = true;
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
        // RegionsCaptionLabel
        // 
        RegionsCaptionLabel.AutoSize = true;
        RegionsCaptionLabel.Location = new Point(321, 133);
        RegionsCaptionLabel.Margin = new Padding(4, 0, 4, 0);
        RegionsCaptionLabel.Name = "RegionsCaptionLabel";
        RegionsCaptionLabel.Size = new Size(34, 17);
        RegionsCaptionLabel.TabIndex = 10;
        RegionsCaptionLabel.Text = "地域";
        RegionsCaptionLabel.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // RegionsDataGridView
        // 
        RegionsDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        RegionsDataGridView.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn3, dataGridViewButtonColumn3 });
        RegionsDataGridView.Location = new Point(321, 153);
        RegionsDataGridView.Margin = new Padding(4, 3, 4, 3);
        RegionsDataGridView.Name = "RegionsDataGridView";
        RegionsDataGridView.RowHeadersVisible = false;
        RegionsDataGridView.Size = new Size(278, 170);
        RegionsDataGridView.TabIndex = 11;
        RegionsDataGridView.CellClick += RegionsDataGridView_CellClick;
        RegionsDataGridView.CellDoubleClick += RegionsDataGridView_CellDoubleClick;
        // 
        // dataGridViewTextBoxColumn3
        // 
        dataGridViewTextBoxColumn3.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
        dataGridViewTextBoxColumn3.DataPropertyName = "Name";
        dataGridViewTextBoxColumn3.HeaderText = "地域";
        dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
        dataGridViewTextBoxColumn3.ReadOnly = true;
        dataGridViewTextBoxColumn3.Width = 59;
        // 
        // dataGridViewButtonColumn3
        // 
        dataGridViewButtonColumn3.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
        dataGridViewButtonColumn3.HeaderText = "詳細";
        dataGridViewButtonColumn3.Name = "dataGridViewButtonColumn3";
        dataGridViewButtonColumn3.Text = "詳細";
        dataGridViewButtonColumn3.UseColumnTextForButtonValue = true;
        dataGridViewButtonColumn3.Width = 40;
        // 
        // VersionsCaptionLabel
        // 
        VersionsCaptionLabel.AutoSize = true;
        VersionsCaptionLabel.Location = new Point(15, 326);
        VersionsCaptionLabel.Margin = new Padding(4, 0, 4, 0);
        VersionsCaptionLabel.Name = "VersionsCaptionLabel";
        VersionsCaptionLabel.Size = new Size(60, 17);
        VersionsCaptionLabel.TabIndex = 12;
        VersionsCaptionLabel.Text = "バージョン";
        VersionsCaptionLabel.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // VersionsDataGridView
        // 
        VersionsDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        VersionsDataGridView.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn4, dataGridViewButtonColumn4 });
        VersionsDataGridView.Location = new Point(15, 346);
        VersionsDataGridView.Margin = new Padding(4, 3, 4, 3);
        VersionsDataGridView.Name = "VersionsDataGridView";
        VersionsDataGridView.RowHeadersVisible = false;
        VersionsDataGridView.Size = new Size(298, 170);
        VersionsDataGridView.TabIndex = 13;
        VersionsDataGridView.CellClick += VersionsDataGridView_CellClick;
        VersionsDataGridView.CellDoubleClick += VersionsDataGridView_CellDoubleClick;
        // 
        // dataGridViewTextBoxColumn4
        // 
        dataGridViewTextBoxColumn4.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
        dataGridViewTextBoxColumn4.DataPropertyName = "Name";
        dataGridViewTextBoxColumn4.HeaderText = "バージョン";
        dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
        dataGridViewTextBoxColumn4.ReadOnly = true;
        dataGridViewTextBoxColumn4.Width = 85;
        // 
        // dataGridViewButtonColumn4
        // 
        dataGridViewButtonColumn4.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
        dataGridViewButtonColumn4.HeaderText = "詳細";
        dataGridViewButtonColumn4.Name = "dataGridViewButtonColumn4";
        dataGridViewButtonColumn4.Text = "詳細";
        dataGridViewButtonColumn4.UseColumnTextForButtonValue = true;
        dataGridViewButtonColumn4.Width = 40;
        // 
        // CloseButton
        // 
        CloseButton.Location = new Point(523, 522);
        CloseButton.Margin = new Padding(4, 3, 4, 3);
        CloseButton.Name = "CloseButton";
        CloseButton.Size = new Size(76, 35);
        CloseButton.TabIndex = 17;
        CloseButton.Text = "閉じる";
        CloseButton.UseVisualStyleBackColor = true;
        CloseButton.Click += CloseButton_Click;
        // 
        // NameTextBox
        // 
        NameTextBox.Location = new Point(165, 37);
        NameTextBox.Margin = new Padding(4, 3, 4, 3);
        NameTextBox.Name = "NameTextBox";
        NameTextBox.ReadOnly = true;
        NameTextBox.Size = new Size(275, 24);
        NameTextBox.TabIndex = 3;
        // 
        // IdTextBox
        // 
        IdTextBox.Location = new Point(165, 7);
        IdTextBox.Margin = new Padding(4, 3, 4, 3);
        IdTextBox.Name = "IdTextBox";
        IdTextBox.ReadOnly = true;
        IdTextBox.Size = new Size(275, 24);
        IdTextBox.TabIndex = 1;
        // 
        // OrderTextBox
        // 
        OrderTextBox.Location = new Point(165, 67);
        OrderTextBox.Margin = new Padding(4, 3, 4, 3);
        OrderTextBox.Name = "OrderTextBox";
        OrderTextBox.ReadOnly = true;
        OrderTextBox.Size = new Size(275, 24);
        OrderTextBox.TabIndex = 5;
        // 
        // GenerationTextBox
        // 
        GenerationTextBox.Location = new Point(165, 97);
        GenerationTextBox.Margin = new Padding(4, 3, 4, 3);
        GenerationTextBox.Name = "GenerationTextBox";
        GenerationTextBox.ReadOnly = true;
        GenerationTextBox.Size = new Size(275, 24);
        GenerationTextBox.TabIndex = 7;
        // 
        // PropertyButton
        // 
        PropertyButton.Location = new Point(439, 522);
        PropertyButton.Margin = new Padding(4, 3, 4, 3);
        PropertyButton.Name = "PropertyButton";
        PropertyButton.Size = new Size(76, 35);
        PropertyButton.TabIndex = 16;
        PropertyButton.Text = "プロパティ";
        PropertyButton.UseVisualStyleBackColor = true;
        PropertyButton.Click += PropertyButton_Click;
        // 
        // VersionGroupInfoForm
        // 
        AutoScaleDimensions = new SizeF(9F, 17F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(628, 569);
        Controls.Add(PropertyButton);
        Controls.Add(GenerationTextBox);
        Controls.Add(OrderTextBox);
        Controls.Add(NameTextBox);
        Controls.Add(IdTextBox);
        Controls.Add(CloseButton);
        Controls.Add(VersionsDataGridView);
        Controls.Add(VersionsCaptionLabel);
        Controls.Add(RegionsDataGridView);
        Controls.Add(RegionsCaptionLabel);
        Controls.Add(PokedexesDataGridView);
        Controls.Add(PokedexesCaptionLabel);
        Controls.Add(MoveLearnMethodsCaptionLabel);
        Controls.Add(MoveLearnMethodsDataGridView);
        Controls.Add(GenerationButton);
        Controls.Add(OrderCaptionLabel);
        Controls.Add(NameCaptionLabel);
        Controls.Add(IdCaptionLabel);
        Font = new Font("Meiryo UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 128);
        FormBorderStyle = FormBorderStyle.FixedSingle;
        Margin = new Padding(4, 3, 4, 3);
        MaximizeBox = false;
        Name = "VersionGroupInfoForm";
        StartPosition = FormStartPosition.CenterParent;
        Text = "バージョングループ";
        ((System.ComponentModel.ISupportInitialize)MoveLearnMethodsDataGridView).EndInit();
        ((System.ComponentModel.ISupportInitialize)PokedexesDataGridView).EndInit();
        ((System.ComponentModel.ISupportInitialize)RegionsDataGridView).EndInit();
        ((System.ComponentModel.ISupportInitialize)VersionsDataGridView).EndInit();
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion
    private Label NameCaptionLabel;
    private Label IdCaptionLabel;
    private Label OrderCaptionLabel;
    private Button GenerationButton;
    private DataGridView MoveLearnMethodsDataGridView;
    private Label MoveLearnMethodsCaptionLabel;
    private Label PokedexesCaptionLabel;
    private DataGridView PokedexesDataGridView;
    private Label RegionsCaptionLabel;
    private DataGridView RegionsDataGridView;
    private Label VersionsCaptionLabel;
    private DataGridView VersionsDataGridView;
    private Button CloseButton;
    private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
    private DataGridViewButtonColumn dataGridViewButtonColumn1;
    private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
    private DataGridViewButtonColumn dataGridViewButtonColumn2;
    private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
    private DataGridViewButtonColumn dataGridViewButtonColumn3;
    private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
    private DataGridViewButtonColumn dataGridViewButtonColumn4;
    private TextBox NameTextBox;
    private TextBox IdTextBox;
    private TextBox OrderTextBox;
    private TextBox GenerationTextBox;
    private Button PropertyButton;
}