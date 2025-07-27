
using System.Diagnostics.Metrics;

namespace LinkedList
{
    public class LinkedList<T>
    {
        public int count;
        public LinkedListNode<T> head = null;
        public LinkedListNode<T> tail = null;

        public bool IsEmpty()
        {
            return head == null;
        }
        public void InsertFirst(T data)
        {
            var newNode = new LinkedListNode<T>(data);
            if (IsEmpty())
            {
                head = tail = newNode;
            }
            else
            {
                newNode.next = head;
                head = newNode;
            }
            count++;
        }

        public LinkedListIterator<T> Begin()
        {
            var itr = new LinkedListIterator<T>(this.head);
            return itr;
        }

        public void PrintList()
        {
            for (var itr = this.Begin(); itr.Current() != null; itr.Next())
            {
                Console.Write(itr.Data() + " -> ");
            }
            Console.Write("\n");
        }
        public LinkedListNode<T>? Find(T _data)
        {


            for (var itr = this.Begin(); itr.Current() != null; itr.Next())
            {
                if (EqualityComparer<T>.Default.Equals(itr.Data(), _data))
                {
                    return itr.Current();
                }
            }
            return null;
        }
        public LinkedListNode<T>? FindParent(T data)
        {
            var itr = this.Begin();

            if (Equals(itr.Current().data, data))
            {
                return itr.Current();
            }

            while (itr.Current().next != null) {
                if (Equals(itr.Current().next.data, data))
                {
                    return itr.Current();
                }
                itr.Next();
            }
            

            return null;
        }

        public void InsertAfter(T InsertAfterThisData,T InsertedData)
        {
            var parentNode = Find(InsertAfterThisData);

            var newNode = new LinkedListNode<T>(InsertedData);
            if (parentNode == null)
            {
                tail.next = newNode;
                tail = newNode;
            }
            else
            {
                newNode.next = parentNode.next;
                parentNode.next = newNode;
                if (tail == parentNode)
                {
                    tail = newNode;
                }
            }
            count++;
        }
        public void InsertBefore(T InsertBeforeThisData, T InsertedData)
        {

            var parentNode = FindParent(InsertBeforeThisData);
            var newNode = new LinkedListNode<T>(InsertedData);
            if (parentNode == null)
            {
                newNode.next = head;
                head = newNode;
            }
            else
            {
                newNode.next = parentNode.next;
                parentNode.next = newNode;
            }
            count++;
        }
        public void InsertLast(T data)
        {
            var newNode = new LinkedListNode<T>(data);
            if (head == null)
            {
                head = newNode;
                tail = newNode;
            }
            else
            {
                tail.next = newNode;
                tail = newNode;
            }
            count++;
        }

        public void DeleteFirst()
        {
            if (IsEmpty()) return;
            head = head.next;
            count--;
        }
        public void DeleteData(T data)
        {
            if (Find(data) == null)
                return;
            else
            {
                if (head == tail)
                    head = tail = null;
                else if (Equals(data, head.data))
                    head = head.next;
                else if(Equals(data, tail.data))
                {
                    var parentNode = FindParent(data);
                    parentNode.next = tail.next;
                    tail = parentNode;
                }
                else
                {
                    var parentNode = FindParent(data);
                    parentNode.next = parentNode.next.next;
                }
            }
            count--;
        }

        
    }
}
