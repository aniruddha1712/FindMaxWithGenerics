﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindMaxWithGenerics
{
    class Maximum
    {
        public int MaxOutOfThree(int num1, int num2, int num3)
        {
            if (num1.CompareTo(num2) > 0 && num1.CompareTo(num3) > 0)
            {
                return num1;
            }
            else if (num2.CompareTo(num1) > 0 && num2.CompareTo(num3) > 0)
            {
                return num2;
            }
            else if (num3.CompareTo(num1) > 0 && num3.CompareTo(num2) > 0)
            {
                return num3;
            }
            else
            {
                return 0;
            }
        }
        public float MaxOutOfThree(float num1, float num2, float num3)
        {
            if (num1.CompareTo(num2) > 0 && num1.CompareTo(num3) > 0)
            {
                return num1;
            }
            else if (num2.CompareTo(num1) > 0 && num2.CompareTo(num3) > 0)
            {
                return num2;
            }
            else if (num3.CompareTo(num1) > 0 && num3.CompareTo(num2) > 0)
            {
                return num3;
            }
            else
            {
                return 0;
            }
        }
    }
}
