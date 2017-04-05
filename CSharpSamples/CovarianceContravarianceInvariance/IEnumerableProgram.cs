using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CovarianceContravarianceInvariance
{
    public class Iterator1
    {
        static void MainIterator1()
        {
            foreach (int number in SomeNumbers())
            {
                Console.Write(number.ToString() + " ");
            }
            // Output: 3 5 8
            Console.ReadKey();
        }

        public static System.Collections.IEnumerable SomeNumbers()
        {
            yield return 3;
            yield return 5;
            yield return 8;
        }
    }

    public class Iterator2
    {
        static void MainIterator2()
        {
            foreach (int number in EvenSequence(5, 18))
            {
                Console.Write(number.ToString() + " ");
            }
            // Output: 6 8 10 12 14 16 18
            Console.ReadKey();
        }

        public static System.Collections.Generic.IEnumerable<int>
            EvenSequence(int firstNumber, int lastNumber)
        {
            // Yield even numbers in the range. 
            for (int number = firstNumber; number <= lastNumber; number++)
            {
                if (number % 2 == 0)
                {
                    yield return number;
                }
            }
        }
    }

    public class Iterator3
    {
        static void MainIterator3()
        {
            DaysOfTheWeek days = new DaysOfTheWeek();

            foreach (string day in days)
            {
                Console.Write(day + " ");
            }
            // Output: Sun Mon Tue Wed Thu Fri Sat
            Console.ReadKey();
        }

        public class DaysOfTheWeek : IEnumerable
        {
            private string[] days = { "Sun", "Mon", "Tue", "Wed", "Thu", "Fri", "Sat" };

            public IEnumerator GetEnumerator()
            {
                for (int index = 0; index < days.Length; index++)
                {
                    // Yield each day of the week. 
                    yield return days[index];
                }
            }
        }
    }
}
