using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class Cuadrado : FiguraBidimencional
    {
        public double CalcularArea(double lado)
        {
            double area = lado * lado;
            return area;
        }
        public double CalcularPerimetro(double lado)
        {
            double perimetro = 4 * lado;
            return perimetro;
        }
    }
}
