using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel_Reservations
{
    public class Quote
    {
        public int NumberOfNight { get; set; }
        public int RatePerNight { get; set; }
        public int Subtotal { get; set; }
        public double Tax { get; set; }
        public int ConvenienceFee { get; set; }
        public double Total { get; set; }

        public Quote()
        {

        }
        public Quote(int numberOfNight, int ratePerNight, int subtotal, double tax, int convenienceFee, double total)
        {
            NumberOfNight = numberOfNight;
            RatePerNight = ratePerNight;
            Subtotal = subtotal;
            Tax = tax;
            ConvenienceFee = convenienceFee;
            Total = total;
        }

    }
}
