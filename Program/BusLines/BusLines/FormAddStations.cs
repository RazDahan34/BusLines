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
    public partial class FormAddStations : Form
    {
        OleDbConnection dataConnection;
        public FormAddStations(OleDbConnection dataConnection)
        {
            InitializeComponent();
            this.dataConnection = dataConnection;
            FillLocationCombo();
        }

        private void FillLocationCombo()
        {
            try
            {
                OleDbCommand datacommand = new OleDbCommand();
                datacommand.Connection = dataConnection;
                datacommand.CommandText = "SELECT locatName " +
                                          "FROM tblLocations ";
                OleDbDataReader dataReader = datacommand.ExecuteReader();
                while (dataReader.Read())
                {
                    stationLocation.Items.Add(dataReader.GetString(0));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Filling locations combobox failed " + ex.Message,
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
                                    ("INSERT INTO tblStations " +
                                     "(stationName,stationLocation, stationStreet, stationPicture ) " +
                                     " VALUES ( \"{0}\", \"{1}\", \"{2}\", \"{3}\" )",
                                       stationName.Text,stationLocation.Text, stationStreet.Text, stationPicture.Text);
                datacommand.CommandText = str;
                OleDbDataReader dataReader = datacommand.ExecuteReader();
                MessageBox.Show("Adding a station ended successfully");
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
                                 "FROM     tblStations " +
                                 "ORDER BY stationID";
            OleDbDataAdapter dataAdapter = new OleDbDataAdapter(sqlCommand, dataConnection);
            DataTable tbl = new DataTable();
            dataAdapter.Fill(tbl);
            dataGridView1.DataSource = tbl;
            dataGridView1.AllowUserToAddRows = false;
        }
        

        private void BrowsePictureClick(object sender, EventArgs e)
        {
            DialogResult dlgResult = openFileDialog1.ShowDialog();
            string pictureFileName = openFileDialog1.FileName;
            pictureBox1.ImageLocation = pictureFileName;
            stationPicture.Text = pictureFileName;
        }

        private void FormAddStations_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSetStations.tblStations' table. You can move, or remove it, as needed.
            this.tblStationsTableAdapter.Fill(this.dataSetStations.tblStations);

        }
    }
}
