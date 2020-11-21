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

            Computer Lenovo = new Computer("Lenovo xp", 1500);
            Console.WriteLine("Nome > " + Lenovo.getName().ToString());
            Console.WriteLine("Prezzo > " + Lenovo.getPrezzo().ToString());
            Console.ReadKey();

            Console.ReadKey();
        }
    }
}
