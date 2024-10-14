namespace BusLines
{
    partial class FormAddSpecialTypes
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
            this.specialDayType = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.specialDayTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblSpecialTypesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetSpecialTypes = new BusLines.DataSetSpecialTypes();
            this.tblSpecialTypesTableAdapter = new BusLines.DataSetSpecialTypesTableAdapters.tblSpecialTypesTableAdapter();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblSpecialTypesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetSpecialTypes)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label2.Location = new System.Drawing.Point(322, 11);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(270, 32);
            this.label2.TabIndex = 3;
            this.label2.Text = "הוספת סוג יום מיוחד";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(786, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "סוג יום מיוחד";
            // 
            // specialDayType
            // 
            this.specialDayType.Location = new System.Drawing.Point(567, 99);
            this.specialDayType.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.specialDayType.Name = "specialDayType";
            this.specialDayType.Size = new System.Drawing.Size(191, 26);
            this.specialDayType.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(252, 69);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(178, 88);
            this.button1.TabIndex = 6;
            this.button1.Text = "הוסף";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.AddButtonClick);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.specialDayTypeDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tblSpecialTypesBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(47, 212);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(835, 205);
            this.dataGridView1.TabIndex = 7;
            // 
            // specialDayTypeDataGridViewTextBoxColumn
            // 
            this.specialDayTypeDataGridViewTextBoxColumn.DataPropertyName = "specialDayType";
            this.specialDayTypeDataGridViewTextBoxColumn.HeaderText = "סוג יום מיוחד";
            this.specialDayTypeDataGridViewTextBoxColumn.Name = "specialDayTypeDataGridViewTextBoxColumn";
            // 
            // tblSpecialTypesBindingSource
            // 
            this.tblSpecialTypesBindingSource.DataMember = "tblSpecialTypes";
            this.tblSpecialTypesBindingSource.DataSource = this.dataSetSpecialTypes;
            // 
            // dataSetSpecialTypes
            // 
            this.dataSetSpecialTypes.DataSetName = "DataSetSpecialTypes";
            this.dataSetSpecialTypes.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblSpecialTypesTableAdapter
            // 
            this.tblSpecialTypesTableAdapter.ClearBeforeFill = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label3.Location = new System.Drawing.Point(715, 188);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(167, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "טבלת סוגי ימים מיוחדים";
            // 
            // FormAddSpecialTypes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.ClientSize = new System.Drawing.Size(928, 451);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.specialDayType);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FormAddSpecialTypes";
            this.Text = "FormAddSpecialTypes";
            this.Load += new System.EventHandler(this.FormAddSpecialTypes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblSpecialTypesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetSpecialTypes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox specialDayType;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private DataSetSpecialTypes dataSetSpecialTypes;
        private System.Windows.Forms.BindingSource tblSpecialTypesBindingSource;
        private DataSetSpecialTypesTableAdapters.tblSpecialTypesTableAdapter tblSpecialTypesTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn specialDayTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label3;
    }
}