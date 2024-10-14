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
    public partial class FormLogin : Form
    {
        private OleDbConnection dataConnection;
        public FormLogin()
        {
            InitializeComponent();
            OpenDb();
        }
        private void OpenDb()
        {
            dataConnection = new OleDbConnection();
            try
            {
                dataConnection.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Project_RazDahan\\Access\\dbBusLines.accdb";
                dataConnection.Open();
            }
            catch (Exception e)
            {
                MessageBox.Show("Error accessing the database: " +
                e.Message,
                "Errors",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);
            }
        }

        private void CheckButtonClick(object sender, EventArgs e)
        {
            string line, password;
            int id;
            try
            {
                OleDbCommand datacommand = new OleDbCommand();
                datacommand.Connection = dataConnection;
                datacommand.CommandText = "SELECT userID, userPassword, userIsManager " +
                "FROM tblUsers " +
                "WHERE userID = " + this.idNumber.Text;
                OleDbDataReader dataReader = datacommand.ExecuteReader();
                dataReader.Read();
                id = dataReader.GetInt32(0);
                password = dataReader.GetString(1);
                if (password == this.password.Text)
                {
                    this.Hide();
                    FormMenu frMenu = new FormMenu(dataConnection,dataReader.GetBoolean(2));
                    frMenu.Show();
                    frMenu.Disposed += new EventHandler(frMenu_Dispose);
                }
                else
                {
                    line = "Invalid password: " + this.password.Text;
                    MessageBox.Show(line, "Error");
                }
            }
            catch (Exception err)
            {
                line = "Invalid id: " + this.idNumber.Text;
                MessageBox.Show(line, "Error");
            }
        }
        void frMenu_Dispose(object sender, EventArgs e)
        {
            this.idNumber.Text = "";
            this.password.Text = "";
            this.Show();
            this.Activate();
        }
    }
}

