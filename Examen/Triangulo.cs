using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen
{
    public class Triangulo : FiguraGeometrica 
    {
        private int Base;
        private int Altura;
        private int Resultado;

        public Triangulo(string nombrefigura, string color,int Base, int Altura):base(nombrefigura,color)
        {
            this.Base = Base;   
            this.Altura = Altura;
            this.Resultado = Resultado;
        }

       public void CalcularArea()
        {
            Resultado = (Base * Altura) / 2;
        }
        public override void MostrarDatos()
        {
            base.MostrarDatos();
            Console.WriteLine("Base: " + Base + "\nAltura " + Altura + "\nEl Area de un Triangulo es: " + Resultado);
        }
    }
}
