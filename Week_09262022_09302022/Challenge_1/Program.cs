using System;

namespace Challenge_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please Enter Line of Ints");
            Console.WriteLine("EX: 26 96 15 52 21 10 5");

            string INPUT_RAW_UserNumbers = Console.ReadLine();
            int[] INPUT_UserNumbers = INPUT_RAW_UserNumbers.Split(' ').Select(int.Parse).ToArray();

            Array.Sort(INPUT_UserNumbers);

            int OUTPUT_LargestGap = 0;
            int OUTPUT_LargestGapBottom = 0;
            int OUTPUT_LargestGapTop = 0;

            for (int WORK_CurrentIteration = 0; WORK_CurrentIteration < (INPUT_UserNumbers.Count() - 1) ; WORK_CurrentIteration++)
            {
                int WORK_CurrentGap = INPUT_UserNumbers[WORK_CurrentIteration + 1] - INPUT_UserNumbers[WORK_CurrentIteration];
                if (WORK_CurrentGap > OUTPUT_LargestGap)
                {
                    OUTPUT_LargestGap = WORK_CurrentGap;
                    OUTPUT_LargestGapBottom = INPUT_UserNumbers[WORK_CurrentIteration];
                    OUTPUT_LargestGapTop = INPUT_UserNumbers[WORK_CurrentIteration + 1];
                }
            }

            Console.WriteLine("Largest Gap = " + OUTPUT_LargestGap);
            Console.WriteLine("   Between numbers " + OUTPUT_LargestGapBottom + " and " + OUTPUT_LargestGapTop);
        }
    }
}