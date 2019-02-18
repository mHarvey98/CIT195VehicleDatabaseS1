using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using VehicleDatabase.Views;
using VehicleDatabase.Models;

namespace VehicleDatabase.BusinessLayer
{
    public class VehicleBL
    {
        //public List<Vehicle.MaintenanceRecord> maintenanceRecords;  Maybe not needed
        #region ENUMS

        VehiclesDatabaseViews _vehicleDatabaseView;
        VehicleDatabasePresenter _vehicleDatabasePresenter;

        #endregion

        #region FIELDS



        #endregion

        #region PROPERTIES

        #endregion

        #region CONSTRUCTORS
        public VehicleBL()
        {
            //
            // instantiate the view model and initialize the data set
            //
            _vehicleDatabasePresenter = new VehicleDatabasePresenter(GetOwnerData(), GetVehicleData());
            //_vehicleDatabasePresenter = new VehicleDatabasePresenter(GetOwnerData(), GetVehicleData(), GetMaintenanceRecords());


            //
            // instantiate, set the data context, and show the Main Window
            //
            _vehicleDatabaseView = new VehiclesDatabaseViews(_vehicleDatabasePresenter);
            _vehicleDatabaseView.DataContext = _vehicleDatabasePresenter;
            _vehicleDatabaseView.Show();
        }

        //private List<Vehicle.MaintenanceRecord> GetMaintenanceRecords()
        //{
        //    throw new NotImplementedException();
        //}

        private Vehicle GetVehicleData()
        {
            return new Vehicle() // 'Bigger, Badder' Way to Instantiate an object
            {
                VehicleType = "Small SUV",
                Model = "Blazer",
                SubModel = "LS",
                Color = "Forrest Green",
                Brand = "Chevrolet",
                Year = 2003,
                Mileage = 166000,
                DateOfPurchase = "02/2016",
                InitialCost = 2400,
                OverallCost = 4000,
                EngineSize = "4.3L v6",
                TransmissionType = "Manual",
                DriveTrain = "4WD",
                NumberOfGears = 5,
                FuelType = "Gasoline",
                OilCapacity = 5,
                OilFilter = "FIL 7060 (NAPA)",
                AirFilter = "SFL 36117 (NAPA)",
                maintenanceRecord = new Vehicle.MaintenanceRecord
                {
                    MaintenanceDate = "05/12/2018",
                    Mileage = 160000,
                    PreventativeOrRequired = "Required",
                    MaintenanceTitle = "Rear-Driver's Brake Caliper Replacement",
                    ToolsRequired = new List<string> { "3/8\" Drive Rachet Wrench", "18mm Socket", "Hammer", "12mm Wrench", "Patience" },
                    PartsRequired = new List<string> { "Brake Caliper Assembly", "Brake Discs", "Brake Pads", "DOT 3 Brake Fluid" },
                    OverallCost = 140,
                    Description = "Brake caliper had seized, destroying all brake components for R-D Wheel.",
                    Images = ""
                }
            };

        }

        private Owner GetOwnerData()
        {
            Owner owner = new Owner();

            owner.Name = "M. Harvey Fleet Inc.";
            owner.Address = "123 First St.";
            owner.City = "Traverse City";

            return owner;
        }

        #endregion

        #region METHODS



        #endregion

        #region EVENTS


        #endregion

    }
}
