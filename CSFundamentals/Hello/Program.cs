using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hello
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = args[0];
            
            DateTime now = DateTime.Now;
            Console.WriteLine("Hello, " + name + "!");
            Console.WriteLine(now);
        }
    }
}
