namespace LinkedList
{
    public class LinkedListNode<T>
    {
        public T? data {  get; set; }
        public LinkedListNode<T>? next;
        
        public LinkedListNode(T data)
        {
            this.data = data;
            next = null;
        }

    }
}
