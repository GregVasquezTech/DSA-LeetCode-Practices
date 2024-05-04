using DSA_Practices.LeetCode.Interfaces;

namespace DSA_Practices.LeetCode.Implementations
{
    public class ConcatentationArray: IConcatenationArray
    {
        public int[] arr;
        public ConcatentationArray() { }
        public int[] GetConcatenation(int[] nums)
        {
            int n = nums.Length;
            int index = 0;
            int[] ans = new int[n * 2];
            for (int i = 0; i < ans.Length; i++)
            {
                if (i == n)
                {
                    index = 0;
                }
                ans[i] = nums[index];
                index++;
            }
            return ans;
        }
    }
}
