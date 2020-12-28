using System;
using System.Collections.Generic;
using System.Text;

namespace FilghtManagement.Customer
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
    }
}
