﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPsConcepts
{
    public class Constructor
    {
        public Constructor() 
        {
            Console.WriteLine("This is constructor");
        }
        public Constructor(string message)
        {
            Console.WriteLine(message);
        }
    }
}
