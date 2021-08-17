using System;

namespace Task3
{
    public class Herbivore : Animal
    {
        public Herbivore(string name, int weight) : base(name, weight)
        {
            Name = name;
            this.weight = weight;
        }

        public override int food()
        {
            amountOfFood = weight / 10;
            typeOfFood = "растения";
            return amountOfFood;
        }
    }
}