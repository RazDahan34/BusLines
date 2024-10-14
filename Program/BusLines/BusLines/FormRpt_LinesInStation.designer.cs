namespace BusLines
{
    partial class FormRpt_LinesInStation
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
            this.label3 = new System.Windows.Forms.Label();
            this.stationStreet = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.stationPicture = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.label5 = new System.Windows.Forms.Label();
            this.stationID = new System.Windows.Forms.TextBox();
            this.buttonFirst = new System.Windows.Forms.Button();
            this.buttonPrev = new System.Windows.Forms.Button();
            this.buttonLast = new System.Windows.Forms.Button();
            this.buttonNext = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.stationIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stationNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stationLocationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stationStreetDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stationPictureDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblStationsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetStations = new BusLines.DataSetStations();
            this.label6 = new System.Windows.Forms.Label();
            this.stationName = new System.Windows.Forms.TextBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tblStationsTableAdapter = new BusLines.DataSetStationsTableAdapters.tblStationsTableAdapter();
            this.stationLocation = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
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
            this.label2.Location = new System.Drawing.Point(407, 24);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 32);
            this.label2.TabIndex = 4;
            this.label2.Text = "דו\"ח תחנה";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(523, 171);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "יישוב";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(260, 171);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "רחוב";
            // 
            // stationStreet
            // 
            this.stationStreet.Location = new System.Drawing.Point(55, 168);
            this.stationStreet.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.stationStreet.Name = "stationStreet";
            this.stationStreet.Size = new System.Drawing.Size(185, 26);
            this.stationStreet.TabIndex = 8;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(990, 41);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(405, 450);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // stationPicture
            // 
            this.stationPicture.Location = new System.Drawing.Point(713, 142);
            this.stationPicture.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.stationPicture.Name = "stationPicture";
            this.stationPicture.Size = new System.Drawing.Size(259, 26);
            this.stationPicture.TabIndex = 12;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(341, 482);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(189, 69);
            this.button2.TabIndex = 13;
            this.button2.Text = "הצג";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.ShowClick);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(537, 99);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(122, 20);
            this.label5.TabIndex = 15;
            this.label5.Text = "מספר מזהה תחנה";
            // 
            // stationID
            // 
            this.stationID.Location = new System.Drawing.Point(350, 95);
            this.stationID.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.stationID.Name = "stationID";
            this.stationID.Size = new System.Drawing.Size(180, 26);
            this.stationID.TabIndex = 16;
            // 
            // buttonFirst
            // 
            this.buttonFirst.Location = new System.Drawing.Point(677, 499);
            this.buttonFirst.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonFirst.Name = "buttonFirst";
            this.buttonFirst.Size = new System.Drawing.Size(84, 52);
            this.buttonFirst.TabIndex = 17;
            this.buttonFirst.Text = "ראשון";
            this.buttonFirst.UseVisualStyleBackColor = true;
            this.buttonFirst.Click += new System.EventHandler(this.buttonFirst_Click);
            // 
            // buttonPrev
            // 
            this.buttonPrev.Location = new System.Drawing.Point(215, 499);
            this.buttonPrev.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonPrev.Name = "buttonPrev";
            this.buttonPrev.Size = new System.Drawing.Size(84, 52);
            this.buttonPrev.TabIndex = 18;
            this.buttonPrev.Text = "הקודם";
            this.buttonPrev.UseVisualStyleBackColor = true;
            this.buttonPrev.Click += new System.EventHandler(this.buttonPrev_Click);
            // 
            // buttonLast
            // 
            this.buttonLast.Location = new System.Drawing.Point(101, 499);
            this.buttonLast.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonLast.Name = "buttonLast";
            this.buttonLast.Size = new System.Drawing.Size(84, 52);
            this.buttonLast.TabIndex = 19;
            this.buttonLast.Text = "אחרון";
            this.buttonLast.UseVisualStyleBackColor = true;
            this.buttonLast.Click += new System.EventHandler(this.buttonLast_Click);
            // 
            // buttonNext
            // 
            this.buttonNext.Location = new System.Drawing.Point(570, 499);
            this.buttonNext.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonNext.Name = "buttonNext";
            this.buttonNext.Size = new System.Drawing.Size(84, 52);
            this.buttonNext.TabIndex = 20;
            this.buttonNext.Text = "הבא";
            this.buttonNext.UseVisualStyleBackColor = true;
            this.buttonNext.Click += new System.EventHandler(this.buttonNext_Click);
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
            this.dataGridView1.Location = new System.Drawing.Point(101, 577);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(877, 188);
            this.dataGridView1.TabIndex = 21;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
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
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(260, 95);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 20);
            this.label6.TabIndex = 22;
            this.label6.Text = "שם תחנה";
            // 
            // stationName
            // 
            this.stationName.Location = new System.Drawing.Point(55, 92);
            this.stationName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.stationName.Name = "stationName";
            this.stationName.Size = new System.Drawing.Size(185, 26);
            this.stationName.TabIndex = 23;
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7});
            this.listView1.Location = new System.Drawing.Point(14, 252);
            this.listView1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.listView1.Name = "listView1";
            this.listView1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.listView1.RightToLeftLayout = true;
            this.listView1.ShowItemToolTips = true;
            this.listView1.Size = new System.Drawing.Size(959, 205);
            this.listView1.TabIndex = 24;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "מספר קו";
            this.columnHeader1.Width = 73;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "מספר תחנה";
            this.columnHeader2.Width = 99;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "חברה";
            this.columnHeader3.Width = 100;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "שם תחנת מקור";
            this.columnHeader4.Width = 140;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "כתובת תחנת מקור";
            this.columnHeader5.Width = 140;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "שם תחנת יעד";
            this.columnHeader6.Width = 140;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "כתובת תחנת יעד";
            this.columnHeader7.Width = 180;
            // 
            // tblStationsTableAdapter
            // 
            this.tblStationsTableAdapter.ClearBeforeFill = true;
            // 
            // stationLocation
            // 
            this.stationLocation.Location = new System.Drawing.Point(350, 168);
            this.stationLocation.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.stationLocation.Name = "stationLocation";
            this.stationLocation.Size = new System.Drawing.Size(147, 26);
            this.stationLocation.TabIndex = 25;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(879, 95);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 20);
            this.label4.TabIndex = 26;
            this.label4.Text = ":כתובת תמונה";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(840, 499);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(133, 52);
            this.button1.TabIndex = 27;
            this.button1.Text = "נקה";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.ClearColumns);
            // 
            // FormRpt_LinesInStation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1459, 821);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.stationLocation);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.stationName);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.buttonNext);
            this.Controls.Add(this.buttonLast);
            this.Controls.Add(this.buttonPrev);
            this.Controls.Add(this.buttonFirst);
            this.Controls.Add(this.stationID);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.stationPicture);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.stationStreet);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FormRpt_LinesInStation";
            this.Text = "FormRpt_LinesInStation";
            this.Load += new System.EventHandler(this.FormUpdateStations_Load);
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
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox stationStreet;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox stationPicture;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox stationID;
        private System.Windows.Forms.Button buttonFirst;
        private System.Windows.Forms.Button buttonPrev;
        private System.Windows.Forms.Button buttonLast;
        private System.Windows.Forms.Button buttonNext;
        private System.Windows.Forms.DataGridView dataGridView1;
        private DataSetStations dataSetStations;
        private System.Windows.Forms.BindingSource tblStationsBindingSource;
        private DataSetStationsTableAdapters.tblStationsTableAdapter tblStationsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn stationIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stationNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stationLocationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stationStreetDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stationPictureDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox stationName;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.TextBox stationLocation;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
    }
}