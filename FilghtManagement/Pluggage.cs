using System;
using System.Collections.Generic;
using System.Text;

namespace FlightManagement
{
    class Pluggage
    {
        public int Id { get; set; }

        public Customer Customer { get; set; }

        public float Weight { get; set; }

        public string Description { get; set; }

        public Pluggage(int Id, Customer Customer, float Weight, string Description = "")
        {
            this.Id = Id;
            this.Customer = Customer;
            this.Weight = Weight;
            this.Description = Description;
        }
    }
}
