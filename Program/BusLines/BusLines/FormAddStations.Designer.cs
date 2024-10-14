namespace BusLines
{
    partial class FormAddStations
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
            this.stationLocation = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.stationStreet = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.stationPicture = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.stationIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stationNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stationLocationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stationStreetDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stationPictureDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblStationsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetStations = new BusLines.DataSetStations();
            this.tblStationsTableAdapter = new BusLines.DataSetStationsTableAdapters.tblStationsTableAdapter();
            this.label5 = new System.Windows.Forms.Label();
            this.stationName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblStationsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetStations)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label2.Location = new System.Drawing.Point(330, 11);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(168, 32);
            this.label2.TabIndex = 4;
            this.label2.Text = "הוספת תחנה";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(259, 116);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "יישוב";
            // 
            // stationLocation
            // 
            this.stationLocation.FormattingEnabled = true;
            this.stationLocation.Location = new System.Drawing.Point(56, 112);
            this.stationLocation.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.stationLocation.Name = "stationLocation";
            this.stationLocation.Size = new System.Drawing.Size(172, 28);
            this.stationLocation.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(512, 238);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "רחוב";
            // 
            // stationStreet
            // 
            this.stationStreet.Location = new System.Drawing.Point(302, 238);
            this.stationStreet.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.stationStreet.Name = "stationStreet";
            this.stationStreet.Size = new System.Drawing.Size(185, 26);
            this.stationStreet.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(1305, 61);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "תמונה";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(878, 61);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(405, 450);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(711, 86);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(160, 40);
            this.button1.TabIndex = 11;
            this.button1.Text = "...עיון";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.BrowsePictureClick);
            // 
            // stationPicture
            // 
            this.stationPicture.Location = new System.Drawing.Point(611, 165);
            this.stationPicture.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.stationPicture.Name = "stationPicture";
            this.stationPicture.Size = new System.Drawing.Size(259, 26);
            this.stationPicture.TabIndex = 12;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(56, 208);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(189, 89);
            this.button2.TabIndex = 13;
            this.button2.Text = "הוסף";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.AddButtonClick);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
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
            this.dataGridView1.Location = new System.Drawing.Point(56, 320);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(732, 204);
            this.dataGridView1.TabIndex = 14;
            // 
            // stationIDDataGridViewTextBoxColumn
            // 
            this.stationIDDataGridViewTextBoxColumn.DataPropertyName = "stationID";
            this.stationIDDataGridViewTextBoxColumn.HeaderText = "מספר מזהה תחנה";
            this.stationIDDataGridViewTextBoxColumn.Name = "stationIDDataGridViewTextBoxColumn";
            // 
            // stationNameDataGridViewTextBoxColumn
            // 
            this.stationNameDataGridViewTextBoxColumn.DataPropertyName = "stationName";
            this.stationNameDataGridViewTextBoxColumn.HeaderText = "שם תחנה";
            this.stationNameDataGridViewTextBoxColumn.Name = "stationNameDataGridViewTextBoxColumn";
            // 
            // stationLocationDataGridViewTextBoxColumn
            // 
            this.stationLocationDataGridViewTextBoxColumn.DataPropertyName = "stationLocation";
            this.stationLocationDataGridViewTextBoxColumn.HeaderText = "יישוב";
            this.stationLocationDataGridViewTextBoxColumn.Name = "stationLocationDataGridViewTextBoxColumn";
            // 
            // stationStreetDataGridViewTextBoxColumn
            // 
            this.stationStreetDataGridViewTextBoxColumn.DataPropertyName = "stationStreet";
            this.stationStreetDataGridViewTextBoxColumn.HeaderText = "רחוב";
            this.stationStreetDataGridViewTextBoxColumn.Name = "stationStreetDataGridViewTextBoxColumn";
            // 
            // stationPictureDataGridViewTextBoxColumn
            // 
            this.stationPictureDataGridViewTextBoxColumn.DataPropertyName = "stationPicture";
            this.stationPictureDataGridViewTextBoxColumn.HeaderText = "תמונה";
            this.stationPictureDataGridViewTextBoxColumn.Name = "stationPictureDataGridViewTextBoxColumn";
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
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(542, 116);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 20);
            this.label5.TabIndex = 15;
            this.label5.Text = "שם תחנה";
            // 
            // stationName
            // 
            this.stationName.Location = new System.Drawing.Point(335, 114);
            this.stationName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.stationName.Name = "stationName";
            this.stationName.Size = new System.Drawing.Size(185, 26);
            this.stationName.TabIndex = 16;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label6.Location = new System.Drawing.Point(696, 296);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(92, 20);
            this.label6.TabIndex = 17;
            this.label6.Text = "טבלת תחנות";
            // 
            // FormAddStations
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.ClientSize = new System.Drawing.Size(1390, 564);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.stationName);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.stationPicture);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.stationStreet);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.stationLocation);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FormAddStations";
            this.Text = "FormAddStations";
            this.Load += new System.EventHandler(this.FormAddStations_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblStationsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetStations)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox stationLocation;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox stationStreet;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox stationPicture;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private DataSetStations dataSetStations;
        private System.Windows.Forms.BindingSource tblStationsBindingSource;
        private DataSetStationsTableAdapters.tblStationsTableAdapter tblStationsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn stationIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stationNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stationLocationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stationStreetDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stationPictureDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox stationName;
        private System.Windows.Forms.Label label6;
    }
}