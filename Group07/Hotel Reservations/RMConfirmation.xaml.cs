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
using System.IO;
using Newtonsoft.Json;


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
            string strFilePath = @"..\..\..\Data Files\Rooms.json";
            try
            {
                //get the json data from the file 
                string strJasonData = File.ReadAllText(strFilePath);
                List<RoomType> lstRooms = new List<RoomType>();
                lstRooms = JsonConvert.DeserializeObject<List<RoomType>>(strJasonData);

                //Display the last room on the json list to the confirmation window
                RoomType rmtDisplay = new RoomType();
                rmtDisplay = lstRooms.Last();
                lblRoomPrice.Content = rmtDisplay.Price;
                lblRoomQuantity.Content = rmtDisplay.Quantity;
                lblRoom.Content = rmtDisplay.Type;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Sorry an error occurred on our confirmation page.");
            }

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
