namespace Task3
{
    public abstract class Animal
    {
        public int weight;
        public int amountOfFood;
        public string typeOfFood;

        public string Name { get; set; }

        public Animal(string name, int weight)
        {
            Name = name;
            this.weight = weight;
        }

        public abstract int food();
    }
}