namespace Sorting_Algorithms;

public class BubbleSort
{
    /// <summary>
    /// Iterate through all of the element while also iterating the previous element
    /// 
    /// </summary>
    /// <param name="nums"></param>
    /// <returns></returns>
    public int[] Sort(int[] nums)
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
}