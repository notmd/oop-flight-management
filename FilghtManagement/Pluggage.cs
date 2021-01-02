using System;
using System.Collections.Generic;
using System.Text;

namespace FlightManagement
{
    public class Pluggage
    {
        public int Id { get; set; }


        public float Weight { get; set; }

        public string Description { get; set; }

        public Pluggage(int Id, float Weight, string Description = "")
        {
            this.Id = Id;
            this.Weight = Weight;
            this.Description = Description;
        }
    }
}
