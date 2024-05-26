namespace Task_12
{
    internal class Program
    {
        class Passenger
        {
            public string Name { get; set; }
            public int FlightNumber { get; set; }
            public string Destination { get; set; }
            public string Airline { get; set; }
            public DateTime ReservationDate { get; set; }
            public string Status { get; set; }

            public Passenger(string name, int flightNumber, string destination, string airline, DateTime reservationDate, string status)
            {
                Name = name;
                FlightNumber = flightNumber;
                Destination = destination;
                Airline = airline;
                ReservationDate = reservationDate;
                Status = status;
            }
        }
        static void Main(string[] args)
        {
            Queue<Passenger> passengersQueue = new Queue<Passenger>();

            passengersQueue.Enqueue(new Passenger("Иван Петров", 101, "Лондон", "British Airways", DateTime.Parse("2024-05-23"), "Потвърдена"));
            passengersQueue.Enqueue(new Passenger("Мария Иванова", 102, "Париж", "Air France", DateTime.Parse("2024-05-25"), "Очаква потвърждение"));
            passengersQueue.Enqueue(new Passenger("Петър Георгиев", 101, "Лондон", "British Airways", DateTime.Parse("2024-05-20"), "Потвърдена"));
            passengersQueue.Enqueue(new Passenger("Анна Николова", 103, "Рим", "Alitalia", DateTime.Parse("2024-05-24"), "Изчаква плащане"));

            int flightNumberToCheck = 101;
            int n = 2;
            CheckPassengerStatus(passengersQueue, flightNumberToCheck, n);
        }

        static void CheckPassengerStatus(Queue<Passenger> passengersQueue, int flightNumber, int n)
        {
            Console.WriteLine($"Пътници с полет номер {flightNumber}, чийто статус ще бъде потвърден:");

            int count = 0;
            foreach (var passenger in passengersQueue)
            {
                if (passenger.FlightNumber == flightNumber)
                {
                    Console.WriteLine($"- {passenger.Name}: {passenger.Status}");
                    count++;
                }

                if (count == n)
                {
                    break;
                }
            }
        }
    }
}
