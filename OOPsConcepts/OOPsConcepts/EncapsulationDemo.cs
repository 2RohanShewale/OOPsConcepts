using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace OOPsConcepts
{
    public class EncapsulationDemo
    {
        private string name;
        private int rollNo;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public int RollNo { get; set; }
    }
}
