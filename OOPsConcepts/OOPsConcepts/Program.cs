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
            /*ClassName name = new ClassName();
            name.WithoutImplementationMethod();
            Constructor constructor = new Constructor("This is Parameterized Construction");
            name.PrintName();
            name.PrintMessage("This is a parameterized method");

            //Inhetitence
            ChildClass childClass = new ChildClass();
            ParentClass childParent = new ChildClass();
            childClass.PrintMessage();
            childParent.PrintMessage();

            //ValueType
            ValueType valueType = new ValueType();
            valueType.ValueTypeMethod();

            //Reference Type
            ReferenceType type = new ReferenceType();
            int value = 5;
            type.ReferenceTypeMethod(ref value);
            Console.WriteLine(value);

            EncapsulationDemo encapsulation = new EncapsulationDemo();
            encapsulation.Name = "Test";
            Console.WriteLine(encapsulation.Name);
            encapsulation.Name = "Changed Name";
            Console.WriteLine(encapsulation.Name);
            encapsulation.RollNo = 45;
            Console.WriteLine(encapsulation.RollNo);

            OverLoading obj = new OverLoading();
            obj.MethodOne();
            obj.MethodOne(4);
            obj.MethodOne(4, "Four");
            */

            DerivedClass obj_one = new DerivedClass();
            obj_one.PrintMessage();
            BaseClass obj_two = new DerivedClass();
            obj_two.PrintMessage();


            //To Hold the screen until the key is pressed
            Console.ReadKey();
        }
    }
}
