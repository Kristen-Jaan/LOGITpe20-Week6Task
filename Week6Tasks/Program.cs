using System;

namespace Week6Tasks
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Good Morning!");
            string[] superHeroes = { "Batman", "Santa", "Spongebob", "Thor", "Harry Potter" };
            string[] superVillains = { "Godzilla", "Voldemort", "Grinch", "Darth Vader", "T-1000" };
            string[] weapon = { "Banana", "Fork", "Keyboard", "Purse", "Jar of mud" };
            Random rnd = new Random();
            Console.WriteLine($"{ superHeroes[rnd.Next(0, superHeroes.Length)]} will fight {superVillains[rnd.Next(0, superVillains.Length)]} with a {weapon[rnd.Next(0, weapon.Length)]}");
        }
    }
}
