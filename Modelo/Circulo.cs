using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class Circulo : FiguraBidimencional
    {
            public double CalculaArea(double radio)
            {
                double area = Math.PI * Math.Pow(radio, 2);
                return area;
            }
            public double CalculaPerimetro(double radio)
            {
                double perimetro = 2 * Math.PI * radio;
                return perimetro;
            }
        
    }
}
