using System;

namespace EADAnimal
{

    public abstract class Mammal
    {
        public string Name { get; }

        protected Mammal(String name) => this.Name = name;

        abstract public void MakeSound();
    }
    public class Dog : Mammal
    {
    }
    public sealed class Cat : Mammal
    {

    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
