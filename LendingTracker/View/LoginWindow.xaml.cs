﻿using LendingTracker.ViewModel;
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

namespace LendingTracker.View
{
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class LoginWindow : Window
    {

        private DBA.LINQtoSQLclassesDataContext _dataContext = new DBA.LINQtoSQLclassesDataContext();

        private UserVM _userVM;

        public LoginWindow()
        {
            InitializeComponent();
             _userVM = new UserVM(_dataContext);

        }

        private void btnCancel_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void btnLogin_Click(object sender, RoutedEventArgs e)
        {
            //if (_userVM.verifyLogin(txtUserName.Text, txtPassword.Password))
            //{
                MainWindow mainWindow = new MainWindow();
                mainWindow.Show();
                this.Close();
            //}
            //else
            //{
            //    lblMainLabel.Content = "Logimine ebaõnnestus!";
            //    lblMainLabel.Foreground = System.Windows.Media.Brushes.Red;
            //}
            
        }
    }



}
