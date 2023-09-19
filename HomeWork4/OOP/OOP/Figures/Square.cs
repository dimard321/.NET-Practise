namespace OOP.Figures
{
    /// <summary>
    /// Класс для квадрата.
    /// </summary>
    class Square : IFigure
    {
        /// <summary>
        /// Приватное поле для хранения длины стороны квадрата.
        /// </summary>
        private double Length { get; init; }

        /// <summary>
        /// Конструктор класса Square, принимающий длину стороны квадрата и инициализирующий поле.
        /// </summary>
        /// <param name="length">Длина стороны квадрата.</param>
        public Square(double length)
        {
            this.Length = length;
        }

        ///<inheritdoc/>
        public double Area()
        {
            if (Length > 0)
            {
                return Length * Length;
            }
            else
            {
                throw new IOException("Введите величину, больше 0");
            }
        }

        ///<inheritdoc/>
        public double Perimeter()
        {
            if (Length > 0)
            {
                return Length * 4;
            }
            else
            {
                throw new IOException("Введите величину, больше 0");
            }
        }
    }
}
