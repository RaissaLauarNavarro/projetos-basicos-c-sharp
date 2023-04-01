using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite o primeiro valor de a: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Digite o primeiro valor de b: ");
            int b = int.Parse(Console.ReadLine());
            Console.Write("Digite o primeiro valor de c: ");
            int c = int.Parse(Console.ReadLine());
            Console.WriteLine(" ");

            int delta = (b * b) - (4 * a * c);

            if (a == 0)
            {
                Console.Write("Não é equação do segundo grau");
            } else if(delta > 0)
            {
                    int resultado1 = (-b + delta) / (2 * a);
                    int resultado2 = (-b - delta) / (2 * a);

                    if (resultado1 != resultado2)
                    {
                        Console.Write("Primeira raíz: ");
                        Console.WriteLine(resultado1);
                        Console.Write("Segunda raíz: ");
                        Console.Write(resultado2);
                    }
                    else
                    {
                        Console.Write("Raíz: ");
                        Console.Write(resultado1);
                    }
            } else if(delta <= 0)
            {
                Console.Write("Não há raízes reais");
            }

            Console.ReadKey();
        }
    }
}
