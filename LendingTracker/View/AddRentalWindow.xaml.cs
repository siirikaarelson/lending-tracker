
using LendingTracker.ViewModel;
using LendingTrackerLibrary;
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

namespace LendingTracker
{
    /// <summary>
    /// Interaction logic for AddRentalWindow.xaml
    /// </summary>
    public partial class AddRentalWindow : Window
    {

        private Rental rental;

        private RentalsVM _rentalVM;

        public AddRentalWindow(RentalsVM rentalVM)
        {

            InitializeComponent();
            rental = new Rental();

            _rentalVM = rentalVM;
            this.DataContext = rental;

        }

        private void btnAddRental_Click(object sender, RoutedEventArgs e)
        {
            _rentalVM.saveRental(rental);      
            Close();
          
        }

        private void btnCancelAddRental_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
