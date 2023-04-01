using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto8
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 0;
            for (int i = 1; i <= 100; i++)
            {
                 a += i;

                if (a%10!=0 && a<100 && a>0)
                {
                    Console.Write(a + " ");
                }
            }
            Console.ReadKey();
        }
    }
}