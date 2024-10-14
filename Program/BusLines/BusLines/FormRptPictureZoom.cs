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
    public partial class FormRptPictureZoom : Form
    {
        private OleDbConnection dataConnection;
        private string dayDate;
        private string dayType;
        private DateTime dayStartDate;
        private DateTime dayEndDate;
        private string dayStartDateString = "כרגיל";
        private string dayEndDateString = "כרגיל";
        private int timeHour;
        private int timeMinutes;
        private int lineID;
        public FormRptPictureZoom(int idx, string dayDate, int lineID, string linenum, Station[] arrStations, OleDbConnection dataConnection)
        {
            InitializeComponent();
            this.dataConnection = dataConnection;
            this.lineID = lineID;
            this.dayDate = dayDate;
            name.Text = arrStations[idx].stationLocation + " " + arrStations[idx].stationStreet;
            pictureBox1.ImageLocation = arrStations[idx].stationPicture;
            CheckDate();
            AddDate();
            label6.Text = linenum;
        }

        private void CheckDate()
        {
            try
            {
                OleDbCommand datacommand = new OleDbCommand();
                datacommand.Connection = dataConnection;
                datacommand.CommandText = "SELECT dayDate, dayType, dayStartDate, dayEndDate " +
                                          "FROM   tblSpecialDays ";
                OleDbDataReader dataReader = datacommand.ExecuteReader();
                while (dataReader.Read())
                {
                    if (dayDate == dataReader.GetDateTime(0).ToShortDateString())
                    {
                        dayType = dataReader.GetString(1);
                        if (!dataReader.IsDBNull(2))
                        {
                            dayStartDate = dataReader.GetDateTime(2);
                            dayStartDateString = "";
                        }
                        if (!dataReader.IsDBNull(3))
                        {
                            dayEndDate = dataReader.GetDateTime(3);
                            dayEndDateString = "";
                        }
                    }
                }
                dataReader.Close();
                if (dayStartDateString == "" && dayEndDateString == "")
                {
                    typeDay.Text = dayType;
                    startDate.Text = dayStartDate.ToShortTimeString();
                    EndDate.Text = dayEndDate.ToShortTimeString();
                }
                else
                    if (dayStartDateString == "")
                    {
                        typeDay.Text = dayType;
                        startDate.Text = dayStartDate.ToShortTimeString();
                        EndDate.Text = dayEndDateString;
                    }
                    else
                        if (dayEndDateString == "")
                        {
                            typeDay.Text = dayType;
                            startDate.Text = dayStartDateString;
                            EndDate.Text = dayEndDate.ToShortTimeString();
                        }
                        else
                        {
                            label3.Visible = false;
                            label4.Visible = false;
                            label5.Visible = false;
                            typeDay.Visible = false;
                            startDate.Visible = false;
                            EndDate.Visible = false;
                        }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Select tblSpecialDays failed " + ex.Message,
                                "Errors",
                                 MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AddDate()
        {
            try
            {
                OleDbCommand datacommand = new OleDbCommand();
                datacommand.Connection = dataConnection;
                datacommand.CommandText = "SELECT timeHour, timeMinute " +
                                          "FROM   tblTimes " +
                                          "WHERE  timeLineID = " + lineID + " " +
                                          "ORDER BY timeHour, timeMinute";
                OleDbDataReader dataReader = datacommand.ExecuteReader();
                while (dataReader.Read())
                {
                    timeHour = dataReader.GetInt32(0);
                    timeMinutes = dataReader.GetInt32(1);
                    EditListView();
                }
                dataReader.Close();
            }

            catch (Exception ex)
            {
                MessageBox.Show("Select tblTimes failed " + ex.Message,
                                "Errors",
                                 MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void EditListView()
        {
            string[] arr = new string[2];
            arr[0] = timeMinutes.ToString();
            arr[1] = timeHour.ToString();
            ListViewItem item = new ListViewItem(arr);
            item.ForeColor = Color.Blue;
            listView1.Items.Add(item);
        }
    }
}
