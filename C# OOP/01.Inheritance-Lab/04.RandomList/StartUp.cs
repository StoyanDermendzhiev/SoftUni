using System;

namespace CustomRandomList
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            RandomList list = new RandomList();
            list.Add("Ivan");
            list.Add("Dragan");
            list.Add("Petkan");
            list.Add("Gosho");

            Console.WriteLine(list.RandomString());
        }
    }
}
