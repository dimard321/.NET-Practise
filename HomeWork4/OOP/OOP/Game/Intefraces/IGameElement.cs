namespace OOP.Game.Intefraces
{
    /// <summary>
    /// Интерфейс для игровых элементов.
    /// </summary>
    public interface IGameElement
    {
        /// <summary>
        /// Получает или задает координату X элемента.
        /// </summary>
        public int X { get; set; }

        /// <summary>
        /// Получает или задает координату Y элемента.
        /// </summary>
        public int Y { get; set; }
    }
}
