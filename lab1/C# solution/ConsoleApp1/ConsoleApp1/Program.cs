using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            // task 1
            int element = 4;
            var newlistOfNumbers1 = Singleton<int>(element);
            Console.WriteLine("List from one element: ");
            foreach (var el in newlistOfNumbers1)
            {
                Console.Write(el + " ");
            }
            Console.WriteLine();


            // task 2
            List<int> listOfNumbers2 = new List<int>();
            Console.WriteLine($"List is empty: { Null<int>(listOfNumbers2)}");
            

            // task 3
            List<int> listOfNumbers3 = new List<int>() { 1, 4, 5, 2, 1 };
            var newlistOfNumbers3 = Snoc<int>(listOfNumbers3, 5);
            Console.WriteLine("New listOfNumbers: ");
            foreach(var el in newlistOfNumbers3)
            {
                Console.Write(el + " ");
            }
            Console.WriteLine();


            // task 4
            List<int> listOfNumbers4 = new List<int>() { 1, 4, 5, 2, 1 };
            Console.WriteLine($"Length of listOfNumbers: { Length<int>(listOfNumbers4)}");
        }

        private static int Length<T>(List<T> list)
        {
            int counter = 0;

            foreach(var element in list)
            {
                counter++;
            }

            return counter;
        }

        private static List<T> Snoc<T>(List<T> list, T elementNeededToAdd)
        {
            list.Add(elementNeededToAdd);
            return list;
        }

        private static bool Null<T>(List<T> list)
        {
            int counter = 0;

            foreach (var element in list)
            {
                counter++;
            }

            return counter == 0;
        }

        private static List<T> Singleton<T>(T elementNeededToAdd)
        {
            List<T> list = new List<T>() { elementNeededToAdd };
            return list;
        }
    }
}
