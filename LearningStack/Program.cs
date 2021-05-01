using System;
using System.Collections.Generic;

namespace LearningStack
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<String> pancakes = new Stack<string>();

            pancakes.Push("First Pancake made");
            pancakes.Push("Second Pancake made");
            pancakes.Push("Third Pancake made");

            foreach (var pancake in pancakes){
                Console.WriteLine(pancake);
                Console.WriteLine(pancakes.Peek());
            }

            Console.WriteLine(".................................");
            Console.WriteLine(pancakes.Pop());
            Console.WriteLine(pancakes.Peek());
            Console.WriteLine(pancakes.Pop());
            Console.WriteLine(pancakes.Peek());

        }
    }
}
