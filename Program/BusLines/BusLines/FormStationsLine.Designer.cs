namespace BusLines
{
    partial class FormStationsLine
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
            this.lineStationLineIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lineStationNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lineStationIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lineStationMinutesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lineStationKindDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblStationsLineBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetStationsLine = new BusLines.DataSetStationsLine();
            this.tblStationsLineTableAdapter = new BusLines.DataSetStationsLineTableAdapters.tblStationsLineTableAdapter();
            this.saveButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblStationsLineBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetStationsLine)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.lineStationLineIDDataGridViewTextBoxColumn,
            this.lineStationNumberDataGridViewTextBoxColumn,
            this.lineStationIDDataGridViewTextBoxColumn,
            this.lineStationMinutesDataGridViewTextBoxColumn,
            this.lineStationKindDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tblStationsLineBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(82, 86);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(657, 206);
            this.dataGridView1.TabIndex = 0;
            // 
            // lineStationLineIDDataGridViewTextBoxColumn
            // 
            this.lineStationLineIDDataGridViewTextBoxColumn.DataPropertyName = "lineStationLineID";
            this.lineStationLineIDDataGridViewTextBoxColumn.HeaderText = "מספר מזהה קו";
            this.lineStationLineIDDataGridViewTextBoxColumn.Name = "lineStationLineIDDataGridViewTextBoxColumn";
            // 
            // lineStationNumberDataGridViewTextBoxColumn
            // 
            this.lineStationNumberDataGridViewTextBoxColumn.DataPropertyName = "lineStationNumber";
            this.lineStationNumberDataGridViewTextBoxColumn.HeaderText = "מספר סידורי תחנה";
            this.lineStationNumberDataGridViewTextBoxColumn.Name = "lineStationNumberDataGridViewTextBoxColumn";
            // 
            // lineStationIDDataGridViewTextBoxColumn
            // 
            this.lineStationIDDataGridViewTextBoxColumn.DataPropertyName = "lineStationID";
            this.lineStationIDDataGridViewTextBoxColumn.HeaderText = "מספר מזהה תחנה";
            this.lineStationIDDataGridViewTextBoxColumn.Name = "lineStationIDDataGridViewTextBoxColumn";
            // 
            // lineStationMinutesDataGridViewTextBoxColumn
            // 
            this.lineStationMinutesDataGridViewTextBoxColumn.DataPropertyName = "lineStationMinutes";
            this.lineStationMinutesDataGridViewTextBoxColumn.HeaderText = "זמן נסיעה בדקות";
            this.lineStationMinutesDataGridViewTextBoxColumn.Name = "lineStationMinutesDataGridViewTextBoxColumn";
            // 
            // lineStationKindDataGridViewTextBoxColumn
            // 
            this.lineStationKindDataGridViewTextBoxColumn.DataPropertyName = "lineStationKind";
            this.lineStationKindDataGridViewTextBoxColumn.HeaderText = "סוג תחנה";
            this.lineStationKindDataGridViewTextBoxColumn.Name = "lineStationKindDataGridViewTextBoxColumn";
            // 
            // tblStationsLineBindingSource
            // 
            this.tblStationsLineBindingSource.DataMember = "tblStationsLine";
            this.tblStationsLineBindingSource.DataSource = this.dataSetStationsLine;
            // 
            // dataSetStationsLine
            // 
            this.dataSetStationsLine.DataSetName = "DataSetStationsLine";
            this.dataSetStationsLine.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblStationsLineTableAdapter
            // 
            this.tblStationsLineTableAdapter.ClearBeforeFill = true;
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(301, 321);
            this.saveButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(248, 61);
            this.saveButton.TabIndex = 1;
            this.saveButton.Text = "שמור";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.SaveButtonClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label2.Location = new System.Drawing.Point(318, 26);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(219, 32);
            this.label2.TabIndex = 3;
            this.label2.Text = "טבלת תחנות בקו";
            // 
            // FormStationsLine
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(803, 406);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.dataGridView1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FormStationsLine";
            this.Text = "FormStationsLine";
            this.Load += new System.EventHandler(this.FormStationsLine_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblStationsLineBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetStationsLine)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private DataSetStationsLine dataSetStationsLine;
        private System.Windows.Forms.BindingSource tblStationsLineBindingSource;
        private DataSetStationsLineTableAdapters.tblStationsLineTableAdapter tblStationsLineTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn lineStationLineIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lineStationNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lineStationIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lineStationMinutesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lineStationKindDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Label label2;
    }
}