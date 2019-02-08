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
