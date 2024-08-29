using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppEvenAndOddNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj liczbę:");

            while (true)
            {
                var number = GetNumber();
                CheckNumber(number);
                Console.WriteLine();

                Console.WriteLine("Jeżeli chcesz podaj kolejną liczbę. Jeśli chcesz zakończyć kliknij 'q'.");

            }


            Console.WriteLine();
        }


        static int GetNumber()
        {
            while (true)
            {
                var number = Console.ReadLine();
                if (number.ToLower() == "q")
                    Environment.Exit(0);

                if (!int.TryParse(number, out int result))
                {
                    Console.WriteLine("Podałeś nieprawidłową wartość! Wpisz liczbę:");
                    continue;
                }
                else
                    return result;
            }
        }

        static void CheckNumber(int number)
        {

            if (number % 2 == 0)
                Console.WriteLine("Podałeś liczbę parzystą.");
            else
                Console.WriteLine("Podałeś liczbę nieparzystą.");

        }

    }
}
