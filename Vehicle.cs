using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fleet_Manager
{
    internal class Vehicle //Parent class for all vehicles
    {
        int vehicleID;
        int mileage;
        int currentJob;
        string type;
        int year;
        string brand;
        string model;
        string licensePlate;
        int age;

        public int _vehicleID
        {
            get { return vehicleID; }
            set { vehicleID = value; }
        }

        public int _mileage
        {
            get { return mileage; }
            set { mileage = value; }
        }

        public int _currentJob
        {
            get { return currentJob; }
            set { currentJob = value; }
        }

        public string _type
        {
            get { return type; }
            set { type = value; }
        }

        public int _year
        {
            get { return year; }
            set { year = value; }
        }

        public string _brand
        {
            get { return brand; }
            set { brand = value; }
        }

        public string _model
        {
            get { return model; }
            set { model = value; }
        }

        public string _licensePlate
        {
            get { return licensePlate; }
            set { licensePlate = value; }
        }

        public int _age
        {
            get { return age; }
            set { age = value; }
        }
        private int calculateAgeOfCar()
        {
            int currentYear = DateTime.Now.Year;

            return currentYear - this.year;
        }

        public Vehicle() { }

        public Vehicle(int _vehicleID, int _mileage, int _currentJob, string _type, int _year, string _brand, string _model, string _licensePlate)
        {
            this.vehicleID = _vehicleID;
            this.mileage = _mileage;
            this.currentJob = _currentJob;
            this.type = _type;
            this.year = _year;
            this.brand = _brand;
            this.model = _model;
            this.licensePlate = _licensePlate;
            this.age = calculateAgeOfCar();
        }
    }

}
