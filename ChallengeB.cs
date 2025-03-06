using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace ChallengeB
{
    internal class ChallengeB
    {
        static bool IsAlphabetical(string str)
        {
            foreach (char c in str)
            {
                if (!char.IsLetter(c))
                    return false;
            }
            return true;
        }
        static void Main(string[] args)
        {



            string[] lines = File.ReadAllLines(@"C:\Users\Acer\Desktop\random.txt");

            foreach (var line in lines)
            {
                var objects = line.Split(',');

           
                foreach (var obj in objects)
                {
                    var trimmed = obj.Trim(); 
                
                    if (int.TryParse(trimmed, out _))
                    {
                        Console.WriteLine($"'{trimmed}' is an Integer");
                    }
          
                    else if (double.TryParse(trimmed, out _))
                    {
                        Console.WriteLine($"'{trimmed}' is a Real Number");
                    }
                   
                    else if (IsAlphabetical(trimmed))
                    {
                        Console.WriteLine($"'{trimmed}' is an Alphabetical String");
                    }
                    else
                    {
                        Console.WriteLine($"'{trimmed}' is Alphanumeric");
                    }
                }
            }


        }
    }
}
