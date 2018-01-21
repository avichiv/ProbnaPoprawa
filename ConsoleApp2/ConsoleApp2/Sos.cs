using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Sos : Skladnik
    {
        public Sos(string nazwaSkladnika, double cenaSkladnika)
        {
            this.nazwaSkladnika = nazwaSkladnika;
            this.cenaSkladnika = cenaSkladnika;
        }

        public override string ToString()
        {
            return "Sos: " + nazwaSkladnika + " cena: " + cenaSkladnika;
        }
    }
}
