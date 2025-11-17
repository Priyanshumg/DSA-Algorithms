namespace Sorting_Algorithms;

public class SelectionSort
{
    /// <summary>
    /// Iterates through each element and searches for the smallest element
    /// Once the smallest element is found it will swap the index
    /// Index Swapping = CurrentIndex swapped with smallest index
    /// and after this, move to next element 
    /// </summary>
    /// <param name="nums"></param>
    /// <returns></returns>
    public int[] Sort(int[] nums) {
        for (int i = 0; i < nums.Length; i++)
        {
            int smallestIndex = i;
            for (int j = i + 1; j < nums.Length; j++){
                // if (nums[i] > nums[j])
                //     (nums[i], nums[j]) = (nums[j], nums[i]);

                if (nums[j] < nums[smallestIndex])
                    smallestIndex = j;
            }
            (nums[i], nums[smallestIndex]) = (nums[smallestIndex], nums[i]);
        }
        return nums;
    }
}
