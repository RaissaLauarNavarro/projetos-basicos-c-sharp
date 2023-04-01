using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite a distância em kilometros: ");
            double distancia = double.Parse(Console.ReadLine());
            Console.Write("Digite a velocidade em km/h: ");
            double velocidade = double.Parse(Console.ReadLine());

            double tempo = distancia / velocidade;
            double velocidadeMetros = velocidade / 3.6;

            Console.WriteLine("");
            Console.Write("Tempo: ");
            Console.WriteLine(tempo);
            Console.Write("Velocidade: ");
            Console.Write(velocidadeMetros + "m/s");

            Console.ReadKey();
        }
    }
}
