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
            //Création d'un menu composé de plusieurs lignes de type LigneMenu
            List<LigneMenu> menu = new List<LigneMenu>
            {
                new LigneMenu { Numero = 1, Texte = "Aller au sous-menu"},
                new LigneMenu { Numero = 3, Texte = "Aller au sous-sol"},
                new LigneMenu { Numero = 42, Texte = "Aller en enfer"},
            };

            GererMenu(menu);
            
        }
        private static int GererMenu(List<LigneMenu> menu)
        {
            //Affiche les lignes du menu
            foreach (LigneMenu ligne in menu)
            {
                Console.WriteLine($"{ligne.Numero} {ligne.Texte.ToUpper()}");
            }

            //Récupération de la saisie de l'utilisateur
            Console.WriteLine("Votre choix :");
            int saisi = int.Parse(Console.ReadLine());

            //Test de la saisie par rapport aux lignes du menu
            while (true)
            {
                foreach (LigneMenu ligne in menu)
                {
                    if (saisi == ligne.Numero)
                    {
                        return saisi;
                    }
                }
                Console.WriteLine("Erreur, saisir un choix:");
                saisi = int.Parse(Console.ReadLine());
            }

            //return menu.SingleOrDefault(x => x.Numero == saisi) != null ? saisi : -1;
        }
    }
}
