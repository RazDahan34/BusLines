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
    public partial class FormRpt_LinesInCompany : Form
    {
        private OleDbConnection dataConnection;
        private string lineNum;
        private int lineFromStationID;
        private int lineToStationID;
        private int lineMinutes;
        private string lineFromStationName;
        private string lineToStationName;
        private string lineFromStation;
        private string lineToStation;
        private string lineNumStations;
        public FormRpt_LinesInCompany(OleDbConnection dataConnection)
        {
            InitializeComponent();
            this.dataConnection = dataConnection;
            FillCompaniesCombo();
        }

        private void FillCompaniesCombo()
        {
            try
            {
                OleDbCommand datacommand = new OleDbCommand();
                datacommand.Connection = dataConnection;
                datacommand.CommandText = "SELECT compName " +
                                          "FROM tblCompanies ";
                OleDbDataReader dataReader = datacommand.ExecuteReader();
                while (dataReader.Read())
                {
                    lineCompany.Items.Add(dataReader.GetString(0));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Filling companies combobox failed " + ex.Message,
                                "Errors",
                                 MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CleanClick(object sender, EventArgs e)
        {
            listView1.Items.Clear();
        }

        private void ShowClick(object sender, EventArgs e)
        {
            try
            {
                OleDbCommand datacommand = new OleDbCommand();
                datacommand.Connection = dataConnection;
                datacommand.CommandText = "SELECT   lineNum, lineFromStation, lineToStation, lineNumStations, lineMinutes " +
                                          "FROM     tblLines " +
                                          "WHERE    lineCompany = \"" + lineCompany.Text + " \" " +
                                          "ORDER BY lineNum ";
                OleDbDataReader dataReader = datacommand.ExecuteReader();
                while (dataReader.Read())
                {
                    lineNum = dataReader.GetString(0);
                    lineFromStationID = dataReader.GetInt32(1);
                    lineToStationID = dataReader.GetInt32(2);
                    lineNumStations = dataReader.GetInt32(3).ToString();
                    lineMinutes = dataReader.GetInt32(4);
                    GetFromStation();
                    GetToStation();
                    EditListView();
                }
                dataReader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Select tblLines failed " + ex.Message,
                                "Errors",
                                 MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void GetFromStation()
        {
            try
            {
                OleDbCommand datacommand = new OleDbCommand();
                datacommand.Connection = dataConnection;
                datacommand.CommandText = "SELECT  stationName , stationLocation, stationStreet " +
                                          "FROM    tblStations " +
                                          "WHERE   stationID = " + lineFromStationID;
                OleDbDataReader dataReader = datacommand.ExecuteReader();
                dataReader.Read();
                lineFromStationName = dataReader.GetString(0);
                lineFromStation = dataReader.GetString(1) + ", " + dataReader.GetString(2);
                dataReader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Select tblFromStation failed " + ex.Message,
                                "Errors",
                                 MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void GetToStation()
        {
            try
            {
                OleDbCommand datacommand = new OleDbCommand();
                datacommand.Connection = dataConnection;
                datacommand.CommandText = "SELECT   stationName , stationLocation, stationStreet " +
                                          "FROM     tblStations " +
                                          "WHERE    stationID = " + lineToStationID;
                OleDbDataReader dataReader = datacommand.ExecuteReader();
                dataReader.Read();
                lineToStationName = dataReader.GetString(0);
                lineToStation = dataReader.GetString(1) + ", " + dataReader.GetString(2);
                dataReader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Select tblToStation failed " + ex.Message,
                                "Errors",
                                 MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void EditListView()
        {
            string[] arr = new string[7];
            arr[0] = lineNum;
            arr[1] = lineFromStationName;
            arr[2] = lineFromStation;
            arr[3] = lineToStationName;
            arr[4] = lineToStation;
            arr[5] = lineNumStations;
            arr[6] = lineMinutes.ToString();
            ListViewItem item = new ListViewItem(arr);
            item.ForeColor = Color.Blue;
            listView1.Items.Add(item);
        }
    }
}
