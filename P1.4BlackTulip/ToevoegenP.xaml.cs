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
    /// Interaction logic for ToevoegenP.xaml
    /// </summary>
    public partial class ToevoegenP : UserControl
    {
        private BlackTulipDBDataContext db ;
        public product hetItem;
        public ToevoegenP(BlackTulipDBDataContext db)
        {
            InitializeComponent();
            this.db = db;
        }

        private void btnUpdate_Click(object sender, RoutedEventArgs e)
        {
            product hetItem = new product();
            hetItem.product_naam = txtPnaam.Text;
            hetItem.prijs = txtPrijs.Text;
            hetItem.afbeelding = cmbAfb.Text;

            db.products.InsertOnSubmit(hetItem);

            db.SubmitChanges();
        }
    }
}
