using DSA_LeetCode.LeetCode.Interfaces;

namespace DSA_LeetCode.LeetCode.Implementations
{
    public class ArrayFromPermutation : IArrayFromPermutation
    {
        public int[] arr;
        public int[] BuildArray(int[] nums)
        {
            arr = new int[nums.Length];

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = nums[(nums[i])];
            }

            return arr;
        }
    }
}
