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
    public partial class FormAddSpecialTypes : Form
    {
        OleDbConnection dataConnection;
        public FormAddSpecialTypes(OleDbConnection dataConnection)
        {
            InitializeComponent();
            this.dataConnection = dataConnection;
        }

        private void FormAddSpecialTypes_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSetSpecialTypes.tblSpecialTypes' table. You can move, or remove it, as needed.
            this.tblSpecialTypesTableAdapter.Fill(this.dataSetSpecialTypes.tblSpecialTypes);

        }

        private void AddButtonClick(object sender, EventArgs e)
        {
            try
            {
                OleDbCommand datacommand = new OleDbCommand();
                datacommand.Connection = dataConnection;
                string str = string.Format
                                    ("INSERT INTO tblSpecialTypes " +
                                     "(specialDayType ) " +
                                     " VALUES ( \"{0}\" )",
                                       specialDayType.Text);
                datacommand.CommandText = str;
                OleDbDataReader dataReader = datacommand.ExecuteReader();
                MessageBox.Show("Adding a special day type ended successfully");
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
                                 "FROM     tblSpecialTypes " +
                                 "ORDER BY specialDayType";
            OleDbDataAdapter dataAdapter = new OleDbDataAdapter(sqlCommand, dataConnection);
            DataTable tbl = new DataTable();
            dataAdapter.Fill(tbl);
            dataGridView1.DataSource = tbl;
            dataGridView1.AllowUserToAddRows = false;
        }
    }
}

