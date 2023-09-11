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
    /// Класс, представляющий препятствие - дерево.
    /// </summary>
    class Tree : Obstacle, IObstacle
    {
        /// <summary>
        /// Конструктор для создания экземпляра дерева.
        /// </summary>
        /// <param name="damage">Урон от дерева.</param>
        public Tree(int damage) : base(damage)
        {

        }

        public override void DamagePerson(Person person)
        {
            Console.WriteLine($"Дерево наносит {HealthDamage} урона персонажу {person.GetType().Name}.");

            person.HP -= HealthDamage;
        }
    }
}
