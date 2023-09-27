namespace LoopTask1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = 62;
            int i = 1;
            while (i < num)
            {
                i *= 2;
            }
            if (i == num)
            {
                Console.WriteLine("Eded ikinin quvvetidir");
            }
            else
            {
                Console.WriteLine("Eded ikinin quvveti deyil");
            }
        }
    }
}