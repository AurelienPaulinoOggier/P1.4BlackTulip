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

namespace P1._4BlackTulip
{
    /// <summary>
    /// Interaction logic for UCAfrekenen.xaml
    /// </summary>
    public partial class UCAfrekenen : UserControl
    {
        BlackTulipDBDataContext db = new BlackTulipDBDataContext();
        public UCAfrekenen()
        {
            InitializeComponent();
            dgklanten.ItemsSource = db.klants.ToList();
            dgProducten.ItemsSource = db.items.ToList();
            txtZoekenB.Text = "Datum";
        }

        private void btnZoeken_Click(object sender, RoutedEventArgs e)
        {
            string zWaarde = txtZoeken.Text;

            var lijst = db.klants.Where(p => p.naam.Contains(zWaarde)).ToList();
            dgklanten.ItemsSource = lijst;
        }

        private void btnZoekenB_Click(object sender, RoutedEventArgs e)
        {
            string zWaarde = txtZoekenB.Text;

            var lijst = db.items.Where(p => p.bestelling.datum.Contains(zWaarde)).ToList();
            dgProducten.ItemsSource = lijst;
        }
    }
}
