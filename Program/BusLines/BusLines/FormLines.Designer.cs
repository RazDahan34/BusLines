namespace BusLines
{
    partial class FormLines
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
            if (disposing && (components != null))
            {
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
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lineIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lineNumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lineCompanyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lineFromStationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lineToStationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lineNumStationsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lineMinutesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblLinesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetLines = new BusLines.DataSetLines();
            this.tblLinesTableAdapter = new BusLines.DataSetLinesTableAdapters.tblLinesTableAdapter();
            this.saveButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblLinesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetLines)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.lineIDDataGridViewTextBoxColumn,
            this.lineNumDataGridViewTextBoxColumn,
            this.lineCompanyDataGridViewTextBoxColumn,
            this.lineFromStationDataGridViewTextBoxColumn,
            this.lineToStationDataGridViewTextBoxColumn,
            this.lineNumStationsDataGridViewTextBoxColumn,
            this.lineMinutesDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tblLinesBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(59, 76);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(760, 218);
            this.dataGridView1.TabIndex = 0;
            // 
            // lineIDDataGridViewTextBoxColumn
            // 
            this.lineIDDataGridViewTextBoxColumn.DataPropertyName = "lineID";
            this.lineIDDataGridViewTextBoxColumn.HeaderText = "מספר מזהה קו";
            this.lineIDDataGridViewTextBoxColumn.Name = "lineIDDataGridViewTextBoxColumn";
            // 
            // lineNumDataGridViewTextBoxColumn
            // 
            this.lineNumDataGridViewTextBoxColumn.DataPropertyName = "lineNum";
            this.lineNumDataGridViewTextBoxColumn.HeaderText = "מספר קו";
            this.lineNumDataGridViewTextBoxColumn.Name = "lineNumDataGridViewTextBoxColumn";
            // 
            // lineCompanyDataGridViewTextBoxColumn
            // 
            this.lineCompanyDataGridViewTextBoxColumn.DataPropertyName = "lineCompany";
            this.lineCompanyDataGridViewTextBoxColumn.HeaderText = "חברה";
            this.lineCompanyDataGridViewTextBoxColumn.Name = "lineCompanyDataGridViewTextBoxColumn";
            // 
            // lineFromStationDataGridViewTextBoxColumn
            // 
            this.lineFromStationDataGridViewTextBoxColumn.DataPropertyName = "lineFromStation";
            this.lineFromStationDataGridViewTextBoxColumn.HeaderText = "תחנת מקור";
            this.lineFromStationDataGridViewTextBoxColumn.Name = "lineFromStationDataGridViewTextBoxColumn";
            // 
            // lineToStationDataGridViewTextBoxColumn
            // 
            this.lineToStationDataGridViewTextBoxColumn.DataPropertyName = "lineToStation";
            this.lineToStationDataGridViewTextBoxColumn.HeaderText = "תחנת יעד";
            this.lineToStationDataGridViewTextBoxColumn.Name = "lineToStationDataGridViewTextBoxColumn";
            // 
            // lineNumStationsDataGridViewTextBoxColumn
            // 
            this.lineNumStationsDataGridViewTextBoxColumn.DataPropertyName = "lineNumStations";
            this.lineNumStationsDataGridViewTextBoxColumn.HeaderText = "מספר תחנות בקו";
            this.lineNumStationsDataGridViewTextBoxColumn.Name = "lineNumStationsDataGridViewTextBoxColumn";
            // 
            // lineMinutesDataGridViewTextBoxColumn
            // 
            this.lineMinutesDataGridViewTextBoxColumn.DataPropertyName = "lineMinutes";
            this.lineMinutesDataGridViewTextBoxColumn.HeaderText = "זמן נסיע בדקות";
            this.lineMinutesDataGridViewTextBoxColumn.Name = "lineMinutesDataGridViewTextBoxColumn";
            // 
            // tblLinesBindingSource
            // 
            this.tblLinesBindingSource.DataMember = "tblLines";
            this.tblLinesBindingSource.DataSource = this.dataSetLines;
            // 
            // dataSetLines
            // 
            this.dataSetLines.DataSetName = "DataSetLines";
            this.dataSetLines.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblLinesTableAdapter
            // 
            this.tblLinesTableAdapter.ClearBeforeFill = true;
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(337, 323);
            this.saveButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(215, 56);
            this.saveButton.TabIndex = 1;
            this.saveButton.Text = "שמור";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.SaveButtonClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label2.Location = new System.Drawing.Point(365, 21);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(157, 32);
            this.label2.TabIndex = 3;
            this.label2.Text = "טבלת קווים";
            // 
            // FormLines
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(876, 411);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.dataGridView1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FormLines";
            this.Text = "FormLines";
            this.Load += new System.EventHandler(this.FormLines_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblLinesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetLines)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private DataSetLines dataSetLines;
        private System.Windows.Forms.BindingSource tblLinesBindingSource;
        private DataSetLinesTableAdapters.tblLinesTableAdapter tblLinesTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn lineIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lineNumDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lineCompanyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lineFromStationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lineToStationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lineNumStationsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lineMinutesDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Label label2;
    }
}