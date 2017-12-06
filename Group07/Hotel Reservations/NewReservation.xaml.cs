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


//background image:http://www.linspark.com/images/hotel-2.jpg
//icon: https://d30y9cdsu7xlg0.cloudfront.net/png/876224-200.png

namespace Hotel_Reservations
{
    /// <summary>
    /// Interaction logic for NewReservation.xaml
    /// </summary>
    public partial class NewReservation : Window
    {
        string strFilePath = @"..\..\..\Data Files\NewReservationTemp.json";

        public NewReservation()
        {
            InitializeComponent();
            btnContinue.Visibility = Visibility.Hidden;
            btnNRBack.Visibility = Visibility.Hidden;
            txbQuote.Visibility = Visibility.Hidden;
            lblQuote.Visibility = Visibility.Hidden;
        }
        private void btnSearch_Click(object sender, RoutedEventArgs e)
        {
            int intNumOfRoom;

            if (!Int32.TryParse(txbNumOfRoom.Text, out intNumOfRoom))
            {

                MessageBox.Show("Please enter a whole number as the number of rooms.");
                return;
            }
            if (intNumOfRoom <= 0)
            {
                MessageBox.Show("The room cannot be negative or zero.");
                return;
            }
            if (dtpCheckIn.SelectedDate == null)
            {
                MessageBox.Show("Must select a check-in date.");
                return;
            }
            if (dtpCheckIn.SelectedDate < DateTime.Now)
            {
                MessageBox.Show("Check-in date must not in the past.");
                return;
            }
            
            if (dtpCheckOut.SelectedDate == null)
            {
               MessageBox.Show("Must select a check-out date.");
               return;
            }
            if (dtpCheckIn.SelectedDate > dtpCheckOut.SelectedDate)
            {
                MessageBox.Show("The check-out date must be later than the check-in date.");
                return;
            }
            if(dtpCheckOut.SelectedDate< DateTime.Now)
            {
                MessageBox.Show("Check-out date must not in the past.");
                return;
            }

            btnContinue.Visibility = Visibility.Visible;
            btnNRBack.Visibility = Visibility.Visible;
            txbQuote.Visibility = Visibility.Visible;
            lblQuote.Visibility = Visibility.Visible;

            intNumOfRoom = Convert.ToInt32(txbNumOfRoom.Text);
            string strroomRate = cmbRoomType.Text;
            double dblsubtotal, dbltax;
            dblsubtotal = 0;
            dbltax = dblsubtotal * 0.07;


            try
            {
                int intSelectedIndex=cmbRoomType.SelectedIndex;
                if (cmbRoomType.SelectedIndex != 0)
                {
                    //get the combo-box item content into a string
                    string strRoomLookup = cmbRoomType.Items[intSelectedIndex].ToString();
                    int intRoomLookup = strRoomLookup.IndexOf(':');
                    strRoomLookup = strRoomLookup.Substring(intRoomLookup + 1).Trim();

                    //get the room from the list that matches strRoomLookup 
                    rmtSelectedRoom = lstRoom.Find(r => r.Type == strRoomLookup);

                }
                else
                {
                    
                }
            }
            catch
            {

            }
            //switch (roomrate)
            //{
            //    case "one king":
            //        roomrate = "$179";
            //        break;
            //    case "one king deluxe":
            //        roomrate = "$189";
            //        break;
            //    case "two queens":
            //        roomrate = "$189";
            //        break;
            //    case "two queen deluxe":
            //        roomrate = "$214";
            //        break;
            //}

            int intNumOfDay = (dtpCheckOut.GetValue - dtpCheckIn.GetValue);
            int intConveniceFee = intNumberOfDays * 10;
            txbQuote.Text = "Number of Nights:".PadRight(10) + intNumOfDay + Environment.NewLine +
                            "Rate Per Night:".PadRight(10) + strroomRate + Environment.NewLine +
                            "Subtotal:" + dblsubtotal.ToString() + Environment.NewLine +
                            "Tax:" + dbltax.ToString() + Environment.NewLine +
                            "Convenience Fee:" + intConvenienceFee.ToString() + Environment.NewLine +
                            "Total:";
        }


    }
    private void btnNRBack_Click(object sender, RoutedEventArgs e)
        {
            MainWindow MainWindow = new MainWindow();
            MainWindow.Show();
            this.Close();
        }

        private void btnContinue_Click(object sender, RoutedEventArgs e)
        {
            //Save this pages information to a jason file so as to be recalled later if user confirms new res
            try
            {
                //I need some sort of class to stor my data into and then add it to a list, then it can go to the json file
                string strJsonData;
                //strJsonData = JsonConvert.SerializeObject();
                //File.WriteAllText(strFilePath, strJsonData);

            }
            //Catch errors and don't let users continue if unable to save new res info
            catch (Exception ex)
            {
                MessageBox.Show("Unable to Continue at this moment. Please, try again later.");
                return;
            }

            //Close this window and move to the payment info page
            PaymentInfo PayInfoWindow = new PaymentInfo();
            PayInfoWindow.Show();
            this.Close();
        }

        private void txbQuote_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

       
    }
    }

