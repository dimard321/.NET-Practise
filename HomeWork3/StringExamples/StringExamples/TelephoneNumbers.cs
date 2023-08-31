using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace StringExamples
{
    public class TelephoneNumbers
    {
        public static List<string> GetTelephoneNumbers(string inputString)
        {
            var phoneNumbers = new List<string>();

            Regex regex = new Regex(@"\+?\d{1,3}\s?\(?\d{2,3}\)?\s\d{3}-\d{2,3}-?(\d{2})?");

            MatchCollection matches = regex.Matches(inputString);

            if (matches.Count > 0)
            {
                foreach (Match match in matches)

                    phoneNumbers.Add(match.Value);
            }

            return phoneNumbers.Count != 0 ? phoneNumbers : new List<string> { "Совпадений не найдено" };
        }
    }
}