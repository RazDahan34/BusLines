using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BusLines
{
    public class Station
    {
        public int    stationID;
        public string stationName;
        public string stationLocation;
        public string stationStreet;
        public string stationPicture;
        public int    stationMinutes;
        public string stationKind;
        public Station(int stationID, string stationName, string stationLocation, string stationStreet, string stationPicture, int stationMinutes, string stationKind)
        {
            this.stationID       = stationID;
            this.stationName     = stationName;
            this.stationLocation = stationLocation;
            this.stationStreet   = stationStreet;
            this.stationPicture  = stationPicture;
            this.stationMinutes  = stationMinutes;
            this.stationKind     = stationKind;
        }
    }
}
