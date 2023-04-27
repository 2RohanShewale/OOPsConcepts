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
            name.WithoutImplementationMethod();
            Constructor constructor = new Constructor("This is Parameterized Construction");
            name.PrintName();
            name.PrintMessage("This is a parameterized method"); 

            //To Hold the screen until the key is pressed
            Console.ReadKey();
        }
    }
}
