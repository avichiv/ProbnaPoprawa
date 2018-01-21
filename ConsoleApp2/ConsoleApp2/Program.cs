using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Skladnik skladnik1 = new Skladnik("Dupa", 13);
            Console.WriteLine(skladnik1);
            List<string> skladnik = new List<string>();
            skladnik.Add("Peperoni");
            skladnik.Add("Ser");
            skladnik.Add("Pomidory");
            skladnik.Add("Cebula");
            skladnik.Add("Oliwki");
            skladnik.Add("Ketchup");

            for (int i = 0; i < skladnik.Count; i++)
            {
                Console.WriteLine(skladnik[i] + " ");
            }

            Console.ReadKey();
        }
    }
}
