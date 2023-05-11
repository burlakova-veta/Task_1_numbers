using System;
namespace csharptest
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[3];
            Console.WriteLine("Введите 3 целых числа");
            for (int i = 0; i < 3; i++)
            {
                numbers[i] = int.Parse(Console.ReadLine());
                
                if (numbers[i] < 0)
                {
                    numbers[i] = numbers[i] * numbers[i];
                }
                else if (numbers[i] > 0)
                {
                    numbers[i] = numbers[i] * numbers[i] * numbers[i];
                }
            }
            foreach (int num in numbers)
            {
                Console.Write(num + " ");
            }
        }
    }
}