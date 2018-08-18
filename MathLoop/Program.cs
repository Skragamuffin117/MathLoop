using System;

namespace MathLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            Program math = new Program();
            int output = math.Number();
            int number1 = output;
            for (int i = 1; i <= number1; i++)
            {
                output = i * output;
            }
            Console.WriteLine(output);
        }
        int Number()
        {
            int number = 0;
            bool dontrepeat = false;
            Console.WriteLine("Enter Number");
            do
            {
                string input = (Console.ReadLine());
                if (int.TryParse(input, out number))
                {
                    dontrepeat = true;
                }
                else
                {
                    Console.WriteLine("Invalid Entry");
                    Console.WriteLine("Enter Number");
                }
            } while (dontrepeat == false);
            return number;
        }
    }
}
