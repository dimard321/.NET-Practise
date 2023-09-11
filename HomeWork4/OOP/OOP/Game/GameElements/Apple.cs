using OOP.Game.AbstractClasses;

namespace OOP.Game.GameElements
{
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
}
