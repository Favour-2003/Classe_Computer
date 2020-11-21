using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classe__
{
    class Computer
    {
        protected string name;
        protected float prezzo;

        public Computer(string n, float p)
        {
            name   =  n;
            prezzo = p;
        }

        public string getName()
        {
            return name;
        }

        public float getPrezzo()
        {
            return prezzo;
        }
    }
}
