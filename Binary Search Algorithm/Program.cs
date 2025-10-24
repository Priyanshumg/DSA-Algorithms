namespace Binary_Search_Algorithm;
class Program
{
    /// <summary>
    /// Returns Index of the target, Work for both sorted and unsorted array.
    /// Works Best with sorted array while performance degrades with unsorted array
    /// </summary>
    /// <param name="array"></param>
    /// <param name="targetValue"></param>
    public static void BinarySearch(int[] array, int targetValue)
    {
        array = array.Distinct().OrderBy(i => i).ToArray();
        if (array[0] == targetValue) Console.WriteLine($"Target is at first index 0");
        else if (array[array.Length - 1] == targetValue) Console.WriteLine($"Target is at Last Index {array.Length  - 1}");
        int start = 0, end = array.Length - 1;
        while (start <= end)
        {
            int mid = (start + end) / 2;
            if (targetValue == array[mid])
            {
                Console.WriteLine($"Target is at {mid}");
                return;
            }
            else if (targetValue >= array[mid]) start = mid + 1;
            else end = mid - 1;
        }
        Console.WriteLine("Target Could not be found");
    }
    static void Main(string[] args)
    {
        BinarySearch(new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11 }, 4);
        BinarySearch(new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11 }, 15);
        BinarySearch(new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11 }, 10);
        BinarySearch(new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11 }, 12);
        BinarySearch(new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11 }, 11);
    }
}