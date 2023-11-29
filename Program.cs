// See https://aka.ms/new-console-template for more information
using System;

namespace premier_programme
{
    class Program
    {
        static void Main(string[] args)
        {
            string nomDeLaPersonne = "";

            while (nomDeLaPersonne == "")
            {
                Console.Write("Quel est ton nom? ");
                nomDeLaPersonne = Console.ReadLine();
                nomDeLaPersonne = nomDeLaPersonne.Trim();
                if (nomDeLaPersonne == "")
                {
                    Console.WriteLine("Erreur: vous devez rentrer un nom");
                }
            }
          

            int age_num = 0;

            while (age_num <= 0)
            {

            Console.Write("Quek est votre age? ");
            string ageDeLaPersonne = Console.ReadLine();
            try
            {
                age_num = int.Parse(ageDeLaPersonne);
                    if (age_num < 0) {
                        Console.WriteLine("Erreur: l'age ne peut pas etre négatif");
                    }
                    if(age_num ==0)
                    {
                        Console.WriteLine("Erreur: l'age ne peut pas etre égal à zéro");
                    }

            }
            catch
            {
                Console.WriteLine("Erreur: vous devez rentrer un age valide");
            }
            }
                Console.WriteLine("Bonjour vous vous appelez " + nomDeLaPersonne + ", vous avez " + age_num + " ans.");

                int age_prochain = age_num + 1;
                Console.WriteLine("L'année prochaine vous aurez " + age_prochain + " ans.");

        }
    }
}

