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
    public partial class FormUpdateStationsLine : Form
    {
        OleDbConnection dataConnection;
        private int lastRow = 0;
        public FormUpdateStationsLine(OleDbConnection dataConnection)
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

        private void UpdateButtonClick(object sender, EventArgs e)
        {
            try
            {
                OleDbCommand datacommand = new OleDbCommand();
                datacommand.Connection = dataConnection;
                datacommand.CommandText = "UPDATE tblStationsLine " +
                                          "SET     lineStationLineID  =       " + lineStationLineID.Text + "   ,  " +
                                                  "lineStationNumber   =      " + lineStationNumber.Text + "   ,  " +
                                                  "lineStationMinutes  =      " + lineStationMinutes.Text + "  ,   " +
                                                  "lineStationKind     =    \"" + lineStationKind.Text + "\"   " +
                                          "WHERE  lineStationID = "+ lineStationID.Text ;
                OleDbDataReader dataReader = datacommand.ExecuteReader();
                RefreshDataGridView();
                MessageBox.Show("Update tblStationsLine ended successfluly");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Update StationsLine table failed " +
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
                                     "FROM     tblStationsLine " +
                                     "ORDER BY lineStationLineID";
                OleDbDataAdapter dataAdapter = new OleDbDataAdapter(sqlCommand, dataConnection);
                DataTable tbl = new DataTable();
                dataAdapter.Fill(tbl);
                dataGridView1.DataSource = tbl;
                dataGridView1.AllowUserToAddRows = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Refresh locations table failed " +
                                 ex.Message, "Errors",
                                 MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            FillSelectedRow();
            buttonLast.Enabled = true;
            buttonNext.Enabled = true;
            lastRow = dataGridView1.CurrentRow.Index;
        }

        private void FillSelectedRow()
        {
            try
            {
                lineStationLineID.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                lineStationNumber.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                lineStationID.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
                lineStationMinutes.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
                lineStationKind.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
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
        
    }
}
