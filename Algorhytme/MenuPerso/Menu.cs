using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorhytme.MenuPerso
{
    class Menu
    {
        private List<LigneMenu> Lignes;

        public Menu()
        {
            Lignes = new List<LigneMenu>();
        }

        /// <summary>
        /// Insere une ligne dans un menu si le numéro de cette ligne n'est pas déjà présent.
        /// </summary>
        /// <param name="ligne"></param>
        /// <exception cref="ArgumentException">Si le numéro de la ligne existe déjà</exception>
        public void InsererLigne(LigneMenu ligne)
        {
            foreach (LigneMenu lignedumenu in Lignes)
            {
                if (ligne.Numero == lignedumenu.Numero)
                {
                    throw new ArgumentException($"Le numéro {ligne.Numero} existe déjà dans le menu");
                }
            }
            //if (menuItems.Exists( x=> x.Numero == item.Numero))
            //{
            //    throw new ArgumentException($"Le numéro {ligne.Numero} existe déjà dans le menu");
            //}
            Lignes.Add(ligne);
        }

        public void Afficher()
        {
            //Affiche les lignes du menu
            foreach (LigneMenu ligne in Lignes)
            {
                Console.WriteLine($"{ligne.Numero} {ligne.Texte.ToUpper()}");
            }
        }

        /// <summary>
        /// Demande à l'utilisateur un choix et renvoie ce choix
        /// </summary>
        /// <returns>Choix de l'utilisateur</returns>
        public int Choisir()
        {
            //Récupération de la saisie de l'utilisateur
            Console.WriteLine("Votre choix :");
            int saisi = int.Parse(Console.ReadLine());

            //Test de la saisie par rapport aux lignes du menu
            while (true)
            {
                foreach (LigneMenu ligne in Lignes)
                {
                    if (saisi == ligne.Numero)
                    {
                        return saisi;
                    }
                }
                Console.WriteLine("Erreur, saisir un choix:");
                saisi = int.Parse(Console.ReadLine());
            }
        }
    }
}
