namespace BusLines
{
    partial class FormRptLineStations
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
            this.lineNum = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lineNumStations = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.lineMinutes = new System.Windows.Forms.TextBox();
            this.buttonShow = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lineIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lineNumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lineCompanyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lineFromStationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lineToStationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lineNumStationsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lineMinutesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblLinesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetLines = new BusLines.DataSetLines();
            this.label8 = new System.Windows.Forms.Label();
            this.lineID = new System.Windows.Forms.TextBox();
            this.buttonFirst = new System.Windows.Forms.Button();
            this.buttonNext = new System.Windows.Forms.Button();
            this.buttonPrev = new System.Windows.Forms.Button();
            this.buttonLast = new System.Windows.Forms.Button();
            this.lineFromStationCity = new System.Windows.Forms.TextBox();
            this.lineFromStationAddress = new System.Windows.Forms.TextBox();
            this.lineCompany = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lineToStationCity = new System.Windows.Forms.TextBox();
            this.lineToStationAddress = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.lineFromStationPicture = new System.Windows.Forms.TextBox();
            this.lineToStationPicture = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.lineFromStationName = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.lineToStationName = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.lineFromStationID = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.lineToStationID = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.tblLinesTableAdapter = new BusLines.DataSetLinesTableAdapters.tblLinesTableAdapter();
            this.label19 = new System.Windows.Forms.Label();
            this.lngRow = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.pictureSize = new System.Windows.Forms.ComboBox();
            this.label21 = new System.Windows.Forms.Label();
            this.dayDate = new System.Windows.Forms.DateTimePicker();
            this.label22 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblLinesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetLines)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label2.Location = new System.Drawing.Point(389, 24);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 32);
            this.label2.TabIndex = 3;
            this.label2.Text = "מסלול קו";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(603, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "מספר קו";
            // 
            // lineNum
            // 
            this.lineNum.Location = new System.Drawing.Point(433, 95);
            this.lineNum.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lineNum.Name = "lineNum";
            this.lineNum.Size = new System.Drawing.Size(137, 26);
            this.lineNum.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(308, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "חברה";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(852, 308);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(117, 20);
            this.label6.TabIndex = 12;
            this.label6.Text = "מספר תחנות בקו";
            // 
            // lineNumStations
            // 
            this.lineNumStations.Location = new System.Drawing.Point(722, 304);
            this.lineNumStations.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lineNumStations.Name = "lineNumStations";
            this.lineNumStations.Size = new System.Drawing.Size(119, 26);
            this.lineNumStations.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(571, 308);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(121, 20);
            this.label7.TabIndex = 14;
            this.label7.Text = "זמן נסיעה בדקות";
            // 
            // lineMinutes
            // 
            this.lineMinutes.Location = new System.Drawing.Point(413, 306);
            this.lineMinutes.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lineMinutes.Name = "lineMinutes";
            this.lineMinutes.Size = new System.Drawing.Size(140, 26);
            this.lineMinutes.TabIndex = 15;
            // 
            // buttonShow
            // 
            this.buttonShow.Location = new System.Drawing.Point(489, 389);
            this.buttonShow.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonShow.Name = "buttonShow";
            this.buttonShow.Size = new System.Drawing.Size(136, 56);
            this.buttonShow.TabIndex = 16;
            this.buttonShow.Text = "הצג מסלול";
            this.buttonShow.UseVisualStyleBackColor = true;
            this.buttonShow.Click += new System.EventHandler(this.ButtonShow_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.lineIDDataGridViewTextBoxColumn,
            this.lineNumDataGridViewTextBoxColumn,
            this.lineCompanyDataGridViewTextBoxColumn,
            this.lineFromStationDataGridViewTextBoxColumn,
            this.lineToStationDataGridViewTextBoxColumn,
            this.lineNumStationsDataGridViewTextBoxColumn,
            this.lineMinutesDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tblLinesBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(86, 504);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(892, 201);
            this.dataGridView1.TabIndex = 17;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
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
            // tblLinesBindingSource
            // 
            this.tblLinesBindingSource.DataMember = "tblLines";
            this.tblLinesBindingSource.DataSource = this.dataSetLines;
            // 
            // dataSetLines
            // 
            this.dataSetLines.DataSetName = "DataSetLines";
            this.dataSetLines.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(865, 96);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(101, 20);
            this.label8.TabIndex = 18;
            this.label8.Text = "מספר מזהה קו";
            // 
            // lineID
            // 
            this.lineID.Location = new System.Drawing.Point(708, 92);
            this.lineID.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lineID.Name = "lineID";
            this.lineID.Size = new System.Drawing.Size(133, 26);
            this.lineID.TabIndex = 19;
            // 
            // buttonFirst
            // 
            this.buttonFirst.Location = new System.Drawing.Point(278, 352);
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
            this.buttonNext.Location = new System.Drawing.Point(127, 352);
            this.buttonNext.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonNext.Name = "buttonNext";
            this.buttonNext.Size = new System.Drawing.Size(94, 46);
            this.buttonNext.TabIndex = 21;
            this.buttonNext.Text = "הבא";
            this.buttonNext.UseVisualStyleBackColor = true;
            this.buttonNext.Click += new System.EventHandler(this.buttonNext_Click);
            // 
            // buttonPrev
            // 
            this.buttonPrev.Location = new System.Drawing.Point(278, 423);
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
            this.buttonLast.Location = new System.Drawing.Point(127, 423);
            this.buttonLast.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonLast.Name = "buttonLast";
            this.buttonLast.Size = new System.Drawing.Size(94, 50);
            this.buttonLast.TabIndex = 23;
            this.buttonLast.Text = "אחרון";
            this.buttonLast.UseVisualStyleBackColor = true;
            this.buttonLast.Click += new System.EventHandler(this.buttonLast_Click);
            // 
            // lineFromStationCity
            // 
            this.lineFromStationCity.Location = new System.Drawing.Point(39, 162);
            this.lineFromStationCity.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lineFromStationCity.Name = "lineFromStationCity";
            this.lineFromStationCity.Size = new System.Drawing.Size(105, 26);
            this.lineFromStationCity.TabIndex = 24;
            // 
            // lineFromStationAddress
            // 
            this.lineFromStationAddress.Location = new System.Drawing.Point(214, 165);
            this.lineFromStationAddress.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lineFromStationAddress.Name = "lineFromStationAddress";
            this.lineFromStationAddress.Size = new System.Drawing.Size(231, 26);
            this.lineFromStationAddress.TabIndex = 25;
            // 
            // lineCompany
            // 
            this.lineCompany.Location = new System.Drawing.Point(112, 95);
            this.lineCompany.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lineCompany.Name = "lineCompany";
            this.lineCompany.Size = new System.Drawing.Size(166, 26);
            this.lineCompany.TabIndex = 26;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(152, 169);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 20);
            this.label5.TabIndex = 27;
            this.label5.Text = "יישוב";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(452, 171);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 20);
            this.label4.TabIndex = 28;
            this.label4.Text = "כתובת ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(152, 230);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(44, 20);
            this.label9.TabIndex = 29;
            this.label9.Text = "יישוב";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(452, 230);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(51, 20);
            this.label10.TabIndex = 30;
            this.label10.Text = "כתובת";
            // 
            // lineToStationCity
            // 
            this.lineToStationCity.Location = new System.Drawing.Point(39, 229);
            this.lineToStationCity.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lineToStationCity.Name = "lineToStationCity";
            this.lineToStationCity.Size = new System.Drawing.Size(105, 26);
            this.lineToStationCity.TabIndex = 31;
            // 
            // lineToStationAddress
            // 
            this.lineToStationAddress.Location = new System.Drawing.Point(214, 229);
            this.lineToStationAddress.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lineToStationAddress.Name = "lineToStationAddress";
            this.lineToStationAddress.Size = new System.Drawing.Size(231, 26);
            this.lineToStationAddress.TabIndex = 32;
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
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(1347, 389);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(117, 20);
            this.label12.TabIndex = 34;
            this.label12.Text = "תמונה תחנת יעד";
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
            this.pictureBox1.Size = new System.Drawing.Size(477, 216);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 35;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(1064, 434);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(477, 226);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 36;
            this.pictureBox2.TabStop = false;
            // 
            // lineFromStationPicture
            // 
            this.lineFromStationPicture.Location = new System.Drawing.Point(1064, 95);
            this.lineFromStationPicture.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lineFromStationPicture.Name = "lineFromStationPicture";
            this.lineFromStationPicture.Size = new System.Drawing.Size(228, 26);
            this.lineFromStationPicture.TabIndex = 39;
            // 
            // lineToStationPicture
            // 
            this.lineToStationPicture.Location = new System.Drawing.Point(1064, 382);
            this.lineToStationPicture.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lineToStationPicture.Name = "lineToStationPicture";
            this.lineToStationPicture.Size = new System.Drawing.Size(228, 26);
            this.lineToStationPicture.TabIndex = 40;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label13.Location = new System.Drawing.Point(909, 171);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(96, 20);
            this.label13.TabIndex = 41;
            this.label13.Text = "תחנת מקור:";
            // 
            // lineFromStationName
            // 
            this.lineFromStationName.Location = new System.Drawing.Point(529, 165);
            this.lineFromStationName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lineFromStationName.Name = "lineFromStationName";
            this.lineFromStationName.Size = new System.Drawing.Size(168, 26);
            this.lineFromStationName.TabIndex = 42;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label14.Location = new System.Drawing.Point(919, 226);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(86, 20);
            this.label14.TabIndex = 43;
            this.label14.Text = "תחנת יעד:";
            // 
            // lineToStationName
            // 
            this.lineToStationName.Location = new System.Drawing.Point(529, 226);
            this.lineToStationName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lineToStationName.Name = "lineToStationName";
            this.lineToStationName.Size = new System.Drawing.Size(168, 26);
            this.lineToStationName.TabIndex = 44;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(704, 171);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(29, 20);
            this.label15.TabIndex = 45;
            this.label15.Text = "שם";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(846, 171);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(45, 20);
            this.label16.TabIndex = 46;
            this.label16.Text = "מספר";
            // 
            // lineFromStationID
            // 
            this.lineFromStationID.Location = new System.Drawing.Point(752, 169);
            this.lineFromStationID.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lineFromStationID.Name = "lineFromStationID";
            this.lineFromStationID.Size = new System.Drawing.Size(79, 26);
            this.lineFromStationID.TabIndex = 47;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(846, 230);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(45, 20);
            this.label17.TabIndex = 48;
            this.label17.Text = "מספר";
            // 
            // lineToStationID
            // 
            this.lineToStationID.Location = new System.Drawing.Point(752, 226);
            this.lineToStationID.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lineToStationID.Name = "lineToStationID";
            this.lineToStationID.Size = new System.Drawing.Size(79, 26);
            this.lineToStationID.TabIndex = 49;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(704, 230);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(29, 20);
            this.label18.TabIndex = 50;
            this.label18.Text = "שם";
            // 
            // tblLinesTableAdapter
            // 
            this.tblLinesTableAdapter.ClearBeforeFill = true;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(752, 385);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(142, 20);
            this.label19.TabIndex = 51;
            this.label19.Text = "מספר תמונות בשורה";
            // 
            // lngRow
            // 
            this.lngRow.Location = new System.Drawing.Point(684, 382);
            this.lngRow.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lngRow.Name = "lngRow";
            this.lngRow.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lngRow.Size = new System.Drawing.Size(48, 26);
            this.lngRow.TabIndex = 52;
            this.lngRow.Text = "6";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(814, 437);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(83, 20);
            this.label20.TabIndex = 53;
            this.label20.Text = "גודל תמונה";
            // 
            // pictureSize
            // 
            this.pictureSize.FormattingEnabled = true;
            this.pictureSize.Location = new System.Drawing.Point(684, 434);
            this.pictureSize.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureSize.Name = "pictureSize";
            this.pictureSize.Size = new System.Drawing.Size(109, 28);
            this.pictureSize.TabIndex = 54;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(320, 308);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(52, 20);
            this.label21.TabIndex = 55;
            this.label21.Text = "תאריך";
            // 
            // dayDate
            // 
            this.dayDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dayDate.Location = new System.Drawing.Point(103, 304);
            this.dayDate.Name = "dayDate";
            this.dayDate.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dayDate.Size = new System.Drawing.Size(200, 26);
            this.dayDate.TabIndex = 56;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(898, 480);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(84, 20);
            this.label22.TabIndex = 57;
            this.label22.Text = "טבלת קווים";
            // 
            // FormRptLineStations
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lime;
            this.ClientSize = new System.Drawing.Size(1582, 726);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.dayDate);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.pictureSize);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.lngRow);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.lineToStationID);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.lineFromStationID);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.lineToStationName);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.lineFromStationName);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.lineToStationPicture);
            this.Controls.Add(this.lineFromStationPicture);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.lineToStationAddress);
            this.Controls.Add(this.lineToStationCity);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lineCompany);
            this.Controls.Add(this.lineFromStationAddress);
            this.Controls.Add(this.lineFromStationCity);
            this.Controls.Add(this.buttonLast);
            this.Controls.Add(this.buttonPrev);
            this.Controls.Add(this.buttonNext);
            this.Controls.Add(this.buttonFirst);
            this.Controls.Add(this.lineID);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.buttonShow);
            this.Controls.Add(this.lineMinutes);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lineNumStations);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lineNum);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FormRptLineStations";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Text = "FormRptLineStations";
            this.Load += new System.EventHandler(this.FormAddLines_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblLinesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetLines)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox lineNum;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox lineNumStations;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox lineMinutes;
        private System.Windows.Forms.Button buttonShow;
        private System.Windows.Forms.DataGridView dataGridView1;
        private DataSetLines dataSetLines;
        private System.Windows.Forms.BindingSource tblLinesBindingSource;
        private DataSetLinesTableAdapters.tblLinesTableAdapter tblLinesTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn lineIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lineNumDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lineCompanyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lineFromStationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lineToStationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lineNumStationsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lineMinutesDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox lineID;
        private System.Windows.Forms.Button buttonFirst;
        private System.Windows.Forms.Button buttonNext;
        private System.Windows.Forms.Button buttonPrev;
        private System.Windows.Forms.Button buttonLast;
        private System.Windows.Forms.TextBox lineFromStationCity;
        private System.Windows.Forms.TextBox lineFromStationAddress;
        private System.Windows.Forms.TextBox lineCompany;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox lineToStationCity;
        private System.Windows.Forms.TextBox lineToStationAddress;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox lineFromStationPicture;
        private System.Windows.Forms.TextBox lineToStationPicture;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox lineFromStationName;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox lineToStationName;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox lineFromStationID;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox lineToStationID;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox lngRow;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.ComboBox pictureSize;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.DateTimePicker dayDate;
        private System.Windows.Forms.Label label22;
    }
}