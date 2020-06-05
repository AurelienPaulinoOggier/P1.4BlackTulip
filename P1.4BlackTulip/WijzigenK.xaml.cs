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
    /// Interaction logic for WijzigenK.xaml
    /// </summary>
    public partial class WijzigenK : UserControl
    {
        private BlackTulipDBDataContext db;
        public klant hetItem;
        public WijzigenK(klant klt, BlackTulipDBDataContext db)
        {
            InitializeComponent();
            this.db = db;
            hetItem = klt;
            txtNaam.Text = klt.naam;
            txtStad.Text = klt.stad;
            txtMob.Text = klt.mobielenummer;
            txtEmail.Text = klt.e_mail;
        }

        private void btnUpdate_Click(object sender, RoutedEventArgs e)
        {
            if (hetItem != null)
            {
                hetItem.naam = txtNaam.Text;
                hetItem.stad = txtStad.Text;
                hetItem.mobielenummer = txtMob.Text;
                hetItem.e_mail = txtEmail.Text;
                db.SubmitChanges();
            }
        }
    }
}
