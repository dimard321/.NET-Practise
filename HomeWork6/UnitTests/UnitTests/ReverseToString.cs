using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringExamples
{
    /// <summary>
    ///  Класс разворачивает все слова во входной строке
    /// </summary>
    public class ReverseToString
    {
        /// <summary>
        /// Разворачивает все слова во входной строке
        /// </summary>
        /// <param name="inputString">входная строка</param>
        /// <returns>строку с развернутыми словами</returns>
        public string ReverseWords(string inputString)
        {
            var words = inputString.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            var newString = string.Empty;

            for (var i = 0; i < words.Length; i++)
            {
                newString = words[i] + " " + newString;
            }

            return newString.Trim();
        }
    }
}