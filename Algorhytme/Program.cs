using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorhytme
{
    class Program
    {
        static void Main(string[] args)
        {

        }
        public static int AfficherMenuEtRenvoyerSaisi(List<string> menu)
        {
            foreach (string ligne in menu)
            {
                Console.WriteLine(ligne);
            }

            Console.WriteLine("Votre choix :");

            int saisi = int.Parse(Console.ReadLine());
            return saisi;
        }
    }
}
