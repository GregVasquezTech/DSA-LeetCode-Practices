using DSA_LeetCode.LeetCode.Interfaces;

namespace DSA_LeetCode.LeetCode.Implementations
{
    public class FindWordsContainingCharacter : IFindWordsContainingCharacter
    {
        public IList<int> FindWordsContaining(string[] words, char x)
        {
            IList<int> result = new List<int>();

            int i = 0;

            foreach (string word in words)
            {
                if (word.Contains(x)) {
                    result.Add(i);
                }
                i++;
            }

            return result; 
        }
    }
}
