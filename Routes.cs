using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fleet_Manager
{
    internal class Routes
    {
        int routeID;
        string loc1;
        string loc2;
        string loc3;
        string loc4;
        string loc5;
        int totalKms;
        double avgKms;

        public int _routeID
        {
            get { return routeID; }
            set { routeID = value; }
        }

        public string _loc1
        {
            get { return loc1; }
            set { loc1 = value; }
        }

        public string _loc2
        {
            get { return loc2; }
            set { loc2 = value; }
        }

        public string _loc3
        {
            get { return loc3; }
            set { loc3 = value; }
        }

        public string _loc4
        {
            get { return loc4; }
            set { loc4 = value; }
        }

        public string _loc5
        {
            get { return loc5; }
            set { loc5 = value; }
        }

        public int _totalKms
        {
            get { return totalKms; }
            set { totalKms = value; }
        }

        public double _avgKms
        {
            get { return avgKms; }
            set { avgKms = value; }
        }

        public Routes() { }

        public Routes(int _routeID, string _loc1, string _loc2, string _loc3, string _loc4, string _loc5, int _totalKms, double _avgKms)
        {
            this.routeID = _routeID;
            this.loc1 = _loc1;
            this.loc2 = _loc2;
            this.loc3 = _loc3;
            this.loc4 = _loc4;
            this.loc5 = _loc5;
            this.totalKms = _totalKms;
            this.avgKms = _avgKms;
        }
    }
}
