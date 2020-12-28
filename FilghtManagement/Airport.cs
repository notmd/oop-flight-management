using System;
using System.Collections.Generic;
using System.Text;

namespace FlightManagement
{
    public class Airport
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string City { get; set; }
        public string Country { get; set; }


        public double Latitude { get; set; } // Negative is South, positive is North
        public double Longtitude { get; set; } // Negative is West, positive is East


        public Airport(int Id, string Name, string City, string Country, double Latitude, double Longtitude)
        {
            this.Id = Id;
            this.Name = Name;
            this.City = City;
            this.Country = Country;
            this.Latitude = Latitude;
            this.Longtitude = Longtitude;
        }
    }
}
