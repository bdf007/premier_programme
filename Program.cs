// See https://aka.ms/new-console-template for more information
using System;

namespace premier_programme
{
    class Program
    {
        static string DemanderNom( int numeroPersonne)
        {
            string nomDeLaPersonne = "";
            while (nomDeLaPersonne == "")
            {
                Console.Write("Quel est le nom de la personne " + numeroPersonne + "? ");
                nomDeLaPersonne = Console.ReadLine();
                nomDeLaPersonne = nomDeLaPersonne.Trim();
                if (nomDeLaPersonne == "")
                {
                    Console.WriteLine("Erreur: vous devez rentrer un nom");
                }
            }
            return nomDeLaPersonne;
        }
        static int DemanderAge(string nom)
        {
            int age_num = 0;
            while (age_num <= 0)
            {
                Console.Write("Quek est l'age de "+ nom + "? ");
                string ageDeLaPersonne = Console.ReadLine();
                try
                {
                    age_num = int.Parse(ageDeLaPersonne);
                    if (age_num < 0)
                    {
                        Console.WriteLine("Erreur: l'age ne peut pas etre négatif");
                    }
                    if (age_num == 0)
                    {
                        Console.WriteLine("Erreur: l'age ne peut pas etre égal à zéro");
                    }
                }
                catch
                {
                    Console.WriteLine("Erreur: vous devez rentrer un age valide");
                }
            }
            return age_num;
        }

        static void AfficherInfosPersonne (string nom, int age)
        {
            Console.WriteLine();
            Console.WriteLine("Bonjour vous vous appelez " + nom + ", vous avez " + age + " ans.");
            Console.WriteLine("L'année prochaine vous aurez " + (age+1) + " ans.");
        }

        static void Main(string[] args)
        {
            //Demander nom
            string nom1 = DemanderNom(1);
            string nom2 = DemanderNom(2);
          
            //Demander Age
            int age1 = DemanderAge(nom1);
            int age2 = DemanderAge(nom2);

            // afficher les infos
            AfficherInfosPersonne (nom1, age1);
            AfficherInfosPersonne (nom2, age2);

        }

        
    }
}

