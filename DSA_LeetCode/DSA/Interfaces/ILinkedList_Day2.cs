namespace DSA_LeetCode.DSA.Interfaces
{
    public interface ILinkedList_Day2<T>
    {
        public void Clear();
        public int Size();
        public int IndexOf(Object obj);
        public bool Contains(object obj);
        public bool IsEmpty();
        public void NewList(T element);
        public void Add(T element);
        public void AddFirt(T element); 
        public void AddLast(T element);
        public T PeekFirst();
        public T PeekLast();
        public T RemoveFirst();
        public T RemoveLast();
        public T Remove(LinkedListNode<T> node);
        public bool Remove(Object obj);
        public T RemoveAt(int index);
    }
}
