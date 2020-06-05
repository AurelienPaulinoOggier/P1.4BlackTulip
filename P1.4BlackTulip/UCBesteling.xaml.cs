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
    /// Interaction logic for UCBesteling.xaml
    /// </summary>
    public partial class UCBesteling : UserControl
    {
        BlackTulipDBDataContext db = new BlackTulipDBDataContext();
        //int iTeller = 0;
        public UCBesteling()
        {
            InitializeComponent();
            dgProduct.ItemsSource = db.products.ToList();
            cmbKlant.ItemsSource = db.klants.ToList();
            txtDatum.Text = "Datum";
        }

        private void dgProduct_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            var item = dgProduct.SelectedItem;
            if (item != null)
            {
                product hetItem = (product)item;
                dgFactuur.Items.Add(hetItem);

            }
        }

        private void btnOpslaan_Click(object sender, RoutedEventArgs e)
        {
            var deKlant = (klant)cmbKlant.SelectedItem;
            if (deKlant != null) 
            {
                item bestellen = new item();
                bestellen.bestelling = new bestelling();

                bestellen.bestelling.klant = deKlant;
                ItemCollection ic = dgFactuur.Items;
                foreach (var i in ic)
                {
                    bestellen.bestelling.datum = txtDatum.Text;
                    bestellen.product = (product)i;
                    db.items.InsertOnSubmit(bestellen);
                }
                db.SubmitChanges();
                dgFactuur.Items.Clear();
                txtDatum.Text = "Datum";
            }
            else MessageBox.Show("U heeft geen Klant geselecteerd!");
        }

        private void dgFactuur_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            var item = dgFactuur.SelectedItem;
            if (item != null)
            { 
                product hetItem = (product)item;
                dgFactuur.Items.Remove(hetItem);
            }
        }
    }
}
