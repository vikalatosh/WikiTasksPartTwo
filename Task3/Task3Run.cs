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
            Console.WriteLine("Введите 10 животных.");

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Если животное хищное - введите 1. Если животное травоядное - введите 2, " +
                                  "если животное всеядное - введите 3");
                int animalClass = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Введите имя животного.");
                string name = Console.ReadLine();
                Console.WriteLine("Введите вес животного.");
                int weight = Convert.ToInt32(Console.ReadLine());
                
                if (animalClass == 1)
                {
                    list.Add(new Predator(name, weight, 0));
                } else if (animalClass == 2)
                {
                    list.Add(new Herbivore(name, weight, 0));
                } else if (animalClass == 3)
                {
                    list.Add(new Omnivore(name, weight, 0));
                }
            }

            // list.Add(new Predator("tiger", 150, 0));
            // list.Add(new Predator("wolf", 90, 0));
            // list.Add(new Herbivore("elephant", 2500, 0));
            // list.Add(new Predator("hyena", 100, 0));
            // list.Add(new Predator("lion", 200, 0));
            // list.Add(new Omnivore("bear", 300, 0));

            foreach (Animal a in list)
            {
                a.Food();
                // идентификатор - это класс животного???? 
                Console.WriteLine($"{a}, {a.Name}, тип пищи - {a.typeOfFood}, количество - {a.amountOfFood} кг/день");
            }

            Console.WriteLine("-------------------------------------------");

            // a) Упорядочить всю последовательность животных по убыванию количества пищи.
            // При совпадении значений – упорядочивать данные по алфавиту по имени.
            // Вывести идентификатор животного, имя, тип и количество потребляемой пищи для всех элементов списка.
            var sortedAnimals = from o in list
                orderby o.amountOfFood descending, o.Name
                select o;
            foreach (Animal a in sortedAnimals)
            {
                Console.WriteLine($"{a}, {a.Name}, тип пищи - {a.typeOfFood}, количество - {a.amountOfFood} кг/день");
            }

            Console.WriteLine("-------------------------------------------");

            // b) Вывести первые 5 имен животных из полученного списка в пункте а.
            var result = sortedAnimals.Take(5);
            foreach (var i in result)
                Console.WriteLine(i.Name);
            Console.WriteLine("-------------------------------------------");

            // c) Вывести последние 3 идентификатора животных из полученного cписка в пункте а.
            result = sortedAnimals.Skip(sortedAnimals.Count() - 3);
            foreach (var i in result)
                Console.WriteLine(i.Name);
            Console.WriteLine("-------------------------------------------");
        }
    }
}