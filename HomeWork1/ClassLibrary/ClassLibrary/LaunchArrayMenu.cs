using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    /// <summary>
    /// Меню выбора массива
    /// </summary>
    public enum LaunchArrayMenu
    {
        /// <summary>
        /// Выбор операции с одномерным массивом
        /// </summary>
        [Description("Выбор операции с одномерным массивом")]
        OneDimensionalArray = 1,

        /// <summary>
        /// Выбор операции с двумерным массивом
        /// </summary>
        [Description("Выбор операции с двумерным массивом")]
        TwoDimensionalArray,

        /// <summary>
        /// Вернуться назад
        /// </summary>
        [Description("Вернуться назад")]
        ComeBack
    }
}
