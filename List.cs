using System;
using System.Collections.Generic;

class List
{
    static void Main(string[] args)
    {
        // Create a new List of integers
        List<int> numbers = new List<int>();

        // Add elements to the List
        numbers.Add(1);
        numbers.Add(2);
        numbers.Add(3);

        // Iterate through the List and display the elements
        foreach (int num in numbers)
        {
            Console.WriteLine(num);
        }

        // Remove an element from the List
        numbers.Remove(2);

        // Clear all elements from the List
        numbers.Clear();

        Console.ReadLine();

        //List.Sort(): Este método ordena los elementos de una lista en orden ascendente. Este método utiliza el 
        //algoritmo de ordenamiento rápido (QuickSort) y es capaz de ordenar arreglos de cualquier tipo de datos.
        List<int> numbers = new List<int> { 5, 3, 2, 8, 1 };
        numbers.Sort();

        //List.OrderBy(): Este método ordena los elementos de una lista utilizando LINQ y es capaz de ordenar arreglos de cualquier tipo de datos.
        var orderedList = numbers.OrderBy(x => x);

        //List.Reverse(): Este método invierte el orden de los elementos de una lista.
        numbers.Reverse();

        //List.Find(): Este método busca un elemento específico en una lista y devuelve el primer elemento que coincida con la condición especificada.
        int firstThree = numbers.Find(x => x == 3);

        //List.FindAll(): Este método busca todos los elementos que coincidan con una condición especificada y devuelve una nueva lista con esos elementos.
        List<int> evenNumbers = numbers.FindAll(x => x % 2 == 0);

        //List.Exists(): Este método determina si al menos un elemento de la lista cumple con una condición especificada.
        bool exist = numbers.Exists(x => x > 4);
    }
}