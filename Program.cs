using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduza a palavra misteriosa");
            string palavra = Console.ReadLine();

            char[] misterio = new char[palavra.Length];

            for (int i = 0; i < palavra.Length; i++)
            {
                misterio[i] = '*';
                Console.Write("{0}", misterio[i]);
            }

            for (int j = 0; j <= 7; j++)
            {
                Console.WriteLine("INSIRA UMA LETRA DE PALPITE");
                  char tent = char.Parse(Console.ReadLine());
                  
                if(tent == palavra[j])
                {
                  misterio[j] = tent;
                  Console.Write(new string(misterio));

                }
                 if (tent != palavra[j])
                 {
                    Console.WriteLine("ERROU");
                }
                
                  }
            

            }

            


            






        }
    }

