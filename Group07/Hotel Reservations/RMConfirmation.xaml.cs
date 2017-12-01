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

namespace Hotel_Reservations
{
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class RMConfirmation : Window
    {
        public RMConfirmation()
        {
            InitializeComponent();
           
        }

        private void btnRMConfirm_Click(object sender, RoutedEventArgs e)
        {
            MainWindow MainWindow = new MainWindow();
            MainWindow.Show();
            this.Close();
        }

        private void btnRMEdit_Click(object sender, RoutedEventArgs e)
        {
            RoomManagement RoomManagWindow = new RoomManagement();
            RoomManagWindow.Show();
            this.Close();
        }
    }
}
