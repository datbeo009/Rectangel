using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 10;
            int m = 20;
            char inside = '#';
            char outside = '^';
            for(int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    if (i % (n - 1) ==0|| i % (n-1)!=0 && j%(m-1)==0)
                    {
                        Console.Write(outside);
                    }
                    else
                    {
                        Console.Write(inside);
                    }
                }
                Console.WriteLine();
            }
            Console.ReadKey();


        }
    }
}





