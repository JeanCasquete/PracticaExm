using System;
using System.Collections.Generic;

namespace Examen
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Rectangulo recta = new Rectangulo("Rectangulo", "Amarillo", 15, 15);
            recta.CalcularArea();

            Triangulo tria = new Triangulo("Triangulo", "Verde", 15, 20);
            tria.CalcularArea();

            Circulo circu = new Circulo("Circulo", "Rojo", 25);
            circu.CalcularArea();

            List<FiguraGeometrica> ListaFiguras = new List<FiguraGeometrica>();
            {
                ListaFiguras.Add(circu);
                ListaFiguras.Add(tria);
                ListaFiguras.Add(recta);

            }
             foreach (FiguraGeometrica Figura in ListaFiguras)
            {
                Figura.MostrarDatos();
            }

        }
    }
}
