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
    public partial class FormAddSpecialDays : Form
    {
        OleDbConnection dataConnection;
        public FormAddSpecialDays(OleDbConnection dataConnection)
        {
            InitializeComponent();
            this.dataConnection = dataConnection;
            FillSpecialDayTypeCombo();
        }

        private void FormAddSpecialDays_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSetSpecialDays.tblSpecialDays' table. You can move, or remove it, as needed.
            this.tblSpecialDaysTableAdapter.Fill(this.dataSetSpecialDays.tblSpecialDays);
            // TODO: This line of code loads data into the 'dataSetSpecialDays.tblSpecialDays' table. You can move, or remove it, as needed.
            this.tblSpecialDaysTableAdapter.Fill(this.dataSetSpecialDays.tblSpecialDays);
            // TODO: This line of code loads data into the 'dataSetSpecialDays.tblSpecialDays' table. You can move, or remove it, as needed.
            this.tblSpecialDaysTableAdapter.Fill(this.dataSetSpecialDays.tblSpecialDays);

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

        private void AddButtonClick(object sender, EventArgs e)
        {
            try
            {
                OleDbCommand datacommand = new OleDbCommand();
                datacommand.Connection = dataConnection;
                string str = string.Format
                                    ("INSERT INTO tblSpecialDays " +
                                     "(dayDate, dayType, dayStartDate, dayEndDate) " +
                                     " VALUES ( \"{0}\", \"{1}\", \"{2}\", \"{3}\" )",
                                       dayDate.Text, dayType.Text, dayStartDate.Text, dayEndDate.Text);
                datacommand.CommandText = str;
                OleDbDataReader dataReader = datacommand.ExecuteReader();
                MessageBox.Show("Adding a SpecialDay ended successfully");
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
                                 "FROM     tblSpecialDays " +
                                 "ORDER BY dayID";
            OleDbDataAdapter dataAdapter = new OleDbDataAdapter(sqlCommand, dataConnection);
            DataTable tbl = new DataTable();
            dataAdapter.Fill(tbl);
            dataGridView1.DataSource = tbl;
            dataGridView1.AllowUserToAddRows = false;
        }
    }
}
