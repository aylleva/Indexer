namespace Arrayindexer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ListInt array = new ListInt(13, 15, 76, 89, 100, 54);

            //array.AddRange(24, 65, 46);
            //Console.WriteLine(array.Contains(100));

            //array.Remove(13);

            //array.RemoveRange(13, 15);

            array.Sum();
            Console.WriteLine(array.ToString());
            //for (int i = 0; i < array.Length; i++)
            //{
            //    Console.WriteLine(array[i]);
            //}
        }
    }
}