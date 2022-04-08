using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindMaxWithGenerics
{
    //Using generic class to find Max out of three values(instead of T can use Any uppercase)
    class Maximum<T> where T : IComparable
    {
        public T first, second, third;
        public Maximum(T first, T second, T third)
        {
            this.first = first;
            this.second = second;
            this.third = third;
        }
        public static T MaxOutOfThree(T first, T second, T third) 
        {
            if (first.CompareTo(second) > 0 && first.CompareTo(third) > 0)
            {
                return first;
            }
            else if (second.CompareTo(first) > 0 && second.CompareTo(third) > 0)
            {
                return second;
            }
            else if (third.CompareTo(first) > 0 && third.CompareTo(second) > 0)
            {
                return third;
            }
            else
            {
                return default;
            }
        }
        public T GetMax()
        {
            T maxValue = Maximum<T>.MaxOutOfThree(this.first, this.second, this.third);
            return maxValue;
        }
    }
}
