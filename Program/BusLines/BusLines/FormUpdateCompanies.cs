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
    public partial class FormUpdateCompanies : Form
    {
        OleDbConnection dataConnection;
        string saveColor;
        private int lastRow = 0;
        public FormUpdateCompanies(OleDbConnection dataConnection)
        {
            InitializeComponent();
            this.dataConnection = dataConnection;
            if (FillLocationCombo() == -1)
                return;
        }

        private void FormUpdateCompanies_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSetCompanies.tblCompanies' table. You can move, or remove it, as needed.
            this.tblCompaniesTableAdapter.Fill(this.dataSetCompanies.tblCompanies);

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
                    compLocation.Items.Add(dataReader.GetString(0));
                }
                return 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Filling locations combobox failed " + ex.Message,
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
                datacommand.CommandText = "UPDATE  tblCompanies " +
                                          "SET     compAddress  =  \"" + compAddress.Text + "\" , " +
                                                  "compLocation =  \"" + compLocation.Text + "\" , " +
                                                  "compPhone    =  \"" + compPhone.Text + "\" , " +
                                                  "compPicture  =  \"" + compPicture.Text + "\" , " +
                                                  "compColor    =    " + compColor.Text + "     " +
                                          "WHERE   compName     =  \"" + compName.Text + "\"  ";
                OleDbDataReader dataReader = datacommand.ExecuteReader();
                RefreshDataGridView();
                MessageBox.Show("Update tblCompanies ended successfluly");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Update Companies table failed " +
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
                                     "FROM     tblCompanies " +
                                     "ORDER BY compName";
                OleDbDataAdapter dataAdapter = new OleDbDataAdapter(sqlCommand, dataConnection);
                DataTable tbl = new DataTable();
                dataAdapter.Fill(tbl);
                dataGridView1.DataSource = tbl;
                dataGridView1.AllowUserToAddRows = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Refresh companies table failed " +
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
                compName.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                compAddress.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                compLocation.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
                compPhone.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
                compPicture.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
                compColor.Text = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
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

        private void BrowsePictureClick(object sender, EventArgs e)
        {
            DialogResult dlgResult = openFileDialog1.ShowDialog();
            string pictureFileName = openFileDialog1.FileName;
            pictureBox1.ImageLocation = pictureFileName;
            compPicture.Text = pictureFileName;
        }

        private void ChangeColorClick(object sender, EventArgs e)
        {
            ColorDialog cd = new ColorDialog();
            cd.ShowDialog();
            color.BackColor = cd.Color;
            saveColor = color.BackColor.ToArgb().ToString();
            compColor.Text = saveColor;
            MessageBox.Show("color value:   " + saveColor);
        }



    }
}

