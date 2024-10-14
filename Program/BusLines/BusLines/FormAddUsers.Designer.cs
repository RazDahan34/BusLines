namespace BusLines
{
    partial class FormAddUsers
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
            this.userID = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.userFirstName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.userLastName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.userBirthDate = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.userAddress = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.userPhone = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.userMobile = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.userMail = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.userPassword = new System.Windows.Forms.TextBox();
            this.userIsManager = new System.Windows.Forms.CheckBox();
            this.userLocation = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.userIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userFirstNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userLastNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userBirthDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userAddressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userLocationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userPhoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userMobileDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userMailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userPasswordDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userIsManagerDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.tblUsersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetUsers = new BusLines.DataSetUsers();
            this.tblUsersTableAdapter = new BusLines.DataSetUsersTableAdapters.tblUsersTableAdapter();
            this.addButton = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblUsersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetUsers)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label1.Location = new System.Drawing.Point(570, 20);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(197, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "הוספת משתמש";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1177, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "ת\"ז";
            // 
            // userID
            // 
            this.userID.Location = new System.Drawing.Point(982, 78);
            this.userID.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.userID.Name = "userID";
            this.userID.Size = new System.Drawing.Size(138, 26);
            this.userID.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(839, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "שם פרטי";
            // 
            // userFirstName
            // 
            this.userFirstName.Location = new System.Drawing.Point(673, 78);
            this.userFirstName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.userFirstName.Name = "userFirstName";
            this.userFirstName.Size = new System.Drawing.Size(140, 26);
            this.userFirstName.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(560, 81);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "שם משפחה";
            // 
            // userLastName
            // 
            this.userLastName.Location = new System.Drawing.Point(367, 78);
            this.userLastName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.userLastName.Name = "userLastName";
            this.userLastName.Size = new System.Drawing.Size(155, 26);
            this.userLastName.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(240, 84);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 20);
            this.label5.TabIndex = 7;
            this.label5.Text = "תאריך לידה";
            // 
            // userBirthDate
            // 
            this.userBirthDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.userBirthDate.Location = new System.Drawing.Point(32, 78);
            this.userBirthDate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.userBirthDate.Name = "userBirthDate";
            this.userBirthDate.Size = new System.Drawing.Size(186, 26);
            this.userBirthDate.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(1157, 148);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 20);
            this.label6.TabIndex = 9;
            this.label6.Text = "כתובת";
            // 
            // userAddress
            // 
            this.userAddress.Location = new System.Drawing.Point(814, 148);
            this.userAddress.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.userAddress.Name = "userAddress";
            this.userAddress.Size = new System.Drawing.Size(306, 26);
            this.userAddress.TabIndex = 10;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(660, 154);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 20);
            this.label7.TabIndex = 11;
            this.label7.Text = "יישוב";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(273, 154);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(76, 20);
            this.label8.TabIndex = 13;
            this.label8.Text = "טלפון קווי";
            // 
            // userPhone
            // 
            this.userPhone.Location = new System.Drawing.Point(86, 151);
            this.userPhone.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.userPhone.Name = "userPhone";
            this.userPhone.Size = new System.Drawing.Size(155, 26);
            this.userPhone.TabIndex = 14;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(1122, 213);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(77, 20);
            this.label9.TabIndex = 15;
            this.label9.Text = "טלפון נייד";
            // 
            // userMobile
            // 
            this.userMobile.Location = new System.Drawing.Point(909, 213);
            this.userMobile.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.userMobile.Name = "userMobile";
            this.userMobile.Size = new System.Drawing.Size(189, 26);
            this.userMobile.TabIndex = 16;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(810, 216);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(38, 20);
            this.label10.TabIndex = 17;
            this.label10.Text = "מייל";
            // 
            // userMail
            // 
            this.userMail.Location = new System.Drawing.Point(526, 213);
            this.userMail.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.userMail.Name = "userMail";
            this.userMail.Size = new System.Drawing.Size(241, 26);
            this.userMail.TabIndex = 18;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(1147, 276);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(52, 20);
            this.label11.TabIndex = 19;
            this.label11.Text = "סיסמא";
            // 
            // userPassword
            // 
            this.userPassword.Location = new System.Drawing.Point(921, 278);
            this.userPassword.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.userPassword.Name = "userPassword";
            this.userPassword.Size = new System.Drawing.Size(177, 26);
            this.userPassword.TabIndex = 20;
            // 
            // userIsManager
            // 
            this.userIsManager.AutoSize = true;
            this.userIsManager.Location = new System.Drawing.Point(760, 280);
            this.userIsManager.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.userIsManager.Name = "userIsManager";
            this.userIsManager.Size = new System.Drawing.Size(69, 24);
            this.userIsManager.TabIndex = 22;
            this.userIsManager.Text = "מנהל";
            this.userIsManager.UseVisualStyleBackColor = true;
            // 
            // userLocation
            // 
            this.userLocation.FormattingEnabled = true;
            this.userLocation.Location = new System.Drawing.Point(397, 148);
            this.userLocation.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.userLocation.Name = "userLocation";
            this.userLocation.Size = new System.Drawing.Size(226, 28);
            this.userLocation.TabIndex = 23;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.userIDDataGridViewTextBoxColumn,
            this.userFirstNameDataGridViewTextBoxColumn,
            this.userLastNameDataGridViewTextBoxColumn,
            this.userBirthDateDataGridViewTextBoxColumn,
            this.userAddressDataGridViewTextBoxColumn,
            this.userLocationDataGridViewTextBoxColumn,
            this.userPhoneDataGridViewTextBoxColumn,
            this.userMobileDataGridViewTextBoxColumn,
            this.userMailDataGridViewTextBoxColumn,
            this.userPasswordDataGridViewTextBoxColumn,
            this.userIsManagerDataGridViewCheckBoxColumn});
            this.dataGridView1.DataSource = this.tblUsersBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(44, 346);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1164, 188);
            this.dataGridView1.TabIndex = 24;
            // 
            // userIDDataGridViewTextBoxColumn
            // 
            this.userIDDataGridViewTextBoxColumn.DataPropertyName = "userID";
            this.userIDDataGridViewTextBoxColumn.HeaderText = "ת\"ז";
            this.userIDDataGridViewTextBoxColumn.Name = "userIDDataGridViewTextBoxColumn";
            // 
            // userFirstNameDataGridViewTextBoxColumn
            // 
            this.userFirstNameDataGridViewTextBoxColumn.DataPropertyName = "userFirstName";
            this.userFirstNameDataGridViewTextBoxColumn.HeaderText = "שם פרטי";
            this.userFirstNameDataGridViewTextBoxColumn.Name = "userFirstNameDataGridViewTextBoxColumn";
            // 
            // userLastNameDataGridViewTextBoxColumn
            // 
            this.userLastNameDataGridViewTextBoxColumn.DataPropertyName = "userLastName";
            this.userLastNameDataGridViewTextBoxColumn.HeaderText = "שם משפחה";
            this.userLastNameDataGridViewTextBoxColumn.Name = "userLastNameDataGridViewTextBoxColumn";
            // 
            // userBirthDateDataGridViewTextBoxColumn
            // 
            this.userBirthDateDataGridViewTextBoxColumn.DataPropertyName = "userBirthDate";
            this.userBirthDateDataGridViewTextBoxColumn.HeaderText = "תאריך לידה";
            this.userBirthDateDataGridViewTextBoxColumn.Name = "userBirthDateDataGridViewTextBoxColumn";
            // 
            // userAddressDataGridViewTextBoxColumn
            // 
            this.userAddressDataGridViewTextBoxColumn.DataPropertyName = "userAddress";
            this.userAddressDataGridViewTextBoxColumn.HeaderText = "כתובת";
            this.userAddressDataGridViewTextBoxColumn.Name = "userAddressDataGridViewTextBoxColumn";
            // 
            // userLocationDataGridViewTextBoxColumn
            // 
            this.userLocationDataGridViewTextBoxColumn.DataPropertyName = "userLocation";
            this.userLocationDataGridViewTextBoxColumn.HeaderText = "יישוב";
            this.userLocationDataGridViewTextBoxColumn.Name = "userLocationDataGridViewTextBoxColumn";
            // 
            // userPhoneDataGridViewTextBoxColumn
            // 
            this.userPhoneDataGridViewTextBoxColumn.DataPropertyName = "userPhone";
            this.userPhoneDataGridViewTextBoxColumn.HeaderText = "טלפון קווי";
            this.userPhoneDataGridViewTextBoxColumn.Name = "userPhoneDataGridViewTextBoxColumn";
            // 
            // userMobileDataGridViewTextBoxColumn
            // 
            this.userMobileDataGridViewTextBoxColumn.DataPropertyName = "userMobile";
            this.userMobileDataGridViewTextBoxColumn.HeaderText = "טלפון נייד";
            this.userMobileDataGridViewTextBoxColumn.Name = "userMobileDataGridViewTextBoxColumn";
            // 
            // userMailDataGridViewTextBoxColumn
            // 
            this.userMailDataGridViewTextBoxColumn.DataPropertyName = "userMail";
            this.userMailDataGridViewTextBoxColumn.HeaderText = "מייל";
            this.userMailDataGridViewTextBoxColumn.Name = "userMailDataGridViewTextBoxColumn";
            // 
            // userPasswordDataGridViewTextBoxColumn
            // 
            this.userPasswordDataGridViewTextBoxColumn.DataPropertyName = "userPassword";
            this.userPasswordDataGridViewTextBoxColumn.HeaderText = "סיסמא";
            this.userPasswordDataGridViewTextBoxColumn.Name = "userPasswordDataGridViewTextBoxColumn";
            // 
            // userIsManagerDataGridViewCheckBoxColumn
            // 
            this.userIsManagerDataGridViewCheckBoxColumn.DataPropertyName = "userIsManager";
            this.userIsManagerDataGridViewCheckBoxColumn.HeaderText = "מנהל";
            this.userIsManagerDataGridViewCheckBoxColumn.Name = "userIsManagerDataGridViewCheckBoxColumn";
            // 
            // tblUsersBindingSource
            // 
            this.tblUsersBindingSource.DataMember = "tblUsers";
            this.tblUsersBindingSource.DataSource = this.dataSetUsers;
            // 
            // dataSetUsers
            // 
            this.dataSetUsers.DataSetName = "DataSetUsers";
            this.dataSetUsers.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblUsersTableAdapter
            // 
            this.tblUsersTableAdapter.ClearBeforeFill = true;
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(101, 213);
            this.addButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(319, 101);
            this.addButton.TabIndex = 25;
            this.addButton.Text = "הוסף";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.AddButtonClick);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label12.Location = new System.Drawing.Point(1091, 322);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(117, 20);
            this.label12.TabIndex = 26;
            this.label12.Text = "טבלת משתמשים";
            // 
            // FormAddUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.ClientSize = new System.Drawing.Size(1256, 570);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.userLocation);
            this.Controls.Add(this.userIsManager);
            this.Controls.Add(this.userPassword);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.userMail);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.userMobile);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.userPhone);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.userAddress);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.userBirthDate);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.userLastName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.userFirstName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.userID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FormAddUsers";
            this.Text = "FormAddUsers";
            this.Load += new System.EventHandler(this.FormAddUsers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblUsersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetUsers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox userID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox userFirstName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox userLastName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker userBirthDate;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox userAddress;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox userPhone;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox userMobile;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox userMail;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox userPassword;
        private System.Windows.Forms.CheckBox userIsManager;
        private System.Windows.Forms.ComboBox userLocation;
        private System.Windows.Forms.DataGridView dataGridView1;
        private DataSetUsers dataSetUsers;
        private System.Windows.Forms.BindingSource tblUsersBindingSource;
        private DataSetUsersTableAdapters.tblUsersTableAdapter tblUsersTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn userIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn userFirstNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn userLastNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn userBirthDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn userAddressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn userLocationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn userPhoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn userMobileDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn userMailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn userPasswordDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn userIsManagerDataGridViewCheckBoxColumn;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Label label12;
    }
}