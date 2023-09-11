using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Perfomance
{
    /// <summary>
    /// класс в котором лежит целочисленное число
    /// </summary>
    public class C: IComparable<C>
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
        public int CompareTo(C other)
        {
            return i.CompareTo(other.i);
        }
    }
}
