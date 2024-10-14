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
    public partial class FormRptWayTwoBus : Form
    {
        private OleDbConnection dataConnection;
        private int[,] linesArr;
        private int lastRow = 0;
        private int lastRow2 = 0;
        private int lineNumStations;
        private string lineID;
        private string lineNum;
        private string lineNumber;
        private string lineCompany;
        private int lineFromStationID;
        private int lineToStationID;
        private int lineMinutes;
        private int stationID;
        private string stationName;
        private string stationLocation;
        private string stationStreet;
        private string stationPicture;
        private int stationMinutes;
        private string stationKind;
        private Station[] arrStations;
        public FormRptWayTwoBus(OleDbConnection dataConnection)
        {
            InitializeComponent();
            this.dataConnection = dataConnection;
            DeleteTblTempLines();
        }

        private void FormAddLines_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSetTempLines.tblTempLines' table. You can move, or remove it, as needed.
            this.tblTempLinesTableAdapter.Fill(this.dataSetTempLines.tblTempLines);
            // TODO: This line of code loads data into the 'dataSetTempStations.tblTempStations' table. You can move, or remove it, as needed.
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
                DeleteTblTempLines();
                linesArr = CreateTable(fromStationID.Text);
                UseTable();
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

        private int[,] CreateTable(string lineID)
        {
            try
            {
                OleDbCommand datacommand = new OleDbCommand();
                datacommand.Connection = dataConnection;
                datacommand.CommandText = "SELECT   Count(*) " +
                                          "FROM     tblStationsLine " +
                                          "WHERE    lineStationID = " + lineID;
                OleDbDataReader dataReader = datacommand.ExecuteReader();
                dataReader.Read();
                int num = dataReader.GetInt32(0);
                dataReader.Close();
                int[,] arr = new int[num, 2];
;
                datacommand.CommandText = "SELECT  lineStationLineID, lineStationNumber " +
                                          "FROM     tblStationsLine " +
                                          "WHERE    lineStationID = " + lineID + " " +
                                          "ORDER BY lineStationLineID ";
                dataReader = datacommand.ExecuteReader();
                int i = 0;
                while (dataReader.Read())
                {
                    arr[i, 0] = dataReader.GetInt32(0);
                    arr[i, 1] = dataReader.GetInt32(1);
                    i++;
                }
                dataReader.Close();
                return arr;
            }

            catch (Exception ex)
            {
                MessageBox.Show("Select tblStationsLine3 failed " + ex.Message,
                                "Errors",
                                 MessageBoxButtons.OK, MessageBoxIcon.Error);
                return new int[0, 0];
            }
        }

        private void UseTable()
        {
            try
            {
                int[,] arr;
                for (int i = 0; i < linesArr.GetLength(0); i++)
                {
                    OleDbCommand datacommand = new OleDbCommand();
                    datacommand.Connection = dataConnection;
                    datacommand.CommandText = "SELECT   lineStationID, lineStationNumber " +
                                              "FROM     tblStationsLine " +
                                              "WHERE    lineStationLineID = " + linesArr[i, 0].ToString() + "  AND  lineStationNumber  > " + linesArr[i, 1].ToString() + " " +
                                              "ORDER BY lineStationID ";
                    OleDbDataReader dataReader = datacommand.ExecuteReader();
                    while (dataReader.Read())
                    {
                        string stationID = dataReader.GetInt32(0).ToString();
                        arr = CreateTable(stationID);
                        CheckMoreLines(arr);
                    }
                    dataReader.Close();
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show("Select tblStationLine failed " + ex.Message,
                                "Errors",
                                 MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void CheckMoreLines(int[,] arr)
        {
            bool check;
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                check = true;
                for (int j = 0; j < linesArr.GetLength(0); j++)
                    if (arr[i, 0] == linesArr[j, 0])
                        check = false;
                if (check)
                    GetMoreDetailsLine(arr[i, 0]);
            }
        }

        private void GetMoreDetailsLine(int line)
        {
            try
            {
                OleDbCommand datacommand = new OleDbCommand();
                datacommand.Connection = dataConnection;
                datacommand.CommandText = "SELECT   lineNum, lineCompany, lineFromStation, lineToStation , lineNumStations, lineMinutes  " +
                                          "FROM     tblLines " +
                                          "WHERE    lineID =" + line;
                OleDbDataReader dataReader = datacommand.ExecuteReader();
                dataReader.Read();
                lineNumber = dataReader.GetString(0);
                lineCompany = dataReader.GetString(1);
                lineFromStationID = dataReader.GetInt32(2);
                lineToStationID = dataReader.GetInt32(3);
                lineNumStations = dataReader.GetInt32(4);
                lineMinutes = dataReader.GetInt32(5);
                AddLineToTable(line);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Select tblLines failed " + ex.Message,
                                "Errors",
                                 MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AddLineToTable(int line)
        {
            try
            {
                OleDbCommand datacommand = new OleDbCommand();
                datacommand.Connection = dataConnection;
                string str = string.Format
                                    ("INSERT INTO tblTempLines " +
                                     "(lineID, lineNum, lineCompany, lineFromStation, lineToStation, lineNumStations, lineMinutes ) " +
                                     " VALUES ( \"{0}\" , \"{1}\", \"{2}\", \"{3}\", \"{4}\", \"{5}\" , \"{6}\" )",
                                       line.ToString(), lineNumber, lineCompany, lineFromStationID.ToString(), lineToStationID.ToString(), lineNumStations.ToString(), lineMinutes.ToString());
                datacommand.CommandText = str;
                datacommand.ExecuteNonQuery();

            }
            catch (Exception err)
            {
            }
        }

        private void RefreshDataGridView2()                         // Refresh DataGridView2
        {
            OleDbCommand datacommand = new OleDbCommand();
            datacommand.Connection = dataConnection;
            string sqlCommand = "SELECT    * " +
                                 "FROM     tblTempLines " +
                                 "ORDER BY lineID";
            OleDbDataAdapter dataAdapter = new OleDbDataAdapter(sqlCommand, dataConnection);
            DataTable tbl = new DataTable();
            dataAdapter.Fill(tbl);
            dataGridView2.DataSource = tbl;
            dataGridView2.AllowUserToAddRows = false;
        }

        private void DeleteTblTempLines()
        {
            OleDbCommand datacommand = new OleDbCommand();
            datacommand.Connection = dataConnection;
            datacommand.CommandText = "DELETE   * " +
                                      "FROM     tblTempLines ";
            OleDbDataReader dataReader = datacommand.ExecuteReader();
            dataReader.Close();
            RefreshDataGridView2();
            buttonPrev2.Enabled = false;
            buttonNext2.Enabled = false;
            buttonFirst2.Enabled = false;
            buttonLast2.Enabled = false;
        }

        private void FillSelectRow2()
        {
            listView1.Items.Clear();
            try
            {
                lineID = dataGridView2.SelectedRows[0].Cells[0].Value.ToString();
                lineNum = dataGridView2.SelectedRows[0].Cells[1].Value.ToString();
                dataGridView2.CurrentCell = dataGridView2[0, lastRow2];
                EnableButtons2();
                int counter = GetlineNumStations(lineID);
                arrStations = new Station[counter];
                FillArrStation(arrStations, lineID);
                EditListView();
            }

            catch (Exception ex)
            {
                MessageBox.Show("Getting fields of dataGridView2 row failed " +
                                 ex.Message, "Errors",
                                 MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
                int counter = dataReader.GetInt32(0);
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

        private void FillArrStation(Station[] arrStations, string lineID)
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

        void Form_Disposed(object sender, EventArgs e)
        {
            this.Show();
            this.Activate();
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

        private void buttonLines_Click(object sender, EventArgs e)
        {
            DeleteTblTempLines();
        }

        private void showPictures_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormRptStationPictures frpsp = new FormRptStationPictures(arrStations, 6, lineNum, "בינוני", int.Parse(lineID), "31/12/2013", dataConnection);
            frpsp.Show();
            frpsp.Disposed += new EventHandler(Form_Disposed);
        }

        private void EditListView()
        {
            for (int i = 0; i < arrStations.Length; i++)
            {
                string[] arr = new string[6];
                arr[0] = arrStations[i].stationID.ToString();
                arr[1] = arrStations[i].stationName;
                arr[2] = arrStations[i].stationLocation;
                arr[3] = arrStations[i].stationStreet;
                arr[4] = arrStations[i].stationMinutes.ToString();
                arr[5] = arrStations[i].stationKind;
                ListViewItem item = new ListViewItem(arr);
                item.ForeColor = Color.Blue;
                listView1.Items.Add(item);
            }
        }

    }

}


