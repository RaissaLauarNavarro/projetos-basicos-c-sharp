using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite o primeiro valor de entrada: ");
            int numero1 = int.Parse(Console.ReadLine());
            Console.Write("Digite o segundo valor de entrada: ");
            int numero2 = int.Parse(Console.ReadLine());
            Console.Write("Digite o terceiro valor de entrada: ");
            int numero3 = int.Parse(Console.ReadLine());


            if (numero1 < numero2 && numero2 < numero3)
            {
                Console.WriteLine(numero1 + ", " + numero2 + ", " + numero3);
            }
            else if (numero1 < numero3 && numero2 > numero3)
            {
                Console.WriteLine(numero1 + ", " + numero3 + ", " + numero2);
            }
            else if (numero2 < numero1 && numero1 < numero3)
            {
                Console.WriteLine(numero2 + ", " + numero1 + ", " + numero3);
            }
            else if (numero2 < numero3 && numero1 > numero3)
            {
                Console.WriteLine(numero2 + ", " + numero3 + ", " + numero1);
            }
            else if (numero3 < numero1 && numero1 < numero2)
            {
                Console.WriteLine(numero3 + ", " + numero1 + ", " + numero2);
            }
            else if (numero3 < numero2 && numero1 > numero3)
            {
                Console.WriteLine(numero3 + ", " + numero2 + ", " + numero1);
            }
            Console.ReadKey();
        }
    }
}
