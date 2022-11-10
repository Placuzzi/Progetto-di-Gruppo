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

namespace Esercizio_Git_gruppo
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

        }

        private void Aggiungi_Brano_Click(object sender, RoutedEventArgs e)
        {
            string Titolo = Agg_Titolo.Text;
            string Autore = Agg_Autore.Text;
            double Durata = (Agg_Durata.Text);
            CD cd = new CD {Titolo,Autore,Durata };
            cd.setAutore();
            cd.setTitolo();

        }
    }
}
