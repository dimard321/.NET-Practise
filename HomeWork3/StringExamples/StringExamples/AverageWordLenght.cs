using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringExamples
{
    /// <summary>
    /// Класс для расчета средней длины слова во входной строке
    /// </summary>
    public class AverageWordLenght
    {
        /// <summary>
        /// Расчет средней длины слова во входной строке
        /// </summary>
        /// <param name="inputString">входящая строка</param>
        /// <returns>средняя длина слов</returns>
        public static double GetAverageWordLenght(string inputString)
        {
           var words = inputString.Split(' ');

           return words.Average(word => word.Length);
        }
    }
}
