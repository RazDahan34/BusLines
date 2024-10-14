using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;

namespace BusLines
{
    public partial class FormUpdateUsers : Form
    {
        OleDbConnection dataConnection;
        private int lastRow = 0;
        public FormUpdateUsers(OleDbConnection dataConnection)
        {
            InitializeComponent();
            this.dataConnection = dataConnection;
            if (FillLocationCombo() == -1)
                return;
        }

        private void FormUpdateUsers_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSetUsers.tblUsers' table. You can move, or remove it, as needed.
            this.tblUsersTableAdapter.Fill(this.dataSetUsers.tblUsers);

        }

        private int FillLocationCombo()                  
        {
            try
            {
                OleDbCommand datacommand = new OleDbCommand();
                datacommand.Connection = dataConnection;
                datacommand.CommandText = "SELECT locatName " +
                                          "FROM tblLocations ";
                OleDbDataReader dataReader = datacommand.ExecuteReader();
                while (dataReader.Read())
                {
                    userLocation.Items.Add(dataReader.GetString(0));
                }
                return 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Fill locations combobox failed" + ex.Message,
                                "Errors",
                                 MessageBoxButtons.OK, MessageBoxIcon.Error);
                return -1;
            }
        }
        private void UpdateButtonClick(object sender, EventArgs e)
        {
             try
            {
                OleDbCommand datacommand = new OleDbCommand();
                datacommand.Connection = dataConnection;
                datacommand.CommandText = "UPDATE tblUsers " +
                                          "SET    userFirstName  =  \"" + userFirstName.Text    + "\" , " +
                                                  "userLastName  =  \"" + userLastName.Text     + "\" , " +
                                                  "userBirthDate =  \"" + userBirthDate.Text    + "\" , " +
                                                  "userAddress   =  \"" + userAddress.Text      + "\" , " +
                                                  "userLocation  =  \"" + userLocation.Text     + "\" , " +
                                                  "userPhone     =  \"" + userPhone.Text        + "\" , " +
                                                  "userMobile    =  \"" + userMobile.Text       + "\" , " +
                                                  "userMail      =  \"" + userMail.Text         + "\" , " +
                                                  "userPassword  =  \"" + userPassword.Text     + "\" , " +
                                                  "userIsManager =    " + userIsManager.Checked + "   " +
                                          "WHERE  userID = " + userID.Text;
                OleDbDataReader dataReader = datacommand.ExecuteReader();
                RefreshDataGridView();
                MessageBox.Show("Update tblUsers ended successfluly");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Update users table failed " +
                                 ex.Message, "Errors",
                                 MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void RefreshDataGridView()                         // Refresh DataGridView
        {
            try
            {
                OleDbCommand datacommand = new OleDbCommand();
                datacommand.Connection = dataConnection;
                string sqlCommand = "SELECT   * " +
                                     "FROM     tblUsers " +
                                     "ORDER BY userID";
                OleDbDataAdapter dataAdapter = new OleDbDataAdapter(sqlCommand, dataConnection);
                DataTable tbl = new DataTable();
                dataAdapter.Fill(tbl);
                dataGridView1.DataSource = tbl;
                dataGridView1.AllowUserToAddRows = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Refresh users table failed " +
                                 ex.Message, "Errors",
                                 MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            FillSelectedRow();
            buttonPrev.Enabled = true;
            buttonNext.Enabled = true;
            lastRow = dataGridView1.CurrentRow.Index;

        }
        private void FillSelectedRow()
        {
            try
            {
                userID.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                userFirstName.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                userLastName.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
                userBirthDate.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
                userAddress.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
                userLocation.Text = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
                userPhone.Text = dataGridView1.SelectedRows[0].Cells[6].Value.ToString();
                userMobile.Text = dataGridView1.SelectedRows[0].Cells[7].Value.ToString();
                userMail.Text = dataGridView1.SelectedRows[0].Cells[8].Value.ToString();
                userPassword.Text = dataGridView1.SelectedRows[0].Cells[9].Value.ToString();
                userIsManager.Checked = dataGridView1.SelectedRows[0].Cells[10].Value.ToString() == "True";
                dataGridView1.CurrentCell = dataGridView1[0, lastRow];
                EnableButtons();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Getting fields of dataGridView row failed " +
                                 ex.Message, "Errors",
                                 MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void EnableButtons()
        {
            buttonPrev.Enabled = true;
            buttonNext.Enabled = true;
            if (lastRow == 0)
                buttonPrev.Enabled = false;
            if (lastRow == dataGridView1.Rows.Count - 2)
                buttonNext.Enabled = false;
        }

        private void buttonPrev_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows[lastRow].Selected = false;
            lastRow--;
            dataGridView1.Rows[lastRow].Selected = true;
            FillSelectedRow();
        }

        private void buttonNext_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows[lastRow].Selected = false;
            lastRow++;
            dataGridView1.Rows[lastRow].Selected = true;
            FillSelectedRow();
        }

        private void buttonFirst_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows[lastRow].Selected = false;
            lastRow = 0;
            dataGridView1.Rows[lastRow].Selected = true;
            FillSelectedRow();
        }

        private void buttonLast_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows[lastRow].Selected = false;
            lastRow = dataGridView1.Rows.Count - 2;
            dataGridView1.Rows[lastRow].Selected = true;
            FillSelectedRow();

        }

    }
}
