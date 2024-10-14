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
    public partial class FormLines : Form
    {
        public FormLines()
        {
            InitializeComponent();
        }

        private void FormLines_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSetLines.tblLines' table. You can move, or remove it, as needed.
            this.tblLinesTableAdapter.Fill(this.dataSetLines.tblLines);

        }

        private void SaveButtonClick(object sender, EventArgs e)
        {
            try
            {
                DataSetLines changes = (DataSetLines)dataSetLines.GetChanges();
                if (changes == null)
                    return;
                // check for errors
                DataTable dt = changes.tblLines.GetChanges();
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
                int numRows = tblLinesTableAdapter.Update(changes);
                MessageBox.Show("Updated " + numRows + " rows", "Success");
                dataSetLines.AcceptChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Erros",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
                dataSetLines.RejectChanges();
            }
        }
    }
}
