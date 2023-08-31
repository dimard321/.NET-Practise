using static System.Runtime.InteropServices.JavaScript.JSType;

namespace StringExamples
{
    internal class Program
    {
        static void StringMenu()
        {
            Console.WriteLine("Введите номер операции:\n" +
                "1. Cредняя длина слова во входной строке\n" +
                "2. Удваивание символов\n" +
                "3. Сумма двух больших чисел\n" +
                "4. Развернуть все слова во входной строке");

            var function = int.Parse(Console.ReadLine());

            switch (function)
            {
                case 1:

                    Console.WriteLine("Введите строку");

                    var inputString = Console.ReadLine();

                    Console.WriteLine(AverageWordLenght.GetAverageWordLenght(inputString));

                    break;

                case 2:

                    Console.WriteLine("Введите две строки");

                    string oneInputString = Console.ReadLine();

                    string twoInputString = Console.ReadLine();

                    Console.WriteLine(CharacterDoubling.GetCharacterDoubling(oneInputString, twoInputString));

                    break;

                case 3:
                    Console.WriteLine("Введите две строки");

                    oneInputString = Console.ReadLine();

                    twoInputString = Console.ReadLine();

                    Console.WriteLine(SumOfNumbers.GetSumOfNumbers(oneInputString, twoInputString));

                    break;

                case 4:

                    Console.WriteLine("Введите строку");

                    inputString = Console.ReadLine();

                    Console.WriteLine(RewerseToString.ReverseWords(inputString));

                    break;

                case 5:

                    var inputTextPath = "Files/Text.txt";

                    var outputTextPath = "Files/Numbers.txt";

                    inputString = File.ReadAllText(inputTextPath);

                    var phoneNumbers = TelephoneNumbers.GetTelephoneNumbers(inputString);

                    File.WriteAllLines(outputTextPath, phoneNumbers);

                    break;


                default:

                    Console.WriteLine("Введенно неверное значение");

                    StringMenu();

                    break;
            }
        }

        static void Main(string[] args)
        {
            StringMenu();
        }
    }
}