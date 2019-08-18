using System;
using System.Collections.Generic;
using System.Text;

namespace BaiTap3
{
    class Vehicles
    {
        protected string make;
        protected string model;
        protected string year;
        public Vehicles()
        {

        }
        public Vehicles(string Make, string Model, string Year)
        {
            make = Make;
            model = Model;
            year = Year;
        }
        public string Make
        {
            set{ make = value; }
            get{ return make; }
        }
        public string Model
        {
            set{ model = value; }
            get{ return model; }
        }
        public string Year
        {
            set { year = value; }
            get { return year; }
        }
        public void Accelerate()
        {

        }

        public void Decelerate()
        {

        }

        public void Drive()
        {
           
        }

        public void Start()
        {

        }

        public void Stop()
        {

        }
    }
    class Car : Vehicles
    {

    }
    class Sportscar : Car
    {

    }
    class Van : Vehicles
    {

    }

    class ExcursionVan : Van
    {

    }

    class Minivan : Van
    {
        protected bool cargo_Net;
        protected bool dual_Sliding_Doors;

        public Minivan()
        {
        }

        public Minivan(bool Cargo_Net, bool Dual_Sliding_Doors)
        {
            cargo_Net = Cargo_Net;
            dual_Sliding_Doors = Dual_Sliding_Doors;
        }

        public void SetCargoNet(bool Cargo_Net)
        {
            cargo_Net = Cargo_Net;
        }

        public void SetDualSlidingDoors(bool Dual_Sliding_Doors)
        {
            dual_Sliding_Doors = Dual_Sliding_Doors;
        }

        public bool GetCargoNet()
        {
            return cargo_Net;
        }

        public bool GetDualSlidingDoors()
        {
            return dual_Sliding_Doors;
        }
    }

    class TestVehicles
    {
        static void Main()
        {
            Car myCar = new Car();
            myCar.Drive();

            Sportscar mySportsCar = new Sportscar();
            mySportsCar.Drive();

            Van myVan = new Van();
            myVan.Drive();

            Minivan myMiniVan = new Minivan();
            myMiniVan.Drive();

            ExcursionVan myExcursionVan = new ExcursionVan();
            myExcursionVan.Drive();
            Console.ReadKey();
        }
    }
}
