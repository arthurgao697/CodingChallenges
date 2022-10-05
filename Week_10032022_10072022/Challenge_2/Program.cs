using System;

namespace Challenge_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please Enter A Integer");

            string INPUT_RAW_UserInt = Console.ReadLine();
            int INPUT_UserInt = 0; 
            int.TryParse(INPUT_RAW_UserInt, out INPUT_UserInt);

            bool OUTPUT_Status = false;

            int WORK_IterationCounter = 1;
            int WORK_IterationTotal = 1;
            while (true)
            {
                WORK_IterationTotal = WORK_IterationTotal * WORK_IterationCounter;
                WORK_IterationCounter++;

                //Console.WriteLine(WORK_IterationTotal);

                if (WORK_IterationTotal > INPUT_UserInt)
                {
                    break;
                }
                if (WORK_IterationTotal == INPUT_UserInt)
                {
                    OUTPUT_Status = true;
                    break;
                }
            }

            Console.WriteLine(OUTPUT_Status);
        }
    }
}