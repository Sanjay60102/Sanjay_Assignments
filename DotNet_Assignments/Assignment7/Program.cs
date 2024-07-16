namespace Assignment7
{
    internal class Program
    {
        static void Main()
        {
            int[] numbers = new int[10];

            Console.WriteLine("Enter 10 numbers:");

            for (int i = 0; i < 10; i++)
            {
                Console.Write("Enter number {0}: ", i + 1);
                numbers[i] = int.Parse(Console.ReadLine());
            }

            Array.Sort(numbers);

            Console.WriteLine("\nSorted numbers in ascending order:");
            foreach (int number in numbers)
            {
                Console.WriteLine(number);
            }
        }
    }
}
