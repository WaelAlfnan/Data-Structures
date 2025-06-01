namespace ResizeAndGetAll
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[3] { 1, 2, 3 };

            ArrayImplementations.ResizeArray<int>(ref arr, 10);

            string arrString = string.Join(", ", arr);
            Console.WriteLine(arrString);

            int item = ArrayImplementations.GetAt<int>(arr, 2, sizeof(int));
            Console.WriteLine(item);
            Console.WriteLine(arr[2]);
        }
    }
}
