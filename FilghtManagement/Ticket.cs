using System;
using System.Collections.Generic;
using System.Text;

namespace FlightManagement
{
    public enum SeatType
    {
        FirstClass,
        Business,
        Economy
    }
    public class Ticket
    {
        public int Id { get; set; }

        public Flight Flight { get; set; }

        public int Price { get; set; }

        public int SeatID { get; set; }

        public SeatType SeatType { get; set; }

        public bool Validity { get; set; }

        public Ticket(int Id, Flight Flight,  int Price, int SeatID, SeatType SeatType, bool Validity)
        {
            this.Id = Id;
            this.Flight = Flight;
            this.Price = Price;
            this.SeatID = SeatID;
            this.SeatType = SeatType;
            this.Validity = Validity;
        }
    }
}
