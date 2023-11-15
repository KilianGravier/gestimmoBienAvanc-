using Serilog;
using Serilog.Core;
using Serilog.Events;
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
using Serilog.Formatting.Compact;


namespace gestimmo_WPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml heho c'est moi le bon
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            Log.Logger = new LoggerConfiguration()
                .MinimumLevel.ControlledBy(new LoggingLevelSwitch(LogEventLevel.Debug)) // Niveau minimum à Debug
                .WriteTo.Logger(lc => lc.Filter.ByIncludingOnly(e => e.Level == LogEventLevel.Debug).WriteTo.Console()) // Seuls les niveaux Debug s'affichent dans la console
                .WriteTo.File("myapp.txt", restrictedToMinimumLevel: LogEventLevel.Verbose) // Tous les niveaux sont enregistrés dans le fichier
                .CreateLogger();

            Log.Information("Hello, world!");
        }









        private void BiensButton_Click(object sender, RoutedEventArgs e)
        {
            // Charge la page Biens lors du clic sur le bouton Biens
            MainFrame.Navigate(new Uri("BiensView.xaml", UriKind.Relative));
        }

        // mit en cyber tp logs
        


    }

}












