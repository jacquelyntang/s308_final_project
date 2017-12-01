using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel_Reservations
{
    public class Payment
    {

        //Properties
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string CCType { get; set; }
        public string CCNumber { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }

        //Method
        public Payment()
        {
        }

        public Payment(string firstName, string lastName, string ccType, string ccNumber, string phone, string email)
        {
            FirstName = firstName;
            LastName = lastName;
            CCType = ccType;
            CCNumber = ccNumber;
            Phone = phone;
            Email = email;

        }
    }
}
