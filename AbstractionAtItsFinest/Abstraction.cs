using System;
using System.Collections.Generic;


namespace AbstractionAtItsFinest
{
   public class Abstraction
    {
        static void Main()
        {
            var list = new List<int> { 5, 6, 7, 10 };
            Print(list);

            var myList = new MyList<int>();
            //  Print(myList);

            Console.WriteLine();

            SortedSet<int> setOfInts = new SortedSet<int> { 10, 11, 15 };
            Print(setOfInts);

            Stack<int> stackOfInts = new Stack<int>();
            stackOfInts.Push(18);
            stackOfInts.Push(29);


            Console.WriteLine(
                );
            Print(stackOfInts);
        }

        public static void Print(IEnumerable<int> numbers)
        {
            foreach (var number in numbers)
            {
                Console.WriteLine(number);
            }
        }
    }
}
