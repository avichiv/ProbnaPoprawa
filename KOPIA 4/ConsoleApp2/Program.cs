﻿using System;
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
            List<Skladnik> skladnik = new List<Skladnik>();
            skladnik.Add(new Skladnik("Peperoni", 3.29));
            skladnik.Add(new Skladnik("Cebula", 5.55));
            skladnik.Add(new Skladnik("Pomidory", 1.11));
            skladnik.Add(new Skladnik("Pieczarki", 2.22));
            skladnik.Add(new Skladnik("Kielbasa", 9.99));
            skladnik.Add(new Sos("Ketchup", 11.11));

            //Wypisanie listy na konsoli
            for (int i = 0; i < skladnik.Count; i++)
            {
                Console.WriteLine(skladnik[i] + " ");
            }
            Console.WriteLine("------------------------------------------------");
            skladnik.Sort();
            skladnik.Reverse();
            foreach (var element in skladnik)
            {
                Console.WriteLine(element);
            }
            Console.ReadKey();
        }
    }
}
