using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace StringExamples
{
    /// <summary>
    /// Класс для парсинга телефонных номеров
    /// </summary>
    public class TelephoneNumbers
    {
        /// <summary>
        /// Метод для парсинга телефонных номеров
        /// </summary>
        /// <param name="inputString">входная строка</param>
        /// <returns>телефонные номера</returns>
        public static List<string> GetTelephoneNumbers(string inputString)
        {
            var phoneNumbers = new List<string>();

            var regex = new Regex(@"\+?\d{1,3}\s?\(?\d{2,3}\)?\s\d{3}-\d{2,3}-?(\d{2})?");

            var matches = regex.Matches(inputString);

            if (matches.Count > 0)
            {
                foreach (Match match in matches)

                    phoneNumbers.Add(match.Value);
            }

            return phoneNumbers.Count != 0 ? phoneNumbers : new List<string> { "Совпадений не найдено" };
        }
    }
}