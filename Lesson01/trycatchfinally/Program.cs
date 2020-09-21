using System;
using System.IO;

namespace trycatchfinally
{
    class Program
    {
        static void Main(string[] args)
        {
            TryCatchFinallyTest();
        }
        private static void TryCatchFinallyTest()
        {
            StreamReader sr = null;
            try
            {   // this file in on the laptop, not the desktop
                sr = File.OpenText("C:/Users/tiffi/data.txt");
                Console.WriteLine(sr.ReadToEnd());
            }
            catch (FileNotFoundException fnfe)
            {
                Console.WriteLine(fnfe.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                if (sr != null)
                {
                    sr.Close();
                }
            }
        }
    }
}
