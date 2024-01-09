namespace DogPlugin
{
    public class Dog
    {
        public string Name { get; set; } = "Dog";

        public void Add()
        {
            Console.WriteLine($"{Name} was added to the Zoo.");
        }

        public void Sound()
        {
            Console.WriteLine($"{Name} goes vuf.");
        }
    }
}