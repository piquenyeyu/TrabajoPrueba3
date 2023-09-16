using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class Triangulo : FiguraBidimencional
    {
        public double CalcularArea(double lado)
        {
            double area = (Math.Sqrt(3) * lado) / 4;
            return area;
        }
        public double CalcularPerimetro(double lado)
        {
            double perimetro = 3 * lado;
            return perimetro;
        }
    }
}
