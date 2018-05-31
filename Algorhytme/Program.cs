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
        private static int GererMenu(List<LigneMenu> menu)
        {
            foreach (LigneMenu ligne in menu)
            {
                Console.WriteLine($"{ligne.Numero} {ligne.Texte}");
            }


            Console.WriteLine("Votre choix :");

            int saisi = int.Parse(Console.ReadLine());

            foreach (LigneMenu ligne in menu)
            {
                if (saisi == ligne.Numero)
                {
                    return saisi;
                }
            }
            return -1;

            //return menu.SingleOrDefault(x => x.Numero == saisi) != null ? saisi : -1;
        }
    }
}
