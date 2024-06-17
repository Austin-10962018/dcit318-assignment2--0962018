using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DCIT318Assignment2
{
    internal class Program
    {
        class Animal
        {
            public virtual void MakeSound()
            {
                Console.WriteLine("Some generic sound");
            }
        }

        class Dog : Animal
        {
            public override void MakeSound()
            {
                Console.WriteLine("Bark");
            }
        }

        class Cat : Animal
        {
            public override void MakeSound()
            {
                Console.WriteLine("Meow");
            }
        }

        class Sound
        {
            static void Main()
            {
                Animal animal = new Animal();
                animal.MakeSound();

                Dog dog = new Dog();
                dog.MakeSound();

                Cat cat = new Cat();
                cat.MakeSound();
            }
        }

    }
}
