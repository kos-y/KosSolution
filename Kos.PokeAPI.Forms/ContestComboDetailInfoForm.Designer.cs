namespace Kos.PokeAPI.Forms;

partial class ContestComboDetailInfoForm
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
        UseBeforeDataGridView = new DataGridView();
        dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
        dataGridViewButtonColumn1 = new DataGridViewButtonColumn();
        UseBeforeCaptionLabel = new Label();
        UseAfterDataGridView = new DataGridView();
        dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
        dataGridViewButtonColumn2 = new DataGridViewButtonColumn();
        UseAfterCaptionLabel = new Label();
        CloseButton = new Button();
        ((System.ComponentModel.ISupportInitialize)UseBeforeDataGridView).BeginInit();
        ((System.ComponentModel.ISupportInitialize)UseAfterDataGridView).BeginInit();
        SuspendLayout();
        // 
        // UseBeforeDataGridView
        // 
        UseBeforeDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        UseBeforeDataGridView.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1, dataGridViewButtonColumn1 });
        UseBeforeDataGridView.Location = new Point(13, 29);
        UseBeforeDataGridView.Margin = new Padding(4, 3, 4, 3);
        UseBeforeDataGridView.Name = "UseBeforeDataGridView";
        UseBeforeDataGridView.RowHeadersVisible = false;
        UseBeforeDataGridView.Size = new Size(288, 170);
        UseBeforeDataGridView.TabIndex = 1;
        // 
        // dataGridViewTextBoxColumn1
        // 
        dataGridViewTextBoxColumn1.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
        dataGridViewTextBoxColumn1.DataPropertyName = "Name";
        dataGridViewTextBoxColumn1.HeaderText = "技";
        dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
        dataGridViewTextBoxColumn1.ReadOnly = true;
        dataGridViewTextBoxColumn1.Width = 46;
        // 
        // dataGridViewButtonColumn1
        // 
        dataGridViewButtonColumn1.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
        dataGridViewButtonColumn1.HeaderText = "詳細";
        dataGridViewButtonColumn1.Name = "dataGridViewButtonColumn1";
        dataGridViewButtonColumn1.Text = "syousai ";
        dataGridViewButtonColumn1.UseColumnTextForButtonValue = true;
        dataGridViewButtonColumn1.Width = 40;
        // 
        // UseBeforeCaptionLabel
        // 
        UseBeforeCaptionLabel.AutoSize = true;
        UseBeforeCaptionLabel.Location = new Point(13, 9);
        UseBeforeCaptionLabel.Margin = new Padding(4, 0, 4, 0);
        UseBeforeCaptionLabel.Name = "UseBeforeCaptionLabel";
        UseBeforeCaptionLabel.Size = new Size(92, 17);
        UseBeforeCaptionLabel.TabIndex = 0;
        UseBeforeCaptionLabel.Text = "前に使用する技";
        UseBeforeCaptionLabel.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // UseAfterDataGridView
        // 
        UseAfterDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        UseAfterDataGridView.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn2, dataGridViewButtonColumn2 });
        UseAfterDataGridView.Location = new Point(309, 29);
        UseAfterDataGridView.Margin = new Padding(4, 3, 4, 3);
        UseAfterDataGridView.Name = "UseAfterDataGridView";
        UseAfterDataGridView.RowHeadersVisible = false;
        UseAfterDataGridView.Size = new Size(288, 170);
        UseAfterDataGridView.TabIndex = 3;
        // 
        // dataGridViewTextBoxColumn2
        // 
        dataGridViewTextBoxColumn2.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
        dataGridViewTextBoxColumn2.DataPropertyName = "Name";
        dataGridViewTextBoxColumn2.HeaderText = "技";
        dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
        dataGridViewTextBoxColumn2.ReadOnly = true;
        dataGridViewTextBoxColumn2.Width = 46;
        // 
        // dataGridViewButtonColumn2
        // 
        dataGridViewButtonColumn2.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
        dataGridViewButtonColumn2.HeaderText = "詳細";
        dataGridViewButtonColumn2.Name = "dataGridViewButtonColumn2";
        dataGridViewButtonColumn2.Text = "syousai ";
        dataGridViewButtonColumn2.UseColumnTextForButtonValue = true;
        dataGridViewButtonColumn2.Width = 40;
        // 
        // UseAfterCaptionLabel
        // 
        UseAfterCaptionLabel.AutoSize = true;
        UseAfterCaptionLabel.Location = new Point(309, 9);
        UseAfterCaptionLabel.Margin = new Padding(4, 0, 4, 0);
        UseAfterCaptionLabel.Name = "UseAfterCaptionLabel";
        UseAfterCaptionLabel.Size = new Size(92, 17);
        UseAfterCaptionLabel.TabIndex = 2;
        UseAfterCaptionLabel.Text = "後に使用する技";
        UseAfterCaptionLabel.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // CloseButton
        // 
        CloseButton.Location = new Point(524, 205);
        CloseButton.Margin = new Padding(4, 3, 4, 3);
        CloseButton.Name = "CloseButton";
        CloseButton.Size = new Size(73, 35);
        CloseButton.TabIndex = 4;
        CloseButton.Text = "閉じる";
        CloseButton.UseVisualStyleBackColor = true;
        CloseButton.Click += CloseButton_Click;
        // 
        // ContestComboDetailInfoForm
        // 
        AutoScaleDimensions = new SizeF(9F, 17F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(615, 250);
        Controls.Add(CloseButton);
        Controls.Add(UseAfterDataGridView);
        Controls.Add(UseAfterCaptionLabel);
        Controls.Add(UseBeforeDataGridView);
        Controls.Add(UseBeforeCaptionLabel);
        Font = new Font("Meiryo UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 128);
        FormBorderStyle = FormBorderStyle.FixedSingle;
        Margin = new Padding(4, 3, 4, 3);
        MaximizeBox = false;
        Name = "ContestComboDetailInfoForm";
        StartPosition = FormStartPosition.CenterParent;
        Text = "コンテストのコンボ詳細";
        ((System.ComponentModel.ISupportInitialize)UseBeforeDataGridView).EndInit();
        ((System.ComponentModel.ISupportInitialize)UseAfterDataGridView).EndInit();
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private DataGridView UseBeforeDataGridView;
    private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
    private DataGridViewButtonColumn dataGridViewButtonColumn1;
    private Label UseBeforeCaptionLabel;
    private DataGridView UseAfterDataGridView;
    private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
    private DataGridViewButtonColumn dataGridViewButtonColumn2;
    private Label UseAfterCaptionLabel;
    private Button CloseButton;
}