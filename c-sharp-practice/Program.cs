using System;

namespace csharppractice
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int numBarks = 5;
            Dog dog = new Dog();
            dog.bark(numBarks);
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
