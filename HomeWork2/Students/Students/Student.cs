using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Students
{
    /// <summary>
    /// Класс Student
    /// </summary>
    internal class Student
    {
        /// <summary>
        /// Принимает и отдает полное имя и email
        /// </summary>
        public string FullName { get; set; }
        public string Email { get; set; }

        /// <summary>
        /// Конструктор класса Student, который принимает email и возвращает полное имя
        /// </summary>
        /// <param name="email">почта</param>
        public Student(string email)
        {
            Email = email;

            FullName = ConvertToFullName(email);
        }

        /// <summary>
        /// Конструктор класса Student, который принимает имя и фамилию, а возвращает email и полное имя
        /// </summary>
        /// <param name="name">имя</param>
        /// <param name="surname">фамилия</param>
        public Student(string name, string surname) 
        {
            FullName = name + " " + surname;

            Email =  ConvertToEmail(name, surname);       
        }

        /// <summary>
        /// Переопределенный метод equals сравнивает по почте 
        /// </summary>
        /// <param name="obj">объект</param>
        /// <returns>true - объекты равны, false - не равны</returns>
        public override bool Equals(object obj)
        {
           if (obj == null || GetType() != obj.GetType())
                return false;

           var s = (Student)obj;

            return Email == s.Email;
        }

        /// <summary>
        /// Назначает почте хеш код
        /// </summary>
        /// <returns>возвращает хеш код</returns>
        public override int GetHashCode()
        {
            return Email.GetHashCode();
        }

        /// <summary>
        /// Извлечение полного имени из email
        /// </summary>
        /// <param name="email">почта</param>
        /// <returns>полное имя</returns>
        public string ConvertToFullName(string Email)
        {
           //извлечение имени из почты
   
            char dot = '.';

            char at = '@';

            int indexOfDot = Email.IndexOf(dot);

            string firstName = Email.Substring(0, indexOfDot);

            string tempFirstName = firstName.ToUpper();

            tempFirstName = tempFirstName.Substring(0, 1);

            firstName = firstName.Substring(1);

            firstName = tempFirstName + firstName;

            // извлечение фамилии из почты

            string newEmail = Email.Substring(indexOfDot + 1);

            int indexOfDotTwo = newEmail.IndexOf(dot);

            int indexOfAt = newEmail.IndexOf(at);

            string lastName = Email.Substring(indexOfDot + 1, indexOfAt);

            string tempLastName = lastName.ToUpper();

            tempLastName = tempLastName.Substring(0, 1);

            lastName = lastName.Substring(1);

            lastName = tempLastName + lastName;

            return FullName = firstName + " " + lastName;
        }

        /// <summary>
        /// Переобразует полное имя в почту
        /// </summary>
        /// <param name="name"> имя</param>
        /// <param name="surname">фамилия</param>
        /// <returns>почту</returns>
        public string ConvertToEmail(string name, string surname)
        {
            name = name.ToLower();

            surname = surname.ToLower();

            string email = name.Insert(name.Length, ".");

            email = email.Insert(email.Length, surname);
           
            email = email.Insert(email.Length, "@mail.ru");

            return email;
        }
    }
}
