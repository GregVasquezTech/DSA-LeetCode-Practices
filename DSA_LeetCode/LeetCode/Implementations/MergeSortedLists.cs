using DSA_LeetCode.LeetCode.Interfaces;

namespace DSA_LeetCode.LeetCode.Implementations
{
    public class MergeSortedLists<T> : IMergeSortedLists<T>
    {
        public MergeSortedLists() { }
        public LinkedList<T> MergeTwoLists(LinkedList<T> list1, LinkedList<T> list2)
        {
            LinkedList<T> result = new LinkedList<T>();
            int i, j = 0;
            if (list1.Count == 0 && list2.Count == 0) {
                return result;
            }
            else if (list1.Count == 0)
            {
                return list2;
            }
            else if (list2.Count == 0)
            {
                return list1;
            }

            return result;
        }
    }
}
