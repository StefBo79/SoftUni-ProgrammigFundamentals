using System;

namespace _03._ExtractFile
{
    class Program
    {
        static void Main(string[] args)
        {
            string fullPath = Console.ReadLine();
            int lastindexOfPipe = fullPath.LastIndexOf('\\');
            int lastIndexOfDot = fullPath.LastIndexOf('.');

            string fileNameWithExtention = fullPath.Substring(lastindexOfPipe +1 , fullPath.Length - 1 - lastindexOfPipe);
            string ExtentionOnly = fullPath.Substring(lastIndexOfDot + 1, fullPath.Length - 1 - lastIndexOfDot);
            string[] fileNameWithOutExtention = fileNameWithExtention.Split('.');
            string fileName = fileNameWithOutExtention[0];

            Console.WriteLine($"File name: {fileName}");
            Console.WriteLine($"File extension: {ExtentionOnly}");
        }
    }
}
