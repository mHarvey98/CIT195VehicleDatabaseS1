using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleDatabase.Models
{
    public class Vehicle
    {
        public string _imageFileName;



        public string VehicleType { get; set; }

        public string Model { get; set; }

        public string SubModel { get; set; }

        public string Color { get; set; }

        public string Brand { get; set; }

        public int Year { get; set; }

        public int Mileage { get; set; }

        public string DateOfPurchase { get; set; }

        public int InitialCost { get; set; }

        public int OverallCost { get; set; }

        public string EngineSize { get; set; }

        public string TransmissionType { get; set; }

        public string DriveTrain { get; set; }

        public int NumberOfGears { get; set; }

        public string FuelType { get; set; }

        public int FuelEconomy { get; set; }

        public int OilCapacity { get; set; }

        public string OilFilter { get; set; }

        public string AirFilter { get; set; }

        public string ServiceManualLink { get; set; }

        public string Notes { get; set; }

        public string ImageFileName
        {
            get { return _imageFileName; }
            set { _imageFileName = value; }
        }

        public string ImageFilePath
        {
            get { return @"../Images/" + _imageFileName; }
        }


        // instantiate a list of maintenance records for 'Vehicle' Class
        public List<MaintenanceRecord> maintenanceRecord = new List<MaintenanceRecord>();



        // Nested maintenance items class.
        public class MaintenanceRecord
        {
            public List<string> toolsRequired = new List<string> { };
            public List<string> partsRequired = new List<string> { };

            public string MaintenanceDate { get; set; }

            public int Mileage { get; set; }

            public string PreventativeOrRequired { get; set; }

            public string MaintenanceTitle { get; set; }

            /// <summary>
            /// Make this a list of values. DONE
            /// </summary>
            public List<string> ToolsRequired { get; set; }

            /// <summary>
            /// Make this a list of values. DONE
            /// </summary>
            public List<string> PartsRequired { get; set; }

            public int OverallCost { get; set; }

            public string Description { get; set; }

            /// <summary>
            /// Not sure what value type here
            /// </summary>
            public string Images { get; set; }
        }
    }


}
