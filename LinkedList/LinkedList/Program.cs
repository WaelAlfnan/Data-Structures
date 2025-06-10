using System.Threading.Tasks.Dataflow;

namespace LinkedList
{
    public class Program
    {
        static void Main(string[] args)
        {
            var list = new LinkedList<int>();
            list.InsertLast(0);
            list.InsertLast(1);
            list.InsertLast(2);

            list.PrintList();

            list.InsertBefore(3, 4);
            list.PrintList();


            list.DeleteData(4);
            Console.WriteLine($"head: {list.head.data}");
            Console.WriteLine($"tail: {list.tail.data}");
            list.PrintList();
        }
    }
}
