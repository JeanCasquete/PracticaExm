using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen
{
    public class FiguraGeometrica
    {
        public string nombrefigura;
        public string color;


        public FiguraGeometrica(string nombrefigura, string color)
        {
            this.nombrefigura = nombrefigura;
            this.color = color;

        }
        public virtual void MostrarDatos()
        {
            Console.WriteLine("\nNombre de Figura: " + nombrefigura+ "\nColor: " + color);
        }
    }
}
