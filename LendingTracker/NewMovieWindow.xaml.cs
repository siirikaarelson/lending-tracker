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
    /// Interaction logic for NewMovieWindow.xaml
    /// </summary>
    public partial class NewMovieWindow : Window
    {

        private MoviesVM moviesVM;
        private Movie _movie;

        public NewMovieWindow()
        {
            InitializeComponent();
            moviesVM = new MoviesVM();
            _movie = new Movie();

            _movie.Title = "Batman return";

            this.DataContext = _movie;
        }

        private void btnSaveMovie_Click(object sender, RoutedEventArgs e)
        {
            moviesVM.saveMovie(_movie);
        }
    }
}
