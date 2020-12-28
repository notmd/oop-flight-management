using System;
using System.Collections.Generic;
using System.Text;
using FilghtManagement.Customer;
using FilghtManagement.Flight;
namespace FilghtManagement.Ticket
{
    public enum SeatClass
    {
        FirstClass,
        Business,
        Economy
    }
    public class Ticket
    {
        public string Id { get; set; }

        public Customer.Customer Customer { get; set; }

        public Flight.Flight Flight { get; set; }

        public int Price { get; set; }

        public int SeatID { get; set; }

        public SeatClass SeatClass{get;set;}

        public bool Validity { get; set; }
    }
}
