using System;
using System.IO;

namespace ConsoleAppReadCSVFile
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            try
            {
                const string Path = @"C:\Users\zoete\Desktop\Prog4\ConsoleAppReadCSVFile\Prijzen_Jun19(beperkt).csv";
                string strCSV = File.ReadAllText(Path);
                Console.WriteLine(strCSV);
                Console.Read();
            }
            catch (Exception Ex)
            {
                Console.WriteLine("The file could not be read:");
                Console.WriteLine(Ex.Message);
            }
        }
    }
}