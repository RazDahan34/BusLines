namespace BusLines
{
    partial class FormAddSpecialStations
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
            this.specialStationType = new System.Windows.Forms.TextBox();
            this.הוסף = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.specialStationTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblSpecialStationsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetSpecialStations = new BusLines.DataSetSpecialStations();
            this.tblSpecialStationsTableAdapter = new BusLines.DataSetSpecialStationsTableAdapters.tblSpecialStationsTableAdapter();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblSpecialStationsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetSpecialStations)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label2.Location = new System.Drawing.Point(326, 30);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(217, 32);
            this.label2.TabIndex = 3;
            this.label2.Text = "הוספת סוג תחנה";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(773, 121);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "סוג תחנה";
            // 
            // specialStationType
            // 
            this.specialStationType.Location = new System.Drawing.Point(515, 118);
            this.specialStationType.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.specialStationType.Name = "specialStationType";
            this.specialStationType.Size = new System.Drawing.Size(220, 26);
            this.specialStationType.TabIndex = 5;
            // 
            // הוסף
            // 
            this.הוסף.Location = new System.Drawing.Point(200, 92);
            this.הוסף.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.הוסף.Name = "הוסף";
            this.הוסף.Size = new System.Drawing.Size(210, 78);
            this.הוסף.TabIndex = 6;
            this.הוסף.Text = "הוסף";
            this.הוסף.UseVisualStyleBackColor = true;
            this.הוסף.Click += new System.EventHandler(this.AddButtonClick);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.specialStationTypeDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tblSpecialStationsBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(60, 244);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(782, 188);
            this.dataGridView1.TabIndex = 7;
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
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label3.Location = new System.Drawing.Point(726, 220);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "טבלת סוגי תחנה";
            // 
            // FormAddSpecialStations
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.ClientSize = new System.Drawing.Size(908, 470);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.הוסף);
            this.Controls.Add(this.specialStationType);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FormAddSpecialStations";
            this.Text = "FormAddSpecialStations";
            this.Load += new System.EventHandler(this.FormAddSpecialStations_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblSpecialStationsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetSpecialStations)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox specialStationType;
        private System.Windows.Forms.Button הוסף;
        private System.Windows.Forms.DataGridView dataGridView1;
        private DataSetSpecialStations dataSetSpecialStations;
        private System.Windows.Forms.BindingSource tblSpecialStationsBindingSource;
        private DataSetSpecialStationsTableAdapters.tblSpecialStationsTableAdapter tblSpecialStationsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn specialStationTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label3;
    }
}