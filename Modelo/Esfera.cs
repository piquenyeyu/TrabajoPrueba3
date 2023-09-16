using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class Esfera : FiguraTridimencional
    {
        public double CalcularArea(double radio)
        {
            double area = 4 * Math.PI * Math.Pow(radio, 2);
            return area;
        }
        public double CalcularPerimetro(double radio)
        {
            double perimetro = (4 * Math.PI * Math.Pow(radio, 3)) / 3;
            return perimetro;
        }
    }
}
