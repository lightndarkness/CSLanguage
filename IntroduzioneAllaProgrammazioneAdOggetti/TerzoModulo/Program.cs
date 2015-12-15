using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TerzoModulo
{
    class Program
    {
        static void Main(string[] args)
        {
            Animale a = new Animale("Max");

            a.VisualizzaNome();

            Cane c = new Cane();
            c.Abbaia();

            Animale secondo = new Cane();
            secondo.FaiUnVerso();
        }
    }
}
