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
    public partial class FormRptLineStations : Form
    {
        private OleDbConnection dataConnection;
        private int lastRow = 0;
        private int counter = 0;
        private Station[] arrStations;
        private int    stationID;
        private string stationName;
        private string stationLocation;
        private string stationStreet;
        private string stationPicture;
        private int    stationMinutes;
        private string stationKind;

        public FormRptLineStations(OleDbConnection dataConnection)
        {
            InitializeComponent();
            this.dataConnection = dataConnection;
            pictureSize.Items.Add("קטן");
            pictureSize.Items.Add("בינוני");
            pictureSize.Items.Add("גדול");
        }

        private void FormAddLines_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSetLines.tblLines' table. You can move, or remove it, as needed.
            this.tblLinesTableAdapter.Fill(this.dataSetLines.tblLines);

        }


        private void RefreshDataGridView()                         // Refresh DataGridView
        {
            OleDbCommand datacommand = new OleDbCommand();
            datacommand.Connection = dataConnection;
            string sqlCommand = "SELECT   * " +
                                 "FROM     tblLines " +
                                 "ORDER BY lineID";
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
                lineID.Text            = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                lineNum.Text           = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                lineCompany.Text       = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
                lineFromStationID.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
                lineToStationID.Text   = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
                lineNumStations.Text   = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
                lineMinutes.Text       = dataGridView1.SelectedRows[0].Cells[6].Value.ToString();
                GetStationDetails(lineFromStationID.Text, "from");
                GetStationDetails(lineToStationID.Text, "to");
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

        private void GetStationDetails(string stationID, string fromToStation)
        {
            try
            {
                OleDbCommand datacommand = new OleDbCommand();
                datacommand.Connection = dataConnection;
                datacommand.CommandText = "SELECT stationName, stationLocation, stationStreet, stationPicture " +
                                          "FROM   tblStations " +
                                          "WHERE  stationID = " + stationID;
                OleDbDataReader dataReader = datacommand.ExecuteReader();
                if (dataReader.Read())
                {
                    if (fromToStation == "from")
                    {
                        lineFromStationName.Text = dataReader.GetString(0);
                        lineFromStationCity.Text = dataReader.GetString(1);
                        lineFromStationAddress.Text = dataReader.GetString(2);
                        lineFromStationPicture.Text = dataReader.GetString(3);
                        pictureBox1.ImageLocation = lineFromStationPicture.Text;
                    }
                    else
                    {
                        lineToStationName.Text = dataReader.GetString(0);
                        lineToStationCity.Text = dataReader.GetString(1);
                        lineToStationAddress.Text = dataReader.GetString(2);
                        lineToStationPicture.Text = dataReader.GetString(3);
                        pictureBox2.ImageLocation = lineToStationPicture.Text;
                    }
                }
                dataReader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Select tblStations failed " + ex.Message,
                                "Errors",
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

        private void ButtonShow_Click(object sender, EventArgs e)
        {
            counter=GetlineNumStations(lineID.Text);
            arrStations = new Station[counter];
            FillArrStation(arrStations, lineID.Text);
            this.Hide();
            FormRptStationPictures frpsp = new FormRptStationPictures(arrStations , int.Parse(lngRow.Text) , lineNum.Text, pictureSize.Text ,int.Parse(lineID.Text), dayDate.Text, dataConnection);
            frpsp.Show();
            frpsp.Disposed += new EventHandler(Form_Disposed);
        }

        void Form_Disposed(object sender, EventArgs e)
        {
            this.Show();
            this.Activate();
        }

        private int GetlineNumStations(string lineID)
        {
            try
            {
                OleDbCommand datacommand = new OleDbCommand();
                datacommand.Connection = dataConnection;
                datacommand.CommandText = "SELECT COUNT (*)" +
                                          "FROM   tblStationsLine " +
                                          "WHERE  lineStationLineID = " + lineID;
                OleDbDataReader dataReader = datacommand.ExecuteReader();
                dataReader.Read();
                counter = dataReader.GetInt32(0);
                return counter;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Select tblStationsLine failed " + ex.Message,
                                "Errors",
                                 MessageBoxButtons.OK, MessageBoxIcon.Error);
                return 0;
            }
        }

        private void FillArrStation(Station[] arrStations,string lineID)
        {
            int idx = 0;
            try
            {
                OleDbCommand datacommand = new OleDbCommand();
                datacommand.Connection = dataConnection;
                datacommand.CommandText = "SELECT    lineStationID, lineStationMinutes, lineStationKind " +
                                          "FROM      tblStationsLine " +
                                          "WHERE     lineStationLineID = " + lineID + " " +
                                          "ORDER BY  lineStationNumber";
                OleDbDataReader dataReader = datacommand.ExecuteReader();
                while (dataReader.Read())
                {
                    stationID = dataReader.GetInt32(0);
                    stationMinutes = dataReader.GetInt32(1);
                    stationKind = dataReader.GetString(2);
                    GetStationDetails(stationID.ToString());
                    arrStations[idx] = new Station(stationID, stationName, stationLocation, stationStreet, stationPicture, stationMinutes, stationKind);
                    idx++;
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

        private void GetStationDetails(string stationID)
        {
            try
            {
                OleDbCommand datacommand = new OleDbCommand();
                datacommand.Connection = dataConnection;
                datacommand.CommandText = "SELECT stationName, stationLocation, stationStreet, stationPicture " +
                                          "FROM   tblStations " +
                                          "WHERE  stationID = " + stationID;
                OleDbDataReader dataReader = datacommand.ExecuteReader();
                dataReader.Read();
                stationName     = dataReader.GetString(0);
                stationLocation = dataReader.GetString(1);
                stationStreet   = dataReader.GetString(2);
                stationPicture  = dataReader.GetString(3);
                dataReader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Select tblStations failed " + ex.Message,
                                "Errors",
                                 MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

