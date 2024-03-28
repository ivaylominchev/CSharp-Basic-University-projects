namespace Task_3
{
    internal class Program
    {
        class Client
        {
            public string Name { get; set; }
            public string Region { get; set; }
            public string SalesRepresentative { get; set; }
            public bool Vip { get; set; }

            public Client(string name, string region, string salesRepresentative, bool vipCheck)
            {
                Name = name;
                Region = region;
                SalesRepresentative = salesRepresentative;
                Vip = vipCheck;
            }
        }
        static void Main(string[] args)
        {
            Console.Write("Enter number of clients: ");
            int n = int.Parse(Console.ReadLine());

            List<Client> clients = new List<Client>();

            for (int i = 0; i < n; i++)
            {
                Console.Write($"Enter name for client {i + 1}: ");
                string name = Console.ReadLine();
                Console.Write($"Enter region for client {i + 1}: ");
                string region = Console.ReadLine();
                Console.Write($"Enter sales representative for client {i + 1}: ");
                string salesRepresentative = Console.ReadLine();
                Console.Write($"Is client {i + 1} VIP? (true/false): ");
                bool vipCheck = bool.Parse(Console.ReadLine());

                Client client = new Client(name, region, salesRepresentative, vipCheck);
                clients.Add(client);

            }

            Console.WriteLine("Clients: ");
            foreach (Client client in clients)
            {
                Console.WriteLine($"Name: {client.Name}, Region: {client.Region}, Sales Representative: {client.SalesRepresentative}, VIP: {client.Vip}");
            }

            Console.Write("Enter sales representative for VIP clients: ");
            string saleRep = Console.ReadLine();

            Console.WriteLine($"All VIP clients for {saleRep}: ");

            foreach (Client client in clients)
            {
                if (client.SalesRepresentative == saleRep && client.Vip)
                {
                    Console.WriteLine($"Client name: {client.Name}");
                }
            }
        }
    }
}
