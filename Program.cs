// See https://aka.ms/new-console-template for more information
using System;

namespace premier_programme
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Quel est ton nom? ");
            string nomDeLaPersonne = Console.ReadLine();

            Console.Write(  "Quek est votre age? ");
            string ageDeLaPersonne = Console.ReadLine();
            int age_num = 0;
            try 
            {
            age_num= int.Parse(ageDeLaPersonne);
                
            Console.WriteLine("Bonjour vous vous appelez " + nomDeLaPersonne + ", vous avez " + age_num + " ans.");

            int age_prochain= age_num + 1;
            Console.WriteLine("L'année prochaine vous aurez " + age_prochain + " ans.");
            }
            catch
            {
                Console.WriteLine("Erreur, vous devez rentrer un age valide");
            }
        }
    }
}

