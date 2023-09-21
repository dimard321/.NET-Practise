using OOP.Game.AbstractClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Game.GameElements
{
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
