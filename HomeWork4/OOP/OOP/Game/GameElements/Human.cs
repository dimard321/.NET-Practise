using OOP.Game.AbstractClasses;

namespace OOP.Game.GameElements
{
    /// <summary>
    /// Класс, представляющий человека.
    /// </summary>
    class Human : Person
    {
        /// Конструктор для создания экземпляра человека с заданными характеристиками.
        /// </summary>
        /// <param name="hp">Здоровье человека.</param>
        /// <param name="attack">Сила атаки человека.</param>
        /// <param name="speed">Скорость человека.</param>
        public Human(int hp, int attack, int speed) : base(hp, attack, speed)
        {

        }

        public override void Move(int x, int y, int x1, int y1)
        {
            Console.WriteLine($"Человек переместился в координаты X:{x1}, Y:{y1}.");

            base.Move(x, y, x1, y1);
        }
    }
}
