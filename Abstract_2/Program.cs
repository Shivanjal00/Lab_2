using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_2
{ 
    abstract class Animal
    {
        public string Name;
        public int Age;
        public Animal(string name, int age)
        {
            Name = name;
            Age = age;
        }
        public abstract void MakeSound();
    }

    class dog : Animal
    {
        public dog(string name, int age) : base(name, age)
        {
           
        }

        public override void MakeSound()
        {
            Console.WriteLine("Bhow Bhow!");
        }
    }

    class cat : Animal
    {
        public cat(string name, int age) : base(name, age)
        {
        }

        public override void MakeSound()
        {
            Console.WriteLine("Meow meow!");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            dog Dog = new dog("Buddy", 3);
            cat Cat = new cat("Whiskers", 2);

            Dog.MakeSound();
            Cat.MakeSound();
        }
    }
}
