using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            RandomGenerate(random);

            //between 0 and 1
            Console.WriteLine(random.NextDouble());

            //shuffle a list using random
            List<People> peoples = new List<People>()
            {
                new People {FirstName = "John"},
                new People {FirstName ="Jake"},
                new People {FirstName ="Julian"},
                new People {FirstName ="Harry"},
                new People {FirstName ="Bruno"},
                new People {FirstName ="Natalia"},
            };

            var sortedPeople = peoples.OrderBy(x => x.FirstName);
            Console.WriteLine("\nSorted people");
            foreach(var people in sortedPeople)
            {
                Console.WriteLine(people.FirstName);
            }

            Console.WriteLine("\nShuffled People");
            var shuffledPeople = sortedPeople.OrderBy(x => random.Next());
            foreach(var people in shuffledPeople)
            {
                Console.WriteLine(people.FirstName);
            }
        }

        private static void RandomGenerate(Random random)
        {
            Console.WriteLine(random.Next(5,6));
        }

        public class People
        {
            public string FirstName { get; set; }   
        }
    }
}
