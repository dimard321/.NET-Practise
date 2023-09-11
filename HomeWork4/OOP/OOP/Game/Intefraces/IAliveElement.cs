namespace OOP.Game.Intefraces
{
    /// <summary>
    /// Интерфейс для живых существ в игре.
    /// </summary>
    public interface IAliveElement
    {
        /// <summary>
        /// Получает или задает текущее количество здоровья существа.
        /// </summary>
        public int HP { get; set; }

        /// <summary>
        /// Получает или задает текущую скорость существа.
        /// </summary>
        public int Speed { get; set; }

        /// <summary>
        /// Получает или задает текущую атаку существа.
        /// </summary>
        public int Attack { get; set; }

        /// <summary>
        /// Выполняет движение существа по указанным координатам.
        /// </summary>
        /// <param name="x">Координата X для перемещения.</param>
        /// <param name="y">Координата Y для перемещения.</param>
        public void Move(int x, int y, int x1, int y1);

        /// <summary>
        /// Выполняет атаку другого живого существа.
        /// </summary>
        /// <param name="target">Цель атаки.</param>
        public void MakeAttack(IAliveElement target);
    }
}
