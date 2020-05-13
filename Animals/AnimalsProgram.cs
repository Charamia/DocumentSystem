using System;
using System.Collections.Generic;
using System.Linq;

namespace Animals
{
    class AnimalsProgram
    {
        static void Main()
        {
           // var animal = new Animal();
            //animal.Name = "Pesho";

           // Console.WriteLine(animal);
           // Console.WriteLine(animal.Greet());

            var dog = new Dog();
            //Console.WriteLine(dog.Greet());

            var cat = new Cat();
            //Console.WriteLine(cat.Greet());

            var snake = new Snake();
            //Console.WriteLine(snake.Greet());

            var animals = new List<Animal>();
           // animals.Add(animal);
            animals.Add(snake);
            animals.Add(dog);
            animals.Add(cat);
            animals.Add(new Dog());
            animals.Add(new Dog());

            var collectionOfDogs = animals.Where(an => an is Dog);

            // foreach (var item in animals)
            //{
            //Console.WriteLine(item.Greet());


            //var someCat = (Cat)item; This will give me ana exception errror
            //someCat.Sleep();

            //If done in the way below it will record null in someCat variable

            //var someCat = item as Cat;

            //  Console.WriteLine(item.GetType().Name);


            //}
            foreach ( var animal in animals)
            {
                int legs = animal.GetNumberOfLegs();
               // Console.WriteLine(legs);

                try
                {
                    cat.Name = "Pesho";
                }
                catch (InvalidAnimalException ex)
                {

                    Console.WriteLine(ex.ErrorName);
                }
            }
        }
    }
}
