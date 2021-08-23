using System;

namespace Task3
{
    public class Herbivore : Animal
    {
        public Herbivore(string name, int weight, int amountOfFood) : base(name, weight, amountOfFood)
        {
            Name = name;
            this.weight = weight;
            this.amountOfFood = amountOfFood;
        }

        public override int Food()
        {
            amountOfFood = weight / 10;
            typeOfFood = "растения";
            return amountOfFood;
        }
        
        public int AnimalClass()
        {
            Console.WriteLine("Если животное хищное - введите 1. Если животное травоядное - введите 2, " +
                              "если животное всеядное - введите 3");
            int animalClass = Convert.ToInt32(Console.ReadLine());
            // Console.WriteLine("Введите имя животного.");
            // string name = Console.ReadLine();
            // Console.WriteLine("Введите вес животного.");
            // int weight = Convert.ToInt32(Console.ReadLine());
            // if (animalClass == 1)
            // {
            //     new Predator() 
            // }
            return animalClass;
        }
    }
}