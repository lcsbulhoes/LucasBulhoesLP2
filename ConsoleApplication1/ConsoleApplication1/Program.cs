using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Quantos pontos deseja?");
            int n = int.Parse(Console.ReadLine());
             List<Ponto> pontos = new List<Ponto>();
             int contx = 0;
             int conty = 0;
             
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Insira a coordenada x");
                int x = int.Parse(Console.ReadLine());
                Console.WriteLine("Insira a coordenada y");
                int y = int.Parse(Console.ReadLine());

                Ponto p = new Ponto(x, y);
                
                
                pontos.Add(p);
            }
            for (int i = 0; i < n; i++)
            {
                contx += pontos[i].X;
                conty += pontos[i].Y;
            }
            Console.WriteLine("Seu ponto médio é:({0},{1})", contx / n, conty / n);
        }
    }
}
