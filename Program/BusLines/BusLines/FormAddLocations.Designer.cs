namespace BusLines
{
    partial class FormAddLocations
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.locatName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.locatNearCity = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.locatDistance = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.locatNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.locatNearCityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.locatDistanceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblLocationsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetLocations = new BusLines.DataSetLocations();
            this.tblLocationsTableAdapter = new BusLines.DataSetLocationsTableAdapters.tblLocationsTableAdapter();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblLocationsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetLocations)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(791, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "שם יישוב";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label2.Location = new System.Drawing.Point(341, 22);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(170, 32);
            this.label2.TabIndex = 1;
            this.label2.Text = "הוספת יישוב";
            // 
            // locatName
            // 
            this.locatName.Location = new System.Drawing.Point(619, 95);
            this.locatName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.locatName.Name = "locatName";
            this.locatName.Size = new System.Drawing.Size(141, 26);
            this.locatName.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(511, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "עיר קרובה";
            // 
            // locatNearCity
            // 
            this.locatNearCity.FormattingEnabled = true;
            this.locatNearCity.Location = new System.Drawing.Point(331, 95);
            this.locatNearCity.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.locatNearCity.Name = "locatNearCity";
            this.locatNearCity.Size = new System.Drawing.Size(154, 28);
            this.locatNearCity.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(215, 95);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "מרחק בק\"מ";
            // 
            // locatDistance
            // 
            this.locatDistance.Location = new System.Drawing.Point(56, 95);
            this.locatDistance.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.locatDistance.Name = "locatDistance";
            this.locatDistance.Size = new System.Drawing.Size(140, 26);
            this.locatDistance.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(346, 161);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(166, 65);
            this.button1.TabIndex = 7;
            this.button1.Text = "הוסף";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.AddButtonClick);
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
            this.dataGridView1.Location = new System.Drawing.Point(56, 261);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(800, 211);
            this.dataGridView1.TabIndex = 8;
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
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label5.Location = new System.Drawing.Point(756, 237);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "טבלת יישובים";
            // 
            // FormAddLocations
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.ClientSize = new System.Drawing.Size(884, 499);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.locatDistance);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.locatNearCity);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.locatName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FormAddLocations";
            this.Text = "FormAddLocations";
            this.Load += new System.EventHandler(this.FormAddLocations_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblLocationsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetLocations)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox locatName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox locatNearCity;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox locatDistance;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private DataSetLocations dataSetLocations;
        private System.Windows.Forms.BindingSource tblLocationsBindingSource;
        private DataSetLocationsTableAdapters.tblLocationsTableAdapter tblLocationsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn locatNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn locatNearCityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn locatDistanceDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label5;
    }
}