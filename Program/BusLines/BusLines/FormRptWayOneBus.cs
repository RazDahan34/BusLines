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
    public partial class FormRptWayOneBus : Form
    {
        private OleDbConnection dataConnection;
        private int lastRow = 0;
        private int lastRow2 = 0;
        private int lineStationID;
        private int lineNumStations;
        private int j;
        private string stationName;
        private string stationLocation;
        private string stationStreet;
        private string stationPicture;
        private string lineID;
        private string lineNumber;
        private string lineCompany;
        private string lineFromStationID;
        private string lineFromStationName;
        private string lineFromStationAddress;
        private string lineToStationID;
        private string lineToStationName;
        private string lineToStationAddress;
        private string lineFromStationKind;
        private string lineToStationKind;
        public FormRptWayOneBus(OleDbConnection dataConnection)
        {
            InitializeComponent();
            this.dataConnection = dataConnection;
            DeleteTblTempStations();
        }

        private void FormAddLines_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSetTempStations.tblTempStations' table. You can move, or remove it, as needed.
            this.tblTempStationsTableAdapter.Fill(this.dataSetTempStations.tblTempStations);
            // TODO: This line of code loads data into the 'dataSetStations.tblStations' table. You can move, or remove it, as needed.
            this.tblStationsTableAdapter.Fill(this.dataSetStations.tblStations);
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

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            lastRow2 = dataGridView2.CurrentRow.Index;
            FillSelectRow2();
            buttonLast2.Enabled = true;
            buttonNext2.Enabled = true;
        }
        private void FillSelectedRow()
        {
            try
            {
                fromStationID.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                fromStationName.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                fromStationLocation.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
                fromStationAddress.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
                fromStationPicture.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
                pictureBox1.ImageLocation = fromStationPicture.Text;
                dataGridView1.CurrentCell = dataGridView1[0, lastRow];
                EnableButtons();
                DeleteTblTempStations();
                RefreshDataGridView2();
                FillToStations();
                CheckColumns();
                RefreshDataGridView2();
                buttonPrev2.Enabled = true;
                buttonNext2.Enabled = true;
                buttonFirst2.Enabled = true;
                buttonLast2.Enabled = true;
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

        private void FillToStations()
        {
            try
            {
                OleDbCommand datacommand = new OleDbCommand();
                datacommand.Connection = dataConnection;
                datacommand.CommandText = "SELECT   lineStationLineID , lineStationKind " +
                                          "FROM     tblStationsLine " +
                                          "WHERE    lineStationID = " + fromStationID.Text + " " +
                                          "ORDER BY lineStationLineID ";
                OleDbDataReader dataReader = datacommand.ExecuteReader();
                int[] arr = new int[999];
                int i = 0;
                while (dataReader.Read())
                {
                    if (dataReader.GetString(1) != "הורדה")
                    {
                        arr[i] = dataReader.GetInt32(0);
                        i++;
                    }
                }
                dataReader.Close();
                ScanArr(arr);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Select tblStationsLine failed " + ex.Message,
                                "Errors",
                                 MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ScanArr(int[] arr)
        {
            for (j = 0; j < arr.Length && arr[j] != 0; j++)
            {
                try
                {
                    OleDbCommand datacommand = new OleDbCommand();
                    datacommand.Connection = dataConnection;
                    datacommand.CommandText = "SELECT   lineStationLineID, lineStationNumber " +
                                              "FROM     tblStationsLine " +
                                              "WHERE    lineStationID = " + fromStationID.Text + " " +
                                              "ORDER BY lineStationNumber ";
                    OleDbDataReader dataReader = datacommand.ExecuteReader();
                    while (dataReader.Read())
                    {
                        if (arr[j] == dataReader.GetInt32(0))
                        {
                            int lineStationNumber = dataReader.GetInt32(1) + 1;
                            GetLineNumStations(arr[j]);
                            GetStationID(arr, lineStationNumber);
                        }
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
        }

        private void GetLineNumStations(int lineID)
        {
            try
            {
                OleDbCommand datacommand = new OleDbCommand();
                datacommand.Connection = dataConnection;
                datacommand.CommandText = "SELECT   lineNumStations " +
                                          "FROM     tblLines " +
                                          "WHERE    lineID = " + lineID;
                OleDbDataReader dataReader = datacommand.ExecuteReader();
                dataReader.Read();
                lineNumStations = dataReader.GetInt32(0);
                dataReader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Select tblLines failed " + ex.Message,
                                "Errors",
                                 MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void GetStationID(int[] arr, int lineStationNumber)
        {
            while (lineStationNumber < (lineNumStations + 1))
            {
                try
                {
                    OleDbCommand datacommand = new OleDbCommand();
                    datacommand.Connection = dataConnection;
                    datacommand.CommandText = "SELECT   lineStationLineID, lineStationID " +
                                              "FROM     tblStationsLine " +
                                              "WHERE    lineStationNumber = " + lineStationNumber + " " +
                                              "ORDER BY lineStationLineID ";
                    OleDbDataReader dataReader = datacommand.ExecuteReader();
                    while (dataReader.Read())
                    {
                        if (arr[j] == dataReader.GetInt32(0))
                        {
                            lineStationID = dataReader.GetInt32(1);
                            GetMoreDetails();
                            FillDataGridView();
                        }
                    }
                    dataReader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Select tblStationsLine failed " + ex.Message,
                                    "Errors",
                                     MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                lineStationNumber = lineStationNumber + 1;
            }
        }

        private void GetMoreDetails()
        {
            try
            {
                OleDbCommand datacommand = new OleDbCommand();
                datacommand.Connection = dataConnection;
                datacommand.CommandText = "SELECT   stationName , stationLocation, stationStreet, stationPicture " +
                                          "FROM     tblStations " +
                                          "WHERE    stationID = " + lineStationID;
                OleDbDataReader dataReader = datacommand.ExecuteReader();
                dataReader.Read();
                stationName = dataReader.GetString(0);
                stationLocation = dataReader.GetString(1);
                stationStreet = dataReader.GetString(2);
                stationPicture = dataReader.GetString(3);
                dataReader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Select tblStations failed " + ex.Message,
                                "Errors",
                                 MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FillDataGridView()
        {
            try
            {
                OleDbCommand datacommand = new OleDbCommand();
                datacommand.Connection = dataConnection;
                string str = string.Format
                                    ("INSERT INTO tblTempStations " +
                                    "(stationID, stationName, stationLocation, stationStreet, stationPicture ) " +
                                    " VALUES ( {0}, \"{1}\", \"{2}\", \"{3}\", \"{4}\" )",
                                           lineStationID, stationName, stationLocation, stationStreet, stationPicture);
                datacommand.CommandText = str;
                OleDbDataReader dataReader = datacommand.ExecuteReader();
            }
            catch (Exception err)
            {
                string line;
                line = err.Message;
                MessageBox.Show(line, "Insert Error");
            }
        }

        private void RefreshDataGridView2()                         // Refresh DataGridView2
        {
            OleDbCommand datacommand = new OleDbCommand();
            datacommand.Connection = dataConnection;
            string sqlCommand = "SELECT    * " +
                                 "FROM     tblTempStations " +
                                 "ORDER BY stationID";
            OleDbDataAdapter dataAdapter = new OleDbDataAdapter(sqlCommand, dataConnection);
            DataTable tbl = new DataTable();
            dataAdapter.Fill(tbl);
            dataGridView2.DataSource = tbl;
            dataGridView2.AllowUserToAddRows = false;
        }

        private void DeleteTblTempStations(object sender, EventArgs e)
        {
            OleDbCommand datacommand3 = new OleDbCommand();
            datacommand3.Connection = dataConnection;
            datacommand3.CommandText = "DELETE   * " +
                                       "FROM     tblTempStations ";
            OleDbDataReader dataReader = datacommand3.ExecuteReader();
            dataReader.Close();
            RefreshDataGridView2();
            buttonPrev2.Enabled = false;
            buttonNext2.Enabled = false;
            buttonFirst2.Enabled = false;
            buttonLast2.Enabled = false;
        }

        private void DeleteTblTempStations()
        {
            OleDbCommand datacommand3 = new OleDbCommand();
            datacommand3.Connection = dataConnection;
            datacommand3.CommandText = "DELETE   * " +
                                       "FROM     tblTempStations ";
            OleDbDataReader dataReader = datacommand3.ExecuteReader();
            dataReader.Close();
            RefreshDataGridView2();
            buttonPrev2.Enabled = false;
            buttonNext2.Enabled = false;
            buttonFirst2.Enabled = false;
            buttonLast2.Enabled = false;

        }
        private void CheckColumns()
        {
            OleDbCommand datacommand = new OleDbCommand();
            datacommand.Connection = dataConnection;
            datacommand.CommandText = "SELECT   DISTINCT stationID " +
                                      "FROM     tblTempStations ";
            OleDbDataReader dataReader = datacommand.ExecuteReader();
            DeleteTblTempStations();
            while (dataReader.Read())
            {
                lineStationID = dataReader.GetInt32(0);
                GetMoreDetails();
                OleDbCommand datacommand2 = new OleDbCommand();
                datacommand2.Connection = dataConnection;
                string str = string.Format
                                    ("INSERT INTO tblTempStations " +
                                    "(stationID, stationName, stationLocation, stationStreet, stationPicture ) " +
                                    " VALUES ( {0}, \"{1}\", \"{2}\", \"{3}\", \"{4}\" )",
                                       lineStationID, stationName, stationLocation, stationStreet, stationPicture);
                datacommand2.CommandText = str;
                OleDbDataReader dataReader2 = datacommand2.ExecuteReader();
                dataReader2.Close();
            }
            dataReader.Close();
        }

        private void FillSelectRow2()
        {
            try
            {
                toStationID.Text = dataGridView2.SelectedRows[0].Cells[0].Value.ToString();
                toStationName.Text = dataGridView2.SelectedRows[0].Cells[1].Value.ToString();
                toStationLocation.Text = dataGridView2.SelectedRows[0].Cells[2].Value.ToString();
                toStationAddress.Text = dataGridView2.SelectedRows[0].Cells[3].Value.ToString();
                toStationPicture.Text = dataGridView2.SelectedRows[0].Cells[4].Value.ToString();
                pictureBox2.ImageLocation = toStationPicture.Text;
                dataGridView2.CurrentCell = dataGridView2[0, lastRow2];
                EnableButtons2();
            }

            catch (Exception ex)
            {
                MessageBox.Show("Getting fields of dataGridView2 row failed " +
                                 ex.Message, "Errors",
                                 MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void EnableButtons2()
        {
            buttonPrev2.Enabled = true;
            buttonNext2.Enabled = true;
            if (lastRow2 == 0)
                buttonPrev2.Enabled = false;
            if (lastRow2 == dataGridView2.Rows.Count - 1)
                buttonNext2.Enabled = false;
        }

        private void buttonPrev2_Click(object sender, EventArgs e)
        {
            dataGridView2.Rows[lastRow2].Selected = false;
            lastRow2--;
            dataGridView2.Rows[lastRow2].Selected = true;
            FillSelectRow2();
        }

        private void buttonNext2_Click(object sender, EventArgs e)
        {
            dataGridView2.Rows[lastRow2].Selected = false;
            lastRow2++;
            dataGridView2.Rows[lastRow2].Selected = true;
            FillSelectRow2();
        }

        private void buttonFirst2_Click(object sender, EventArgs e)
        {
            dataGridView2.Rows[lastRow2].Selected = false;
            lastRow2 = 0;
            dataGridView2.Rows[lastRow2].Selected = true;
            FillSelectRow2();
        }

        private void buttonLast2_Click(object sender, EventArgs e)
        {
            dataGridView2.Rows[lastRow2].Selected = false;
            lastRow2 = dataGridView2.Rows.Count - 1;
            dataGridView2.Rows[lastRow2].Selected = true;
            FillSelectRow2();
        }

        private void ClearColumns(object sender, EventArgs e)
        {
            listView1.Items.Clear();
        }

        private void ShowClick(object sender, EventArgs e)
        {
            try
            {
                OleDbCommand datacommand = new OleDbCommand();
                datacommand.Connection = dataConnection;
                datacommand.CommandText = "SELECT   lineStationLineID , lineStationKind " +
                                          "FROM     tblStationsLine " +
                                          "WHERE    lineStationID = " + fromStationID.Text + " " +
                                          "ORDER BY lineStationLineID ";
                OleDbDataReader dataReader = datacommand.ExecuteReader();
                while (dataReader.Read())
                {
                    lineID = dataReader.GetInt32(0).ToString();
                    if (CheckLine())
                    {
                        lineFromStationKind = dataReader.GetString(1);
                        GetOtherDetails();
                    }
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

        private bool CheckLine()
        {
            OleDbCommand datacommand = new OleDbCommand();
            datacommand.Connection = dataConnection;
            datacommand.CommandText = "SELECT   lineStationLineID, lineStationKind " +
                                      "FROM     tblStationsLine " +
                                      "WHERE    lineStationID = " + toStationID.Text + " " +
                                      "ORDER BY lineStationLineID ";
            OleDbDataReader dataReader = datacommand.ExecuteReader();
            dataReader.Read();
            if (dataReader.GetInt32(0).ToString() == lineID)
            {
                lineToStationKind = dataReader.GetString(1);
                dataReader.Close();
                return true;
            }
            dataReader.Close();
            return false;
        }

        private void GetOtherDetails()
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
                lineNumber = dataReader.GetString(0);
                lineCompany = dataReader.GetString(1);
                lineFromStationID = dataReader.GetInt32(2).ToString();
                lineToStationID = dataReader.GetInt32(3).ToString();
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
                lineFromStationName = dataReader.GetString(0);
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
            string[] arr = new string[8];
            arr[0] = lineNumber;
            arr[1] = lineCompany;
            arr[2] = lineFromStationName;
            arr[3] = lineFromStationAddress;
            arr[4] = lineFromStationKind;
            arr[5] = lineToStationName;
            arr[6] = lineToStationAddress;
            arr[7] = lineToStationKind;
            ListViewItem item = new ListViewItem(arr);
            item.ForeColor = Color.Blue;
            listView1.Items.Add(item);
        }

    }

}


