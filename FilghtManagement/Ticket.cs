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
        public string Id { get; set; }

        public Customer Customer { get; set; }

        public Flight Flight { get; set; }

        public int Price { get; set; }

        public int SeatID { get; set; }

        public SeatType SeatType { get; set; }

        public bool Validity { get; set; }
    }
}
