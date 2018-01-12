using System;

namespace opdracht2._1
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = GeefGetal();
            if (number < 100)
            {
                for (int i = 0; i < (number+1); i++)
                {
                    Console.WriteLine(i + IsPrime(i));
                }
            } 
            else
            {
                Console.WriteLine("Het getal is groter dan 100, foei!");
            }

        }


        static int GeefGetal()
        {
            Console.WriteLine("Geef een geheel getal in (max tot 100)");
            int getal = Convert.ToInt32(Console.ReadLine());
            return getal;
        }

        static string IsPrime(int getal)
        {
            int tllr = 0;
            for (int i = 1; i < (getal+1); i++)
            {
                if((getal%i) == 0) 
                {
                  
                    tllr++;
                }
            }
            
            if(tllr == 2)
            {
                return " is een priemgetal";
            }
            else
            {
                return " is geen priemgetal";
            }
        }
    }

}
