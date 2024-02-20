using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisitorPlacementLibrary
{
    public class Row
    {
        private List<Seat> Seats = new();

        public IReadOnlyList<Seat> seats
        {
            get
            {
                return Seats;
            }
        }
        public string RowName { get; private set; }
        public int NumOfSeats { get; private set; }

        public Row(string rowName, int numOfSeats) {
            RowName = rowName;
            NumOfSeats = numOfSeats;

            AddSeat();
        }

        private void AddSeat()
        {
            for (int i = 0; i < NumOfSeats; i++)
            {
                Seats.Add(new Seat($"{RowName}-{i+1}"));
            }
        }

    }
}
