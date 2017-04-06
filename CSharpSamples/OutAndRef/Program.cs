using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OutAndRef
{
    class Program
    {
        static void Main(string[] args)
        {
            int value = 01;
            Program p = new Program();
            //p.Convert(ref value);
            p.Convert(out value);

        }

        void Convert(out int value)
        {
            value = 20;/* Must be initialize */
        }
        /*
        void Convert(ref int value)
        {
            //value = 20;// Option
        }
        */
    }
}
