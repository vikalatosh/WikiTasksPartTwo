namespace Task3
{
    public abstract class Animal
    {
        public int weight;
        public int amountOfFood;
        public string typeOfFood;

        public string Name { get; set; }

        public Animal(string name, int weight, int amountOfFood)
        {
            Name = name;
            this.weight = weight;
            this.amountOfFood = amountOfFood;
        }

        public abstract int food();
    }
}