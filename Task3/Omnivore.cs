using System;

namespace Task3
{
    public class Omnivore : Animal
    {
        public Omnivore(string name, int weight) : base(name, weight)
        {
            Name = name;
            this.weight = weight;
        }

        public override int food()
        {
            amountOfFood = weight / 35;
            typeOfFood = "фрукты/овощи, мясо/рыба";
            return amountOfFood;
        }
    }
}