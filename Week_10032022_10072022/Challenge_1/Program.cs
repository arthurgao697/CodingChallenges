using System;
using System.Text.RegularExpressions;

namespace Challenge_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please Enter A Pin");

            string INPUT_UserPin = Console.ReadLine();

            bool OUTPUT_Status = true;
            if (INPUT_UserPin.Count() == 4 || INPUT_UserPin.Count() == 6)
            {
                if (INPUT_UserPin != Regex.Replace(INPUT_UserPin, "[^0-9 _]", ""))
                {
                    OUTPUT_Status = false;
                }
                if (INPUT_UserPin != Regex.Replace(INPUT_UserPin, @"\s", ""))
                {
                    OUTPUT_Status = false;
                }
            }
            else
            {
                OUTPUT_Status = false;
            }

            Console.WriteLine(OUTPUT_Status);
        }
    }
}