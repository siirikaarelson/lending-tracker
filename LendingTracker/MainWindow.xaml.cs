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
using System.Windows.Navigation;
using System.Windows.Shapes;
using LendingTrackerLibrary;
using LendingTracker.ViewModel;
using System.Configuration;
using LendingTracker.View;

namespace LendingTracker
{
    public partial class MainWindow : Window
    {
        RentalsVM rentalsVM;
        MoviesVM moviesVM;

        public MainWindow()
        {
            InitializeComponent();
           // rentalsVM = new RentalsVM();
           // moviesVM = new MoviesVM();


           // lstViewRentals.ItemsSource = rentalsVM.Rentals;
           // lstViewMovies.ItemsSource = moviesVM.getMovies();

        }


        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
           DisplayLoginScreen();
        }

        private void DisplayLoginScreen()
        {
            LoginWindow loginWindow = new LoginWindow();

            loginWindow.Owner = this;
            loginWindow.ShowDialog();
            if (loginWindow.DialogResult.HasValue && loginWindow.DialogResult.Value)
            {
                MessageBox.Show("User Logged In");
            }
            else
            {
                this.Close();
            }
        }

        private void btnNewClient_Click(object sender, RoutedEventArgs e)
        {
            var newCustWindow = new NewCustomerWindow();
            newCustWindow.Show();
        }

        private void btnNewMovie_Click(object sender, RoutedEventArgs e)
        {
            var newMovWindow = new NewMovieWindow();
            newMovWindow.Show();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            DBA.LINQtoSQLclassesDataContext dataContext = new DBA.LINQtoSQLclassesDataContext();

            if (dataContext.DatabaseExists())
            {
                MessageBox.Show("Database olemas, kustutan");
                dataContext.DeleteDatabase();
             
            }

            dataContext.CreateDatabase();
        }

     

      

       

      

    }
}
