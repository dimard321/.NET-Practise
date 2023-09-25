using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringExamples
{
    /// <summary>
    /// Класс находит сумму двух больших чисел
    /// </summary>
    public class SumOfNumbers
    {
        /// <summary>
        /// Находит сумму двух больших чисел
        /// </summary>
        /// <param name="inputString">первое входное число</param>
        /// <param name="twoInputString">второе входное число</param>
        /// <returns>строку в которой сумма чисел</returns>
        public string GetSumOfNumbers(string inputString, string twoInputString)
        {
            var maxLength = Math.Max(inputString.Length, twoInputString.Length);

            var finalString = "";

            var carry = 0;

            if(inputString == "" || twoInputString == "")
            {
                throw new NullReferenceException("Не передано никакого значения");
            }
            else
            {
                for (var i = 0; i < maxLength; i++)
                {
                    var digit1 = i < inputString.Length && int.TryParse(inputString[inputString.Length - 1 - i].ToString(), out int parsedDigit)
                        ? parsedDigit
                        : throw new FormatException("Входные данные содержат недопустимый символ");

                    var digit2 = i < twoInputString.Length && int.TryParse(twoInputString[twoInputString.Length - 1 - i].ToString(), out parsedDigit)
                        ? parsedDigit
                        : throw new FormatException("Входные данные содержат недопустимый символ");

                    var sum = digit1 + digit2 + carry;

                    carry = sum / 10;

                    var currentDigit = sum % 10;

                    finalString = currentDigit + finalString;
                }
            }

            if (carry > 0)
            {
                finalString = carry + finalString;
            }

            return finalString;
        }
    }
}