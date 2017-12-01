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
using System.Text.RegularExpressions;


//background image:http://www.linspark.com/images/hotel-2.jpg
//icon: https://d30y9cdsu7xlg0.cloudfront.net/png/585555-200.png

namespace Hotel_Reservations
{
    /// <summary>
    /// Interaction logic for PaymentInfo.xaml
    /// </summary>
    public partial class PaymentInfo : Window
    {
        //create list of payment
        List<Payment> paymentList;
        public PaymentInfo()
        {
            InitializeComponent();
            //initialize the list of payments
            paymentList = new List<Payment>();
        }

        private void btnPIBack_Click(object sender, RoutedEventArgs e)
        {
            NewReservation NewReservWindow = new NewReservation();
            NewReservWindow.Show();
            this.Close();
        }

        private void btnReturnToHome_Click(object sender, RoutedEventArgs e)
        {
            MainWindow MainWindow = new MainWindow();
            MainWindow.Show();
            this.Close();
        }

        private void btnPISubmit_Click(object sender, RoutedEventArgs e)
        {
            //define variable
            bool boolStatus = false;

            //call AddPayment method
            boolStatus = AddPayment(txtFirstName.Text.Trim(), txtLastName.Text.Trim(), cmbCCType.SelectedItem, txtCCNumber.Text.Trim(), txtPhone.Text.Trim(), txtEmail.Text.Trim());

            //if the payment is added successfully, diaplay message to user
            //if (boolStatus)
            //{
            //    MessageBox.Show("Payment is added.");
            //}
        }

        private bool AddPayment(string firstName, string lastName, object ccType, string ccNumber, string phone, string email)
        {
            //define variables;
            Payment newPayment;

            //Validate on required fields 
            if (firstName == "")
            {
                MessageBox.Show("First Name is a required field.");
                return false;
            }
            if (lastName == "")
            {
                MessageBox.Show("Last Name is a required field.");
                return false;
            }
            if (ccType == null)
            {
                MessageBox.Show("Credit Card Type is a required field.");
                return false;
            }
            if (ccNumber == "")
            {
                MessageBox.Show("Credit Card Number is a required field.");
                return false;
            }
            if (phone == "")
            {
                MessageBox.Show("Phone is a required field.");
                return false;
            }

            //validate Credit Card Number





            //validate phone number
            Regex phoneValidate = new Regex(@"^(\([0-9]{3}\)|[0-9]{3}-)[0-9]{3}-[0-9]{4}|(\([0-9]{3}\)|[0-9]{3})[0-9]{3}[0-9]{4}$");
            if (!phoneValidate.IsMatch(txtPhone.Text))
            {
                MessageBox.Show("Please input a valid phone number.");
                return false;
            }
            //validate email address
            Regex emailValidate = new Regex(@"^[a-zA-Z][\w\.-]{2,28}[a-zA-Z0-9]@[a-zA-Z0-9][\w\.-]*[a-zA-Z0-9]\.[a-zA-Z][a-zA-Z\.]*[a-zA-Z]$");
            if (!emailValidate.IsMatch(txtEmail.Text))
            {
                MessageBox.Show("Please input a valid email.");
                return false;
            }

            newPayment = new Payment(firstName, lastName, ccType.ToString(), ccNumber, phone, email);

            //make sure customer want to save record
            MessageBoxResult messageBoxResult = MessageBox.Show("Do you want to save the payment information?" + Environment.NewLine
                                                     , "Add New Payment", MessageBoxButton.YesNo);

            // add customer to list
            if (messageBoxResult == MessageBoxResult.No)
            {
                return false;
            }
            else
            {
                paymentList.Add(newPayment);

                PIConfirmation PIConfirmation = new PIConfirmation();
                PIConfirmation.Show();
                this.Close();
                return true;
            }
        }
    }
}

