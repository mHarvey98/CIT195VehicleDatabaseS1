using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using VehicleDatabase.Models;

namespace VehicleDatabase.Views
{
    /// <summary>
    /// Interaction logic for VehiclesDatabaseViews.xaml
    /// </summary>
    public partial class VehiclesDatabaseViews : Window
    {
        #region FIELDS

        VehicleDatabasePresenter _vehicleDatabasePresenter;

        #endregion

        #region METHODS (pass events to view model)

        //private void Button_Quit_Click(object sender, RoutedEventArgs e)
        //{
        //    _productWindowPresenter.QuitApplication();
        //}

        #endregion

        #region CONSTRUCTORS 

        public VehiclesDatabaseViews(VehicleDatabasePresenter vehiclePresenter)
        {
            _vehicleDatabasePresenter = vehiclePresenter;

            DataContext = _vehicleDatabasePresenter;

            InitializeComponent();
        }

        #endregion
    }
}
