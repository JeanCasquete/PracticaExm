using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen
{
    public class Circulo : FiguraGeometrica
    {
        private double Radio;
        private double Pi =3.1416;
        public double Area;


        public Circulo(string nombrefigura, string color, double Radio):base(nombrefigura,color)
        {
            this.Radio = Radio; 
            this.Pi = Pi;
            this.Area = Area;
        }

        public void CalcularArea()
        {
            Area = Pi * (Radio * Radio);
        }
        public override void MostrarDatos()
        {
            base.MostrarDatos();
            Console.WriteLine("Radio: " + Radio + "\nAl Area de un Circulo es: " + Area);
        }
    }
}
