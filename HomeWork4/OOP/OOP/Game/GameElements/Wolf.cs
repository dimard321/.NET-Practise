using OOP.Game.AbstractClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Game.GameElements
{
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
}