namespace BusLines
{
    partial class FormUpdateCompanies
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
            this.compName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.compAddress = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.compPhone = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.compColor = new System.Windows.Forms.TextBox();
            this.compLocation = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.browsePicture = new System.Windows.Forms.Button();
            this.compPicture = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.color = new System.Windows.Forms.Button();
            this.changeColor = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.compNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.compAddressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.compLocationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.compPhoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.compPictureDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.compColorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblCompaniesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetCompanies = new BusLines.DataSetCompanies();
            this.tblCompaniesTableAdapter = new BusLines.DataSetCompaniesTableAdapters.tblCompaniesTableAdapter();
            this.buttonFirst = new System.Windows.Forms.Button();
            this.buttonNext = new System.Windows.Forms.Button();
            this.buttonPrev = new System.Windows.Forms.Button();
            this.buttonLast = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblCompaniesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetCompanies)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label1.Location = new System.Drawing.Point(300, 25);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "עדכון חברה";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(745, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "שם חברה";
            // 
            // compName
            // 
            this.compName.Location = new System.Drawing.Point(585, 94);
            this.compName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.compName.Name = "compName";
            this.compName.Size = new System.Drawing.Size(136, 26);
            this.compName.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(480, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "כתובת";
            // 
            // compAddress
            // 
            this.compAddress.Location = new System.Drawing.Point(279, 94);
            this.compAddress.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.compAddress.Name = "compAddress";
            this.compAddress.Size = new System.Drawing.Size(181, 26);
            this.compAddress.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(209, 98);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "יישוב";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(767, 166);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "טלפון";
            // 
            // compPhone
            // 
            this.compPhone.Location = new System.Drawing.Point(564, 160);
            this.compPhone.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.compPhone.Name = "compPhone";
            this.compPhone.Size = new System.Drawing.Size(175, 26);
            this.compPhone.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(303, 160);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 20);
            this.label6.TabIndex = 10;
            this.label6.Text = "צבע";
            // 
            // compColor
            // 
            this.compColor.Location = new System.Drawing.Point(57, 299);
            this.compColor.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.compColor.Name = "compColor";
            this.compColor.Size = new System.Drawing.Size(193, 26);
            this.compColor.TabIndex = 11;
            // 
            // compLocation
            // 
            this.compLocation.FormattingEnabled = true;
            this.compLocation.Location = new System.Drawing.Point(29, 91);
            this.compLocation.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.compLocation.Name = "compLocation";
            this.compLocation.Size = new System.Drawing.Size(150, 28);
            this.compLocation.TabIndex = 12;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(306, 342);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(161, 64);
            this.button1.TabIndex = 14;
            this.button1.Text = "עדכן";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.UpdateButtonClick);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(766, 228);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 20);
            this.label7.TabIndex = 15;
            this.label7.Text = "תמונה";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(597, 228);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(142, 98);
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            // 
            // browsePicture
            // 
            this.browsePicture.Location = new System.Drawing.Point(465, 228);
            this.browsePicture.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.browsePicture.Name = "browsePicture";
            this.browsePicture.Size = new System.Drawing.Size(99, 49);
            this.browsePicture.TabIndex = 17;
            this.browsePicture.Text = "...עיון";
            this.browsePicture.UseVisualStyleBackColor = true;
            this.browsePicture.Click += new System.EventHandler(this.BrowsePictureClick);
            // 
            // compPicture
            // 
            this.compPicture.Location = new System.Drawing.Point(327, 299);
            this.compPicture.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.compPicture.Name = "compPicture";
            this.compPicture.Size = new System.Drawing.Size(236, 26);
            this.compPicture.TabIndex = 18;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // color
            // 
            this.color.Location = new System.Drawing.Point(43, 200);
            this.color.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.color.Name = "color";
            this.color.Size = new System.Drawing.Size(230, 76);
            this.color.TabIndex = 19;
            this.color.UseVisualStyleBackColor = true;
            // 
            // changeColor
            // 
            this.changeColor.Location = new System.Drawing.Point(43, 156);
            this.changeColor.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.changeColor.Name = "changeColor";
            this.changeColor.Size = new System.Drawing.Size(230, 29);
            this.changeColor.TabIndex = 20;
            this.changeColor.Text = "לחץ לשנות צבע";
            this.changeColor.UseVisualStyleBackColor = true;
            this.changeColor.Click += new System.EventHandler(this.ChangeColorClick);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.compNameDataGridViewTextBoxColumn,
            this.compAddressDataGridViewTextBoxColumn,
            this.compLocationDataGridViewTextBoxColumn,
            this.compPhoneDataGridViewTextBoxColumn,
            this.compPictureDataGridViewTextBoxColumn,
            this.compColorDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tblCompaniesBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(29, 454);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(783, 214);
            this.dataGridView1.TabIndex = 21;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // compNameDataGridViewTextBoxColumn
            // 
            this.compNameDataGridViewTextBoxColumn.DataPropertyName = "compName";
            this.compNameDataGridViewTextBoxColumn.HeaderText = "שם חברה";
            this.compNameDataGridViewTextBoxColumn.Name = "compNameDataGridViewTextBoxColumn";
            // 
            // compAddressDataGridViewTextBoxColumn
            // 
            this.compAddressDataGridViewTextBoxColumn.DataPropertyName = "compAddress";
            this.compAddressDataGridViewTextBoxColumn.HeaderText = "כתובת";
            this.compAddressDataGridViewTextBoxColumn.Name = "compAddressDataGridViewTextBoxColumn";
            // 
            // compLocationDataGridViewTextBoxColumn
            // 
            this.compLocationDataGridViewTextBoxColumn.DataPropertyName = "compLocation";
            this.compLocationDataGridViewTextBoxColumn.HeaderText = "יישוב";
            this.compLocationDataGridViewTextBoxColumn.Name = "compLocationDataGridViewTextBoxColumn";
            // 
            // compPhoneDataGridViewTextBoxColumn
            // 
            this.compPhoneDataGridViewTextBoxColumn.DataPropertyName = "compPhone";
            this.compPhoneDataGridViewTextBoxColumn.HeaderText = "טלפון";
            this.compPhoneDataGridViewTextBoxColumn.Name = "compPhoneDataGridViewTextBoxColumn";
            // 
            // compPictureDataGridViewTextBoxColumn
            // 
            this.compPictureDataGridViewTextBoxColumn.DataPropertyName = "compPicture";
            this.compPictureDataGridViewTextBoxColumn.HeaderText = "תמונה";
            this.compPictureDataGridViewTextBoxColumn.Name = "compPictureDataGridViewTextBoxColumn";
            // 
            // compColorDataGridViewTextBoxColumn
            // 
            this.compColorDataGridViewTextBoxColumn.DataPropertyName = "compColor";
            this.compColorDataGridViewTextBoxColumn.HeaderText = "צבע";
            this.compColorDataGridViewTextBoxColumn.Name = "compColorDataGridViewTextBoxColumn";
            // 
            // tblCompaniesBindingSource
            // 
            this.tblCompaniesBindingSource.DataMember = "tblCompanies";
            this.tblCompaniesBindingSource.DataSource = this.dataSetCompanies;
            // 
            // dataSetCompanies
            // 
            this.dataSetCompanies.DataSetName = "DataSetCompanies";
            this.dataSetCompanies.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblCompaniesTableAdapter
            // 
            this.tblCompaniesTableAdapter.ClearBeforeFill = true;
            // 
            // buttonFirst
            // 
            this.buttonFirst.Location = new System.Drawing.Point(655, 360);
            this.buttonFirst.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonFirst.Name = "buttonFirst";
            this.buttonFirst.Size = new System.Drawing.Size(84, 46);
            this.buttonFirst.TabIndex = 22;
            this.buttonFirst.Text = "ראשון";
            this.buttonFirst.UseVisualStyleBackColor = true;
            this.buttonFirst.Click += new System.EventHandler(this.buttonFirst_Click);
            // 
            // buttonNext
            // 
            this.buttonNext.Location = new System.Drawing.Point(519, 360);
            this.buttonNext.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonNext.Name = "buttonNext";
            this.buttonNext.Size = new System.Drawing.Size(84, 46);
            this.buttonNext.TabIndex = 23;
            this.buttonNext.Text = "הבא";
            this.buttonNext.UseVisualStyleBackColor = true;
            this.buttonNext.Click += new System.EventHandler(this.buttonNext_Click);
            // 
            // buttonPrev
            // 
            this.buttonPrev.Location = new System.Drawing.Point(166, 360);
            this.buttonPrev.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonPrev.Name = "buttonPrev";
            this.buttonPrev.Size = new System.Drawing.Size(84, 46);
            this.buttonPrev.TabIndex = 24;
            this.buttonPrev.Text = "הקודם";
            this.buttonPrev.UseVisualStyleBackColor = true;
            this.buttonPrev.Click += new System.EventHandler(this.buttonPrev_Click);
            // 
            // buttonLast
            // 
            this.buttonLast.Location = new System.Drawing.Point(43, 360);
            this.buttonLast.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonLast.Name = "buttonLast";
            this.buttonLast.Size = new System.Drawing.Size(84, 46);
            this.buttonLast.TabIndex = 25;
            this.buttonLast.Text = "אחרון";
            this.buttonLast.UseVisualStyleBackColor = true;
            this.buttonLast.Click += new System.EventHandler(this.buttonLast_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(718, 430);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(94, 20);
            this.label8.TabIndex = 26;
            this.label8.Text = "טבלת חברות";
            // 
            // FormUpdateCompanies
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Coral;
            this.ClientSize = new System.Drawing.Size(870, 681);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.buttonLast);
            this.Controls.Add(this.buttonPrev);
            this.Controls.Add(this.buttonNext);
            this.Controls.Add(this.buttonFirst);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.changeColor);
            this.Controls.Add(this.color);
            this.Controls.Add(this.compPicture);
            this.Controls.Add(this.browsePicture);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.compLocation);
            this.Controls.Add(this.compColor);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.compPhone);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.compAddress);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.compName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FormUpdateCompanies";
            this.Text = "FormAddCompanies";
            this.Load += new System.EventHandler(this.FormUpdateCompanies_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblCompaniesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetCompanies)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox compName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox compAddress;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox compPhone;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox compColor;
        private System.Windows.Forms.ComboBox compLocation;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button browsePicture;
        private System.Windows.Forms.TextBox compPicture;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button color;
        private System.Windows.Forms.Button changeColor;
        private System.Windows.Forms.DataGridView dataGridView1;
        private DataSetCompanies dataSetCompanies;
        private System.Windows.Forms.BindingSource tblCompaniesBindingSource;
        private DataSetCompaniesTableAdapters.tblCompaniesTableAdapter tblCompaniesTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn compNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn compAddressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn compLocationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn compPhoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn compPictureDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn compColorDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button buttonFirst;
        private System.Windows.Forms.Button buttonNext;
        private System.Windows.Forms.Button buttonPrev;
        private System.Windows.Forms.Button buttonLast;
        private System.Windows.Forms.Label label8;
    }
}