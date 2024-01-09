namespace LionPlugin
{
    public class Lion
    {
        public string Name { get; set; } = "Lion";

        public void Add()
        {
            Console.WriteLine($"{Name} was added to the Zoo.");
        }

        public void Sound()
        {
            Console.WriteLine($"{Name} goes roar.");
        }
    }
}