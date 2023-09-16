namespace Modelo
{
    public class Figura
    {

        public string figura { get; set; }

        public double AsignaFigura()
        {
            switch (figura)
            {
                case "Circulo": return 1;
                case "Cuadrado": return 2;
                case "Triandulo": return 3;
                case "Esfera": return 4;
                case "Cubo": return 5;
                case "Tetraedro": return 6;

            }
            return 0;
        }
    }
}