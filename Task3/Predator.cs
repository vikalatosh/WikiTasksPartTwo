using System;

namespace Task3
{
    public class Predator : Animal
    {
        public Predator(string name, int weight) : base(name, weight)
        {
            Name = name;
            this.weight = weight;
        }

        public override int food()
        {
            amountOfFood = weight / 15;
            typeOfFood = "мясо/рыба";
            return amountOfFood;
        }
    }
}