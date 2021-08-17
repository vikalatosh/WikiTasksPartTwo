using System;
using System.Collections;

namespace Task3
{
    public class Task3Run
    {
        public static void Main(string[] args)
        {
            ArrayList list = new ArrayList();
            list.Add(new Herbivore("elephant", 2500));
            list.Add(new Predator("tiger", 150));
            list.Add(new Predator("lion", 200));
            list.Add(new Predator("wolf", 90));
            list.Add(new Predator("hyena", 100));
            list.Add(new Omnivore("bear", 300));

            foreach (Animal o in list)
            {
                o.food();
                // идентификатор - это класс животного???? 
                Console.WriteLine($"{o}, {o.Name}, тип пищи - {o.typeOfFood}, количество - {o.amountOfFood} кг/день");
            }
            Console.WriteLine("-------------------------------------------");
        }
    }
}