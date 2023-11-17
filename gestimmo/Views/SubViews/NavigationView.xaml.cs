using System.Windows;
using System.Windows.Controls;

namespace gestimmo_WPF.Views.SubViews
{
    /// <summary>
    /// Logique d'interaction pour NavigationView.xaml
    /// </summary>
    public partial class NavigationView : Page
    {
        private HomeView _homeView;

        public NavigationView()
        {
            InitializeComponent();
            _homeView = new HomeView();
            this.MainFrame.NavigationService.Navigate(_homeView);
        }

        private void BiensButton_Click(object sender, RoutedEventArgs e)
        {
            // Naviguer vers la vue BiensView
            this.MainFrame.NavigationService.Navigate(new BiensView());
        }

        private void AccueilButton_Click(object sender, RoutedEventArgs e)
        {
            // Revenir à la vue Accueil (HomeView)
            this.MainFrame.NavigationService.Navigate(_homeView);
        }
    }
}
