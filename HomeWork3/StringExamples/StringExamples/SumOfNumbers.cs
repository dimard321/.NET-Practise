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
        public static string GetSumOfNumbers(string inputString, string twoInputString)
        {
            var maxLength = Math.Max(inputString.Length, twoInputString.Length);

            var finalString = "";

            var carry = 0;

            for (var i = 0; i < maxLength; i++)
            {
                var digit1 = i < inputString.Length 
                    ? int.Parse(inputString[inputString.Length - 1 - i].ToString()) 
                    : 0;

                var digit2 = i < twoInputString.Length 
                    ? int.Parse(twoInputString[twoInputString.Length - 1 - i].ToString()) 
                    : 0;

                var sum = digit1 + digit2 + carry;

                carry = sum / 10;

                var currentDigit = sum % 10;

                finalString = currentDigit + finalString;
            }

            if (carry > 0)
            {
                finalString = carry + finalString;
            }

            return finalString;
        }
    }
}
