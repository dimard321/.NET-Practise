using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringExamples
{
    public class RewerseToString
    {
        public static string ReverseWords(string inputString)
        {
            string[] words = inputString.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            var newString = string.Empty;

            for (int i = 0; i < words.Length; i++)
            {
                newString = words[i] + " " + newString;
            }

            return newString;
        }
    }
}
