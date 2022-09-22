using System;

namespace Challenge_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int INPUT_TotalIterations = Int32.Parse(Console.ReadLine());
            int[] OUTPUT_Numbers = new int[INPUT_TotalIterations];

            for (int WORK_CurrentIteration = 0 ; WORK_CurrentIteration < INPUT_TotalIterations ; WORK_CurrentIteration++)
            {
                string INPUT_RAW_UserNumbers = Console.ReadLine();
                int[] INPUT_UserNumbers = INPUT_RAW_UserNumbers.Split(' ').Select(int.Parse).ToArray();

                Array.Sort(INPUT_UserNumbers);

                OUTPUT_Numbers[WORK_CurrentIteration] = INPUT_UserNumbers[1];
            }

            foreach(int OUTPUT_current in OUTPUT_Numbers)
            {
                Console.WriteLine(OUTPUT_current);
            }
        }
    }
}