using System;

namespace AbstractExample.Models
{
    public class Cow : Animal
    {
        public Cow(string name)
        {
            Name = name;
        }

        public Cow()
        {
            Name = "Bessie";
        }

        public override void MakeNoise()
        {
            Console.WriteLine($"{Name} says mooooooooooo!");
        }
        
        public override void Sleep()
        {
            Console.WriteLine("zZzZzZzZz...");
        }
    }
}