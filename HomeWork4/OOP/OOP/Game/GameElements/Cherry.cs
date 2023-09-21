using OOP.Game.AbstractClasses;

namespace OOP.Game.GameElements
{
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
