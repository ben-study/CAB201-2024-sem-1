namespace Week3;

public class ShoppingList
{
    static void ShoppingListActivity()
    {
        // Keep the following line intact 
        Console.WriteLine("===========================");

        Console.WriteLine("How many items are there?");
        string userInput = Console.ReadLine();
        int numItems = int.Parse(userInput);

        if (numItems > 0)
        {
            string[] items = new string[numItems];

            for (int i = 0; i < numItems; i++)
            {
                Console.WriteLine("Please enter an item:");
                userInput = Console.ReadLine();
                items[i] = userInput;
            }

            Array.Sort(items);
            Console.WriteLine(@"----------------------------
Your shopping list contains:
----------------------------");

            for (int i = 0; i < numItems; i++)
            {
                Console.WriteLine("Item {0}: {1}", i+1, items[i]);
            }
        }
        else
        {
            Console.WriteLine(@"----------------------------
Your shopping list contains:
----------------------------");
        }

        // Keep the following line intact
        Console.WriteLine("===========================");
    }
}