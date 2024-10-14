namespace BusLines
{
    partial class FormSpecialTypes
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
            this.specialDayTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblSpecialTypesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetSpecialTypes = new BusLines.DataSetSpecialTypes();
            this.tblSpecialTypesTableAdapter = new BusLines.DataSetSpecialTypesTableAdapters.tblSpecialTypesTableAdapter();
            this.saveButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblSpecialTypesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetSpecialTypes)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.specialDayTypeDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tblSpecialTypesBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(73, 73);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(656, 188);
            this.dataGridView1.TabIndex = 0;
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
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(304, 282);
            this.saveButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(193, 56);
            this.saveButton.TabIndex = 1;
            this.saveButton.Text = "שמור";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.SaveButtonClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label2.Location = new System.Drawing.Point(258, 25);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(315, 32);
            this.label2.TabIndex = 3;
            this.label2.Text = "טבלת סוגי ימים מיוחדים";
            // 
            // FormSpecialTypes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(819, 362);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.dataGridView1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FormSpecialTypes";
            this.Text = "FormSpecialTypes";
            this.Load += new System.EventHandler(this.FormSpecialTypes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblSpecialTypesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetSpecialTypes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private DataSetSpecialTypes dataSetSpecialTypes;
        private System.Windows.Forms.BindingSource tblSpecialTypesBindingSource;
        private DataSetSpecialTypesTableAdapters.tblSpecialTypesTableAdapter tblSpecialTypesTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn specialDayTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Label label2;
    }
}