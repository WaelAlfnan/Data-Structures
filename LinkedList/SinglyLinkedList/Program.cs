namespace LinkedList
{
    public class Program
    {
        static void Main(string[] args)
        {

            #region Stack
            /*
             var stack = new Stack<int>();

            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            //stack.print();
            //Console.WriteLine($"Pop: {stack.Pop()}");
            //Console.WriteLine($"Size: {stack.Size()}");
            //stack.print();
            //Console.WriteLine($"peek: {stack.Peek()}");
            while (!stack.IsEmpty())
            {
                Console.WriteLine($"Pop: {stack.Pop()}");
                stack.print();
                Console.WriteLine($"Size: {stack.Size()}");
            }
            */
            #endregion

            #region Queue
            // Demonstration of Queue<T> using singly linked list
            var queue = new Queue<int>();

            // Enqueue elements
            queue.Enqueue(10);
            queue.Enqueue(20);
            queue.Enqueue(30);
            Console.WriteLine("Queue after enqueuing 10, 20, 30:");
            queue.Print();

            // Peek at the front element
            Console.WriteLine($"Peek: {queue.Peek()}"); // Should print 10

            // Dequeue elements
            Console.WriteLine($"Dequeue: {queue.Dequeue()}"); // Should remove 10
            Console.WriteLine("Queue after one dequeue:");
            queue.Print();

            // Check size and if empty
            Console.WriteLine($"Size: {queue.Size()}"); // Should print 2
            Console.WriteLine($"IsEmpty: {queue.IsEmpty()}"); // Should print False

            // Dequeue remaining elements
            Console.WriteLine($"Dequeue: {queue.Dequeue()}"); // Should remove 20
            Console.WriteLine($"Dequeue: {queue.Dequeue()}"); // Should remove 30
            Console.WriteLine($"IsEmpty after removing all: {queue.IsEmpty()}"); // Should print True

            // Console.WriteLine(queue.Dequeue());
            #endregion
        }
    }
}
