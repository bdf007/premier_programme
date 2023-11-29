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

        static void AfficherInfosPersonne (string nom, int age, float taille =0)
        {
            Console.WriteLine();
/*            Console.WriteLine("Bonjour vous vous appelez " + nom + ", vous avez " + age + " ans.");
*/            Console.WriteLine($"Bonjour vous vous appelez {nom},\nvous avez {age} ans.");

            // si age >= 18 afficher majeur sinon mineur
            // si age == 18 afficher tout juste majeur
            // si age == 17 afficher presque majeur
            // age >= 60 afficher senior
            // age <10 afficher enfant
            // age >= 12 et age < 18 adolescent
            // age==1 ou age ==2 bébé
            if (age == 18)
            {
                Console.WriteLine("Vous êtes tout juste majeur");
            }
            else if (age == 17)
            {
                Console.WriteLine("Vous êtes presque majeur");
            }
            else if ((age >= 12) && (age <18))
            {
                Console.WriteLine("Vous êtes un adolescent");
            }
            else if ((age == 1) || (age == 2))
            {
                Console.WriteLine("Vous êtes un bébé");
            }
            else if (age >= 60)
            {
                Console.WriteLine("Vous êtes un senior");
            }
            else if (age > 18)
            {
                Console.WriteLine("Vous êtes majeur");
            }              
            else if (age < 10)
            {
                Console.WriteLine("Vous êtes un enfant");
             }
            else
            {
                Console.WriteLine("Vous êtes mineur");
            }
            Console.WriteLine("L'année prochaine vous aurez " + (age+1) + " ans.");
            if (taille != 0)
            {

            Console.WriteLine("Wous faites " + taille + "m");
            }
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
            AfficherInfosPersonne(nom1, age1, 1.75f);
            AfficherInfosPersonne(nom2, age2);

            /*            float taille = 1.75f;
            */
            /* const int nbPersonne = 3;
             for (int i = 0; i<nbPersonne; i++)
             {
                 string nom = DemanderNom(i+1);
                 int age =DemanderAge(nom);
                 AfficherInfosPersonne(nom, age, 1.75f);
                 Console.WriteLine();
                 Console.WriteLine("--");
             }*/
        }

        
    }
}

