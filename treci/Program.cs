using System;

namespace treci
{
    class Program
    {
        static void Main(string[] args)
        {
            Logger logger1 = Logger.GetInstance();
            Logger logger2 = Logger.GetInstance();

            logger1.Log("test");
            logger2.Log("test_opet"); //pisu u isti file, isti je path
        }
    }
}
