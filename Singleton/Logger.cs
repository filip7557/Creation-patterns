using System;
using System.IO;

namespace Singleton
{
    class Logger
    {
        private static Logger instance;
        private string filepath;
        private Logger()
        {
            this.filepath = "log.txt";
        }

        public string Filepath { get { return filepath; } set { filepath = value; } }

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
