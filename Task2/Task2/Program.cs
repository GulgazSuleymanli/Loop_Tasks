namespace Task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = 5724;
            int a = 0;
            while (num>=1)
            {
                a = a * 10 + (num % 10);
                num = (num - num % 10) / 10;
            }
            Console.WriteLine(a);
        }
    }
}