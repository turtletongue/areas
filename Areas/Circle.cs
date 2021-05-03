using System;

namespace Areas
{
    public class Circle : IFigure
    {
        public double Radius { get; set; }

        public Circle(double radius)
        {
            Radius = radius;
        }

        // Получаем площадь круга по формуле S = Pi * R^2
        public double GetArea() => Math.PI * Math.Pow(Radius, 2);
    }
}
