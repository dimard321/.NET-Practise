using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork7
{
    /// <summary>
    /// Класс, представляющий сообщение, которое отправляется подписчикам объекта Countdown.
    /// </summary>
    public class Message
    {
        /// <summary>
        /// Текст сообщения.
        /// </summary>
        public string MyMessage { get; set; }

        /// <summary>
        /// Конструктор класса Message, инициализирующий текст сообщения с текущей датой и временем.
        /// </summary>
        public Message() 
        {
            MyMessage += DateTime.Now.ToString(CultureInfo.InvariantCulture);

            MyMessage += "Message for subscribes";
        }
    }
}
