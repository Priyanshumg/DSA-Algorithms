using Sorting_Algorithms;

namespace Main;

class Program
{
    static void Main(string[] args)
    {
        // SelectionSort algo = new SelectionSort();
        // BubbleSort algo = new BubbleSort();
        // InsertionSort algo = new InsertionSort();
        MergeSort algo = new MergeSort();
        var question = new[] { 7, 4, 1, 5, 3 };
        Console.Write("Printing Question: ");
        foreach (var element in question)
            Console.Write(element + " ");

        Console.WriteLine();
        // Sorted 1, 3, 4, 5, 7
        Console.Write("Printing Result: ");
        var result = algo.Sort(question);
        foreach (var element in result)
            Console.Write(element + " ");
    }
}