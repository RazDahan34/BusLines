namespace BusLines
{
    partial class FormAddSpecialDays
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
            this.dayDate = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.dayType = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dayStartDate = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.dayEndDate = new System.Windows.Forms.DateTimePicker();
            this.הוסף = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dayIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dayDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dayTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dayStartDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dayEndDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblSpecialDaysBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetSpecialDays = new BusLines.DataSetSpecialDays();
            this.tblSpecialDaysTableAdapter = new BusLines.DataSetSpecialDaysTableAdapters.tblSpecialDaysTableAdapter();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblSpecialDaysBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetSpecialDays)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label2.Location = new System.Drawing.Point(324, 23);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(221, 32);
            this.label2.TabIndex = 3;
            this.label2.Text = "הוספת יום מיוחד";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(758, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "תאריך";
            // 
            // dayDate
            // 
            this.dayDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dayDate.Location = new System.Drawing.Point(515, 88);
            this.dayDate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dayDate.Name = "dayDate";
            this.dayDate.Size = new System.Drawing.Size(224, 26);
            this.dayDate.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(388, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "סוג יום מיוחד";
            // 
            // dayType
            // 
            this.dayType.FormattingEnabled = true;
            this.dayType.Location = new System.Drawing.Point(182, 82);
            this.dayType.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dayType.Name = "dayType";
            this.dayType.Size = new System.Drawing.Size(184, 28);
            this.dayType.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(706, 156);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "תחבורה משעה";
            // 
            // dayStartDate
            // 
            this.dayStartDate.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dayStartDate.Location = new System.Drawing.Point(506, 150);
            this.dayStartDate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dayStartDate.Name = "dayStartDate";
            this.dayStartDate.Size = new System.Drawing.Size(177, 26);
            this.dayStartDate.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(368, 156);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(118, 20);
            this.label5.TabIndex = 10;
            this.label5.Text = "תחבורה עד שעה";
            // 
            // dayEndDate
            // 
            this.dayEndDate.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dayEndDate.Location = new System.Drawing.Point(163, 150);
            this.dayEndDate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dayEndDate.Name = "dayEndDate";
            this.dayEndDate.Size = new System.Drawing.Size(180, 26);
            this.dayEndDate.TabIndex = 11;
            // 
            // הוסף
            // 
            this.הוסף.Location = new System.Drawing.Point(15, 88);
            this.הוסף.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.הוסף.Name = "הוסף";
            this.הוסף.Size = new System.Drawing.Size(127, 90);
            this.הוסף.TabIndex = 12;
            this.הוסף.Text = "הוסף";
            this.הוסף.UseVisualStyleBackColor = true;
            this.הוסף.Click += new System.EventHandler(this.AddButtonClick);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dayIDDataGridViewTextBoxColumn,
            this.dayDateDataGridViewTextBoxColumn,
            this.dayTypeDataGridViewTextBoxColumn,
            this.dayStartDateDataGridViewTextBoxColumn,
            this.dayEndDateDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tblSpecialDaysBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(30, 257);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(791, 216);
            this.dataGridView1.TabIndex = 13;
            // 
            // dayIDDataGridViewTextBoxColumn
            // 
            this.dayIDDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dayIDDataGridViewTextBoxColumn.DataPropertyName = "dayID";
            this.dayIDDataGridViewTextBoxColumn.HeaderText = "מספר מזהה";
            this.dayIDDataGridViewTextBoxColumn.Name = "dayIDDataGridViewTextBoxColumn";
            this.dayIDDataGridViewTextBoxColumn.Width = 99;
            // 
            // dayDateDataGridViewTextBoxColumn
            // 
            this.dayDateDataGridViewTextBoxColumn.DataPropertyName = "dayDate";
            this.dayDateDataGridViewTextBoxColumn.HeaderText = "תאריך";
            this.dayDateDataGridViewTextBoxColumn.Name = "dayDateDataGridViewTextBoxColumn";
            // 
            // dayTypeDataGridViewTextBoxColumn
            // 
            this.dayTypeDataGridViewTextBoxColumn.DataPropertyName = "dayType";
            this.dayTypeDataGridViewTextBoxColumn.HeaderText = "סוג יום מיוחד";
            this.dayTypeDataGridViewTextBoxColumn.Name = "dayTypeDataGridViewTextBoxColumn";
            // 
            // dayStartDateDataGridViewTextBoxColumn
            // 
            this.dayStartDateDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dayStartDateDataGridViewTextBoxColumn.DataPropertyName = "dayStartDate";
            this.dayStartDateDataGridViewTextBoxColumn.HeaderText = "תחבורה משעה";
            this.dayStartDateDataGridViewTextBoxColumn.Name = "dayStartDateDataGridViewTextBoxColumn";
            this.dayStartDateDataGridViewTextBoxColumn.Width = 119;
            // 
            // dayEndDateDataGridViewTextBoxColumn
            // 
            this.dayEndDateDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dayEndDateDataGridViewTextBoxColumn.DataPropertyName = "dayEndDate";
            this.dayEndDateDataGridViewTextBoxColumn.HeaderText = "תחבורה עד שעה";
            this.dayEndDateDataGridViewTextBoxColumn.Name = "dayEndDateDataGridViewTextBoxColumn";
            this.dayEndDateDataGridViewTextBoxColumn.Width = 104;
            // 
            // tblSpecialDaysBindingSource
            // 
            this.tblSpecialDaysBindingSource.DataMember = "tblSpecialDays";
            this.tblSpecialDaysBindingSource.DataSource = this.dataSetSpecialDays;
            // 
            // dataSetSpecialDays
            // 
            this.dataSetSpecialDays.DataSetName = "DataSetSpecialDays";
            this.dataSetSpecialDays.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblSpecialDaysTableAdapter
            // 
            this.tblSpecialDaysTableAdapter.ClearBeforeFill = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label6.Location = new System.Drawing.Point(684, 233);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(137, 20);
            this.label6.TabIndex = 14;
            this.label6.Text = "טבלת ימים מיוחדים";
            // 
            // FormAddSpecialDays
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.ClientSize = new System.Drawing.Size(853, 510);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.הוסף);
            this.Controls.Add(this.dayEndDate);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dayStartDate);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dayType);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dayDate);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FormAddSpecialDays";
            this.Text = "FormAddSpecialDays";
            this.Load += new System.EventHandler(this.FormAddSpecialDays_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblSpecialDaysBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetSpecialDays)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dayDate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox dayType;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dayStartDate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dayEndDate;
        private System.Windows.Forms.Button הוסף;
        private System.Windows.Forms.DataGridView dataGridView1;
        private DataSetSpecialDays dataSetSpecialDays;
        private System.Windows.Forms.BindingSource tblSpecialDaysBindingSource;
        private DataSetSpecialDaysTableAdapters.tblSpecialDaysTableAdapter tblSpecialDaysTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn dayIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dayDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dayTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dayStartDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dayEndDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label6;
    }
}