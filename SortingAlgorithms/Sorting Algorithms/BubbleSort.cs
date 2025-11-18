namespace Sorting_Algorithms;

public class BubbleSort
{
    /// <summary>
    /// Iterate through all of the element while also iterating the previous element
    /// 
    /// </summary>
    /// <param name="nums"></param>
    /// <returns></returns>
    private int[] IterativeSort(int[] nums)
    {
        for (int i = 0; i < nums.Length; i++)
        {
            for (int j = 0; j < nums.Length - i - 1; j++)
            {
                if (nums[j] > nums[j + 1])
                    (nums[j], nums[j + 1]) = (nums[j + 1], nums[j]);
            }
        }
        return nums;
    }

    public int[] Sort(int[] nums) => RecursiveSort(nums, nums.Length);
    
    
    // N is nothing but iterative object
    // it will go for each element just like i in above method
    public int[] RecursiveSort(int[] nums, int n)
    {
        if (n == 1)
            return nums;

        for (int j = 0; j < n - 1; j++)
        {
            if (nums[j] > nums[j + 1])
                (nums[j], nums[j + 1]) = (nums[j + 1], nums[j]);
        }

        return RecursiveSort(nums, n - 1);
    }
}