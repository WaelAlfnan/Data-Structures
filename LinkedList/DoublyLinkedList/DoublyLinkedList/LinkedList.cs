
namespace DoublyLinkedList
{
    public class LinkedList<T>
    {
        public LinkedListNode<T> head;
        public LinkedListNode<T> tail;
        public int Counter { get; private set; }

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
                head.back = newNode;
                newNode.next = head;
                head = newNode;
            }
            Counter++;
        }
        public void InsertLast(T data)
        {

            if(IsEmpty())
            {
                InsertFirst(data);
            }
            else
            {
                var newNode = new LinkedListNode<T>(data);

                tail.next = newNode;
                newNode.back = tail;
                tail = newNode;

                Counter++;
            }
        }
       
        
        public LinkedListIterator<T> Begin()
        {
            var itr = new LinkedListIterator<T>(this.head);
            return itr;
        }
        public LinkedListNode<T>? FindNode(T? key)
        {
            for(var itr = Begin(); itr.Current() != null; itr.Next())
            {
                if(Equals(itr.Data(), key))
                {
                    return itr.Current();
                }
            }
            return null;
        }

        public void Display()
        {
            for (var itr = Begin(); itr.Current() != null; itr.Next())
            {
                
                Console.WriteLine(itr.Data());
            }
        }

        public void InsertAfter(T key, T data)
        {
            

            var parentNode = FindNode(key);
            if (IsEmpty() || parentNode == null)
            {
                InsertFirst(data);
            }
            else if(parentNode == tail)
            {
                InsertLast(data);
            }
            else
            {
                var newNode = new LinkedListNode<T>(data);
                newNode.next = parentNode.next;
                newNode.back = parentNode;

                parentNode.next.back = newNode;
                parentNode.next = newNode;

                Counter++;
            }
        }
        public void InsertBefore(T key, T data)
        {
            var childNode = FindNode(key);
            if(IsEmpty() || childNode == null || Equals(key, head.data))
            {
                InsertFirst(data);
            }
            else
            {
                var newNode = new LinkedListNode<T>(data);

                newNode.next = childNode;
                newNode.back = childNode.back;
                childNode.back.next = newNode;//todo: notice: this step must precedes the next step
                childNode.back = newNode;
                Counter++;
            }
        }
        public void Delete(T? data)
        {
            if (IsEmpty())
                return;
            if (head == tail)
                head = tail = null;
            else if (Equals(head.data, data))
            {
                head = head.next;
                head.back = null;
            }
            else if(Equals(tail.data, data))
            {
                tail = tail.back;
                tail.next = null;
            }
            else
            {
                var node = FindNode(data);

                node.back.next = node.next;
                node.next.back = node.back;
            }
            Counter--;
        }
    }
}
