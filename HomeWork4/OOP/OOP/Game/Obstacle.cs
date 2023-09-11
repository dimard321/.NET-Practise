using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Game
{
    /// <summary>
    /// Интерфейс для представления препятствий.
    /// </summary>
    public interface IObstacle
    {
        public int HealthDamage { get; set; }
    }

    /// <summary>
    /// Абстрактный базовый класс для препятствий в игре.
    /// </summary>
    abstract class Obstacle : IGameElement, IObstacle
    {
        public int X { get; set; }

        public int Y { get; set; }

        public int HealthDamage { get; set; }

        public Obstacle(int healthDamage)
        {
            HealthDamage = healthDamage;
        }

        /// <summary>
        /// Метод для нанесения урона персонажу при столкновении с препятствием.
        /// </summary>
        /// <param name="person">Персонаж, который получает урон.</param>
        public virtual void DamagePerson(Person person)
        {
            Console.WriteLine($"{GetType().Name} наносит {HealthDamage} урона персонажу {person.GetType().Name}.");

            person.HP -= HealthDamage;
        }
    }

    /// <summary>
    /// Класс, представляющий препятствие - дерево.
    /// </summary>
    class Tree : Obstacle, IObstacle
    {
        public Tree(int damage) : base(damage)
        {

        }

        public override void DamagePerson(Person person)
        {
            Console.WriteLine($"Дерево наносит {HealthDamage} урона персонажу {person.GetType().Name}.");

            person.HP -= HealthDamage;
        }
    }

    /// <summary>
    /// Класс, представляющий препятствие - камень.
    /// </summary>
    class Stone : Obstacle, IObstacle
    {
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
