using System;
using System.Text.RegularExpressions;

namespace Challenge_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int INPUT_TotalIterations = Int32.Parse(Console.ReadLine());
            int[] OUTPUT_Sum = new int[INPUT_TotalIterations];

            for (int WORK_CurrentIteration = 0 ; WORK_CurrentIteration < INPUT_TotalIterations ; WORK_CurrentIteration++)
            {
                string INPUT_UserString = Console.ReadLine();
                string WORK_UserString = Regex.Replace(INPUT_UserString, "[^0-9 _]", "");
                WORK_UserString = Regex.Replace(WORK_UserString, @"\s", "");

                int WORK_CurrentSum = 0;
                for(int WORK_CurrentNumber = 0 ; WORK_CurrentNumber < WORK_UserString.Count() ; WORK_CurrentNumber++)
                {
                    WORK_CurrentSum = WORK_CurrentSum + WORK_UserString[WORK_CurrentNumber] - 48;
                }

                OUTPUT_Sum[WORK_CurrentIteration] = WORK_CurrentSum;
            }

            foreach(int OUTPUT_current in OUTPUT_Sum)
            {
                Console.WriteLine(OUTPUT_current);
            }
        }
    }
}