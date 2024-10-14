namespace BusLines
{
    partial class FormRptWayTwoBus
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.stationIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stationNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stationLocationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stationStreetDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stationPictureDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblStationsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetStations = new BusLines.DataSetStations();
            this.buttonFirst = new System.Windows.Forms.Button();
            this.buttonNext = new System.Windows.Forms.Button();
            this.buttonPrev = new System.Windows.Forms.Button();
            this.buttonLast = new System.Windows.Forms.Button();
            this.fromStationLocation = new System.Windows.Forms.TextBox();
            this.fromStationAddress = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.fromStationPicture = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.fromStationName = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.fromStationID = new System.Windows.Forms.TextBox();
            this.tblStationsTableAdapter = new BusLines.DataSetStationsTableAdapters.tblStationsTableAdapter();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.lineIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lineNumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lineCompanyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lineFromStationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lineToStationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lineNumStationsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lineMinutesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblTempLinesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetTempLines = new BusLines.DataSetTempLines();
            this.buttonFirst2 = new System.Windows.Forms.Button();
            this.buttonNext2 = new System.Windows.Forms.Button();
            this.buttonPrev2 = new System.Windows.Forms.Button();
            this.buttonLast2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tblStationsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tblTempLinesTableAdapter = new BusLines.DataSetTempLinesTableAdapters.tblTempLinesTableAdapter();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.button2 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblStationsBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetStations)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblTempLinesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetTempLines)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblStationsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label2.Location = new System.Drawing.Point(529, 24);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(470, 32);
            this.label2.TabIndex = 3;
            this.label2.Text = "ממקור ליעד באמצעות שני אוטובוסים";
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
            this.dataGridView1.DataSource = this.tblStationsBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(101, 235);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(892, 186);
            this.dataGridView1.TabIndex = 17;
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
            this.stationStreetDataGridViewTextBoxColumn.HeaderText = "כתובת";
            this.stationStreetDataGridViewTextBoxColumn.Name = "stationStreetDataGridViewTextBoxColumn";
            // 
            // stationPictureDataGridViewTextBoxColumn
            // 
            this.stationPictureDataGridViewTextBoxColumn.DataPropertyName = "stationPicture";
            this.stationPictureDataGridViewTextBoxColumn.HeaderText = "תמונה";
            this.stationPictureDataGridViewTextBoxColumn.Name = "stationPictureDataGridViewTextBoxColumn";
            // 
            // tblStationsBindingSource1
            // 
            this.tblStationsBindingSource1.DataMember = "tblStations";
            this.tblStationsBindingSource1.DataSource = this.dataSetStations;
            // 
            // dataSetStations
            // 
            this.dataSetStations.DataSetName = "DataSetStations";
            this.dataSetStations.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // buttonFirst
            // 
            this.buttonFirst.Location = new System.Drawing.Point(876, 161);
            this.buttonFirst.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonFirst.Name = "buttonFirst";
            this.buttonFirst.Size = new System.Drawing.Size(94, 46);
            this.buttonFirst.TabIndex = 20;
            this.buttonFirst.Text = "ראשון";
            this.buttonFirst.UseVisualStyleBackColor = true;
            this.buttonFirst.Click += new System.EventHandler(this.buttonFirst_Click);
            // 
            // buttonNext
            // 
            this.buttonNext.Location = new System.Drawing.Point(686, 161);
            this.buttonNext.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonNext.Name = "buttonNext";
            this.buttonNext.Size = new System.Drawing.Size(94, 48);
            this.buttonNext.TabIndex = 21;
            this.buttonNext.Text = "הבא";
            this.buttonNext.UseVisualStyleBackColor = true;
            this.buttonNext.Click += new System.EventHandler(this.buttonNext_Click);
            // 
            // buttonPrev
            // 
            this.buttonPrev.Location = new System.Drawing.Point(273, 161);
            this.buttonPrev.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonPrev.Name = "buttonPrev";
            this.buttonPrev.Size = new System.Drawing.Size(94, 50);
            this.buttonPrev.TabIndex = 22;
            this.buttonPrev.Text = "הקודם";
            this.buttonPrev.UseVisualStyleBackColor = true;
            this.buttonPrev.Click += new System.EventHandler(this.buttonPrev_Click);
            // 
            // buttonLast
            // 
            this.buttonLast.Location = new System.Drawing.Point(130, 161);
            this.buttonLast.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonLast.Name = "buttonLast";
            this.buttonLast.Size = new System.Drawing.Size(94, 50);
            this.buttonLast.TabIndex = 23;
            this.buttonLast.Text = "אחרון";
            this.buttonLast.UseVisualStyleBackColor = true;
            this.buttonLast.Click += new System.EventHandler(this.buttonLast_Click);
            // 
            // fromStationLocation
            // 
            this.fromStationLocation.Location = new System.Drawing.Point(39, 99);
            this.fromStationLocation.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.fromStationLocation.Name = "fromStationLocation";
            this.fromStationLocation.Size = new System.Drawing.Size(105, 26);
            this.fromStationLocation.TabIndex = 24;
            // 
            // fromStationAddress
            // 
            this.fromStationAddress.Location = new System.Drawing.Point(214, 99);
            this.fromStationAddress.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.fromStationAddress.Name = "fromStationAddress";
            this.fromStationAddress.Size = new System.Drawing.Size(231, 26);
            this.fromStationAddress.TabIndex = 25;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(156, 102);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 20);
            this.label5.TabIndex = 27;
            this.label5.Text = "יישוב";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(460, 102);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 20);
            this.label4.TabIndex = 28;
            this.label4.Text = "כתובת ";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(1328, 99);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(126, 20);
            this.label11.TabIndex = 33;
            this.label11.Text = "תמונה תחנת מקור";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(1064, 135);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(659, 255);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 35;
            this.pictureBox1.TabStop = false;
            // 
            // fromStationPicture
            // 
            this.fromStationPicture.Location = new System.Drawing.Point(1064, 95);
            this.fromStationPicture.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.fromStationPicture.Name = "fromStationPicture";
            this.fromStationPicture.Size = new System.Drawing.Size(228, 26);
            this.fromStationPicture.TabIndex = 39;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label13.Location = new System.Drawing.Point(909, 95);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(96, 20);
            this.label13.TabIndex = 41;
            this.label13.Text = "תחנת מקור:";
            // 
            // fromStationName
            // 
            this.fromStationName.Location = new System.Drawing.Point(529, 96);
            this.fromStationName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.fromStationName.Name = "fromStationName";
            this.fromStationName.Size = new System.Drawing.Size(168, 26);
            this.fromStationName.TabIndex = 42;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(704, 102);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(29, 20);
            this.label15.TabIndex = 45;
            this.label15.Text = "שם";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(849, 98);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(45, 20);
            this.label16.TabIndex = 46;
            this.label16.Text = "מספר";
            // 
            // fromStationID
            // 
            this.fromStationID.Location = new System.Drawing.Point(752, 95);
            this.fromStationID.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.fromStationID.Name = "fromStationID";
            this.fromStationID.Size = new System.Drawing.Size(79, 26);
            this.fromStationID.TabIndex = 47;
            // 
            // tblStationsTableAdapter
            // 
            this.tblStationsTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.lineIDDataGridViewTextBoxColumn,
            this.lineNumDataGridViewTextBoxColumn,
            this.lineCompanyDataGridViewTextBoxColumn,
            this.lineFromStationDataGridViewTextBoxColumn,
            this.lineToStationDataGridViewTextBoxColumn,
            this.lineNumStationsDataGridViewTextBoxColumn,
            this.lineMinutesDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.tblTempLinesBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(205, 549);
            this.dataGridView2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowTemplate.Height = 28;
            this.dataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView2.Size = new System.Drawing.Size(788, 174);
            this.dataGridView2.TabIndex = 51;
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // lineIDDataGridViewTextBoxColumn
            // 
            this.lineIDDataGridViewTextBoxColumn.DataPropertyName = "lineID";
            this.lineIDDataGridViewTextBoxColumn.HeaderText = "מספר מזהה קו";
            this.lineIDDataGridViewTextBoxColumn.Name = "lineIDDataGridViewTextBoxColumn";
            // 
            // lineNumDataGridViewTextBoxColumn
            // 
            this.lineNumDataGridViewTextBoxColumn.DataPropertyName = "lineNum";
            this.lineNumDataGridViewTextBoxColumn.HeaderText = "מספר קו";
            this.lineNumDataGridViewTextBoxColumn.Name = "lineNumDataGridViewTextBoxColumn";
            // 
            // lineCompanyDataGridViewTextBoxColumn
            // 
            this.lineCompanyDataGridViewTextBoxColumn.DataPropertyName = "lineCompany";
            this.lineCompanyDataGridViewTextBoxColumn.HeaderText = "חברה";
            this.lineCompanyDataGridViewTextBoxColumn.Name = "lineCompanyDataGridViewTextBoxColumn";
            // 
            // lineFromStationDataGridViewTextBoxColumn
            // 
            this.lineFromStationDataGridViewTextBoxColumn.DataPropertyName = "lineFromStation";
            this.lineFromStationDataGridViewTextBoxColumn.HeaderText = "תחנת מקור";
            this.lineFromStationDataGridViewTextBoxColumn.Name = "lineFromStationDataGridViewTextBoxColumn";
            // 
            // lineToStationDataGridViewTextBoxColumn
            // 
            this.lineToStationDataGridViewTextBoxColumn.DataPropertyName = "lineToStation";
            this.lineToStationDataGridViewTextBoxColumn.HeaderText = "תחנת יעד";
            this.lineToStationDataGridViewTextBoxColumn.Name = "lineToStationDataGridViewTextBoxColumn";
            // 
            // lineNumStationsDataGridViewTextBoxColumn
            // 
            this.lineNumStationsDataGridViewTextBoxColumn.DataPropertyName = "lineNumStations";
            this.lineNumStationsDataGridViewTextBoxColumn.HeaderText = "מספר תחנות בקו";
            this.lineNumStationsDataGridViewTextBoxColumn.Name = "lineNumStationsDataGridViewTextBoxColumn";
            // 
            // lineMinutesDataGridViewTextBoxColumn
            // 
            this.lineMinutesDataGridViewTextBoxColumn.DataPropertyName = "lineMinutes";
            this.lineMinutesDataGridViewTextBoxColumn.HeaderText = "זמן נסיעה בדקות";
            this.lineMinutesDataGridViewTextBoxColumn.Name = "lineMinutesDataGridViewTextBoxColumn";
            // 
            // tblTempLinesBindingSource
            // 
            this.tblTempLinesBindingSource.DataMember = "tblTempLines";
            this.tblTempLinesBindingSource.DataSource = this.dataSetTempLines;
            // 
            // dataSetTempLines
            // 
            this.dataSetTempLines.DataSetName = "DataSetTempLines";
            this.dataSetTempLines.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // buttonFirst2
            // 
            this.buttonFirst2.Location = new System.Drawing.Point(876, 470);
            this.buttonFirst2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonFirst2.Name = "buttonFirst2";
            this.buttonFirst2.Size = new System.Drawing.Size(94, 48);
            this.buttonFirst2.TabIndex = 52;
            this.buttonFirst2.Text = "ראשון";
            this.buttonFirst2.UseVisualStyleBackColor = true;
            this.buttonFirst2.Click += new System.EventHandler(this.buttonFirst2_Click);
            // 
            // buttonNext2
            // 
            this.buttonNext2.Location = new System.Drawing.Point(635, 470);
            this.buttonNext2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonNext2.Name = "buttonNext2";
            this.buttonNext2.Size = new System.Drawing.Size(94, 48);
            this.buttonNext2.TabIndex = 53;
            this.buttonNext2.Text = "הבא";
            this.buttonNext2.UseVisualStyleBackColor = true;
            this.buttonNext2.Click += new System.EventHandler(this.buttonNext2_Click);
            // 
            // buttonPrev2
            // 
            this.buttonPrev2.Location = new System.Drawing.Point(273, 468);
            this.buttonPrev2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonPrev2.Name = "buttonPrev2";
            this.buttonPrev2.Size = new System.Drawing.Size(94, 50);
            this.buttonPrev2.TabIndex = 54;
            this.buttonPrev2.Text = "הקודם";
            this.buttonPrev2.UseVisualStyleBackColor = true;
            this.buttonPrev2.Click += new System.EventHandler(this.buttonPrev2_Click);
            // 
            // buttonLast2
            // 
            this.buttonLast2.Location = new System.Drawing.Point(130, 468);
            this.buttonLast2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonLast2.Name = "buttonLast2";
            this.buttonLast2.Size = new System.Drawing.Size(94, 50);
            this.buttonLast2.TabIndex = 55;
            this.buttonLast2.Text = "אחרון";
            this.buttonLast2.UseVisualStyleBackColor = true;
            this.buttonLast2.Click += new System.EventHandler(this.buttonLast2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(115, 549);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(84, 174);
            this.button1.TabIndex = 56;
            this.button1.Text = "נקה";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.buttonLines_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label1.Location = new System.Drawing.Point(460, 170);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "בחר תחנת מקור:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label3.Location = new System.Drawing.Point(481, 479);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 25);
            this.label3.TabIndex = 57;
            this.label3.Text = "בחר קו (שני):";
            // 
            // tblStationsBindingSource
            // 
            this.tblStationsBindingSource.DataMember = "tblStations";
            this.tblStationsBindingSource.DataSource = this.dataSetStations;
            // 
            // tblTempLinesTableAdapter
            // 
            this.tblTempLinesTableAdapter.ClearBeforeFill = true;
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7});
            this.listView1.Location = new System.Drawing.Point(1045, 484);
            this.listView1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.listView1.Name = "listView1";
            this.listView1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.listView1.RightToLeftLayout = true;
            this.listView1.ShowItemToolTips = true;
            this.listView1.Size = new System.Drawing.Size(686, 295);
            this.listView1.TabIndex = 62;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "מזהה תחנה";
            this.columnHeader1.Width = 63;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "שם תחנה";
            this.columnHeader3.Width = 99;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "יישוב";
            this.columnHeader4.Width = 123;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "כתובת";
            this.columnHeader5.Width = 155;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "זמן נסיעה (בד\')";
            this.columnHeader6.Width = 123;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "סוג תחנה";
            this.columnHeader7.Width = 114;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(1134, 418);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(192, 54);
            this.button2.TabIndex = 63;
            this.button2.Text = "הצג תמונות";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.showPictures_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label6.Location = new System.Drawing.Point(1390, 431);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(158, 25);
            this.label6.TabIndex = 64;
            this.label6.Text = "תחנות הקו שבחרת:";
            // 
            // FormRptWayTwoBus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Yellow;
            this.ClientSize = new System.Drawing.Size(1753, 794);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttonLast2);
            this.Controls.Add(this.buttonPrev2);
            this.Controls.Add(this.buttonNext2);
            this.Controls.Add(this.buttonFirst2);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.fromStationID);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.fromStationName);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.fromStationPicture);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.fromStationAddress);
            this.Controls.Add(this.fromStationLocation);
            this.Controls.Add(this.buttonLast);
            this.Controls.Add(this.buttonPrev);
            this.Controls.Add(this.buttonNext);
            this.Controls.Add(this.buttonFirst);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label2);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FormRptWayTwoBus";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Text = "FormRptWayTwoBus";
            this.Load += new System.EventHandler(this.FormAddLines_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblStationsBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetStations)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblTempLinesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetTempLines)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblStationsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button buttonFirst;
        private System.Windows.Forms.Button buttonNext;
        private System.Windows.Forms.Button buttonPrev;
        private System.Windows.Forms.Button buttonLast;
        private System.Windows.Forms.TextBox fromStationLocation;
        private System.Windows.Forms.TextBox fromStationAddress;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox fromStationPicture;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox fromStationName;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox fromStationID;
        private DataSetStations dataSetStations;
        private DataSetStationsTableAdapters.tblStationsTableAdapter tblStationsTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button buttonFirst2;
        private System.Windows.Forms.Button buttonNext2;
        private System.Windows.Forms.Button buttonPrev2;
        private System.Windows.Forms.Button buttonLast2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn stationIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stationNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stationLocationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stationStreetDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stationPictureDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource tblStationsBindingSource;
        private DataSetTempLines dataSetTempLines;
        private System.Windows.Forms.BindingSource tblTempLinesBindingSource;
        private DataSetTempLinesTableAdapters.tblTempLinesTableAdapter tblTempLinesTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn lineIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lineNumDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lineCompanyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lineFromStationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lineToStationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lineNumStationsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lineMinutesDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource tblStationsBindingSource1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label6;
    }
}