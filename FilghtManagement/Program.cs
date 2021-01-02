using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace FlightManagement
{
    class Program
    {
        static List<AirCraft> airCrafts = new List<AirCraft>();
        static List<Customer> customers = new List<Customer>();
        static List<Airport> airports = new List<Airport>();
        static List<Pluggage> pluggages  = new List<Pluggage>();
        static List<Ticket> tickets = new List<Ticket>();
        static List<Flight> flights = new List<Flight>();
        static void Main(string[] args)
        {
            Init();
            //Query1();
            //Query2();
            Query3();
        }

        static void Init()
        {
            CreateAirCrafts();
            CreateAirports();
            CreateFlights();
            CreatePluggage();
            CreateTicket();
            CreateCustomers();
            AddCustomerToFlight();
        }

        static void CreateFlights()
        {
            flights.Add(new Flight(1, new DateTime(2021, 1, 2, 3, 4, 5), new DateTime(2021, 1, 2, 5, 4, 5), airCrafts[0], airports[0], airports[1]));
            flights.Add(new Flight(2, new DateTime(2021, 1, 2, 3, 4, 5), new DateTime(2021, 1, 2, 5, 4, 5), airCrafts[0], airports[1], airports[2]));
            flights.Add(new Flight(3, new DateTime(2021, 1, 2, 3, 4, 5), new DateTime(2021, 1, 2, 5, 4, 5), airCrafts[0], airports[3], airports[2]));
            flights.Add(new Flight(4, new DateTime(2021, 1, 2, 3, 4, 5), new DateTime(2021, 1, 2, 5, 4, 5), airCrafts[0], airports[4], airports[0]));
        }

        static void AddCustomerToFlight()
        {
            flights[0].Customers = customers.GetRange(0, 4);
            flights[1].Customers = customers.GetRange(4, 4);
            flights[2].Customers = customers.GetRange(8, 4);
            flights[3].Customers = customers.GetRange(12, 3);
        }

        static void CreateTicket()
        {
            tickets.Add(new Ticket(1, flights[0], 1000000, 1, SeatType.Business, true));
            tickets.Add(new Ticket(2, flights[0], 1000000, 2, SeatType.Economy, true));
            tickets.Add(new Ticket(3, flights[0], 1000000, 3, SeatType.Economy, true));
            tickets.Add(new Ticket(4, flights[0], 2000000, 4, SeatType.FirstClass, true));
            tickets.Add(new Ticket(5, flights[1], 1000000, 1, SeatType.Business, true));
            tickets.Add(new Ticket(6, flights[1], 1000000, 2, SeatType.Business, true));
            tickets.Add(new Ticket(7, flights[1], 1000000, 3, SeatType.Economy, true));
            tickets.Add(new Ticket(8, flights[1], 1000000, 4, SeatType.Business, true));
            tickets.Add(new Ticket(9, flights[2], 1000000, 1, SeatType.FirstClass, true));
            tickets.Add(new Ticket(10, flights[2], 1000000, 2, SeatType.FirstClass, true));
            tickets.Add(new Ticket(11, flights[2], 1000000, 3, SeatType.Economy, true));
            tickets.Add(new Ticket(12, flights[2], 1000000, 4, SeatType.Business, true));
            tickets.Add(new Ticket(13, flights[3], 1000000, 1, SeatType.Business, true));
            tickets.Add(new Ticket(14, flights[3], 1000000, 2, SeatType.Business, true));
            tickets.Add(new Ticket(15, flights[3], 1000000, 3, SeatType.Business, true));
        }

        static void CreateCustomers()
        {
            customers.Add(new Customer(1, "A", "Nguyen", 19, Gender.Male, "0123456789", pluggages[0],tickets[0]));
            customers.Add(new Customer(2, "B", "Nguyen", 19, Gender.Female, "0123456789", pluggages[1], tickets[1]));
            customers.Add(new Customer(3, "C", "Nguyen", 19, Gender.Male, "0123456789", pluggages[2], tickets[2]));
            customers.Add(new Customer(4, "D", "Nguyen", 19, Gender.Female, "0123456789", pluggages[3], tickets[3]));
            customers.Add(new Customer(5, "E", "Nguyen", 19, Gender.Male, "0123456789", pluggages[4], tickets[4]));
            customers.Add(new Customer(6, "F", "Nguyen", 19, Gender.Female, "0123456789", pluggages[5],tickets[5]));
            customers.Add(new Customer(7, "G", "Nguyen", 19, Gender.Male, "0123456789", pluggages[6],tickets[6]));
            customers.Add(new Customer(8, "H", "Nguyen", 19, Gender.Female, "0123456789", pluggages[7], tickets[7]));
            customers.Add(new Customer(9, "I", "Nguyen", 19, Gender.Male, "0123456789", pluggages[8], tickets[8]));
            customers.Add(new Customer(10, "J", "Nguyen", 19, Gender.Female, "0123456789", pluggages[9], tickets[9]));
            customers.Add(new Customer(11, "K", "Nguyen", 19, Gender.Male, "0123456789", pluggages[10], tickets[10]));
            customers.Add(new Customer(12, "L", "Nguyen", 19, Gender.Female, "0123456789", pluggages[11], tickets[11]));
            customers.Add(new Customer(13, "M", "Nguyen", 19, Gender.Male, "0123456789", pluggages[12], tickets[12]));
            customers.Add(new Customer(14, "N", "Nguyen", 19, Gender.Female, "0123456789", pluggages[13], tickets[13]));
            customers.Add(new Customer(15, "O", "Nguyen", 19, Gender.Male, "0123456789", pluggages[14], tickets[14]));
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
            airports.Add(new Airport(1, "Da Nang International Airport", "Danang", "Vietnam", 16.043899536132812, 108.1989974975586));
            airports.Add(new Airport(2, "Noi Bai International Airport", "Hanoi", "Vietnam", 21.221200942993164, 105.80699920654297));
            airports.Add(new Airport(3, "Phu Quoc International Airport", "Phuquoc", "Vietnam", 10.1698, 103.9931));
            airports.Add(new Airport(4, "Tan Son Nhat International Airport", "Ho Chi Minh City", "Vietnam", 10.8187999725, 106.652000427));
            airports.Add(new Airport(5, "Vinh Airport", "Vinh", "Vietnam", 18.7376003265, 105.67099762));
        }

        static void CreatePluggage()
        {
            pluggages.Add(new Pluggage(1,  1));
            pluggages.Add(new Pluggage(2, 2));
            pluggages.Add(new Pluggage(3, 3));
            pluggages.Add(new Pluggage(4, 4));
            pluggages.Add(new Pluggage(5, 5));
            pluggages.Add(new Pluggage(6, 6));
            pluggages.Add(new Pluggage(7, 7));
            pluggages.Add(new Pluggage(8, 8));
            pluggages.Add(new Pluggage(9, 9));
            pluggages.Add(new Pluggage(10, 10));
            pluggages.Add(new Pluggage(11, 11));
            pluggages.Add(new Pluggage(12, 12));
            pluggages.Add(new Pluggage(13, 13));
            pluggages.Add(new Pluggage(14, 14));
            pluggages.Add(new Pluggage(15, 15));
        }

        static void Query1()
        {
            Console.WriteLine("Cau 1");

            var res = flights.First(flight => flight.Id == 1)
                .Customers
                .Sum(customer => customer.Pluggage.Weight);

            Console.WriteLine(res);
        }

        static void Query2()
        {
            Console.WriteLine("Cau 2");

            var res = flights.First(Flight => Flight.Id == 2)
                .Customers
                .Where(customer => customer.Gender == Gender.Female)
                .Count();

            Console.WriteLine(res);
        }

        static void Query3()
        {
            Console.WriteLine("Cau 3");

            var res = flights.Aggregate(
                (flight1, flight2) =>
                {
                    var count1 = flight1.Customers.Where(
                    customer => customer.Ticket.SeatType == SeatType.FirstClass
                    ).Count();
                    var count2 = flight2.Customers.Where(
                    customer => customer.Ticket.SeatType == SeatType.FirstClass
                    ).Count();

                    return count1 > count2 ? flight1 : flight2;
                }
                ).Id;

            Console.WriteLine(res);
        }
      
    }
}
