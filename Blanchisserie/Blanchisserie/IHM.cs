using System;
using System.Collections.Generic;
using System.Text;

namespace Blanchisserie
{
    class IHM
    {
        private static IHM instance = null;
        private static object _lock = new object();

        public static IHM Instance
        {
            get
            {
                lock (_lock)
                {
                    if (instance == null)
                        instance = new IHM();
                    return instance;
                }
            }
        }

        private IHM()
        { }

        public  void MenuPrincipal()
        {
            Console.WriteLine("---------MENU PRINCIPAL----------");
            Console.WriteLine("1-Gestion Client");
            Console.WriteLine("2-Facturation");
            Console.WriteLine("3-Gestion Personnel");
            Console.WriteLine("0-Quitter");

            int choix;
            do
            {
                Int32.TryParse(Console.ReadLine(), out choix);
                switch (choix)
                {
                    case 1:
                        MenuClient();
                        break;
                    case 2:
                        Facturation();
                        break;
                    case 3:
                        MenuPersonnel();
                        break;
                    default:
                        DisplayRed("Enter a correct choice");
                        break;


                }

            } while (choix != 0);

        }

        public  void MenuClient()
        {
            Console.WriteLine("---Menu Client---");
            Console.WriteLine("1-Afficher liste des clients");
            Console.WriteLine("2-Ajouter un client");
            Console.WriteLine("3-Modifier un client");
            Console.WriteLine("4-Supprimer un client");
            Console.WriteLine("0-Quitter");

            int choix;
            do
            {
                Int32.TryParse(Console.ReadLine(), out choix);
                switch (choix)
                {
                    case 1:
                        break;
                    case 2:
                        Console.Write("Veuillez saisir le nom de l'entreprise :");
                        string  n = Console.ReadLine();
                        Console.Write("Veuillez saisir la rue de l'entreprise :");
                        string r = Console.ReadLine();
                        Console.Write("Veuillez saisir la ville de l'entreprise :");
                        string v = Console.ReadLine();
                        Console.Write("Veuillez saisir le téléphone de l'entreprise :");
                        string t = Console.ReadLine();
                        Console.Write("Veuillez saisir le mail de l'entreprise :");
                        string m = Console.ReadLine();
                        Client c = new Client
                        {
                            NomEntreprise = n,
                            RueEntreprise = r,
                            VilleEntreprise = v,
                            TelephoneEntreprise = t,
                            MailEntreprise = m
                        };
                        c.AjouterClient();
                        break;
                    case 3:
                        break;
                    case 4:
                        break;
                    default:
                        DisplayRed("Enter a correct choice");
                        break;


                }

            } while (choix != 0);

        }

        public  void Facturation()
        {
            Console.WriteLine("---Menu Facturation---");
            Console.WriteLine("1-Afficher liste des commandes");
            Console.WriteLine("2-Ajouter une commande");
            Console.WriteLine("3-Modifier une commande");
            Console.WriteLine("4-Supprimer une commande");
            Console.WriteLine("5-Afficher liste des factures");
            Console.WriteLine("6-Ajouter une facture");
            Console.WriteLine("0-Quitter");

            int choix;
            do
            {
                Int32.TryParse(Console.ReadLine(), out choix);
                switch (choix)
                {
                    case 1:
                        break;
                    case 2:
                        break;
                    case 3:
                        break;
                    case 4:
                        break;
                    case 5:
                        break;
                    case 6:
                        break;
                    default:
                        DisplayRed("Enter a correct choice");
                        break;


                }

            } while (choix != 0);
        }

        public  void MenuPersonnel()
        {
            Console.WriteLine("---Menu Personnel---");
            Console.WriteLine("1-Afficher liste du personnel");
            Console.WriteLine("2-Ajouter un employé");
            Console.WriteLine("3-Modifier un employé");
            Console.WriteLine("4-Supprimer un employé");
            Console.WriteLine("5-Editer le bulletin de salaire");
            Console.WriteLine("0-Quitter");



            int choix;
            do
            {
                Int32.TryParse(Console.ReadLine(), out choix);
                switch (choix)
                {
                    case 1:
                        break;
                    case 2:
                        break;
                    case 3:
                        break;
                    case 4:
                        break;
                    case 5:
                        break;
                    default :
                        DisplayRed("Enter a correct choice");
                        break;


                }

            } while (choix != 0);
        }

        public void DisplayRed(string chaine)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(chaine);
            Console.ForegroundColor = ConsoleColor.White;
        }










 }






}

