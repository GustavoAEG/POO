using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AreaDoRetangulo_POO
{
    public class Area
    {
        public Area()
        {

        }
        public int altura;
        public int Altura
        {
            get { return altura; }
            set
            {
                if (altura >= 0)
                {
                    altura = value;
                }
            }
        }
        public int base_;

        public int Base_
        {
            get { return base_; }
            set  
            { 
                if (base_ >= 0)
                {
                    base_ = value;  
                }
            }
        }
     public double Resultado { get{return base_*altura;}}

        public void Resultado_area()
        {

            Console.WriteLine("A area total é de " + Resultado + "m²");
        }


    }
}