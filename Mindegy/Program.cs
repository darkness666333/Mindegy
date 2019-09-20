using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mindegy
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Szia hogy hívnak?");
            var nev = Console.ReadLine();
            Console.WriteLine("Oh milyen szép az, hogy "{nev}"! <3");
            Console.WriteLine("Szeretsz programozni?");
            var valasz = Console.ReadLine();
            if (valasz == "igen")
            {
                Console.WriteLine("Akkor mi nagyon jó barátok leszünk");
            }
            else
            {
                Console.WriteLine(":((( " );
            }
            Console.ReadKey();
        }
    }
}
