﻿using DSA_LeetCode.DSA.Interfaces;

namespace DSA_LeetCode.DSA.Implementations
{
    public class LinkedList_Day2<T> : ILinkedList_Day2<T>
    {
        private int size = 0;
        private LinkedListNode<T> head;
        private LinkedListNode<T>? tail;

        public LinkedList_Day2(LinkedListNode<T> _head, LinkedListNode<T> _tail) 
        {
            head = _head;
            tail = _tail;
        }
        public class LinkedListNode<U>
        {
            public T Data { get; set; }
            public LinkedListNode<T>? Prev { get; set; }
            public LinkedListNode<T>? Next { get; set; }
            public LinkedListNode(T data, LinkedListNode<T>? prev, LinkedListNode<T>? next)
            {
                Data = data;
                Prev = prev;
                Next = next;
            }
            public override string? ToString()
            {
                return Data?.ToString();
            }
        }
        public void Clear()
        {
            LinkedListNode<T>? trav = head;
            while (trav != null)
            {
                LinkedListNode<T>? next = trav.Next;
                trav.Prev = trav.Next = null;
                trav.Data = default;
                trav = next;
            }
            head = tail = trav = null;
            size = 0;
        }
        public int Size()
        {
            return size;
        }
        public int IndexOf(Object obj)
        {
            if(IsEmpty())
                return -1;

            int index = 0; 
            LinkedListNode<T> node = head;

            if(obj == null)
            {
                while(node != null)
                {
                    if (node.Data == null)
                        return index;
                    index++;
                }
            } else {
                while (!obj.Equals(node.Data))
                {
                    if (obj.Equals(node.Data))
                        return index;
                    index++;
                }
            }
            return -1;
        }
        public bool Contains(Object obj)
        {
            return IndexOf(obj) != -1;
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
                if (tail != null)
                {
                    tail.Next = new LinkedListNode<T>(element, tail, null);
                    tail = tail.Next;
                }
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
            if (tail != null)
                return tail.Data;
            return head.Data;
        }
        public T RemoveFirst()
        {
            if (IsEmpty())
                throw new Exception("Empty list");

            T? tempData = head.Data;
            if (head.Next != null)
            {
                head = head.Next;
                --size;

                head.Prev = null;
            }
            else
            {
                Clear();
            }

            return tempData;
        }
        public T RemoveLast()
        {
            if (IsEmpty())
                throw new Exception("Empty list");

            if (tail != null)
            {
                T tempData = tail.Data;
                tail = tail.Prev;
                --size;

                if (tail != null && tail.Prev == null)
                {
                    head = tail;
                    tail = null;
                }
                else
                {
                    if (tail != null)
                        tail.Next = null;
                }
                return tempData;
            }

            return head.Data;
        }
        public T Remove(LinkedListNode<T> node)
        {
            if (node.Prev == null)
                RemoveFirst();
            if (node.Next == null)
                RemoveLast();

            if (node is not null)
            {
                node.Next.Prev = node.Prev;
                node.Prev.Next = node.Next;

                T tempData = node.Data;

                node.Data = default(T);
                node = node.Next = node.Prev = null;

                --size;
                return tempData;
            }
            return node.Data = default;
        }
        public bool Remove(Object obj)
        {
            if (IsEmpty())
                throw new Exception("Empty List");

            LinkedListNode<T> trav = head;

            if(obj == null)
            {
                for (trav = head; trav != null; trav = trav.Next)
                {
                    if (trav.Data == null)
                    {
                        Remove(trav);
                        return true;
                    }
                }
            } else {
                for (trav = head; trav != null; trav = trav.Next)
                {
                    if (obj.Equals(trav.Data)){
                        Remove(trav);
                        return true;
                    }
                }
            }
            return false;
        }
        public T RemoveAt(int index)
        {
            if ((index < 0) || IsEmpty() || index >= Size())
                throw new Exception("Out of bounds!");

            LinkedListNode<T> trav;

            if (index < size / 2)
            {
                trav = head;
                for (int i = 0; i != index; i++)
                {
                    trav = trav.Next;
                }
            } else {
                trav = tail;
                for (int i = 0; i != index; i--)
                {
                    trav = trav.Prev;
                }
            }

            return Remove(trav);
        }
    }
}