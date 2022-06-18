using System;
using System.IO;

namespace Singleton
{
    class Logger
    {
        private static Logger instance;
        private static string filepath;
        private Logger()
        {
            Filepath = "log.txt";
        }

        public static string Filepath { get { return filepath; } set { filepath = value; } }

        public static Logger GetInstance()
        {
            if (instance == null)
            {
                instance = new Logger();
            }
            return instance;
        }
        public void Log(string text)
        {
            File.AppendAllText(Filepath, "[" + DateTime.Now + "] " + text);
        }
    }

}
