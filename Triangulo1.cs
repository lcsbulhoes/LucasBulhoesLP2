using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Quantos triângulos deseja?");
             int x = int.Parse(Console.ReadLine());
             double perim = 0;
             double n;
             int id = 0;
             Triangulo tri = new Triangulo(50, 50, 50);

             for (int i = 0; i < x; i++)
             {
                 Console.WriteLine("Insira o id do triângulo:");
                 tri.id = int.Parse(Console.ReadLine());
                 Console.WriteLine("Insira o tamanho do lado 1:");
                 tri.Lado1 = double.Parse(Console.ReadLine());
                 Console.WriteLine("Insira o tamanho do lado 2:");
                 tri.Lado2 = double.Parse(Console.ReadLine());
                 Console.WriteLine("Insira o tamanho do lado 3:");
                 tri.Lado3 = double.Parse(Console.ReadLine());
                 Console.WriteLine("Insira o código da cor do triângulo:");
                 tri.cor = Console.ReadLine();

                 n = tri.Lado1 + tri.Lado2 + tri.Lado3;

                 if (n > perim)
                 {
                     perim = n;
                     id = tri.id;
                 }

 
             }
             Console.WriteLine("O triângulo de maior perímetro é o {0},com o seguinte perímetro: {1}", id, perim);
 
        }
    }
}
