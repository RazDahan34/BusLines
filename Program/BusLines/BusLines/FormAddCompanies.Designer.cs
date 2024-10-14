namespace BusLines
{
    partial class FormAddCompanies
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
            this.button1 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.browsePicture = new System.Windows.Forms.Button();
            this.compPicture = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.color = new System.Windows.Forms.Button();
            this.changeColor = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblCompaniesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetCompanies)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label1.Location = new System.Drawing.Point(480, 23);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(171, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "הוספת חברה";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(994, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "שם חברה";
            // 
            // compName
            // 
            this.compName.Location = new System.Drawing.Point(835, 91);
            this.compName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.compName.Name = "compName";
            this.compName.Size = new System.Drawing.Size(136, 26);
            this.compName.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(722, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "כתובת";
            // 
            // compAddress
            // 
            this.compAddress.Location = new System.Drawing.Point(516, 91);
            this.compAddress.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.compAddress.Name = "compAddress";
            this.compAddress.Size = new System.Drawing.Size(181, 26);
            this.compAddress.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(423, 94);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "יישוב";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(1016, 160);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "טלפון";
            // 
            // compPhone
            // 
            this.compPhone.Location = new System.Drawing.Point(796, 157);
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
            this.compLocation.Location = new System.Drawing.Point(221, 91);
            this.compLocation.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.compLocation.Name = "compLocation";
            this.compLocation.Size = new System.Drawing.Size(150, 28);
            this.compLocation.TabIndex = 12;
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
            this.dataGridView1.Location = new System.Drawing.Point(57, 414);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(952, 252);
            this.dataGridView1.TabIndex = 13;
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
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(343, 300);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(161, 64);
            this.button1.TabIndex = 14;
            this.button1.Text = "הוסף";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.AddButtonClick);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(1015, 228);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 20);
            this.label7.TabIndex = 15;
            this.label7.Text = "תמונה";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(835, 228);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(142, 98);
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            // 
            // browsePicture
            // 
            this.browsePicture.Location = new System.Drawing.Point(713, 228);
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
            this.compPicture.Location = new System.Drawing.Point(576, 300);
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
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label8.Location = new System.Drawing.Point(915, 390);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(94, 20);
            this.label8.TabIndex = 21;
            this.label8.Text = "טבלת חברות";
            // 
            // FormAddCompanies
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.ClientSize = new System.Drawing.Size(1101, 681);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.changeColor);
            this.Controls.Add(this.color);
            this.Controls.Add(this.compPicture);
            this.Controls.Add(this.browsePicture);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
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
            this.Name = "FormAddCompanies";
            this.Text = "FormAddCompanies";
            this.Load += new System.EventHandler(this.FormAddCompanies_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblCompaniesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetCompanies)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button browsePicture;
        private System.Windows.Forms.TextBox compPicture;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button color;
        private System.Windows.Forms.Button changeColor;
        private System.Windows.Forms.Label label8;
    }
}