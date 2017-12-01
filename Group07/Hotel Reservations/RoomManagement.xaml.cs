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
//icon: https://www.shareicon.net/data/512x512/2016/08/06/807649_check_512x512.png

namespace Hotel_Reservations
{
    /// <summary>
    /// Interaction logic for RoomManagement.xaml
    /// </summary>
    public partial class RoomManagement : Window
    {
        // Put the rooms into the roomtype class for reference later

        RoomType rmtPresidential = new RoomType("One King Presidential Suite",5,289);
        RoomType rmtKing = new RoomType("One King", 30, 179);
        RoomType rmtKingDeluxe = new RoomType("One King Deluxe", 10, 189);
        RoomType rmtQueen = new RoomType("Two Queens", 30, 189);
        RoomType rmtQueenDeluxe = new RoomType("Two Queen Deluxe", 15, 214);
        RoomType rmtKingSuite = new RoomType("One King Suite", 10, 249);

        RoomType rmtSelectedRoom = new RoomType();

        double dblPrice;
        int intQuantity;
        bool bolSelectedIndex=false; 

        public RoomManagement()
        {
            InitializeComponent();
            

        }

        private void btnRMSave_Click(object sender, RoutedEventArgs e)
        {
            

            #region Validation
            //make sure that a room is selected
            if (cbxRoomType.SelectedIndex==0)
            {
                MessageBox.Show("Please Select a Room, before saving changes.");

                return;
            }
          //make sure that the room inputs are not null and valid
          else if (!Int32.TryParse(txtQuantityInput.Text,out intQuantity))
            {
                MessageBox.Show("Please input a Number for Quantity.");
                return;
            }
          else if (!Double.TryParse(txtPriceInput.Text,out dblPrice))
            {
                MessageBox.Show("Please input a Number for Price.");
                return;
            }
          else if (dblPrice<0 || intQuantity<0)
            {
                MessageBox.Show("Please input Positive Numbers for Price and Quantity.");
                return;
            }
            #endregion

            //Move to Confirmation Page and close this window
            RMConfirmation RMConfirmWindow = new RMConfirmation();
            RMConfirmWindow.Show();
            this.Close();
        }

        private void btnRMBack_Click(object sender, RoutedEventArgs e)
        {
            //Create a message box to ask if the user really wishes to exit without saving changes
            MessageBoxResult mbrCheck = MessageBox.Show("You are about to leave without saving your changes.", "", MessageBoxButton.OKCancel);

            if (mbrCheck == MessageBoxResult.Cancel)
            { return; }

            else
            //Close window and open main interface
            {
                MainWindow MainWindow = new MainWindow();
                MainWindow.Show();
                this.Close();
            }
        }

        private void cbxRoomType_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            //Clear out the outputs
            try
            {
                //lblPriceLabel.Visibility = 0;
                
                //lblRoomType.Content = "";
                //txtPriceInput.Text = "";
                //txtQuantityInput.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error occured");
            }

            #region Change Labels with Room Selection

            //Make so that when user dropdowns,the labels change to match the dropdown

            int intSelectedIndex;
            bolSelectedIndex=true;

            intSelectedIndex = cbxRoomType.SelectedIndex;

            //Use switch statement to determine which RoomType is selected in the combobox
            switch (intSelectedIndex) 
            {
                case 1:
                    {   rmtSelectedRoom = rmtKing;
                        
                        break;
                    }
                case 2:
                    {   rmtSelectedRoom = rmtKingDeluxe;
                        break;
                    }
                case 3:
                    {   rmtSelectedRoom = rmtQueen;
                        break;
                    }
                case 4:
                    {   rmtSelectedRoom = rmtQueenDeluxe;
                        break;
                    }
                case 5:
                    {   rmtSelectedRoom = rmtKingSuite;
                        break;
                    }
                case 6:
                    {   rmtSelectedRoom = rmtPresidential;
                        break;
                    }
                default:
                    {   bolSelectedIndex = false;
                        break;
                    }
            }

            #endregion


            //Display the Room Information based on the selected room if room is selected; hide if no room selected
            if (bolSelectedIndex)
            {

                lblRoomType.Content = rmtSelectedRoom.Type;

                txtQuantityInput.Text = rmtSelectedRoom.Quantity.ToString();

                txtPriceInput.Text = rmtSelectedRoom.Price.ToString();
               

            }
            

        }
    }
}
