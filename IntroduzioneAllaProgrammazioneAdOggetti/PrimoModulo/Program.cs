using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimoModulo
{
    class Program
    {
        static void Main(string[] args)
        {
            string nomeCorso = "Corso di programmazione ad oggetti";
            Console.WriteLine(nomeCorso);

            int x = 1;
            int y = 2;
            string s = "3";

            //int somma = x + y;

            //Console.WriteLine(somma);
            Console.WriteLine(x + y);
            Console.WriteLine(s + x); // ToString chiamato automaticamente
            Console.ReadLine();
        }
    }
}
