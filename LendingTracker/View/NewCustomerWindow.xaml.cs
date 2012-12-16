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
    /// Interaction logic for NewCustomerWindow.xaml
    /// </summary>
    public partial class NewCustomerWindow : Window
    {
        private ClientVM clientVM;

        private Client client = new Client();

        public NewCustomerWindow()
        {
            InitializeComponent();
            clientVM = new ClientVM();
            this.DataContext = client;

           
        }

        private void btnSaveClient_Click(object sender, RoutedEventArgs e)
        {
            clientVM.saveClient(client);      
            Close();
          
        }

        private void btnCancelClient_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
