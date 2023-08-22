using System.ComponentModel;

namespace ClassLibrary
{
    /// <summary>
    /// Основное меню
    /// </summary>
    public enum FunctionalMenu
    {
        /// <summary>
        /// Выбор операции с прямоугольником
        /// </summary>
        [Description("Выбор операции с прямоугольником")]
        RectangleHelper = 1,

        /// <summary>
        /// Выбор операции с массивом
        /// </summary>
        [Description("Выбор операции с массивом")]
        ArrayHelper
    }
}
