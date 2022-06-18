using System;

namespace Singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            var logger = Logger.GetInstance();

            logger.Log("Logged this line.");
        }
    }
}
