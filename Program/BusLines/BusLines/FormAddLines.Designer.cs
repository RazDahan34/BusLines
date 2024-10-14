namespace BusLines
{
    partial class FormAddLines
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
            this.lineNum = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lineCompany = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lineFromStation = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lineToStation = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.lineNumStations = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.lineMinutes = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
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
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblLinesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetLines)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label2.Location = new System.Drawing.Point(389, 24);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 32);
            this.label2.TabIndex = 3;
            this.label2.Text = "הוספת קו";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(846, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "מספר קו";
            // 
            // lineNum
            // 
            this.lineNum.Location = new System.Drawing.Point(678, 91);
            this.lineNum.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lineNum.Name = "lineNum";
            this.lineNum.Size = new System.Drawing.Size(137, 26);
            this.lineNum.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(590, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "חברה";
            // 
            // lineCompany
            // 
            this.lineCompany.FormattingEnabled = true;
            this.lineCompany.Location = new System.Drawing.Point(412, 88);
            this.lineCompany.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lineCompany.Name = "lineCompany";
            this.lineCompany.Size = new System.Drawing.Size(150, 28);
            this.lineCompany.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(306, 91);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "תחנת מקור";
            // 
            // lineFromStation
            // 
            this.lineFromStation.FormattingEnabled = true;
            this.lineFromStation.Location = new System.Drawing.Point(122, 88);
            this.lineFromStation.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lineFromStation.Name = "lineFromStation";
            this.lineFromStation.Size = new System.Drawing.Size(163, 28);
            this.lineFromStation.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(840, 164);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 20);
            this.label5.TabIndex = 10;
            this.label5.Text = "תחנת יעד";
            // 
            // lineToStation
            // 
            this.lineToStation.FormattingEnabled = true;
            this.lineToStation.Location = new System.Drawing.Point(658, 164);
            this.lineToStation.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lineToStation.Name = "lineToStation";
            this.lineToStation.Size = new System.Drawing.Size(156, 28);
            this.lineToStation.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(521, 168);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(117, 20);
            this.label6.TabIndex = 12;
            this.label6.Text = "מספר תחנות בקו";
            // 
            // lineNumStations
            // 
            this.lineNumStations.Location = new System.Drawing.Point(402, 168);
            this.lineNumStations.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lineNumStations.Name = "lineNumStations";
            this.lineNumStations.Size = new System.Drawing.Size(109, 26);
            this.lineNumStations.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(268, 168);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(121, 20);
            this.label7.TabIndex = 14;
            this.label7.Text = "זמן נסיעה בדקות";
            // 
            // lineMinutes
            // 
            this.lineMinutes.Location = new System.Drawing.Point(99, 166);
            this.lineMinutes.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lineMinutes.Name = "lineMinutes";
            this.lineMinutes.Size = new System.Drawing.Size(145, 26);
            this.lineMinutes.TabIndex = 15;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(375, 232);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(136, 56);
            this.button1.TabIndex = 16;
            this.button1.Text = "הוסף";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.AddButtonClick);
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
            this.dataGridView1.Location = new System.Drawing.Point(69, 324);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(819, 201);
            this.dataGridView1.TabIndex = 17;
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
            this.lineMinutesDataGridViewTextBoxColumn.HeaderText = "זמן נסיעה בדקות";
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
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label8.Location = new System.Drawing.Point(804, 300);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(84, 20);
            this.label8.TabIndex = 18;
            this.label8.Text = "טבלת קווים";
            // 
            // FormAddLines
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.ClientSize = new System.Drawing.Size(937, 555);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lineMinutes);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lineNumStations);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lineToStation);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lineFromStation);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lineCompany);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lineNum);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FormAddLines";
            this.Text = "FormAddLines";
            this.Load += new System.EventHandler(this.FormAddLines_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblLinesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetLines)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox lineNum;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox lineCompany;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox lineFromStation;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox lineToStation;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox lineNumStations;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox lineMinutes;
        private System.Windows.Forms.Button button1;
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
        private System.Windows.Forms.Label label8;
    }
}