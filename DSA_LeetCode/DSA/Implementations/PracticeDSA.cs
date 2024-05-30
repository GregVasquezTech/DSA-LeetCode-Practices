using static System.Runtime.InteropServices.JavaScript.JSType;

namespace DSA_LeetCode.DSA.Implementations
{
    public class PracticeDSA<T>
    {
        private int size = 0;
        private LinkedListNode<T> head = null;
        private LinkedListNode<T> tail = null;

        public PracticeDSA() { }

        public class LinkedListNode<S> {

            public T data;
            public LinkedListNode<T> Prev { get; set; }
            public LinkedListNode<T> Next { get; set; }

            public LinkedListNode(T data, LinkedListNode<T> prev, LinkedListNode<T> next) { 
                data = data;
                Prev = prev;
                Next = next;
            }
            public override string ToString()
            {
                return data.ToString();
            }
        }
        public void Add(T element)
        {
            AddLast(element);
        }

        public void AddFirt(T element)
        {
            if (IsEmpty())
                NewList(element);

            else
            {
                LinkedListNode<T> newHead = head;
                newHead.Next = head;
                newHead.data = element;

                head.Prev = newHead;
            }

            size++;
        }

        public void AddLast(T element)
        {
            if(IsEmpty())
                NewList(element);
            else
            {
                tail.Next = new LinkedListNode<T>(element, tail, null);
                tail = tail.Next;
            }
            size++;
        }

        public void Clear()
        {
            if (IsEmpty())
                throw new Exception("Empty List");

            LinkedListNode<T> trav;

            for (trav = head; trav != null; trav = trav.Next)
            {
                LinkedListNode<T> tempNext = trav.Next;
                trav.Prev = null;
                trav.data = default;
                trav.Next = null;
            }

            head = tail = trav = null;
            size = 0;
        }

        public bool Contains(object obj)
        {
            
            return IndexOf(obj) != -1;
        }

        public int IndexOf(object obj)
        {   
            if (IsEmpty())
                return -1;

            int i = 0;
            LinkedListNode<T> trav;

            if(obj == null)
            {
                for (trav = head; trav != null; trav = trav.Next)
                {
                    if (obj.Equals(trav.data))
                    {
                        return i;
                    }
                }
            }
            else
            {
                for (trav = head; trav != null; trav = trav.Next ) { 
                    if (obj.Equals(trav.data))
                    {
                        return i;
                    }
                }
            }

            return -1;
        }

        public bool IsEmpty()
        {
            return size == 0;
        }

        public void NewList(T element)
        {
            head = tail = new LinkedListNode<T> (element, null, null);
        }

        public T PeekFirst()
        {
            if (IsEmpty())
                throw new Exception("Empty List");
            return head.data;
        }

        public T PeekLast()
        {
            if (IsEmpty())
                throw new Exception("Empty List");
            return tail.data;
        }

        public bool Remove(object obj)
        {
            if (IsEmpty())
                throw new Exception("Empty List");


            return false;
        }

        public T RemoveAt(int index)
        {
            if (index < 0 || IsEmpty() || index >= size) {
                throw new Exception("Out of bounds!");
            }

            int i = 0;
            LinkedListNode<T> trav;

            for (trav = head; trav != null; trav = trav.Next)
            {
                if (i == index)
                {
                    return trav.data;
                }
                i++;
            }
            return trav.data;
        }

        public T RemoveFirst()
        {
            if (IsEmpty())
                throw new Exception("Out of bounds");

            LinkedListNode<T> newHead = head.Next;
            newHead.Prev = null;

            head = head.Prev = head.Next = null;
            head.data = default(T);

            size--;

            return newHead.data;
        }

        public T RemoveLast()
        {
            if (IsEmpty())
                throw new Exception("Out of bounds!");

            LinkedListNode <T> newTail = tail.Prev;

            newTail.Next = null;
            tail = tail.Next = null;

            if(newTail.Prev == null)
            {
                head = newTail;
            }

            size--;

            return newTail.data;
        }

        public int Size()
        {
            return size;
        }
    }
}
