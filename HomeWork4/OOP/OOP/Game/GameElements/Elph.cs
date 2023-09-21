using OOP.Game.AbstractClasses;

namespace OOP.Game.GameElements
{
    /// <summary>
    /// Класс, представляющий эльфа.
    /// </summary>
    class Elph : Person
    {
        /// <summary>
        /// Конструктор для создания экземпляра эльфа.
        /// </summary>
        /// <param name="hp">Здоровье эльфа.</param>
        /// <param name="attack">Сила атаки эльфа.</param>
        /// <param name="speed">Скорость эльфа.</param>
        public Elph(int hp, int attack, int speed) : base(hp, attack, speed)
        {

        }

        public override void Move(int x, int y, int x1, int y1)
        {
            Console.WriteLine($"Эльф переместился в координаты X:{x1}, Y:{y1}.");

            base.Move(x, y, x1, y1);
        }
    }
}
