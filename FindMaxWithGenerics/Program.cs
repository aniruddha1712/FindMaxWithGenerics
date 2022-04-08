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
            Console.WriteLine("Welcome to the Find Maximum using GENERICS program\n");

            Console.WriteLine("Choose the option below.....\n1. Find Max Of Three Int Number\n2. Find Max of Three Float values" +
                "\n3. Find Max Of Three Strings\n4. Exit\n");
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
                    Console.WriteLine("Enter fourth integer");
                    int intNum4 = Convert.ToInt32(Console.ReadLine());
                    int[] intArray = { intNum1, intNum2, intNum3, intNum4 };
                    int intMax = new Maximum<int>(intArray).GetMax();
                    if (intMax == 0)
                    {
                        Console.WriteLine("Two or more integers have equal value");
                    }
                    else
                        Console.WriteLine("Maximum out of given integers: " + intMax);
                    break;
                case 2:
                    Console.WriteLine("Enter first Float value");
                    float floatNum1 = float.Parse(Console.ReadLine());
                    Console.WriteLine("Enter second Float value");
                    float floatNum2 = float.Parse(Console.ReadLine());
                    Console.WriteLine("Enter third Float value");
                    float floatNum3 = float.Parse(Console.ReadLine());
                    Console.WriteLine("Enter fourth Float value");
                    float floatNum4 = float.Parse(Console.ReadLine());
                    float[] floatArray = { floatNum1, floatNum2, floatNum3, floatNum4 };
                    float floatMax = new Maximum<float>(floatArray).GetMax();
                    if (floatMax == 0)
                    {
                        Console.WriteLine("Two or more floats have equal value");
                    }
                    else
                        Console.WriteLine("Maximum out of given floats: " + floatMax);
                    break;
                case 3:
                    Console.WriteLine("Enter first string");
                    string str1 = Console.ReadLine();
                    Console.WriteLine("Enter second string");
                    string str2 = Console.ReadLine();
                    Console.WriteLine("Enter third string");
                    string str3 = Console.ReadLine();
                    Console.WriteLine("Enter third string");
                    string str4 = Console.ReadLine();
                    string[] strArray = { str1, str2, str3, str4 };
                    string strMax = new Maximum<string>(strArray).GetMax();
                    if (strMax == null)
                    {
                        Console.WriteLine("Two or more strings are same");
                    }
                    else
                        Console.WriteLine("Maximum out of given strings: " + strMax);
                    break;
                case 4:
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Invalid Input");
                    break;
            }
            Console.ReadLine();
        }
    }
}
