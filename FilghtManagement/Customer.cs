using System;
using System.Collections.Generic;
using System.Text;

namespace FlightManagement
{
    public enum Gender
    {
        Male = 0,
        Female = 1
    }
    public class Customer
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public Gender Gender { get; set; }
        public string PhoneNumber { get; set; }
        public Pluggage Pluggage { get; set; }
        public Ticket Ticket { get; set; }

        public Customer(int Id, string FirstName, string LastName, int Age, Gender Gender, string PhoneNumber, Pluggage pluggage, Ticket ticket)
        {
            this.Id = Id;
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.Age = Age;
            this.Gender = Gender;
            this.PhoneNumber = PhoneNumber;
            this.Pluggage = pluggage;
            this.Ticket = ticket;
        }
    }
}
