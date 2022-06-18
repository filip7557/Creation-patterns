using System;

namespace Builder
{
    class Program
    {
        static void Main(string[] args)
        {
            var notificationManager = new NotificationManager();
            var builder = new NotificationBuilder();
            var notification = builder.SetAuthor("Person")
                .SetLevel(Category.INFO)
                .SetColor(ConsoleColor.Green)
                .SetTitle("Notification title")
                .SetText("Notification text ....")
                .Build();

            notificationManager.Display(notification);
        }
    }
}
