namespace BusLines
{
    partial class FormCities
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
            this.cityNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblCitiesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetCities = new BusLines.DataSetCities();
            this.tblCitiesTableAdapter = new BusLines.DataSetCitiesTableAdapters.tblCitiesTableAdapter();
            this.saveButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblCitiesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetCities)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cityNameDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tblCitiesBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(36, 75);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(718, 207);
            this.dataGridView1.TabIndex = 0;
            // 
            // cityNameDataGridViewTextBoxColumn
            // 
            this.cityNameDataGridViewTextBoxColumn.DataPropertyName = "cityName";
            this.cityNameDataGridViewTextBoxColumn.HeaderText = "שם עיר";
            this.cityNameDataGridViewTextBoxColumn.Name = "cityNameDataGridViewTextBoxColumn";
            // 
            // tblCitiesBindingSource
            // 
            this.tblCitiesBindingSource.DataMember = "tblCities";
            this.tblCitiesBindingSource.DataSource = this.dataSetCities;
            // 
            // dataSetCities
            // 
            this.dataSetCities.DataSetName = "DataSetCities";
            this.dataSetCities.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblCitiesTableAdapter
            // 
            this.tblCitiesTableAdapter.ClearBeforeFill = true;
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(312, 308);
            this.saveButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(177, 57);
            this.saveButton.TabIndex = 1;
            this.saveButton.Text = "שמור";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.SaveButtonClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label2.Location = new System.Drawing.Point(321, 20);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(153, 32);
            this.label2.TabIndex = 3;
            this.label2.Text = "טבלת ערים";
            // 
            // FormCities
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(804, 397);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.dataGridView1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FormCities";
            this.Text = "FormCities";
            this.Load += new System.EventHandler(this.FormCities_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblCitiesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetCities)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private DataSetCities dataSetCities;
        private System.Windows.Forms.BindingSource tblCitiesBindingSource;
        private DataSetCitiesTableAdapters.tblCitiesTableAdapter tblCitiesTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn cityNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Label label2;
    }
}