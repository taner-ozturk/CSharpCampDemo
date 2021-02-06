using System;
namespace OOP3
{
    class DatabaseLoggerService : IloggerService
    {
        public void Log()
        {
            Console.WriteLine("Veritabanına loglandı");
        }
    }
}
