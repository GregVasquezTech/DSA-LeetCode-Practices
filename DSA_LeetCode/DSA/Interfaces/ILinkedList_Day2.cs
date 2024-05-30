namespace DSA_LeetCode.DSA.Interfaces
{
    public interface ILinkedList_Day2<T>
    {
        void Clear();
        int Size();
        int IndexOf(Object obj);
        bool Contains(object obj);
        bool IsEmpty();
        void NewList(T element);
        void Add(T element);
        void AddFirt(T element); 
        void AddLast(T element);
        T PeekFirst();
        T PeekLast();
        T RemoveFirst();
        T RemoveLast();
        bool Remove(Object obj);
        T RemoveAt(int index);
    }
}
