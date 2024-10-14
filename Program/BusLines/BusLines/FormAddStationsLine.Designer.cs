namespace BusLines
{
    partial class FormAddStationsLine
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
            this.label2.Location = new System.Drawing.Point(431, 27);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(220, 32);
            this.label2.TabIndex = 2;
            this.label2.Text = "הוספת תחנה בקו";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(857, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "מספר מזהה קו";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(521, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "מספר סידורי תחנה";
            // 
            // lineStationLineID
            // 
            this.lineStationLineID.FormattingEnabled = true;
            this.lineStationLineID.Location = new System.Drawing.Point(683, 100);
            this.lineStationLineID.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lineStationLineID.Name = "lineStationLineID";
            this.lineStationLineID.Size = new System.Drawing.Size(136, 28);
            this.lineStationLineID.TabIndex = 6;
            // 
            // lineStationNumber
            // 
            this.lineStationNumber.Location = new System.Drawing.Point(358, 100);
            this.lineStationNumber.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lineStationNumber.Name = "lineStationNumber";
            this.lineStationNumber.Size = new System.Drawing.Size(131, 26);
            this.lineStationNumber.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(206, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(122, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "מספר מזהה תחנה";
            // 
            // lineStationID
            // 
            this.lineStationID.FormattingEnabled = true;
            this.lineStationID.Location = new System.Drawing.Point(28, 100);
            this.lineStationID.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lineStationID.Name = "lineStationID";
            this.lineStationID.Size = new System.Drawing.Size(154, 28);
            this.lineStationID.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(837, 189);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(121, 20);
            this.label5.TabIndex = 10;
            this.label5.Text = "זמן נסיעה בדקות";
            // 
            // lineStationMinutes
            // 
            this.lineStationMinutes.Location = new System.Drawing.Point(654, 185);
            this.lineStationMinutes.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lineStationMinutes.Name = "lineStationMinutes";
            this.lineStationMinutes.Size = new System.Drawing.Size(142, 26);
            this.lineStationMinutes.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(521, 189);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 20);
            this.label6.TabIndex = 12;
            this.label6.Text = "סוג תחנה";
            // 
            // lineStationKind
            // 
            this.lineStationKind.FormattingEnabled = true;
            this.lineStationKind.Location = new System.Drawing.Point(335, 185);
            this.lineStationKind.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lineStationKind.Name = "lineStationKind";
            this.lineStationKind.Size = new System.Drawing.Size(154, 28);
            this.lineStationKind.TabIndex = 13;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(100, 185);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(173, 62);
            this.button1.TabIndex = 14;
            this.button1.Text = "הוסף";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.AddButtonClick);
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
            this.dataGridView1.Location = new System.Drawing.Point(77, 285);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(837, 210);
            this.dataGridView1.TabIndex = 15;
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
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label7.Location = new System.Drawing.Point(795, 261);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(119, 20);
            this.label7.TabIndex = 16;
            this.label7.Text = "טבלת תחנות בקו";
            // 
            // FormAddStationsLine
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.ClientSize = new System.Drawing.Size(1008, 536);
            this.Controls.Add(this.label7);
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
            this.Name = "FormAddStationsLine";
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
        private System.Windows.Forms.Label label7;
    }
}