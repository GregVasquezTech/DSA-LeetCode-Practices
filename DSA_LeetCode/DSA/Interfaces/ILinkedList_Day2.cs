namespace DSA_LeetCode.DSA.Interfaces
{
    public interface ILinkedList_Day2<T>
    {
        public void Clear();
        public int Size();
        public bool IsEmpty();
        public void NewList(T element);
        public void Add(T element);
        public void AddFirt(T element); 
        public void AddLast(T element);
        public T PeekFirst();
        public T PeekLast();
        public void RemoveFirst(T element);
        public void RemoveLast(T element);
        public bool Remove(T element);
    }
}
