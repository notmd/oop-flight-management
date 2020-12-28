using System;
using System.Collections.Generic;
using System.Text;

namespace FilghtManagement.Aircraft
{
    class AirCraft
    {
        public string Id { get; set; }

        public string Model { get; set; }

        public int FirstClassSeatAmount { get; set; }

        public int BusinessClassSeatAmount { get; set; }

        public int EconomyClassSeatAmount { get; set; }
    }
}
