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
    /// Interaction logic for ToevoegenK.xaml
    /// </summary>
    public partial class ToevoegenK : UserControl
    {
        private BlackTulipDBDataContext db ;
        public klant hetItem;
        public ToevoegenK(BlackTulipDBDataContext db)
        {
            InitializeComponent();
            this.db = db;
        }

        private void btnUpdate_Click(object sender, RoutedEventArgs e)
        {
            klant hetItem = new klant();
            hetItem.naam = txtNaam.Text;
            hetItem.stad = txtStad.Text;
            hetItem.mobielenummer = txtMob.Text.ToString();
            hetItem.e_mail = txtEmail.Text;

            db.klants.InsertOnSubmit(hetItem);

            db.SubmitChanges();
        }
    }
}
