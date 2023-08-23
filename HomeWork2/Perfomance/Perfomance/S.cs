using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Perfomance
{
    /// <summary>
    /// структура в которой лежит целочисленное число
    /// </summary>
    public struct S: IComparable<S>
    {
        /// <summary>
        /// целочисленное значение
        /// </summary>
        public int i;

        /// <summary>
        /// Сравнивает объекты на основе значения i
        /// </summary>
        /// <param name="other">значения</param>
        /// <returns>значения</returns>
        public int CompareTo(S other)
        {
            return i.CompareTo(other.i);
        }
    }
}
