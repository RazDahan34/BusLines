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
    public partial class FormRpt_LinesInStation : Form
    {
        OleDbConnection dataConnection;
        private int lastRow = 0;
        private string lineID;
        private string lineNumber;
        private string lineCompany;
        private string lineStationNumber;
        private string lineFromStationID;
        private string lineFromStationName;
        private string lineFromStationAddress;
        private string lineToStationID;
        private string lineToStationName;
        private string lineToStationAddress;
        public FormRpt_LinesInStation(OleDbConnection dataConnection)
        {
            InitializeComponent();
            this.dataConnection = dataConnection;
        }

        private void ShowClick(object sender, EventArgs e)
        {
            try
            {
                OleDbCommand datacommand = new OleDbCommand();
                datacommand.Connection = dataConnection;
                datacommand.CommandText = "SELECT   lineStationLineID, lineStationNumber " +
                                          "FROM     tblStationsLine " +
                                          "WHERE    lineStationID = " + stationID.Text + " " +
                                          "ORDER BY lineStationLineID ";
                OleDbDataReader dataReader = datacommand.ExecuteReader();
                while (dataReader.Read())
                {
                    lineID = dataReader.GetInt32(0).ToString();
                    lineStationNumber = dataReader.GetInt32(1).ToString();
                    GetMoreDetails();
                }
                dataReader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Select tblStationsLine failed " + ex.Message,
                                "Errors",
                                 MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void GetMoreDetails()
        {
            try
            {
                OleDbCommand datacommand = new OleDbCommand();
                datacommand.Connection = dataConnection;
                datacommand.CommandText = "SELECT   lineNum, lineCompany, lineFromStation, lineToStation " +
                                          "FROM     tblLines " +
                                          "WHERE    lineID =" + lineID;
                OleDbDataReader dataReader = datacommand.ExecuteReader();
                dataReader.Read();
                lineNumber        = dataReader.GetString(0);
                lineCompany       = dataReader.GetString(1);
                lineFromStationID = dataReader.GetInt32(2).ToString();
                lineToStationID   = dataReader.GetInt32(3).ToString();
                GetFromStationDetails();
                GetToStationDetails();
                EditListView();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Select tblLines failed " + ex.Message,
                                "Errors",
                                 MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void GetFromStationDetails()
        {
            try
            {
                OleDbCommand datacommand = new OleDbCommand();
                datacommand.Connection = dataConnection;
                datacommand.CommandText = "SELECT   stationName, stationLocation, stationStreet " +
                                          "FROM     tblStations " +
                                          "WHERE    stationID = " + lineFromStationID;
                OleDbDataReader dataReader = datacommand.ExecuteReader();
                dataReader.Read();
                lineFromStationName    = dataReader.GetString(0);
                lineFromStationAddress = dataReader.GetString(1) + ", " + dataReader.GetString(2);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Select tblStations failed " + ex.Message,
                                "Errors",
                                 MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void GetToStationDetails()
        {
            try
            {
                OleDbCommand datacommand = new OleDbCommand();
                datacommand.Connection = dataConnection;
                datacommand.CommandText = "SELECT   stationName, stationLocation, stationStreet " +
                                          "FROM     tblStations " +
                                          "WHERE    stationID = " + lineToStationID;
                OleDbDataReader dataReader = datacommand.ExecuteReader();
                dataReader.Read();
                lineToStationName = dataReader.GetString(0);
                lineToStationAddress = dataReader.GetString(1) + ", " + dataReader.GetString(2);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Select tblStations failed " + ex.Message,
                                "Errors",
                                 MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void EditListView()
        {
            string[] arr = new string[7];
            arr[0] = lineNumber;
            arr[1] = lineStationNumber;
            arr[2] = lineCompany;
            arr[3] = lineFromStationName;
            arr[4] = lineFromStationAddress;
            arr[5] = lineToStationName;
            arr[6] = lineToStationAddress;
            ListViewItem item = new ListViewItem(arr);
            item.ForeColor = Color.Blue;
            listView1.Items.Add(item);
        }

        private void ClearColumns(object sender, EventArgs e)
        {
            listView1.Items.Clear();
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
