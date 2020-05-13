using System;


namespace CTS
{
    class Program
    {
        static void Main()
        {
           
            var cat = new Cat();
            cat.Name = "Gosho";

            var anotherCat = new Cat();
            anotherCat.Name = "Gosho";

            bool areEqual = cat != anotherCat;

            var properties = cat.GetType().GetProperties();

            var propertiesTheSame = typeof(Cat).GetProperties();

            foreach (var prop  in propertiesTheSame)
            {
                Console.WriteLine(prop.Name + " " +  prop.GetValue(cat));
            }

            Console.WriteLine(cat.ToString());

        }
    }
}
