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
using System.Windows.Shapes;


//background image:http://www.linspark.com/images/hotel-2.jpg
//icon: https://d30y9cdsu7xlg0.cloudfront.net/png/876224-200.png

namespace Hotel_Reservations
{
    /// <summary>
    /// Interaction logic for NewReservation.xaml
    /// </summary>
    public partial class NewReservation : Window
    {
        public NewReservation()
        {
            InitializeComponent();
        }

        private void btnNRBack_Click(object sender, RoutedEventArgs e)
        {
            MainWindow MainWindow = new MainWindow();
            MainWindow.Show();
            this.Close();
        }

        private void btnContinue_Click(object sender, RoutedEventArgs e)
        {
            PaymentInfo PayInfoWindow = new PaymentInfo();
            PayInfoWindow.Show();
            this.Close();
        }

        private void txbQuote_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
