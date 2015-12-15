using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TerzoModulo
{
    class Animale
    {
        protected string nome = "Rocky";

        public Animale() { }

        public Animale(string n)
        {
            nome = n;
        }

        public void VisualizzaNome()
        {
            Console.WriteLine(nome);
        }

        public virtual void FaiUnVerso()
        {
            Console.WriteLine("Verso della classe Animale");
        }
    }
}
