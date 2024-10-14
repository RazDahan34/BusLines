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
    public partial class FormMenu : Form
    {
        private OleDbConnection dataConnection;
        public FormMenu(OleDbConnection dataConnection, bool IsManager)
        {
            InitializeComponent();
            this.dataConnection = dataConnection;
            if (IsManager == false)
            {
                tabelsToolStripMenuItem.Enabled = false;
                addToolStripMenuItem.Enabled = false;
                UpdateToolStripMenuItem.Enabled = false;
            }
        }

        private void UsersClick(object sender, EventArgs e)
        {
            FormUsers frUser = new FormUsers();
            frUser.Show();
        }

        private void CompaniesClick(object sender, EventArgs e)
        {
            FormCompanies frCompany = new FormCompanies();
            frCompany.Show();
        }

        private void LocationsClick(object sender, EventArgs e)
        {
            FormLocations frLocation = new FormLocations();
            frLocation.Show();
        }

        private void CitiesClick(object sender, EventArgs e)
        {
            FormCities frCity = new FormCities();
            frCity.Show();
        }

        private void LinesClick(object sender, EventArgs e)
        {
            FormLines frLine = new FormLines();
            frLine.Show();
        }

        private void StationsClick(object sender, EventArgs e)
        {
            FormStations frStation = new FormStations();
            frStation.Show();
        }

        private void StationsLineClick(object sender, EventArgs e)
        {
            FormStationsLine frStationLine = new FormStationsLine();
            frStationLine.Show();
        }

        private void TimesClick(object sender, EventArgs e)
        {
            FormTimes frTime = new FormTimes();
            frTime.Show();
        }

        private void SpecialDaysClick(object sender, EventArgs e)
        {
            FormSpecialDays frSpecialDay = new FormSpecialDays();
            frSpecialDay.Show();
        }

        private void SpecialTypesClick(object sender, EventArgs e)
        {
            FormSpecialTypes frSpecialType = new FormSpecialTypes();
            frSpecialType.Show();
        }

        private void SpecialStationsClick(object sender, EventArgs e)
        {
            FormSpecialStations frSpecialStation = new FormSpecialStations();
            frSpecialStation.Show();
        }

        private void addUsersClick(object sender, EventArgs e)
        {
            this.Hide();
            FormAddUsers frmAdd = new FormAddUsers(dataConnection);
            frmAdd.Show();
            frmAdd.Disposed += new EventHandler(Form_Disposed);
        }

        void Form_Disposed(object sender, EventArgs e)
        {
            this.Show();
            this.Activate();
        }

        private void addCompaniesClick(object sender, EventArgs e)
        {
            this.Hide();
            FormAddCompanies frmAdd = new FormAddCompanies(dataConnection);
            frmAdd.Show();
            frmAdd.Disposed += new EventHandler(Form_Disposed); 
        }

        private void addLocationsClick(object sender, EventArgs e)
        {
            this.Hide();
            FormAddLocations frmAdd = new FormAddLocations(dataConnection);
            frmAdd.Show();
            frmAdd.Disposed += new EventHandler(Form_Disposed); 
        }

        private void addCitiesClick(object sender, EventArgs e)
        {
            this.Hide();
            FormAddCities frmAdd = new FormAddCities(dataConnection);
            frmAdd.Show();
            frmAdd.Disposed += new EventHandler(Form_Disposed);
        }

        private void addLinesClick(object sender, EventArgs e)
        {
            this.Hide();
            FormAddLines frmAdd = new FormAddLines(dataConnection);
            frmAdd.Show();
            frmAdd.Disposed += new EventHandler(Form_Disposed);
        }

        private void addStationsClick(object sender, EventArgs e)
        {
            this.Hide();
            FormAddStations frmAdd = new FormAddStations(dataConnection);
            frmAdd.Show();
            frmAdd.Disposed += new EventHandler(Form_Disposed);
        }

        private void addStationsLineClick(object sender, EventArgs e)
        {
            this.Hide();
            FormAddStationsLine frmAdd = new FormAddStationsLine(dataConnection);
            frmAdd.Show();
            frmAdd.Disposed += new EventHandler(Form_Disposed);
        }

        private void addTimesClick(object sender, EventArgs e)
        {
            this.Hide();
            FormAddTimes frmAdd = new FormAddTimes(dataConnection);
            frmAdd.Show();
            frmAdd.Disposed += new EventHandler(Form_Disposed);
        }

        private void addSpecialDaysClick(object sender, EventArgs e)
        {
            this.Hide();
            FormAddSpecialDays frmAdd = new FormAddSpecialDays(dataConnection);
            frmAdd.Show();
            frmAdd.Disposed += new EventHandler(Form_Disposed);
        }

        private void addSpecialTypesClick(object sender, EventArgs e)
        {
            this.Hide();
            FormAddSpecialTypes frmAdd = new FormAddSpecialTypes(dataConnection);
            frmAdd.Show();
            frmAdd.Disposed += new EventHandler(Form_Disposed);
        }

        private void addSpecialStationClick(object sender, EventArgs e)
        {
            this.Hide();
            FormAddSpecialStations frmAdd = new FormAddSpecialStations(dataConnection);
            frmAdd.Show();
            frmAdd.Disposed += new EventHandler(Form_Disposed);
        }

        private void updateUsersClick(object sender, EventArgs e)
        {
            this.Hide();
            FormUpdateUsers frmUpdate = new FormUpdateUsers(dataConnection);
            frmUpdate.Show();
            frmUpdate.Disposed += new EventHandler(Form_Disposed);
        }

        private void UpdateCompaniesClick(object sender, EventArgs e)
        {
            this.Hide();
            FormUpdateCompanies frmUpdate = new FormUpdateCompanies(dataConnection);
            frmUpdate.Show();
            frmUpdate.Disposed += new EventHandler(Form_Disposed);
        }

        private void UpdateLocationsClick(object sender, EventArgs e)
        {
            this.Hide();
            FormUpdateLocations frmUpdate = new FormUpdateLocations(dataConnection);
            frmUpdate.Show();
            frmUpdate.Disposed += new EventHandler(Form_Disposed);
        }

        private void UpdateLinesClick(object sender, EventArgs e)
        {
            this.Hide();
            FormUpdateLines frmUpdate = new FormUpdateLines(dataConnection);
            frmUpdate.Show();
            frmUpdate.Disposed += new EventHandler(Form_Disposed);
        }

        private void UpdateStationsClick(object sender, EventArgs e)
        {
            this.Hide();
            FormUpdateStations frmUpdate = new FormUpdateStations(dataConnection);
            frmUpdate.Show();
            frmUpdate.Disposed += new EventHandler(Form_Disposed);
        }

        private void UpdateStationsLineClick(object sender, EventArgs e)
        {
            this.Hide();
            FormUpdateStationsLine frmUpdate = new FormUpdateStationsLine(dataConnection);
            frmUpdate.Show();
            frmUpdate.Disposed += new EventHandler(Form_Disposed);
        }

        private void UpdateSpecialDays(object sender, EventArgs e)
        {
            this.Hide();
            FormUpdateSpecialDays frmUpdate = new FormUpdateSpecialDays(dataConnection);
            frmUpdate.Show();
            frmUpdate.Disposed += new EventHandler(Form_Disposed);
        }

        private void trackClick(object sender, EventArgs e)
        {
            this.Hide();
            FormRptLineStations frmRLS = new FormRptLineStations(dataConnection);
            frmRLS.Show();
            frmRLS.Disposed += new EventHandler(Form_Disposed);
        }

        private void stationReport(object sender, EventArgs e)
        {
            this.Hide();
            FormRpt_LinesInStation frmRLIS = new FormRpt_LinesInStation(dataConnection);
            frmRLIS.Show();
            frmRLIS.Disposed += new EventHandler(Form_Disposed);
        }

        private void linesInCityReport(object sender, EventArgs e)
        {
            this.Hide();
            FormRpt_LinesInCity frmRLIC = new FormRpt_LinesInCity(dataConnection);
            frmRLIC.Show();
            frmRLIC.Disposed += new EventHandler(Form_Disposed);
        }

        private void linesInCompanyReport(object sender, EventArgs e)
        {
            this.Hide();
            FormRpt_LinesInCompany frmRLIC = new FormRpt_LinesInCompany(dataConnection);
            frmRLIC.Show();
            frmRLIC.Disposed += new EventHandler(Form_Disposed);
        }

        private void wayOneBusClick(object sender, EventArgs e)
        {
            this.Hide();
            FormRptWayOneBus frmRWOB= new FormRptWayOneBus(dataConnection);
            frmRWOB.Show();
            frmRWOB.Disposed += new EventHandler(Form_Disposed);
        }

        private void wayTwoBusClick(object sender, EventArgs e)
        {
            this.Hide();
            FormRptWayTwoBus frmRWTB = new FormRptWayTwoBus(dataConnection);
            frmRWTB.Show();
            frmRWTB.Disposed += new EventHandler(Form_Disposed);
        }

    }
}

