using System;
namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, j;
            for (i = 2; i <= 100; i++) {
                for(j=2; j<=i; j++)
                {
                    if (i % j == 0)
                        break;
                    else if(i==j+1)
                        Console.WriteLine(i);
                }
            }
            Console.ReadLine();

        }
    }
}


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] testArray = { "13", "17", "22", "3467", null, "notNumber", "55" };
            foreach(var s in testArray)
            {
                int n;
                bool res = Int32.TryParse(s, out n);

                if (res)
                {
                    bool flag = false;
                    for (int i = 2; i <= n / 2; i++)
                    {
                        if (n % i == 0)
                        {
                            flag = false;
                            break;
                        }
                        else
                            flag = true;
                    }
                    if (flag)
                        System.Console.WriteLine(n);
                }
                
            }
            System.Console.ReadLine();
        }
    }
}