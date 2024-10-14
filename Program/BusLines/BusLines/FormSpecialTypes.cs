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
    public partial class FormSpecialTypes : Form
    {
        public FormSpecialTypes()
        {
            InitializeComponent();
        }

        private void FormSpecialTypes_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSetSpecialTypes.tblSpecialTypes' table. You can move, or remove it, as needed.
            this.tblSpecialTypesTableAdapter.Fill(this.dataSetSpecialTypes.tblSpecialTypes);

        }

        private void SaveButtonClick(object sender, EventArgs e)
        {
            try
            {
                DataSetSpecialTypes changes = (DataSetSpecialTypes)dataSetSpecialTypes.GetChanges();
                if (changes == null)
                    return;
                // check for errors
                DataTable dt = changes.tblSpecialTypes.GetChanges();
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
                int numRows = tblSpecialTypesTableAdapter.Update(changes);
                MessageBox.Show("Updated " + numRows + " rows", "Success");
                dataSetSpecialTypes.AcceptChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Erros",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
                dataSetSpecialTypes.RejectChanges();
            }
        }

    }
}
