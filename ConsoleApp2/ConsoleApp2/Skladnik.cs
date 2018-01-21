using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Skladnik
    {
        protected string nazwaSkladnika;
        protected double cenaSkladnika;

        public Skladnik(string nazwaSkladnika, double cenaSkladnika)
        {
            this.nazwaSkladnika = nazwaSkladnika;
            this.cenaSkladnika = cenaSkladnika;
        }

        public override string ToString()
        {
            return "Skladnik: " + nazwaSkladnika + " cena: " + cenaSkladnika;
        }
        
        public double PobierzCene()
        {
            return cenaSkladnika;
        }
    }
}
