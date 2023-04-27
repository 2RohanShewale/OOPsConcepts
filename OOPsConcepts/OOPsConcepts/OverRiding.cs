using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPsConcepts
{
    public class BaseClass
    {
        public virtual void PrintMessage()
        {
            Console.WriteLine("This method is in the base class.");
        }
    }
    public class DerivedClass: BaseClass 
    {
        public override void PrintMessage()
        {
            Console.WriteLine("This method is in derived class");
        }
    }
}
