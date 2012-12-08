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

namespace LendingTracker
{
    public partial class MainWindow : Window
    {
        RentalsVM rentalsVM;

        public MainWindow()
        {
            InitializeComponent();
            rentalsVM = new RentalsVM();
            lstviewRentals.ItemsSource = rentalsVM.Rentals;
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
    }
}
