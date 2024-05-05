using DSA_LeetCode.DSA.Interfaces;

namespace DSA_LeetCode.DSA.Implementations
{
    public class LinkedList_Day2<T> : ILinkedList_Day2<T>
    {
        private int size = 0;
        private LinkedListNode<T> head = null;
        private LinkedListNode<T> tail = null;

        public LinkedList_Day2() { }
        public class LinkedListNode<T>
        {
            public T? Data { get; set; }
            public LinkedListNode<T> Prev { get; set; }
            public LinkedListNode<T> Next { get; set; }
            public LinkedListNode(T data, LinkedListNode<T> prev, LinkedListNode<T> next)
            {
                Data = data;
                Prev = prev;
                Next = next;
            }
            public override string ToString()
            {
                return Data.ToString();
            }
        }
        public void Clear()
        {
            LinkedListNode<T> trav = head;
            while (trav != null)
            {
                LinkedListNode<T> next = trav.Next;
                trav.Prev = trav.Next = null;
                trav.Data = default(T);
                trav = next;
            }
            head = tail = trav = null;
            size = 0;
        }
        public int Size()
        {
            return size;
        }
        public bool IsEmpty()
        {
            return Size() == 0;
        }
        public void Add(T element)
        {
            AddLast(element);
        }
        public void NewList(T element)
        {
            head = tail = new LinkedListNode<T>(element, null, null);
        }
        public void AddFirt(T element)
        {
            if (IsEmpty())
                NewList(element);
            else
            {
                head.Prev = new LinkedListNode<T>(element, null, head);
                head = head.Prev;
            }
            size++;
        }
        public void AddLast(T element)
        {
            if (IsEmpty())
                NewList(element);
            else
            {
                tail.Next = new LinkedListNode<T>(element, tail, null);
                tail = tail.Next;
            }
            size++;
        }
        public T PeekFirst()
        {
            if (IsEmpty())
                throw new Exception("Empty list");
            return head.Data;
        }
        public T PeekLast()
        {
            if (IsEmpty())
                throw new Exception("Empty list");
            return tail.Data;
        }
        public void RemoveFirst(T element)
        {

        }
        public void RemoveLast(T element)
        {

        }
        public bool Remove(T element)
        {
            return false;
        }
    }
}
