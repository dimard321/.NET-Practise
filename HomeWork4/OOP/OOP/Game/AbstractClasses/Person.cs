using OOP.Game.Intefraces;

namespace OOP.Game.AbstractClasses
{
    /// <summary>
    /// Абстрактный базовый класс для персонажей в игре.
    /// </summary>
    public abstract class Person : IGameElement, IAliveElement
    {
        public int X { get; set; }

        public int Y { get; set; }

        public int HP { get; set; }

        public int Attack { get; set; }

        public int Speed { get; set; }

        /// <summary>
        /// Конструктор для создания экземпляра человека с заданными характеристиками.
        /// </summary>
        /// <param name="hp">Здоровье человека.</param>
        /// <param name="attack">Сила атаки человека.</param>
        /// <param name="speed">Скорость человека.</param>
        public Person(int hp, int attack, int speed)
        {
            if (hp > 0 && attack > 0 && speed > 0)
            {
                HP = hp;

                Attack = attack;

                Speed = speed;
            }
            else
            {
                throw new ArgumentOutOfRangeException(null, null, message: "Характеристики персонажа не могут быть меньше 1") ;
            }
        }

        /// <summary>
        /// Метод для перемещения персонажа по указанным координатам.
        /// </summary>
        /// <param name="x1">Координата X, в которую персонаж перемещается.</param>
        /// <param name="y1">Координата Y, в которую персонаж перемещается.</param>
        public virtual void Move(int x1, int y1)
        {
            X = x1;

            Y = y1;
        }

        /// <summary>
        /// Метод для атаки.
        /// </summary>
        /// <param name="target">Цель атаки.</param>
        public virtual void MakeAttack(IAliveElement target)
        {
            if (target is Monster)
            {
                Console.WriteLine($"{GetType().Name} атакует {target.GetType().Name} на {Attack} урона.");

                target.HP -= Attack;
            }
            else
            {
                Console.WriteLine($"{GetType().Name} не может атаковать {target.GetType().Name}, так как это не монстр.");
            }
        }
    }
}
