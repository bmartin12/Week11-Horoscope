using System;
using System.IO;

namespace Horoscope
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your horoscope sign");
            string userSign = Console.ReadLine();
            Console.WriteLine(GetHoroscope(userSign));
        }
        public static string[] ReadHoroScope()
        {

            string filePath = @"C:\Users\opilane\Sample\horoscope.txt";
            string[] dataFromFile = File.ReadAllLines(filePath);
            return dataFromFile;
        }
        public static string GetHoroscope(string userInput)
        {
            string[] horoscope = ReadHoroScope();
            string todayHoroscope = "";
         

            foreach (string elements in horoscope)
            {
                if (elements.Contains(userInput))
                {
                    todayHoroscope = elements;
                }
            }

            return todayHoroscope;
        }
    }
}
