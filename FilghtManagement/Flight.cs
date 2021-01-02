using System;
using System.Collections.Generic;
using System.Text;

namespace FlightManagement
{
    public class Flight
    {
        public int Id { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }

        public AirCraft AirCraft { get; set; }
        public Airport DepartureAirPort { get; set; }
        public Airport ArrivalAirPort { get; set; }


        public Flight(int Id, DateTime StartDate,  DateTime EndDate, AirCraft AirCraft, Airport DepartureAirPort, Airport ArrivalAirPort)
        {
            this.Id = Id;
            this.StartDate = StartDate;
            this.EndDate = EndDate;
            this.AirCraft = AirCraft;
            this.DepartureAirPort = DepartureAirPort;
            this.ArrivalAirPort = ArrivalAirPort;
        }

       
    }
}
