using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace ChallengeA
{
    internal class ChallengeA
    {
        static string randomAlphabetical(int length = 10)
        {
            var random = new Random();
            var chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz";
            return new string(Enumerable.Repeat(chars, length)
        .Select(s => s[random.Next(s.Length)]).ToArray());
        }

        static double randomRealNumber()
        {
            var random = new Random();
            double realNumber = random.NextDouble() * 50;
            return Math.Round(realNumber);

        }
        static int randomInt()
        {
            var random = new Random();
            int intNumber = random.Next(100);
            return intNumber;
        }
        static string randomAlphanumerics(int length = 10)
        {
            var random = new Random();
            var chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
            return new string(Enumerable.Repeat(chars, length)
        .Select(s => s[random.Next(s.Length)]).ToArray());
        }

        static void randomAll()
        {
            string alphabetical = randomAlphabetical();
            double realNumber = randomRealNumber();
            int integer = randomInt();
            string alphanumeric = randomAlphanumerics();

            string fileDestination = @"C:\Users\Acer\Desktop\random.txt";
            string infoText = alphabetical + "," + realNumber + "," + integer + "," + alphanumeric;
            File.WriteAllText(fileDestination, infoText);
        }



        static void Main(string[] args)
        {
            randomAll();


        }
    }
}
