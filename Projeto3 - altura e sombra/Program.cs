using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite a sua altura: ");
            double alturaPessoa = double.Parse(Console.ReadLine());
            Console.Write("Digite a altura da sua sombra: ");
            double sombraPessoa = double.Parse(Console.ReadLine());
            Console.Write("Digite a altura da sombra so prédio: ");
            double sombraPredio = double.Parse(Console.ReadLine());

            double resposta = (alturaPessoa * sombraPredio) / sombraPessoa;
            Console.WriteLine("");
            Console.Write("Altura do prédio: ");
            Console.Write(resposta);

            Console.ReadKey();
        }
    }
}
