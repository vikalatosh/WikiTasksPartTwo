using System;
using System.Collections.Generic;
using System.Linq;

namespace Task3
{
    public class Task3Run
    {
        public static void Main(string[] args)
        {
            List<Animal> list = new List<Animal>();
            list.Add(new Predator("tiger", 150, 0));
            list.Add(new Predator("wolf", 90, 0));
            list.Add(new Herbivore("elephant", 2500, 0));
            list.Add(new Predator("hyena", 100, 0));
            list.Add(new Predator("lion", 200, 0));
            list.Add(new Omnivore("bear", 300, 0));

            foreach (Animal a in list)
            {
                a.food();
                // идентификатор - это класс животного???? 
                Console.WriteLine($"{a}, {a.Name}, тип пищи - {a.typeOfFood}, количество - {a.amountOfFood} кг/день");
            }
            Console.WriteLine("-------------------------------------------");

            var sortedAnimals = from o in list
                                orderby o.amountOfFood descending, o.Name
                                select o;
            foreach (Animal a in sortedAnimals)
            {
                Console.WriteLine($"{a}, {a.Name}, тип пищи - {a.typeOfFood}, количество - {a.amountOfFood} кг/день");
            }
            Console.WriteLine("-------------------------------------------");

            var result = sortedAnimals.Take(5);
            foreach (var i in result)
                Console.WriteLine(i.Name);
            Console.WriteLine("-------------------------------------------");

            result = sortedAnimals.Skip(sortedAnimals.Count() - 3);
            foreach (var i in result)
                Console.WriteLine(i.Name);
            Console.WriteLine("-------------------------------------------");
        }
    }
}