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
        static List<Luggage> luggages  = new List<Luggage>();
        static List<Ticket> tickets = new List<Ticket>();
        static List<Flight> flights = new List<Flight>();
        static void Main(string[] args)
        {
            Init();
            //Query1();
            //Query2();
            //Query3();
            //Query4();
            //Query5();
            //Query6();
            //Query7();
            //Query8();
            //Query9();
            //Query10();
            //Query11();
            //Query12();
            //Query14();
            //Query15();
            //Query16();
            //Query17();
            //Query18();
            //Query19();
            Query20();
        }

        static void Query1()
        {
            Console.WriteLine("Cau 1");

            var res = flights.First(flight => flight.Id == 1)
                .Customers
                .Sum(customer => customer.Luggage.Weight);

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

        static void Query4()
        {
            Console.WriteLine("Cau 4");

            var res = flights.Where(flight => flight.ArrivalAirPort.City == "Hanoi");
            res.ToList().ForEach(flight => Console.WriteLine(flight.AirCraft.Model));
        }

        static void Query5()
        {
            Console.WriteLine("Cau 5");

            var res = flights.Find(flight => flight.Id == 3)
                .Customers.Sum(customer => customer.Ticket.Price);

            Console.WriteLine(res);
        }

        static void Query6()
        {
            Console.WriteLine("Cau 6");

            var res = flights.Where(flight => {
                var endDate = flight.EndDate;

                return endDate.Day == 2 && endDate.Month == 1 && endDate.Year == 2021;
            });

            res.ToList().ForEach(flight => Console.WriteLine(flight.Id));
        }

        static void Query7()
        {
            Console.WriteLine("Cau 7");

            var res = flights.Aggregate((flight1, flight2) =>
            {
                var count1 = flight1.Customers.Count(customer => customer.Age < 18);
                var count2 = flight2.Customers.Count(customer => customer.Age < 18);

                return count1 > count2 ? flight1 : flight2;
            }).Id;
            
            Console.WriteLine(res);
        }

        static void Query8()
        {
            Console.WriteLine("Cau 8");

            var res = customers.Average(customer => customer.Age);

            Console.WriteLine(res);
        }

        static void Query9()
        {
            Console.WriteLine("Cau 9");

            var res = customers.Find(customer => customer.LastName + " " + customer.FirstName == "Nguyen A")
                   .Ticket
                   .Flight
                   .DepartureAirPort
                   .Name;

            Console.WriteLine(res);
        }

        static void Query10()
        {
            Console.WriteLine("Cau 10");

            var res = flights.Select(flight => flight.EndDate.Subtract(flight.StartDate).TotalHours)
                .Average();

            Console.WriteLine(res);
        }
        static void Query11()
        {
            Console.WriteLine("Cau 11");

            var res = airports.Aggregate((airport1, airport2) =>
            {
                var count1 = flights.Count(flight => flight.ArrivalAirPort.Id == airport1.Id || flight.DepartureAirPort.Id == airport1.Id);
                var count2 = flights.Count(flight => flight.ArrivalAirPort.Id == airport2.Id || flight.DepartureAirPort.Id == airport2.Id);

                return count1 > count2 ? airport1 : airport2;
            }).Name;

            Console.WriteLine(res);
        }

        static void Query12()
        {
            Console.WriteLine("Cau 12");

            var res = flights.Find(flight => flight.Id == 4)
                .Customers
                .Where(customer => customer.Ticket.SeatType == SeatType.Business)
                .Count();

            Console.WriteLine(res);
        }

        static void Query13()
        {
            Console.WriteLine("Cau 13");

            var res = flights.Aggregate((flight1, flight2) =>
            {
                var time1 = flight1.EndDate.Subtract(flight1.StartDate);
                var time2 = flight2.EndDate.Subtract(flight2.StartDate);

                return time1.CompareTo(time2) >= 0 ? flight1 : flight2;
            }).Id;

            Console.WriteLine(res);
        }

        static void Query14()
        {
            Console.WriteLine("Cau 14");

            var res = flights.Aggregate((flight1, flight2) => flight1.Customers.Count > flight2.Customers.Count ? flight1 : flight2)
                .Id;

            Console.WriteLine(res);
        }

        static void Query15()
        {
            Console.WriteLine("Cau 15");

            var res = flights.Find(flight => flight.Id == 2)
                .Customers
                .Aggregate((customer1, customer2) => customer1.Age > customer2.Age ? customer1 : customer2)
                .PhoneNumber;

            Console.WriteLine(res);
        }

        static void Query16()
        {
            Console.WriteLine("Cau 16");

            var res = flights.Count(flight => flight.EndDate.Subtract(flight.StartDate).TotalDays < 1);

            Console.WriteLine(res);
        }

        static void Query17()
        {
            Console.WriteLine("Cau 17");

            var res = flights.Find(flight => flight.Id == 1)
                .Customers
                .Aggregate((customer1, customer2) => customer1.Luggage.Weight >= customer2.Luggage.Weight ? customer1 : customer2)
                .Id;

            Console.WriteLine(res);
        }

        static void Query18()
        {
            Console.WriteLine("Cau 18");

            var res = customers.Count(customer => customer.Luggage.Weight > 5);

            Console.WriteLine(res);
        }

        static void Query19()
        {
            Console.WriteLine("Cau 19");

            airports.Select(airport => new { 
                Name = airport.Name,
                Count = flights.Count(flight => flight.ArrivalAirPort.Id == airport.Id)
            })
                .Where(e => e.Count < 1)
                .ToList()
                .ForEach(e => Console.WriteLine(e.Name));
        }

        static void Query20()
        {
            Console.WriteLine("Cau 20");

            var res = tickets.GroupBy(ticket => ticket.SeatType)
                    .Select(group => new {
                        SeatType = group.Key,
                        Count = group.Count()
                    })
                    .OrderByDescending(g => g.Count)
                    .First()
                    .SeatType;

            Console.WriteLine(res);
        }

        static void Init()
        {
            CreateAirCrafts();
            CreateAirports();
            CreateFlights();
            CreateLuggage();
            CreateTicket();
            CreateCustomers();
            AddCustomerToFlight();
        }

        static void CreateFlights()
        {
            flights.Add(new Flight(1, new DateTime(2021, 1, 2, 3, 4, 5), new DateTime(2021, 1, 2, 9, 4, 5), airCrafts[0], airports[0], airports[1]));
            flights.Add(new Flight(2, new DateTime(2021, 1, 2, 3, 4, 5), new DateTime(2021, 1, 3, 1, 4, 5), airCrafts[1], airports[1], airports[2]));
            flights.Add(new Flight(3, new DateTime(2021, 1, 2, 3, 4, 5), new DateTime(2021, 1, 2, 5, 4, 5), airCrafts[2], airports[3], airports[2]));
            flights.Add(new Flight(4, new DateTime(2021, 1, 3, 3, 4, 5), new DateTime(2021, 1, 3, 5, 4, 5), airCrafts[3], airports[4], airports[0]));
            flights.Add(new Flight(5, new DateTime(2021, 1, 3, 3, 4, 5), new DateTime(2021, 1, 4, 5, 4, 5), airCrafts[4], airports[2], airports[4]));
        }

        static void AddCustomerToFlight()
        {
            flights[0].Customers = customers.GetRange(0, 4);
            flights[1].Customers = customers.GetRange(4, 4);
            flights[2].Customers = customers.GetRange(8, 4);
            flights[3].Customers = customers.GetRange(12, 3);
            flights[4].Customers = customers.GetRange(15, 5);
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
            tickets.Add(new Ticket(16, flights[4], 1000000, 3, SeatType.FirstClass, true));
            tickets.Add(new Ticket(17, flights[4], 1000000, 3, SeatType.Business, true));
            tickets.Add(new Ticket(18, flights[4], 1000000, 3, SeatType.Economy, true));
            tickets.Add(new Ticket(19, flights[4], 1000000, 3, SeatType.Business, true));
            tickets.Add(new Ticket(20, flights[4], 1000000, 3, SeatType.Business, true));
        }

        static void CreateCustomers()
        {
            customers.Add(new Customer(1, "A", "Nguyen", 45, Gender.Male, "0123456701", luggages[0], tickets[0]));
            customers.Add(new Customer(2, "B", "Nguyen", 12, Gender.Female, "0123456702", luggages[1], tickets[1]));
            customers.Add(new Customer(3, "C", "Nguyen", 56, Gender.Male, "0123456703", luggages[2], tickets[2]));
            customers.Add(new Customer(4, "D", "Nguyen", 19, Gender.Female, "0123456704", luggages[3], tickets[3]));
            customers.Add(new Customer(5, "E", "Nguyen", 12, Gender.Male, "0123456705", luggages[4], tickets[4]));
            customers.Add(new Customer(6, "F", "Nguyen", 14, Gender.Female, "0123456706", luggages[5], tickets[5]));
            customers.Add(new Customer(7, "G", "Nguyen", 20, Gender.Male, "0123456707", luggages[6], tickets[6]));
            customers.Add(new Customer(8, "H", "Nguyen", 19, Gender.Female, "0123456708", luggages[7], tickets[7]));
            customers.Add(new Customer(9, "I", "Nguyen", 11, Gender.Male, "0123456709", luggages[8], tickets[8]));
            customers.Add(new Customer(10, "J", "Nguyen", 28, Gender.Female, "0123456710", luggages[9], tickets[9]));
            customers.Add(new Customer(11, "K", "Nguyen", 30, Gender.Male, "0123456711", luggages[10], tickets[10]));
            customers.Add(new Customer(12, "L", "Nguyen", 24, Gender.Female, "0123456712", luggages[11], tickets[11]));
            customers.Add(new Customer(13, "M", "Nguyen", 10, Gender.Male, "0123456713", luggages[12], tickets[12]));
            customers.Add(new Customer(14, "N", "Nguyen", 19, Gender.Female, "0123456714", luggages[13], tickets[13]));
            customers.Add(new Customer(15, "O", "Nguyen", 8, Gender.Male, "0123456715", luggages[14], tickets[14]));
            customers.Add(new Customer(16, "P", "Nguyen", 8, Gender.Male, "0123456716", luggages[15], tickets[15]));
            customers.Add(new Customer(17, "Q", "Nguyen", 8, Gender.Male, "0123456717", luggages[16], tickets[16]));
            customers.Add(new Customer(18, "R", "Nguyen", 8, Gender.Male, "0123456718", luggages[17], tickets[17]));
            customers.Add(new Customer(19, "S", "Nguyen", 8, Gender.Male, "0123456719", luggages[18], tickets[18]));
            customers.Add(new Customer(20, "T", "Nguyen", 8, Gender.Male, "0123456720", luggages[19], tickets[19]));
        }

        static void CreateAirCrafts()
        {
            airCrafts.Add(new AirCraft(1, "Airbus A300", "AB3", "A30B"));
            airCrafts.Add(new AirCraft(2, "Airbus A321", "321", "A321"));
            airCrafts.Add(new AirCraft(3, "Boeing 747-100", "741", "B741"));
            airCrafts.Add(new AirCraft(4, "Airbus A350-900", "359", "A359"));
            airCrafts.Add(new AirCraft(5, "Airbus A380-800", "388", "A388"));
            airCrafts.Add(new AirCraft(6, "Aerospatiale/Alenia ATR 72", "AT7", "AT72"));
            //airCrafts.Add(new AirCraft(7, "Boeing 767-300", "763", "B763"));
            //airCrafts.Add(new AirCraft(8, "Boeing 777-300", "773", "B773"));
            //airCrafts.Add(new AirCraft(9, "Boeing 767-200", "762", "B762"));
            //airCrafts.Add(new AirCraft(10, "Airbus A330-300", "333", "A333"));
        }

        static void CreateAirports()
        {
            airports.Add(new Airport(1, "Da Nang International Airport", "Danang", "Vietnam", 16.043899536132812, 108.1989974975586));
            airports.Add(new Airport(2, "Noi Bai International Airport", "Hanoi", "Vietnam", 21.221200942993164, 105.80699920654297));
            airports.Add(new Airport(3, "Phu Quoc International Airport", "Phuquoc", "Vietnam", 10.1698, 103.9931));
            airports.Add(new Airport(4, "Tan Son Nhat International Airport", "Ho Chi Minh City", "Vietnam", 10.8187999725, 106.652000427));
            airports.Add(new Airport(5, "Vinh Airport", "Vinh", "Vietnam", 18.7376003265, 105.67099762));
        }

        static void CreateLuggage()
        {
            luggages.Add(new Luggage(1, 2));
            luggages.Add(new Luggage(2, 2));
            luggages.Add(new Luggage(3, 4));
            luggages.Add(new Luggage(4, 6));
            luggages.Add(new Luggage(5, 5));
            luggages.Add(new Luggage(6, 6));
            luggages.Add(new Luggage(7, 7));
            luggages.Add(new Luggage(8, 8));
            luggages.Add(new Luggage(9, 9));
            luggages.Add(new Luggage(10, 10));
            luggages.Add(new Luggage(11, 11));
            luggages.Add(new Luggage(12, 12));
            luggages.Add(new Luggage(13, 13));
            luggages.Add(new Luggage(14, 14));
            luggages.Add(new Luggage(15, 15));
            luggages.Add(new Luggage(16, 16));
            luggages.Add(new Luggage(17, 17));
            luggages.Add(new Luggage(18, 18));
            luggages.Add(new Luggage(19, 19));
            luggages.Add(new Luggage(20, 20));
        }

    }
}
