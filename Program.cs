// See https://aka.ms/new-console-template for more information
using System;

namespace premier_programme
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write(  "Quel est ton nom? ");
            string nomDeLaPersonne = Console.ReadLine();

            Console.Write(  "Quek est votre age? ");
            string ageDeLaPersonne = Console.ReadLine();
            Console.WriteLine("Bonjour vous vous appelez " + nomDeLaPersonne + ", vous avez " + ageDeLaPersonne + " ans.");
        }
    }
}

