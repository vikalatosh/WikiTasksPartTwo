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
    }
}