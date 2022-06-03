using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen
{
    public class Rectangulo : FiguraGeometrica
    {
        private int Base;
        private int Altura;
        private int resultado;

        public Rectangulo(string nombrefigura, string color, int Base, int Altura): base (nombrefigura,color)
        {
            this.Base = Base;   
            this.Altura = Altura;
        }
        public void CalcularArea()
        {
            resultado = Altura *Base ;
        }
        public override void MostrarDatos()
        {
            base.MostrarDatos();
            Console.WriteLine("Base: " + Base + "\nAltura: " + Altura + "\nEl area de un Rectangulo es: " + resultado);
        }
    }
}
