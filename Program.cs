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
            string numeroUm;
            string numeroDois;
            string operador;
            int total = 0;

            Regex rgx = new Regex(@"[\/\+\-\*]");
            Regex nRgx = new Regex(@"[0-9]");

            Console.WriteLine("Digite um número");
            numeroUm = Console.ReadLine();

            var isValidNumberOne = nRgx.IsMatch(numeroUm, 0);

            if (!isValidNumberOne)
            {
                while (isValidNumberOne == false)
                {
                    Console.WriteLine("Digite o número valido");
                    numeroUm = Console.ReadLine();
                    isValidNumberOne = nRgx.IsMatch(numeroUm, 0);

                }

            }

            Console.WriteLine("Digite o operador");
            operador = Console.ReadLine();

            var isValidOperator = rgx.IsMatch(operador, 0);


            if (!isValidOperator)
            {
                while (isValidOperator == false)
                {
                    Console.WriteLine("Digite o operador valido");
                    operador = Console.ReadLine();
                    isValidOperator = rgx.IsMatch(operador, 0);

                }

            }

            Console.WriteLine("Digite outro número");
            numeroDois = Console.ReadLine();

            var isValidNumberTwo = nRgx.IsMatch(numeroDois, 0);

            if (!isValidNumberTwo)
            {
                while (isValidNumberTwo == false)
                {
                    Console.WriteLine("Digite o número valido");
                    numeroDois = Console.ReadLine();
                    isValidNumberTwo = nRgx.IsMatch(numeroDois, 0);

                }

            }

            if (operador == "+")

            {
                total = Int32.Parse(numeroDois) + Int32.Parse(numeroUm);
            }

            if (operador == "/")
            {
                total = Int32.Parse(numeroDois) / Int32.Parse(numeroUm);
            }

            if (operador == "*")
            {
                total = Int32.Parse(numeroDois) * Int32.Parse(numeroUm);
            }

            if (operador == "-")
            {
                total = Int32.Parse(numeroDois) - Int32.Parse(numeroUm);
            }


            Console.WriteLine($" Resulta de {numeroUm} {operador} {numeroDois} é {total}");


        }
    }

}
