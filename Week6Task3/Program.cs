using System;
using System.Reflection.PortableExecutable;

namespace Week6Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Good Morning!");
            Random rnd = new Random();
            int[] array = new int[10];
            for(int i = 0; i < array.Length; i++)
            {
                array[i] = rnd.Next(1, 11);
            }
            foreach(int num in array)
            {
                Console.WriteLine(num);
            }

            int min = array[0];
            int max = array[0];

            for(int i = 0; i < array.Length; i++)
            {
                if(min > array[i])
                {
                    min = array[i];
                }
                if(max < array[i])
                {
                    max = array[i];
                }
            }
            Console.WriteLine($"Max: {max}");
            Console.WriteLine($"Min: {min}");
        }
    }
}
