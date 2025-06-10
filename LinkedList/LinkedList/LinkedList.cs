
namespace LinkedList
{
    public class LinkedList<T>
    {
        public LinkedListNode<T> head = null;
        public LinkedListNode<T> tail = null;

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

            while(itr.Current().next != null) {
                if (Equals(itr.Current().next.data, data))
                {
                    return itr.Current();
                }
                itr.Next();
            }
            if( Equals(itr.Current().data, data))
            {
                return itr.Current();
            }

            return null;
        }
        public void InsertAfter(T InsertAfterThisData,T InsertedData)
        {
            if (head == null)
            {
                throw new InvalidOperationException("List is empty");
            }
            var parentNode = Find(InsertAfterThisData);
            if(parentNode == null)
            {
                throw new InvalidOperationException("Item not found");
            }
            else
            {
                var newNode = new LinkedListNode<T>(InsertedData);
                newNode.next = parentNode.next;
                parentNode.next = newNode;
                if (tail == parentNode)
                {
                    tail = newNode;
                }
            }
        }
        public void InsertBefore(T InsertBeforeThisData, T InsertedData)
        {
            if (head == null)
            {
                throw new InvalidOperationException("List is empty");
            }

            var newNode = new LinkedListNode<T>(InsertedData);
            var parentNode = FindParent(InsertBeforeThisData);

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
        }

        public void DeleteData(T data)
        {
            if (Find(data) == null)
                return;
            else
            {
                if (head == tail)
                    head = tail = null;
                else if (Equals(data, head.data) && head != tail)
                    head = head.next;
                else if(Equals(data, tail.data) && head != tail)
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
        }
    }
}
