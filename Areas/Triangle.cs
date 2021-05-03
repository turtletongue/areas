using System;

namespace Areas
{
    public class Triangle : IFigure
    {
        public double ASide { get; set; }
        public double BSide { get; set; }
        public double CSide { get; set; }

        public Triangle(double aSide, double bSide, double cSide)
        {
            ASide = aSide;
            BSide = bSide;
            CSide = cSide;
        }

        public double GetArea()
        {
            // Полупериметр
            double p = (ASide + BSide + CSide) / 2;
            // Формула Герона
            return Math.Sqrt(p * (p - ASide) * (p - BSide) * (p - CSide));
        }

        // Проверяем равенство c^2 = a^2 + b^2 для найденной наибольшей стороны, которая является гипотенузой
        // Равносторонний треугольник не может быть прямоугольным
        public bool IsRectangular()
        {
            if (ASide > BSide || ASide > CSide)
            {
                return Math.Pow(ASide, 2) == Math.Ceiling(Math.Pow(BSide, 2) + Math.Pow(CSide, 2));
            }
            else if (BSide > ASide || BSide > CSide)
            {
                return Math.Pow(BSide, 2) == Math.Ceiling(Math.Pow(BSide, 2) + Math.Pow(CSide, 2));
            }
            else if (CSide > ASide || CSide > BSide)
            {
                return Math.Pow(BSide, 2) == Math.Ceiling(Math.Pow(BSide, 2) + Math.Pow(CSide, 2));
            }
            else
            {
                return false;
            }
        }
    }
}
