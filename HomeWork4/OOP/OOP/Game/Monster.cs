using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Game
{
    /// <summary>
    /// Абстрактный базовый класс для монстров в игре.
    /// </summary>
    public abstract class Monster : IGameElement, IAliveElement
    {
        /// <summary>
        /// Конструктор для создания экземпляра монстра с заданными характеристиками.
        /// </summary>
        /// <param name="hp">Здоровье монстра.</param>
        /// <param name="attack">Сила атаки монстра.</param>
        /// <param name="speed">Скорость монстра.</param>
        protected Monster(int hp, int attack, int speed)
        {
            HP = hp;

            Attack = attack;

            Speed = speed;
        }

        public int X { get; set; }

        public int Y { get; set; }

        public int HP { get; set; }

        public int Attack { get; set; }

        public int Speed { get; set; }

        /// <summary>
        /// Выполняет перемещение монстра по указанным координатам.
        /// </summary>
        /// <param name="x">Текущая координата X монстра.</param>
        /// <param name="y">Текущая координата Y монстра.</param>
        /// <param name="x1">Новая координата X для перемещения.</param>
        /// <param name="y1">Новая координата Y для перемещения.</param>
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
            if (target is Human)
            {
                Console.WriteLine($"{GetType().Name} атакует {target.GetType().Name} на {Attack} урона.");

                target.HP -= Attack;
            }
            else
            {
                Console.WriteLine($"{GetType().Name} не может атаковать {target.GetType().Name}, так как это не человек.");
            }
        }
    }

    /// <summary>
    /// Класс, представляющий монстра - волка.
    /// </summary>
    class Wolf : Monster
    {
        /// <summary>
        /// Конструктор для создания экземпляра волка с заданными характеристиками.
        /// </summary>
        /// <param name="hp">Здоровье волка.</param>
        /// <param name="attack">Сила атаки волка.</param>
        /// <param name="speed">Скорость волка.</param>
        public Wolf(int hp, int attack, int speed) : base(hp, attack, speed)
        {

        }
    }

    /// <summary>
    /// Класс, представляющий монстра - медведя.
    /// </summary>
    class Bear : Monster
    {
        /// <summary>
        /// Конструктор для создания экземпляра медведя с заданными характеристиками.
        /// </summary>
        /// <param name="hp">Здоровье медведя.</param>
        /// <param name="attack">Сила атаки медведя.</param>
        /// <param name="speed">Скорость медведя.</param>
        public Bear(int hp, int attack, int speed) : base(hp, attack, speed)
        {

        }
    }
}
