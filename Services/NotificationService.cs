using System;
using Module2HW3_4.Interfaces;

namespace Module2HW3_4.Services
{
    public class NotificationService : IShowMessage
    {
        public void ShowMessage(string message)
        {
            Console.WriteLine(message);
        }
    }
}
