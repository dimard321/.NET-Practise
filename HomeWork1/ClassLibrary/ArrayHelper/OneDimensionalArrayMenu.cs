using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayHelper
{
    /// <summary>
    /// Меню выбора сортировки
    /// </summary>
    public enum OneDimensionalArrayMenu
    {
        /// <summary>
        /// Восходящая сортировка
        /// </summary>
        [Description("Восходящая сортировка")]
        ASCSort = 1,

        /// <summary>
        /// Низходящая сортировка
        /// </summary>
        [Description("Низходящая сортировка")]
        DESCSort
    }
}
