using System;
using System.Collections.Generic;
using System.Text;

namespace treci
{
    class Logger
    {
        private string filePath;
        private static Logger instance;
        private Logger(string filePath)
        {
            this.filePath = filePath;
        }

        public static Logger GetInstance()
        {
            if (instance == null)
                instance = new Logger("test.txt");
            return instance;
        }

        public string FilePath
        {
            get { return filePath; }
            set { filePath = value; }
        }

        public void Log(string message)
        {
            using (System.IO.StreamWriter fileWriter = new System.IO.StreamWriter(this.filePath, true))
            {
                fileWriter.WriteLine(message);
            }
        }
    }
}
