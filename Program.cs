using System;
using System.Text.RegularExpressions;

// calculadora com c#
// primeiro programa

namespace Cursocsharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }
        public static void Menu()
        {
            Console.WriteLine("---------CALCULADORA--------------");
            Console.WriteLine("Digite uma opção");
            Console.WriteLine("1 - Soma");
            Console.WriteLine("2 - Divisão");
            Console.WriteLine("3 - subtração  ");
            Console.WriteLine("4 - multiplicação  ");
            Console.WriteLine("5 - Sair  ");
            Console.WriteLine("---------------------------");

            string action = Console.ReadLine();

            switch (action)
            {
                case "1":
                    Operation("1");
                    break;
                case "2":
                    Operation("2");
                    break;
                case "3":
                    Operation("3");
                    break;
                case "4":
                    Operation("4");
                    break;
                case "5":
                    System.Environment.Exit(0);
                    break;

                default: break;
            }
        }

        public static void Operation(string opr)
        {
            Regex nRgx = new Regex(@"[0-9]");
            Console.WriteLine("Digite um numero");
            string n1 = Console.ReadLine();


            var isValidNumberone = nRgx.IsMatch(n1, 0);


            if (!isValidNumberone)
            {
                while (isValidNumberone == false)
                {
                    Console.WriteLine("Digite o número valido");
                    n1 = Console.ReadLine();
                    isValidNumberone = nRgx.IsMatch(n1, 0);

                }

            }

            Console.WriteLine("Digite outro número");
            string n2 = Console.ReadLine();


            var isValidNumberTwo = nRgx.IsMatch(n2, 0);

            if (!isValidNumberTwo)
            {
                while (isValidNumberTwo == false)
                {
                    Console.WriteLine("Digite o número valido");
                    n2 = Console.ReadLine();
                    isValidNumberTwo = nRgx.IsMatch(n2, 0);

                }

            }
            int total = 0;
            switch (opr)
            {
                case "1":
                    total = Int32.Parse(n1) + Int32.Parse(n2);
                    break;
                case "2":
                    total = Int32.Parse(n1) / Int32.Parse(n2);
                    break;
                case "3":
                    total = Int32.Parse(n1) - Int32.Parse(n2);
                    break;
                case "4":
                    total = Int32.Parse(n1) * Int32.Parse(n2);
                    break;
                default: break;
            }


            Console.WriteLine($" Resulta é {total}");
            Menu();

        }



    }

}
