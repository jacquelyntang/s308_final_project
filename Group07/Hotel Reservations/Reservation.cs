using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel_Reservations
{
    public class Reservation
    {
        //Properties
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string RoomType { get; set; }
        public string NumberOfRooms { get; set; }
        public string NumberOfNights { get; set; }
        public string CheckInDate { get; set; }
        public double RoomPrice { get; set; }
        public double Total { get; set; }

        //Methods

        public Reservation()
        {
        }

        public Reservation(string firstName, string lastName, string phone, string email, string roomType, string numberOfRooms, string numberOfNights, string checkInDate, double price, double total)
        {
            FirstName = firstName;
            LastName = lastName;
            Phone = phone;
            Email = email;
            RoomType = roomType;
            NumberOfRooms = numberOfRooms;
            NumberOfNights = numberOfNights;
            CheckInDate = checkInDate;
            RoomType = roomType;
            Total = total;
        }

    }
}
