using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestHello
{
    class Program
    {
        enum Error { DEFAULT, STRINGA, ZERO };

        static void Main(string[] args)
        {
            Console.WriteLine("        Option Chooser        \n\n");

            char userAnswer;
            
            do
            {
                int max = 0;
                do
                {
                    Error error = Error.DEFAULT;
                    
                    Console.WriteLine("Quante opzioni hai?");
                    try
                    {
                        max = Convert.ToInt32(Console.ReadLine());
                        if (max == 0)
                        {
                            error = Error.ZERO;
                        }
                    }
                    catch (FormatException fe)
                    {
                        Console.WriteLine(fe.Message);
                        error = Error.STRINGA;
                    }
                    switch (error)
                    {
                        case Error.STRINGA:
                            Console.WriteLine("Devi inserire un numero!");
                            break;
                        case Error.ZERO:
                            Console.WriteLine("Non è possibile avere 0 opzioni.");
                            break;
                        case Error.DEFAULT:
                        default:
                            break;
                    }
                } while (max == 0);

                Console.WriteLine("Hai " + max + " opzioni.");
                Random random = new Random();

                int opzione = random.Next(1, max + 1);

                Console.WriteLine("L'opzione scelta è la " + opzione + ".");
                Console.WriteLine("Vuoi generare un'altra opzione? (y/n)");
                userAnswer = Convert.ToChar(Console.ReadLine());
            } while (userAnswer == 'y' || userAnswer == 'Y');

            Console.ReadLine();
        }
    }
}
