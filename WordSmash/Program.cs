using System;

namespace WordSmash
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This application will take two words and make them into one word.");
            Console.WriteLine("Please enter the first word:");
            string wordFirst = Console.ReadLine();
            Console.WriteLine("Please enter the second word:");
            string wordSecond = Console.ReadLine();

            char[] arrayFirst = wordFirst.ToCharArray();
            char[] arraySecond = wordSecond.ToCharArray();

            int arrayFirstHalf = 0;
            int arraySecondHalf = 0;

            if (arrayFirst.Length == 3 && arraySecond.Length == 3)
            {
                arrayFirstHalf = arrayFirst.Length - 1;
                arraySecondHalf = arraySecond.Length - 2;
            }
            else if (arrayFirst.Length == 3)
            {
                arrayFirstHalf = arrayFirst.Length - 1;
            }
            else if (arraySecond.Length == 3)
            {
                arraySecondHalf = arraySecond.Length - 1;
            }
            else
            {
                arrayFirstHalf = arrayFirst.Length / 2;
                arraySecondHalf = arraySecond.Length / 2;
            }

            Console.WriteLine("Smashed word:");

            for (int loop = 0; loop < arrayFirstHalf; loop++)
            {
                Console.Write(arrayFirst[loop]);
            }

            for (int loop = arraySecondHalf; loop < (arraySecond.Length); loop++)
            {
                Console.Write(arraySecond[loop]);
            }

            Console.ReadLine();
        }
    }
}
