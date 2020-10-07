using System;

namespace Week6Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Good Morning!");
            Random rnd = new Random();
            int sum = 0;
            int[] array = new int[10];
            for(int i = 0; i < array.Length; i++)
            {
                array[i] = rnd.Next(1, 11);
            }
            foreach(int num in array)
            {
                Console.WriteLine(num);
                sum = sum + num;

                
            }
            Console.WriteLine($"Answer is {sum}");


        }
    }
}
