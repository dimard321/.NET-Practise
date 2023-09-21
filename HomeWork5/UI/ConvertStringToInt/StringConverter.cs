using NLog;
using System.Text.RegularExpressions;

namespace StringConverterLibrary
{
    /// <summary>
    /// Класс для преобразования строк в целые числа и их валидации.
    /// </summary>
    public class StringConverter
    {
        private readonly ILogger _logger;

        /// <summary>
        /// Конструктор класса StringConverter.
        /// </summary>
        /// <param name="logger">Объект для логирования.</param>
        public StringConverter(ILogger logger)
        {
            _logger = logger;
        }

        /// <summary>
        /// Метод для преобразования строки в целое число.
        /// </summary>
        /// <param name="inputStrings">Входная строка.</param>
        /// <returns>Преобразованное целое число.</returns>
        public int ConvertToInt(string inputStrings)
        {
            _logger.Info("Началась конвертация");

            int result = 0;

            bool negative = false;

            foreach (char symbol in inputStrings)
            {
                if (symbol == '-')
                {
                    negative = true;
                }
                else
                {
                    checked
                    {
                        try
                        {
                            result = result * 10 + symbol - '0';
                        }
                        catch (OverflowException)
                        {
                            _logger.Error($"Введенное значение превышает максимальное или минимальное целочисленное значение: {inputStrings}");

                            throw new OverflowException("Введенное значение превышает максимальное или минимальное целочисленное значение");
                        }
                    }
                }

            }

            _logger.Info("Конвертация завершилась успешно");

            if (negative)
            {
                return -result;
            }
            else
            {
                return result;
            }
        }

        /// <summary>
        /// Метод для валидации строки.
        /// </summary>
        /// <param name="inputString">Входная строка.</param>
        /// <returns>True, если строка является целым числом, в противном случае - False.</returns>
        public bool Validate(string inputString)
        {
            _logger.Info("Валидация строки");

            Regex regex = new Regex(@"(^-?[1-9]+\d*$)|^0$");

            var match = regex.IsMatch(inputString);

            if (!match)
            {
                _logger.Error($"Введенное значение не является целым числом: {inputString}");

                throw new ArgumentException($"Введенное значение не является целым числом: {inputString}");
            }

            _logger.Info("Валидация прошла успешно");

            return match;
        }
    }
}