using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleDatabase.Models
{
    public class Vehicle
    {
        public string VehicleType
        {
            get => default(string);
            set
            {
            }
        }

        public string Model
        {
            get => default(string);
            set
            {
            }
        }

        public string SubModel
        {
            get => default(string);
            set
            {
            }
        }

        public string Color
        {
            get => default(string);
            set
            {
            }
        }

        public string Brand
        {
            get => default(string);
            set
            {
            }
        }

        public int Year
        {
            get => default(int);
            set
            {
            }
        }

        public int Mileage
        {
            get => default(int);
            set
            {
            }
        }

        public string DateOfPurchase
        {
            get => default(string);
            set
            {
            }
        }

        public int InitialCost
        {
            get => default(int);
            set
            {
            }
        }

        public int OverallCost
        {
            get => default(int);
            set
            {
            }
        }

        public string EngineSize
        {
            get => default(string);
            set
            {
            }
        }

        public string TransmissionType
        {
            get => default(string);
            set
            {
            }
        }

        public string DriveTrain
        {
            get => default(string);
            set
            {
            }
        }

        public int NumberOfGears
        {
            get => default(int);
            set
            {
            }
        }

        public string FuelType
        {
            get => default(string);
            set
            {
            }
        }

        public int FuelEconomy
        {
            get => default(int);
            set
            {
            }
        }

        public int OilCapacity
        {
            get => default(int);
            set
            {
            }
        }

        public string OilFilter
        {
            get => default(string);
            set
            {
            }
        }

        public string AirFilter
        {
            get => default(string);
            set
            {
            }
        }

        public string ServiceManualLink
        {
            get => default(string);
            set
            {
            }
        }

        public string Notes
        {
            get => default(string);
            set
            {
            }
        }

        /// <summary>
        /// Not sure what value type here
        /// </summary>
        public string Images
        {
            get => default(string);
            set
            {
            }
        }




        // instantiate one maintenance record for 'Vehicle' Class
        public MaintenanceRecord maintenanceRecord = new MaintenanceRecord();

        // instantiate a list of maintenance records for 'Vehicle' Class (doesn't work yet)
        //public List<MaintenanceRecord> maintenanceRecord = new List<MaintenanceRecord>();



        // Nested maintenance items class.
        public class MaintenanceRecord
        {
            public List<string> toolsRequired = new List<string> { };
            public List<string> partsRequired = new List<string> { };

            public string MaintenanceDate
            {
                get => default(string);
                set
                {
                }
            }

            public int Mileage
            {
                get => default(int);
                set
                {
                }
            }

            public string PreventativeOrRequired
            {
                get => default(string);
                set
                {
                }
            }

            public string MaintenanceTitle
            {
                get => default(string);
                set
                {
                }
            }

            /// <summary>
            /// Make this a list of values. DONE
            /// </summary>
            public List<string> ToolsRequired
            {
                get => default(List<string>);
                set
                {
                }
            }

            /// <summary>
            /// Make this a list of values. DONE
            /// </summary>
            public List<string> PartsRequired
            {
                get => default(List<string>);
                set
                {
                }
            }

            public int OverallCost
            {
                get => default(int);
                set
                {
                }
            }

            public string Description
            {
                get => default(string);
                set
                {
                }
            }

            /// <summary>
            /// Not sure what value type here
            /// </summary>
            public string Images
            {
                get => default(string);
                set
                {
                }
            }
        }
    }


}
