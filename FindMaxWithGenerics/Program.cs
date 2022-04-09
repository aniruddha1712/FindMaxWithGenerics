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

            Console.WriteLine("Choose the option below.....\n1. Find Max Of given Int Number\n2. Find Max of given Float values" +
                "\n3. Find Max Of given Strings\n4. Exit\n");
            int option = Convert.ToInt32(Console.ReadLine());
            switch(option)
            {
                case 1:
                    int[] intArray = new int[4];
                    Console.WriteLine("Enter first integer");
                    intArray[0] = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter second integer");
                    intArray[1] = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter third integer");
                    intArray[2] = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter fourth integer");
                    intArray[3] = Convert.ToInt32(Console.ReadLine());
                    Maximum<int> intMax = new Maximum<int>(intArray);
                    intMax.PrintMax();
                    break;
                case 2:
                    float[] floatArray = new float[4];
                    Console.WriteLine("Enter first Float value");
                    floatArray[0]  = float.Parse(Console.ReadLine());
                    Console.WriteLine("Enter second Float value");
                    floatArray[1]  = float.Parse(Console.ReadLine());
                    Console.WriteLine("Enter third Float value");
                    floatArray[2]  = float.Parse(Console.ReadLine());
                    Console.WriteLine("Enter fourth Float value");
                    floatArray[3]  = float.Parse(Console.ReadLine());
                    Maximum<float> floatMax = new Maximum<float>(floatArray);
                    floatMax.PrintMax();
                    break;
                case 3:
                    string[] strArray = new string[4];
                    Console.WriteLine("Enter first string");
                    strArray[0] = Console.ReadLine();
                    Console.WriteLine("Enter second string");
                    strArray[1] = Console.ReadLine();
                    Console.WriteLine("Enter third string");
                    strArray[2] = Console.ReadLine();
                    Console.WriteLine("Enter third string");
                    strArray[3] = Console.ReadLine();
                    Maximum<string> stringMax = new Maximum<string>(strArray);
                    stringMax.PrintMax();
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
