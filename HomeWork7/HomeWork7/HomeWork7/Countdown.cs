using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace HomeWork7
{
    public class Countdown
    {
        public System.Timers.Timer Timer { get; set; }

        public delegate void Handler(object sender, Message message);

        public event Handler Notify;

        public Countdown(System.Timers.Timer timer)
        {
            if (timer.Interval < 0)
            {
                throw new ArgumentException("Interval < 0");
            }

            Timer = timer;

            Timer.Elapsed += timer_Elapsed;
        }

        public void timer_Elapsed(object sender, ElapsedEventArgs e)
        {
            Notify?.Invoke(this, new Message());

            Timer.Stop();
        }
    }
}
