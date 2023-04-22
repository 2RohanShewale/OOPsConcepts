using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPsConcepts
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ClassName name = new ClassName();
            name.PrintName();
            //To Hold the screen until the key is pressed
            Console.ReadKey();
        }
    }
}
