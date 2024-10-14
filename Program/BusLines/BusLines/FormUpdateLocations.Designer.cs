namespace BusLines
{
    partial class FormUpdateLocations
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
            this.buttonFirst = new System.Windows.Forms.Button();
            this.buttonNext = new System.Windows.Forms.Button();
            this.buttonPrev = new System.Windows.Forms.Button();
            this.buttonLast = new System.Windows.Forms.Button();
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
            this.label2.Size = new System.Drawing.Size(161, 32);
            this.label2.TabIndex = 1;
            this.label2.Text = "עדכון יישוב";
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
            this.button1.Text = "עדכון";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.UpdateButtonClick);
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
            this.dataGridView1.Location = new System.Drawing.Point(56, 281);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(800, 192);
            this.dataGridView1.TabIndex = 8;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
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
            // buttonFirst
            // 
            this.buttonFirst.Location = new System.Drawing.Point(721, 180);
            this.buttonFirst.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonFirst.Name = "buttonFirst";
            this.buttonFirst.Size = new System.Drawing.Size(84, 45);
            this.buttonFirst.TabIndex = 9;
            this.buttonFirst.Text = "ראשון";
            this.buttonFirst.UseVisualStyleBackColor = true;
            this.buttonFirst.Click += new System.EventHandler(this.buttonFirst_Click);
            // 
            // buttonNext
            // 
            this.buttonNext.Location = new System.Drawing.Point(562, 180);
            this.buttonNext.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonNext.Name = "buttonNext";
            this.buttonNext.Size = new System.Drawing.Size(84, 45);
            this.buttonNext.TabIndex = 10;
            this.buttonNext.Text = "הבא";
            this.buttonNext.UseVisualStyleBackColor = true;
            this.buttonNext.Click += new System.EventHandler(this.buttonNext_Click);
            // 
            // buttonPrev
            // 
            this.buttonPrev.Location = new System.Drawing.Point(212, 180);
            this.buttonPrev.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonPrev.Name = "buttonPrev";
            this.buttonPrev.Size = new System.Drawing.Size(84, 45);
            this.buttonPrev.TabIndex = 11;
            this.buttonPrev.Text = "הקודם";
            this.buttonPrev.UseVisualStyleBackColor = true;
            this.buttonPrev.Click += new System.EventHandler(this.buttonPrev_Click);
            // 
            // buttonLast
            // 
            this.buttonLast.Location = new System.Drawing.Point(71, 180);
            this.buttonLast.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonLast.Name = "buttonLast";
            this.buttonLast.Size = new System.Drawing.Size(84, 45);
            this.buttonLast.TabIndex = 12;
            this.buttonLast.Text = "אחרון";
            this.buttonLast.UseVisualStyleBackColor = true;
            this.buttonLast.Click += new System.EventHandler(this.buttonLast_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(756, 257);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 20);
            this.label5.TabIndex = 13;
            this.label5.Text = "טבלת יישובים";
            // 
            // FormUpdateLocations
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Coral;
            this.ClientSize = new System.Drawing.Size(884, 499);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.buttonLast);
            this.Controls.Add(this.buttonPrev);
            this.Controls.Add(this.buttonNext);
            this.Controls.Add(this.buttonFirst);
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
            this.Name = "FormUpdateLocations";
            this.Text = "FormAddLocations";
            this.Load += new System.EventHandler(this.FormUpdateLocations_Load_1);
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
        private System.Windows.Forms.Button buttonFirst;
        private System.Windows.Forms.Button buttonNext;
        private System.Windows.Forms.Button buttonPrev;
        private System.Windows.Forms.Button buttonLast;
        private System.Windows.Forms.Label label5;
    }
}