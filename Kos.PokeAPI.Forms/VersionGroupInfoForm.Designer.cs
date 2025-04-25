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
        NameLabel = new Label();
        NameCaptionLabel = new Label();
        IdLabel = new Label();
        IdCaptionLabel = new Label();
        OrderCaptionLabel = new Label();
        OrderLabel = new Label();
        GenerationLabel = new Label();
        GenerationCaptionLabel = new Label();
        GenerationInfoButton = new Button();
        MoveLearnMethodsDataGridView = new DataGridView();
        dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
        dataGridViewButtonColumn1 = new DataGridViewButtonColumn();
        MoveLarnMethodsCaptionLabel = new Label();
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
        ((System.ComponentModel.ISupportInitialize)MoveLearnMethodsDataGridView).BeginInit();
        ((System.ComponentModel.ISupportInitialize)PokedexesDataGridView).BeginInit();
        ((System.ComponentModel.ISupportInitialize)RegionsDataGridView).BeginInit();
        ((System.ComponentModel.ISupportInitialize)VersionsDataGridView).BeginInit();
        SuspendLayout();
        // 
        // NameLabel
        // 
        NameLabel.BorderStyle = BorderStyle.Fixed3D;
        NameLabel.Location = new Point(153, 31);
        NameLabel.Name = "NameLabel";
        NameLabel.Size = new Size(226, 23);
        NameLabel.TabIndex = 3;
        NameLabel.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // NameCaptionLabel
        // 
        NameCaptionLabel.Location = new Point(12, 32);
        NameCaptionLabel.Name = "NameCaptionLabel";
        NameCaptionLabel.Size = new Size(135, 23);
        NameCaptionLabel.TabIndex = 2;
        NameCaptionLabel.Text = "name";
        NameCaptionLabel.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // IdLabel
        // 
        IdLabel.BorderStyle = BorderStyle.Fixed3D;
        IdLabel.Location = new Point(153, 8);
        IdLabel.Name = "IdLabel";
        IdLabel.Size = new Size(226, 23);
        IdLabel.TabIndex = 1;
        IdLabel.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // IdCaptionLabel
        // 
        IdCaptionLabel.Location = new Point(12, 9);
        IdCaptionLabel.Name = "IdCaptionLabel";
        IdCaptionLabel.Size = new Size(135, 23);
        IdCaptionLabel.TabIndex = 0;
        IdCaptionLabel.Text = "id";
        IdCaptionLabel.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // OrderCaptionLabel
        // 
        OrderCaptionLabel.Location = new Point(12, 57);
        OrderCaptionLabel.Name = "OrderCaptionLabel";
        OrderCaptionLabel.Size = new Size(135, 23);
        OrderCaptionLabel.TabIndex = 4;
        OrderCaptionLabel.Text = "order";
        OrderCaptionLabel.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // OrderLabel
        // 
        OrderLabel.BorderStyle = BorderStyle.Fixed3D;
        OrderLabel.Location = new Point(153, 54);
        OrderLabel.Name = "OrderLabel";
        OrderLabel.Size = new Size(226, 26);
        OrderLabel.TabIndex = 5;
        OrderLabel.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // GenerationLabel
        // 
        GenerationLabel.BorderStyle = BorderStyle.Fixed3D;
        GenerationLabel.Location = new Point(153, 80);
        GenerationLabel.Name = "GenerationLabel";
        GenerationLabel.Size = new Size(226, 26);
        GenerationLabel.TabIndex = 7;
        GenerationLabel.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // GenerationCaptionLabel
        // 
        GenerationCaptionLabel.Location = new Point(12, 82);
        GenerationCaptionLabel.Name = "GenerationCaptionLabel";
        GenerationCaptionLabel.Size = new Size(135, 23);
        GenerationCaptionLabel.TabIndex = 6;
        GenerationCaptionLabel.Text = "generation";
        GenerationCaptionLabel.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // GenerationInfoButton
        // 
        GenerationInfoButton.Location = new Point(385, 82);
        GenerationInfoButton.Name = "GenerationInfoButton";
        GenerationInfoButton.Size = new Size(43, 23);
        GenerationInfoButton.TabIndex = 8;
        GenerationInfoButton.Text = "Info...";
        GenerationInfoButton.UseVisualStyleBackColor = true;
        GenerationInfoButton.Click += GenerationInfoButton_Click;
        // 
        // MoveLearnMethodsDataGridView
        // 
        MoveLearnMethodsDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        MoveLearnMethodsDataGridView.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1, dataGridViewButtonColumn1 });
        MoveLearnMethodsDataGridView.Location = new Point(12, 135);
        MoveLearnMethodsDataGridView.Name = "MoveLearnMethodsDataGridView";
        MoveLearnMethodsDataGridView.RowHeadersVisible = false;
        MoveLearnMethodsDataGridView.Size = new Size(434, 150);
        MoveLearnMethodsDataGridView.TabIndex = 10;
        MoveLearnMethodsDataGridView.CellClick += MoveLearnMethodsDataGridView_CellClick;
        MoveLearnMethodsDataGridView.CellDoubleClick += MoveLearnMethodsDataGridView_CellDoubleClick;
        // 
        // dataGridViewTextBoxColumn1
        // 
        dataGridViewTextBoxColumn1.DataPropertyName = "Name";
        dataGridViewTextBoxColumn1.HeaderText = "name";
        dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
        dataGridViewTextBoxColumn1.ReadOnly = true;
        // 
        // dataGridViewButtonColumn1
        // 
        dataGridViewButtonColumn1.HeaderText = "Info";
        dataGridViewButtonColumn1.Name = "dataGridViewButtonColumn1";
        dataGridViewButtonColumn1.Text = "Info..";
        dataGridViewButtonColumn1.UseColumnTextForButtonValue = true;
        // 
        // MoveLarnMethodsCaptionLabel
        // 
        MoveLarnMethodsCaptionLabel.Location = new Point(12, 109);
        MoveLarnMethodsCaptionLabel.Name = "MoveLarnMethodsCaptionLabel";
        MoveLarnMethodsCaptionLabel.Size = new Size(135, 23);
        MoveLarnMethodsCaptionLabel.TabIndex = 9;
        MoveLarnMethodsCaptionLabel.Text = "move_learn_methods";
        MoveLarnMethodsCaptionLabel.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // PokedexesCaptionLabel
        // 
        PokedexesCaptionLabel.Location = new Point(452, 109);
        PokedexesCaptionLabel.Name = "PokedexesCaptionLabel";
        PokedexesCaptionLabel.Size = new Size(135, 23);
        PokedexesCaptionLabel.TabIndex = 11;
        PokedexesCaptionLabel.Text = "pokedexes";
        PokedexesCaptionLabel.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // PokedexesDataGridView
        // 
        PokedexesDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        PokedexesDataGridView.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn2, dataGridViewButtonColumn2 });
        PokedexesDataGridView.Location = new Point(452, 135);
        PokedexesDataGridView.Name = "PokedexesDataGridView";
        PokedexesDataGridView.RowHeadersVisible = false;
        PokedexesDataGridView.Size = new Size(434, 150);
        PokedexesDataGridView.TabIndex = 12;
        PokedexesDataGridView.CellClick += PokedexesDataGridView_CellClick;
        PokedexesDataGridView.CellDoubleClick += PokedexesDataGridView_CellDoubleClick;
        // 
        // dataGridViewTextBoxColumn2
        // 
        dataGridViewTextBoxColumn2.DataPropertyName = "Name";
        dataGridViewTextBoxColumn2.HeaderText = "name";
        dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
        dataGridViewTextBoxColumn2.ReadOnly = true;
        // 
        // dataGridViewButtonColumn2
        // 
        dataGridViewButtonColumn2.HeaderText = "Info";
        dataGridViewButtonColumn2.Name = "dataGridViewButtonColumn2";
        dataGridViewButtonColumn2.Text = "Info..";
        dataGridViewButtonColumn2.UseColumnTextForButtonValue = true;
        // 
        // RegionsCaptionLabel
        // 
        RegionsCaptionLabel.Location = new Point(12, 288);
        RegionsCaptionLabel.Name = "RegionsCaptionLabel";
        RegionsCaptionLabel.Size = new Size(135, 23);
        RegionsCaptionLabel.TabIndex = 13;
        RegionsCaptionLabel.Text = "regions";
        RegionsCaptionLabel.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // RegionsDataGridView
        // 
        RegionsDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        RegionsDataGridView.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn3, dataGridViewButtonColumn3 });
        RegionsDataGridView.Location = new Point(12, 314);
        RegionsDataGridView.Name = "RegionsDataGridView";
        RegionsDataGridView.RowHeadersVisible = false;
        RegionsDataGridView.Size = new Size(434, 150);
        RegionsDataGridView.TabIndex = 14;
        // 
        // dataGridViewTextBoxColumn3
        // 
        dataGridViewTextBoxColumn3.DataPropertyName = "Name";
        dataGridViewTextBoxColumn3.HeaderText = "name";
        dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
        dataGridViewTextBoxColumn3.ReadOnly = true;
        // 
        // dataGridViewButtonColumn3
        // 
        dataGridViewButtonColumn3.HeaderText = "Info";
        dataGridViewButtonColumn3.Name = "dataGridViewButtonColumn3";
        dataGridViewButtonColumn3.Text = "Info..";
        dataGridViewButtonColumn3.UseColumnTextForButtonValue = true;
        // 
        // VersionsCaptionLabel
        // 
        VersionsCaptionLabel.Location = new Point(452, 288);
        VersionsCaptionLabel.Name = "VersionsCaptionLabel";
        VersionsCaptionLabel.Size = new Size(135, 23);
        VersionsCaptionLabel.TabIndex = 15;
        VersionsCaptionLabel.Text = "versions";
        VersionsCaptionLabel.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // VersionsDataGridView
        // 
        VersionsDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        VersionsDataGridView.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn4, dataGridViewButtonColumn4 });
        VersionsDataGridView.Location = new Point(453, 314);
        VersionsDataGridView.Name = "VersionsDataGridView";
        VersionsDataGridView.RowHeadersVisible = false;
        VersionsDataGridView.Size = new Size(434, 150);
        VersionsDataGridView.TabIndex = 16;
        VersionsDataGridView.CellClick += VersionsDataGridView_CellClick;
        VersionsDataGridView.CellDoubleClick += VersionsDataGridView_CellDoubleClick;
        // 
        // dataGridViewTextBoxColumn4
        // 
        dataGridViewTextBoxColumn4.DataPropertyName = "Name";
        dataGridViewTextBoxColumn4.HeaderText = "name";
        dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
        dataGridViewTextBoxColumn4.ReadOnly = true;
        // 
        // dataGridViewButtonColumn4
        // 
        dataGridViewButtonColumn4.HeaderText = "Info";
        dataGridViewButtonColumn4.Name = "dataGridViewButtonColumn4";
        dataGridViewButtonColumn4.Text = "Info..";
        dataGridViewButtonColumn4.UseColumnTextForButtonValue = true;
        // 
        // CloseButton
        // 
        CloseButton.Location = new Point(811, 470);
        CloseButton.Name = "CloseButton";
        CloseButton.Size = new Size(75, 23);
        CloseButton.TabIndex = 17;
        CloseButton.Text = "Close";
        CloseButton.UseVisualStyleBackColor = true;
        CloseButton.Click += CloseButton_Click;
        // 
        // VersionGroupInfoForm
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(899, 502);
        Controls.Add(CloseButton);
        Controls.Add(VersionsDataGridView);
        Controls.Add(VersionsCaptionLabel);
        Controls.Add(RegionsDataGridView);
        Controls.Add(RegionsCaptionLabel);
        Controls.Add(PokedexesDataGridView);
        Controls.Add(PokedexesCaptionLabel);
        Controls.Add(MoveLarnMethodsCaptionLabel);
        Controls.Add(MoveLearnMethodsDataGridView);
        Controls.Add(GenerationInfoButton);
        Controls.Add(GenerationCaptionLabel);
        Controls.Add(GenerationLabel);
        Controls.Add(OrderLabel);
        Controls.Add(OrderCaptionLabel);
        Controls.Add(NameLabel);
        Controls.Add(NameCaptionLabel);
        Controls.Add(IdLabel);
        Controls.Add(IdCaptionLabel);
        Name = "VersionGroupInfoForm";
        Text = "VersionGroupInfoForm";
        ((System.ComponentModel.ISupportInitialize)MoveLearnMethodsDataGridView).EndInit();
        ((System.ComponentModel.ISupportInitialize)PokedexesDataGridView).EndInit();
        ((System.ComponentModel.ISupportInitialize)RegionsDataGridView).EndInit();
        ((System.ComponentModel.ISupportInitialize)VersionsDataGridView).EndInit();
        ResumeLayout(false);
    }

    #endregion

    private Label NameLabel;
    private Label NameCaptionLabel;
    private Label IdLabel;
    private Label IdCaptionLabel;
    private Label OrderCaptionLabel;
    private Label OrderLabel;
    private Label GenerationLabel;
    private Label GenerationCaptionLabel;
    private Button GenerationInfoButton;
    private DataGridView MoveLearnMethodsDataGridView;
    private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
    private DataGridViewButtonColumn dataGridViewButtonColumn1;
    private Label MoveLarnMethodsCaptionLabel;
    private Label PokedexesCaptionLabel;
    private DataGridView PokedexesDataGridView;
    private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
    private DataGridViewButtonColumn dataGridViewButtonColumn2;
    private Label RegionsCaptionLabel;
    private DataGridView RegionsDataGridView;
    private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
    private DataGridViewButtonColumn dataGridViewButtonColumn3;
    private Label VersionsCaptionLabel;
    private DataGridView VersionsDataGridView;
    private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
    private DataGridViewButtonColumn dataGridViewButtonColumn4;
    private Button CloseButton;
}