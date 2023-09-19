using NLog;
using StringConverterLibrary;

namespace UI
{
    public class Program
    {
        private static readonly NLog.ILogger logger = LogManager.GetCurrentClassLogger();

        static void Main(string[] args)
        {

            var str = new StringConverter(logger);

            var inputString = "645";

            try
            {
                str.Validate(inputString);

                int result = str.ConvertToInt(inputString);

                Console.WriteLine($"Результат: {result}");
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);

                return;
            }
            catch (OverflowException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (Exception ex)
            {
                logger.Error($"Необработанное исключение: {ex.Message}");

                Console.WriteLine($"Необработанное исключение: {ex.Message}");

                return;
            }
        }
    }
}