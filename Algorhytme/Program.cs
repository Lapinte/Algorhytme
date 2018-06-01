using Algorhytme.MenuPerso;
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
            Menu menu = new Menu();
            
            LigneMenu ligne1 = new LigneMenu { Numero = 1, Texte = "Aller au sous-menu"};
            LigneMenu ligne2 = new LigneMenu { Numero = 4, Texte = "Aller au sous-sol" };
            LigneMenu ligne3 = new LigneMenu { Numero = 4, Texte = "Aller encore au sous-sol" };
            LigneMenu ligne4 = new LigneMenu { Numero = 6, Texte = "Aller a Ibiza" };
            LigneMenu ligne5 = new LigneMenu { Numero = 42, Texte = "Aller en enfer" };

            menu.InsererLigne(ligne1);
            menu.InsererLigne(ligne2);
            menu.InsererLigne(ligne3);
            menu.InsererLigne(ligne4);
            menu.InsererLigne(ligne5);

            menu.Afficher();

            int resultat = menu.Choisir();
            Console.WriteLine(resultat);
            Console.ReadKey();

            //return menu.SingleOrDefault(x => x.Numero == saisi) != null ? saisi : -1;
        }
    }
}
