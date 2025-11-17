namespace Sorting_Algorithms;

public class InsertionSort
{
    public int[] Sort(int[] nums)
    {
        for (int i = 1; i < nums.Length; i++)
        {
            int key = nums[i];
            int j = i - 1;

            while (j >= 0 && nums[j] > key)
            {
                nums[j + 1] = nums[j];
                j--;
            }

            nums[j + 1] = key;
        }
        return nums;
    }
}