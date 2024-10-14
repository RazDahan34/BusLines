namespace BusLines
{
    partial class FormLocations
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
            this.locatNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.locatNearCityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.locatDistanceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblLocationsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetLocations = new BusLines.DataSetLocations();
            this.tblLocationsTableAdapter = new BusLines.DataSetLocationsTableAdapters.tblLocationsTableAdapter();
            this.saveButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblLocationsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetLocations)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.locatNameDataGridViewTextBoxColumn,
            this.locatNearCityDataGridViewTextBoxColumn,
            this.locatDistanceDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tblLocationsBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(68, 105);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(755, 188);
            this.dataGridView1.TabIndex = 0;
            // 
            // locatNameDataGridViewTextBoxColumn
            // 
            this.locatNameDataGridViewTextBoxColumn.DataPropertyName = "locatName";
            this.locatNameDataGridViewTextBoxColumn.HeaderText = "שם יישוב";
            this.locatNameDataGridViewTextBoxColumn.Name = "locatNameDataGridViewTextBoxColumn";
            // 
            // locatNearCityDataGridViewTextBoxColumn
            // 
            this.locatNearCityDataGridViewTextBoxColumn.DataPropertyName = "locatNearCity";
            this.locatNearCityDataGridViewTextBoxColumn.HeaderText = "עיר קרובה";
            this.locatNearCityDataGridViewTextBoxColumn.Name = "locatNearCityDataGridViewTextBoxColumn";
            // 
            // locatDistanceDataGridViewTextBoxColumn
            // 
            this.locatDistanceDataGridViewTextBoxColumn.DataPropertyName = "locatDistance";
            this.locatDistanceDataGridViewTextBoxColumn.HeaderText = "מרחק בק\"מ";
            this.locatDistanceDataGridViewTextBoxColumn.Name = "locatDistanceDataGridViewTextBoxColumn";
            // 
            // tblLocationsBindingSource
            // 
            this.tblLocationsBindingSource.DataMember = "tblLocations";
            this.tblLocationsBindingSource.DataSource = this.dataSetLocations;
            // 
            // dataSetLocations
            // 
            this.dataSetLocations.DataSetName = "DataSetLocations";
            this.dataSetLocations.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblLocationsTableAdapter
            // 
            this.tblLocationsTableAdapter.ClearBeforeFill = true;
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(311, 325);
            this.saveButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(261, 75);
            this.saveButton.TabIndex = 1;
            this.saveButton.Text = "שמור";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.SaveButtonClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label2.Location = new System.Drawing.Point(349, 35);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(187, 32);
            this.label2.TabIndex = 3;
            this.label2.Text = "טבלת יישובים";
            // 
            // FormLocations
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(889, 428);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.dataGridView1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FormLocations";
            this.Text = "FormLocations";
            this.Load += new System.EventHandler(this.FormLocations_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblLocationsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetLocations)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private DataSetLocations dataSetLocations;
        private System.Windows.Forms.BindingSource tblLocationsBindingSource;
        private DataSetLocationsTableAdapters.tblLocationsTableAdapter tblLocationsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn locatNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn locatNearCityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn locatDistanceDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Label label2;
    }
}