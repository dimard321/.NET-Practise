using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringExamples
{
    /// <summary>
    /// Меню для выбора операции со строками
    /// </summary>
    public enum LaunchStringMenu
    {
        /// <summary>
        /// Средняя длина слова во входной строке
        /// </summary>
        [Description("Cредняя длина слова во входной строке")]
        AverageLength = 1,

        /// <summary>
        /// Удваивание символов
        /// </summary>
        [Description("Удваивание символов")]
        DoublingCharacters,

        /// <summary>
        /// Сумма двух больших чисел
        /// </summary>
        [Description("Сумма двух больших чисел")]
        SumOfNumbers,

        /// <summary>
        /// Развернуть все слова во входной строке
        /// </summary>
        [Description("Развернуть все слова во входной строке")]
        ExpandOfWords,

        /// <summary>
        /// Считать номера телефонов из файла
        /// </summary>
        [Description("Считать номера телефонов из файла")]
        ReadPhoneNumbers
    }
}
