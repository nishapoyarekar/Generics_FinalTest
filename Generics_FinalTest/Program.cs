// See https://aka.ms/new-console-template for more information

public class Program
{
    static void Main()
    {
        // Create instance of SomeTypeCollection with int
        SomeTypeCollection<int> collection = new SomeTypeCollection<int>();

        // Add items
        collection.AddItem(55);
        collection.AddItem(10);
        collection.AddItem(10);

        // Retrieve an item by index
        Console.WriteLine("Item at index 1: " + collection.GetItem(1)); // Output: 10

        // Get sorted items in descending order
        List<int> sortedItems = collection.GetSortedItemsDescending();
        Console.WriteLine("Sorted items (descending): " + string.Join(", ", sortedItems)); // Output: 55,10,10
    }
}
