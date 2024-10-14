namespace BusLines
{
    partial class FormSpecialDays
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
            this.dayIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dayDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dayTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dayStartDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dayEndDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblSpecialDaysBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetSpecialDays = new BusLines.DataSetSpecialDays();
            this.saveButton = new System.Windows.Forms.Button();
            this.tblSpecialDaysTableAdapter = new BusLines.DataSetSpecialDaysTableAdapters.tblSpecialDaysTableAdapter();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblSpecialDaysBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetSpecialDays)).BeginInit();
            this.SuspendLayout();
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
            this.dataGridView1.Location = new System.Drawing.Point(82, 86);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(656, 188);
            this.dataGridView1.TabIndex = 0;
            // 
            // dayIDDataGridViewTextBoxColumn
            // 
            this.dayIDDataGridViewTextBoxColumn.DataPropertyName = "dayID";
            this.dayIDDataGridViewTextBoxColumn.HeaderText = "מספר מזהה";
            this.dayIDDataGridViewTextBoxColumn.Name = "dayIDDataGridViewTextBoxColumn";
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
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(273, 299);
            this.saveButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(261, 65);
            this.saveButton.TabIndex = 1;
            this.saveButton.Text = "שמור";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.SaveButtonClick);
            // 
            // tblSpecialDaysTableAdapter
            // 
            this.tblSpecialDaysTableAdapter.ClearBeforeFill = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label2.Location = new System.Drawing.Point(267, 25);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(256, 32);
            this.label2.TabIndex = 3;
            this.label2.Text = "טבלת ימים מיוחדים";
            // 
            // FormSpecialDays
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(831, 398);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.dataGridView1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FormSpecialDays";
            this.Text = "FormSpecialDays";
            this.Load += new System.EventHandler(this.FormSpecialDays_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblSpecialDaysBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetSpecialDays)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button saveButton;
        private DataSetSpecialDays dataSetSpecialDays;
        private System.Windows.Forms.BindingSource tblSpecialDaysBindingSource;
        private DataSetSpecialDaysTableAdapters.tblSpecialDaysTableAdapter tblSpecialDaysTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn dayIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dayDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dayTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dayStartDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dayEndDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label2;
    }
}