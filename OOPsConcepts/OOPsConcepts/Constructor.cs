using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPsConcepts
{
    public class Constructor:InterfaceDemo
    {
        public Constructor() 
        {
            Console.WriteLine("This is constructor");
        }
        public Constructor(string message)
        {
            Console.WriteLine(message);
        }

        public void WithoutImplementationMethod()
        {
            Console.WriteLine("This is Constructor.cs");
        }
    }
}
