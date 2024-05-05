using DSA_LeetCode.LeetCode.Interfaces;

namespace DSA_LeetCode.LeetCode.Implementations
{
    public class ShuffleArray : IShuffleArray
    {
        public int[] Shuffle(int[] nums, int n)
        {
            int i = 1;
            int j = n;
            int[] tempArray = new int[nums.Length];

            tempArray[0] = nums[0];
            for (int k = 1;  k < nums.Length; k++)
            {
                if (k%2 == 1)
                    tempArray[k] = nums[j++];
                else
                    tempArray[k] = nums[i++];
            }
            return tempArray;
        }
    }
}
