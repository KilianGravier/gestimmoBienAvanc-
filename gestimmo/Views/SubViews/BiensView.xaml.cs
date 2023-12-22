using System.Collections.Generic;
using System.Windows.Controls;
using System.Windows;
using gestimmo_WPF.Views.Forms;

namespace gestimmo_WPF.Views.SubViews
{
    public partial class BiensView : Page
    {
        public BiensView()
        {
            InitializeComponent();
            this.Droite.Navigate(new GererBienForm());
          
            this.Gauche.Navigate(new ListBienView());
        }
    
    }
}
