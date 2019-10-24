using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace If_inside_loop
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int a = 1; a <= 20; a++)
            {
                Console.WriteLine("Umur saya " + a + " tahun.");
                if (a == 17)
                {
                    Console.WriteLine("Umur saya " + a + " tahun. Saya sudah dewasa");
                }
            }
            Console.ReadKey();

        }
    }
}