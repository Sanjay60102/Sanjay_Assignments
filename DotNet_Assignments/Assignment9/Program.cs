namespace Assignment9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 3, 2, 4, 5, 6, 7, 8, 9, 10, 11, 12,50 };
            var result = from k in arr
                         let m = k*k*k
                         where m > 100 && m < 1000
                         select k;
            foreach (var i in result)
            {
                Console.WriteLine(i);
            }
        }
    }
}