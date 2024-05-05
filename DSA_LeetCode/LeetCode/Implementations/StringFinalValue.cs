using DSA_LeetCode.LeetCode.Interfaces;

namespace DSA_LeetCode.LeetCode.Implementations
{
    public class StringFinalValue : IStringFinalValue
    {
        public int FinalValueAfterOperations(string[] operations)
        {
            int finalValue = 0;
            foreach (string operation in operations) {
                if (operation.StartsWith('-') || operation.EndsWith('-')){
                    finalValue--;
                } else
                    finalValue++;
            }
            return finalValue;
        }
    }
}
