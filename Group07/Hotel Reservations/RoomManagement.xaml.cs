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
using System.IO;

//simple change

//backdround image: http://www.easyfairs.com/fileadmin/groups/10/Guest_2017/_OGA1J00.jpg
//icon: https://www.shareicon.net/data/512x512/2016/08/06/807649_check_512x512.png

namespace Hotel_Reservations
{
    /// <summary>
    /// Interaction logic for RoomManagement.xaml
    /// </summary>
    public partial class RoomManagement : Window
    {

       // public int MyNumber { get; set; }


        RoomType rmtSelectedRoom = new RoomType();

        List<RoomType> lstRoom = new List<RoomType>();

        string strFilePath = @"..\..\..\Data Files\Rooms.json";

        double dblPrice;
        int intQuantity;
        bool bolSelectedIndex=false;
        string strJsonData;

        public RoomManagement()
        {
            InitializeComponent();

            //Take Get room data from json file to use later in the document
            try
            {
                strJsonData = File.ReadAllText(strFilePath);
                lstRoom = JsonConvert.DeserializeObject<List<RoomType>>(strJsonData);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Unable to find file. Please try again later.");
            }
        }

        //public RoomManagement(int myNum)
        //{
        //    InitializeComponent();

        //    MyNumber = myNum;

        //    //Take Get room data from json file to use later in the document
        //    try
        //    {
        //        strJsonData = File.ReadAllText(strFilePath);
        //        lstRoom = JsonConvert.DeserializeObject<List<RoomType>>(strJsonData);

        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show("Unable to find file. Please try again later.");
        //    }
        //}

        //public void DoSomething()
        //{
        //    //fdsdsfs
        //}

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
            //create variables
            int intSelectedIndex = cbxRoomType.SelectedIndex;
            RoomType rmtSavedRoom = new RoomType(rmtSelectedRoom.Type, intQuantity, dblPrice);
            

            //MessageBox to Confirm that changes are wanted
            MessageBoxResult mbrSaveConfirm = MessageBox.Show("Are You Sure You Would Like to Make the Following Changes?"+ Environment.NewLine+Environment.NewLine+ rmtSavedRoom.ToString(),"", MessageBoxButton.YesNo);

            if (mbrSaveConfirm == MessageBoxResult.No)
            { return; }
            else
            //load information into json document for external save
            {
                //get the combo-box item content into a string
                string strRoomLookup = cbxRoomType.Items[intSelectedIndex].ToString();
                int intRoomLookup = strRoomLookup.IndexOf(':');
                strRoomLookup = strRoomLookup.Substring(intRoomLookup + 1).Trim();

                //Get the roomindex of the masterdata room that was changed, delete it, and add new room info

                int intRoomIndex= lstRoom.IndexOf(rmtSelectedRoom);
                lstRoom.RemoveAt(intRoomIndex);
                lstRoom.Add(rmtSavedRoom);

                //Overwrite  the json file with the new list
                try
                {
                    string strJsonData = JsonConvert.SerializeObject(lstRoom);
                    File.WriteAllText(strFilePath, strJsonData);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Unable to Save Changes. Please Try Again Later.");
                }
            }

            //Move to Confirmation Page and close this window
            RMConfirmation RMConfirmWindow = new RMConfirmation();
            RMConfirmWindow.Show();
            this.Close();
        }

        private void btnRMBack_Click(object sender, RoutedEventArgs e)
        {
            if (cbxRoomType.SelectedIndex != 0)

            {
                //Create a message box to ask if the user really wishes to exit without saving changes
                MessageBoxResult mbrCheck = MessageBox.Show("You are about to leave without saving your changes.", "", MessageBoxButton.OKCancel);

                if (mbrCheck == MessageBoxResult.Cancel)
                { return; }

               
}     else       //Close window and open main interface
            {
                MainWindow MainWindow = new MainWindow();
                MainWindow.Show();
                this.Close();
            }
        }

        private void cbxRoomType_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            
            

            #region Change Labels with Room Selection

            //Make so that when user dropdowns,the labels change to match the dropdown

            int intSelectedIndex;
            bolSelectedIndex=true;

            intSelectedIndex = cbxRoomType.SelectedIndex;

           
            
            if (cbxRoomType.SelectedIndex!=0)
            {
                //get the combo-box item content into a string
                string strRoomLookup = cbxRoomType.Items[intSelectedIndex].ToString();
                int intRoomLookup = strRoomLookup.IndexOf(':');
                strRoomLookup = strRoomLookup.Substring(intRoomLookup+1).Trim();

                //get the room from the list that matches strRoomLookup 
                rmtSelectedRoom = lstRoom.Find(r => r.Type == strRoomLookup);
               
            }
            else
            {
                bolSelectedIndex = false;
            }



            #endregion



            //Display the Room Information based on the selected room if room is selected; hide if no room selected
            //Hide and show save button based on selected index

            
            if (bolSelectedIndex)
            {
                lblRoomType.Content = rmtSelectedRoom.Type;

                txtQuantityInput.Text = rmtSelectedRoom.Quantity.ToString();

                txtPriceInput.Text = rmtSelectedRoom.Price.ToString();

                btnRMSave.Visibility = Visibility.Visible;
            }
            else
            {
                try
                {
                    lblRoomType.Content = " ";
                    txtQuantityInput.Text = " ";
                    txtPriceInput.Text = " ";
                    btnRMSave.Visibility = Visibility.Hidden;
                }
                //When first entering window have a catch for the null exception
                catch
                { }
            }
            
        }
    }
}
