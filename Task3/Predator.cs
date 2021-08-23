namespace Task3
{
    public class Predator : Animal
    {
        public Predator(string name, int weight, int amountOfFood) : base(name, weight, amountOfFood)
        {
            Name = name;
            this.weight = weight;
            this.amountOfFood = amountOfFood;
        }

        public override int food()
        {
            amountOfFood = weight / 15;
            typeOfFood = "мясо/рыба";
            return amountOfFood;
        }
    }
}