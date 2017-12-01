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


//backdround image: http://www.easyfairs.com/fileadmin/groups/10/Guest_2017/_OGA1J00.jpg
//icon: https://cdn3.iconfinder.com/data/icons/medcare/512/Report-512.png

namespace Hotel_Reservations
{
    /// <summary>
    /// Interaction logic for ReservationsReport.xaml
    /// </summary>
    public partial class ReservationsReport : Window
    {
        public ReservationsReport()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, RoutedEventArgs e)
        {
            MainWindow MainWindow = new MainWindow();
            MainWindow.Show();
            this.Close();
        }
    }
}
