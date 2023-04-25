using System;
using System.ComponentModel;
using System.Diagnostics.Metrics;

public class Program
{
    public static void Main()
    {

    }
}

//Write a generic class that meets the following requirements:

//1)   That constrains a developer to only instantiate the class based on value types

public class ValueCollection<T> where T : struct
{
    private readonly List<T> collection;

    //2)   Contains a private generic collection

    public ValueCollection()
    {
        collection = new List<T>();
    }

    //3)   Has a method to add items to the private collection

    public void Add(T item)
    {
        collection.Add(item);
    }

    //4)   Has a method that will return an item from the list (e.g. item 3 or item 4 in the list)

    public T GetItem(int index)
    {
        if (index < 0 || index >= collection.Count)
        {
            throw new ArgumentOutOfRangeException(nameof(index));
        }
        return collection[index];
    }

    //5)   Has a method that returns a sorted collection with the items in descending order

    public List<T> GetSortedDescending()
    {
        var sortedCollection = new List<T>(collection);
        sortedCollection.Sort();
        sortedCollection.Reverse();
        return sortedCollection;
    }
}

