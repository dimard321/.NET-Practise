using OOP.Game.AbstractClasses;
using OOP.Game.Intefraces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Game.GameElements
{
    /// <summary>
    /// Класс, представляющий препятствие - камень.
    /// </summary>
    class Stone : Obstacle, IObstacle
    {
        /// <summary>
        /// Конструктор для создания экземпляра камня
        /// </summary>
        /// <param name="damage">Урон от камня</param>
        public Stone(int damage) : base(damage)
        {

        }

        public override void DamagePerson(Person person)
        {
            Console.WriteLine($"Камень наносит {HealthDamage} урона персонажу {person.GetType().Name}.");

            person.HP -= HealthDamage;
        }
    }
}
