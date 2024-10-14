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
    public partial class FormAddTimes : Form
    {
        OleDbConnection dataConnection;
        public FormAddTimes(OleDbConnection dataConnection)
        {
            InitializeComponent();
            this.dataConnection = dataConnection;
            FillLineIDCombo();
            for (int i = 1; i <= 24; i++)
                timeHour.Items.Add(i);
            for (int i = 1; i <= 60; i++)
                timeMinute.Items.Add(i);
        }

        private void FormAddTimes_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSetTimes.tblTimes' table. You can move, or remove it, as needed.
            this.tblTimesTableAdapter.Fill(this.dataSetTimes.tblTimes);

        }

        private void FillLineIDCombo()
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
                    timeLineID.Items.Add(dataReader.GetInt32(0));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Filling lineID combobox failed " + ex.Message,
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
                                    ("INSERT INTO tblTimes " +
                                     "(timeLineID, timeHour, timeMinute ) " +
                                     " VALUES ( {0}, \"{1}\", \"{2}\" )",
                                       timeLineID.Text, timeHour.Text, timeMinute.Text);
                datacommand.CommandText = str;
                OleDbDataReader dataReader = datacommand.ExecuteReader();
                MessageBox.Show("Adding a Time ended successfully");
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
                                 "FROM     tblTimes " +
                                 "ORDER BY timeLineID";
            OleDbDataAdapter dataAdapter = new OleDbDataAdapter(sqlCommand, dataConnection);
            DataTable tbl = new DataTable();
            dataAdapter.Fill(tbl);
            dataGridView1.DataSource = tbl;
            dataGridView1.AllowUserToAddRows = false;
        
        }
    }
}
