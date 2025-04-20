namespace Kos.PokeAPI.Forms;

partial class ContestEffectInfoForm
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
        AppealLabel = new Label();
        AppealCaptionLabel = new Label();
        IdLabel = new Label();
        IdCaptionLabel = new Label();
        JamLabel = new Label();
        JamCaptionLabel = new Label();
        EffectEntriesDataGridView = new DataGridView();
        EffectColumn = new DataGridViewTextBoxColumn();
        EffectLanguageColumn = new DataGridViewTextBoxColumn();
        EffectLanguageInfoButtonColumn = new DataGridViewButtonColumn();
        EffectEntriesCaptionLabel = new Label();
        FlavorTextEntriesDataGridView = new DataGridView();
        FlavorTextColumn = new DataGridViewTextBoxColumn();
        FlavorTextLanguageColumn = new DataGridViewTextBoxColumn();
        FlavorVersionColumn = new DataGridViewTextBoxColumn();
        FlavorTextLanguageInfoButtonColumn = new DataGridViewButtonColumn();
        FlavorTextVersionInfoButtonColumn = new DataGridViewButtonColumn();
        CloseButton = new Button();
        FlavorTextEntriesCaptionLabel = new Label();
        ((System.ComponentModel.ISupportInitialize)EffectEntriesDataGridView).BeginInit();
        ((System.ComponentModel.ISupportInitialize)FlavorTextEntriesDataGridView).BeginInit();
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
        // JamLabel
        // 
        JamLabel.BorderStyle = BorderStyle.Fixed3D;
        JamLabel.Location = new Point(133, 55);
        JamLabel.Name = "JamLabel";
        JamLabel.Size = new Size(147, 23);
        JamLabel.TabIndex = 5;
        JamLabel.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // JamCaptionLabel
        // 
        JamCaptionLabel.Location = new Point(12, 55);
        JamCaptionLabel.Name = "JamCaptionLabel";
        JamCaptionLabel.Size = new Size(115, 23);
        JamCaptionLabel.TabIndex = 4;
        JamCaptionLabel.Text = "jam";
        JamCaptionLabel.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // EffectEntriesDataGridView
        // 
        EffectEntriesDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        EffectEntriesDataGridView.Columns.AddRange(new DataGridViewColumn[] { EffectColumn, EffectLanguageColumn, EffectLanguageInfoButtonColumn });
        EffectEntriesDataGridView.Location = new Point(133, 81);
        EffectEntriesDataGridView.Name = "EffectEntriesDataGridView";
        EffectEntriesDataGridView.RowHeadersVisible = false;
        EffectEntriesDataGridView.Size = new Size(672, 150);
        EffectEntriesDataGridView.TabIndex = 7;
        EffectEntriesDataGridView.CellClick += EffectEntriesDataGridView_CellClick;
        EffectEntriesDataGridView.CellDoubleClick += EffectEntriesDataGridView_CellDoubleClick;
        // 
        // EffectColumn
        // 
        EffectColumn.DataPropertyName = "Text";
        EffectColumn.HeaderText = "effect";
        EffectColumn.Name = "EffectColumn";
        EffectColumn.ReadOnly = true;
        EffectColumn.Width = 450;
        // 
        // EffectLanguageColumn
        // 
        EffectLanguageColumn.DataPropertyName = "Language";
        EffectLanguageColumn.HeaderText = "language";
        EffectLanguageColumn.Name = "EffectLanguageColumn";
        EffectLanguageColumn.ReadOnly = true;
        // 
        // EffectLanguageInfoButtonColumn
        // 
        EffectLanguageInfoButtonColumn.HeaderText = "LanguageInfo";
        EffectLanguageInfoButtonColumn.Name = "EffectLanguageInfoButtonColumn";
        EffectLanguageInfoButtonColumn.Text = "Info..";
        EffectLanguageInfoButtonColumn.UseColumnTextForButtonValue = true;
        // 
        // EffectEntriesCaptionLabel
        // 
        EffectEntriesCaptionLabel.Location = new Point(12, 81);
        EffectEntriesCaptionLabel.Name = "EffectEntriesCaptionLabel";
        EffectEntriesCaptionLabel.Size = new Size(115, 23);
        EffectEntriesCaptionLabel.TabIndex = 6;
        EffectEntriesCaptionLabel.Text = "effect_entries";
        EffectEntriesCaptionLabel.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // FlavorTextEntriesDataGridView
        // 
        FlavorTextEntriesDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        FlavorTextEntriesDataGridView.Columns.AddRange(new DataGridViewColumn[] { FlavorTextColumn, FlavorTextLanguageColumn, FlavorVersionColumn, FlavorTextLanguageInfoButtonColumn, FlavorTextVersionInfoButtonColumn });
        FlavorTextEntriesDataGridView.Location = new Point(133, 237);
        FlavorTextEntriesDataGridView.Name = "FlavorTextEntriesDataGridView";
        FlavorTextEntriesDataGridView.RowHeadersVisible = false;
        FlavorTextEntriesDataGridView.Size = new Size(672, 150);
        FlavorTextEntriesDataGridView.TabIndex = 9;
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
        // CloseButton
        // 
        CloseButton.Location = new Point(736, 393);
        CloseButton.Name = "CloseButton";
        CloseButton.Size = new Size(75, 23);
        CloseButton.TabIndex = 10;
        CloseButton.Text = "Close";
        CloseButton.UseVisualStyleBackColor = true;
        CloseButton.Click += CloseButton_Click;
        // 
        // FlavorTextEntriesCaptionLabel
        // 
        FlavorTextEntriesCaptionLabel.Location = new Point(12, 237);
        FlavorTextEntriesCaptionLabel.Name = "FlavorTextEntriesCaptionLabel";
        FlavorTextEntriesCaptionLabel.Size = new Size(115, 23);
        FlavorTextEntriesCaptionLabel.TabIndex = 8;
        FlavorTextEntriesCaptionLabel.Text = "flavor_text_entries";
        FlavorTextEntriesCaptionLabel.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // ContestEffectInfoForm
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(823, 429);
        Controls.Add(FlavorTextEntriesCaptionLabel);
        Controls.Add(CloseButton);
        Controls.Add(FlavorTextEntriesDataGridView);
        Controls.Add(EffectEntriesCaptionLabel);
        Controls.Add(EffectEntriesDataGridView);
        Controls.Add(JamCaptionLabel);
        Controls.Add(JamLabel);
        Controls.Add(AppealLabel);
        Controls.Add(AppealCaptionLabel);
        Controls.Add(IdLabel);
        Controls.Add(IdCaptionLabel);
        MinimizeBox = false;
        Name = "ContestEffectInfoForm";
        Text = "Contest Effect";
        Load += ContestEffectInfoForm_Load;
        ((System.ComponentModel.ISupportInitialize)EffectEntriesDataGridView).EndInit();
        ((System.ComponentModel.ISupportInitialize)FlavorTextEntriesDataGridView).EndInit();
        ResumeLayout(false);
    }

    #endregion

    private Label AppealLabel;
    private Label AppealCaptionLabel;
    private Label IdLabel;
    private Label IdCaptionLabel;
    private Label JamLabel;
    private Label JamCaptionLabel;
    private DataGridView EffectEntriesDataGridView;
    private Label EffectEntriesCaptionLabel;
    private DataGridView FlavorTextEntriesDataGridView;
    private Button CloseButton;
    private Label FlavorTextEntriesCaptionLabel;
    private DataGridViewTextBoxColumn EffectColumn;
    private DataGridViewTextBoxColumn EffectLanguageColumn;
    private DataGridViewButtonColumn EffectLanguageInfoButtonColumn;
    private DataGridViewTextBoxColumn FlavorTextColumn;
    private DataGridViewTextBoxColumn FlavorTextLanguageColumn;
    private DataGridViewTextBoxColumn FlavorVersionColumn;
    private DataGridViewButtonColumn FlavorTextLanguageInfoButtonColumn;
    private DataGridViewButtonColumn FlavorTextVersionInfoButtonColumn;
}
