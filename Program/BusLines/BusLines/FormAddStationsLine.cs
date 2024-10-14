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
    public partial class FormAddStationsLine : Form
    {
        OleDbConnection dataConnection;
        public FormAddStationsLine(OleDbConnection dataConnection)
        {
            InitializeComponent();
            this.dataConnection = dataConnection;
            FillLinesCombo();
            FillStationsCombo();
            FillStationsKindCombo();
        }

        private void FormAddStationsLine_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSetStationsLine.tblStationsLine' table. You can move, or remove it, as needed.
            this.tblStationsLineTableAdapter.Fill(this.dataSetStationsLine.tblStationsLine);

        }

        private void FillLinesCombo()
        {
            try
            {
                OleDbCommand datacommand = new OleDbCommand();
                datacommand.Connection = dataConnection;
                datacommand.CommandText = "SELECT lineID " +
                                          "FROM tblLines ";
                OleDbDataReader dataReader = datacommand.ExecuteReader();
                while (dataReader.Read())
                {
                    lineStationLineID.Items.Add(dataReader.GetInt32(0));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Filling lines combobox failed " + ex.Message,
                                "Errors",
                                 MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FillStationsCombo()
        {
            try
            {
                OleDbCommand datacommand = new OleDbCommand();
                datacommand.Connection = dataConnection;
                datacommand.CommandText = "SELECT stationID " +
                                          "FROM tblStations ";
                OleDbDataReader dataReader = datacommand.ExecuteReader();
                while (dataReader.Read())
                {
                    lineStationID.Items.Add(dataReader.GetInt32(0));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Filling Stations combobox failed " + ex.Message,
                                "Errors",
                                 MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FillStationsKindCombo()
        {
            try
            {
                OleDbCommand datacommand = new OleDbCommand();
                datacommand.Connection = dataConnection;
                datacommand.CommandText = "SELECT specialStationType " +
                                          "FROM tblSpecialStations ";
                OleDbDataReader dataReader = datacommand.ExecuteReader();
                while (dataReader.Read())
                {
                    lineStationKind.Items.Add(dataReader.GetString(0));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Filling StationsKind combobox failed " + ex.Message,
                                "Errors",
                                 MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AddButtonClick(object sender, EventArgs e)
        {
            try
            {
                OleDbCommand datacommand = new OleDbCommand();
                datacommand.Connection = dataConnection;
                string str = string.Format
                                    ("INSERT INTO tblStationsLine " +
                                     "(lineStationLineID, lineStationNumber, lineStationID, lineStationMinutes, lineStationKind) " +
                                     " VALUES ( {0}, \"{1}\", \"{2}\", \"{3}\", \"{4}\" )",
                                       lineStationLineID.Text, lineStationNumber.Text, lineStationID.Text, lineStationMinutes.Text, lineStationKind.Text);
                datacommand.CommandText = str;
                OleDbDataReader dataReader = datacommand.ExecuteReader();
                MessageBox.Show("Adding a station in line ended successfully");
                RefreshDataGridView();
            }
            catch (Exception err)
            {
                string line;
                line = err.Message;
                MessageBox.Show(line, "Insert Error");
            }
        }
        private void RefreshDataGridView()                         // Refresh DataGridView
        {
            OleDbCommand datacommand = new OleDbCommand();
            datacommand.Connection = dataConnection;
            string sqlCommand = "SELECT   * " +
                                 "FROM     tblStationsLine " +
                                 "ORDER BY lineStationLineID";
            OleDbDataAdapter dataAdapter = new OleDbDataAdapter(sqlCommand, dataConnection);
            DataTable tbl = new DataTable();
            dataAdapter.Fill(tbl);
            dataGridView1.DataSource = tbl;
            dataGridView1.AllowUserToAddRows = false;
        }


    }
}
