using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pattern_problems
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            for (int i  = 1; i <=4; i ++) 
            {
                for (int j = 1; j <=4 - i ; j++)
                {
                    Console.Write(" ");
                }
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
             
            for(int i = 1; i<=4 ; i ++)
            {
                for(int j = 1;j <=i ; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

            int n = 4;
            int m = 5;

            //outer loop 
            for(int i = 1; i<=n ;i++)
            {
                //inner loop
                for( int j = 1; j<=m ; j++)
                {
                    //cell i,j
                    if (i == 1 || j == 1 || i == n || j == m)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }





        }
    }
}
