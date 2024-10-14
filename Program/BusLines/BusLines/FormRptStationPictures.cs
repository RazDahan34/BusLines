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
    public partial class FormRptStationPictures : Form
    {
        private OleDbConnection dataConnection;
        private Station[] arrStations;
        private int lngRow;
        private int picWidth = 133, picHight = 110;
        private int lineID;
        private string lineIDD;
        private string dayDate;
        private string numberLine;
        private string direction;
        private int toStationID;
        public FormRptStationPictures(Station[] arrStations, int lngRow, string lineNum, string pictureSize, int lineID, string dayDate, OleDbConnection dataConnection)
        {
            int i;
            InitializeComponent();
            this.dataConnection = dataConnection; 
            this.arrStations = arrStations;
            this.lineID = lineID;
            this.lngRow = lngRow;
            this.dayDate = dayDate;
            lineNumber.Text = lineNum;
            if (pictureSize == "קטן")
            {
                picWidth = 93; 
                picHight = 70;
            }
            if (pictureSize == "גדול")
            {
                picWidth = 173;
                picHight = 150;
            }
            for (i = 0; i < arrStations.Length; i++)
            {
                if (i == 0)
                    fromStation.Text = arrStations[i].stationName + " " + arrStations[i].stationStreet;
                if (i == (arrStations.Length - 1))
                    toStation.Text = arrStations[i].stationName + " " + arrStations[i].stationStreet;
                AddPicture(i);
            }
        }

        private void AddPicture(int k)
        {
            int i = k / lngRow;
            int j = k % lngRow;
            int X = j * (picWidth + 10) + 100;
            int Y = i * (picHight + 70) + 120;
            PictureBox pic = new System.Windows.Forms.PictureBox();
            pic.Location = new System.Drawing.Point(X, Y);
            pic.Name = "picture_" + k.ToString();
            pic.Size = new System.Drawing.Size(picWidth, picHight);
            pic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            pic.ImageLocation = arrStations[k].stationPicture;
            pic.Click += new EventHandler(picture_Click);
            pic.MouseHover += new EventHandler(picture_MouseHover);
            this.Controls.Add(pic);
            RichTextBox txt = new System.Windows.Forms.RichTextBox();
            txt.Multiline = true;
            txt.RightToLeft = RightToLeft.No;
            txt.Text =  (k+1) + "\n" + arrStations[k].stationName + "\n" + arrStations[k].stationStreet + "\n" + arrStations[k].stationLocation;
            //txt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            txt.Location = new System.Drawing.Point(X, Y + picHight);
            txt.Size = new System.Drawing.Size(picWidth, 70);
            this.Controls.Add(txt);
        }

        void picture_Click(object sender, EventArgs e)
        {
            PictureBox pic = (PictureBox)sender;
            int idx = int.Parse(pic.Name.Substring(8));
            this.Hide();
            FormRptPictureZoom frpz = new FormRptPictureZoom(idx, dayDate, lineID, lineNumber.Text, arrStations, dataConnection);
            frpz.Show();
            frpz.Disposed += new EventHandler(Form_Disposed);
        }

        void Form_Disposed(object sender, EventArgs e)
        {
            this.Show();
            this.Activate();
        }

        void picture_MouseHover(object sender, EventArgs e)
        {
            PictureBox pic = (PictureBox)sender;
            string msg = ":הקווים שעוצרים בתחנה זו הם" + "\n";
            try
            {
                OleDbCommand datacommand = new OleDbCommand();
                datacommand.Connection = dataConnection;
                datacommand.CommandText = "SELECT   lineStationLineID " +
                                          "FROM     tblStationsLine " +
                                          "WHERE    lineStationID = " + arrStations[int.Parse(pic.Name.Substring(8))].stationID + " " +
                                          "ORDER BY lineStationLineID ";
                OleDbDataReader dataReader = datacommand.ExecuteReader();
                while (dataReader.Read())
                {
                    lineIDD = dataReader.GetInt32(0).ToString();
                    GetMoreDetails();
                    msg = msg + numberLine + " :לכיוון " + direction + "\n";
                }
                dataReader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Select tblStationsLine failed " + ex.Message,
                                "Errors",
                                 MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            myToolTip.Active = true;
            //MessageBox.Show(msg);      
            myToolTip.AutomaticDelay = 1000;
            myToolTip.SetToolTip(pic, msg);
        }

        private void GetMoreDetails()
        {
            try
            {
                OleDbCommand datacommand = new OleDbCommand();
                datacommand.Connection = dataConnection;
                datacommand.CommandText = "SELECT   lineNum , lineToStation " +
                                          "FROM     tblLines " +
                                          "WHERE    lineID = " + lineIDD;
                OleDbDataReader dataReader = datacommand.ExecuteReader();
                dataReader.Read();
                numberLine = dataReader.GetString(0);
                toStationID = dataReader.GetInt32(1);
                dataReader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Select tblLines failed " + ex.Message,
                                "Errors",
                                 MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            try
            {
                OleDbCommand datacommand2 = new OleDbCommand();
                datacommand2.Connection = dataConnection;
                datacommand2.CommandText = "SELECT  stationLocation " +
                                          "FROM     tblStations " +
                                          "WHERE    stationID = " + toStationID;
                OleDbDataReader dataReader2 = datacommand2.ExecuteReader();
                dataReader2.Read();
                direction = dataReader2.GetString(0);
                dataReader2.Close();
            }

            catch (Exception ex)
            {
                MessageBox.Show("Select tblStations failed " + ex.Message,
                                "Errors",
                                 MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
