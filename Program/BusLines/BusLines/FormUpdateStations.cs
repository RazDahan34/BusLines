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
    public partial class FormUpdateStations : Form
    {
        OleDbConnection dataConnection;
        private int lastRow = 0;
        public FormUpdateStations(OleDbConnection dataConnection)
        {
            InitializeComponent();
            this.dataConnection = dataConnection;
            FillLocationCombo();
        }

        private void FillLocationCombo()
        {
            try
            {
                OleDbCommand datacommand = new OleDbCommand();
                datacommand.Connection = dataConnection;
                datacommand.CommandText = "SELECT   locatName " +
                                          "FROM     tblLocations " +
                                          "ORDER BY locatName";
                OleDbDataReader dataReader = datacommand.ExecuteReader();
                while (dataReader.Read())
                {
                    stationLocation.Items.Add(dataReader.GetString(0));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Filling locations combobox failed " + ex.Message,
                                "Errors",
                                 MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void UpdateButtonClick(object sender, EventArgs e)
        {
            try
            {
                OleDbCommand datacommand = new OleDbCommand();
                datacommand.Connection = dataConnection;
                datacommand.CommandText = "UPDATE tblStations " +
                                          "SET     stationName      =   \"" + stationName.Text + "\" , " +
                                                  "stationLocation  =   \"" + stationLocation.Text + "\" , " +
                                                  "stationStreet    =   \"" + stationStreet.Text + "\" , " +
                                                  "stationPicture   =   \"" + stationPicture.Text + "\"     " +
                                          "WHERE  stationID = " + stationID.Text ;
                OleDbDataReader dataReader = datacommand.ExecuteReader();
                RefreshDataGridView();
                MessageBox.Show("Update tblStations ended successfluly");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Update stations table failed " +
                                 ex.Message, "Errors",
                                 MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void RefreshDataGridView()                         // Refresh DataGridView
        {
            OleDbCommand datacommand = new OleDbCommand();
            datacommand.Connection = dataConnection;
            string sqlCommand = "SELECT   * " +
                                 "FROM     tblStations " +
                                 "ORDER BY stationID";
            OleDbDataAdapter dataAdapter = new OleDbDataAdapter(sqlCommand, dataConnection);
            DataTable tbl = new DataTable();
            dataAdapter.Fill(tbl);
            dataGridView1.DataSource = tbl;
            dataGridView1.AllowUserToAddRows = false;
        }
        

        private void BrowsePictureClick(object sender, EventArgs e)
        {
            DialogResult dlgResult = openFileDialog1.ShowDialog();
            string pictureFileName = openFileDialog1.FileName;
            pictureBox1.ImageLocation = pictureFileName;
            stationPicture.Text = pictureFileName;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            lastRow = dataGridView1.CurrentRow.Index;
            FillSelectedRow();
            buttonLast.Enabled = true;
            buttonNext.Enabled = true;
        }

        private void FillSelectedRow()
        {
            try
            {
                stationID.Text       = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                stationName.Text     = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                stationLocation.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
                stationStreet.Text   = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
                stationPicture.Text  = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
                pictureBox1.ImageLocation = stationPicture.Text;
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

        private void FormUpdateStations_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSetStations.tblStations' table. You can move, or remove it, as needed.
            this.tblStationsTableAdapter.Fill(this.dataSetStations.tblStations);

        }
    }
}
