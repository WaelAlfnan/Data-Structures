namespace Stack
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create a stack of integers
            var stack = new Stack<int>();

            Console.WriteLine("Pushing elements: 10, 20, 30");
            stack.Push(10);
            stack.Push(20);
            stack.Push(30);

            Console.WriteLine($"Current size: {stack.Size()}");
            Console.WriteLine($"Top element (Peek): {stack.Peek()}");

            Console.WriteLine($"Pop: {stack.Pop()}");
            Console.WriteLine($"Pop: {stack.Pop()}");

            Console.WriteLine($"Size after popping: {stack.Size()}");
            Console.WriteLine($"Is stack empty? {stack.IsEmpty()}");

            Console.WriteLine($"Pop: {stack.Pop()}");
            Console.WriteLine($"Is stack empty? {stack.IsEmpty()}");

            // Try popping from an empty stack (should throw exception)
            try
            {
                stack.Pop();
            }
            catch (InvalidOperationException ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }
    }
}
