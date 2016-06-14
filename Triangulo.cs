using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Triangulo
    {
        private double lado1;
        private double lado2;
        private double lado3;
        private string cor;

        public Triangulo(double lado1, double lado2, double lado3)
        {
            if( Lado1 > (Lado2 - Lado3) && Lado1 < (Lado2 + Lado3) && Lado1 > 0 && Lado2 > (Lado1 - Lado3) && Lado2 < (Lado1 + Lado3) && Lado2 > 0 && Lado3 > (Lado1 - Lado2) && Lado3 < (Lado1 + Lado2) && Lado3 > 0){
            this.lado3 = Lado3;
            this.lado2= Lado2;
            this.lado1 = Lado1;
            }
        }

        public double Lado1
        {
            get { return lado1; }
            set
            {
                if (value > 0)
                    this.lado1 = value;
            }
        }
            public double Lado2
            {
                get { return lado2; }
                set 
                {
                  if (value > 0)
                      this.lado2 = value;
                }
            }
                public double Lado3
                {
                    get {return lado3; }
                    set 
                    {
                        if (value > 0)
                            this.lado3 = value;
                    }
                    }
        

        public int id {get; set;}
        public int posx { get; set; }
        public int posy { get; set; }
        public string cor;
        

        

                }
                }
            

  