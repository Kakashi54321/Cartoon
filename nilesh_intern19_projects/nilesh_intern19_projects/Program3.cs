using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3_Construct
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--------------------------------");
            Console.WriteLine("using CopyTo method");
            int[] arr1 = { 1, 2, 3, 4, 5 };
            int[] arr2 = new int[5];
            arr1.CopyTo(arr2, 0);
            for(int i = 0; i < arr2.Length; i++)
            {
                Console.WriteLine(arr2[i]);
            }
            Console.WriteLine("-----------------------------");
            string n = "Nilesh Prasad";
            char[] ch = new char[10];
            n.CopyTo(7, ch, 0, 6);
            Console.WriteLine(ch);
            Console.WriteLine("-----------------------------");
            string company = "42Gears";
            char[] name = {'N','i','l','e','s','h','P','r','a','s','a','d' };
            company.CopyTo(2, name, 6, 5);
            Console.WriteLine(name);
            Console.WriteLine("-----------------------------");



            Console.WriteLine("without using Copyto method");
            for(int i = 0; i < arr1.Length; i++)
            {
                arr2[i] = arr1[i];
            }
            for (int i = 0; i < arr2.Length; i++)
            {
                Console.WriteLine(arr2[i]);
            }
            Console.WriteLine("-----------------------------");



            Console.WriteLine("3*3 matrix");
            int[,] ar = new int[3, 3];
            for(int i = 0; i < 3; i++)
            {
                for(int j=0; j < 3; j++)
                {
                    ar[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            for(int i = 0; i < 3; i++)
            {
                for(int j = 0; j < 3; j++)
                {
                    Console.Write(" {0} ", ar[i, j]);
                }
                Console.WriteLine();
            }
            Console.WriteLine("-----------------------------");
            Console.WriteLine("Using REF keyword");
            string str1 = "Nilesh";
            string str2 = "Prasad";
            Console.WriteLine("Before swaping the values are:");
            Console.WriteLine("{0} {1}", str1, str2);
            toswap(ref str1, ref str2);
            Console.WriteLine("After swaping the values are:");
            Console.WriteLine("{0} {1}", str1, str2);
            Console.WriteLine("-----------------------------");

            Console.WriteLine("Using OUT keyword");
            int a = 5;
            int b = 10;
            add(a, b, out int c);
            int z = c * a;      //to show that the out variable can be used outside the function 
            Console.WriteLine(z);
            Console.ReadLine();
        }
        static void toswap(ref string str1, ref string str2)
        {
            string temp = str1;
            str1 = str2;
            str2 = temp;
        }

        static int add(int a, int b, out int c)
        {
            c = a + b;
            return c;
        }
    }
}
