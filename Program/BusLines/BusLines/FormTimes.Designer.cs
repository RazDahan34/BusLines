namespace BusLines
{
    partial class FormTimes
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
            this.timeLineIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timeHourDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timeMinuteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblTimesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetTimes = new BusLines.DataSetTimes();
            this.tblTimesTableAdapter = new BusLines.DataSetTimesTableAdapters.tblTimesTableAdapter();
            this.saveButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblTimesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetTimes)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.timeLineIDDataGridViewTextBoxColumn,
            this.timeHourDataGridViewTextBoxColumn,
            this.timeMinuteDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tblTimesBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(104, 84);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(627, 188);
            this.dataGridView1.TabIndex = 0;
            // 
            // timeLineIDDataGridViewTextBoxColumn
            // 
            this.timeLineIDDataGridViewTextBoxColumn.DataPropertyName = "timeLineID";
            this.timeLineIDDataGridViewTextBoxColumn.HeaderText = "מספר מזהה קו";
            this.timeLineIDDataGridViewTextBoxColumn.Name = "timeLineIDDataGridViewTextBoxColumn";
            // 
            // timeHourDataGridViewTextBoxColumn
            // 
            this.timeHourDataGridViewTextBoxColumn.DataPropertyName = "timeHour";
            this.timeHourDataGridViewTextBoxColumn.HeaderText = "שעה";
            this.timeHourDataGridViewTextBoxColumn.Name = "timeHourDataGridViewTextBoxColumn";
            // 
            // timeMinuteDataGridViewTextBoxColumn
            // 
            this.timeMinuteDataGridViewTextBoxColumn.DataPropertyName = "timeMinute";
            this.timeMinuteDataGridViewTextBoxColumn.HeaderText = "דקה";
            this.timeMinuteDataGridViewTextBoxColumn.Name = "timeMinuteDataGridViewTextBoxColumn";
            // 
            // tblTimesBindingSource
            // 
            this.tblTimesBindingSource.DataMember = "tblTimes";
            this.tblTimesBindingSource.DataSource = this.dataSetTimes;
            // 
            // dataSetTimes
            // 
            this.dataSetTimes.DataSetName = "DataSetTimes";
            this.dataSetTimes.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblTimesTableAdapter
            // 
            this.tblTimesTableAdapter.ClearBeforeFill = true;
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(311, 293);
            this.saveButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(227, 65);
            this.saveButton.TabIndex = 1;
            this.saveButton.Text = "שמור";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButtonClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label2.Location = new System.Drawing.Point(346, 23);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(160, 32);
            this.label2.TabIndex = 3;
            this.label2.Text = "טבלת זמנים";
            // 
            // FormTimes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(815, 386);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.dataGridView1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FormTimes";
            this.Text = "FormTimes";
            this.Load += new System.EventHandler(this.FormTimes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblTimesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetTimes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private DataSetTimes dataSetTimes;
        private System.Windows.Forms.BindingSource tblTimesBindingSource;
        private DataSetTimesTableAdapters.tblTimesTableAdapter tblTimesTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn timeLineIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn timeHourDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn timeMinuteDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Label label2;
    }
}