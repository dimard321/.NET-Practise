using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Game
{
    /// <summary>
    /// Интерфейс для представления бонусов в игре.
    /// </summary>
    public interface IBonus
    {
        public int BonusValue { get; set; }

        /// <summary>
        /// Метод для применения бонуса к персонажу.
        /// </summary>
        /// <param name="person">Персонаж, который получает бонус.</param>
        public void SetBonus(Person person);
    }

    /// <summary>
    /// Абстрактный базовый класс для бонусов в игре.
    /// </summary>
    abstract class Bonus : IGameElement, IBonus
    {
        public int X { get; set; }

        public int Y { get; set; }

        public int BonusValue { get; set; }

        protected Bonus(int bonusValue)
        {
            BonusValue = bonusValue;
        }

        /// <summary>
        /// Метод для применения бонуса к персонажу.
        /// </summary>
        /// <param name="person">Персонаж, который получает бонус.</param>
        public abstract void SetBonus(Person person);
    }

    /// <summary>
    /// Класс, представляющий бонус - банан.
    /// </summary>
    class Banana : Bonus
    {
        /// <summary>
        /// Создает экземпляр банана с указанным бонусом скорости.
        /// </summary>
        /// <param name="speedBonus">Значение бонуса скорости, которое будет предоставлено персонажу.</param>
        public Banana(int speedBonus) : base(speedBonus)
        {
        }

        /// <summary>
        /// Применяет бонус банана к персонажу, увеличивая его скорость на указанное значение.
        /// </summary>
        /// <param name="person">Персонаж, который получает бонус.</param>
        public override void SetBonus(Person person)
        {
            person.Speed += BonusValue;
        }
    }

    /// <summary>
    /// Класс, представляющий бонус - яблоко.
    /// </summary>
    class Apple : Bonus
    {
        /// <summary>
        /// Создает экземпляр яблока с указанным бонусом атаки.
        /// </summary>
        /// <param name="attackBonus">Значение бонуса атаки, которое будет предоставлено персонажу.</param>
        public Apple(int attackBonus) : base(attackBonus)
        {
        }

        /// <summary>
        /// Применяет бонус яблока к персонажу, увеличивая его атаку на указанное значение.
        /// </summary>
        /// <param name="person">Персонаж, который получает бонус.</param>
        public override void SetBonus(Person person)
        {
            person.Attack += BonusValue;
        }
    }

    /// <summary>
    /// Класс, представляющий бонус - вишню.
    /// </summary>
    class Cherry : Bonus
    {
        /// <summary>
        /// Создает экземпляр вишни с указанным бонусом здоровья.
        /// </summary>
        /// <param name="healthBonus">Значение бонуса здоровья, которое будет предоставлено персонажу.</param>
        public Cherry(int healthBonus) : base(healthBonus)
        {
        }

        /// <summary>
        /// Применяет бонус вишни к персонажу, увеличивая его здоровье на указанное значение.
        /// </summary>
        /// <param name="person">Персонаж, который получает бонус.</param>
        public override void SetBonus(Person person)
        {
            person.HP += BonusValue;
        }
    }
}
