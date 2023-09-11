using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Game
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
            HP = hp;

            Attack = attack;

            Speed = speed;
        }

        /// <summary>
        /// Метод для перемещения персонажа по указанным координатам.
        /// </summary>
        /// <param name="x">Координата X для перемещения.</param>
        /// <param name="y">Координата Y для перемещения.</param>
        /// <param name="x1">Координата X, в которую персонаж перемещается.</param>
        /// <param name="y1">Координата Y, в которую персонаж перемещается.</param>
        public virtual void Move(int x, int y, int x1, int y1)
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
            Console.WriteLine($"Человек переместился в координаты X:{x}, Y:{y}.");

            base.Move(x, y, x1, y1);
        }
    }

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
            Console.WriteLine($"Эльф переместился в координаты X:{x}, Y:{y}.");

            base.Move(x, y, x1, y1);
        }
    }
}
