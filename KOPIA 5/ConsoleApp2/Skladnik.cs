using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Skladnik : IComparable
    {
        protected string nazwaSkladnika;
        protected double cenaSkladnika;

        public Skladnik(string nazwaSkladnika, double cenaSkladnika)
        {
            this.nazwaSkladnika = nazwaSkladnika;
            this.cenaSkladnika = cenaSkladnika;
            try
            {
                if (cenaSkladnika < 0)
                {
                    throw new Exception();
                }
                else
                {
                    this.cenaSkladnika = cenaSkladnika;
                }
            }
            catch
            {
                Console.WriteLine("Cena mniejsza od 0!");
            }
        }

        public override string ToString()
        {
            return "Skladnik: " + nazwaSkladnika + " cena: " + cenaSkladnika;
        }
        
        public double PobierzCene()
        {
            return cenaSkladnika;
        }

        public int CompareTo(object obj)
        {
            Skladnik n = (Skladnik)obj;
            return -cenaSkladnika.CompareTo(n.cenaSkladnika);
        }




    }
}
