using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace LendingTracker
{

    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {

        private void createDatabase(object sender, StartupEventArgs e)
        {
            Helpers.DatabaseHelper databaseHelper = new Helpers.DatabaseHelper();

            if (!databaseHelper.hasDatabase())
            {
                MessageBox.Show("Andmebaas on puudu, genereerin uue andmebaasi!", "Hoiatus", MessageBoxButton.OK, MessageBoxImage.Information);

                databaseHelper.createDatabase();

               MessageBoxResult result = MessageBox.Show("Andmebaas genereereeritud! Kas tekitan ka test andmed",
                   "Hoiatus", MessageBoxButton.YesNo, MessageBoxImage.Question);

               if (result == MessageBoxResult.Yes)
               {
                   databaseHelper.createSampleData(true);
               }
               else
               {
                   databaseHelper.createSampleData(false);
               }
            }
        }
    }
}
