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
    public partial class FormRpt_LinesInCity : Form
    {
        private OleDbConnection dataConnection;
        private int counter;
        private int stationID;
        private string lineID;
        private string lineNumber;
        private string lineCompany;
        private int FromStationID;
        private int ToStationID;
        private string FromStationName;
        private string FromStationAddress;
        private string ToStationName;
        private string ToStationAddress;
        private string stationName;
        private string stationLocation;
        private string stationStreet;
        private string stationNumber;
        public FormRpt_LinesInCity(OleDbConnection dataConnection)
        {
            InitializeComponent();
            this.dataConnection = dataConnection;
            FillCitiesCombo();
        }

        private void FillCitiesCombo()
        {
            try
            {
                OleDbCommand datacommand = new OleDbCommand();
                datacommand.Connection = dataConnection;
                datacommand.CommandText = "SELECT cityName " +
                                          "FROM tblCities ";
                OleDbDataReader dataReader = datacommand.ExecuteReader();
                while (dataReader.Read())
                {
                    cityName.Items.Add(dataReader.GetString(0));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Filling cities combobox failed " + ex.Message,
                                "Errors",
                                 MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ShowClick(object sender, EventArgs e)
        {
            try
            {
                OleDbCommand datacommand = new OleDbCommand();
                datacommand.Connection = dataConnection;
                datacommand.CommandText = "SELECT   lineID, lineNum, lineCompany, lineFromStation, lineToStation " +
                                          "FROM     tblLines " +
                                          "ORDER BY lineID ";
                OleDbDataReader dataReader = datacommand.ExecuteReader();
                while (dataReader.Read())
                {
                    lineID = dataReader.GetInt32(0).ToString();
                    lineNumber = dataReader.GetString(1);
                    lineCompany = dataReader.GetString(2);
                    FromStationID = dataReader.GetInt32(3);
                    ToStationID = dataReader.GetInt32(4);
                    GetMoreDetails();
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
        private void GetMoreDetails()
        {
            try
            {
                OleDbCommand datacommand = new OleDbCommand();
                datacommand.Connection = dataConnection;
                datacommand.CommandText = "SELECT   lineStationID, lineStationNumber " +
                                          "FROM     tblStationsLine " +
                                          "WHERE    lineStationLineID = " + lineID + " " +
                                          "ORDER BY lineStationID ";
                OleDbDataReader dataReader = datacommand.ExecuteReader();
                counter = 0;
                while (dataReader.Read())
                {
                    stationID = dataReader.GetInt32(0);
                    stationNumber = dataReader.GetInt32(1).ToString();
                    CheckStationCity();
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

        private void CheckStationCity()
        {
            try
            {
                OleDbCommand datacommand = new OleDbCommand();
                datacommand.Connection = dataConnection;
                datacommand.CommandText = "SELECT stationName , stationLocation, stationStreet " +
                                          "FROM   tblStations " +
                                          "WHERE  stationID = " + stationID;
                OleDbDataReader dataReader = datacommand.ExecuteReader();
                dataReader.Read();
                stationName = dataReader.GetString(0);
                stationLocation = dataReader.GetString(1);
                stationStreet = dataReader.GetString(2);
                dataReader.Close();
                if (stationLocation == cityName.Text)
                {
                    counter++;
                    GetFromStation();
                    GetToStation();
                    EditListView();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Select tblStations failed " + ex.Message,
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
                                          "WHERE   stationID = " + FromStationID;
                OleDbDataReader dataReader = datacommand.ExecuteReader();
                dataReader.Read();
                FromStationName = dataReader.GetString(0);
                FromStationAddress = dataReader.GetString(1) + ", " + dataReader.GetString(2);
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
                                          "WHERE    stationID = " + ToStationID;
                OleDbDataReader dataReader = datacommand.ExecuteReader();
                dataReader.Read();
                ToStationName = dataReader.GetString(0);
                ToStationAddress = dataReader.GetString(1) + ", " + dataReader.GetString(2);
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
            string[] arr = new string[9];
            if (counter == 1)
            {
                arr[0] = lineNumber;
                arr[1] = lineCompany;
                arr[2] = FromStationName;
                arr[3] = FromStationAddress;
                arr[4] = ToStationName;
                arr[5] = ToStationAddress;
            }
            arr[6] = stationName;
            arr[7] = stationStreet;
            arr[8] = stationNumber;
            ListViewItem item = new ListViewItem(arr);
            item.ForeColor = Color.Blue;
            listView1.Items.Add(item);
        }

        private void ClearColumns(object sender, EventArgs e)
        {
            listView1.Items.Clear();
        }
    }
}
