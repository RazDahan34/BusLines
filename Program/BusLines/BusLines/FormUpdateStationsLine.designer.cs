namespace BusLines
{
    partial class FormUpdateStationsLine
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
            this.label3 = new System.Windows.Forms.Label();
            this.lineStationLineID = new System.Windows.Forms.ComboBox();
            this.lineStationNumber = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lineStationID = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lineStationMinutes = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.lineStationKind = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lineStationLineIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lineStationNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lineStationIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lineStationMinutesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lineStationKindDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblStationsLineBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetStationsLine = new BusLines.DataSetStationsLine();
            this.tblStationsLineTableAdapter = new BusLines.DataSetStationsLineTableAdapters.tblStationsLineTableAdapter();
            this.buttonFirst = new System.Windows.Forms.Button();
            this.buttonNext = new System.Windows.Forms.Button();
            this.buttonPrev = new System.Windows.Forms.Button();
            this.buttonLast = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblStationsLineBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetStationsLine)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label2.Location = new System.Drawing.Point(302, 26);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(211, 32);
            this.label2.TabIndex = 2;
            this.label2.Text = "עדכון תחנה בקו";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(770, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "מספר מזהה קו";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(482, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "מספר סידורי תחנה";
            // 
            // lineStationLineID
            // 
            this.lineStationLineID.FormattingEnabled = true;
            this.lineStationLineID.Location = new System.Drawing.Point(628, 100);
            this.lineStationLineID.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lineStationLineID.Name = "lineStationLineID";
            this.lineStationLineID.Size = new System.Drawing.Size(126, 28);
            this.lineStationLineID.TabIndex = 6;
            // 
            // lineStationNumber
            // 
            this.lineStationNumber.Location = new System.Drawing.Point(345, 100);
            this.lineStationNumber.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lineStationNumber.Name = "lineStationNumber";
            this.lineStationNumber.Size = new System.Drawing.Size(116, 26);
            this.lineStationNumber.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(207, 103);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(122, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "מספר מזהה תחנה";
            // 
            // lineStationID
            // 
            this.lineStationID.FormattingEnabled = true;
            this.lineStationID.Location = new System.Drawing.Point(43, 100);
            this.lineStationID.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lineStationID.Name = "lineStationID";
            this.lineStationID.Size = new System.Drawing.Size(154, 28);
            this.lineStationID.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(736, 189);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(121, 20);
            this.label5.TabIndex = 10;
            this.label5.Text = "זמן נסיעה בדקות";
            // 
            // lineStationMinutes
            // 
            this.lineStationMinutes.Location = new System.Drawing.Point(573, 185);
            this.lineStationMinutes.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lineStationMinutes.Name = "lineStationMinutes";
            this.lineStationMinutes.Size = new System.Drawing.Size(142, 26);
            this.lineStationMinutes.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(482, 189);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 20);
            this.label6.TabIndex = 12;
            this.label6.Text = "סוג תחנה";
            // 
            // lineStationKind
            // 
            this.lineStationKind.FormattingEnabled = true;
            this.lineStationKind.Location = new System.Drawing.Point(307, 185);
            this.lineStationKind.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lineStationKind.Name = "lineStationKind";
            this.lineStationKind.Size = new System.Drawing.Size(154, 28);
            this.lineStationKind.TabIndex = 13;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(43, 189);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(173, 62);
            this.button1.TabIndex = 14;
            this.button1.Text = "עדכן";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.UpdateButtonClick);
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
            this.dataGridView1.Location = new System.Drawing.Point(34, 333);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(837, 210);
            this.dataGridView1.TabIndex = 15;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
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
            // buttonFirst
            // 
            this.buttonFirst.Location = new System.Drawing.Point(702, 250);
            this.buttonFirst.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonFirst.Name = "buttonFirst";
            this.buttonFirst.Size = new System.Drawing.Size(84, 41);
            this.buttonFirst.TabIndex = 16;
            this.buttonFirst.Text = "ראשון";
            this.buttonFirst.UseVisualStyleBackColor = true;
            this.buttonFirst.Click += new System.EventHandler(this.buttonFirst_Click);
            // 
            // buttonNext
            // 
            this.buttonNext.Location = new System.Drawing.Point(559, 250);
            this.buttonNext.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonNext.Name = "buttonNext";
            this.buttonNext.Size = new System.Drawing.Size(84, 41);
            this.buttonNext.TabIndex = 17;
            this.buttonNext.Text = "הבא";
            this.buttonNext.UseVisualStyleBackColor = true;
            this.buttonNext.Click += new System.EventHandler(this.buttonNext_Click);
            // 
            // buttonPrev
            // 
            this.buttonPrev.Location = new System.Drawing.Point(412, 250);
            this.buttonPrev.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonPrev.Name = "buttonPrev";
            this.buttonPrev.Size = new System.Drawing.Size(84, 41);
            this.buttonPrev.TabIndex = 18;
            this.buttonPrev.Text = "הקודם";
            this.buttonPrev.UseVisualStyleBackColor = true;
            this.buttonPrev.Click += new System.EventHandler(this.buttonPrev_Click);
            // 
            // buttonLast
            // 
            this.buttonLast.Location = new System.Drawing.Point(269, 250);
            this.buttonLast.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonLast.Name = "buttonLast";
            this.buttonLast.Size = new System.Drawing.Size(84, 41);
            this.buttonLast.TabIndex = 19;
            this.buttonLast.Text = "אחרון";
            this.buttonLast.UseVisualStyleBackColor = true;
            this.buttonLast.Click += new System.EventHandler(this.buttonLast_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(752, 309);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(119, 20);
            this.label7.TabIndex = 20;
            this.label7.Text = "טבלת תחנות בקו";
            // 
            // FormUpdateStationsLine
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Coral;
            this.ClientSize = new System.Drawing.Size(901, 571);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.buttonLast);
            this.Controls.Add(this.buttonPrev);
            this.Controls.Add(this.buttonNext);
            this.Controls.Add(this.buttonFirst);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lineStationKind);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lineStationMinutes);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lineStationID);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lineStationNumber);
            this.Controls.Add(this.lineStationLineID);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FormUpdateStationsLine";
            this.Text = "FormAddStationsLine";
            this.Load += new System.EventHandler(this.FormAddStationsLine_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblStationsLineBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetStationsLine)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox lineStationLineID;
        private System.Windows.Forms.TextBox lineStationNumber;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox lineStationID;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox lineStationMinutes;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox lineStationKind;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private DataSetStationsLine dataSetStationsLine;
        private System.Windows.Forms.BindingSource tblStationsLineBindingSource;
        private DataSetStationsLineTableAdapters.tblStationsLineTableAdapter tblStationsLineTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn lineStationLineIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lineStationNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lineStationIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lineStationMinutesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lineStationKindDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button buttonFirst;
        private System.Windows.Forms.Button buttonNext;
        private System.Windows.Forms.Button buttonPrev;
        private System.Windows.Forms.Button buttonLast;
        private System.Windows.Forms.Label label7;
    }
}