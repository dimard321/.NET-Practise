using OOP.Game.Intefraces;

namespace OOP.Game.AbstractClasses
{
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
            if (bonusValue > 0)
            {
                BonusValue = bonusValue;
            }
            else
            {
                throw new ArgumentOutOfRangeException("Введенное значение для бонуса не может быть меньше 1");
            }
           
        }

        /// <summary>
        /// Метод для применения бонуса к персонажу.
        /// </summary>
        /// <param name="person">Персонаж, который получает бонус.</param>
        public abstract void SetBonus(Person person);
    }
}
