
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

        private DBA.Rental _rental;

        private RentalsVM _rentalsVM;
        private ClientVM _clientVM;
        private MoviesVM _moviesVM;
     

        public AddRentalWindow(RentalsVM rentalVM, ClientVM clientVM, MoviesVM moviesVM)
        {

            InitializeComponent();
            _rental = new DBA.Rental();
            this.DataContext = _rental;

            _rentalsVM = rentalVM;
            _clientVM = clientVM;
            _moviesVM = moviesVM;
     
            cboxClient.ItemsSource = _clientVM.getClients();
            listBoxMovies.ItemsSource = _moviesVM.getMovies();

            _rental.StartDate = DateTime.Now;
            _rental.EndDate = DateTime.Now.AddDays(7d);



        }

        public AddRentalWindow(RentalsVM rentalsVM, ClientVM clientVM, MoviesVM moviesVM, DBA.Rental rental)
        {
            InitializeComponent();

            this._rentalsVM = rentalsVM;
            this._clientVM = clientVM;
            this._moviesVM = moviesVM;
            this._rental = rental;

            cboxClient.ItemsSource = _clientVM.getClients();
            listBoxMovies.ItemsSource = _moviesVM.getMovies();

            InitializeComponent();
            _rental = rental;
            this.DataContext = _rental;
        }

        private void btnAddRental_Click(object sender, RoutedEventArgs e)
        {

            if (isValid())
            {
                _rentalsVM.saveOrUpdateRental(_rental);
                Close();
            }
          
        }

        private bool isValid()
        {
            bool isValid = true;

            if (datePickerStartDate.SelectedDate == null || datePickerStartDate.SelectedDate < DateTime.Today)
            {
                lblStartDate.Foreground = System.Windows.Media.Brushes.Red;
                isValid = false;
            }

            return isValid;
        }

        private void btnCancelAddRental_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
