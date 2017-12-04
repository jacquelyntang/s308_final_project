using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel_Reservations
{
    public class RoomType
    {
        public string Type { get; set; }
        public int Quantity { get; set; }
        public double Price { get; set; }

        public RoomType() { }

        public RoomType(string type, int quantity, double price)
        {
            Type = type;
            Quantity = quantity;
            Price = price;
            
        }

        public override string ToString()
        {
            string strOutput = "";

            strOutput = Type + Environment.NewLine + "Quantity: " + Quantity + 
                Environment.NewLine + "Price: " + Price;

           
            return strOutput;
        }

    }
}
