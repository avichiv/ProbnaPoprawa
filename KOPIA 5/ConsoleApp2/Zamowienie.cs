using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    abstract class Zamowienie
    {
        protected string czasDostawy;
   

        public virtual bool PoprawnyCzas()
        {
            if (czasDostawy != null)
                return true;
            else
                return false;

        }
        
        public void UstawCzasDostawy(string czasDostawy)
        {
            this.czasDostawy = czasDostawy;
        }
    
    }
}
