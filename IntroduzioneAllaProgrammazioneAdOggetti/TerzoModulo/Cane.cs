using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TerzoModulo
{
    class Cane : Animale
    {
        public void Abbaia()
        {
            Console.WriteLine(nome + ": Bau Bau");
        }

        public override void FaiUnVerso()
        {
            Console.WriteLine("Verso della classe cane");
        }
    }
}
