using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class cubo : FiguraTridimencional
    {
        public double CalcularArea(double lado)
        {
            double area = 6 * Math.Pow(lado, 2);
            return area;
        }
        public double CalcularPerimetro(double lado)
        {
            double perimetro = Math.Pow(lado, 3);
            return perimetro;
        }
    }
}
