namespace BusLines
{
    partial class FormAddTimes
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.timeLineID = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.timeLineIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timeHourDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timeMinuteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblTimesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetTimes = new BusLines.DataSetTimes();
            this.tblTimesTableAdapter = new BusLines.DataSetTimesTableAdapters.tblTimesTableAdapter();
            this.timeHour = new System.Windows.Forms.ComboBox();
            this.timeMinute = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblTimesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetTimes)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label2.Location = new System.Drawing.Point(284, 28);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(302, 32);
            this.label2.TabIndex = 4;
            this.label2.Text = "הוספת זמן יציאה של קו";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(746, 108);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "מספר מזהה קו";
            // 
            // timeLineID
            // 
            this.timeLineID.FormattingEnabled = true;
            this.timeLineID.Location = new System.Drawing.Point(586, 101);
            this.timeLineID.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.timeLineID.Name = "timeLineID";
            this.timeLineID.Size = new System.Drawing.Size(136, 28);
            this.timeLineID.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(529, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "שעה";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(299, 108);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "דקה";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(203, 169);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(519, 49);
            this.button1.TabIndex = 11;
            this.button1.Text = "הוסף";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.AddButtonClick);
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
            this.dataGridView1.Location = new System.Drawing.Point(30, 253);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(817, 249);
            this.dataGridView1.TabIndex = 12;
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
            // timeHour
            // 
            this.timeHour.FormattingEnabled = true;
            this.timeHour.Location = new System.Drawing.Point(368, 101);
            this.timeHour.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.timeHour.Name = "timeHour";
            this.timeHour.Size = new System.Drawing.Size(136, 28);
            this.timeHour.TabIndex = 13;
            // 
            // timeMinute
            // 
            this.timeMinute.FormattingEnabled = true;
            this.timeMinute.Location = new System.Drawing.Point(135, 101);
            this.timeMinute.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.timeMinute.Name = "timeMinute";
            this.timeMinute.Size = new System.Drawing.Size(136, 28);
            this.timeMinute.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label5.Location = new System.Drawing.Point(732, 229);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(115, 20);
            this.label5.TabIndex = 15;
            this.label5.Text = "טבלת לוח זמנים";
            // 
            // FormAddTimes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.ClientSize = new System.Drawing.Size(886, 532);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.timeMinute);
            this.Controls.Add(this.timeHour);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.timeLineID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FormAddTimes";
            this.Text = "FormAddTimes";
            this.Load += new System.EventHandler(this.FormAddTimes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblTimesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetTimes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox timeLineID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private DataSetTimes dataSetTimes;
        private System.Windows.Forms.BindingSource tblTimesBindingSource;
        private DataSetTimesTableAdapters.tblTimesTableAdapter tblTimesTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn timeLineIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn timeHourDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn timeMinuteDataGridViewTextBoxColumn;
        private System.Windows.Forms.ComboBox timeHour;
        private System.Windows.Forms.ComboBox timeMinute;
        private System.Windows.Forms.Label label5;
    }
}