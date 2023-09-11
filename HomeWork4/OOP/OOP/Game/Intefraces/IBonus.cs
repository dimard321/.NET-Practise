using OOP.Game.AbstractClasses;

namespace OOP.Game.Intefraces
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
}
