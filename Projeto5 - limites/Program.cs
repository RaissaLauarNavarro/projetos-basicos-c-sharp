using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite o limite inferior: ");
            int inferior = int.Parse(Console.ReadLine());
            Console.Write("Digite o limite superior: ");
            int superior = int.Parse(Console.ReadLine());
            Console.Write("Digite o numero: ");
            int numero = int.Parse(Console.ReadLine());

            for (int i = 1; i < superior; i++)
            {
                int a = (i * numero);

                if(a < superior && a > inferior)
                {
                    Console.Write(a + " ");

                }
            }
            Console.ReadKey();
        }
    }
}
