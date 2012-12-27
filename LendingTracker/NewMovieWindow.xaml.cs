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

        private MoviesVM _moviesVM;
        private DBA.Movie _movie;
       
        public NewMovieWindow(MoviesVM moviesVM)
        {
            InitializeComponent();
            
            _moviesVM = moviesVM;
            _movie = new DBA.Movie();
            this.DataContext = _movie;
        }

        public NewMovieWindow(MoviesVM moviesVM, DBA.Movie movie)
        {
            InitializeComponent();
            this._moviesVM = moviesVM;
            this._movie = movie;

            this.DataContext = movie;
        }

        private void btnSaveMovie_Click(object sender, RoutedEventArgs e)
        {

            if (!validate())
            {
                _movie.Title = tboxTitle.Text.Trim();
                _movie.Description = tboxDescription.Text.Trim();
                _movie.Comment = tboxComment.Text.Trim();
                _movie.Year = int.Parse(tboxYear.Text.Trim());

                if ( _movie.id == 0)
                {
                     _moviesVM.saveMovie(_movie);
                }
                else
                {
                     _moviesVM.updateMovie(_movie);
                }

                Close();
            }

          
        }

        /* 
         * Validate methtod
         */ 
        private bool validate()
        {

            bool hasError = false;

            if (tboxTitle.Text.Trim() == "")
            {
                lblTitle.Foreground = System.Windows.Media.Brushes.Red;
                hasError = true;
            }
            else 
            { 
                lblTitle.Foreground = System.Windows.Media.Brushes.Black; 
            }

            int year;
            if (tboxYear.Text.Trim() == "" && !int.TryParse(tboxYear.Text.Trim(), out year))
            {
                lblYear.Foreground = System.Windows.Media.Brushes.Red;
                hasError = true;
            }
            else
            {
                lblYear.Foreground = System.Windows.Media.Brushes.Black;
            }



            return hasError;
        }
    }
}
