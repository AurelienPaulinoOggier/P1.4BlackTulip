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
    /// Interaction logic for UCKlant.xaml
    /// </summary>
    public partial class UCKlant : UserControl
    {
        BlackTulipDBDataContext db = new BlackTulipDBDataContext();
        public klant hetItem;
        public UCKlant()
        {
            InitializeComponent();

            var lijst = db.klants.ToList();

            dgKlant.ItemsSource = lijst;

        }

        private void dgKlant_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            
        }

        private void DataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            
        }

        private void btnToevoegen_Click(object sender, RoutedEventArgs e)
        {
            gPwt.Children.Clear();
            gPwt.Children.Add(new ToevoegenK(db));
        }

        private void btnVerwijderen_Click(object sender, RoutedEventArgs e)
        {
            var item = (klant)dgKlant.SelectedItem;

            MessageBoxResult mbr = MessageBox.Show("Weet u het zeker dat u: " + item.naam + " wilt verwijderen?", "Waarschuwing!", MessageBoxButton.YesNo);

            if (MessageBoxResult.Yes == mbr)
            {
                db.klants.DeleteOnSubmit(item);

                db.SubmitChanges();
                dgKlant.ItemsSource = db.klants.ToList();
            }
        }

        private void btnWijzigen_Click(object sender, RoutedEventArgs e)
        {
            var item = (klant)dgKlant.SelectedItem;

            gPwt.Children.Clear();
            gPwt.Children.Add(new WijzigenK(item, db));
        }

        private void btnZoeken_Click(object sender, RoutedEventArgs e)
        {
            string zWaarde = txtZoeken.Text;

            var lijst = db.klants.Where(p => p.naam.Contains(zWaarde)).ToList();
            Klant.ItemsSource = lijst;
        }
    }
}
