﻿namespace IfElseOddNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sisesta number");
            //konsool k[sib numbrit ja siin muudetakse
            //see int andmetüübiks
            int number = int.Parse(Console.ReadLine());

            //teha if ja else-ga kontroll, 
            //kus saame teada, et kas nr
            //on paaris v]i paaritu
            //kasuta operaatoreid

            if (number %2 == 0)
            {
                Console.WriteLine("Sisestasid paaris arvu: " + number);
            }
            else
            {
                Console.WriteLine("Sisestasid paaritu arvu: " + number);
            }
        }
    }
}
