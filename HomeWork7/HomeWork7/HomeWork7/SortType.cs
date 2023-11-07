using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork7
{
    /// <summary>
    /// Перечисление, представляющее тип сортировки.
    /// </summary>
    enum SortType
    {
        /// <summary>
        /// Сортировка в порядке возрастания.
        /// </summary>
        [Description("Сортировка по возрастанию")]
        ASC,

        /// <summary>
        /// Сортировка в порядке убывания.
        /// </summary>
        [Description("Сортировка по убыванию")]
        DESC
    }
}
