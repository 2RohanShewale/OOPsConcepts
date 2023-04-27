using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPsConcepts
{
    public class ReferenceType
    {
        public void ReferenceTypeMethod(ref int num)
        {
            num = num * num;
            Console.WriteLine(num);
        }
    }
}
