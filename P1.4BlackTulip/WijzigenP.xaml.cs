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
    /// Interaction logic for WijzigenP.xaml
    /// </summary>
    public partial class WijzigenP : UserControl
    {
        private BlackTulipDBDataContext db;
        public product hetItem;
        public WijzigenP(product prt, BlackTulipDBDataContext db)
        {
            InitializeComponent();
            this.db = db;
            hetItem = prt;
            txtPnaam.Text = prt.product_naam;
            txtPrijs.Text = prt.prijs;
            cmbAfb.Text = prt.afbeelding;
            cmbAfb.Items.Add("Pictures/bierglas.jpg");
        }

        private void btnUpdate_Click(object sender, RoutedEventArgs e)
        {
            if (hetItem != null)
            {
                hetItem.product_naam = txtPnaam.Text;
                hetItem.prijs = txtPrijs.Text.ToString();
                hetItem.afbeelding = cmbAfb.Text;
                db.SubmitChanges();

            }
        }

    }
}
