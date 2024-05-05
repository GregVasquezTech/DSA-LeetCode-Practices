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

            /*
             * 0, 3, 1, 4, 2, 5
             * we already assigned 0 so we start at index 1 in the for loop
             * 
             */

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
