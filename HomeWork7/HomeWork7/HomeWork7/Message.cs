using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork7
{
    public class Message
    {
        public string MyMessage { get; set; }

        public Message() 
        {
            MyMessage += DateTime.Now.ToString(CultureInfo.InvariantCulture);

            MyMessage += "Message for subscribes";
        }
    }
}
