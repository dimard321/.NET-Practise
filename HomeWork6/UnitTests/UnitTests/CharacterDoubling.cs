using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringExamples
{
    /// <summary>
    /// Класс для дублирования повторяющихся символов в двух строках
    /// </summary>
    public class CharacterDoubling
    {
        /// <summary>
        /// Метод для дублирования повторяющихся символов в двух строках
        /// </summary>
        /// <param name="inputString">входная строка</param>
        /// <param name="twoInputString">вторая входная строка</param>
        /// <returns>строка с продублированными символами</returns>
        public string GetCharacterDoubling(string inputString, string twoInputString)
        {
            for (var i = 0; i < inputString.Length; i++)
            {
                if (twoInputString.Contains(inputString[i]))
                {
                    inputString = inputString.Insert(i, inputString[i].ToString());

                    i++;
                }
            }

            return inputString;
        }
    }
}