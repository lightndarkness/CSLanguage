using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuartoModulo
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 5;
            int b = 0;

            try
            {
                double risultato = Divisione(a, 1);
                Console.WriteLine(risultato);
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("Impossibile dividere un numero per zero");
                Console.WriteLine("Si è verificato un errore: " + ex.Message);
            }
            catch (FakeException ex)
            {

            }
            finally
            {
                Console.WriteLine("Sono all'interno del blocco FINALLY");
            }
            Console.ReadLine();
        }

        public static double Divisione(int x, int y)
        {
            
            if (y == 0)
            {
                throw new DivideByZeroException();
            }
            else if (y == 1)
            {
                throw new FakeException();
            }
            

            return x / y;
        }
    }
}
