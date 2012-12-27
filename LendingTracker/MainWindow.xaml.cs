﻿using System;
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
using LendingTrackerLibrary.Data;

namespace LendingTracker
{
    public partial class MainWindow : Window
    {

        private DBA.LINQtoSQLclassesDataContext _dataContext = new DBA.LINQtoSQLclassesDataContext();
        private RentalsVM _rentalsVM;
        private MoviesVM _moviesVM;
        private ClientVM _clientVM;

        
        public MainWindow()
        {
            InitializeComponent();
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
              
            }
            else
            {
                this.Close();
            }
        }

        private void btnNewClient_Click(object sender, RoutedEventArgs e)
        {
            var newCustWindow = new NewCustomerWindow(getClientVM());
            newCustWindow.Owner = this;
            newCustWindow.ShowDialog();
        }

        private void btnNewMovie_Click(object sender, RoutedEventArgs e)
        {
            var newMovWindow = new NewMovieWindow(getMoviesVM());
            newMovWindow.Owner = this;
            newMovWindow.ShowDialog();
        }

        private void btnNewRental_Click(object sender, RoutedEventArgs e)
        {
            var newRentalWindow = new AddRentalWindow(getRentalsVM());
            newRentalWindow.Owner = this;
            newRentalWindow.ShowDialog();
        }


        private ClientVM getClientVM()
        {
            if (_clientVM == null)
            {
                _clientVM = new ClientVM(_dataContext);
            }

            return _clientVM;
        }


        private MoviesVM getMoviesVM()
        {
            if (_moviesVM == null)
            {
                _moviesVM = new MoviesVM(_dataContext);
            }

            return _moviesVM;
        }

        private RentalsVM getRentalsVM()
        {
            if (_rentalsVM == null)
            {
                _rentalsVM = new RentalsVM(_dataContext);
            }

            return _rentalsVM;
        }

        private void TabControl_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (tabClients.IsSelected)
            {
                lstViewClients.ItemsSource = getClientVM().getClients();
            }

            if (tabMovies.IsSelected)
            {
                lstViewMovies.ItemsSource = getMoviesVM().getMovies();
            }

            if (tabRentals.IsSelected)
            {
                lstViewRentals.ItemsSource = getRentalsVM().getRentals();
            }

        }


        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            _clientVM = null;
            _moviesVM = null;
            _rentalsVM = null;

            if (_dataContext.DatabaseExists())
            {
                MessageBox.Show("Database olemas, kustutan");
                _dataContext.DeleteDatabase();
            }

            _dataContext.CreateDatabase();
            MessageBox.Show("Uus baas genereeritud");
        }

        private void lstViewClients_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            if (lstViewClients.SelectedItems.Count == 1)
            {
                DBA.Client client = (DBA.Client) lstViewClients.SelectedItem;
                var newCustWindow = new NewCustomerWindow(getClientVM(), client);
                newCustWindow.Owner = this;
                newCustWindow.ShowDialog();
            }
      
        }

        private void lstViewMovies_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            if (lstViewMovies.SelectedItems.Count == 1)
            {
                DBA.Movie movie = (DBA.Movie)lstViewMovies.SelectedItem;
                var movieWindow = new NewMovieWindow(getMoviesVM(), movie);
                movieWindow.Owner = this;
                movieWindow.ShowDialog();
            }
      
        }



      

    }
}
