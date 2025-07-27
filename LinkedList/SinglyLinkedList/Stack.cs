namespace LinkedList
{
    public class Stack<T>
    {
        LinkedList<T> stack;
        public Stack()
        {
            stack = new LinkedList<T>();
        }

        public void Push(T data)
        {
            stack.InsertFirst(data);
        }

        public T Pop()
        {
            var top = stack.head.data;
            stack.DeleteFirst();
            return top;
        }
        public T Peek()
        {
            return stack.head.data;
        }

        public bool IsEmpty()
        {
            return stack.IsEmpty();
        }
        public void print()
        {
            stack.PrintList();
        }
        public int Size()
        {
            return stack.count;
        }
    }
}
