using LendingTracker.ViewModel;
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

        private DBA.Client client;

        private ClientVM _clientVM;

        public NewCustomerWindow(ClientVM clientVM)
        {
            InitializeComponent();
            client = new DBA.Client();
            _clientVM = clientVM;
        }

        private void btnSaveClient_Click(object sender, RoutedEventArgs e)
        {
            #region Validation
            if (tboxFirstName.Text == "") { //First name
                lblFirstName.Foreground = System.Windows.Media.Brushes.Red;
                return;
            }   else {lblFirstName.Foreground = System.Windows.Media.Brushes.Black;}

            if (tboxLastName.Text == "")    //Last name
            {
                lblLastName.Foreground = System.Windows.Media.Brushes.Red;
                return;
            }
            else { lblLastName.Foreground = System.Windows.Media.Brushes.Black; }

            if (tboxPhone.Text == "")   //Phone
            {
                lblPhone.Foreground = System.Windows.Media.Brushes.Red;
                return;
            }
            else { lblPhone.Foreground = System.Windows.Media.Brushes.Black; }

            if (tboxEmail.Text == "")   //eMail
            {
                lblEmail.Foreground = System.Windows.Media.Brushes.Red;
                return;
            }
            else { lblEmail.Foreground = System.Windows.Media.Brushes.Black; }
            long IdCode;
            if (tboxIdCode.Text == "" || !long.TryParse(tboxIdCode.Text,out IdCode))   //ID code
            {
                lblIdCode.Foreground = System.Windows.Media.Brushes.Red;
                return;
            }
            else { lblIdCode.Foreground = System.Windows.Media.Brushes.Black; }
            #endregion

            client.FirstName = tboxFirstName.Text;
            client.LastName = tboxLastName.Text;
            client.Phone = tboxPhone.Text;
            client.IDCode = IdCode;
            client.Problematic = (bool) chBoxProblematic.IsChecked;
            client.VIP = (bool) chBoxVIP.IsChecked;
            client.Comment = tboxComment.Text;
            client.DocumentNumber = tboxDocumentCode.Text;
            _clientVM.saveClient(client); 
           Close();
        }

        private void btnCancelClient_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
