using System;

namespace opdrachtweek03
{
    class Program
    {
        static void Main(string[] args)
        {
            // Oplossing 1: 
            Console.WriteLine("Van welk getal wil je vermenigvuldigingstafel?");
            int getal = Convert.ToInt32(Console.ReadLine());
            int[] resultaten = new int[11];
            for (int i = 0 ; i < 11 ; i++)
            {
                int resultaat = i * getal;
                Console.WriteLine("{0} x {1} = {2}", i, getal, resultaat);
                resultaten[i] = resultaat;
            }

            Console.WriteLine("Resultaten overlopen, eerste loop...");
            foreach (var item in resultaten)
            {
                Console.WriteLine("{0}", item);
            }
            Console.WriteLine("Resultaten overlopen, tweede loop...");
            for (int i = 0; i < resultaten.Length; i++)
            {
                Console.WriteLine("{0}", resultaten[i]);
            }


            //vraagGetal()
            // datacollectie 1
            // datacollectie 2
            // datacollectie 3
            //maakVermenigvuldigingstafel(getal)
            //

            
        }
    }
}
