using DSA_LeetCode.DSA.Interfaces;

namespace DSA_LeetCode.DSA.Implementations
{
    public class Array_Day1: IArray_Day1
    {
        public int[] arr;
        private int len = 0;
        private int capacity = 0;

        public Array_Day1()
        {
            len = 16;
            capacity = 16;
        }
        public Array_Day1(int capacity)
        {
            if (capacity < 0)
                throw new Exception($"Illegal Capacity {capacity}");

            this.capacity = capacity;
            arr = new int[capacity];
            len = capacity;
        }
        public int Size()
        {
            return arr.Length;
        }
        public bool IsEmpty()
        {
            if (capacity < 0)
                return true;
            return false;
        }
        public int IndexOf(int element)
        {
            if (capacity < 0)
                throw new Exception($"Illegal Capacity {capacity}");

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == element) return i;
            }
            return -1;
        }
        public bool Contains(int element)
        {
            return IndexOf(element) != -1;
        }

        public int[] Add(int element)
        {
            if (len >= capacity)
            {
                if (capacity < 0) capacity = 1;
                else capacity *= 2;
            }
            int[] tempArray = new int[capacity];
            for (int i = 0; i < arr.Length; i++)
            {
                tempArray[i] = arr[i];
            }
            arr = new int[capacity];
            arr = tempArray;

            arr[len++] = element;
            return arr;
        }
        public void RemoveAt(int index)
        {
            if (index < 0 || index >= arr.Length)
                throw new ArgumentOutOfRangeException("index");

            int[] tempArray = new int[capacity-1];

            for (int i = 0; i < tempArray.Length; i++)
            {
                if (i == index)
                {
                    arr[i] = 0;
                }
                else
                { tempArray[i] = arr[i]; }
            }
            len--;
            capacity--;
            arr = new int[capacity];
            arr = tempArray;
        }
        public bool Remove(int element)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i].Equals(element))
                {
                    RemoveAt(i);
                    return true;
                }
            }
            return false;

        }
        public void IterateArray()
        {
            if (arr.Length == 0)
                throw new Exception($"Illegal Capacity {capacity}");

            for (int i = 0; i < arr.Length; i++)
                Console.WriteLine(arr[i]);
        }
    }
}
