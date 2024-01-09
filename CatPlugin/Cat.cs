namespace CatPlugin
{
    public class Cat
    {
        public string Name { get; set; } = "Cat";

        public void Add()
        {
            Console.WriteLine($"{Name} was added to the Zoo.");
        }

        public void Sound()
        {
            Console.WriteLine($"{Name} goes meow.");
        }
    }
}