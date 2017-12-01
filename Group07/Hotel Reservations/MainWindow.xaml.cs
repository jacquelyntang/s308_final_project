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

//Andrea Igo
//Haiyue Zhang
//Jacquelyn Tang


//background image:http://cdn-image.travelandleisure.com/sites/default/files/styles/1600x1000/public/1466546613/27-Negril-Jamaica-Rockhouse-Hotel-HONEYMOON0616.jpg?itok=KSzsJxTX

namespace Hotel_Reservations
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        

        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnNewReserv_Click(object sender, RoutedEventArgs e)
        {
            NewReservation NewReservWindow = new NewReservation();
            NewReservWindow.Show();
            this.Close();
        }

        private void btnRoomMgmt_Click(object sender, RoutedEventArgs e)
        {
            RoomManagement RoomManagWindow = new RoomManagement();
            RoomManagWindow.Show();
            this.Close();

           
        }

        private void btnReservReport_Click(object sender, RoutedEventArgs e)
        {
            ReservationsReport ReservRepWindow = new ReservationsReport();
            ReservRepWindow.Show();
            this.Close();
        }

        private void btnExit_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
