using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPsConcepts
{
    public class ValueType
    {
        /*In value type is further classified into two type
         * a)Built in types: int, long, float, byte, decimal, short
         * b)User-defined: strut, enum
         * It will store in a stack memory
        */
        public void ValueTypeMethod()
        {
            //num_one and num_two are the value type
            int num_one = 123;
            int num_two = num_one;
            num_two++;
            Console.WriteLine(num_one);
            Console.WriteLine(num_two);
        }
    }
}
