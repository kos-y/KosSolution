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
        AppealLabel = new Label();
        AppealCaptionLabel = new Label();
        IdLabel = new Label();
        IdCaptionLabel = new Label();
        FlavorTextEntriesDataGridView = new DataGridView();
        FlavorTextColumn = new DataGridViewTextBoxColumn();
        FlavorTextLanguageColumn = new DataGridViewTextBoxColumn();
        FlavorVersionColumn = new DataGridViewTextBoxColumn();
        FlavorTextLanguageInfoButtonColumn = new DataGridViewButtonColumn();
        FlavorTextVersionInfoButtonColumn = new DataGridViewButtonColumn();
        FlavorTextEntriesCaptionLabel = new Label();
        MovesDataGridView = new DataGridView();
        MovesColumn = new DataGridViewTextBoxColumn();
        MovesInfoColumn = new DataGridViewButtonColumn();
        MovesCaptionLabel = new Label();
        CloseButton = new Button();
        ((System.ComponentModel.ISupportInitialize)FlavorTextEntriesDataGridView).BeginInit();
        ((System.ComponentModel.ISupportInitialize)MovesDataGridView).BeginInit();
        SuspendLayout();
        // 
        // AppealLabel
        // 
        AppealLabel.BorderStyle = BorderStyle.Fixed3D;
        AppealLabel.Location = new Point(133, 32);
        AppealLabel.Name = "AppealLabel";
        AppealLabel.Size = new Size(147, 23);
        AppealLabel.TabIndex = 3;
        AppealLabel.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // AppealCaptionLabel
        // 
        AppealCaptionLabel.Location = new Point(12, 32);
        AppealCaptionLabel.Name = "AppealCaptionLabel";
        AppealCaptionLabel.Size = new Size(115, 23);
        AppealCaptionLabel.TabIndex = 2;
        AppealCaptionLabel.Text = "appeal";
        AppealCaptionLabel.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // IdLabel
        // 
        IdLabel.BorderStyle = BorderStyle.Fixed3D;
        IdLabel.Location = new Point(133, 9);
        IdLabel.Name = "IdLabel";
        IdLabel.Size = new Size(147, 23);
        IdLabel.TabIndex = 1;
        IdLabel.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // IdCaptionLabel
        // 
        IdCaptionLabel.Location = new Point(12, 9);
        IdCaptionLabel.Name = "IdCaptionLabel";
        IdCaptionLabel.Size = new Size(115, 23);
        IdCaptionLabel.TabIndex = 0;
        IdCaptionLabel.Text = "id";
        IdCaptionLabel.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // FlavorTextEntriesDataGridView
        // 
        FlavorTextEntriesDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        FlavorTextEntriesDataGridView.Columns.AddRange(new DataGridViewColumn[] { FlavorTextColumn, FlavorTextLanguageColumn, FlavorVersionColumn, FlavorTextLanguageInfoButtonColumn, FlavorTextVersionInfoButtonColumn });
        FlavorTextEntriesDataGridView.Location = new Point(133, 58);
        FlavorTextEntriesDataGridView.Name = "FlavorTextEntriesDataGridView";
        FlavorTextEntriesDataGridView.RowHeadersVisible = false;
        FlavorTextEntriesDataGridView.Size = new Size(672, 150);
        FlavorTextEntriesDataGridView.TabIndex = 5;
        FlavorTextEntriesDataGridView.CellClick += FlavorTextEntriesDataGridView_CellClick;
        FlavorTextEntriesDataGridView.CellDoubleClick += FlavorTextEntriesDataGridView_CellDoubleClick;
        // 
        // FlavorTextColumn
        // 
        FlavorTextColumn.DataPropertyName = "Text";
        FlavorTextColumn.HeaderText = "flavor_text";
        FlavorTextColumn.Name = "FlavorTextColumn";
        FlavorTextColumn.ReadOnly = true;
        FlavorTextColumn.Width = 250;
        // 
        // FlavorTextLanguageColumn
        // 
        FlavorTextLanguageColumn.DataPropertyName = "Language";
        FlavorTextLanguageColumn.HeaderText = "language";
        FlavorTextLanguageColumn.Name = "FlavorTextLanguageColumn";
        FlavorTextLanguageColumn.ReadOnly = true;
        // 
        // FlavorVersionColumn
        // 
        FlavorVersionColumn.DataPropertyName = "Version";
        FlavorVersionColumn.HeaderText = "version";
        FlavorVersionColumn.Name = "FlavorVersionColumn";
        FlavorVersionColumn.ReadOnly = true;
        // 
        // FlavorTextLanguageInfoButtonColumn
        // 
        FlavorTextLanguageInfoButtonColumn.HeaderText = "LanguageInfo";
        FlavorTextLanguageInfoButtonColumn.Name = "FlavorTextLanguageInfoButtonColumn";
        FlavorTextLanguageInfoButtonColumn.Text = "Info..";
        FlavorTextLanguageInfoButtonColumn.UseColumnTextForButtonValue = true;
        // 
        // FlavorTextVersionInfoButtonColumn
        // 
        FlavorTextVersionInfoButtonColumn.HeaderText = "VersionInfo";
        FlavorTextVersionInfoButtonColumn.Name = "FlavorTextVersionInfoButtonColumn";
        FlavorTextVersionInfoButtonColumn.Text = "Info...";
        FlavorTextVersionInfoButtonColumn.UseColumnTextForButtonValue = true;
        // 
        // FlavorTextEntriesCaptionLabel
        // 
        FlavorTextEntriesCaptionLabel.Location = new Point(12, 58);
        FlavorTextEntriesCaptionLabel.Name = "FlavorTextEntriesCaptionLabel";
        FlavorTextEntriesCaptionLabel.Size = new Size(115, 23);
        FlavorTextEntriesCaptionLabel.TabIndex = 4;
        FlavorTextEntriesCaptionLabel.Text = "flavor_text_entries";
        FlavorTextEntriesCaptionLabel.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // MovesDataGridView
        // 
        MovesDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        MovesDataGridView.Columns.AddRange(new DataGridViewColumn[] { MovesColumn, MovesInfoColumn });
        MovesDataGridView.Location = new Point(133, 214);
        MovesDataGridView.Name = "MovesDataGridView";
        MovesDataGridView.RowHeadersVisible = false;
        MovesDataGridView.Size = new Size(672, 150);
        MovesDataGridView.TabIndex = 7;
        // 
        // MovesColumn
        // 
        MovesColumn.DataPropertyName = "Name";
        MovesColumn.HeaderText = "move";
        MovesColumn.Name = "MovesColumn";
        MovesColumn.ReadOnly = true;
        MovesColumn.Width = 200;
        // 
        // MovesInfoColumn
        // 
        MovesInfoColumn.HeaderText = "Info";
        MovesInfoColumn.Name = "MovesInfoColumn";
        MovesInfoColumn.Text = "Info...";
        MovesInfoColumn.UseColumnTextForButtonValue = true;
        // 
        // MovesCaptionLabel
        // 
        MovesCaptionLabel.Location = new Point(12, 214);
        MovesCaptionLabel.Name = "MovesCaptionLabel";
        MovesCaptionLabel.Size = new Size(115, 23);
        MovesCaptionLabel.TabIndex = 6;
        MovesCaptionLabel.Text = "moves";
        MovesCaptionLabel.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // CloseButton
        // 
        CloseButton.Location = new Point(730, 370);
        CloseButton.Name = "CloseButton";
        CloseButton.Size = new Size(75, 23);
        CloseButton.TabIndex = 8;
        CloseButton.Text = "Close";
        CloseButton.UseVisualStyleBackColor = true;
        CloseButton.Click += CloseButton_Click;
        // 
        // SuperContestEffectInfoForm
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(820, 399);
        Controls.Add(CloseButton);
        Controls.Add(MovesCaptionLabel);
        Controls.Add(MovesDataGridView);
        Controls.Add(FlavorTextEntriesCaptionLabel);
        Controls.Add(FlavorTextEntriesDataGridView);
        Controls.Add(AppealLabel);
        Controls.Add(AppealCaptionLabel);
        Controls.Add(IdLabel);
        Controls.Add(IdCaptionLabel);
        FormBorderStyle = FormBorderStyle.FixedSingle;
        MaximizeBox = false;
        MinimizeBox = false;
        Name = "SuperContestEffectInfoForm";
        Text = "Super Contest Effect";
        Load += SuperContestEffectInfoForm_Load;
        ((System.ComponentModel.ISupportInitialize)FlavorTextEntriesDataGridView).EndInit();
        ((System.ComponentModel.ISupportInitialize)MovesDataGridView).EndInit();
        ResumeLayout(false);
    }

    #endregion

    private Label AppealLabel;
    private Label AppealCaptionLabel;
    private Label IdLabel;
    private Label IdCaptionLabel;
    private DataGridView FlavorTextEntriesDataGridView;
    private DataGridViewTextBoxColumn FlavorTextColumn;
    private DataGridViewTextBoxColumn FlavorTextLanguageColumn;
    private DataGridViewTextBoxColumn FlavorVersionColumn;
    private DataGridViewButtonColumn FlavorTextLanguageInfoButtonColumn;
    private DataGridViewButtonColumn FlavorTextVersionInfoButtonColumn;
    private Label FlavorTextEntriesCaptionLabel;
    private DataGridView MovesDataGridView;
    private Label MovesCaptionLabel;
    private DataGridViewTextBoxColumn MovesColumn;
    private DataGridViewButtonColumn MovesInfoColumn;
    private Button CloseButton;
}