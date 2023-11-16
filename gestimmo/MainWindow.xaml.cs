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
using System.Windows.Navigation;
using System.Windows.Shapes;
using gestimmo_WPF.Views.SubViews;

namespace gestimmo_WPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            // Charge la page d'accueil au démarrage
            // MainFrame.Navigate(new Uri("MainWindow.xaml", UriKind.Relative));
        }

        private void BiensButton_Click(object sender, RoutedEventArgs e)
        {
            // Crée une nouvelle fenêtre pour afficher la page BiensView
            BiensWindow biensWindow = new BiensWindow();
            biensWindow.Show();
        }




    }








}
