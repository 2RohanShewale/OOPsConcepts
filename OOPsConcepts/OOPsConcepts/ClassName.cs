using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPsConcepts
{
    public class ClassName:InterfaceDemo
    {

        public void PrintName()
        {
            Console.WriteLine("Rohan Shewale");
        }
        public void PrintMessage(string message)
        {
            Console.WriteLine(message);
        }

        public void WithoutImplementationMethod()
        {
            Console.WriteLine("This is ClassName.cs");
        }
    }
}
