using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisitorPlacementLibrary
{
    public class Seat
    {
        public string SeatCode { get; set; }

        public Seat(string seatCode)
        {
            SeatCode = seatCode;
        }
    }
}
