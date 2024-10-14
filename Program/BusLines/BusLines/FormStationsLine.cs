using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BusLines
{
    public partial class FormStationsLine : Form
    {
        public FormStationsLine()
        {
            InitializeComponent();
        }

        private void FormStationsLine_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSetStationsLine.tblStationsLine' table. You can move, or remove it, as needed.
            this.tblStationsLineTableAdapter.Fill(this.dataSetStationsLine.tblStationsLine);

        }

        private void SaveButtonClick(object sender, EventArgs e)
        {
            try
            {
                DataSetStationsLine changes = (DataSetStationsLine)dataSetStationsLine.GetChanges();
                if (changes == null)
                    return;
                // check for errors
                DataTable dt = changes.tblStationsLine.GetChanges();
                DataRow[] badRows = dt.GetErrors();
                //find the errors and tell the user
                if (badRows.Length > 0)
                {
                    string errorMsg = "";
                    foreach (DataRow row in badRows)
                    {
                        foreach (DataColumn col in row.GetColumnsInError())
                        {
                            errorMsg = errorMsg + row.GetColumnsInError() + "\n";
                        }
                    }
                    MessageBox.Show("Errors in data: " + errorMsg,
                    "Please fix", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                //no error found, update the database
                int numRows = tblStationsLineTableAdapter.Update(changes);
                MessageBox.Show("Updated " + numRows + " rows", "Success");
                dataSetStationsLine.AcceptChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Erros",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
                dataSetStationsLine.RejectChanges();
            }
        }
    }
}
