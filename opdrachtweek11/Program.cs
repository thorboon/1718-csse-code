using System;
using System.Threading;

delegate void NumberReached(int threadNr);

namespace opdrachtweek11
{
    class Program
    {
        event NumberReached nrEvent;

        public Program()
        {
            this.nrEvent += new NumberReached(printMessage);

        }

        static void Main(string[] args)
        {
            Program p1 = new Program();

            int maxVal = getMaxValInput();
            
            //Thread 1
            Thread thread1 = new Thread(() => thread1UserInput(maxVal, p1));
            thread1.Start();

            //Thread 2
            Thread thread2 = new Thread(() => thread2LoopIncrement(maxVal, p1));
            thread2.Start();

            //Thread 3
            Thread thread3 = new Thread(() => thread3Random(maxVal, p1));
            thread3.Start();
        }

        public static int getMaxValInput(){
            Console.WriteLine("Please enter a maximum value");
            int val = Int32.Parse(Console.ReadLine());
            Console.WriteLine("maximum value set to {0}", val);
            return(val);
        }

        public static void thread1UserInput(int maxVal, Program p1){
            Console.WriteLine("Thread 1 started");
            Console.WriteLine("Please enter the maximum value");

            int enteredVal = Int32.Parse(Console.ReadLine());

            do {
                Console.WriteLine("incorrect maximum value entered");
                enteredVal = Int32.Parse(Console.ReadLine());
            } while (enteredVal != maxVal);

            p1.nrEvent(1);

        }

        public static void thread2LoopIncrement(int maxVal, Program p1){
            Console.WriteLine("Thread 2 started");
            for (int i = 0; i <= maxVal; i++)
            {
                Console.WriteLine("the number is {0}", i);
                if(i == maxVal){
                    p1.nrEvent(2);
                }
            }
        }

        public static void thread3Random(int maxVal, Program p1){
            Console.WriteLine("Thread 3 started");
            Random rnd = new Random();
            int randomVal = rnd.Next(maxVal - 10, maxVal + 10);

            do {
                
                randomVal = rnd.Next(maxVal - 10, maxVal + 10);
            } while (randomVal != maxVal);

            p1.nrEvent(3);
        }


        public static void printMessage(int a)
        {
            Console.WriteLine("Thread {0} finished", a);
        }

    }
}
