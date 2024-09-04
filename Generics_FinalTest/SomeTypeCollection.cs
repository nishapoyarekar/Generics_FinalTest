using System;
using System.Collections.Generic;
using System.Linq;

public class SomeTypeCollection<T> where T : struct, IComparable<T>
{
    // Private generic collection
    private List<T> _items = new List<T>();

    // Method to add items to the private collection
    public void AddItem(T item)
    {
        _items.Add(item);
    }

    // Method that returns an item from the list by index
    public T GetItem(int index)
    {
        return _items[index];
    }

    // Method that returns a sorted collection in descending order
    public List<T> GetSortedItemsDescending()
    {
        return _items.OrderByDescending(item => item).ToList();
    }
}
