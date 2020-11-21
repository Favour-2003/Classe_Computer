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
        protected string color;

        public Computer(string n, float p, string c)
        {
            name   =  n;
            prezzo = p;
            color = c;
        }

        public string getName()
        {
            return name;
        }

        public float getPrezzo()
        {
            return prezzo;
        }

        public string getColor()
        {
            return color;
        }
    }
}
