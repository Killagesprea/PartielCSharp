using System;
using Newtonsoft.Json;
using PartielCSharp_XML_JSON_GIT.Models;
using System.IO;

namespace PartielCSharp_XML_JSON_GIT
{
    class Program
    {

        public Program LogService { get; set; }

        static void Main(string[] args)
        {
            Console.WriteLine("a - Ajouter un log en JSON dans un fichier ");
            Console.WriteLine("b - Sauvegarder le fichier JSON dans un fichier XML");
            Console.WriteLine("c - Afficher les logs du fichier XML avant une date (dd/mm/yyyy)");
            Console.WriteLine("d - Quitter");

            String caseSwitch = Console.ReadLine();

            var exit = false;
            while (!exit)
            {
                switch (caseSwitch)
                {
                    case "a":

                        Console.WriteLine("Case a - Ajout log JSON dans un fichier \n");
                        EcrireLog();

                        exit = true;

                        break;
                    case "b":

                        Console.WriteLine("Case b - Sauvegarde du fichier JSON dans un fichier XML (confirm) \n");
                        Console.ReadLine();
                        exit = true;
                        break;
                    case "c":

                        Console.WriteLine("Case c - Demande de date : \n");
                        Console.ReadLine();
                        exit = true;
                        break;
                    case "d":

                        Console.WriteLine("Case d - On quitte (confirm)");
                        Console.ReadLine();
                        exit = true;
                        break;
                    default:

                        Console.WriteLine("Default case, try again");
                        Console.ReadLine();
                        exit = true;
                        break;
                }
            }
            
        }

    }
}
