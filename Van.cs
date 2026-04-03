using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fleet_Manager
{
    internal class Van : Vehicle
    {
        public Van(int _vehicleID, int _mileage, int _currentJob, int _year, string _brand, string _model, string _licensePlate)
        : base(_vehicleID, _mileage, _currentJob, _year, _brand, _model, _licensePlate)
        {
            this.type = "Van";
        }
    }
}
