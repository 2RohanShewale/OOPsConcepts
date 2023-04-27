using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPsConcepts
{
    public class ParentClass
    {
        public void PrintMessage()
        {
            Console.WriteLine("This is from parent class");
        }
    }
    public class ChildClass: ParentClass 
    { 
        public void PrintMessage()
        {
            Console.WriteLine("This is from child Class");
        }
    }
}
