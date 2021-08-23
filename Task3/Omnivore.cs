namespace Task3
{
    public class Omnivore : Animal
    {
        public Omnivore(string name, int weight, int amountOfFood) : base(name, weight, amountOfFood)
        {
            Name = name;
            this.weight = weight;
            this.amountOfFood = amountOfFood;
        }

        public override int food()
        {
            amountOfFood = weight / 35;
            typeOfFood = "фрукты/овощи, мясо/рыба";
            return amountOfFood;
        }
    }
}