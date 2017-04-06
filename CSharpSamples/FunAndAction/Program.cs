using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunAndAction
{

    public class FunClassTest
    {
        public FunClassTest(Func<Car> carFun) /* First is return */
        {
            var car = carFun();
        }

        public FunClassTest(Func<int, Car> carFun) /* Last is return */
        {
            var car = carFun(10);
        }

        public FunClassTest(Func<int, DateTime, Car> carFun) /* Last is return */
        {
            var car = carFun(10, DateTime.Now);
        }
    }

    public class ActionClassTest
    {
        public ActionClassTest(Action carFun)
        {
            carFun();
        }

        public ActionClassTest(Action<int> carFun)
        {
            carFun(10);
        }

        public ActionClassTest(Action<int, DateTime> carFun)
        {
            carFun(10, DateTime.Now);
        }
    }

    public class HelperMethod
    {
        static void Main(string[] args)//MainHelperMethod //Main
        {
            HelperMethod hm = new HelperMethod();
            hm.FunTest();
            hm.ActionTest();
        }

        #region Fun Delegate

        void FunTest()
        {
            /* It can be passed to any function and constructor. */
            var l11 = new FunClassTest(() => new Car());
            var l12 = new FunClassTest(() => this.FunTestH());

            //var l13 = new FunClassTest(this.FunTestH);/* It gives error. The call is ambiguous between the methods, because multiple overload.*/
            var l14 = new FunClassTest(this.FunTestH1);/* It works, because no overload is there.*/

            var l3 = new FunClassTest((id) => new Car());
            var l4 = new FunClassTest((id) => this.FunTestH(id));

            var l5 = new FunClassTest((id, dt) => new Car());
            var l6 = new FunClassTest((id, dt) => this.FunTestH(id, dt));
        }

        Car FunTestH()
        {
            return new Car();
        }

        Car FunTestH1(int id)
        {
            return new Car();
        }

        Car FunTestH(int id)
        {
            return new Car();/* Use id */
        }

        Car FunTestH(int id, DateTime dt)
        {
            return new Car();/* Use id and dt */
        }

        #endregion

        #region Action Delegate

        public void ActionTest()
        {
            /* It can be passed to any function and constructor. */
            var l1 = new ActionClassTest(() => new Car());
            var l2 = new ActionClassTest(() => this.ActionTestH());

            var l3 = new ActionClassTest((id) => new Car());
            var l4 = new ActionClassTest((id) => this.ActionTestH(id));

            var l5 = new ActionClassTest((id, dt) => new Car());
            var l6 = new ActionClassTest((id, dt) => this.ActionTestH(id, dt));
        }

        void ActionTestH()
        {
        }

        void ActionTestH(int id)
        {
            var car = new Car();/* Use id */
        }

        void ActionTestH(int id, DateTime dt)
        {
            var car = new Car();/* Use id and dt */
        }
        #endregion Methods
    }
}
