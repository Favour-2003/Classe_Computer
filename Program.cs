using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classe__
{
    class Program
    {
        static void Main(string[] args)
        {
            Computer Acer = new Computer("Acer 5000", 500);
            Console.WriteLine("Nome > " + Acer.getName().ToString());
            Console.WriteLine("Prezzo > " + Acer.getPrezzo().ToString());

            Computer Hp = new Computer("Hp Notebook", 1000);
            Console.WriteLine("Nome > " + Hp.getName().ToString());
            Console.WriteLine("Prezzo > " + Hp.getPrezzo().ToString());
            Console.ReadKey();
        }
    }
}
