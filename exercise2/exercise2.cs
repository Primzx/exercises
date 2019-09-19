using System;

namespace Summan_av_två_tal
{
    class Program
    {
        static void Main(string[] args)
        {
           /* Skapa ett program där man matar in två tal, sedan lägger
            programmet ihop dessa tal.  */

            int tal1, tal2; //deklarerar variabler
            int summa;

            Console.WriteLine("Mata in två tal"); //Skriver ut till konsol
            tal1 = Convert.ToInt32(Console.ReadLine()); //konverterar inmatning från användaren till int
            tal2 = Convert.ToInt32(Console.ReadLine());
            summa = (tal1 +tal2); //uträckning
            Console.WriteLine("Summan av " + tal1 + " + " + tal2 + " är " + summa); //utskrift till konsol
        }
    }
}
