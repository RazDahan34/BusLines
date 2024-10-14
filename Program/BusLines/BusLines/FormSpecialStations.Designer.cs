namespace BusLines
{
    partial class FormSpecialStations
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
            this.specialStationTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblSpecialStationsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetSpecialStations = new BusLines.DataSetSpecialStations();
            this.tblSpecialStationsTableAdapter = new BusLines.DataSetSpecialStationsTableAdapters.tblSpecialStationsTableAdapter();
            this.saveButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblSpecialStationsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetSpecialStations)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.specialStationTypeDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tblSpecialStationsBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(66, 85);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(671, 188);
            this.dataGridView1.TabIndex = 0;
            // 
            // specialStationTypeDataGridViewTextBoxColumn
            // 
            this.specialStationTypeDataGridViewTextBoxColumn.DataPropertyName = "specialStationType";
            this.specialStationTypeDataGridViewTextBoxColumn.HeaderText = "סוג תחנה";
            this.specialStationTypeDataGridViewTextBoxColumn.Name = "specialStationTypeDataGridViewTextBoxColumn";
            // 
            // tblSpecialStationsBindingSource
            // 
            this.tblSpecialStationsBindingSource.DataMember = "tblSpecialStations";
            this.tblSpecialStationsBindingSource.DataSource = this.dataSetSpecialStations;
            // 
            // dataSetSpecialStations
            // 
            this.dataSetSpecialStations.DataSetName = "DataSetSpecialStations";
            this.dataSetSpecialStations.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblSpecialStationsTableAdapter
            // 
            this.tblSpecialStationsTableAdapter.ClearBeforeFill = true;
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(277, 304);
            this.saveButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(244, 61);
            this.saveButton.TabIndex = 1;
            this.saveButton.Text = "שמור";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.SaveButtonClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label2.Location = new System.Drawing.Point(295, 25);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(216, 32);
            this.label2.TabIndex = 3;
            this.label2.Text = "טבלת סוגי תחנה";
            // 
            // FormSpecialStations
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(831, 390);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.dataGridView1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FormSpecialStations";
            this.Text = "FormSpecialStations";
            this.Load += new System.EventHandler(this.FormSpecialStations_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblSpecialStationsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetSpecialStations)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private DataSetSpecialStations dataSetSpecialStations;
        private System.Windows.Forms.BindingSource tblSpecialStationsBindingSource;
        private DataSetSpecialStationsTableAdapters.tblSpecialStationsTableAdapter tblSpecialStationsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn specialStationTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Label label2;
    }
}