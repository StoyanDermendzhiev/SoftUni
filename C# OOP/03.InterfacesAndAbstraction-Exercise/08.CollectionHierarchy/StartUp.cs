using System;
using System.Collections.Generic;
using _08.CollectionHierarchy.Models;

namespace _08.CollectionHierarchy
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();
            int removedOperationsNumber = int.Parse(Console.ReadLine());

            AddCollection addCollection = new AddCollection();
            List<int> addCollectionResults = new List<int>();

            AddRemoveCollection addRemoveCollection = new AddRemoveCollection();
            List<int> addRemoveCollectonAddResults = new List<int>();
            List<string> addRemoveCollectionRemoveResults = new List<string>();

            MyList myList = new MyList();
            List<int> myListAddResults = new List<int>();
            List<string> myListRemoveResults = new List<string>();

            foreach (var item in input)
            {
                addCollectionResults.Add(addCollection.Add(item));
                addRemoveCollectonAddResults.Add(addRemoveCollection.Add(item));
                myListAddResults.Add(myList.Add(item));
            }
            
            for (int i = 0; i < removedOperationsNumber; i++)
            {
                addRemoveCollectionRemoveResults.Add(addRemoveCollection.Remove());
                myListRemoveResults.Add(myList.Remove());
            }

            Console.WriteLine(string.Join(" ", addCollectionResults));
            Console.WriteLine(string.Join(" ", addRemoveCollectonAddResults));
            Console.WriteLine(string.Join(" ", myListAddResults));
            Console.WriteLine(string.Join(" ", addRemoveCollectionRemoveResults));
            Console.WriteLine(string.Join(" ", myListRemoveResults));
        }
    }
}
