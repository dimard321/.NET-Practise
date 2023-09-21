using OOP.Figures;
using OOP.Game;

namespace OOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var circle = new Circle(5);

            Console.WriteLine($"Площадь круга равна {circle.Area()}");

            Console.WriteLine($"Периметр круга равен {circle.Perimeter()}");

            var triangle = new Triangle(5, 6, 7);

            Console.WriteLine($"Площадь треугольника равна {triangle.Area()}");

            Console.WriteLine($"Периметр треугольника равен {triangle.Perimeter()}");

            var rectangle = new Rectangle(4, 8);

            Console.WriteLine($"Площадь прямоугольника равна {rectangle.Area()}");

            Console.WriteLine($"Периметр прямоугольника равен {rectangle.Perimeter()}");

            var square = new Square(4);

            Console.WriteLine($"Площадь квадрата равна {square.Area()}");

            Console.WriteLine($"Периметр квадрата равен {square.Perimeter()}\n\n");

            var gameImitation = new GameImitation();
            try
            {
                gameImitation.PlayGame();
            }
            catch(ArgumentOutOfRangeException ex)
            {
               Console.WriteLine(ex.Message);
            }
        }
    }
}