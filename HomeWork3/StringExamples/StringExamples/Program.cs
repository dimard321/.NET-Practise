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
                "4. Развернуть все слова во входной строке\n" +
                "5. Считать номера телефонов из файла\n");

            var function = (LaunchStringMenu)int.Parse(Console.ReadLine());

            switch (function)
            {
                case LaunchStringMenu.AverageLength:

                    Console.WriteLine("Введите строку");

                    var inputString = Console.ReadLine();

                    Console.WriteLine(AverageWordLength.GetAverageWordLength(inputString));

                    break;

                case LaunchStringMenu.DoublingCharacters:

                    Console.WriteLine("Введите две строки");

                    string oneInputString = Console.ReadLine();

                    string twoInputString = Console.ReadLine();

                    Console.WriteLine(CharacterDoubling.GetCharacterDoubling(oneInputString, twoInputString));

                    break;

                case LaunchStringMenu.SumOfNumbers:

                    Console.WriteLine("Введите две строки");

                    oneInputString = Console.ReadLine();

                    twoInputString = Console.ReadLine();

                    Console.WriteLine(SumOfNumbers.GetSumOfNumbers(oneInputString, twoInputString));

                    break;

                case LaunchStringMenu.ExpandOfWords:

                    Console.WriteLine("Введите строку");

                    inputString = Console.ReadLine();

                    Console.WriteLine(RewerseToString.ReverseWords(inputString));

                    break;

                case LaunchStringMenu.ReadPhoneNumbers:

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