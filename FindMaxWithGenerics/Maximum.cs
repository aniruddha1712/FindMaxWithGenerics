using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindMaxWithGenerics
{
    class Maximum<T> where T : IComparable
    {
        public T[] values;

        public Maximum(T[] values)        //Constructor
        {
            this.values = values;
        }

        public T[] ArraySort()
        {
            Array.Sort(values);
            return values;
        }

        public T GetMaxOfGiven(T[] genValue)
        {
            ArraySort();
            int lastIndex = values.Length - 1;
            return values[lastIndex];
        }
        public T GetMax()
        {
            T maxValue = GetMaxOfGiven(this.values);
            return maxValue;
        }
        public void PrintMax()
        {
            T maxValue = GetMaxOfGiven(this.values);
            Console.WriteLine("Maximum value is : " + maxValue);
        }
    }
}
