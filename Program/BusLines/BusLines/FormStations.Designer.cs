namespace BusLines
{
    partial class FormStations
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
            this.saveButton = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.stationIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stationNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stationLocationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stationStreetDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stationPictureDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblStationsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetStations = new BusLines.DataSetStations();
            this.tblStationsTableAdapter = new BusLines.DataSetStationsTableAdapters.tblStationsTableAdapter();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblStationsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetStations)).BeginInit();
            this.SuspendLayout();
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(342, 560);
            this.saveButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(244, 67);
            this.saveButton.TabIndex = 1;
            this.saveButton.Text = "שמור";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.SaveButtonClick);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.stationIDDataGridViewTextBoxColumn,
            this.stationNameDataGridViewTextBoxColumn,
            this.stationLocationDataGridViewTextBoxColumn,
            this.stationStreetDataGridViewTextBoxColumn,
            this.stationPictureDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tblStationsBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(61, 94);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(816, 435);
            this.dataGridView1.TabIndex = 2;
            // 
            // stationIDDataGridViewTextBoxColumn
            // 
            this.stationIDDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.stationIDDataGridViewTextBoxColumn.DataPropertyName = "stationID";
            this.stationIDDataGridViewTextBoxColumn.HeaderText = "מספר מזהה תחנה";
            this.stationIDDataGridViewTextBoxColumn.Name = "stationIDDataGridViewTextBoxColumn";
            this.stationIDDataGridViewTextBoxColumn.Width = 134;
            // 
            // stationNameDataGridViewTextBoxColumn
            // 
            this.stationNameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.stationNameDataGridViewTextBoxColumn.DataPropertyName = "stationName";
            this.stationNameDataGridViewTextBoxColumn.HeaderText = "שם תחנה";
            this.stationNameDataGridViewTextBoxColumn.Name = "stationNameDataGridViewTextBoxColumn";
            this.stationNameDataGridViewTextBoxColumn.Width = 86;
            // 
            // stationLocationDataGridViewTextBoxColumn
            // 
            this.stationLocationDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.stationLocationDataGridViewTextBoxColumn.DataPropertyName = "stationLocation";
            this.stationLocationDataGridViewTextBoxColumn.HeaderText = "יישוב";
            this.stationLocationDataGridViewTextBoxColumn.Name = "stationLocationDataGridViewTextBoxColumn";
            this.stationLocationDataGridViewTextBoxColumn.Width = 69;
            // 
            // stationStreetDataGridViewTextBoxColumn
            // 
            this.stationStreetDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.stationStreetDataGridViewTextBoxColumn.DataPropertyName = "stationStreet";
            this.stationStreetDataGridViewTextBoxColumn.HeaderText = "רחוב";
            this.stationStreetDataGridViewTextBoxColumn.Name = "stationStreetDataGridViewTextBoxColumn";
            this.stationStreetDataGridViewTextBoxColumn.Width = 67;
            // 
            // stationPictureDataGridViewTextBoxColumn
            // 
            this.stationPictureDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.stationPictureDataGridViewTextBoxColumn.DataPropertyName = "stationPicture";
            this.stationPictureDataGridViewTextBoxColumn.HeaderText = "תמונה";
            this.stationPictureDataGridViewTextBoxColumn.Name = "stationPictureDataGridViewTextBoxColumn";
            this.stationPictureDataGridViewTextBoxColumn.Width = 74;
            // 
            // tblStationsBindingSource
            // 
            this.tblStationsBindingSource.DataMember = "tblStations";
            this.tblStationsBindingSource.DataSource = this.dataSetStations;
            // 
            // dataSetStations
            // 
            this.dataSetStations.DataSetName = "DataSetStations";
            this.dataSetStations.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblStationsTableAdapter
            // 
            this.tblStationsTableAdapter.ClearBeforeFill = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label2.Location = new System.Drawing.Point(386, 32);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(167, 32);
            this.label2.TabIndex = 3;
            this.label2.Text = "טבלת תחנות";
            // 
            // FormStations
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(957, 640);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.saveButton);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FormStations";
            this.Text = "FormStations";
            this.Load += new System.EventHandler(this.FormStations_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblStationsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetStations)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.DataGridView dataGridView1;
        private DataSetStations dataSetStations;
        private System.Windows.Forms.BindingSource tblStationsBindingSource;
        private DataSetStationsTableAdapters.tblStationsTableAdapter tblStationsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn stationIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stationNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stationLocationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stationStreetDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stationPictureDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label2;
    }
}