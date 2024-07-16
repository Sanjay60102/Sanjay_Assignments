namespace Assignment8
{
    internal class Program
    {
        public static void Write(string path, string s)
        {
            File.AppendAllText(path, s);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Number of users");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter User Names");
            for (int i = 0; i < n; i++)
            {
                string s = $"{Console.ReadLine()}\n";
                Program.Write("D:/UserName.txt",s);

            }
        }
    }
}
