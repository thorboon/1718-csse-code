using System;

namespace opdracht2._2
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = GeefGetal();
            Fibo(number);


        }

        static int GeefGetal()
        {
            Console.WriteLine("Geef een geheel getal in: ");
            int getal = Convert.ToInt32(Console.ReadLine());
            return getal;

        }

        static void Fibo(int number)
        {
            int[] a = new int[number];
            a[0] = 0;
            a[1] = 1;
            for (int i = 2; i < a.Length ; i++)
            {
                a[i]= a[i-1] + a[i-2];
            }
            int teller = 0;

            foreach(var j in a)
            {
                Console.WriteLine(a[teller]);
                teller++;
            }

        }

    }
}
