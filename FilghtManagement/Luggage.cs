using System;
using System.Collections.Generic;
using System.Text;

namespace FlightManagement
{
    public class Luggage
    {
        public int Id { get; set; }


        public float Weight { get; set; }

        public string Description { get; set; }

        public Luggage(int Id, float Weight, string Description = "")
        {
            this.Id = Id;
            this.Weight = Weight;
            this.Description = Description;
        }
    }
}
