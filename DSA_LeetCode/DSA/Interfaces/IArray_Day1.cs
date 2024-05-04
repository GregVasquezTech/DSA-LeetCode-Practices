namespace DSA_Practices.DSA.Interfaces
{
    internal interface IArray_Day1
    {
        public int Size();
        public bool IsEmpty();
        public int IndexOf(int element);
        public bool Contains(int element);
        public int[] Add(int element);
        public void RemoveAt(int index);
        public bool Remove(int element);
        public void IterateArray();
    }
}
