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

        private DBA.Client _client;
        private ClientVM _clientVM;

        public NewCustomerWindow(ClientVM clientVM)
        {
            InitializeComponent();
            _client = new DBA.Client();
            _clientVM = clientVM;

            this.DataContext = _client;
        }

        public NewCustomerWindow(ClientVM clientVM, DBA.Client client)
        {
            InitializeComponent();
            _clientVM = clientVM;
            this._client = client;
            this.DataContext = client;
        }

        private void btnSaveClient_Click(object sender, RoutedEventArgs e)
        {

            if (!validate())
            {
                _client.FirstName = tboxFirstName.Text;
                _client.LastName = tboxLastName.Text;
                _client.Phone = tboxPhone.Text;
                _client.IDCode = long.Parse(tboxIdCode.Text);
                _client.Problematic = (bool)chBoxProblematic.IsChecked;
                _client.VIP = (bool)chBoxVIP.IsChecked;
                _client.Comment = tboxComment.Text;
                _client.DocumentNumber = tboxDocumentCode.Text;
                _client.Email = tboxEmail.Text;

                if (_client.id == 0)
                {
                    _clientVM.saveClient(_client);
                }
                else
                {
                    _clientVM.updateClient(_client);
                }

                Close();
            }


        }

        private void btnCancelClient_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private bool validate()
        {

            bool hasError = false;

            if (tboxFirstName.Text == "")
            { //First name
                lblFirstName.Foreground = System.Windows.Media.Brushes.Red;
                hasError = true;
            }
            else { lblFirstName.Foreground = System.Windows.Media.Brushes.Black; }

            if (tboxLastName.Text == "")    //Last name
            {
                lblLastName.Foreground = System.Windows.Media.Brushes.Red;
                hasError = true;
            }
            else { lblLastName.Foreground = System.Windows.Media.Brushes.Black; }

            if (tboxPhone.Text == "")   //Phone
            {
                lblPhone.Foreground = System.Windows.Media.Brushes.Red;
                hasError = true;
            }
            else { lblPhone.Foreground = System.Windows.Media.Brushes.Black; }

            if (tboxEmail.Text == "")   //eMail
            {
                lblEmail.Foreground = System.Windows.Media.Brushes.Red;
                hasError = true;
            }
            else
            {
                lblEmail.Foreground = System.Windows.Media.Brushes.Black;
            }

            long IdCode;
            if (tboxIdCode.Text == "" || !long.TryParse(tboxIdCode.Text, out IdCode))   //ID code
            {
                lblIdCode.Foreground = System.Windows.Media.Brushes.Red;
                hasError = true;
            }
            else { lblIdCode.Foreground = System.Windows.Media.Brushes.Black; }


            return hasError;
        }
    }
}
