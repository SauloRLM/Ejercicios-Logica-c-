using System;

class Array
{
    static void Main(string[] args)
    {
        // Create a new array of integers
        int[] numbers = new int[3];

        // Add elements to the array
        numbers[0] = 1;
        numbers[1] = 2;
        numbers[2] = 3;

        //Declarar una variable con un valor específico
        int age = 25;
        string name = "John";
        bool isStudent = true;


        //Declarar una variable sin asignar un valor inicial:
        int x;
        string y;
        bool z;

        // Iterate through the array and display the elements
        for (int i = 0; i < numbers.Length; i++)
        {
            Console.WriteLine(numbers[i]);
        }
        Console.ReadLine();


        //Array.Sort(): Este método ordena los elementos de un arreglo en orden ascendente. Este método utiliza el algoritmo de ordenamiento rápido (QuickSort) y es capaz de ordenar arreglos de cualquier tipo de datos.
        int[] numbers = { 5, 3, 2, 8, 1 };
        Array.Sort(numbers);

        //Array.Reverse(): Este método invierte el orden de los elementos de un arreglo.
        Array.Reverse(numbers);

        //Array.BinarySearch(): Este método busca un elemento específico en un arreglo ordenado y devuelve su índice. Si el elemento no se encuentra en el arreglo, devuelve un número negativo.
        Array.Sort(numbers);
        int index = Array.BinarySearch(numbers, 3);        
    }
}