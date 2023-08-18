namespace Students
{
    public class Program
    {
        /// <summary>
        /// Заполняет словарь рандомным предметами для каждого студента
        /// </summary>
        /// <param name="array">массив</param>
        /// <returns>название предмета</returns>
        static HashSet<string> GetRandomSubjects(string[] array)
        {
            var subjects = new HashSet<string>();

            var rnd = new Random();

            while (subjects.Count < 3)
            {
                string subject = array[rnd.Next(6)];

                subjects.Add(subject);
            }

            return subjects;
        }
        /// <summary>
        /// В основном методе создается словарь из студентов и их предметов
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            var subjects = new string[6] { "Maths", "History", "Literature", "Physics", "Biology", "PE" };

            var student1c2 = new Student("Vasya", "Pupkin");

            var student2c2 = new Student("Rima", "Tarakanova");

            var student3c2 = new Student("Kolya", "Bobrov");

            var student1c1 = new Student("vasya.pupkin@mail.ru");

            var student2c1 = new Student("rima.tarakanova@mail.ru");

            var student3c1 = new Student("kolya.bobrov@mail.ru");

            // словарь
            var studentSubjectDict = new Dictionary<Student, HashSet<string>>()
            {
                [student1c1] = GetRandomSubjects(subjects),

                [student2c1] = GetRandomSubjects(subjects),

                [student3c1] = GetRandomSubjects(subjects),

                [student1c2] = GetRandomSubjects(subjects),

                [student2c2] = GetRandomSubjects(subjects),

                [student3c2] = GetRandomSubjects(subjects)
            };

            // вывод на консоль студентов и их предметов из словаря
            foreach (var item in studentSubjectDict)
            {
                Console.WriteLine($"Имя студента: {item.Key.FullName}");

                Console.WriteLine("Название предметов:");

                foreach (var item2 in item.Value)
                {
                    Console.WriteLine($"{item2}\t");
                }

                Console.WriteLine();
            }
        }
    }
}