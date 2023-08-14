using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OPP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Manager mng = new Manager();
            mng.Name = "John";

            Client cl1 = mng.AddClient("Alex");
            cl1.Buy("Book");
            Console.WriteLine(cl1.Name);
            Console.WriteLine(cl1.GetPoint());
            cl1.Buy("Bag2");
            Console.WriteLine(cl1.GetPoint());

            Client cl2 = mng.AddClient("Marry");
            Console.WriteLine(cl2.GetPoint());
            Console.ReadKey();
        }
    }
    public class Client
    {
        public string Name;
        private int point = 0;

        public int GetPoint()
        {
            return point;
        }
        public void Buy(string prodduct) 
        {
            //Buy the product
            point++;
        }
    }
    public class Manager
    {
        public string Name;

        public Client AddClient(string ClientName)
        {
            Client client1 = new Client();
            client1.Name = ClientName;
            return client1;
        }
    }
}
