using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPsConcepts
{
    public class OverLoading
    {
        public void MethodOne()
        {
            Console.WriteLine("This is first Mehtod");
        }
        public void MethodOne(int num)
        {
            Console.WriteLine("This is second Method");
        }
        public void MethodOne(int num, string name)
        {
            Console.WriteLine("This is third Method");
        }
    }
}
