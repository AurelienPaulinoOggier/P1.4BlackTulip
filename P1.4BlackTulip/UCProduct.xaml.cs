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
    /// Interaction logic for UCProduct.xaml
    /// </summary>
    public partial class UCProduct : UserControl
    {
        BlackTulipDBDataContext db = new BlackTulipDBDataContext();
        public product hetItem;
        public UCProduct()
        {
            InitializeComponent();

            var lijst = db.products.ToList();

            dgProduct.ItemsSource = lijst;
        }

        private void btnVerwijderen_Click(object sender, RoutedEventArgs e)
        {
            var item = (product)dgProduct.SelectedItem;

            MessageBoxResult mbr = MessageBox.Show("Weet u het zeker dat u: " + item.product_naam + " wilt verwijderen?", "Waarschuwing!", MessageBoxButton.YesNo);

            if (MessageBoxResult.Yes == mbr)
            {
                db.products.DeleteOnSubmit(item);

                db.SubmitChanges();
                dgProduct.ItemsSource = db.products.ToList();
            }
        }


        private void btnZoeken_Click(object sender, RoutedEventArgs e)
        {
            string zWaarde = txtZoeken.Text;

            var lijst = db.products.Where(p => p.product_naam.Contains(zWaarde)).ToList();
            Product.ItemsSource = lijst;
        }

        private void btnWijzigen_Click(object sender, RoutedEventArgs e)
        {
            var item = (product)dgProduct.SelectedItem;

            gPwt.Children.Clear();
            gPwt.Children.Add(new WijzigenP(item, db));
        }

        private void btnToevoegen_Click(object sender, RoutedEventArgs e)
        {
            gPwt.Children.Clear();
            gPwt.Children.Add(new ToevoegenP(db));
            /*

            producttype deCat = new producttype();
            deCat.omschrijving = txtCat.Text;

            hetItem.producttype = deCat;

            */
        }

    }
}
