using OOP.Game.AbstractClasses;

namespace OOP.Game.GameElements
{
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
}
