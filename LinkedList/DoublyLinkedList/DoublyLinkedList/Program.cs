namespace DoublyLinkedList
{
    public class Program
    {
        static void Main(string[] args)
        {
            var list = new LinkedList<int>();

            list.InsertLast(0);
            list.InsertLast(1);
            list.InsertLast(2);
            list.InsertLast(3);
            list.InsertAfter(2, 4);
            list.InsertBefore(3, 5);
            list.InsertFirst(4);
            list.Display();
            list.Delete(0);
            Console.WriteLine("-----------------------");
            list.Display();

            Console.WriteLine($"head : {list.head.data}");
            Console.WriteLine($"Tail : {list.tail.data}");

            Console.WriteLine($"Counter : {list.Counter}");
        }
    }
}
