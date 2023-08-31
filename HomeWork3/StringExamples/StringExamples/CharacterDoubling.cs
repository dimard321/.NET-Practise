using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringExamples
{
    public class CharacterDoubling
    {
       public static string GetCharacterDoubling(string inputString, string twoInputString)
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
