using System;
using System.Collections.Generic;

namespace FlightManagement
{
    class Program
    {
        static List<AirCraft> airCrafts = new List<AirCraft>();
        static List<Customer> customers = new List<Customer>();
        static List<Airport> airports = new List<Airport>();
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        static void CreateCustomers()
        {
            customers.Add(new Customer(1, "A", "Nguyen", 19, Gender.Male, "0123456789"));
            customers.Add(new Customer(2, "B", "Nguyen", 19, Gender.Female, "0123456789"));
            customers.Add(new Customer(3, "C", "Nguyen", 19, Gender.Male, "0123456789"));
            customers.Add(new Customer(4, "D", "Nguyen", 19, Gender.Female, "0123456789"));
            customers.Add(new Customer(5, "E", "Nguyen", 19, Gender.Male, "0123456789"));
            customers.Add(new Customer(6, "F", "Nguyen", 19, Gender.Female, "0123456789"));
            customers.Add(new Customer(7, "G", "Nguyen", 19, Gender.Male, "0123456789"));
            customers.Add(new Customer(8, "H", "Nguyen", 19, Gender.Female, "0123456789"));
            customers.Add(new Customer(9, "I", "Nguyen", 19, Gender.Male, "0123456789"));
            customers.Add(new Customer(10, "J", "Nguyen", 19, Gender.Female, "0123456789"));
            customers.Add(new Customer(11, "K", "Nguyen", 19, Gender.Male, "0123456789"));
            customers.Add(new Customer(12, "L", "Nguyen", 19, Gender.Female, "0123456789"));
            customers.Add(new Customer(13, "M", "Nguyen", 19, Gender.Male, "0123456789"));
            customers.Add(new Customer(14, "N", "Nguyen", 19, Gender.Female, "0123456789"));
            customers.Add(new Customer(15, "O", "Nguyen", 19, Gender.Male, "0123456789"));
        }

        static void CreateAirCrafts()
        {
            airCrafts.Add(new AirCraft(1, "Airbus A300", "AB3", "A30B"));
            airCrafts.Add(new AirCraft(2, "Airbus A321", "321", "A321"));
            airCrafts.Add(new AirCraft(3, "Boeing 747-100", "741", "B741"));
            airCrafts.Add(new AirCraft(4, "Airbus A350-900", "359", "A359"));
            airCrafts.Add(new AirCraft(5, "Aerospatiale/Alenia ATR 72", "AT7", "AT72"));
            airCrafts.Add(new AirCraft(6, "Airbus A380-800", "388", "A388"));
            airCrafts.Add(new AirCraft(7, "Boeing 767-300", "763", "B763"));
            airCrafts.Add(new AirCraft(8, "Boeing 777-300", "773", "B773"));
            airCrafts.Add(new AirCraft(9, "Boeing 767-200", "762", "B762"));
            airCrafts.Add(new AirCraft(10, "Airbus A330-300", "333", "A333"));
        }

        static void CreateAirports()
        {
            airports.Add(new Airport(3196, "Da Nang International Airport", "Danang", "Vietnam", 16.043899536132812, 108.1989974975586));
            airports.Add(new Airport(3199, "Noi Bai International Airport", "Hanoi", "Vietnam", 21.221200942993164, 105.80699920654297));
            airports.Add(new Airport(3204, "Phu Quoc International Airport", "Phuquoc", "Vietnam", 10.1698, 103.9931));
            airports.Add(new Airport(3205, "Tan Son Nhat International Airport", "Ho Chi Minh City", "Vietnam", 10.8187999725, 106.652000427));
            airports.Add(new Airport(6195, "Vinh Airport", "Vinh", "Vietnam", 18.7376003265, 105.67099762));
            //airports.Add(new Airport(3196, "Da Nang International Airport", "Danang", "Vietnam", "16.043899536132812", "108.1989974975586"));
        }


    }
}
