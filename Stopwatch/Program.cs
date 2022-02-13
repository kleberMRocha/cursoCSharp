using System;

namespace Stopwatch
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("----------- ⏲ Cronometro ---------------------");
            Console.WriteLine("\r\n Por favor, digite os segundos a serem contados \r\n");
            Console.WriteLine("-----------------------------------------------");
            string timeInput = Console.ReadLine();
            int time = Int32.Parse(timeInput);

            Start(time);
        }
        public static void Start(int time)
        {
            for (int i = 1; i <= time; i++)
            {
                System.Threading.Thread.Sleep(1000);
                Console.WriteLine($"{i} seg");
            }

            Console.WriteLine("Fim !");

        }
    }
}
