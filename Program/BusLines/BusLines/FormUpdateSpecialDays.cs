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
    public partial class FormUpdateSpecialDays : Form
    {
        OleDbConnection dataConnection;
        private int lastRow = 0;
        public FormUpdateSpecialDays(OleDbConnection dataConnection)
        {
            InitializeComponent();
            this.dataConnection = dataConnection;
            FillSpecialDayTypeCombo();
        }

        
        private void FillSpecialDayTypeCombo()
        {
            try
            {
                OleDbCommand datacommand = new OleDbCommand();
                datacommand.Connection = dataConnection;
                datacommand.CommandText = "SELECT specialDayType " +
                                          "FROM tblSpecialTypes ";
                OleDbDataReader dataReader = datacommand.ExecuteReader();
                while (dataReader.Read())
                {
                    dayType.Items.Add(dataReader.GetString(0));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Filling Special Day Type combobox failed " + ex.Message,
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
                datacommand.CommandText = "UPDATE tblSpecialDays " +
                                          "SET     dayDate =               \"" + dayDate.Text + "\" , " +
                                                  "dayType  =              \"" + dayType.Text + "\" , " +
                                                  "dayStartDate  =         \"" + dayStartDate.Text + "\" , " +
                                                  "dayEndDate    =         \"" + dayEndDate.Text + "\"    " +
                                          "WHERE dayID =  " + dayID.Text;
                OleDbDataReader dataReader = datacommand.ExecuteReader();
                RefreshDataGridView();
                MessageBox.Show("Update tblSpecialDays ended successfluly");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Update special days table failed " +
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
                                     "FROM     tblSpecialDays " +
                                     "ORDER BY dayID";
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
                dayID.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                dayDate.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                dayType.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
                dayStartDate.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
                dayEndDate.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
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

        private void FormUpdateSpecialDays_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSetSpecialDays.tblSpecialDays' table. You can move, or remove it, as needed.
            this.tblSpecialDaysTableAdapter.Fill(this.dataSetSpecialDays.tblSpecialDays);

        }
    }
}
