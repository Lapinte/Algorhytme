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
            Menu menuPrincipal = new Menu();
            
            menuPrincipal.InsererLigne(new LigneMenu { Numero = 1, Texte = "Voyages" });
            menuPrincipal.InsererLigne(new LigneMenu { Numero = 3, Texte = "Clients" });
            menuPrincipal.InsererLigne(new LigneMenu { Numero = 4, Texte = "Dossiers" });

            Menu Clients = new Menu();

            Clients.InsererLigne(new LigneMenu { Numero = 5, Texte = "Créer client" });
            Clients.InsererLigne(new LigneMenu { Numero = 7, Texte = "Rechercher client" });

            Menu Dossiers = new Menu();

            Dossiers.InsererLigne(new LigneMenu { Numero = 8, Texte = "Créer" });
            Dossiers.InsererLigne(new LigneMenu { Numero = 12, Texte = "Rechercher" });
            Dossiers.InsererLigne(new LigneMenu { Numero = 10, Texte = "Supprimer" });

            menuPrincipal.Afficher();

            int resultat = menuPrincipal.Choisir();
            
            switch (resultat)
            {
                case 1:
                    SousMenuVoyages();
                    break;

                case 3:
                    SousMenuClients();
                    break;

                case 4:
                    SousMenuDossiers();
                    break;
            }

            //return menu.SingleOrDefault(x => x.Numero == saisi) != null ? saisi : -1;
        
        }

        private static void SousMenuDossiers()
        {
            Menu Dossiers = new Menu();

            Dossiers.InsererLigne(new LigneMenu { Numero = 5, Texte = "Créer" });
            Dossiers.InsererLigne(new LigneMenu { Numero = 7, Texte = "Rechercher" });

            Dossiers.Afficher();
            int choix = Dossiers.Choisir();
            switch (choix)
            {
                case 8:
                    Console.WriteLine("Vous souhaitez: Dossiers => Créer");
                    Console.ReadKey();
                    break;

                case 12:
                    Console.WriteLine("Vous souhaitez: Dossiers => Rechercher");
                    Console.ReadKey();
                    break;

                case 10:
                    Console.WriteLine("Vous souhaitez: Dossiers => Supprimer");
                    Console.ReadKey();
                    break;
            }
        }

        private static void SousMenuClients()
        {
            Menu Clients = new Menu();

            Clients.InsererLigne(new LigneMenu { Numero = 5, Texte = "Créer" });
            Clients.InsererLigne(new LigneMenu { Numero = 7, Texte = "Rechercher" });

            Clients.Afficher();
            int choix = Clients.Choisir();
            switch (choix)
            {
                case 5:
                    Console.WriteLine("Vous souhaitez: Clients => Créer");
                    Console.ReadKey();
                    break;

                case 7:
                    Console.WriteLine("Vous souhaitez: Clients => Rechercher");
                    Console.ReadKey();
                    break;
            }
        }

        private static void SousMenuVoyages()
        {
            Menu Voyages = new Menu();

            Voyages.InsererLigne(new LigneMenu { Numero = 1, Texte = "Destinations" });
            Voyages.InsererLigne(new LigneMenu { Numero = 2, Texte = "Compagnies" });

            Voyages.Afficher();
            int choix = Voyages.Choisir();
            switch (choix)
            {
                case 1:
                    Console.WriteLine("Vous souhaitez: Voyages => Destination");
                    Console.ReadKey();
                    break;

                case 2:
                    Console.WriteLine("Vous souhaitez: Voyages => Compagnies");
                    Console.ReadKey();
                    break;
            }

        }
    }
}
