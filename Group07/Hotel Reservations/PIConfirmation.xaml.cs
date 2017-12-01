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
using Newtonsoft.Json;


//background image:http://www.linspark.com/images/hotel-2.jpg

namespace Hotel_Reservations
{
    /// <summary>
    /// Interaction logic for PIConfirmation.xaml
    /// </summary>
    public partial class PIConfirmation : Window
    {
        List<Payment> paymentList;
        public PIConfirmation()
        {
            InitializeComponent();
            paymentList = new List<Payment>();
        }

        private void btnRMConfirm_Click(object sender, RoutedEventArgs e)
        {
            
            MainWindow MainWindow = new MainWindow();
            MainWindow.Show();
            this.Close();
        }

        private void btnRMEdit_Click(object sender, RoutedEventArgs e)
        {
            PaymentInfo PIWindow = new PaymentInfo();
            PIWindow.Show();
            this.Close();
        }


    }
}
