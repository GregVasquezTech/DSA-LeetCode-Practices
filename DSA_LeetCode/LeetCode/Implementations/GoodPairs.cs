using DSA_LeetCode.LeetCode.Interfaces;

namespace DSA_LeetCode.LeetCode.Implementations
{
    public class GoodPairs: IGoodPairs
    {
        public GoodPairs() { }
        public int[] arr;
        public int NumIdenticalPairs(int[] nums) 
        {
            int goodPairs = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = i+1; j < nums.Length; j++)
                {
                    if (nums[i] == nums[j])
                    { goodPairs++; }
                }
            }
            return goodPairs;
        }
    }
}
