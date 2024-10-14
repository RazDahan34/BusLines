namespace BusLines
{
    partial class FormUpdateSpecialDays
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
            this.buttonFirst = new System.Windows.Forms.Button();
            this.buttonNext = new System.Windows.Forms.Button();
            this.buttonPrev = new System.Windows.Forms.Button();
            this.buttonLast = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.dayID = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dayIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dayDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dayTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dayStartDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dayEndDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblSpecialDaysBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetSpecialDays = new BusLines.DataSetSpecialDays();
            this.tblSpecialDaysTableAdapter = new BusLines.DataSetSpecialDaysTableAdapters.tblSpecialDaysTableAdapter();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblSpecialDaysBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetSpecialDays)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label2.Location = new System.Drawing.Point(290, 20);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(212, 32);
            this.label2.TabIndex = 3;
            this.label2.Text = "עדכון יום מיוחד";
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
            this.label3.Location = new System.Drawing.Point(367, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "סוג יום מיוחד";
            // 
            // dayType
            // 
            this.dayType.FormattingEnabled = true;
            this.dayType.Location = new System.Drawing.Point(147, 84);
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
            this.label5.Location = new System.Drawing.Point(292, 156);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(118, 20);
            this.label5.TabIndex = 10;
            this.label5.Text = "תחבורה עד שעה";
            // 
            // dayEndDate
            // 
            this.dayEndDate.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dayEndDate.Location = new System.Drawing.Point(82, 150);
            this.dayEndDate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dayEndDate.Name = "dayEndDate";
            this.dayEndDate.Size = new System.Drawing.Size(180, 26);
            this.dayEndDate.TabIndex = 11;
            // 
            // הוסף
            // 
            this.הוסף.Location = new System.Drawing.Point(351, 209);
            this.הוסף.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.הוסף.Name = "הוסף";
            this.הוסף.Size = new System.Drawing.Size(137, 68);
            this.הוסף.TabIndex = 12;
            this.הוסף.Text = "עדכון";
            this.הוסף.UseVisualStyleBackColor = true;
            this.הוסף.Click += new System.EventHandler(this.UpdateButtonClick);
            // 
            // buttonFirst
            // 
            this.buttonFirst.Location = new System.Drawing.Point(698, 218);
            this.buttonFirst.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonFirst.Name = "buttonFirst";
            this.buttonFirst.Size = new System.Drawing.Size(84, 50);
            this.buttonFirst.TabIndex = 14;
            this.buttonFirst.Text = "ראשון";
            this.buttonFirst.UseVisualStyleBackColor = true;
            this.buttonFirst.Click += new System.EventHandler(this.buttonFirst_Click);
            // 
            // buttonNext
            // 
            this.buttonNext.Location = new System.Drawing.Point(534, 218);
            this.buttonNext.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonNext.Name = "buttonNext";
            this.buttonNext.Size = new System.Drawing.Size(84, 50);
            this.buttonNext.TabIndex = 15;
            this.buttonNext.Text = "הבא";
            this.buttonNext.UseVisualStyleBackColor = true;
            this.buttonNext.Click += new System.EventHandler(this.buttonNext_Click);
            // 
            // buttonPrev
            // 
            this.buttonPrev.Location = new System.Drawing.Point(220, 218);
            this.buttonPrev.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonPrev.Name = "buttonPrev";
            this.buttonPrev.Size = new System.Drawing.Size(84, 50);
            this.buttonPrev.TabIndex = 16;
            this.buttonPrev.Text = "הקודם";
            this.buttonPrev.UseVisualStyleBackColor = true;
            this.buttonPrev.Click += new System.EventHandler(this.buttonPrev_Click);
            // 
            // buttonLast
            // 
            this.buttonLast.Location = new System.Drawing.Point(70, 218);
            this.buttonLast.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonLast.Name = "buttonLast";
            this.buttonLast.Size = new System.Drawing.Size(84, 50);
            this.buttonLast.TabIndex = 17;
            this.buttonLast.Text = "אחרון";
            this.buttonLast.UseVisualStyleBackColor = true;
            this.buttonLast.Click += new System.EventHandler(this.buttonLast_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(728, 37);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 20);
            this.label6.TabIndex = 18;
            this.label6.Text = "מספר מזהה";
            // 
            // dayID
            // 
            this.dayID.Location = new System.Drawing.Point(595, 34);
            this.dayID.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dayID.Name = "dayID";
            this.dayID.Size = new System.Drawing.Size(112, 26);
            this.dayID.TabIndex = 19;
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
            this.dataGridView1.Location = new System.Drawing.Point(70, 324);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(736, 204);
            this.dataGridView1.TabIndex = 20;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
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
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(669, 300);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(137, 20);
            this.label7.TabIndex = 21;
            this.label7.Text = "טבלת ימים מיוחדים";
            // 
            // FormUpdateSpecialDays
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Coral;
            this.ClientSize = new System.Drawing.Size(849, 551);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.dayID);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.buttonLast);
            this.Controls.Add(this.buttonPrev);
            this.Controls.Add(this.buttonNext);
            this.Controls.Add(this.buttonFirst);
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
            this.Name = "FormUpdateSpecialDays";
            this.Text = "FormAddSpecialDays";
            this.Load += new System.EventHandler(this.FormUpdateSpecialDays_Load);
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
        private System.Windows.Forms.Button buttonFirst;
        private System.Windows.Forms.Button buttonNext;
        private System.Windows.Forms.Button buttonPrev;
        private System.Windows.Forms.Button buttonLast;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox dayID;
        private System.Windows.Forms.DataGridView dataGridView1;
        private DataSetSpecialDays dataSetSpecialDays;
        private System.Windows.Forms.BindingSource tblSpecialDaysBindingSource;
        private DataSetSpecialDaysTableAdapters.tblSpecialDaysTableAdapter tblSpecialDaysTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn dayIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dayDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dayTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dayStartDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dayEndDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label7;
    }
}