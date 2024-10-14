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
    public partial class FormAddCompanies : Form
    {
        OleDbConnection dataConnection;
        string saveColor;
        public FormAddCompanies(OleDbConnection dataConnection)
        {
            InitializeComponent();
            this.dataConnection = dataConnection;
            FillLocationCombo();
        }

        private void FormAddCompanies_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSetCompanies.tblCompanies' table. You can move, or remove it, as needed.
            this.tblCompaniesTableAdapter.Fill(this.dataSetCompanies.tblCompanies);

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
                    compLocation.Items.Add(dataReader.GetString(0));
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
                                    ("INSERT INTO tblCompanies " +
                                     "(compName, compAddress, compLocation, compPhone, compPicture, compColor ) " +
                                     " VALUES ( {0}, \"{1}\", \"{2}\", \"{3}\", \"{4}\", \"{5}\" )",
                                       compName.Text, compAddress.Text, compLocation.Text, compPhone.Text, compPicture.Text, compColor.Text);
                datacommand.CommandText = str;
                OleDbDataReader dataReader = datacommand.ExecuteReader();
                MessageBox.Show("Adding a company ended successfully");
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
                                 "FROM     tblCompanies " +
                                 "ORDER BY compName";
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
            compPicture.Text = pictureFileName;
        }

        private void ChangeColorClick(object sender, EventArgs e)
        {
            ColorDialog cd = new ColorDialog();
            cd.ShowDialog();
            color.BackColor = cd.Color;
            saveColor = color.BackColor.ToArgb().ToString();
            compColor.Text = saveColor;
            MessageBox.Show("color value:   " + saveColor);
        }


    }
}

