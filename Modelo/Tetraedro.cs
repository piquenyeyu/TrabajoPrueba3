using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class Tetraedro : FiguraTridimencional
    {
        public double CalcularArea(double lado)
        {
            double area = Math.Sqrt(3) * Math.Pow(lado, 2);
            return area;
        }
        public double CalcularPerimetro(double lado)
        {
            double perimetro = (Math.Sqrt(2) * Math.Pow(lado, 3)) / 12;
            return perimetro;
        }

    }
}
