using VehicleDatabase;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace VehicleDatabase.Models
{
    public class VehicleDatabasePresenter
    {

        #region ENUMS


        #endregion

        #region FIELDS

        private Owner _ownerInfo;
        private Vehicle _selectedVehicle;

        #endregion

        #region PROPERTIES

        public Owner OwnerInfo
        {
            get { return _ownerInfo; }
            set { _ownerInfo = value; }
        }

        public Vehicle SelectedProduct
        {
            get { return _selectedVehicle; }
            set { _selectedVehicle = value; }
        }

        #endregion

        #region CONSTRUCTORS

        public VehicleDatabasePresenter(Owner owner, Vehicle vehicle)
        {
            _selectedVehicle = vehicle;
            _ownerInfo = owner;
        }

        #endregion

        #region METHODS

        public void QuitApplication()
        {
            Environment.Exit(0);
        }

        #endregion

        #region EVENTS


        #endregion


    }
}

