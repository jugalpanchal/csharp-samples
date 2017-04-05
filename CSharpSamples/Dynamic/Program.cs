using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dynamic
{
    class ProgramDynamic
    {
        #region Methods

        static void Main(string[] args)
        {
            dynamic dyn = 1;
            object obj = 1;

            dyn = dyn + 3;
            //obj = obj + 3;

            // Rest the mouse pointer over dyn and obj to see their 
            // types at compile time.
            System.Console.WriteLine(dyn.GetType());
            System.Console.WriteLine(obj.GetType());


            ExampleClass ec = new ExampleClass();
            Console.WriteLine(ec.exampleMethod(10));
            Console.WriteLine(ec.exampleMethod("value"));

            // The following line causes a compiler error because exampleMethod 
            // takes only one argument. 
            //Console.WriteLine(ec.exampleMethod(10, 4));

            dynamic dynamic_ec = new ExampleClass();
            Console.WriteLine(dynamic_ec.exampleMethod(10));

            // Because dynamic_ec is dynamic, the following call to exampleMethod 
            // with two arguments does not produce an error at compile time. 
            // However, it does cause a run-time error.  
            Console.WriteLine(dynamic_ec.exampleMethod(10, 4));
        }

        #endregion Methods
    }

    class ExampleClass
    {
        static dynamic field;
        dynamic prop { get; set; }

        public dynamic exampleMethod(dynamic d)
        {
            dynamic local = "Local variable";
            int two = 2;

            if (d is int)
            {
                return local;
            }
            else
            {
                return two;
            }
        }
    }
}
