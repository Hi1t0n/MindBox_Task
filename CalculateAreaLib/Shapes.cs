namespace CalculateAreaLib
{
    public class Circle : ICalculateArea
    {
        private double radius;

        /// <summary>
        /// Конуструктор класса Circle
        /// </summary>
        /// <param name="radius">Радиус</param>
        /// <exception cref="ArgumentException">Проверка больше ли радиус 0 или нет</exception>
        public Circle(double radius)
        {
            if (radius <= 0) { throw new ArgumentException("Радиус должен быть больше 0"); }
            this.radius = radius;
        }

        /// <summary>
        /// Подсчет площади круга
        /// </summary>
        /// <returns>Площадь круга</returns>
        public double GetArea()
        {

            return Math.PI * Math.Pow(radius, 2);
        }
    }

    public class Triangle : ICalculateArea
    {
        private double side1;
        private double side2;
        private double side3;

        /// <summary>
        /// Конструктор класс Triangle
        /// </summary>
        /// <param name="side1">Сторона 1</param>
        /// <param name="side2">Сторона 2</param>
        /// <param name="side3">Сторона 3</param>
        /// <exception cref="ArgumentException">Проверка сторон треугольника и на то может ли он существовать </exception>
        public Triangle(double side1, double side2, double side3)
        {
            if (side1 <= 0 || side2 <= 0 || side3 <= 0) { throw new ArgumentException("Значение сторон должно быть больше 0"); }
            if (side1 + side2 < side3 || side2 + side3 < side1 || side3 + side1 < side2) { throw new ArgumentException("Данный треугольник не может существовать"); }
            this.side1 = side1;
            this.side2 = side2;
            this.side3 = side3;
        }

        /// <summary>
        /// Подсчет площади треугольника
        /// </summary>
        /// <returns>Площадь треугольника</returns>
        public double GetArea()
        {
            double semiP = (side1 + side2 + side3) / 2;

            return Math.Sqrt(semiP * (semiP - side1) * (semiP - side2) * (semiP - side3));
        }

        /// <summary>
        /// Проверяем прямоугольный ли у нас треугольник или нет
        /// </summary>
        /// <returns>True или False в зависимости от того какой у нас треугольник</returns>
        public bool IsRightTriangle()
        {
            return (Math.Pow(side1, 2) + Math.Pow(side2, 2) == Math.Pow(side3, 2) ||
                Math.Pow(side1, 2) + Math.Pow(side3, 2) == Math.Pow(side2, 2) ||
                Math.Pow(side3, 2) + Math.Pow(side2, 2) == Math.Pow(side1, 2));
        }
    }
}