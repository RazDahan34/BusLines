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
    public partial class FormUpdateLines : Form
    {
        OleDbConnection dataConnection;
        private int lastRow = 0;
        public FormUpdateLines(OleDbConnection dataConnection)
        {
            InitializeComponent();
            this.dataConnection = dataConnection;
            if (FillCompanyCombo() == -1)
                return;
            if(FillFromAndToStationCombo()==-1)
                return;
        }

        private void FormAddLines_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSetLines.tblLines' table. You can move, or remove it, as needed.
            this.tblLinesTableAdapter.Fill(this.dataSetLines.tblLines);

        }

        private int FillCompanyCombo()
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
                return 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Filling companies combobox failed " + ex.Message,
                                "Errors",
                                 MessageBoxButtons.OK, MessageBoxIcon.Error);
                return -1;
            }
        }

        private int FillFromAndToStationCombo()
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
                    lineFromStation.Items.Add(dataReader.GetInt32(0));
                    lineToStation.Items.Add(dataReader.GetInt32(0));
                }
                return 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Filling stations combobox failed " + ex.Message,
                                "Errors",
                                 MessageBoxButtons.OK, MessageBoxIcon.Error);
                return -1;
            }
        }

        private void UpdateButtonClick(object sender, EventArgs e)
        {
            try
            {
                OleDbCommand datacommand = new OleDbCommand();
                datacommand.Connection = dataConnection;
                datacommand.CommandText = "UPDATE tblLines " +
                                          "SET     lineNum  =           \"" + lineNum.Text + "\" , " + 
                                                  "lineCompany  =       \"" + lineCompany.Text + "\" , " +
                                                  "lineFromStation  =   \"" + lineFromStation.Text + "\" , " +
                                                  "lineToStation  =     \"" + lineToStation.Text + "\" , " +
                                                  "lineNumStations  =   \"" + lineNumStations.Text + "\" , " +
                                                  "lineMinutes  =       \"" + lineMinutes.Text + "\"    " +
                                          "WHERE  lineID = " + lineID.Text ;
                OleDbDataReader dataReader = datacommand.ExecuteReader();
                RefreshDataGridView();
                MessageBox.Show("Update tblLines ended successfluly");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Update lines table failed " +
                                 ex.Message, "Errors",
                                 MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
            FillSelectedRow();
            buttonLast.Enabled = true;
            buttonNext.Enabled = true;
            lastRow = dataGridView1.CurrentRow.Index;
        }

        private void FillSelectedRow()
        {
            try
            {
                lineID.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                lineNum.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                lineCompany.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
                lineFromStation.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
                lineToStation.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
                lineNumStations.Text = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
                lineMinutes.Text = dataGridView1.SelectedRows[0].Cells[6].Value.ToString();
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

