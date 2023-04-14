using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Assignment3
{
    public class SLL : ILinkedListADT
    {
         public Node Head { get; set; }
         public Node Tail { get; set; }

        public int count { get; private set; }

       
        public void Add(User value, int index)
        {
            if (value == null) throw new ArgumentNullException("value");
            else if (index < 0) throw new ArgumentOutOfRangeException("index");
            else if (index >= count) throw new ArgumentOutOfRangeException("index");
            else if (index == 1) AddFirst(value);
            else if (index == count - 1) AddLast(value);
            else 
            { 
                Node currentNode = Head;
                for (int i = 0; i < count; i++)
                {
                    currentNode = currentNode.Next;
                    if (index == i) 
                    { 
                        Node newNode = new Node();
                        newNode.Value = value;
                        newNode.Next = currentNode.Next;
                        currentNode.Next = newNode;
                        count++;
                    }
                    else throw new IndexOutOfRangeException();
                }
            }
        }

        public void AddFirst(User value)
        {
            Node newNode = new Node();
            newNode.Value = value;
            Node head = this.Head;
            this.Head = newNode;
            newNode.Next= head;
            count++;
        }

        public void AddLast(User value)
        {
            Node newNode = new Node();
            newNode.Value = value;
            Tail.Next = newNode;
            Tail = newNode;
            count++;
        }

        public void Clear()
        {
            Head = null;
            Tail = null;
            count = 0;
        }

        public bool Contains(User value)
        {
            Node currentNode = Head;
            while (currentNode != null)
            {
                if (currentNode.Value == value)
                {
                    return true;
                }
                currentNode = currentNode.Next;
            }
            return false;
        }

        public int Count()
        {
            return  count;
        }

        public User GetValue(int index)
        {
            if (index < 0 || index >= count)
            {
                throw new ArgumentOutOfRangeException("index");
            }

            Node currentNode = Head;
            for (int i = 0; i < index; i++)
            {
                currentNode = currentNode.Next;
            }
            return currentNode.Value;
        }

        public int IndexOf(User value)
        {
            Node currentNode = Head;
            int index = 0;
            while (currentNode != null)
            {
                if (currentNode.Value == value)
                {
                    return index;
                }
                currentNode = currentNode.Next;
                index++;
            }
            return -1;
        }

        public bool IsEmpty()
        {
            if (Head == null) return true;
            else return false;
        }

        public void Remove(int index)
        {
            if (index < 0 || index >= count)
            {
                throw new ArgumentOutOfRangeException("index");
            }
            else if (index == 0) RemoveFirst();
            else if (index == count - 1) RemoveLast();
            else 
            {
                Node currentNode = Head;
                for (int i = 0; i <= index; i++)
                {
                    currentNode = currentNode.Next;
                    if(index == i)
                    {
                        currentNode.Next = currentNode.Next.Next;
                        count--;
                    }
                    else throw new IndexOutOfRangeException();
                }
            }
        }
        
        public void RemoveFirst()
        {

            if (Head == null)
            {
                throw new InvalidOperationException("Cannot remove from an empty list.");
            }

            else 
            {
                Head = Head.Next;
                count--;

                if (count <= 1) 
                {
                    Tail = null;
                }
            }
        }

        public void RemoveLast()
        {
            if (Tail == null)
            {
                throw new InvalidOperationException("Cannot remove from an empty list.");
            }

            else
            {
                Tail.Next = Tail;
                count--;

                if (count <= 1)
                {
                    Head = null;
                }
            }
        }
    

        public void Replace(User value, int index)
        {
            Node currentNode = Head;
            Node newNode = new Node();
            newNode.Value = value;
            if (index == 0)
            {
                if (Head == null)
                {
                    Head = newNode;
                }
                else
                {
                    newNode.Next = Head.Next;
                    Head = newNode;
                }
            }
            else if (index > 0 & index < count)
            {
                for (int i = 0; i < index - 1; i++)
                {
                    currentNode = currentNode.Next;
                }
                newNode.Next = currentNode.Next.Next;
                currentNode.Next = newNode;
                if (newNode.Next == null) Tail = newNode;
            }
            else throw new IndexOutOfRangeException();
        }
        int ILinkedListADT.Count()
        {
            return count;
        }
    }
}
