using System;
using System.Globalization;

namespace NextBusinessDay
{
        public class Program
        {
            public static void Main(string[] args)
            {

                Console.WriteLine("__________________________________________________________________________");
                Console.WriteLine("---------------- Console Application - Next business day  ----------------");
                Console.WriteLine("__________________________________________________________________________");

                string myChoice;
                do
                {
                    Console.WriteLine();
                    Console.WriteLine("Enter a date and location - Ex: EUA = MM/DD/YYYY en | BRAZIL = DD/MM/YYYY pt ");
                    Console.Write(">>> ");

                    string[] valores = Console.ReadLine().Split(' ');

                    String dt = valores[0];
                    var cultureInfo = new CultureInfo(valores[1]);

                    DateTime date = DateTime.Parse(dt, cultureInfo);
                    Console.WriteLine();

                    NextDay.GetAddDays(date);

                    Console.WriteLine("____________________________________________");
                    Console.Write("Press any key to continue | <N> To Exit >>> ");
                    myChoice = Console.ReadLine();
                    Console.Clear();
                } while (myChoice != "N" && myChoice != "n");
            }

        }
    }
