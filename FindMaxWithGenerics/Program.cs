using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindMaxWithGenerics
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Find Maximum using GENERICS program");

            Maximum maximum = new Maximum();
            Console.WriteLine("Choose the option below.....\n1. Find Max Of Three Int Number\n ");
            int option = Convert.ToInt32(Console.ReadLine());
            switch(option)
            {
                case 1:
                    Console.WriteLine("Enter first integer");
                    int intNum1 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter second integer");
                    int intNum2 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter third integer");
                    int intNum3 = Convert.ToInt32(Console.ReadLine());
                    int intMax = maximum.MaxOutOfThree(intNum1, intNum2, intNum3);
                    if(intMax==0)
                    {
                        Console.WriteLine("Two or Three numbers have equal value");
                    }
                    else
                        Console.WriteLine("Maximum out of given numbers {0} {1} & {2} is {3}",intNum1,intNum2,intNum3,intMax);
                    break;
                default:
                    Console.WriteLine("Invalid Input");
                    break;
            }
            Console.ReadLine();
        }
    }
}
