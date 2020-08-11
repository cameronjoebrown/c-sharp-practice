using System;

namespace csharppractice
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Dog dog = new Dog();
            dog.bark(5);
        }
    }

    class Dog
    {
        public void bark(int numBarks)
        {
            for (int i = 0; i < numBarks; i++)
            {
                Console.WriteLine("Bark!");
            }
        }
    }
}
