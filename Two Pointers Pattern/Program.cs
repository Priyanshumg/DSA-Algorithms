namespace Two_Pointers_Pattern;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine(RemoveDuplicates(new int[] { 1, 2, 2, 3 }));
    }
    public static int RemoveDuplicates(int[] nums)
    {
        int slowPtr = 0;

        for (int fastPtr = 1; fastPtr < nums.Length; fastPtr++)
        {
            if (nums[fastPtr] != nums[slowPtr])
            {
                slowPtr++;
                nums[slowPtr] = nums[fastPtr];
            }        
        }
        return slowPtr + 1;
    }
}