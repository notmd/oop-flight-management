using System;
using System.Collections.Generic;
using System.Text;

namespace FlightManagement
{
    class AirCraft
    {
        public int Id { get; set; }

        public string Model { get; set; }

        //public int FirstClassSeatAmount { get; set; }

        //public int BusinessClassSeatAmount { get; set; }

        //public int EconomyClassSeatAmount { get; set; }

        public string IATACode { get; set; }
        public string ICAOCode { get; set; }



        public AirCraft(int Id, string Model, string IATACode, string ICAOCode)
        {
            this.Id = Id;
            this.Model = Model;
            this.IATACode = IATACode;
            this.ICAOCode = ICAOCode;
        }

    }

}
