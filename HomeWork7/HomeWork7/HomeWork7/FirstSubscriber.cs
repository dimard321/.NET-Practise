namespace HomeWork7
{
    class FirstSubscriber
    {
        public FirstSubscriber(Countdown cd) 
        {
            cd.Notify += GetMessage;
        }

        public void GetMessage(object sender, Message message)
        {
            Console.WriteLine("First subscribe get message");

            Console.WriteLine("Class sender: {0}; Message: {1}", sender.GetType().Name, message.MyMessage);
        }
    }
}
