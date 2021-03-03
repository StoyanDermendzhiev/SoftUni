using System;

namespace _04.PizzaCalories
{
    public class StartUp
    {
        static void Main(string[] args)
        {

            try
            {
                string pizzaName = Console.ReadLine()
                       .Split(" ", StringSplitOptions.RemoveEmptyEntries)[1];

                string[] doughInfo = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

                Pizza pizza = new Pizza(pizzaName, new Dough(doughInfo[1].ToLower(), doughInfo[2].ToLower(), int.Parse(doughInfo[3])));

                string input = Console.ReadLine();

                while (input != "END")
                {
                    string[] toppingInfo = input.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                    Topping topping = new Topping(toppingInfo[1], int.Parse(toppingInfo[2]));
                    pizza.AddTopping(topping);

                    input = Console.ReadLine();
                }


                Console.WriteLine($"{pizza.Name} - {pizza.GetTotalCalories():f2} Calories.");
            }
            catch (Exception ex)
                when (ex is ArgumentException || ex is InvalidOperationException)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
