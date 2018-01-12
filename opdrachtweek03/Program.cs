using System;
using System.Collections.Generic;
using System.Collections;



namespace opdrachtweek03
{
    class Program
    {
        static void Main(string[] args)
        {
            
            //Ask for a number
            Console.WriteLine("Give in a number:");
            int getal = Convert.ToInt32((Console.ReadLine()));
            // writing
            Console.WriteLine("Vermenigvuldigingsfacotr: {0}", getal);
            //create array with 11 places
            int[] a = new int[11];
           
           
            //create new list
             List <int> lijst = new List <int>();

            //create new hashtable
            Hashtable tafels = new Hashtable();
                    

            //loop
            for (int i = 0; i < 11; i++){
                
                a[i]= getal*i;
            
	            lijst.Add(i*getal);

  
               tafels.Add(i,i*getal);
	
            }
            Console.WriteLine("Array");
            //write more stuff
            int teller = 0;
            foreach(int j in a){
                Console.WriteLine("{0}x{1}={2}",teller, getal, j);
                teller++;
            }

            Console.WriteLine("List");
            //write a list
            teller = 0;
            foreach(int j in lijst){
                Console.WriteLine("{0}x{1}={2}",teller, getal, j);
                teller++;
            }

            Console.WriteLine("Hashtable");
            //more hashtables
            for(int i=0; i<11; i++){
                Console.WriteLine("{0}x{1}={2}",i, getal, tafels[i]);
            }
          
        }
    }
}