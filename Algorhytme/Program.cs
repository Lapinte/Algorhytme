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
            List<LigneMenu> menu = new List<LigneMenu>();

            menu.Add(new LigneMenu { Numero = 1, Texte = "-  Aller au premier sous menu" });
            menu.Add(new LigneMenu { Numero = 42, Texte = "-  Aller en enfer" });

            foreach (LigneMenu ligne in menu)
            {
                Console.WriteLine($"{ligne.Numero} {ligne.Texte}");
            }

            
            Console.WriteLine("Votre choix :");

            int saisi = int.Parse(Console.ReadLine());

        }
    }
}
