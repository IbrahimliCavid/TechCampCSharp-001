namespace Abstraction
{
    public class Program
    {
        static void Main(string[] args)
        {
            Animal dog = new Dog();
            Animal donkey = new Donkey();

            dog.AnimalSound();
            donkey.AnimalSound();

        }
    }

    public abstract class Animal
    {
        public abstract void AnimalSound();
    }

    public class Dog : Animal
    {
        public override void AnimalSound()
        {
            Console.WriteLine("Dog ham-ham sound make!");
        }
    }

    public class Donkey : Animal
    {
        public override void AnimalSound()
        {
            Console.WriteLine("Donkey ia-ia sound make!");
        }
    }




}
