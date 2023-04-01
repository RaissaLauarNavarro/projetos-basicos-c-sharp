using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto9
{
    class Program
    {
        static void Main(string[] args)
        {

            int anos = 0;
            int a = 5000000;
            int b = 7000000;

            while (b > a)
            {
                a = (a / 100) * 103;
                b = (b / 100) * 102;
                anos++;
            }

            Console.Write("Tempo necessário: " + anos + "anos");
            Console.ReadKey();
        }
    }
}
