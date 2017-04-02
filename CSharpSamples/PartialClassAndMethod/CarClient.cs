using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartialClassAndMethod
{
    public partial class Car
    {
        partial void OnSomethingHappened(String str)
        {
            Console.WriteLine("Something happened: {0}", str);
        }
    }
}
