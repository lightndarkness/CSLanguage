using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecondoModulo
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 1;
            int y = 5;

            Console.WriteLine("Inserisci un numero: ");
            string s = Console.ReadLine();

            if (s == "5")
            {
                Console.WriteLine("Sono all'interno del blocco IF");
            }
            else if (s == "2")
            {
                Console.WriteLine("Sono all'interno di un blocco ELSE-IF");
            }
            else
            {
                Console.WriteLine("Sono all'interno di un blocco ELSE");
            }

            if (x < y)
            {
                Console.WriteLine("x è minore di y");
            }
            else
            {
                Console.WriteLine("x è maggiore di y");
            }

            while (x < y)
            {
                Console.WriteLine(x);
                x++;
            }

            for (int i = 0; i < y; i++)
            {
                Console.WriteLine(i);

                switch (i)
                {
                    case 1:
                        Console.WriteLine("Uno");
                        break;
                    case 2:
                        Console.WriteLine("Due");
                        break;
                    case 3:
                        Console.WriteLine("Tre");
                        break;
                    case 4:
                        Console.WriteLine("Quattro");
                        break;
                    case 5:
                        Console.WriteLine("Cinque"); // Non eseguito xchè i non sarà mai uguale a 5
                        break;
                    default:
                        break;
                }
            }

            x = 0;

            do
            {
                Console.WriteLine(x);
                x++;
            } while (x < y);
            Console.ReadLine();
        }
    }
}
